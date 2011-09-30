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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RepetierHost.model;

namespace RepetierHost.view
{
    public partial class PrintPanel : UserControl
    {
        PrinterConnection con;
        GCodeAnalyzer ann;
        LinkedList<string> commands = new LinkedList<string>();
        int commandPos = 0;
        bool createCommands = true;
        public PrintPanel()
        {
            InitializeComponent();
            con = Main.conn;
            ann = con.analyzer;
            con.eventConnectionChange += ConnectionChanged;
            con.eventTempChange += tempUpdate;
            ann.eventPosChanged += coordUpdate;
            ann.eventChange += analyzerChange;
            UpdateConStatus(false);
            float volt = 100f * trackFanVoltage.Value / 255;
            labelVoltage.Text = "Output " + volt.ToString("0.0") + "%";
        }
        public void ConnectionChanged(string msg) {
            UpdateConStatus(Main.conn.serial != null);
        }
        private void tempUpdate(int extruder, int printbed)
        {
            labelExtruderTemp.Text = extruder.ToString() + "°C";
            labelPrintbedTemp.Text = printbed.ToString() + "°C";
        }
        private void analyzerChange() {
            createCommands = false;
            if (ann.extruderTemp > 0)
                textExtruderSetTemp.Text = ann.extruderTemp.ToString();
            if (ann.bedTemp > 0)
                textPrintbedTemp.Text = ann.bedTemp.ToString();
            switchExtruderHeatOn.On = ann.extruderTemp > 0;
            switchFanOn.On = ann.fanOn;
            trackFanVoltage.Value = ann.fanVoltage;
            switchBedHeat.On = ann.bedTemp > 0;
            switchPower.On = ann.powerOn;
            createCommands = true;
        }
        private void coordUpdate(GCode code,float x,float y,float z) {
            labelX.Text = "X=" + x.ToString("0.00");
            labelY.Text = "Y=" + y.ToString("0.00");
            labelZ.Text = "Z=" + z.ToString("0.00");
        }
        private void UpdateConStatus(bool c)
        {
            Main.main.toolRunJob.Enabled = c;
            switchConnect.On = c;
            switchBedHeat.Enabled = c;
            switchFanOn.Enabled = c;
            switchExtruderHeatOn.Enabled = c;
            buttonExtruderSetTemp.Enabled = c;
            buttonExtrude.Enabled = c;
            buttonPrintbedSendTemp.Enabled = c;
            buttonSend.Enabled = c;
            buttonHomeAll.Enabled = c;
            buttonHomeX.Enabled = c;
            buttonHomeY.Enabled = c;
            buttonHomeZ.Enabled = c;
            buttonXM01.Enabled = c;
            buttonXM1.Enabled = c;
            buttonXM10.Enabled = c;
            buttonXM100.Enabled = c;
            buttonXP01.Enabled = c;
            buttonXP1.Enabled = c;
            buttonXP10.Enabled = c;
            buttonXP100.Enabled = c;
            buttonYM01.Enabled = c;
            buttonYM1.Enabled = c;
            buttonYM10.Enabled = c;
            buttonYM100.Enabled = c;
            buttonYP01.Enabled = c;
            buttonYP1.Enabled = c;
            buttonYP10.Enabled = c;
            buttonYP100.Enabled = c;
            buttonZM01.Enabled = c;
            buttonZM1.Enabled = c;
            buttonZM10.Enabled = c;
            buttonZM100.Enabled = c;
            buttonZP01.Enabled = c;
            buttonZP1.Enabled = c;
            buttonZP10.Enabled = c;
            buttonZP100.Enabled = c;
            buttonStopMotor.Enabled = c;
            switchPower.Enabled = c;
            switchExtruderReverse.Enabled = c;
            switchEcho.Enabled = c;
            switchInfo.Enabled = c;
            switchDryRun.Enabled = c;
            switchErrors.Enabled = c;
            buttonGoDisposeArea.Enabled = c;
            buttonSimulateOK.Enabled = c;
            buttonJobStatus.Enabled = c;
            if (c) sendDebug();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textGCode.Text.Length < 2) return;
            con.injectManualCommand(textGCode.Text);
            commands.AddLast(textGCode.Text);
            if (commands.Count > 100)
                commands.RemoveFirst();
            commandPos = commands.Count;
            textGCode.Text = "";
        }

        private void switchConnect_Changed(SwitchButton b)
        {
            if (switchConnect.On) con.open(); else con.close();
        }
        private void sendDebug()
        {
            if (con.serial == null) return;
            int v = 0;
            if (switchEcho.On) v += 1;
            if (switchInfo.On) v += 2;
            if (switchErrors.On) v += 4;
            if (switchDryRun.On) v += 8;
            con.GetInjectLock();
            con.injectManualCommand("M111 S" + v);
            con.ReturnInjectLock();
        }

