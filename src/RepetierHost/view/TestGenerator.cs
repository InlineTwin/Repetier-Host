using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RepetierHost.model;
using System.Globalization;

namespace RepetierHost.view
{
    public partial class TestGenerator : Form
    {
        private GCodeGenerator gen = null;
        static TestGenerator generator = null;
        public static void Execute()
        {
            if (generator == null)
                generator = new TestGenerator();
            generator.Show();
        }
        public TestGenerator()
        {
            InitializeComponent();
            comboTestCase.SelectedIndex = 0;
            gen = Main.generator;
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void buttonCreateTestCase_Click(object sender, EventArgs e)
        {
            switch (comboTestCase.SelectedIndex)
            {
                case 0:
                    Advance1();
                    break;
                case 1:
                    Advance2();
                    break;
            }
            Main.main.LoadGCodeText(gen.Code);
            Hide();
        }

        private void comboTestCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboTestCase.SelectedIndex)
            {
                case 0: // Advance
                    textP4.Enabled = false;
                    textP5.Enabled = false;
                    break;
                case 1:
                    textP4.Enabled = true;
                    textP5.Enabled = true;
                    break;
            }
        }
        protected void Advance1()
        {
            gen.Reset();
            double fLow, fHigh, accel;
            double.TryParse(textP1.Text, NumberStyles.Float, GCode.format, out fLow);
            double.TryParse(textP2.Text, NumberStyles.Float, GCode.format, out fHigh);
            double.TryParse(textP3.Text, NumberStyles.Float, GCode.format, out accel);
            double szEdge = 10;
            double tAccel = (fHigh - fLow) / accel;
            double szAccel = 2.0*(fLow*tAccel+0.5*accel*tAccel*tAccel);
            double left = 20;
            double front = 60+szAccel;
            double edge = 2*szEdge+szAccel;
            double clipW = gen.LayerHeight * gen.WidthOverHeight * gen.ClipFactor;
            while (gen.NextLayer() < 5)
            {
                gen.Move(left, front,fHigh);
                gen.Print(left + szEdge + szAccel, front, fLow);
                gen.Print(left + szEdge + szAccel, front - szAccel, fLow);
                gen.Print(left + edge, front, fLow);
                gen.Print(left + edge, front + szEdge, fLow);
                gen.Print(left + edge, front + szEdge + szAccel, fHigh);
                gen.Print(left + edge, front + edge, fLow);
                gen.Print(left + szEdge + szAccel, front + edge, fLow);
                gen.Print(left + szEdge, front + edge, fHigh);
                gen.Print(left, front + edge, fLow);
                gen.Print(left, front + szEdge + szAccel, fLow);
                gen.Print(left, front + szEdge, fHigh);
                gen.Print(left, front+clipW, fLow);
                gen.ResetE();
            }
            gen.SetRetract(true);
        }
        protected void Advance2()
        {
            gen.Reset();
            double fLow, fHigh, accel;
            double.TryParse(textP1.Text, NumberStyles.Float, GCode.format, out fLow);
            double.TryParse(textP2.Text, NumberStyles.Float, GCode.format, out fHigh);
            double.TryParse(textP3.Text, NumberStyles.Float, GCode.format, out accel);
            double szEdge,szMid;
            double.TryParse(textP4.Text, NumberStyles.Float, GCode.format, out szEdge);
            double.TryParse(textP5.Text, NumberStyles.Float, GCode.format, out szMid);
            double tAccel = (fHigh - fLow) / accel;
            double szAccel = 2.0 * (fLow * tAccel + 0.5 * accel * tAccel * tAccel)+szMid;
            double left = 20;
            double front = Main.printerSettings.PrintAreaDepth-20-szAccel-2*szEdge;
            double edge = 2 * szEdge + szAccel;
            double clipW = gen.LayerHeight * gen.WidthOverHeight * gen.ClipFactor;
            while (gen.NextLayer() < 5)
            {
                gen.Move(left, front, gen.TravelFeedRate);
                gen.Print(left + szEdge + szAccel, front, fLow);
                gen.Print(left + szEdge + szAccel, front - szAccel+szMid, fLow);
                gen.Print(left + edge, front, fLow);
                gen.Print(left + edge, front + szEdge, fLow);
                gen.Print(left + edge, front + szEdge + szAccel, fHigh);
                gen.Print(left + edge, front + edge, fLow);
                gen.Print(left + szEdge + szAccel, front + edge, fLow);
                gen.Print(left + szEdge, front + edge, fHigh);
                gen.Print(left, front + edge, fLow);
                gen.Print(left, front + szEdge + szAccel, fLow);
                gen.Print(left, front + szEdge, fHigh);
                gen.Print(left, front+clipW, fLow);
                gen.ResetE();
            }
            gen.SetRetract(true);
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
    }
}
