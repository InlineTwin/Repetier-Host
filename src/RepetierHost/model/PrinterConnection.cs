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
using System.IO.Ports;
using System.IO;
using System.Timers;
using System.Threading;

namespace RepetierHost.model
{
    /// <summary>
    /// Connection has changed.
    /// </summary>
    /// <param name="msg"></param>
    public delegate void OnPrinterConnectionChange(string msg);
    public delegate void OnPrinterAction(string action);
    public delegate void OnLogCleared();
    public delegate void OnLogAppend(LogLine line);
    public delegate void OnLogRemoveLast(LogLine line);
    public delegate void OnTempUpdate(int extruder,int printbed);
    public delegate void OnJobProgress(float percent);
    public delegate void OnTempMonitor(UInt32 time,int temp,int target,int output); 
    public class PrinterConnection
    {
        public event OnPrinterConnectionChange eventConnectionChange;
        public event OnPrinterAction eventPrinterAction;
        public event OnLogCleared eventLogCleared;
        //public event OnLogAppend eventLogAppend;
        //public event OnLogRemoveLast eventLogRemoveLast;
        public event OnLogAppend eventLogUpdate;
        public event OnTempUpdate eventTempChange;
        public event OnJobProgress eventJobProgress;
        public event OnTempMonitor eventTempMonitor;
        TextWriter logWriter = null;
        public GCodeAnalyzer analyzer = new GCodeAnalyzer(false);
        public bool connected = false;
        // ======== Printer data =============
        public string printerName = "default";
        public int transferProtocol = 0; // 0 = auto, 1 = force ascii, 2 = force binary
        public int binaryVersion = 0;
        public int baud=57600;
        public Parity parity = Parity.None;
        public StopBits stopbits = StopBits.One;
        public int databits = 8;
        public ProtectedSerialPort serial = null;
        public string port="COM10";
        public float travelFeedRate = 4800;
        public float printFeedRate = 2400;
        public float maxZFeedRate = 100;
        public float disposeX=130;
        public float disposeY = 0;
        public float disposeZ = 0;
        public bool afterJobGoDispose = true;
        public bool afterJobDisableExtruder = true;
        public bool afterJobDisablePrintbed = true;
        string read="";
        public LinkedList<LogLine> logList = new LinkedList<LogLine>();
        public LinkedList<LogLine> newLogs = new LinkedList<LogLine>();
        public int maxLogLines = 1000;
        bool readyForNextSend = true;
        public bool pingpong = false;
        public LinkedList<GCode> injectCommands = new LinkedList<GCode>();
        public LinkedList<GCode> history = new LinkedList<GCode>();
        LinkedListNode<GCode> resendNode = null;
        public EEPROMStorage eeprom = new EEPROMStorage();
        public Printjob job;
        private Object nextlineLock = new Object();
        // Printer data
        public string machine = "unknown";
        public string firmware = "";
        public string firmware_url = "";
        public string protocol = "";
        public int numberExtruder = 1;
        public int extruderTemp;
        public int bedTemp;
        public float x, y, z, e;
        public int lastline = 0;
        long lastReceived = 0;
        public bool autocheckTemp = true;
        public long autocheckInterval = 3000;
        private long lastAutocheck = 0;
        System.Timers.Timer timer=null;
        private int resendError = 0;
        public int linesSend = 0, errorsReceived = 0;
        public int bytesSend = 0;
        bool ignoreNextOk = false;
        private ManualResetEvent injectLock = new ManualResetEvent(true);
        string nextPrinterAction = null;
        private long lastCommandSend = DateTime.Now.Ticks;
        private string lastPrinterAction = "";
        public int receiveCacheSize = 120;
        public LinkedList<int> nackLines = new LinkedList<int>(); // Lines, whoses receivement were not acknowledged
        public PrinterConnection()
        {
            job = new Printjob(this);
            timer = new System.Timers.Timer();
            timer.Interval = 100;
            timer.AutoReset = true;
            timer.Elapsed += handleTimer;
            timer.Start();
            try
            {
                string dir = Main.globalSettings.Workdir;
                if(dir.Length>0 && Main.globalSettings.LogEnabled)
                    logWriter = new StreamWriter(dir+"\\repetier.log");
            }
            catch
            {
                logWriter = null;
            }
        }
        public void Destroy()
        {
            if(serial!=null) close();
            if (logWriter != null)
            {
                logWriter.Close();
            }
        }
        void handleTimer(object sender, EventArgs e)
        {
            if (nextPrinterAction != null && !nextPrinterAction.Equals(lastPrinterAction))
            {
                lastPrinterAction = nextPrinterAction;
                try
                {
                    if (eventPrinterAction != null)
                        Main.main.Invoke(eventPrinterAction, nextPrinterAction);
                }
                catch { }
                nextPrinterAction = null;
            }
            if (serial == null || connected == false) return;
            long actTime = DateTime.Now.Ticks / 10000;
            if (autocheckTemp && actTime - lastAutocheck > autocheckInterval)
            {
                lastAutocheck = actTime;
                // only inject temp check, if not present. Some commands
                // take a long time and it makes no sense, to push 30 M105
                // commands as soon as it's ready.
                bool found = false;
                lock (history)
                {
                    foreach (GCode co in injectCommands)
                    {
                        if (co.hasM && co.M == 105)
                        {
                            found = true;
                            break;
                        }
                    }
                }
                if (!found)
                {
                    GetInjectLock();
                    injectManualCommand("M105");
                    ReturnInjectLock();
                }
            }
            if ((!pingpong && nackLines.Count==0) || (pingpong && readyForNextSend)) TrySendNextLine();

            // If the reprap starts sending response it should finish soon
            else if (resendError < 4 && read.Length > 0 && lastReceived - actTime > 400)
            {
                // force response, even if we
                // get a resend request
                log("Reset output. After some wait, I got only " + read, false, 2);
                read = "";
                if (pingpong)
                    readyForNextSend = true;
                else
                {
                    lock (nackLines)
                    {
                        if (nackLines.Count > 0)
                            nackLines.RemoveFirst();
                    }
                }
                TrySendNextLine();
            }

        }
        LogLine useNextLog = null;
        public void log(string t, bool response, int level)
        {
            LogLine l;
            bool update = false;
            if (useNextLog != null)
            {
                l = useNextLog;
                l.text = t;
                l.response = response;
                l.level = level;
                update = true;
                useNextLog = null;
            } else
                l = new LogLine(t, response, level);
            if (logWriter != null)
            {
                if(!response)
                    logWriter.WriteLine("< "+l.text);
            }
            lock (logList)
            {
                if (t.Length > 0 && t[t.Length - 1] == 27)
                {
                    //useNextLog = l;
                    l.text = t.Substring(0, t.Length - 1);
                }
                if (!update) logList.AddLast(l);
            }
            if (logList.Count > maxLogLines)
            {
                LogLine removed = null;
                lock (logList)
                {
                    removed = logList.First.Value;
                    logList.RemoveFirst();
                }
               /* if (eventLogRemoveLast!=null)
                {
                    try
                    {
                        Main.main.Invoke(eventLogRemoveLast, removed);
                    }
                    catch { } // Closing the app can cause an exception, if event comes after Main handle is destroyed
                }*/
            }
            if(!update /*&& eventLogAppend!=null*/)
                try
                {
                    lock (newLogs)
                    {
                        newLogs.AddLast(l);
                    }
                    //Main.main.Invoke(eventLogAppend, l);
                }
                catch { } // Closing the app can cause an exception, if event comes after Main handle is destroyed
      
            if (update && eventLogUpdate != null)
                try
                {
                    Main.main.Invoke(eventLogUpdate, l);
                }
                catch { } // Closing the app can cause an exception, if event comes after Main handle is destroyed
        }
        private void StoreHistory(GCode gcode)
        {
            history.AddLast(gcode);
            log(gcode.getAscii(true, true), false, 0);
            if (history.Count > 40)
                history.RemoveFirst();
        }
        private int receivedCount()
        {
            int n = 0;
            lock (nackLines)
            {
                foreach (int i in nackLines)
                    n += i;
            }
            return n;
        }
        public void ResendLine(int line)
        {
            resendError++;
            errorsReceived++;
            if (pingpong)
                readyForNextSend = true;
            else 
                nackLines.Clear(); // printer flushed all coming commands
            
            LinkedListNode<GCode> node = history.Last;
            if (resendError > 5 || node==null)
            {
                log("Receiving only error messages. Stopped communication.",false,2);
                close();
                return; // give up, something is terribly wrong
            }
            line &=65535;
            do
            {
                GCode gc = node.Value;
                if (gc.hasN && (gc.N & 65535) == line)
                {
                    resendNode = node;
                    if (binaryVersion != 0)
                    {
                        int send = receivedCount();
                        serial.DiscardOutBuffer();
                        System.Threading.Thread.Sleep(send * 10000 / baud); // Wait for buffer to empty
                        byte[] buf = new byte[32];
                        for (int i = 0; i < 32; i++) buf[i] = 0;
                        serial.Write(buf, 0, 32);
                        System.Threading.Thread.Sleep(320000 / baud); // Wait for buffer to empty
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(receiveCacheSize * 10000 / baud); // Wait for buffer to empty
                    }
                    TrySendNextLine();
                    return;
                }
                if (node.Previous == null) return;
                node = node.Previous;
            } while (true);
        }
        public void TrySendNextLine()
        {
            string logtext = null;
            int loglevel = 0;
            float logprogress = -1;
            string printeraction = null;
            GCode historygc = null;
            try
            {
                lock (nextlineLock)
                {
                    if (pingpong && !readyForNextSend) return;
                    if (serial == null) return; // Not ready yet
                    if (!serial.IsOpen) // someone unplugged the cord?
                    {
                        close();
                        return;
                    }
                    GCode gc = null;
                    try
                    {
                        // first resolve old communication problems
                        if (resendNode != null)
                        {
                            gc = resendNode.Value;
                            if (binaryVersion == 0)
                            {
                                string cmd = gc.getAscii(true, true);
                                if (!pingpong && receivedCount() + cmd.Length + 2 > receiveCacheSize) return; // printer cache full
                                if (pingpong) readyForNextSend = false;
                                else { lock (nackLines) { nackLines.AddLast(cmd.Length + 2); } }
                                serial.WriteLine(cmd);
                                bytesSend += cmd.Length + 2;
                            }
                            else
                            {
                                byte[] cmd = gc.getBinary(binaryVersion);
                                if (!pingpong && receivedCount() + cmd.Length > receiveCacheSize) return; // printer cache full
                                if (pingpong) readyForNextSend = false;
                                else { lock (nackLines) { nackLines.AddLast(cmd.Length); } }
                                serial.Write(cmd, 0, cmd.Length);
                                bytesSend += cmd.Length;
                            }
                            linesSend++;
                            lastCommandSend = DateTime.Now.Ticks;
                            resendNode = resendNode.Next;
                            logtext = "Resend: " + gc.getAscii(true, true);
                          //  if (resendNode == null) readyForNextSend = true;
                            //readyForNextSend = false;
                            return;
                        }
                        if (resendError > 0) resendError--; // Drop error counter
                        // then check for manual commands
                        if (injectCommands.Count > 0)
                        {
                            lock (history)
                            {
                                gc = injectCommands.First.Value;                                
                                gc.N = ++lastline;
                                if (binaryVersion == 0)
                                {
                                    string cmd = gc.getAscii(true, true);
                                    if (!pingpong && receivedCount() + cmd.Length + 2 > receiveCacheSize) { --lastline; return; } // printer cache full
                                    if (pingpong) readyForNextSend = false;
                                    else { lock (nackLines) { nackLines.AddLast(cmd.Length); } }
                                    serial.WriteLine(cmd);
                                    bytesSend += cmd.Length + 2;
                                }
                                else
                                {
                                    byte[] cmd = gc.getBinary(binaryVersion);
                                    if (!pingpong && receivedCount() + cmd.Length > receiveCacheSize) { --lastline; return; } // printer cache full
                                    if (pingpong) readyForNextSend = false;
                                    else { lock (nackLines) { nackLines.AddLast(cmd.Length); } }
                                    serial.Write(cmd, 0, cmd.Length);
                                    bytesSend += cmd.Length;
                                }
                                injectCommands.RemoveFirst();
                            }
                            linesSend++;
                            lastCommandSend = DateTime.Now.Ticks;
                            historygc = gc;
                            analyzer.Analyze(gc);
                            if (job.dataComplete == false)
                            {
                                if (injectCommands.Count == 0)
                                {
                                    printeraction = "Idle";
                                }
                                else
                                {
                                    printeraction = injectCommands.Count.ToString() + " commands waiting";
                                }
                            }
                            return;
                        }
                        // do we have a printing job?
                        if (job.dataComplete)
                        {
                            lock (history)
                            {
                                gc = job.PeekData();
                                gc.N = ++lastline;
                                if (binaryVersion == 0)
                                {
                                    string cmd = gc.getAscii(true, true);
                                    if (!pingpong && receivedCount() + cmd.Length + 2 > receiveCacheSize) { --lastline; return; } // printer cache full
                                    if (pingpong) readyForNextSend = false;
                                    else { lock (nackLines) { nackLines.AddLast(cmd.Length + 2); } }
                                    serial.WriteLine(cmd);
                                    bytesSend += cmd.Length + 2;
                                }
                                else
                                {
                                    byte[] cmd = gc.getBinary(binaryVersion);
                                    if (!pingpong && receivedCount() + cmd.Length > receiveCacheSize) { --lastline; return; } // printer cache full
                                    if (pingpong) readyForNextSend = false;
                                    else { lock (nackLines) { nackLines.AddLast(cmd.Length); } }
                                    serial.Write(cmd, 0, cmd.Length);
                                    bytesSend += cmd.Length;
                                }
                                historygc = gc;
                                job.PopData();
                            }
                            linesSend++;
                            lastCommandSend = DateTime.Now.Ticks;
                            analyzer.Analyze(gc);
                            printeraction = "Printing...ETA " + job.ETA;
                            logprogress = job.PercentDone;
                        }

                    }
                    catch (InvalidOperationException ex)
                    {
                        logtext = "Error sending data:" + ex;
                        loglevel = 2;
                    }
                }
            }
            finally
            {
                // need to extract log/event calls because they cause deadlocks inside
                // the lock statement.
                if (historygc != null)
                    StoreHistory(historygc);
                if (logtext != null)
                    log(logtext, false, loglevel);
                if (printeraction != null)
                    firePrinterAction(printeraction);
                if (logprogress>=0 && eventJobProgress != null)
                    Main.main.Invoke(eventJobProgress, job.PercentDone);
            }
        }
        /// <summary>
        /// Clean log.
        /// </summary>
        public void clearLog()
        {
            logList.Clear();
            if (eventLogCleared != null)
                eventLogCleared();
        }
        public void open()
        {
            try {
                serial = new ProtectedSerialPort();
                serial.PortName = port;
                serial.BaudRate = baud;
                serial.Parity = parity;
                serial.DataBits = databits;
                serial.StopBits = stopbits;
                serial.DataReceived += received;
                serial.ErrorReceived += error;
                serial.Open();
                connected = true;
                if (transferProtocol < 2)
                    binaryVersion = 0;
                else binaryVersion = transferProtocol - 1;
                readyForNextSend = true;
                nackLines.Clear();
                ignoreNextOk = false;
                linesSend = errorsReceived = bytesSend = 0;
                GetInjectLock();
                injectManualCommand("N0 M110"); // Make sure we tal about the same linenumbers
                injectManualCommand("M115"); // Check firmware
                injectManualCommand("M105"); // Read temperature
                ReturnInjectLock();
                if (eventConnectionChange != null)
                    eventConnectionChange("Connected");
                Main.main.Invoke(Main.main.UpdateJobButtons);
            }
            catch(IOException ex) {
                serial = null;
                log(ex.Message, true, 2);
                if(eventConnectionChange!=null)
                    eventConnectionChange("Conn. error");
            }
        }

