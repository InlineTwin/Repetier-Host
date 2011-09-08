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

namespace RepetierHost.view
{
    public delegate void SwitchEventHandler(SwitchButton button);
    public partial class SwitchButton : UserControl
    {
        string textOn="On";
        string textOff="Off";
        bool on=false;
        [Browsable(true)]
        public event SwitchEventHandler OnChange;
        public SwitchButton()
        {
            InitializeComponent();
        }
        [Description("Text if button is off")]
        public string TextOff
        {
            get { return textOff; }
            set { textOff = value; if (!on) button.Text = textOff; }
        }
        [Description("Text if button is on")]
        public string TextOn
        {
            get { return textOn; }
            set { textOn = value; if (on) button.Text = textOn; }
        }
        public bool On
        {
            get { return on; }
            set {
                if (on == value) return;
                on = value; button.Text = on ? textOn : textOff;
                button.ImageIndex = on ? 1 : 0;
                if (OnChange != null)
                    OnChange(this);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            On = !On;
        }
        public new bool Enabled
        {
            get { return button.Enabled; }
            set { button.Enabled = value; }
        }
    }
}
