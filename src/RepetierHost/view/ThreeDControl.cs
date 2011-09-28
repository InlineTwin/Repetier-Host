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
using OpenTK.Graphics.OpenGL;
using OpenTK.Platform.Windows;
using OpenTK;
using System.Diagnostics;
using RepetierHost.model;

namespace RepetierHost.view
{
    public delegate void onObjectMoved(float dx,float dy);

    public partial class ThreeDControl : UserControl
    {
        FormPrinterSettings ps = Main.printerSettings;
        public onObjectMoved eventObjectMoved;
        bool loaded = false;
        float xDown, yDown;
        float xPos, yPos;
        float speedX, speedY;
        float zoom = 1.0f;
        Vector3 viewCenter;
        Vector3 userPosition;
        float rotZ = 0, rotX = 0;
        Stopwatch sw = new Stopwatch();
        Stopwatch fpsTimer = new Stopwatch();
        int mode = 0;
        bool editor = false;
        bool autoupdateable = false;
        public LinkedList<ThreeDModel> models;
        public ThreeDControl()
        {
            models = new LinkedList<ThreeDModel>();
            InitializeComponent();
            toolAutoupdate.Visible = autoupdateable;
            toolStripClear.Visible = autoupdateable;
            Application.Idle += Application_Idle;
            STL m1 = new STL();
            viewCenter = new Vector3(0, 0, 0);
            rotX = 20;
            userPosition = new Vector3(0, -2f * ps.PrintAreaDepth, 0.0f * ps.PrintAreaHeight);
            gl.MouseWheel += gl_MouseWheel;
        }
        public void SetEditor(bool ed)
        {
            editor = ed;
            toolMoveObject.Visible = editor;
        }
        public void SetObjectSelected(bool sel)
        {
            toolMoveObject.Enabled = sel;
        }
        public bool AutoUpdateable
        {
            get { return autoupdateable; }
            set
            {
                autoupdateable = value;
                if (autoupdateable)
                {
                    timer.Start();
                }
                else
                {
                    timer.Stop();
                }
                toolAutoupdate.Visible = value;
                toolStripClear.Visible = value;
            }
        }
        public void UpdateChanges() {
            gl.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        private void SetupViewport()
        {
            try
            {
                int w = gl.Width;
                int h = gl.Height;
                GL.Viewport(0,0, w, h); // Use all of the glControl painting area
                GL.MatrixMode(MatrixMode.Projection);
                //GL.LoadIdentity();
                float dx = viewCenter.X - userPosition.X;
                float dy = viewCenter.Y - userPosition.Y;
                float dz = viewCenter.Z - userPosition.Z;
                float dist = (float)Math.Sqrt(dx * dx + dy * dy + dz * dz);
                Matrix4 persp = Matrix4.CreatePerspectiveFieldOfView((float)(zoom*30f * Math.PI / 180f), (float)w / (float)h, Math.Max(10,dist-2f*ps.PrintAreaDepth),dist+ 2*ps.PrintAreaDepth);
                GL.LoadMatrix(ref persp);
                // GL.Ortho(0, w, 0, h, -1, 1); // Bottom-left corner pixel has coordinate (0, 0)

            }
            catch { }
        }

        private void gl_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (!loaded) return;
                fpsTimer.Reset();
                fpsTimer.Start();
                gl.MakeCurrent();
                GL.ClearColor(Main.threeDSettings.background.BackColor);
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                GL.Enable(EnableCap.DepthTest);
                SetupViewport();
                Matrix4 lookat = Matrix4.LookAt(userPosition.X, userPosition.Y, userPosition.Z, viewCenter.X, viewCenter.Y, viewCenter.Z, 0, 0, 1.0f);
                GL.MatrixMode(MatrixMode.Modelview);
                GL.LoadMatrix(ref lookat);
                GL.ShadeModel(ShadingModel.Smooth);
                //Enable lighting
                GL.Light(LightName.Light0, LightParameter.Ambient, new float[] { 0.2f, 0.2f, 0.2f, 1f });
                GL.Light(LightName.Light0, LightParameter.Diffuse, new float[] {0,0,0,0});
                GL.Light(LightName.Light0, LightParameter.Specular, new float[] { 0, 0, 0, 0 });
                GL.Enable(EnableCap.Light0);
                if (Main.threeDSettings.enableLight1.Checked)
                {
                    GL.Light(LightName.Light1, LightParameter.Diffuse, new float[] { 0.8f, 0.8f, 0.8f, 1f });
                    GL.Light(LightName.Light1, LightParameter.Specular, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
                    GL.Light(LightName.Light1, LightParameter.Position, (new Vector4(-1f, -1f, 2f, 0)));
                    GL.Light(LightName.Light1, LightParameter.SpotExponent, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
                    GL.Enable(EnableCap.Light1);
                }
                else GL.Disable(EnableCap.Light1);
                if (Main.threeDSettings.enableLight2.Checked)
                {
                    GL.Light(LightName.Light2, LightParameter.Diffuse, new float[] { 0.7f, 0.7f, 0.7f, 1f });
                    GL.Light(LightName.Light2, LightParameter.Specular, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
                    GL.Light(LightName.Light2, LightParameter.Position, (new Vector4(100f, 200f, 300f, 0)));
                    GL.Light(LightName.Light2, LightParameter.SpotExponent, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
                    GL.Enable(EnableCap.Light2);
                }
                else GL.Disable(EnableCap.Light2);
                if (Main.threeDSettings.enableLight3.Checked)
                {
                    GL.Light(LightName.Light3, LightParameter.Diffuse, new float[] { 0.8f, 0.8f, 0.8f, 1f });
                    GL.Light(LightName.Light3, LightParameter.Specular, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
                    GL.Light(LightName.Light3, LightParameter.Position, (new Vector4(100f, -200f, 200f, 0)));
                    GL.Light(LightName.Light3, LightParameter.SpotExponent, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
                    GL.Enable(EnableCap.Light3);
                }
                else GL.Disable(EnableCap.Light3);
                if (Main.threeDSettings.enableLight4.Checked)
                {
                    GL.Light(LightName.Light4, LightParameter.Diffuse, new float[] { 0.7f, 0.7f, 0.7f, 1f });
                    GL.Light(LightName.Light4, LightParameter.Specular, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
                    GL.Light(LightName.Light4, LightParameter.Position, (new Vector4(170f, -100f, -250f, 0)));
                    GL.Light(LightName.Light4, LightParameter.SpotExponent, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
                    GL.Enable(EnableCap.Light4);
                }
                else GL.Disable(EnableCap.Light4);

                GL.Enable(EnableCap.Lighting);
                //Enable Backfaceculling
                GL.Enable(EnableCap.CullFace);

                Color col = Main.threeDSettings.printerBase.BackColor;
                // Draw viewpoint
                /*GL.Material(
                    MaterialFace.Front,
                    MaterialParameter.Emission,
                    new OpenTK.Graphics.Color4(col.R, col.G, col.B, col.A));
                GL.Begin(BeginMode.Lines);
                GL.Vertex3(viewCenter.X - 2, viewCenter.Y, viewCenter.Z);
                GL.Vertex3(viewCenter.X + 2, viewCenter.Y, viewCenter.Z);
                GL.Vertex3(viewCenter.X, viewCenter.Y - 2, viewCenter.Z);
                GL.Vertex3(viewCenter.X, viewCenter.Y + 2, viewCenter.Z);
                GL.Vertex3(viewCenter.X, viewCenter.Y, viewCenter.Z - 2);
                GL.Vertex3(viewCenter.X, viewCenter.Y, viewCenter.Z + 2);
                GL.End();*/

                GL.Rotate(rotX, 1, 0, 0);
                GL.Rotate(rotZ, 0, 0, 1);
                GL.Translate(-ps.PrintAreaWidth*0.5f,-ps.PrintAreaDepth*0.5f,-0.5f*ps.PrintAreaHeight);
                GL.Material(
                    MaterialFace.Front,
                    MaterialParameter.Specular,
                    new OpenTK.Graphics.Color4(255,255,255,255));

                if (Main.threeDSettings.showPrintbed.Checked)
                {
                    float dx1 = ps.DumpAreaLeft;
                    float dx2 = dx1 + ps.DumpAreaWidth;
                    float dy1 = ps.DumpAreaFront;
                    float dy2 = dy1 + ps.DumpAreaDepth;
                    col = Main.threeDSettings.printerBase.BackColor;
                    GL.Material(MaterialFace.FrontAndBack, MaterialParameter.AmbientAndDiffuse, new OpenTK.Graphics.Color4(0, 0,0, 255));
                    GL.Material(MaterialFace.Front, MaterialParameter.Emission, new OpenTK.Graphics.Color4(0, 0, 0, 0));
                    GL.Material(MaterialFace.Front, MaterialParameter.Specular, new float[] { 0.0f, 0.0f, 0.0f, 1.0f });
                    GL.Material(
                        MaterialFace.Front,
                        MaterialParameter.Emission,
                        new OpenTK.Graphics.Color4(col.R, col.G, col.B, col.A));
                    GL.Begin(BeginMode.Lines);
                    int i;
                    // Print cube
                    GL.Vertex3(0, 0, 0);
                    GL.Vertex3(0, 0, ps.PrintAreaHeight);
                    GL.Vertex3(ps.PrintAreaWidth, 0, 0);
                    GL.Vertex3(ps.PrintAreaWidth, 0, ps.PrintAreaHeight);
                    GL.Vertex3(0, ps.PrintAreaDepth, 0);
                    GL.Vertex3(0, ps.PrintAreaDepth, ps.PrintAreaHeight);
                    GL.Vertex3(ps.PrintAreaWidth, ps.PrintAreaDepth, 0);
                    GL.Vertex3(ps.PrintAreaWidth, ps.PrintAreaDepth, ps.PrintAreaHeight);
                    GL.Vertex3(0, 0, ps.PrintAreaHeight);
                    GL.Vertex3(ps.PrintAreaWidth, 0, ps.PrintAreaHeight);
                    GL.Vertex3(ps.PrintAreaWidth, 0, ps.PrintAreaHeight);
                    GL.Vertex3(ps.PrintAreaWidth, ps.PrintAreaDepth, ps.PrintAreaHeight);
                    GL.Vertex3(ps.PrintAreaWidth, ps.PrintAreaDepth, ps.PrintAreaHeight);
                    GL.Vertex3(0, ps.PrintAreaDepth, ps.PrintAreaHeight);
                    GL.Vertex3(0, ps.PrintAreaDepth, ps.PrintAreaHeight);
                    GL.Vertex3(0, 0, ps.PrintAreaHeight);
                    if (ps.HasDumpArea)
                    {
                        if (dy1 != 0)
                        {
                            GL.Vertex3(dx1, dy1, 0);
                            GL.Vertex3(dx2, dy1, 0);
                        }
                        GL.Vertex3(dx2, dy1, 0);
                        GL.Vertex3(dx2, dy2, 0);
                        GL.Vertex3(dx2, dy2, 0);
                        GL.Vertex3(dx1, dy2, 0);
                        GL.Vertex3(dx1, dy2, 0);
                        GL.Vertex3(dx1, dy1, 0);
                    }
                    float dx = ps.PrintAreaWidth / 20f;
                    float dy = ps.PrintAreaDepth / 20f;
                    float x,y;
                    for (i = 0; i < 21; i++)
                    {
                        x = (float)i*dx;
                        y = (float)i*dy;
                        if (ps.HasDumpArea && y >= dy1 && y <= dy2)
                        {
                            GL.Vertex3(0, y, 0);
                            GL.Vertex3(dx1, y, 0);
                            GL.Vertex3(dx2, y, 0);
                            GL.Vertex3(ps.PrintAreaWidth, y, 0);
                        }
                        else
                        {
                            GL.Vertex3(0, y, 0);
                            GL.Vertex3(ps.PrintAreaWidth, y, 0);
                        }
                        if (ps.HasDumpArea && x >= dx1 && x <= dx2)
                        {
                            GL.Vertex3(x, 0, 0);
                            GL.Vertex3(x, dy1, 0);
                            GL.Vertex3(x, dy2, 0);
                            GL.Vertex3(x, ps.PrintAreaDepth, 0);
                        }
                        else
                        {
                            GL.Vertex3(x, 0, 0);
                            GL.Vertex3(x, ps.PrintAreaDepth, 0);
                        }
                    }
                    GL.End();
                }
                foreach (ThreeDModel model in models)
                {
                    GL.PushMatrix();
                    GL.Translate(model.Position.x, model.Position.y, model.Position.z);
                    GL.Rotate(model.Rotation.z, Vector3.UnitZ);
                    GL.Rotate(model.Rotation.y, Vector3.UnitY);
                    GL.Rotate(model.Rotation.x, Vector3.UnitX);
                    GL.Scale(model.Scale.x, model.Scale.y, model.Scale.z);
                    model.Paint();
                    GL.PopMatrix();
                }
                gl.SwapBuffers();
                fpsTimer.Stop();
                double framerate = 10000000.0 / fpsTimer.ElapsedTicks;
                Main.main.fpsLabel.Text = framerate.ToString("0") + " FPS";
            }
            catch { }
        }

        private void ThreeDControl_Load(object sender, EventArgs e)
        {
            loaded = true;
            SetupViewport();
        }

        private void gl_Resize(object sender, EventArgs e)
        {
            SetupViewport();
            gl.Invalidate();
        }

        private void gl_MouseDown(object sender, MouseEventArgs e)
        {
            xDown = e.X;
            yDown = e.Y;
        }

        private void gl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.None)
            {
                speedX = speedY = 0;
                return;
            }
            xPos = e.X;
            yPos = e.Y;
            float d = Math.Min(gl.Width, gl.Height) / 3;
            speedX = Math.Max(-1,Math.Min(1,(xPos - xDown) / d));
            speedY = Math.Max(-1, Math.Min(1, (yPos - yDown) / d));
        }

        private void gl_MouseUp(object sender, MouseEventArgs e)
        {
            speedX = speedY = 0;
        }
        private void gl_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                zoom *= 1f - e.Delta / 500f;
                if (zoom < 0.01) zoom = 0.01f;
                if (zoom > 10) zoom = 10;
                //userPosition.Y += e.Delta;
                gl.Invalidate();
            }
        }
        void Application_Idle(object sender, EventArgs e)
        {
            if (!loaded || (speedX==0 && speedY==0)) return;
            // no guard needed -- we hooked into the event in Load handler

            sw.Stop(); // we've measured everything since last Idle run
            double milliseconds = sw.Elapsed.TotalMilliseconds;
            sw.Reset(); // reset stopwatch
            sw.Start(); // restart stopwatch
            Keys k = Control.ModifierKeys;
            int emode = mode;
            if (k == Keys.Shift) emode = 2;
            if (k == Keys.Control) emode = 0;
            if (k == Keys.Alt) emode = 4;
            if (emode == 0)
            {
                rotZ += (float)milliseconds * speedX *Math.Abs(speedX)/ 15.0f;
                rotX += (float)milliseconds * speedY*Math.Abs(speedY) / 15.0f;
            }
            else if (emode == 1)
            {
                userPosition.X += (float)milliseconds * speedX *Math.Abs(speedX)/ 10.0f;
                userPosition.Z -= (float)milliseconds * speedY *Math.Abs(speedY)/ 10.0f;
            }
            else if (emode == 2)
            {
                viewCenter.X -= (float)milliseconds * speedX * Math.Abs(speedX)/ 10.0f;
                viewCenter.Z += (float)milliseconds * speedY * Math.Abs(speedY)/ 10.0f;
            }
            else if (emode == 3)
            {
                userPosition.Y += (float)milliseconds * speedY * Math.Abs(speedY)/ 10.0f;
            }
            else if (emode == 4)
            {
                if (eventObjectMoved != null)
                    eventObjectMoved((float)milliseconds * speedX * Math.Abs(speedX) / 10.0f,
                        -(float)milliseconds * speedY * Math.Abs(speedY) / 10.0f);
            }
            gl.Invalidate();
        }

        public void SetMode(int _mode)
        {
            mode = _mode;
            toolRotate.Checked = mode == 0;
            toolMove.Checked = mode == 1;
            toolMoveViewpoint.Checked = mode == 2;
            toolZoom.Checked = mode == 3;
            toolMoveObject.Checked = mode == 4;
        }
        private void toolRotate_Click(object sender, EventArgs e)
        {
            SetMode(0);
        }

        private void toolMove_Click(object sender, EventArgs e)
        {
            SetMode(1);
        }

        private void toolResetView_Click(object sender, EventArgs e)
        {
            rotX = 20;
            rotZ = 0;
            zoom = 1.0f;
            viewCenter = new Vector3(0.25f * ps.PrintAreaWidth, ps.PrintAreaDepth * 0.25f, 0.0f * ps.PrintAreaHeight);
            userPosition = new Vector3(0.25f * ps.PrintAreaWidth, -2f * ps.PrintAreaDepth, 2.0f * ps.PrintAreaHeight);
            viewCenter = new Vector3(0f * ps.PrintAreaWidth, ps.PrintAreaDepth * 0f, 0.0f * ps.PrintAreaHeight);
            userPosition = new Vector3(0f * ps.PrintAreaWidth, -2f * ps.PrintAreaDepth, 0.0f * ps.PrintAreaHeight);
            gl.Invalidate();
        }

        private void toolMoveViewpoint_Click(object sender, EventArgs e)
        {
            SetMode(2);
        }

        private void toolZoom_Click(object sender, EventArgs e)
        {
            SetMode(3);
        }

        private void toolMoveObject_Click(object sender, EventArgs e)
        {
            SetMode(4);
        }

        private void ThreeDControl_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                zoom *= 1.05f;
                if (zoom > 10) zoom = 10;
                gl.Invalidate();
            }
            if (e.KeyChar == '+')
            {
                zoom *= 0.95f;
                if (zoom < 0.01) zoom = 0.01f;
                gl.Invalidate();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!autoupdateable) return;
            if (toolAutoupdate.Checked == false) return;
            foreach (ThreeDModel m in models)
            {
                if (m.Changed)
                {
                    gl.Invalidate();
                    return;
                }
            }
        }

        private void toolStripClear_Click(object sender, EventArgs e)
        {
            foreach (ThreeDModel m in models)
            {
                m.Clear();
            }
            gl.Invalidate();
        }

        private void toolAutoupdate_Click(object sender, EventArgs e)
        {
            toolAutoupdate.Checked = !toolAutoupdate.Checked;
        }
    }
}
