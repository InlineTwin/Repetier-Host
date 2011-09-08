namespace RepetierHost.view
{
    partial class FormTempMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTempMonitor));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonStartMonitor = new System.Windows.Forms.Button();
            this.buttonStopMonitor = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMonitor = new System.Windows.Forms.ComboBox();
            this.checkAutoscaleX = new System.Windows.Forms.CheckBox();
            this.plotter = new RepetierHost.GraphLib.PlotterDisplayEx();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(882, 526);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonStartMonitor
            // 
            this.buttonStartMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStartMonitor.Location = new System.Drawing.Point(241, 526);
            this.buttonStartMonitor.Name = "buttonStartMonitor";
            this.buttonStartMonitor.Size = new System.Drawing.Size(78, 23);
            this.buttonStartMonitor.TabIndex = 2;
            this.buttonStartMonitor.Text = "Start monitor";
            this.buttonStartMonitor.UseVisualStyleBackColor = true;
            this.buttonStartMonitor.Click += new System.EventHandler(this.buttonStartMonitor_Click);
            // 
            // buttonStopMonitor
            // 
            this.buttonStopMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStopMonitor.Location = new System.Drawing.Point(323, 525);
            this.buttonStopMonitor.Name = "buttonStopMonitor";
            this.buttonStopMonitor.Size = new System.Drawing.Size(78, 23);
            this.buttonStopMonitor.TabIndex = 3;
            this.buttonStopMonitor.Text = "Stop monitor";
            this.buttonStopMonitor.UseVisualStyleBackColor = true;
            this.buttonStopMonitor.Click += new System.EventHandler(this.buttonStopMonitor_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.Location = new System.Drawing.Point(405, 524);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(78, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Monitor:";
            // 
            // comboMonitor
            // 
            this.comboMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMonitor.FormattingEnabled = true;
            this.comboMonitor.Items.AddRange(new object[] {
            "Extruder 0",
            "Extruder 1",
            "Extruder 2",
            "Extruder 3",
            "Heated bed"});
            this.comboMonitor.Location = new System.Drawing.Point(65, 526);
            this.comboMonitor.Name = "comboMonitor";
            this.comboMonitor.Size = new System.Drawing.Size(166, 21);
            this.comboMonitor.TabIndex = 6;
            // 
            // checkAutoscaleX
            // 
            this.checkAutoscaleX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkAutoscaleX.AutoSize = true;
            this.checkAutoscaleX.Location = new System.Drawing.Point(489, 528);
            this.checkAutoscaleX.Name = "checkAutoscaleX";
            this.checkAutoscaleX.Size = new System.Drawing.Size(83, 17);
            this.checkAutoscaleX.TabIndex = 7;
            this.checkAutoscaleX.Text = "Autoscale X";
            this.checkAutoscaleX.UseVisualStyleBackColor = true;
            this.checkAutoscaleX.CheckedChanged += new System.EventHandler(this.checkAutoscaleX_CheckedChanged);
            // 
            // plotter
            // 
            this.plotter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.plotter.BackColor = System.Drawing.Color.Black;
            this.plotter.BackgroundColorBot = System.Drawing.Color.DimGray;
            this.plotter.BackgroundColorTop = System.Drawing.Color.Black;
            this.plotter.DashedGridColor = System.Drawing.Color.DarkGray;
            this.plotter.DoubleBuffering = true;
            this.plotter.ForeColor = System.Drawing.Color.White;
            this.plotter.Location = new System.Drawing.Point(-1, 0);
            this.plotter.Name = "plotter";
            this.plotter.PlaySpeed = 0.5F;
            this.plotter.Size = new System.Drawing.Size(969, 504);
            this.plotter.SolidGridColor = System.Drawing.Color.DarkGray;
            this.plotter.TabIndex = 0;
            // 
            // FormTempMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 561);
            this.ControlBox = false;
            this.Controls.Add(this.checkAutoscaleX);
            this.Controls.Add(this.comboMonitor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonStopMonitor);
            this.Controls.Add(this.buttonStartMonitor);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.plotter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTempMonitor";
            this.Text = "Temperature monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RepetierHost.GraphLib.PlotterDisplayEx plotter;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonStartMonitor;
        private System.Windows.Forms.Button buttonStopMonitor;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMonitor;
        private System.Windows.Forms.CheckBox checkAutoscaleX;
    }
}