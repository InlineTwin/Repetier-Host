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

namespace RepetierHost.model
{
    public delegate void OnPosChange(GCode code,float x,float y,float z);
    public delegate void OnAnalyzerChange();

    public class GCodeAnalyzer
    {
        public event OnPosChange eventPosChanged;
        public event OnAnalyzerChange eventChange;
        public int activeExtruder = 0;
        public int extruderTemp=0;
        public int bedTemp=0;
        public float x=0, y=0, z=0, e=0,emax=0;
        public float xOffset=0, yOffset=0, zOffset=0, eOffset=0;
        public bool fanOn = false;
        public int fanVoltage = 0;
        public bool powerOn = true;
        public bool relative = false;
        public bool eRelative = false;
        public int debugLevel = 6;
        public int lastline = 0;
        public bool hasXHome = false, hasYHome = false, hasZHome = false;
        public bool privateAnalyzer = false;
        public GCodeAnalyzer(bool privAnal)
        {
            privateAnalyzer = privAnal;
            extruderTemp = 0;
            bedTemp = 0;
        }
        public void fireChanged()
        {
            if (eventChange != null)
            {
                try
                {
                    Main.main.Invoke(eventChange);
                }
                catch { }
            }
        }
        // set to start condition
        public void start()
        {
            relative = false;
            eRelative = false;
            activeExtruder = 0;
            extruderTemp = 0;
            bedTemp = 0;
            fanOn = false;
            powerOn = true;
            fanVoltage = 0;
            lastline = 0;
            x = y = z = e = emax = 0;
            xOffset = yOffset = zOffset = eOffset = 0;
            hasXHome = hasYHome = hasZHome = false;
            fireChanged();
        }
        public void Analyze(GCode code)
        {
            if (code.hasN)
                lastline = code.N;
            if (code.hasG)
            {
                switch (code.G)
                {
                    case 0:
                    case 1:
                        if (relative)
                        {
                            if(code.hasX) x += code.X;
                            if(code.hasY) y += code.Y;
                            if(code.hasZ) z += code.Z;
                            if(code.hasE) e += code.E;
                        }
                        else
                        {
                            if (code.hasX) x = xOffset+code.X;
                            if (code.hasY) y = yOffset+code.Y;
                            if (code.hasZ) z = zOffset+code.Z;
                            if (code.hasE)
                            {
                                if (eRelative)
                                    e += code.E;
                                else
                                    e = eOffset + code.E;
                            }
                        }
                        if (x < 0) x = 0;
                        if (y < 0) y = 0;
                        if (z < 0) z = 0;
                        if (e > emax) emax = e;
                        if (eventPosChanged != null)
                            Main.main.Invoke(eventPosChanged,code, x, y, z);
                        break;
                    case 28:
                    case 161:
                        {
                            bool homeAll = !(code.hasX || code.hasY || code.hasZ);
                            if (code.hasX || homeAll) { xOffset = 0; x = 0; hasXHome = true; }
                            if (code.hasY || homeAll) { yOffset = 0; y = 0; hasYHome = true; }
                            if (code.hasZ || homeAll) { zOffset = 0; z = 0; hasZHome = true; }
                            if (code.hasE) { eOffset = 0; e = 0; emax = 0; }
                            if (eventPosChanged != null)
                                Main.main.Invoke(eventPosChanged, code, x, y, z);
                        }
                        break;
                    case 162:
                        {
                            bool homeAll = !(code.hasX || code.hasY || code.hasZ);
                            if (code.hasX || homeAll) { xOffset = 0; x = Main.printerSettings.PrintAreaWidth; hasXHome = true; }
                            if (code.hasY || homeAll) { yOffset = 0; y = Main.printerSettings.PrintAreaDepth; hasYHome = true; }
                            if (code.hasZ || homeAll) { zOffset = 0; z = Main.printerSettings.PrintAreaHeight; hasZHome = true; }
                            if (eventPosChanged != null)
                                Main.main.Invoke(eventPosChanged, code, x, y, z);
                        }
                        break;
                    case 90:
                        relative = false;
                        break;
                    case 91:
                        relative = true;
                        break;
                    case 92:
                        if (code.hasX) { xOffset = Math.Max(0,x-code.X); x = code.X; }
                        if (code.hasY) { yOffset = Math.Max(0,y-code.Y); y = code.Y; }
                        if (code.hasZ) { zOffset = Math.Max(0,z-code.Z); z = code.Z; }
                        if (code.hasE) { eOffset = Math.Max(0,e-code.E); e = code.E; }
                        if (eventPosChanged != null)
                            Main.main.Invoke(eventPosChanged,code, x, y, z);
                        break;
                }
            }
            else if (code.hasM)
            {
                switch (code.M)
                {
                    case 80:
                        powerOn = true;
                        fireChanged();
                        break;
                    case 81:
                        powerOn = false;
                        fireChanged();
                        break;
                    case 82:
                        eRelative = false;
                        break;
                    case 83:
                        eRelative = true;
                        break;
                    case 104:
                    case 109:
                        if (code.hasS) extruderTemp = code.S;
                        fireChanged();
                        break;
                    case 106:
                        fanOn = true;
                        if (code.hasS) fanVoltage = code.S;
                        fireChanged();
                        break;
                    case 107:
                        fanOn = false;
                        fireChanged();
                        break;
                    case 110:
                        lastline = code.N;
                        break;
                    case 111:
                        if (code.hasS)
                        {
                            debugLevel = code.S;
                        }
                        break;
                    case 140:
                    case 141:
                        if (code.hasS) bedTemp = code.S;
                        fireChanged();
                        break;
                }
            }
            else if (code.hasT)
            {
                activeExtruder = code.T;
            }
        }
    }
}
