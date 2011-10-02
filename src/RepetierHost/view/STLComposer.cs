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
using System.Globalization;
using System.IO;
using OpenTK;

namespace RepetierHost.view
{
    public partial class STLComposer : UserControl
    {
        ThreeDControl cont;
        public STLComposer()
        {
            InitializeComponent();
            try
            {
                cont = new ThreeDControl();
                cont.Dock = DockStyle.None;
                cont.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                cont.Width = Width - panelControls.Width;
                cont.Height = Height;
                Controls.Add(cont);
                cont.SetEditor(true);
                cont.SetObjectSelected(false);
                cont.eventObjectMoved += objectMoved;
                updateEnabled();
            }
            catch { }
        }
        public void Update3D() {
            cont.UpdateChanges();
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
        private void updateEnabled()
        {
            if (listSTLObjects.SelectedItem == null)
            {
                textRotX.Enabled = false;
                textRotY.Enabled = false;
                textRotZ.Enabled = false;
                textScaleX.Enabled = false;
                textScaleY.Enabled = false;
                textScaleZ.Enabled = false;
                checkScaleAll.Enabled = false;
                textTransX.Enabled = false;
                textTransY.Enabled = false;
                textTransZ.Enabled = false;
                buttonCenter.Enabled = false;
                buttonLand.Enabled = false;
                cont.SetObjectSelected(false);
            }
            else
            {
                textRotX.Enabled = true;
                textRotY.Enabled = true;
                textRotZ.Enabled = true;
                textScaleX.Enabled = true;
                textScaleY.Enabled = !checkScaleAll.Checked;
                textScaleZ.Enabled = !checkScaleAll.Checked;
                checkScaleAll.Enabled = true;
                textTransX.Enabled = true;
                textTransY.Enabled = true;
                textTransZ.Enabled = true;
                buttonCenter.Enabled = true;
                buttonLand.Enabled = true;
                cont.SetObjectSelected(true);
            }
            if (listSTLObjects.Items.Count == 0)
            {
                buttonRemoveSTL.Enabled = false;
                buttonSave.Enabled = false;
                buttonSlice.Enabled = false;
            }
            else
            {
                buttonRemoveSTL.Enabled = listSTLObjects.SelectedIndex>=0;
                buttonSave.Enabled = true;
                buttonSlice.Enabled = true;
            }
        }
        private void buttonAddSTL_Click(object sender, EventArgs e)
        {
            if (openFileSTL.ShowDialog() == DialogResult.OK)
            {
                STL stl = new STL();
                stl.Load(openFileSTL.FileName);
                if (stl.list.Count > 0)
                {
                    listSTLObjects.Items.Add(stl);
                    cont.models.AddLast(stl);
                    listSTLObjects.SelectedItem = stl;
                }
            }
        }

        private void listSTLObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateEnabled();
            STL stl = (STL)listSTLObjects.SelectedItem;
            foreach (STL s in cont.models)
            {
                s.Selected = s == stl;
            }
            if (stl != null)
            {
                textRotX.Text = stl.Rotation.x.ToString(GCode.format);
                textRotY.Text = stl.Rotation.y.ToString(GCode.format);
                textRotZ.Text = stl.Rotation.z.ToString(GCode.format);
                textScaleX.Text = stl.Scale.x.ToString(GCode.format);
                textScaleY.Text = stl.Scale.y.ToString(GCode.format);
                textScaleZ.Text = stl.Scale.z.ToString(GCode.format);
                textTransX.Text = stl.Position.x.ToString(GCode.format);
                textTransY.Text = stl.Position.y.ToString(GCode.format);
                textTransZ.Text = stl.Position.z.ToString(GCode.format);
                checkScaleAll.Checked = (stl.Scale.x == stl.Scale.y && stl.Scale.x == stl.Scale.z);
            }
            cont.UpdateChanges();
        }

        private void textTransX_TextChanged(object sender, EventArgs e)
        {
            STL stl = (STL)listSTLObjects.SelectedItem;
            if(stl==null) return;
            float.TryParse(textTransX.Text, NumberStyles.Float, GCode.format, out stl.Position.x);
            cont.UpdateChanges();
        }

        private void textTransY_TextChanged(object sender, EventArgs e)
        {
            STL stl = (STL)listSTLObjects.SelectedItem;
            if (stl == null) return;
            float.TryParse(textTransY.Text, NumberStyles.Float, GCode.format, out stl.Position.y);
            cont.UpdateChanges();
        }

        private void textTransZ_TextChanged(object sender, EventArgs e)
        {
            STL stl = (STL)listSTLObjects.SelectedItem;
            if (stl == null) return;
            float.TryParse(textTransZ.Text, NumberStyles.Float, GCode.format, out stl.Position.z);
            cont.UpdateChanges();
        }
        private void objectMoved(float dx, float dy)
        {
            STL stl = (STL)listSTLObjects.SelectedItem;
            if (stl == null) return;
            stl.Position.x += dx;
            stl.Position.y += dy;
            textTransX.Text = stl.Position.x.ToString(GCode.format);
            textTransY.Text = stl.Position.y.ToString(GCode.format);
            cont.UpdateChanges();
        }
        private void textScaleX_TextChanged(object sender, EventArgs e)
        {
            STL stl = (STL)listSTLObjects.SelectedItem;
            if (stl == null) return;
            float.TryParse(textScaleX.Text, NumberStyles.Float, GCode.format, out stl.Scale.x);
            if (checkScaleAll.Checked)
            {
                stl.Scale.y = stl.Scale.z = stl.Scale.x;
                textScaleY.Text = stl.Scale.y.ToString(GCode.format);
                textScaleZ.Text = stl.Scale.z.ToString(GCode.format);
            }
            cont.UpdateChanges();
        }

