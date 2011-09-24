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
    public partial class SlicingParameter : Form
    {
        static SlicingParameter form = null;

        public static void Execute()
        {
            if (form == null)
                form = new SlicingParameter();
            form.ToForm();
            form.Show();
        }
        public SlicingParameter()
        {
            InitializeComponent();
        }
        private String ReadD(double d)
        {
            return d.ToString("0.0", GCode.format);
        }
        private String ReadD2(double d)
        {
            return d.ToString("0.00", GCode.format);
        }
        private double ToD(string t)
        {
            double d;
            double.TryParse(t, NumberStyles.Float, GCode.format,out d);
            return d;
        }
        
        public void ToForm()
        {
            GCodeGenerator g = Main.generator;
            g.Load();
            comboDefaultPrecision.SelectedIndex = g.DefaultPrecision;
            comboExtruderPrecision.SelectedIndex = g.ExtruderPrecision;
            textTemperature.Text = g.ExtruderTemperature.ToString();
            textFilamentDiameter.Text = ReadD2(g.FilamentDiameter);
            textPackingDensity.Text = ReadD(g.FilamentPackingDensity);
            textFirstLayerHeight.Text = ReadD2(g.FirstLayerHeight);
            textFirstLayerSpeedFactor.Text = ReadD2(g.FirstLayerSpeedFactor);
            textLayerHeight.Text = ReadD2(g.LayerHeight);
            textRetractionSpeed.Text = ReadD(g.ExtruderRetractionSpeed);
            textRetractionRestartExtra.Text = ReadD2(g.RetractionRestartExtra);
            textRetractionDistance.Text = ReadD2(g.RetractionDistance);
            textMaxFeedRate.Text = ReadD(g.MaximumFeedRate);
            textTravelFeedRate.Text = ReadD(g.TravelFeedRate);
            textZAxisFeedRate.Text = ReadD(g.ZFeedRate);
            textPrintFeedRate.Text = ReadD(g.PrintFeedRate);
            textClipFactor.Text = ReadD2(g.ClipFactor);
            textWidthOverThickness.Text = ReadD2(g.WidthOverHeight);
        }
        public void FromForm()
        {
            GCodeGenerator g = Main.generator;
            g.DefaultPrecision = comboDefaultPrecision.SelectedIndex;
            g.ExtruderPrecision = comboExtruderPrecision.SelectedIndex;
            int i;
            int.TryParse(textTemperature.Text,out i);
            g.ExtruderTemperature = i;
            g.FilamentDiameter = ToD(textFilamentDiameter.Text);
            g.FilamentPackingDensity = ToD(textPackingDensity.Text);
            g.FirstLayerHeight= ToD(textFirstLayerHeight.Text);
            g.FirstLayerSpeedFactor = ToD(textFirstLayerSpeedFactor.Text);
            g.LayerHeight = ToD(textLayerHeight.Text);
            g.ExtruderRetractionSpeed = ToD(textRetractionSpeed.Text);
            g.RetractionRestartExtra = ToD(textRetractionRestartExtra.Text);
            g.RetractionDistance = ToD(textRetractionDistance.Text);
            g.MaximumFeedRate = ToD(textMaxFeedRate.Text);
            g.TravelFeedRate = ToD(textTravelFeedRate.Text);
            g.ZFeedRate = ToD(textZAxisFeedRate.Text);
            g.PrintFeedRate = ToD(textPrintFeedRate.Text);
            g.ClipFactor = ToD(textClipFactor.Text);
            g.WidthOverHeight = ToD(textWidthOverThickness.Text);
            g.Save();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            FromForm();
            Hide();
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            Hide();
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
        private void int_Validating(object sender, CancelEventArgs e)
        {
            TextBox box = (TextBox)sender;
            try
            {
                int.Parse(box.Text);
                errorProvider.SetError(box, "");
            }
            catch
            {
                errorProvider.SetError(box, "Not an integer.");
            }
        }
    }
}