        private void buttonHomeX_Click(object sender, EventArgs e)
        {
            con.GetInjectLock();
            con.injectManualCommand("G28 X0");
            con.ReturnInjectLock();
        }

        private void buttonHomeY_Click(object sender, EventArgs e)
        {
            con.GetInjectLock();
            con.injectManualCommand("G28 Y0");
            con.ReturnInjectLock();
        }

        private void buttonHomeZ_Click(object sender, EventArgs e)
        {
            con.GetInjectLock();
            con.injectManualCommand("G28 Z0");
            con.ReturnInjectLock();
        }

        private void buttonHomeAll_Click(object sender, EventArgs e)
        {
            con.GetInjectLock();
            con.injectManualCommand("G28 X0 Y0 Z0");
            con.ReturnInjectLock();
        }
        private void moveHead(string axis,float amount) {
            con.GetInjectLock();
            bool wasrel = con.analyzer.relative;
            //if(!wasrel) 
                con.injectManualCommand("G91");
            if(axis.Equals("Z"))
                con.injectManualCommand("G1 " + axis + amount.ToString(GCode.format) + " F" + con.maxZFeedRate.ToString(GCode.format));
            else
                con.injectManualCommand("G1 " + axis + amount.ToString(GCode.format) + " F" + con.travelFeedRate.ToString(GCode.format));
            //if (!wasrel) 
                con.injectManualCommand("G90");
            con.ReturnInjectLock();
        }

        private void buttonXM100_Click(object sender, EventArgs e)
        {
            moveHead("X", -100);
        }

        private void buttonXM10_Click(object sender, EventArgs e)
        {
            moveHead("X", -10);
        }

        private void buttonXM1_Click(object sender, EventArgs e)
        {
            moveHead("X", -1);
        }

        private void buttonXM01_Click(object sender, EventArgs e)
        {
            moveHead("X", -0.1f);
        }

        private void buttonXP01_Click(object sender, EventArgs e)
        {
            moveHead("X", 0.1f);
        }

        private void buttonXP1_Click(object sender, EventArgs e)
        {
            moveHead("X", 1);
        }

        private void buttonXP10_Click(object sender, EventArgs e)
        {
            moveHead("X", 10);
        }

        private void buttonXP100_Click(object sender, EventArgs e)
        {
            moveHead("X", 100);
        }

        private void buttonYM100_Click(object sender, EventArgs e)
        {
            moveHead("Y", -100);
        }

        private void buttonYM10_Click(object sender, EventArgs e)
        {
            moveHead("Y", -10);
        }

        private void buttonYM1_Click(object sender, EventArgs e)
        {
            moveHead("Y", -1);
        }

        private void buttonYM01_Click(object sender, EventArgs e)
        {
            moveHead("Y", -0.1f);
        }

        private void buttonYP01_Click(object sender, EventArgs e)
        {
            moveHead("Y", 0.1f);
        }

        private void buttonYP1_Click(object sender, EventArgs e)
        {
            moveHead("Y", 1);
        }

        private void buttonYP10_Click(object sender, EventArgs e)
        {
            moveHead("Y", 10);
        }

        private void buttonYP100_Click(object sender, EventArgs e)
        {
            moveHead("Y", 100);
        }

        private void buttonZM100_Click(object sender, EventArgs e)
        {
            moveHead("Z", -100);
        }

        private void buttonZM10_Click(object sender, EventArgs e)
        {
            moveHead("Z", -10);
        }

        private void buttonZM1_Click(object sender, EventArgs e)
        {
            moveHead("Z", -1);
        }

        private void buttonZM01_Click(object sender, EventArgs e)
        {
            moveHead("Z", -0.1f);
        }

        private void buttonZP01_Click(object sender, EventArgs e)
        {
            moveHead("Z", 0.1f);
        }

        private void buttonZP1_Click(object sender, EventArgs e)
        {
            moveHead("Z", 1);
        }

        private void buttonZP10_Click(object sender, EventArgs e)
        {
            moveHead("Z", 10);
        }

        private void buttonZP100_Click(object sender, EventArgs e)
        {
            moveHead("Z", 100);
        }

        private void switchFanOn_Change(SwitchButton b)
        {
            if (Main.conn.connected == false) return;
            if (!createCommands) return;
            con.GetInjectLock();
            if (switchFanOn.On)
            {
                con.injectManualCommand("M106 S" + trackFanVoltage.Value);
            }
            else
            {
                con.injectManualCommand("M107");
            }
            con.ReturnInjectLock();
        }

