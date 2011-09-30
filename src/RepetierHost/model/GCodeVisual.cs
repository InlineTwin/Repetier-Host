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
using System.Linq;
using System.Text;
using OpenTK;
//using OpenTK.Graphics;
using OpenTK.Platform;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.Windows.Forms;

namespace RepetierHost.model
{
    public class GCodePath
    {
        public int drawMethod = -1;
        public float[] positions = null;
        public float[] normals = null;
        public int[] elements = null;
        public int[] buf = new int[3];
        public LinkedList<Vector3> points = new LinkedList<Vector3>();
        public void Add(Vector3 v)
        {
            points.AddLast(v);
            drawMethod = -1; // invalidate old 
        }
        public void Free()
        {
            if (elements != null)
            {
                elements = null;
                normals = null;
                positions = null;
                points.Clear();
                GL.DeleteBuffers(3, buf);
            }
        }
        public void UpdateVBO()
        {
            if (points.Count < 2) return;
            if (elements != null)
                GL.DeleteBuffers(3, buf);
            int method = Main.threeDSettings.filamentVisualization;
            float h = Main.threeDSettings.layerHeight;
            float w = h * Main.threeDSettings.widthOverHeight;
            int nv = 8 * (method - 1), i;
            if (method == 1) nv = 4;
            if (method == 0) nv = 1;
            int n = nv * (method == 0 ? 1 : 2) * (points.Count-1);
            if (method != 0) positions = new float[n * 3]; else positions = new float[3 * points.Count];
            if (method != 0) normals = new float[n * 3]; else normals = null;
            if (method != 0) elements = new int[(points.Count-1)*nv * 4]; else elements = new int[n * 2];
            int pos = 0;
            int npos = 0;
            int vpos = 0;
            if (method > 0)
            {
                float alpha, dalpha = (float)Math.PI * 2f / nv;
                float[] dir = new float[3];
                float[] dirs = new float[3];
                float[] diru = new float[3];
                float[] norm = new float[3];
                float dh = 0.5f * h;
                float dw = 0.5f * w;
                bool first = true;
                Vector3 last = new Vector3();
                w *= 0.5f;
                int nv2 = 2*nv;
                foreach (Vector3 v in points)
                {
                    if (first)
                    {
                        last = v;
                        first = false;
                        continue;
                    }
                    bool isLast = v == points.Last.Value;
                    dir[0] = v.X - last.X;
                    dir[1] = v.Y - last.Y;
                    dir[2] = v.Z - last.Z;
                    GCodeVisual.normalize(ref dir);
                    dirs[0] = -dir[1];
                    dirs[1] = dir[0];
                    dirs[2] = dir[2];
                    diru[0] = diru[1] = 0;
                    diru[2] = 1;
                    alpha = 0;
                    float c, s;
                    int b = vpos / 3;
                    for (i = 0; i < nv; i++)
                    {
                        c = (float)Math.Cos(alpha) * dh;
                        s = (float)Math.Sin(alpha) * dw;
                        norm[0] = (float)(s * dirs[0] + c * diru[0]);
                        norm[1] = (float)(s * dirs[1] + c * diru[1]);
                        norm[2] = (float)(s * dirs[2] + c * diru[2]);
                        GCodeVisual.normalize(ref norm);
                        elements[pos++] = b + i*2;//1
                        elements[pos++] = b + (i * 2 + nv2 - 2) % nv2;//2
                        elements[pos++] = b + (i * 2 + nv2 - 1) % nv2;//3
                        elements[pos++] = b + (i * 2 + 1);//4
                        normals[npos++] = norm[0];
                        normals[npos++] = norm[1];
                        normals[npos++] = norm[2];
                        normals[npos++] = norm[0];
                        normals[npos++] = norm[1];
                        normals[npos++] = norm[2];
                        positions[vpos++] = last.X + s * dirs[0] + c * diru[0];
                        positions[vpos++] = last.Y + s * dirs[1] + c * diru[1];
                        positions[vpos++] = last.Z - dh + s * dirs[2] + c * diru[2];
                        positions[vpos++] = v.X + s * dirs[0] + c * diru[0];
                        positions[vpos++] = v.Y + s * dirs[1] + c * diru[1];
                        positions[vpos++] = v.Z - dh + s * dirs[2] + c * diru[2];
                        alpha += dalpha;
                    }
                    last = v;
                }
                GL.GenBuffers(3, buf);
                GL.BindBuffer(BufferTarget.ArrayBuffer, buf[0]);
                GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(positions.Length * sizeof(float)), positions, BufferUsageHint.StaticDraw); 
                GL.BindBuffer(BufferTarget.ArrayBuffer, buf[1]);
                GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(normals.Length * sizeof(float)), normals, BufferUsageHint.StaticDraw);
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, buf[2]);
                GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(elements.Length * sizeof(int)), elements, BufferUsageHint.StaticDraw);
            }
            else
            {
                // Draw edges
                bool first = true;
                foreach (Vector3 v in points)
                {
                    positions[vpos++] = v.X;
                    positions[vpos++] = v.Y;
                    positions[vpos++] = v.Z;

                    if (!first)
                    {
                        elements[pos] = pos / 2;
                        elements[pos + 1] = pos / 2 + 1;
                        pos += 2;
                    }
                    first = false;
                }
                GL.GenBuffers(3, buf);
                GL.BindBuffer(BufferTarget.ArrayBuffer, buf[0]);
                GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(positions.Length * sizeof(float)), positions, BufferUsageHint.StaticDraw);
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, buf[2]);
                GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(elements.Length * sizeof(int)), elements, BufferUsageHint.StaticDraw);
            }
            drawMethod = method;
        }
    }
    public class GCodeVisual : ThreeDModel
    {
        LinkedList<GCodePath> segments = new LinkedList<GCodePath>();
        GCodeAnalyzer ana = new GCodeAnalyzer(true);
        public GCode act = null;
        public float lastFilHeight = 999;
        public float lastFilWidth = 999;
        public float laste = -999;
        float lastx = 1e20f, lasty = 0, lastz = 0;
        bool changed = false;
        public bool startOnClear = false;

        public GCodeVisual()
        {
            ana = new GCodeAnalyzer(true);
            startOnClear = true;
            ana.eventPosChanged += OnPosChange;
        }
        public GCodeVisual(GCodeAnalyzer a)
        {
            ana = a;
            startOnClear = false;
            ana.eventPosChanged += OnPosChange;
        }

        /// <summary>
        /// Add a GCode line to be visualized.
        /// </summary>
        /// <param name="g"></param>
        public void AddGCode(GCode g)
        {
            act = g;
            ana.Analyze(g);
            laste = ana.emax;
        }
        /// <summary>
        /// Remove all drawn lines.
        /// </summary>
        public override void Clear()
        {
            foreach (GCodePath p in segments)
                p.Free();
            segments.Clear();
            lastx = 1e20f; // Don't ignore first point if it was the last! 
            if(startOnClear)
                ana.start();
        }
        void OnPosChange(GCode act,float x, float y, float z)
        {
            bool isLastPos = Math.Abs(x-lastx)+Math.Abs(y-lasty)+Math.Abs(z-lastz)<0.00001;
            if (!act.hasG || (act.G > 1 && act.G!=28)) return;
            if (segments.Count == 0 || laste >= ana.e) // start new segment
            {
                if (!isLastPos) // no move, no action
                {
                    GCodePath p = new GCodePath();
                    p.Add(new Vector3(x, y, z));
                    if (segments.Count > 0 && segments.Last.Value.points.Count == 1)
                    {
                        segments.RemoveLast();
                    }
                    segments.AddLast(p);
                    changed = true;
                }
            }
            else
            {
                if (!isLastPos)
                {
                    segments.Last.Value.Add(new Vector3(x, y, z));
                    changed = true;
                }
            }
            lastx = x;
            lasty = y;
            lastz = z;
            laste = ana.emax;
        }
        public void ParseText(string text,bool clear)
        {
            GCode gc = new GCode();
            if(clear)
                Clear();
            foreach(string s in text.Split('\n'))  {
                gc.Parse(s);
                AddGCode(gc);
            }
        }
        public static void normalize(ref float[] n)
        {
            float d = (float)Math.Sqrt(n[0]*n[0]+n[1]*n[1]+n[2]*n[2]);
            n[0] /= d;
            n[1] /= d;
            n[2] /= d;
        }
        public override void Paint()
        {
            changed = false;
            //long timeStart = DateTime.Now.Ticks;
            Color col;
            col = Main.threeDSettings.filament.BackColor;
            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Ambient, new OpenTK.Graphics.Color4(col.R, col.G, col.B, 255));
            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Diffuse, new OpenTK.Graphics.Color4(col.R, col.G, col.B, 255));
            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Emission, new OpenTK.Graphics.Color4(0, 0, 0, 0));
            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Specular, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
            GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Shininess, 50f);
            int method = Main.threeDSettings.filamentVisualization;
            float h = Main.threeDSettings.layerHeight;
            float w = h * Main.threeDSettings.widthOverHeight;
            bool recompute = lastFilHeight != h || lastFilWidth != w;
            lastFilHeight = h;
            lastFilWidth = w;
            if (Main.threeDSettings.useVBOs.Checked)
            {
                GL.EnableClientState(ArrayCap.VertexArray);
                if(method!=0)
                    GL.EnableClientState(ArrayCap.NormalArray);
                foreach (GCodePath path in segments)
                {
                    if (path.drawMethod != method || recompute)
                        path.UpdateVBO();
                    if (path.elements == null) continue;
                    GL.BindBuffer(BufferTarget.ArrayBuffer, path.buf[0]);
                    GL.VertexPointer(3, VertexPointerType.Float, 0, 0);
                    if (method != 0)
                    {
                        GL.BindBuffer(BufferTarget.ArrayBuffer, path.buf[1]);
                        GL.NormalPointer(NormalPointerType.Float, 0, 0);
                    }
                    GL.BindBuffer(BufferTarget.ElementArrayBuffer, path.buf[2]);
                    if (method == 0)
                        GL.DrawElements(BeginMode.Lines, path.elements.Length, DrawElementsType.UnsignedInt, 0);

                    else
                        GL.DrawElements(BeginMode.Quads, path.elements.Length, DrawElementsType.UnsignedInt, 0);
                }
                GL.DisableClientState(ArrayCap.VertexArray);
                GL.DisableClientState(ArrayCap.NormalArray);
            }
            else
            {


                if (method > 0)
                {
                    int nv = 8 * (method - 1), i;
                    if (method == 1) nv = 4;
                    float alpha, dalpha = (float)Math.PI * 2f / nv;
                    float[] dir = new float[3];
                    float[] dirs = new float[3];
                    float[] diru = new float[3];
                    float[] n = new float[3];
                    float dh = 0.5f * h;
                    float dw = 0.5f * w;
                    GL.Begin(BeginMode.Quads);
                    foreach (GCodePath path in segments)
                    {
                        if (path.points.Count < 2) continue;
                        bool first = true;
                        Vector3 last = new Vector3();
                        w *= 0.5f;
                        foreach (Vector3 v in path.points)
                        {
                            if (first)
                            {
                                last = v;
                                first = false;
                                continue;
                            }
                            bool isLast = v == path.points.Last.Value;
                            dir[0] = v.X - last.X;
                            dir[1] = v.Y - last.Y;
                            dir[2] = v.Z - last.Z;
                            normalize(ref dir);
                            dirs[0] = -dir[1];
                            dirs[1] = dir[0];
                            dirs[2] = dir[2];
                            diru[0] = diru[1] = 0;
                            diru[2] = 1;
                            alpha = 0;
                            float c = (float)Math.Cos(alpha) * dh;
                            float s = (float)Math.Sin(alpha) * dw;
                            n[0] = (float)(s * dirs[0] + c * diru[0]);
                            n[1] = (float)(s * dirs[1] + c * diru[1]);
                            n[2] = (float)(s * dirs[2] + c * diru[2]);
                            normalize(ref n);
                            GL.Normal3(n[0], n[1], n[2]);
                            for (i = 0; i < nv; i++)
                            {
                                GL.Vertex3(last.X + s * dirs[0] + c * diru[0], last.Y + s * dirs[1] + c * diru[1], last.Z - dh + s * dirs[2] + c * diru[2]);
                                GL.Vertex3(v.X + s * dirs[0] + c * diru[0], v.Y + s * dirs[1] + c * diru[1], v.Z - dh + s * dirs[2] + c * diru[2]);
                                alpha += dalpha;
                                c = (float)Math.Cos(alpha) * dh;
                                s = (float)Math.Sin(alpha) * dw;
                                n[0] = (float)(s * dirs[0] + c * diru[0]);
                                n[1] = (float)(s * dirs[1] + c * diru[1]);
                                n[2] = (float)(s * dirs[2] + c * diru[2]);
                                normalize(ref n);
                                GL.Normal3(n[0], n[1], n[2]);
                                GL.Vertex3(v.X + s * dirs[0] + c * diru[0], v.Y + s * dirs[1] + c * diru[1], v.Z - dh + s * dirs[2] + c * diru[2]);
                                GL.Vertex3(last.X + s * dirs[0] + c * diru[0], last.Y + s * dirs[1] + c * diru[1], last.Z - dh + s * dirs[2] + c * diru[2]);
                            }
                            last = v;
                        }
                    }
                    GL.End();

                }
                else if (method == 0)
                {
                    // Draw edges
                    col = Main.threeDSettings.filament.BackColor;
                    GL.Material(
                        MaterialFace.Front,
                        MaterialParameter.Emission,
                        new OpenTK.Graphics.Color4(col.R, col.G, col.B, col.A));

                    GL.Begin(BeginMode.Lines);
                    foreach (GCodePath path in segments)
                    {
                        if (path.points.Count < 2) continue;
                        bool first = true;
                        foreach (Vector3 v in path.points)
                        {
                            GL.Vertex3(v);
                            if (!first && v != path.points.Last.Value)
                                GL.Vertex3(v);
                            first = false;
                        }
                    }
                    GL.End();
                }
            }
           // timeStart = DateTime.Now.Ticks - timeStart;
          //  double time = (double)timeStart * 0.1;
           // Main.conn.log("OpenGL paint time " + time.ToString("0.0", GCode.format) + " microseconds",false,4);
        }
        public override bool Changed
        {
            get
            {
                return changed;
            }
        }
    }
}
