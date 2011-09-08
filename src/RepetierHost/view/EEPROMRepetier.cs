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
    public partial class EEPROMRepetier : Form
    {
        EEPROMStorage storage;
        BindingList<EEPROMParameter> data = new BindingList<EEPROMParameter>();
        public EEPROMRepetier()
        {
            InitializeComponent();
            storage = Main.conn.eeprom;
            storage.eventAdded += newline;
            grid.Columns.Add("Description", "Description");
            grid.Columns[0].DataPropertyName = "Description";
            grid.Columns[0].ReadOnly = true;
            grid.Columns.Add("Value", "Value");
            grid.Columns[1].DataPropertyName = "Value";
            grid.DataSource = data;
        }
        public void Show2()
        {
            Show();
            storage.Clear();
            data.Clear();
            storage.Update();
        }
        private void newline(EEPROMParameter p)
        {
            data.Add(p);
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            storage.Save();
            Hide();
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
