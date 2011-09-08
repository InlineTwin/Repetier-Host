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
using System.ComponentModel;

namespace RepetierHost.model
{
    public delegate void OnEEPROMAdded(EEPROMParameter param);

    public class EEPROMParameter
    {
        public string description;
        public int type;
        public int position;
        string val="";
        bool changed = false;

        public EEPROMParameter(string line)
        {
            update(line);
        }
        public void update(string line)
        {
            string[] lines = line.Substring(4).Split(' ');
            int.TryParse(lines[0], out type);
            int.TryParse(lines[1], out position);
            val = lines[2];
            description = line.Substring(7+lines[0].Length+lines[1].Length+lines[2].Length);
            changed = false;
        }
        public void save()
        {
            if (!changed) return; // nothing changed
            string cmd = "M206 T" + type + " P" + position + " ";
            if (type == 3) cmd += "X" + val;
            else cmd += "S" + val;
            Main.conn.injectManualCommand(cmd);
            changed = false;
        }
        //[DisplayName("Description")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        //[DisplayName("Value")]
        public string Value {
            get { return val; }
            set { if (val.Equals(value)) return; val = value; changed = true; }
        }
    }
    public class EEPROMStorage
    {
        public Dictionary<int,EEPROMParameter> list;
        public event OnEEPROMAdded eventAdded = null;

        public EEPROMStorage()
        {
            list = new Dictionary<int,EEPROMParameter>();
        }
        public void Clear()
        {
            list.Clear();
        }
        public void Save()
        {
            foreach (EEPROMParameter p in list.Values)
                p.save();
        }
        public void Add(string line)
        {
            if (!line.StartsWith("EPR:")) return;
            EEPROMParameter p = new EEPROMParameter(line);
            if (list.ContainsKey(p.position))
                list.Remove(p.position);
            list.Add(p.position, p);
            if (eventAdded != null)
                Main.main.Invoke(eventAdded, p);
        }
        public void Update()
        {
            Main.conn.injectManualCommand("M205");
        }
        public EEPROMParameter Get(int pos)
        {
            return list[pos];
        }
    }
}
