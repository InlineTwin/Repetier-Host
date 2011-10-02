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
using System.IO;
using System.Windows.Forms;
using RepetierHost.model;
using RepetierHost.view;
using Microsoft.Win32;

namespace RepetierHost
{
    public partial class Main : Form
    {
        public static PrinterConnection conn;
        public static Main main;
        public static FormPrinterSettings printerSettings;
        public static ThreeDSettings threeDSettings;
        public static GlobalSettings globalSettings;
        private FormTempMonitor tempMonitor = null;
        public Skeinforge skeinforge = null;
        public EEPROMRepetier eepromSettings = null;
        public LogView logView = null;
        public PrintPanel printPanel = null;
        public RegistryKey repetierKey;
        public ThreeDControl jobPreview = null;
        public ThreeDControl printPreview = null;
        public GCodeVisual jobVisual = new GCodeVisual();
        public GCodeVisual printVisual = null;
        public static GCodeGenerator generator = null;
        public string basicTitle = "";
        public Main()
        {
            repetierKey = Registry.CurrentUser.CreateSubKey("Software\\Repetier");
            main = this;
            generator = new GCodeGenerator();
            globalSettings = new GlobalSettings();
            conn = new PrinterConnection();
            printerSettings = new FormPrinterSettings();
            threeDSettings = new ThreeDSettings();
            InitializeComponent();
            conn.eventConnectionChange += OnPrinterConnectionChange;
            conn.eventPrinterAction += OnPrinterAction;
            conn.eventJobProgress += OnJobProgress;
            printPanel = new PrintPanel();
            printPanel.Dock = DockStyle.Fill;
            splitContainerPrinterGraphic.Panel1.Controls.Add(printPanel);
            logView = new LogView();
            logView.Dock = DockStyle.Fill;
            splitVert.Panel2.Controls.Add(logView);
            skeinforge = new Skeinforge();
            PrinterChanged(printerSettings.currentPrinterKey,true);
            printerSettings.eventPrinterChanged += PrinterChanged;
            // GCode print preview
            printPreview = new ThreeDControl();
            printPreview.Dock = DockStyle.Fill;
            splitContainerPrinterGraphic.Panel2.Controls.Add(printPreview);
            printPreview.SetEditor(false);
            printPreview.AutoUpdateable = true;
            printVisual = new GCodeVisual(conn.analyzer);
            printPreview.models.AddLast(printVisual);
            basicTitle = Text;
        }
        public void PrinterChanged(RegistryKey pkey,bool printerChanged)
        {
            if (printerChanged)
            {
                textGCodePrepend.Text = (string)pkey.GetValue("gcodePrepend", textGCodePrepend.Text);
                textGCodeAppend.Text = (string)pkey.GetValue("gcodeAppend", textGCodeAppend.Text);
            }
        }
        public string Title
        {
            set { Text = basicTitle + " - " + value; }
            get { return Text; }
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OnPrinterConnectionChange(string msg) {
            toolConnection.Text = msg;
        }
        private void OnPrinterAction(string msg)
        {
            toolAction.Text = msg;
        }
        private void OnJobProgress(float per)
        {
            toolProgress.Value = (int)per;
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eepromSettings == null)
                eepromSettings = new EEPROMRepetier();
            eepromSettings.Show2();
        }

