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
using Microsoft.Win32;
using System.Globalization;
using RepetierHost.model;

namespace RepetierHost.view
{
    public partial class ThreeDSettings : Form
    {
        RegistryKey repetierKey;
        RegistryKey threedKey;
        public ThreeDSettings()
        {
            InitializeComponent();
            repetierKey = Registry.CurrentUser.CreateSubKey("Software\\Repetier");
            threedKey = repetierKey.CreateSubKey("3D");
            if (comboFilamentVisualization.SelectedIndex < 0) comboFilamentVisualization.SelectedIndex = 1;
            RegistryToForm();
        }
        public int filamentVisualization
        {
            get {return comboFilamentVisualization.SelectedIndex;}
        }
        public float layerHeight
        {
            get { float h; float.TryParse(textLayerHeight.Text, NumberStyles.Float, GCode.format, out h); if (h < 0.05) h = 0.05f; return h; }
        }
        public float widthOverHeight
        {
            get { float h; float.TryParse(textWidthOverThickness.Text, NumberStyles.Float, GCode.format, out h); if (h < 0.05) h = 0.05f; return h; }
        }
        private void FormToRegistry()
        {
            try
            {
                threedKey.SetValue("backgroundColor", background.BackColor.ToArgb());
                threedKey.SetValue("facesColor", faces.BackColor.ToArgb());
                threedKey.SetValue("edgesColor", edges.BackColor.ToArgb());
                threedKey.SetValue("selectedFacesColor", selectedFaces.BackColor.ToArgb());
                threedKey.SetValue("printerBaseColor", printerBase.BackColor.ToArgb());
                threedKey.SetValue("filamenColor", filament.BackColor.ToArgb());
                threedKey.SetValue("showEdges", showEdges.Checked ? 1 : 0);
                threedKey.SetValue("showPrintbed", showPrintbed.Checked ? 1 : 0);
                threedKey.SetValue("useVBOs", useVBOs.Checked ? 1 : 0);
                threedKey.SetValue("layerHeight", textLayerHeight.Text);
                threedKey.SetValue("widthOverHeight", textWidthOverThickness.Text);
                threedKey.SetValue("filamentVisualization", comboFilamentVisualization.SelectedIndex);
            }
            catch { }
        }
        private void RegistryToForm()
        {
            try
            {
                background.BackColor = Color.FromArgb((int)threedKey.GetValue("backgroundColor",background.BackColor.ToArgb()));
                faces.BackColor = Color.FromArgb((int)threedKey.GetValue("facesColor", faces.BackColor.ToArgb()));
                edges.BackColor = Color.FromArgb((int)threedKey.GetValue("edgesColor", faces.BackColor.ToArgb()));
                selectedFaces.BackColor = Color.FromArgb((int)threedKey.GetValue("selectedFacesColor", selectedFaces.BackColor.ToArgb()));
                printerBase.BackColor = Color.FromArgb((int)threedKey.GetValue("printerBaseColor", printerBase.BackColor.ToArgb()));
                filament.BackColor = Color.FromArgb((int)threedKey.GetValue("filamenColor", filament.BackColor.ToArgb()));
                showEdges.Checked = 0 != (int)threedKey.GetValue("showEdges", showEdges.Checked ? 1 : 0);
                showPrintbed.Checked = 0 != (int)threedKey.GetValue("showPrintbed", showPrintbed.Checked ? 1 : 0);
                useVBOs.Checked = 0 != (int)threedKey.GetValue("useVBOs", useVBOs.Checked ? 1 : 0);
                textLayerHeight.Text = (string)threedKey.GetValue("layerHeight", textLayerHeight.Text);
                textWidthOverThickness.Text = (string)threedKey.GetValue("widthOverHeight", textWidthOverThickness.Text);
                comboFilamentVisualization.SelectedIndex = (int)threedKey.GetValue("filamentVisualization", comboFilamentVisualization.SelectedIndex);
            }
            catch { }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            FormToRegistry();
            Hide();
        }

        private void background_Click(object sender, EventArgs e)
        {
            colorDialog.Color = background.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                background.BackColor = colorDialog.Color;
                Main.main.Update3D();
            }
        }

        private void faces_Click(object sender, EventArgs e)
        {
            colorDialog.Color = faces.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                faces.BackColor = colorDialog.Color;
                Main.main.Update3D();
            }
        }
        private void edges_Click(object sender, EventArgs e)
        {
            colorDialog.Color = edges.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                edges.BackColor = colorDialog.Color;
                Main.main.Update3D();
            }
        }

        private void selectedFaces_Click(object sender, EventArgs e)
        {
            colorDialog.Color = selectedFaces.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFaces.BackColor = colorDialog.Color;
                Main.main.Update3D();
            }
        }

        private void filament_Click(object sender, EventArgs e)
        {
            colorDialog.Color = filament.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                filament.BackColor = colorDialog.Color;
                Main.main.Update3D();
            }
        }

        private void printerBase_Click(object sender, EventArgs e)
        {
            colorDialog.Color = printerBase.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                printerBase.BackColor = colorDialog.Color;
                Main.main.Update3D();
            }
        }

        private void comboFilamentVisualization_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main.main.Update3D();
        }

        private void textLayerHeight_TextChanged(object sender, EventArgs e)
        {
            Main.main.Update3D();
        }

        private void showEdges_CheckedChanged(object sender, EventArgs e)
        {
            Main.main.Update3D();
        }
    }
}
