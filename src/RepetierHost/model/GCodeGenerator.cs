using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Globalization;

namespace RepetierHost.model
{
    public class GCodeGenerator
    {
        public RegistryKey repetierKey;
        public RegistryKey printerKey;
        RegistryKey printer;
        public int ExtruderTemperature = 180;
        public double LayerHeight = 0.36;
        public double WidthOverHeight = 1.6;
        public double FilamentDiameter = 2.87;
        public double FilamentPackingDensity = 1.0;
        public double ExtruderRetractionSpeed = 24;
        public double RetractionDistance = 3.0;
        public double RetractionRestartExtra = 0.0;
        public double ZFeedRate = 2.0;
        public double MaximumFeedRate = 150.0;
        public double PrintFeedRate = 50.0;
        public double TravelFeedRate = 100.0;
        public double FirstLayerSpeedFactor = 0.5;
        public double FirstLayerHeight = 0.36;
        public int DefaultPrecision = 2;
        public int ExtruderPrecision = 4;
        public double ClipFactor = 0.5;
        public double X = 0, Y = 0, Z = 0,E = 0;
        public bool IsRetract = false;
        int layer = 0;
        public StringBuilder code;

        public GCodeGenerator()
        {
            repetierKey = Registry.CurrentUser.CreateSubKey("Software\\Repetier");
            printerKey = repetierKey.CreateSubKey("printer");
            code = new StringBuilder();
        }
        double ReadD(string name, double def)
        {
            string sdef = def.ToString("0.0000", GCode.format);
            string res = (string)printer.GetValue(name, sdef);
            double.TryParse(res, NumberStyles.Float, GCode.format, out def);
            return def;
        }
        void WriteD(string name, double v)
        {
            string sv = v.ToString("0.0000", GCode.format);
            printer.SetValue(name, sv);
        }
        double ReadI(string name, int i)
        {
            return (int)printer.GetValue(name, i);
        }
        void WriteI(string name, double v)
        {
            string sv = v.ToString("0.0000", GCode.format);
            printer.SetValue(name, sv);
        }
        public void Load()
        {
            if (Main.printerSettings.comboPrinter.Text.Length == 0) return;
            printer = printerKey.CreateSubKey(Main.printerSettings.comboPrinter.Text);
            DefaultPrecision = (int)printer.GetValue("SliceDefaultPrecision", DefaultPrecision);
            ExtruderPrecision = (int)printer.GetValue("SliceExtruderPrecision", ExtruderPrecision);
            ExtruderTemperature = (int)printer.GetValue("SliceExtruderTemperature", ExtruderTemperature);
            LayerHeight = ReadD("SliceLayerHeight",LayerHeight);
            WidthOverHeight = ReadD("SliceWidthOverHeight",WidthOverHeight);
            FilamentDiameter = ReadD("SliceFilamentDiameter",FilamentDiameter);
            FilamentPackingDensity = ReadD("SliceFilamentPackingDensity",FilamentPackingDensity);
            ExtruderRetractionSpeed = ReadD("SliceExtruderRetractionSpeed",ExtruderRetractionSpeed);
            RetractionDistance = ReadD("SliceRetractionDistance",RetractionDistance);
            RetractionRestartExtra = ReadD("SliceRetractionRestartExtra", RetractionRestartExtra) ;
            ZFeedRate = ReadD("SliceZFeedRate",ZFeedRate);
            MaximumFeedRate = ReadD("SliceMaximumFeedRate",MaximumFeedRate);
            PrintFeedRate = ReadD("SlicePrintFeedRate",PrintFeedRate);
            TravelFeedRate = ReadD("SliceTravelFeedRate",TravelFeedRate);
            FirstLayerSpeedFactor = ReadD("SliceFirstLayerSpeedFactor",FirstLayerSpeedFactor);
            FirstLayerHeight = ReadD("SliceFirstLayerHeight",FirstLayerHeight);
            ClipFactor = ReadD("SliceClipFactor", ClipFactor);
        }
        public void Save()
        {
            if (Main.printerSettings.comboPrinter.Text.Length == 0) return;
            printer = printerKey.CreateSubKey(Main.printerSettings.comboPrinter.Text);
            printer.SetValue("SliceDefaultPrecision", DefaultPrecision);
            printer.SetValue("SliceExtruderPrecision", ExtruderPrecision);
            printer.SetValue("SliceExtruderTemperature", ExtruderTemperature);
            WriteD("SliceLayerHeight", LayerHeight);
            WriteD("SliceWidthOverHeight", WidthOverHeight);
            WriteD("SliceFilamentDiameter", FilamentDiameter);
            WriteD("SliceFilamentPackingDensity", FilamentPackingDensity);
            WriteD("SliceExtruderRetractionSpeed", ExtruderRetractionSpeed);
            WriteD("SliceRetractionDistance", RetractionDistance);
            WriteD("SliceRetractionRestartExtra", RetractionRestartExtra);
            WriteD("SliceZFeedRate", ZFeedRate);
            WriteD("SliceMaximumFeedRate", MaximumFeedRate);
            WriteD("SlicePrintFeedRate", PrintFeedRate);
            WriteD("SliceTravelFeedRate", TravelFeedRate);
            WriteD("SliceFirstLayerSpeedFactor", FirstLayerSpeedFactor);
            WriteD("SliceFirstLayerHeight", FirstLayerHeight);
            WriteD("SliceClipFactor", ClipFactor);
        }
        public void Reset()
        {
            Load();
            X = 0;
            Y = 0;
            Z = 0;
            E = 0;
            layer = 0;
            code.Length = 0;
            IsRetract = false;
        }
        public void SetTemperature(int temp)
        {
            code.Append("M109 S" + temp);
            NewLine();
        }
        public void SetTemperatureFast(int temp)
        {
            code.Append("M104 S" + temp);
            NewLine();
        }
        public void HomeAllAxis()
        {
            code.Append("G28 X0 Y0 Z0");
            NewLine();
        }
        public string Code
        {
            get { return code.ToString(); }
        }
        public void Add(string c)
        {
            code.Append(c);
        }
        // How much E is needed for given distance/diameter
        public double DeltaE(double dist,double woh)
        {
            double A = LayerHeight * LayerHeight * (woh-1.0+Math.PI/4.0)/
                (FilamentDiameter*FilamentDiameter* FilamentPackingDensity*Math.PI/4.0);
            return A * dist;
        }
        public void WriteDouble(double val,int dig) {
            switch (dig)
            {
                case 0: code.Append(val.ToString("0",GCode.format));
                    return;
                case 1: code.Append(val.ToString("0.0", GCode.format));
                    return;
                case 2: code.Append(val.ToString("0.00", GCode.format));
                    return;
                case 3: code.Append(val.ToString("0.000", GCode.format));
                    return;
                case 4: code.Append(val.ToString("0.0000", GCode.format));
                    return;
                case 5: code.Append(val.ToString("0.00000", GCode.format));
                    return;
                default: code.Append(val.ToString("0.000000", GCode.format));
                    return;

            }
        }
        public void WriteDouble(double val)
        {
            WriteDouble(val, DefaultPrecision);
        }
        public void WriteFeedrate(double fr)
        {
            if (layer == 1)
                fr *= FirstLayerSpeedFactor;
            code.Append(" F");
            WriteDouble(fr * 60);
        }
        public void WriteFeedrateExact(double fr)
        {
            code.Append(" F");
            WriteDouble(fr * 60);
        }
        public void ResetE()
        {
            code.Append("G92 E0");
            NewLine();
            E = 0;
        }
        public void NewLine()
        {
            code.Append("\r\n");
        }
        public double NextLayer()
        {
            layer++;
            SetRetract(true);
            if (layer == 1)
                Z += FirstLayerHeight;
            else 
                Z = layer*LayerHeight;
            code.Append("G1 Z");
            WriteDouble(Z);
            WriteFeedrateExact(ZFeedRate);
            NewLine();
            return Z;
        }
        public void SetRetract(bool rt)
        {
            if (rt == IsRetract) return;
            if (RetractionDistance <= 0) return;
            if (!IsRetract)
                E -= RetractionDistance;
             else
                E += RetractionDistance + RetractionRestartExtra;
            code.Append("G1 E");
            WriteDouble(E, ExtruderPrecision);
            WriteFeedrateExact(ExtruderRetractionSpeed);
            NewLine();
            IsRetract = rt;            
        }
        // Move head to new position. Manages retraction.
        public void Move(double x, double y, double fr)
        {
            double dx = x - X;
            double dy = y - Y;
            double dist2 = dx * dx + dy * dy;
            if (dist2 > 1e-6)
            {
                SetRetract(true);
                code.Append("G1 X");
                WriteDouble(x);
                code.Append(" Y");
                WriteDouble(y);
                WriteFeedrate(Math.Min(fr, MaximumFeedRate));
                NewLine();
                X = x;
                Y = y;
            }
        }
        public void Print(double x, double y, double fr)
        {
            double dx = x - X;
            double dy = y - Y;
            double dist = Math.Sqrt(dx * dx + dy * dy);
            if (dist > 0.001)
            {
                SetRetract(false);
                code.Append("G1 X");
                WriteDouble(x);
                code.Append(" Y");
                WriteDouble(y);
                code.Append(" E");
                E += DeltaE(dist, WidthOverHeight);
                WriteDouble(E, ExtruderPrecision);
                WriteFeedrateExact(Math.Min(fr, MaximumFeedRate));
                NewLine();
                X = x;
                Y = y;
            }
        }
    }
}