        private void toolGCodeLoad_Click(object sender, EventArgs e)
        {
            if (openGCode.ShowDialog() == DialogResult.OK)
            {
                FileInfo f = new FileInfo(openGCode.FileName);
                Title = f.Name;
                if (openGCode.FileName.EndsWith(".stl"))
                {
                    skeinforge.RunSlice(openGCode.FileName); // Slice it and load
                }
                else
                {
                    textGCode.Text = System.IO.File.ReadAllText(openGCode.FileName);
                    tab.SelectTab(tabGCode);
                    tabGCodes.SelectedTab = tabPageGCode;
                }
            }
        }
        public void LoadGCode(string file)
        {
            try
            {
                textGCode.Text = System.IO.File.ReadAllText(file);
                tab.SelectTab(tabGCode);
                tabGCodes.SelectedTab = tabPageGCode;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadGCodeText(string text)
        {
            try
            {
                textGCode.Text = text;
                tab.SelectTab(tabGCode);
                tabGCodes.SelectedTab = tabPageGCode;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolPrintJob_Click(object sender, EventArgs e)
        {
            Printjob job = conn.job;
            job.BeginJob();
            job.PushData(textGCodePrepend.Text);
            job.PushData(textGCode.Text);
            job.PushData(textGCodeAppend.Text);
            job.EndJob();
        }

        private void textGCode_CursorChanged()
        {
            TextBox act = null;
            if (tabGCodes.SelectedTab == tabPageGCode)
                act = textGCode;
            else if (tabGCodes.SelectedTab == tabPagePrepend)
                act = textGCodePrepend;
            else
                act = textGCodeAppend;
            Point p = act.GetPositionFromCharIndex(act.SelectionStart);
            toolGCodeCol.Text = "Col " + (act.SelectionStart - act.GetFirstCharIndexOfCurrentLine() + 1);
            toolGCodeRow.Text = "Row " + (act.GetLineFromCharIndex(act.SelectionStart) + 1);
        }

        private void textGCode_Key(object sender, KeyEventArgs e)
        {
            textGCode_CursorChanged();
        }

        private void textGCode_Enter(object sender, EventArgs e)
        {
            textGCode_CursorChanged();
        }

        private void toolKillJob_Click(object sender, EventArgs e)
        {
            conn.job.KillJob();
        }

        private void printerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerSettings.ShowDialog();
        }

        private void textGCode_Click(object sender, EventArgs e)
        {
            textGCode_CursorChanged();
        }

        private void textGCodePrepend_Click(object sender, EventArgs e)
        {
            textGCode_CursorChanged();
        }

        private void textGCodeAppend_Click(object sender, EventArgs e)
        {
            textGCode_CursorChanged();
        }

        private void temperatureMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tempMonitor == null)
                tempMonitor = new FormTempMonitor();
            tempMonitor.Show();
        }

        private void skeinforgeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skeinforge.Show();
        }

        private void skeinforgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skeinforge.RunSkeinforge();
        }

        private void threeDSettingsMenu_Click(object sender, EventArgs e)
        {
            threeDSettings.Show();
        }
        private PrinterInfo printerInfo = null;
        private void printerInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printerInfo == null)
                printerInfo = new PrinterInfo();
            printerInfo.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Destroy();
        }

        private void repetierSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalSettings.Show(this);
        }
        public About about = null;
        private void aboutRepetierHostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (about == null) about = new About();
            about.Show(this);
        }

        private void jobStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobStatus.ShowStatus();
        }
        public void openLink(string link)
        {
            try
            {
                System.Diagnostics.Process.Start(link);
            }
            catch
            (
            System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
        private void repetierHostHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openLink("https://github.com/repetier/Repetier-Host");
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openLink("https://github.com/repetier/Repetier-Host/wiki");
        }

        public MethodInvoker UpdateJobButtons = delegate
        {
            if (conn.job.mode != 1)
            {
                Main.main.toolRunJob.Enabled = conn.connected;
                Main.main.toolKillJob.Enabled = false;
            }
            else
            {
                Main.main.toolRunJob.Enabled = false;
                Main.main.toolKillJob.Enabled = true;
                Main.main.printVisual.Clear();
            }
        };

        private void toolStripSaveGCode_Click(object sender, EventArgs e)
        {
            if (saveJobDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveJobDialog.FileName, textGCode.Text, Encoding.Default);
            }
        }

        private void toolStripSavePrepend_Click(object sender, EventArgs e)
        {
            printerSettings.currentPrinterKey.SetValue("gcodePrepend", textGCodePrepend.Text);
        }

        private void toolStripSaveAppend_Click(object sender, EventArgs e)
        {
            printerSettings.currentPrinterKey.SetValue("gcodeAppend", textGCodeAppend.Text);
        }
        private void toolStripJobPreview_Click(object sender, EventArgs e)
        {
            if (splitJob.Panel2Collapsed)
            {
                splitJob.Panel2Collapsed = false;
                splitJob.SplitterDistance = 300;
                jobPreview = new ThreeDControl();
                jobPreview.Dock = DockStyle.Fill;
                splitJob.Panel2.Controls.Add(jobPreview);
                jobPreview.SetEditor(false);
                jobPreview.models.AddLast(jobVisual);
                //jobPreview.SetObjectSelected(false);
            }
            jobVisual.ParseText(textGCodePrepend.Text, true);
            jobVisual.ParseText(textGCode.Text, false);
            jobVisual.ParseText(textGCodeAppend.Text, false);
            jobPreview.UpdateChanges();
        }
        public void Update3D()
        {
            if (tab == null) return;
            switch (tab.SelectedIndex)
            {
                case 0:
                    printPreview.UpdateChanges();
                    break;
                case 1:
                    if (jobPreview != null)
                        jobPreview.UpdateChanges();
                    break;
                case 2:
                    stlComposer1.Update3D();
                    break;
            }
        }

        private void testCaseGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestGenerator.Execute();
        }

        private void internalSlicingParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SlicingParameter.Execute();
        }
    }
}