        public void close()
        {
            if(serial == null) return;
            connected = false;
            lock (nextlineLock)
            {
                try
                {
                    serial.Close();
                    serial.Dispose();
                }
                catch (Exception) { }
                serial = null;
            }
            job.KillJob();
            history.Clear();
            injectCommands.Clear();
            resendNode = null;
            if(eventConnectionChange!=null)
                try
                {
                    Main.main.Invoke(eventConnectionChange, "Disconnected");
                }
                catch { } // Closing the app can cause an exception, if event comes after Main handle is destroyed
            firePrinterAction("Idle");
            Main.main.Invoke(Main.main.UpdateJobButtons);
        }

        public void firePrinterAction(string s)
        {
            nextPrinterAction = s;
        }
        private void error(Object sender, SerialErrorReceivedEventArgs e)
        {
            log("Serial com error:" + e.ToString(), false, 2);
        }

        private void received(object sender,
                        SerialDataReceivedEventArgs e)
        {
            string indata = serial.ReadExisting();
            read+=indata.Replace('\r','\n');
            do {
                int pos = read.IndexOf('\n');
                if(pos<0) break;
                string response = read.Substring(0,pos);
                read = read.Substring(pos+1);
                if(response.Length>0) {
                    analyzeResponse(response);
                }
                TrySendNextLine();
            } while(true);
            lastReceived = DateTime.Now.Ticks/10000;
        }
        /// <summary>
        /// Send a print command, that does not belong to a print job.
        /// </summary>
        /// <param name="command">GCode command</param>
        public void injectManualCommand(string command)
        {
            GCode gc = new GCode();
            gc.Parse(command);
            lock(history)
                injectCommands.AddLast(gc);
            if (job.dataComplete == false)
            {
                if (injectCommands.Count == 0)
                {
                    firePrinterAction("Idle");
                }
                else
                {
                    firePrinterAction(injectCommands.Count.ToString() + " commands waiting");
                }
            }
        }
        private Object injectLockLock = new Object();
        public void GetInjectLock()
        {
            try
            {
                injectLock.WaitOne();
                injectLock.Reset();
            }
            catch (Exception e)
            {
                firePrinterAction(e.ToString());
            }
            /*lock(injectLockLock) {
                while(!injectLock) {}
                injectLock = false;
            }*/
        }
        public void ReturnInjectLock()
        {
            injectLock.Set();
        }
        /// <summary>
        /// Analyzes a response from the printer.
        /// Updates data and sends events according to the data.
        /// </summary>
        /// <param name="res"></param>
        public void analyzeResponse(string res)
        {
            int level=0;
            if (logWriter != null)
            {
                DateTime time = DateTime.Now;
                logWriter.WriteLine("> "+time.Hour.ToString("00") + ":" + time.Minute.ToString("00") + ":" +
                time.Second.ToString("00") + "." + time.Millisecond.ToString("000") + " : " + res);
            }
            
            string h = extract(res, "FIRMWARE_NAME:");
            if (h != null)
            {
                level = 3;
                firmware = h;
            }
            h = extract(res, "FIRMWARE_URL:");
            if (h != null)
            {
                level = 3;
                firmware_url = h;
            }
            h = extract(res, "PROTOCOL_VERSION:");
            if (h != null)
            {
                level = 3;
                protocol = h;
            }
            h = extract(res, "MACHINE_TYPE:");
            if (h != null)
            {
                level = 3;
                machine = h;
            }
            h = extract(res, "EXTRUDER_COUNT:");
            if (h != null)
            {
                level = 3;
                if (!int.TryParse(h, out numberExtruder)) numberExtruder = 1;
            }
            h = extract(res, "X:");
            if (h != null)
            {
                level = 3;
                float.TryParse(h, out x);
            }
            h = extract(res, "Y:");
            if (h != null)
            {
                level = 3;
                float.TryParse(h, out y);
            }
            h = extract(res, "Z:");
            if (h != null)
            {
                level = 3;
                float.TryParse(h, out z);
            }
            h = extract(res, "E:");
            if (h != null)
            {
                level = 3;
                float.TryParse(h, out e);
            }
            bool tempChange = false;
            h = extract(res, "T:");
            if (h != null)
            {
                level = -1; // dont log, we see result in status
                if(h.IndexOf('.')>0) h = h.Substring(0,h.IndexOf('.'));
                int.TryParse(h, out extruderTemp);
                tempChange = true;
            }
            h = extract(res, "B:");
            if (h != null)
            {
                level = -1; // don't log, we see result in status
                if (h.IndexOf('.') > 0) h = h.Substring(0, h.IndexOf('.'));
                int.TryParse(h, out bedTemp);
                tempChange = true;
            }
            if (res.StartsWith("EPR:"))
            {
                eeprom.Add(res);
            }
            if (res.StartsWith("MTEMP:")) // Temperature monitor 
            {
                level = -1; // this happens to often to log. Temperture monitor i sthe log
                string[] sl = res.Substring(6).Split(' ');
                if (sl.Length == 4)
                {
                    UInt32 time;
                    int temp,target,output;
                    UInt32.TryParse(sl[0], out time);
                    int.TryParse(sl[1], out temp);
                    int.TryParse(sl[2], out target);
                    int.TryParse(sl[3], out output);
                    if (time > 0 && eventTempMonitor != null)
                    {
                        try
                        {
                            Main.main.Invoke(eventTempMonitor, time, temp, target, output);
                        }
                        catch { }
                    }
                }
            }
            h = extract(res, "REPETIER_PROTOCOL:");
            if (h != null)
            {
                level = 3;
                int.TryParse(h, out binaryVersion);
                if (transferProtocol == 1) binaryVersion = 0; // force ascii transfer
            }
            if (res.Equals("start"))
            {
                lastline = 0;
                job.KillJob(); // continuing the old job makes no sense, better save the plastic
                resendNode = null;
                history.Clear();
                analyzer.start();
                readyForNextSend = true;
                nackLines.Clear();
            }
            if (extract(res, "Error:")!=null)
            {
                level = 2;
            }
            if (tempChange && eventTempChange != null)
            {
                Main.main.Invoke(eventTempChange, extruderTemp, bedTemp);
            }
            h = extract(res, "Resend:");
            if (h != null)
            {
                level = 1;
                log(res, true, level);
                int line;
                int.TryParse(h, out line);
                ignoreNextOk = true;
                ResendLine(line);
            }
            else if (res.StartsWith("ok"))
            {
                if(Main.main.logView.toolACK.Checked)
                  log(res, true, level);
                if (!ignoreNextOk)  // ok in response of resend?
                {
                    if (pingpong) readyForNextSend = true;
                    else
                    {
                        lock (nackLines)
                        {
                            if (nackLines.Count > 0)
                                nackLines.RemoveFirst();
                        }
                    }
                    resendError = 0;
                    TrySendNextLine();
                } else
                  ignoreNextOk = false;
            }
            else if (res.Equals("wait") && DateTime.Now.Ticks-lastCommandSend>5000)
            {
                if (Main.main.logView.toolACK.Checked)
                    log(res, true, level);
                if (pingpong) readyForNextSend = true;
                else
                {
                    lock (nackLines)
                    {
                        if (nackLines.Count > 0)
                            nackLines.Clear();
                    }
                }
                resendError = 0;
                TrySendNextLine();
            }
            else if (level >= 0) log(res, true, level);
            
        }
        private string extract(string source, string ident)
        {
            int pos = 0;
            do
            {
                pos = source.IndexOf(ident, pos == 0 ? pos : pos + 1);
                if (pos < 0) return null;
            } while (pos > 0 && source[pos - 1] != ' ');
            int start = pos + ident.Length;
            int end = start;
            while (end < source.Length && source[end] != ' ') end++;
            return source.Substring(start, end - start);
        }
        public void doDispose()
        {
            if (analyzer.hasXHome == false || analyzer.hasYHome == false) return; // don't know where we are
            float dx = disposeX - analyzer.xOffset-(analyzer.relative?analyzer.x:0);
            float dy = disposeY - analyzer.yOffset - (analyzer.relative ? analyzer.y : 0);
            string zextra = "";
            GetInjectLock();
            injectManualCommand("G1 X" + dx.ToString(GCode.format) + " Y" + dy.ToString(GCode.format) + " F" + travelFeedRate.ToString(GCode.format));
            if (analyzer.hasZHome && analyzer.z - analyzer.zOffset < disposeZ && disposeZ > 0 && disposeZ < Main.printerSettings.PrintAreaHeight)
            {
                float dz = disposeZ - analyzer.zOffset - (analyzer.relative ? analyzer.z : 0);
                zextra = "G1 Z" + dz.ToString(GCode.format) + " F" + maxZFeedRate.ToString(GCode.format);
                injectManualCommand(zextra);
            }
            ReturnInjectLock();
        }
    }
}
