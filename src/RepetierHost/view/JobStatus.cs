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
using RepetierHost.model;

namespace RepetierHost.view
{
    public partial class JobStatus : Form
    {
        static JobStatus f = null;
        public static void ShowStatus()
        {
            if (f == null)
                f = new JobStatus();
            f.Show();
            f.timer.Start();
        }
        public JobStatus()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Printjob j = Main.conn.job;
            switch (j.mode)
            {
                case 0:
                    labelStatus.Text = "No job defined";
                    labelStartTime.Text = "-";
                    labelFinishTime.Text = "-";
                    labelETA.Text = "-";
                    labelLinesSend.Text = "-";
                    labelTotalLines.Text = "-";
                    break;
                case 1: // Running
                    labelStatus.Text = "Running ...";
                    labelStartTime.Text = j.jobStarted.ToLongTimeString();
                    labelFinishTime.Text = "-";
                    labelETA.Text = j.ETA;
                    labelLinesSend.Text = j.linesSend.ToString();
                    labelTotalLines.Text = j.totalLines.ToString();
                    break;
                case 2:
                    labelStatus.Text = "Finished";
                    labelStartTime.Text = j.jobStarted.ToLongTimeString();
                    labelFinishTime.Text = j.jobFinished.ToLongTimeString();
                    labelETA.Text = "-";
                    labelLinesSend.Text = j.linesSend.ToString();
                    labelTotalLines.Text = j.totalLines.ToString();
                    break;
                case 3:
                    labelStatus.Text = "Aborted";
                    labelStartTime.Text = j.jobStarted.ToLongTimeString();
                    labelFinishTime.Text = j.jobFinished.ToLongTimeString();
                    labelETA.Text = "-";
                    labelLinesSend.Text = j.linesSend.ToString();
                    labelTotalLines.Text = j.totalLines.ToString();
                    break;
            }
        }

        private void JobStatus_Shown(object sender, EventArgs e)
        {
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Hide();
        }
    }
}
