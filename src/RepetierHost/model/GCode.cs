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
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace RepetierHost.model
{
    /// <summary>
    /// Stores the complete data of a gcode command in an easy 
    /// accessible data structure. This structure can be converted
    /// into a binary or ascii representation to be send to a
    /// reprap printer.
    /// </summary>
    public class GCode
    {
        public static NumberFormatInfo format = CultureInfo.InvariantCulture.NumberFormat;
        private ushort fields = 128;
        int n;
        private byte g = 0, m = 0, t = 0;
        private float x, y, z, e, f;
        private int s;
        private int p;
        private String text = null;

        public bool hasText { get { return (fields & 32768) != 0; } }
        public String Text
        {
            get { return text; }
            set { text = value; if (text.Length > 16) text = text.Substring(0, 16); fields |= 32768; }
        }
        public bool hasN { get { return (fields & 1) != 0; } }
        public int N
        {
            get { return n; }
            set { n = value; fields |= 1; }
        }
        public bool hasM {get { return (fields & 2) != 0; }}
        public byte M
        {
            get { return m; }
            set { m = value; fields |= 2; }
        }
        public bool hasG { get { return (fields & 4) != 0; } }
        public byte G
        {
            get { return g; }
            set { g = value; fields |= 4; }
        }
        public bool hasT { get { return (fields & 512) != 0; } }
        public byte T
        {
            get { return t; }
            set { t = value; fields |= 512; }
        }
        public bool hasS { get { return (fields & 1024) != 0; } }
        public int S
        {
            get { return s; }
            set { s = value; fields |= 1024; }
        }
        public bool hasP { get { return (fields & 2048) != 0; } }
        public int P
        {
            get { return p; }
            set { p = value; fields |= 2048; }
        }

        public bool hasX { get { return (fields & 8) != 0; } }
        public float X
        {
            get { return x; }
            set { x=value;fields|=8;}
        }
        public bool hasY { get { return (fields & 16) != 0; } }
        public float Y
        {
            get { return y; }
            set { y = value; fields |= 16; }
        }
        public bool hasZ { get { return (fields & 32) != 0; } }
        public float Z
        {
            get { return z; }
            set { z = value; fields |= 32; }
        }
        public bool hasE { get { return (fields & 64) != 0; } }
        public float E
        {
            get { return e; }
            set { e = value; fields |= 64; }
        }
        public bool hasF { get { return (fields & 256) != 0; } }
        public float F
        {
            get { return f; }
            set { f = value; fields |= 256; }
        }
        /// <summary>
        /// Converts a gcode line into a binary representation.
        /// </summary>
        /// <param name="version">Binary protocol version</param>
        /// <returns></returns>
        public byte[] getBinary(int version)
        {
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms,Encoding.ASCII);
            bw.Write(fields);
            if (hasN) bw.Write((ushort)(n & 65535));
            if (hasM) bw.Write(m);
            if (hasG) bw.Write(g);
            if (hasX) bw.Write(x);
            if (hasY) bw.Write(y);
            if (hasZ) bw.Write(z);
            if (hasE) bw.Write(e);
            if (hasF) bw.Write(f);
            if (hasT) bw.Write(t);
            if (hasS) bw.Write(s);
            if (hasP) bw.Write(p);
            if (hasText)
            {
                int i, len = text.Length;
                if (len > 16) len = 16;
                for (i = 0; i < len; i++)
                {
                    bw.Write((byte)text[i]);
                }
                for(;i<16;i++) bw.Write((byte)0);
            }
            // compute fletcher-16 checksum
            int sum1 = 0, sum2 = 0;
            bw.Flush();
            ms.Flush();
            byte[] buf = ms.ToArray();
            foreach (byte c in buf)
            {
                sum1 = (sum1 + c) % 255;
                sum2 = (sum2 + sum1) % 255;
            }
            bw.Write((byte)sum1);
            bw.Write((byte)sum2);
            bw.Close();
            ms.Flush();
            return ms.ToArray();
        }
        public String getAscii(bool inclLine,bool inclChecksum)
        {
            StringBuilder s = new StringBuilder();
            if (inclLine && hasN)
            {
                s.Append("N");
                s.Append(n);
                s.Append(" ");
            }
            if (hasM)
            {
                s.Append("M");
                s.Append(m);
            }
            if (hasG)
            {
                s.Append("G");
                s.Append(g);
            }
            if (hasT)
            {
                if (hasM) s.Append(" ");
                s.Append("T");
                s.Append(t);
            }
            if (hasX)
            {
                s.Append(" X");
                s.Append(x.ToString(format));
            }
            if (hasY)
            {
                s.Append(" Y");
                s.Append(y.ToString(format));
            }
            if (hasZ)
            {
                s.Append(" Z");
                s.Append(z.ToString(format));
            }
            if (hasE)
            {
                s.Append(" E");
                s.Append(e.ToString(format));
            }
            if (hasF)
            {
                s.Append(" F");
                s.Append(f.ToString(format));
            }
            if (hasS)
            {
                s.Append(" S");
                s.Append(this.s);
            }
            if (hasP)
            {
                s.Append(" P");
                s.Append(p);
            }
            if (hasText)
            {
                s.Append(" ");
                s.Append(text);
            }
            if (inclChecksum)
            {
                int check = 0;
                foreach (char ch in s.ToString()) check ^= (ch & 0xff);
                check ^= 32;
                s.Append(" *");
                s.Append(check);
            }
            return s.ToString();
        }
        public void Parse(String line)
        {
            fields = 128;
            int iv;
            float fv;
            if (line.IndexOf(';') >= 0) line = line.Substring(0, line.IndexOf(';')); // Strip comments
            if (ExtractInt(line, "G", out iv)) G = (byte)iv;
            if (ExtractInt(line, "M", out iv)) M = (byte)iv;
            if (ExtractInt(line, "T", out iv)) T = (byte)iv;
            if (ExtractInt(line, "S", out iv)) S = iv;
            if (ExtractInt(line, "P", out iv)) P = iv;
            if (ExtractFloat(line, "X", out fv)) X = fv;
            if (ExtractFloat(line, "Y", out fv)) Y = fv;
            if (ExtractFloat(line, "Z", out fv)) Z = fv;
            if (ExtractFloat(line, "E", out fv)) E = fv;
            if (ExtractFloat(line, "F", out fv)) F = fv;
            if (hasM && (m == 23 || m == 28 || m == 29))
            {
                int pos = line.IndexOf('M') + 3;
                while (pos < line.Length && char.IsWhiteSpace(line[pos])) pos++;
                int end = pos;
                while (end < line.Length && !char.IsWhiteSpace(line[end])) end++;
                Text = line.Substring(pos, end - pos);
            }
        }
        private bool ExtractInt(string s,string code,out int value) {
            value = 0;
            int p = s.IndexOf(code);
            if (p < 0) return false;
            p++;
            int end = p;
            while(end<s.Length && char.IsDigit(s[end])) end++;
            int.TryParse(s.Substring(p,end-p),out value);
            return true;
        }
        private bool ExtractFloat(string s, string code, out float value)
        {
            value = 0;
            int p = s.IndexOf(code);
            if (p < 0) return false;
            p++;
            int end = p;
            while (end < s.Length && !char.IsWhiteSpace(s[end])) end++;

            float.TryParse(s.Substring(p, end - p), NumberStyles.Float, format, out value);
            return true;
        }
        public override string ToString()
        {
            return getAscii(true,true);
        }
    }
}