        private void textScaleY_TextChanged(object sender, EventArgs e)
        {
            STL stl = (STL)listSTLObjects.SelectedItem;
            if (stl == null) return;
            float.TryParse(textScaleY.Text, NumberStyles.Float, GCode.format, out stl.Scale.y);
            cont.UpdateChanges();
        }

        private void textScaleZ_TextChanged(object sender, EventArgs e)
        {
            STL stl = (STL)listSTLObjects.SelectedItem;
            if (stl == null) return;
            float.TryParse(textScaleZ.Text, NumberStyles.Float, GCode.format, out stl.Scale.z);
            cont.UpdateChanges();
        }

        private void textRotX_TextChanged(object sender, EventArgs e)
        {
            STL stl = (STL)listSTLObjects.SelectedItem;
            if (stl == null) return;
            float.TryParse(textRotX.Text, NumberStyles.Float, GCode.format, out stl.Rotation.x);
            cont.UpdateChanges();
        }

        private void textRotY_TextChanged(object sender, EventArgs e)
        {
            STL stl = (STL)listSTLObjects.SelectedItem;
            if (stl == null) return;
            float.TryParse(textRotY.Text, NumberStyles.Float, GCode.format, out stl.Rotation.y);
            cont.UpdateChanges();
        }

        private void textRotZ_TextChanged(object sender, EventArgs e)
        {
            STL stl = (STL)listSTLObjects.SelectedItem;
            if (stl == null) return;
            float.TryParse(textRotZ.Text, NumberStyles.Float, GCode.format, out stl.Rotation.z);
            cont.UpdateChanges();
        }

        private void buttonRemoveSTL_Click(object sender, EventArgs e)
        {
            STL stl = (STL)listSTLObjects.SelectedItem;
            if (stl == null) return;
            cont.models.Remove(stl);
            listSTLObjects.Items.Remove(stl);
            cont.UpdateChanges();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveSTL.ShowDialog() == DialogResult.OK)
            {
                saveComposition(saveSTL.FileName);
            }
        }
        private void saveComposition(string fname)
        {
            int n = 0;
            foreach (STL stl in listSTLObjects.Items)
            {
                n += stl.list.Count;
            }
            STLTriangle[] triList = new STLTriangle[n];
            int p = 0;
            foreach (STL stl in listSTLObjects.Items)
            {
                stl.UpdateMatrix();
                foreach (STLTriangle t2 in stl.list)
                {
                    STLTriangle t = new STLTriangle();
                    t.p1 = new Vector3();
                    t.p2 = new Vector3();
                    t.p3 = new Vector3();
                    t.normal = new Vector3();
                    stl.TransformPoint(ref t2.p1, out t.p1.X, out t.p1.Y, out t.p1.Z);
                    stl.TransformPoint(ref t2.p2, out t.p2.X, out t.p2.Y, out t.p2.Z);
                    stl.TransformPoint(ref t2.p3, out t.p3.X, out t.p3.Y, out t.p3.Z);
                    // Compute normal from p1-p3
                    float ax = t.p2.X - t.p1.X;
                    float ay = t.p2.Y - t.p1.Y;
                    float az = t.p2.Z - t.p1.Z;
                    float bx = t.p3.X - t.p1.X;
                    float by = t.p3.Y - t.p1.Y;
                    float bz = t.p3.Z - t.p1.Z;
                    t.normal.X = ay * bz - az * by;
                    t.normal.Y = az * bx - ax * bz;
                    t.normal.Z = ax * by - ay * bx;
                    Vector3.Normalize(ref t.normal, out t.normal);
                    triList[p++] = t;
                }
            }
            // STL should have increasing z for faster slicing
            Array.Sort<STLTriangle>(triList, triList[0]);
            // Write file in binary STL format
            FileStream fs = File.Open(fname, FileMode.Create);
            BinaryWriter w = new BinaryWriter(fs);
            int i;
            for (i = 0; i < 20; i++) w.Write((int)0);
            w.Write(n);
            for (i = 0; i < n; i++)
            {
                STLTriangle t = triList[i];
                w.Write(t.normal.X);
                w.Write(t.normal.Y);
                w.Write(t.normal.Z);
                w.Write(t.p1.X);
                w.Write(t.p1.Y);
                w.Write(t.p1.Z);
                w.Write(t.p2.X);
                w.Write(t.p2.Y);
                w.Write(t.p2.Z);
                w.Write(t.p3.X);
                w.Write(t.p3.Y);
                w.Write(t.p3.Z);
                w.Write((short)0);
            }
            w.Close();
            fs.Close();
        }

        private void buttonLand_Click(object sender, EventArgs e)
        {
            STL stl = (STL)listSTLObjects.SelectedItem;
            if (stl == null) return;
            stl.Land();
            listSTLObjects_SelectedIndexChanged(null, null);
            cont.UpdateChanges();
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            STL stl = (STL)listSTLObjects.SelectedItem;
            if (stl == null) return;
            stl.Center(100f,100f);
            listSTLObjects_SelectedIndexChanged(null, null);
            cont.UpdateChanges();
        }

        private void buttonSlice_Click(object sender, EventArgs e)
        {
            string dir = Main.globalSettings.Workdir;
            if (!Directory.Exists(dir))
            {
                MessageBox.Show("Workdir does not exists. Slicing aborted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Main.globalSettings.Show();
                return;
            }
            if (listSTLObjects.Items.Count == 0) return;
            string t = listSTLObjects.Items[0].ToString();
            if (listSTLObjects.Items.Count > 1)
                t += " + " + (listSTLObjects.Items.Count - 1).ToString();
            Main.main.Title = t;
            dir+="/composition.stl";
            saveComposition(dir);
            Main.main.skeinforge.RunSlice(dir); // Slice it and load
        }
    }
}
