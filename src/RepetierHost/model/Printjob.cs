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
    public class Printjob
    {
        public class PrintTime
        {
            public int line;
            public long time;
        }
        public bool dataComplete = false;
        public int totalLines;
        public int linesSend;
        public int mode = 0; // 0 = no job defines, 1 = printing, 2 = finished, 3 = aborted
        public DateTime jobStarted, jobFinished;
        LinkedList<GCode> jobList = new LinkedList<GCode>();
        LinkedList<PrintTime> times = new LinkedList<PrintTime>();
        PrinterConnection con;

        public Printjob(PrinterConnection c)
        {
            con = c;
        }

        public void BeginJob()
        {
            con.firePrinterAction("Building print job...");
            dataComplete = false;
            jobList.Clear();
            times.Clear();
            totalLines = 0;
            linesSend = 0;
            mode = 1;
            Main.main.Invoke(Main.main.UpdateJobButtons);
        }
        public void EndJob()
        {
            if (jobList.Count == 0)
            {
                mode = 0;
                con.firePrinterAction("Idle");
                Main.main.Invoke(Main.main.UpdateJobButtons);
                return;
            }
            dataComplete = true;
            jobStarted = DateTime.Now;
            con.firePrinterAction("Printing...");
        }
        public void KillJob()
        {
            if (dataComplete == false && jobList.Count == 0) return;
            dataComplete = false;
            jobFinished = DateTime.Now;
            jobList.Clear();
            mode = 3;
            Main.main.Invoke(Main.main.UpdateJobButtons);
            con.firePrinterAction("Job killed");
            DoEndKillActions();
        }
        public void DoEndKillActions()
        {
            con.GetInjectLock();
            if (con.afterJobDisableExtruder)
            {
                con.injectManualCommand("M104 S0");
            }
            if(con.afterJobDisablePrintbed) 
                con.injectManualCommand("M140 S0");
            con.ReturnInjectLock();
            if (con.afterJobGoDispose)
                con.doDispose();
        }
        public void PushData(string code)
        {
            code = code.Replace('\r', '\n');
            string[] lines = code.Split('\n');
            foreach (string line in lines)
            {
                if (line.Length == 0) continue;
                GCode gcode = new GCode();
                gcode.Parse(line);
                jobList.AddLast(gcode);
                totalLines++;
            }
        }
        /// <summary>
        /// Check, if more data is stored
        /// </summary>
        /// <returns></returns>
        public bool hasData()
        {
            return linesSend < totalLines;
        }
        public GCode PeekData()
        {
            if (jobList.Count == 0) return null;
            return jobList.First.Value;
        }
        public GCode PopData()
        {
            if (jobList.Count == 0) return null;
            linesSend++;
            GCode gc = jobList.First.Value;
            jobList.RemoveFirst();
            PrintTime pt = new PrintTime();
            pt.line = linesSend;
            pt.time = DateTime.Now.Ticks;
            lock (times)
            {
                times.AddLast(pt);
                if (times.Count > 1500)
                    times.RemoveFirst();
            }
            if (jobList.Count == 0)
            {
                dataComplete = false;
                mode = 2;
                jobFinished = DateTime.Now;
                long ticks = (jobFinished.Ticks - jobStarted.Ticks) / 10000;
                long hours = ticks / 3600000;
                ticks -= 3600000 * hours;
                long min = ticks / 60000;
                ticks -= 60000 * min;
                long sec = ticks / 1000;
                Main.conn.log("Printjob finished at " + jobFinished.ToShortDateString()+" "+jobFinished.ToShortTimeString(),false,3);
                StringBuilder s = new StringBuilder();
                if (hours > 0)
                {
                    s.Append(hours);
                    s.Append("h:");
                }
                if (min > 0)
                {
                    s.Append(min);
                    s.Append("m:");
                }
                s.Append(sec);
                s.Append("s");
                Main.conn.log("printing time:"+s.ToString(),false,3);
                Main.conn.log("lines send:" + linesSend.ToString(), false, 3);
                Main.conn.firePrinterAction("Finished in "+s.ToString());
                DoEndKillActions();
                Main.main.Invoke(Main.main.UpdateJobButtons);
            }
            return gc;
        }
        public float PercentDone {
            get {
              if(totalLines==0) return 100f;
              return 100f*(float)linesSend/(float)totalLines;
            }
        }
        public String ETA {
            get {
                if (linesSend < 3) return "---";
                try
                {
                    long ticks = 0;
                    lock (times)
                    {
                        if (times.Count > 100)
                        {
                            PrintTime t1 = times.First.Value;
                            PrintTime t2 = times.Last.Value;
                            ticks = (t2.time - t1.time) / 10000 * (totalLines - linesSend) / (t2.line - t1.line + 1);
                        }
                        else
                            ticks = (DateTime.Now.Ticks - jobStarted.Ticks) / 10000 * (totalLines - linesSend) / linesSend; // Milliseconds
                    }

                    long hours = ticks / 3600000;
                    ticks -= 3600000 * hours;
                    long min = ticks / 60000;
                    ticks -= 60000 * min;
                    long sec = ticks / 1000;
                    StringBuilder s = new StringBuilder();
                    if (hours > 0)
                    {
                        s.Append(hours);
                        s.Append("h:");
                    }
                    if (min > 0)
                    {
                        s.Append(min);
                        s.Append("m:");
                    }
                    s.Append(sec);
                    s.Append("s");
                    return s.ToString();
                }
                catch
                {
                    return "-"; // Overflow somewhere
                }
            }
        }
    }
}
