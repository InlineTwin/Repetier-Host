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
using OpenTK.Graphics.OpenGL;
using System.IO;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;

namespace RepetierHost.model
{
    public class STLTriangle : IComparer<STLTriangle>
    {
        public Vector3 normal;
        public Vector3 p1,p2,p3;
        public int Compare(STLTriangle x, STLTriangle y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    // If x is null and y is null, they're
                    // equal. 
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y
                    // is greater. 
                    return -1;
                }
            }
            else
            {
                // If x is not null...
                //
                if (y == null)
                {
                    return 1;
                }
                else
                {
                    float xmin = Math.Min(x.p1.Z, Math.Min(x.p2.Z, x.p3.Z));
                    float ymin = Math.Min(y.p1.Z, Math.Min(y.p2.Z, y.p3.Z));
                    return xmin < ymin ? -1 : (xmin > ymin ? 1 : 0);
                }
            }
        }
    }
    public class STL: ThreeDModel
    {
        public LinkedList<STLTriangle> list;
        public string name="Unknown";
        public float xMin=0, yMin=0, zMin=0, xMax=0, yMax=0, zMax=0;
        public Matrix4 trans;
        public void Load(string file)
        {
            list = new LinkedList<STLTriangle>();
            try
            {
                FileStream f = File.OpenRead(file);
                byte[] header = new byte[80];
                ReadArray(f, header);
             /*   if (header[0] == 's' && header[1] == 'o' && header[2] == 'l' && header[3] == 'i' && header[4] == 'd')
                {
                    f.Close();
                    LoadText(file);
                }
                else
                {*/
                    BinaryReader r = new BinaryReader(f);
                    int nTri = r.ReadInt32();
                    if (f.Length != 84 + nTri * 50)
                    {
                        f.Close();
                        LoadText(file);
                    }
                    else
                    {
                        for (int i = 0; i < nTri; i++)
                        {
                            STLTriangle tri = new STLTriangle();
                            tri.normal = new Vector3(r.ReadSingle(), r.ReadSingle(), r.ReadSingle());
                            tri.p1 = new Vector3(r.ReadSingle(), r.ReadSingle(), r.ReadSingle());
                            tri.p2 = new Vector3(r.ReadSingle(), r.ReadSingle(), r.ReadSingle());
                            tri.p3 = new Vector3(r.ReadSingle(), r.ReadSingle(), r.ReadSingle());
                            list.AddLast(tri);
                            r.ReadUInt16();
                        }
                        r.Close();
                        f.Close();
                    }
                //}
                FileInfo info = new FileInfo(file);
                name = info.Name;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error reading STL file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override string ToString()
        {
            return name;
        }
        /// <summary>
        /// Translate Object, so that the lowest point is 0.
        /// </summary>
        public void Land()
        {
            UpdateBoundingBox();
            Position.z -= zMin;
        }
        public void Center(float x, float y)
        {
            Land();
            Position.x += x - 0.5f * (xMax + xMin);
            Position.y += y - 0.5f * (yMax + yMin);
        }
        public void UpdateMatrix()
        {
            Matrix4 transl = Matrix4.CreateTranslation(Position.x, Position.y, Position.z);
            Matrix4 scale = Matrix4.Scale(Scale.x, Scale.y, Scale.z);
            Matrix4 rotx = Matrix4.CreateRotationX(Rotation.x*(float)Math.PI/180.0f);
            Matrix4 roty = Matrix4.CreateRotationY(Rotation.y*(float)Math.PI / 180.0f);
            Matrix4 rotz = Matrix4.CreateRotationZ(Rotation.z * (float)Math.PI / 180.0f);
            trans = Matrix4.Mult(scale, rotx);
            trans = Matrix4.Mult(trans, roty);
            trans = Matrix4.Mult(trans, rotz);
            trans = Matrix4.Mult(trans, transl);
        }
        public void UpdateBoundingBox()
        {
            UpdateMatrix();
            xMin = yMin = zMin = float.MaxValue;
            xMax = yMax = zMax = float.MinValue;

            foreach (STLTriangle tri in list)
            {
                includePoint(ref tri.p1);
                includePoint(ref tri.p2);
                includePoint(ref tri.p3);
            }
        }
        private void includePoint(ref Vector3 v) {
            float x, y, z;
            Vector4 v4 = new Vector4(v, 1);
            x = Vector4.Dot(trans.Column0, v4);
            y = Vector4.Dot(trans.Column1, v4);
            z = Vector4.Dot(trans.Column2, v4);
            xMin = Math.Min(xMin, x);
            xMax = Math.Max(xMax, x);
            yMin = Math.Min(yMin, y);
            yMax = Math.Max(yMax, y);
            zMin = Math.Min(zMin, z);
            zMax = Math.Max(zMax, z);
        }
        public void TransformPoint(ref Vector3 v,out float x,out float y,out float z)
        {
            Vector4 v4 = new Vector4(v, 1);
            x = Vector4.Dot(trans.Column0, v4);
            y = Vector4.Dot(trans.Column1, v4);
            z = Vector4.Dot(trans.Column2, v4);
        }
        float[] points = null;
        float[] normals = null;
        int[] triangles = null;
        int[] edges = null;
        int[] bufs = null;
        public override void Paint()
        {
            bool useVBOs = Main.threeDSettings.useVBOs.Checked;
            if (useVBOs && bufs == null)
            {
                bufs = new int[4];
                GL.GenBuffers(4, bufs);
                int nv = list.Count * 3;
                points = new float[nv*3];
                normals = new float[nv*3];
                triangles = new int[nv];
                edges = new int[2 * nv];
                int pos = 0;
                int epos = 0;
                int tpos = 0;
                int ppos = 0;
                foreach (STLTriangle tri in list)
                {
                    edges[epos++] = pos;
                    edges[epos++] = pos+1;
                    edges[epos++] = pos+1;
                    edges[epos++] = pos+2;
                    edges[epos++] = pos+2;
                    edges[epos++] = pos;
                    triangles[tpos++] = pos;
                    triangles[tpos++] = pos+1;
                    triangles[tpos++] = pos+2;
                    normals[ppos] = tri.normal.X;
                    points[ppos++] = tri.p1.X;
                    normals[ppos] = tri.normal.Y;
                    points[ppos++] = tri.p1.Y;
                    normals[ppos] = tri.normal.Z;
                    points[ppos++] = tri.p1.Z;
                    normals[ppos] = tri.normal.X;
                    points[ppos++] = tri.p2.X;
                    normals[ppos] = tri.normal.Y;
                    points[ppos++] = tri.p2.Y;
                    normals[ppos] = tri.normal.Z;
                    points[ppos++] = tri.p2.Z;
                    normals[ppos] = tri.normal.X;
                    points[ppos++] = tri.p3.X;
                    normals[ppos] = tri.normal.Y;
                    points[ppos++] = tri.p3.Y;
                    normals[ppos] = tri.normal.Z;
                    points[ppos++] = tri.p3.Z;
                    pos += 3;
                }
                GL.BindBuffer(BufferTarget.ArrayBuffer, bufs[0]);
                GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(points.Length * sizeof(float)), points, BufferUsageHint.StaticDraw);
                GL.BindBuffer(BufferTarget.ArrayBuffer, bufs[1]);
                GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(normals.Length * sizeof(float)), normals, BufferUsageHint.StaticDraw);
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, bufs[2]);
                GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(triangles.Length * sizeof(int)), triangles, BufferUsageHint.StaticDraw);
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, bufs[3]);
                GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(edges.Length * sizeof(int)), edges, BufferUsageHint.StaticDraw);
            }
            Color col;
            if (Selected)
                col = Main.threeDSettings.selectedFaces.BackColor;
            else
                col = Main.threeDSettings.faces.BackColor;
            GL.Material(MaterialFace.FrontAndBack,MaterialParameter.Ambient,new OpenTK.Graphics.Color4(col.R, col.G, col.B, 255));
            GL.Material(MaterialFace.FrontAndBack,MaterialParameter.Diffuse,new OpenTK.Graphics.Color4(col.R,col.G,col.B, 255));
            GL.Material(MaterialFace.Front,MaterialParameter.Emission,new OpenTK.Graphics.Color4(0,0,0,0));
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
            GL.Material(MaterialFace.Front, MaterialParameter.Shininess, 50f);
            if (useVBOs)
            {
                GL.EnableClientState(ArrayCap.VertexArray);
                GL.EnableClientState(ArrayCap.NormalArray);
                GL.BindBuffer(BufferTarget.ArrayBuffer, bufs[0]);
                GL.VertexPointer(3, VertexPointerType.Float, 0, 0);
                GL.BindBuffer(BufferTarget.ArrayBuffer, bufs[1]);
                GL.NormalPointer(NormalPointerType.Float, 0, 0);
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, bufs[2]);

                GL.DrawElements(BeginMode.Triangles, triangles.Length, DrawElementsType.UnsignedInt, 0);
                if (Main.threeDSettings.showEdges.Checked)
                {
                    col = Main.threeDSettings.edges.BackColor;
                    GL.Material(
                        MaterialFace.Front,
                        MaterialParameter.Emission,
                        new OpenTK.Graphics.Color4(col.R, col.G, col.B, col.A));
                    GL.BindBuffer(BufferTarget.ElementArrayBuffer, bufs[3]);
                    GL.DrawElements(BeginMode.Lines, edges.Length, DrawElementsType.UnsignedInt, 0);
                }
                GL.DisableClientState(ArrayCap.VertexArray);
                GL.DisableClientState(ArrayCap.NormalArray);
            }
            else
            {
                GL.Begin(BeginMode.Triangles);
                foreach (STLTriangle tri in list)
                {
                    GL.Normal3(tri.normal);
                    GL.Vertex3(tri.p1);
                    GL.Vertex3(tri.p2);
                    GL.Vertex3(tri.p3);
                }
                GL.End();
            }
            // Draw edges
            if (Main.threeDSettings.showEdges.Checked && !useVBOs)
            {
                col = Main.threeDSettings.edges.BackColor;
                GL.Material(
                    MaterialFace.Front,
                    MaterialParameter.Emission,
                    new OpenTK.Graphics.Color4(col.R, col.G, col.B, col.A));
                GL.Begin(BeginMode.Lines);
                foreach (STLTriangle tri in list)
                {
                    GL.Vertex3(tri.p1);
                    GL.Vertex3(tri.p2);
                    GL.Vertex3(tri.p2);
                    GL.Vertex3(tri.p3);
                    GL.Vertex3(tri.p3);
                    GL.Vertex3(tri.p1);
                }
                GL.End();
            }
        }
        /// <summary>
        /// solid
        ///  facet normal -1.000000 -0.000000 -0.000000
        /// outer loop
        /// vertex -12.000000 -12.000000 0.000000
        /// vertex -12.000000 -12.000000 24.000000
        /// vertex -12.000000 12.000000 0.000000
        /// endloop
        /// endfacet

        /// </summary>
        /// <param name="file"></param>
        private void LoadText(string file)
        {
            string text = System.IO.File.ReadAllText(file);
            int lastP = 0,p,pend,normal,outer,vertex,vertex2;
            while((p = text.IndexOf("facet",lastP))>0) {
                pend = text.IndexOf("endfacet", p + 5);
                normal = text.IndexOf("normal", p) + 6;
                outer = text.IndexOf("outer loop",normal);
                STLTriangle tri = new STLTriangle();
                tri.normal = extractVector(text.Substring(normal,outer-normal));
                outer+=10;
                vertex = text.IndexOf("vertex",outer)+6;
                vertex2 = text.IndexOf("vertex",vertex);
                tri.p1 = extractVector(text.Substring(vertex,vertex2-vertex));
                vertex2 += 7;
                vertex = text.IndexOf("vertex",vertex2);
                tri.p2 = extractVector(text.Substring(vertex2,vertex-vertex2));
                vertex += 7;
                vertex2 = text.IndexOf("endloop", vertex);
                tri.p3 = extractVector(text.Substring(vertex, vertex2 - vertex));
                lastP = pend + 8;
                list.AddLast(tri);
            }
        }
        private Vector3 extractVector(string s)
        {
            Vector3 v = new Vector3() ;
            s = s.Trim();
            int p = s.IndexOf(' ');
            if (p < 0) throw new Exception("Format error");
            float.TryParse(s.Substring(0, p),NumberStyles.Float,GCode.format, out v.X);
            s = s.Substring(p).Trim();
            p = s.IndexOf(' ');
            if (p < 0) throw new Exception("Format error");
            float.TryParse(s.Substring(0, p), NumberStyles.Float, GCode.format, out v.Y);
            s = s.Substring(p).Trim();
            float.TryParse(s, NumberStyles.Float, GCode.format, out v.Z);
            return v;
        }
        public void ReadArray(Stream stream, byte[] data)
        {
            int offset = 0;
            int remaining = data.Length;
            while (remaining > 0)
            {
                int read = stream.Read(data, offset, remaining);
                if (read <= 0)
                    throw new EndOfStreamException
                        (String.Format("End of stream reached with {0} bytes left to read", remaining));
                remaining -= read;
                offset += read;
            }
        }

    }
}