        private void trackFanVoltage_ValueChanged(object sender, EventArgs e)
        {
            float volt = 100f*trackFanVoltage.Value/255;
            labelVoltage.Text = "Output " + volt.ToString("0.0") + "%";
            if (!createCommands) return;
            switchFanOn_Change(null);
        }

        private void trackExtruderSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelExtruderSpeed.Text = trackExtruderSpeed.Value.ToString();
        }

        private void trackExtruderLength_ValueChanged(object sender, EventArgs e)
        {
            labelExtruderLength.Text = trackExtruderLength.Value.ToString();
        }

        private void buttonExtrude_Click(object sender, EventArgs e)
        {
            int dir = 1;
            if (switchExtruderReverse.On) dir = -1;
            con.GetInjectLock();
            bool wasrel = con.analyzer.relative;
            if (!wasrel) con.injectManualCommand("G91");
            con.injectManualCommand("G1 E" + dir*trackExtruderLength.Value + " F"+trackExtruderSpeed.Value);
            if (!wasrel) con.injectManualCommand("G90");
            con.ReturnInjectLock();
        }

        private void switchExtruderHeatOn_Change(SwitchButton b)
        {
            if (Main.conn.connected == false) return;
            if (!createCommands) return;
            int temp = 0;
            int.TryParse(textExtruderSetTemp.Text,out temp);
            con.GetInjectLock();
            if (switchExtruderHeatOn.On)
            {
                con.injectManualCommand("M104 S" + temp);
            }
            else
            {
                con.injectManualCommand("M104 S0");
            }
            con.ReturnInjectLock();
        }

        private void buttonExtruderSetTemp_Click(object sender, EventArgs e)
        {
            int temp = 0;
            int.TryParse(textExtruderSetTemp.Text, out temp);
            if (switchExtruderHeatOn.On)
            {
                con.GetInjectLock();
                con.injectManualCommand("M104 S" + temp);
                con.ReturnInjectLock();
            }
        }

        private void switchBedHeat_Change(SwitchButton b)
        {
            if (Main.conn.connected == false) return;
            if (!createCommands) return;
            int temp = 0;
            int.TryParse(textPrintbedTemp.Text, out temp);
            con.GetInjectLock();
            if (switchBedHeat.On)
            {
                con.injectManualCommand("M140 S" + temp);
            }
            else
            {
                con.injectManualCommand("M140 S0");
            }
            con.ReturnInjectLock();
        }

        private void buttonPrintbedSendTemp_Click(object sender, EventArgs e)
        {
            int temp = 0;
            int.TryParse(textPrintbedTemp.Text, out temp);
            if (switchBedHeat.On)
            {
                con.GetInjectLock();
                con.injectManualCommand("M140 S" + temp);
                con.ReturnInjectLock();
            }
        }

        private void switchEcho_Change(SwitchButton b)
        {
            sendDebug();
        }

        private void switchInfo_Change(SwitchButton b)
        {
            sendDebug();
        }

        private void switchErrors_Change(SwitchButton b)
        {
            sendDebug();
        }

        private void switchDryRun_Change(SwitchButton b)
        {
            sendDebug();
        }

        private void switchPower_Change(SwitchButton b)
        {
            if (Main.conn.connected == false) return;
            con.GetInjectLock();
            if (switchPower.On)
            {
                con.injectManualCommand("M80");
            }
            else
            {
                con.injectManualCommand("M81");
            }
            con.ReturnInjectLock();
        }

        private void textGCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                buttonSend_Click(null, null);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                commandPos--;
                if (commandPos < 0) commandPos = 0;
                if (commandPos < commands.Count)
                    textGCode.Text = commands.ElementAt(commandPos);
                textGCode.SelectionLength = 0;
                textGCode.SelectionStart = textGCode.Text.Length;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                commandPos++;
                if (commandPos > commands.Count)
                    commandPos = commands.Count;
                if (commandPos < commands.Count)
                    textGCode.Text = commands.ElementAt(commandPos);
                textGCode.SelectionLength = 0;
                textGCode.SelectionStart = textGCode.Text.Length;
                e.Handled = true;
            }
        }

        private void buttonGoDisposeArea_Click(object sender, EventArgs e)
        {
            con.doDispose();
        }

        private void buttonSimulateOK_Click(object sender, EventArgs e)
        {
            con.analyzeResponse("ok");
        }

        private void buttonJobStatus_Click(object sender, EventArgs e)
        {
            JobStatus.ShowStatus();
        }

        private void textGCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar == '\r')
                    e.Handled = true;
            }
        }

        private void buttonStopMotor_Click(object sender, EventArgs e)
        {
            con.injectManualCommand("M84");
        }
    }
}
