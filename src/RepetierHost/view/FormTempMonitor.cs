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
using RepetierHost.GraphLib;
using RepetierHost.model;

namespace RepetierHost.view
{
    public partial class FormTempMonitor : Form
    {
        DataSource source;
        DataSource target;
        DataSource output;
        float left = 0;
        public FormTempMonitor()
        {
            InitializeComponent();
            this.SuspendLayout();
            comboMonitor.SelectedIndex = 0;
            source = new DataSource();
            source.AutoScaleY = true;
            source.AutoScaleX = false;
            source.Name = "Temperature";
            source.OnRenderXAxisLabel += RenderXLabel;
            source.OnRenderYAxisLabel += RenderYLabel;
            source.SetDisplayRangeY(0, 300);
            source.SetGridDistanceY(10);
            source.SetGridOriginY(20);
            source.GraphColor = Color.Red;

            target = new DataSource();
            target.AutoScaleY = true;
            target.AutoScaleX = false;
            target.Name = "Target temp.";
            target.OnRenderXAxisLabel += RenderXLabel;
            target.OnRenderYAxisLabel += RenderYLabel;
            target.SetDisplayRangeY(0, 300);
            target.SetGridDistanceY(10);
            target.SetGridOriginY(20);
            target.GraphColor = Color.Blue;
            target.Active = false; // only show when requested

            output = new DataSource();
            output.AutoScaleY = true;
            output.AutoScaleX = false;
            output.Name = "Output";
            output.OnRenderXAxisLabel += RenderXLabel;
            output.OnRenderYAxisLabel += RenderYLabel;
            output.SetDisplayRangeY(0, 255);
            output.SetGridDistanceY(50);
            output.SetGridOriginY(0);
            output.GraphColor = Color.Green;

            /* for (int i = 0; i < 1500; i++)
                         {
                             source.Add(i, 23f+180f*(1-300/(1+i))+20f*(float)Math.Sin(0.1f*i));
                         }*/
            plotter.DataSources.Add(source);
            plotter.DataSources.Add(target);
            plotter.DataSources.Add(output);
            plotter.SetDisplayRangeX(0, 300);
            plotter.SetGridDistanceX(15);
           
            plotter.PanelLayout = PlotterGraphPaneEx.LayoutMode.VERTICAL_ARRANGED;
            plotter.BackgroundColorTop = Color.Black;
            plotter.BackgroundColorBot = Color.Black;
            plotter.SolidGridColor = Color.DarkGray;
            plotter.DashedGridColor = Color.DarkGray;

            this.ResumeLayout();
            Main.conn.eventTempMonitor += OnTempMonitor;
        }
        void OnTempMonitor(UInt32 time, int temp, int _target, int _output)
        {
            float ftime = time / 1000.0f;
            if (source.Length == 0) plotter.SetGridOriginX(ftime);
            
            source.Add(ftime, temp);
            target.Add(ftime, _target);
            output.Add(ftime, _output);
            if (source.Length == 1)
            {
                left = ftime;
                plotter.SetDisplayRangeX(ftime, ftime + 300);
            }
            else if (ftime > left + 290)
            {
                left = ftime - 290;
                plotter.SetDisplayRangeX(left, left + 300);
            }
            plotter.Refresh();
        }
        private String RenderXLabel(DataSource s, int idx)
        {
            float x = ((cPoint)s.Samples[idx]).x;
            return x.ToString("0", GCode.format);
        }

        private String RenderYLabel(DataSource s, float value)
        {
            return value.ToString("0");
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void buttonStartMonitor_Click(object sender, EventArgs e)
        {
            int mon = comboMonitor.SelectedIndex;
            if (mon < 0) mon = 0;
            if (mon == comboMonitor.Items.Count - 1)
                mon = 100;
            Main.conn.injectManualCommand("M203 S" + mon.ToString());
        }

        private void buttonStopMonitor_Click(object sender, EventArgs e)
        {
            Main.conn.injectManualCommand("M203 S255");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            source.Samples.Clear();
            target.Samples.Clear();
            output.Samples.Clear();
            plotter.Refresh();
        }

        private void checkAutoscaleX_CheckedChanged(object sender, EventArgs e)
        {
            source.AutoScaleX = checkAutoscaleX.Checked;
            target.AutoScaleX = checkAutoscaleX.Checked;
            output.AutoScaleX = checkAutoscaleX.Checked;
            plotter.Refresh();
        }
    }
}
