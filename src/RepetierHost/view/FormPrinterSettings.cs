/*
   Copyright 2011 repetier repetierdev@googlemail.com

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using Microsoft.Win32;
using RepetierHost.model;
using System.Globalization;

namespace RepetierHost.view
{
    public delegate void PrinterChanged(RegistryKey printerKey,bool printerChanged);
    public partial class FormPrinterSettings : Form
    {
        public event PrinterChanged eventPrinterChanged;
        public RegistryKey repetierKey;
        public RegistryKey printerKey;
        public RegistryKey currentPrinterKey;
        public PrinterConnection con;
        public float PrintAreaWidth;
        public float PrintAreaDepth;
        public float PrintAreaHeight;
        public bool HasDumpArea;
        public float DumpAreaLeft;
        public float DumpAreaFront;
        public float DumpAreaWidth;
        public float DumpAreaDepth;
        public FormPrinterSettings()
        {
            InitializeComponent();
            repetierKey = Registry.CurrentUser.CreateSubKey("Software\\Repetier");
            printerKey = repetierKey.CreateSubKey("printer");
            con = Main.conn;
            conToForm();
            comboPrinter.Items.Clear();
            foreach (string s in printerKey.GetSubKeyNames())
                comboPrinter.Items.Add(s);
            con.printerName = (string)repetierKey.GetValue("currentPrinter", "default");
            load(con.printerName);
            formToCon();
            UpdateDimensions();
        }
        public void save(string printername)
        {
            if (printername.Length == 0) return;
            RegistryKey p = printerKey.CreateSubKey(printername);
            currentPrinterKey = p;
            p.SetValue("port", comboPort.Text);
            p.SetValue("baud", comboBaud.Text);
            p.SetValue("stopbits", comboStopbits.SelectedIndex);
            p.SetValue("parity", comboParity.SelectedIndex);
            p.SetValue("transferProtocol", comboTransferProtocol.SelectedIndex);
            p.SetValue("travelFeedrate", textTravelFeedrate.Text);
            p.SetValue("zAxisFeedrate", textZFeedrate.Text);
            p.SetValue("checkTemp", checkTemp.Checked ? 1 : 0);
            p.SetValue("pingPong", checkPingPong.Checked ? 1 : 0);
            p.SetValue("checkTempInterval", trackTempPeriod.Value);
            p.SetValue("disposeX", textDisposeX.Text);
            p.SetValue("disposeY", textDisposeY.Text);
            p.SetValue("disposeZ", textDisposeZ.Text);
            p.SetValue("goDisposeAfterJob", checkGoDisposeAfterJob.Checked ? 1 : 0);
            p.SetValue("disableHeatedBetAfterJob", checkDisbaleHeatedBedAfterJob.Checked ? 1 : 0);
            p.SetValue("disableExtruderAfterJob", checkDisableExtruderAfterJob.Checked ? 1 : 0);
            p.SetValue("receiveCacheSize", textReceiveCacheSize.Text);
            p.SetValue("printAreaWidth", textPrintAreaWidth.Text);
            p.SetValue("printAreaDepth", textPrintAreaDepth.Text);
            p.SetValue("printAreaHeight", textPrintAreaHeight.Text);
            p.SetValue("hasDumpArea", checkHasDumpArea.Checked ? 1 : 0);
            p.SetValue("dumpAreaLeft", textDumpAreaLeft.Text);
            p.SetValue("dumpAreaFront", textDumpAreaFront.Text);
            p.SetValue("dumpAreaWidth", textDumpAreaWidth.Text);
            p.SetValue("dumpAreaDepth", textDumpAreaDepth.Text);
        }
        public void load(string printername)
        {
            if (printername.Length == 0) return;
            comboPrinter.Text = printername;
            RegistryKey p = printerKey.CreateSubKey(printername);
            currentPrinterKey = p;
            comboPort.Text = (string)p.GetValue("port", comboPort.Text);
            comboBaud.Text = (string)p.GetValue("baud",comboBaud.Text);
            comboStopbits.SelectedIndex = (int)p.GetValue("stopbits",comboStopbits.SelectedIndex);
            comboParity.SelectedIndex = (int)p.GetValue("parity",comboParity.SelectedIndex);
            comboTransferProtocol.SelectedIndex = (int)p.GetValue("transferProtocol", comboTransferProtocol.SelectedIndex);
            textTravelFeedrate.Text = (string)p.GetValue("travelFeedrate",textTravelFeedrate.Text);
            textZFeedrate.Text = (string)p.GetValue("zAxisFeedrate",textZFeedrate.Text);
            checkTemp.Checked = ((int)p.GetValue("checkTemp", checkTemp.Checked ? 1 : 0))==1?true:false;
            checkPingPong.Checked = ((int)p.GetValue("pingPong", checkPingPong.Checked ? 1 : 0)) == 1 ? true : false;
            trackTempPeriod.Value = (int)p.GetValue("checkTempInterval", trackTempPeriod.Value);
            textDisposeX.Text = (string)p.GetValue("disposeX", textDisposeX.Text);
            textDisposeY.Text = (string)p.GetValue("disposeY", textDisposeY.Text);
            textDisposeZ.Text = (string)p.GetValue("disposeZ", textDisposeZ.Text);
            checkGoDisposeAfterJob.Checked = 1 == (int)p.GetValue("goDisposeAfterJob", checkGoDisposeAfterJob.Checked ? 1 : 0);
            checkDisbaleHeatedBedAfterJob.Checked = 1 == (int)p.GetValue("disableHeatedBetAfterJob", checkDisbaleHeatedBedAfterJob.Checked ? 1 : 0);
            checkDisableExtruderAfterJob.Checked = 1 == (int)p.GetValue("disableExtruderAfterJob", checkDisableExtruderAfterJob.Checked ? 1 : 0);
            labelCheckInterval.Text = trackTempPeriod.Value.ToString();
            textReceiveCacheSize.Text = (string)p.GetValue("receiveCacheSize", textReceiveCacheSize.Text);
            textPrintAreaWidth.Text = (string)p.GetValue("printAreaWidth", textPrintAreaWidth.Text);
            textPrintAreaDepth.Text = (string)p.GetValue("printAreaDepth", textPrintAreaDepth.Text);
            textPrintAreaHeight.Text = (string)p.GetValue("printAreaHeight", textPrintAreaHeight.Text);
            checkHasDumpArea.Checked = 1==(int)p.GetValue("hasDumpArea", checkHasDumpArea.Checked ? 1 : 0);
            textDumpAreaLeft.Text = (string)p.GetValue("dumpAreaLeft", textDumpAreaLeft.Text);
            textDumpAreaFront.Text = (string)p.GetValue("dumpAreaFront", textDumpAreaFront.Text);
            textDumpAreaWidth.Text = (string)p.GetValue("dumpAreaWidth", textDumpAreaWidth.Text);
            textDumpAreaDepth.Text = (string)p.GetValue("dumpAreaDepth", textDumpAreaDepth.Text);

        }
        public void UpdateDimensions()
        {
            float.TryParse(textPrintAreaWidth.Text, NumberStyles.Float, GCode.format, out PrintAreaWidth);
            float.TryParse(textPrintAreaHeight.Text, NumberStyles.Float, GCode.format, out PrintAreaHeight);
            float.TryParse(textPrintAreaDepth.Text, NumberStyles.Float, GCode.format, out PrintAreaDepth);
            float.TryParse(textDumpAreaDepth.Text, NumberStyles.Float, GCode.format, out DumpAreaDepth);
            float.TryParse(textDumpAreaWidth.Text, NumberStyles.Float, GCode.format, out DumpAreaWidth);
            float.TryParse(textDumpAreaLeft.Text, NumberStyles.Float, GCode.format, out DumpAreaLeft);
            float.TryParse(textDumpAreaFront.Text, NumberStyles.Float, GCode.format, out DumpAreaFront);
            HasDumpArea = checkHasDumpArea.Checked;
        }
        public void formToCon()
        {
            bool pnchanged = !con.printerName.Equals(comboPrinter.Text);
            con.printerName = comboPrinter.Text;
            con.port = comboPort.Text;
            con.baud = int.Parse(comboBaud.Text);
            con.transferProtocol = comboTransferProtocol.SelectedIndex;
            switch (comboStopbits.SelectedIndex)
            {
                case 0: con.stopbits = StopBits.None; break;
                case 1: con.stopbits = StopBits.One; break;
                case 2: con.stopbits = StopBits.Two; break;
            }
            switch (comboParity.SelectedIndex)
            {
                case 0: con.parity = Parity.None; break;
                case 1: con.parity = Parity.Even; break;
                case 2: con.parity = Parity.Odd; break;
                case 3: con.parity = Parity.Mark; break;
                case 4: con.parity = Parity.Space; break;
            }
            float.TryParse(textTravelFeedrate.Text, out con.travelFeedRate);
            float.TryParse(textZFeedrate.Text, out con.maxZFeedRate);
            con.autocheckTemp = checkTemp.Checked;
            con.pingpong = checkPingPong.Checked;
            con.autocheckInterval = trackTempPeriod.Value*1000;
            float.TryParse(textDisposeX.Text, NumberStyles.Float, GCode.format, out con.disposeX);
            float.TryParse(textDisposeY.Text, NumberStyles.Float, GCode.format, out con.disposeY);
            float.TryParse(textDisposeZ.Text, NumberStyles.Float, GCode.format, out con.disposeZ);
            con.afterJobGoDispose = checkGoDisposeAfterJob.Checked;
            con.afterJobDisableExtruder = checkDisableExtruderAfterJob.Checked;
            con.afterJobDisablePrintbed = checkDisbaleHeatedBedAfterJob.Checked;
            int.TryParse(textReceiveCacheSize.Text, out con.receiveCacheSize);
            if (eventPrinterChanged != null)
                eventPrinterChanged(currentPrinterKey,pnchanged);
        }
        public void conToForm()
        {
            comboPrinter.Text = con.printerName;
            comboBaud.Text = con.baud.ToString();
            comboPort.Text = con.port;
            comboTransferProtocol.SelectedIndex = con.transferProtocol;
            switch (con.stopbits)
            {
                case StopBits.None: comboStopbits.SelectedIndex = 0; break;
                case StopBits.One: comboStopbits.SelectedIndex = 1; break;
                case StopBits.Two: comboStopbits.SelectedIndex = 2; break;
            }
            switch (con.parity)
            {
                case Parity.None: comboParity.SelectedIndex = 0; break;
                case Parity.Even: comboParity.SelectedIndex = 1; break;
                case Parity.Odd: comboParity.SelectedIndex = 2; break;
                case Parity.Mark: comboParity.SelectedIndex = 3; break;
                case Parity.Space: comboParity.SelectedIndex = 4; break;
            }
            textTravelFeedrate.Text = con.travelFeedRate.ToString(GCode.format);
            textZFeedrate.Text = con.maxZFeedRate.ToString(GCode.format);
            checkTemp.Checked = con.autocheckTemp;
            checkPingPong.Checked = con.pingpong;
            trackTempPeriod.Value = (int)(con.autocheckInterval/1000);
            textDisposeX.Text = con.disposeX.ToString(GCode.format);
            textDisposeY.Text = con.disposeY.ToString(GCode.format);
            textDisposeZ.Text = con.disposeZ.ToString(GCode.format);
            checkGoDisposeAfterJob.Checked = con.afterJobGoDispose;
            checkDisableExtruderAfterJob.Checked = con.afterJobDisableExtruder;
            checkDisbaleHeatedBedAfterJob.Checked = con.afterJobDisablePrintbed;
            labelCheckInterval.Text = trackTempPeriod.Value.ToString();
            textReceiveCacheSize.Text = con.receiveCacheSize.ToString();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            buttonApply_Click(null, null);
            formToCon();
            UpdateDimensions();
            Hide();
            Main.main.Update3D();
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            load(con.printerName);
            UpdateDimensions();
            Hide();
            Main.main.Update3D();
        }

        private void FormPrinterSettings_Shown(object sender, EventArgs e)
        {
            comboPort.Items.Clear();
            foreach (string p in SerialPort.GetPortNames())
            {
                comboPort.Items.Add(p);
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            string name = comboPrinter.Text;
            if(name.Length==0) return;
            save(comboPrinter.Text);
            if (comboPrinter.Items.IndexOf(name) < 0)
            {
                comboPrinter.Items.Add(name);
                comboPrinter.SelectedIndex = comboPrinter.Items.IndexOf(name);
            }
            Main.main.Update3D();
        }

        private void comboPrinter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPrinter.SelectedIndex < 0) return;
            load(comboPrinter.Text);
            formToCon();
            repetierKey.SetValue("currentPrinter", comboPrinter.Text);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Di you realy want to delete all settings for " + comboPrinter.Text, "Security question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string name = comboPrinter.Text;
                printerKey.DeleteSubKeyTree(comboPrinter.Text);
                comboPrinter.Items.Remove(name);
                comboPrinter.Text = "";
                if(comboPrinter.Items.Count>0)
                    comboPrinter.SelectedIndex = 0;
            }
        }

        private void trackTempPeriod_ValueChanged(object sender, EventArgs e)
        {
            labelCheckInterval.Text = trackTempPeriod.Value.ToString();
        }

        private void float_Validating(object sender, CancelEventArgs e)
        {
            TextBox box = (TextBox)sender;
            try
            {
                float.Parse(box.Text);
                errorProvider.SetError(box, "");
            }
            catch
            {
                errorProvider.SetError(box, "Not a number.");
            }
        }
    }
}
