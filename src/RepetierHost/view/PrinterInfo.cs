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
    public partial class PrinterInfo : Form
    {
        PrinterConnection con;
        public PrinterInfo()
        {
            con = Main.conn;
            InitializeComponent();
            timer_Tick(null, null);
        }
        /// <summary>
        /// Update the informations every second.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (con.connected == false) return;
            labelMachine.Text = con.machine;
            labelFirmware.Text = con.firmware;
            labelFirmwareURL.Text = con.firmware_url;
            labelNumExtruder.Text = con.numberExtruder.ToString();
            labelProtocol.Text = con.protocol;
            labelLinesSend.Text = con.linesSend.ToString();
            labelBytesSend.Text = con.bytesSend.ToString();
            labelErrorsReceived.Text = con.errorsReceived.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void labelFirmwareURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main.main.openLink(labelFirmwareURL.Text);
        }

    }
}
