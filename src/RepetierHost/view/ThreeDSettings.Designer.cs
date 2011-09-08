namespace RepetierHost.view
{
    partial class ThreeDSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThreeDSettings));
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.printerBase = new System.Windows.Forms.Panel();
            this.filament = new System.Windows.Forms.Panel();
            this.selectedFaces = new System.Windows.Forms.Panel();
            this.edges = new System.Windows.Forms.Panel();
            this.faces = new System.Windows.Forms.Panel();
            this.background = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.useVBOs = new System.Windows.Forms.CheckBox();
            this.textWidthOverThickness = new System.Windows.Forms.TextBox();
            this.textLayerHeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboFilamentVisualization = new System.Windows.Forms.ComboBox();
            this.showPrintbed = new System.Windows.Forms.CheckBox();
            this.showEdges = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.enableLight4 = new System.Windows.Forms.CheckBox();
            this.enableLight3 = new System.Windows.Forms.CheckBox();
            this.enableLight2 = new System.Windows.Forms.CheckBox();
            this.enableLight1 = new System.Windows.Forms.CheckBox();
            this.groupBoxColors.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.label5);
            this.groupBoxColors.Controls.Add(this.printerBase);
            this.groupBoxColors.Controls.Add(this.filament);
            this.groupBoxColors.Controls.Add(this.selectedFaces);
            this.groupBoxColors.Controls.Add(this.edges);
            this.groupBoxColors.Controls.Add(this.faces);
            this.groupBoxColors.Controls.Add(this.background);
            this.groupBoxColors.Controls.Add(this.label4);
            this.groupBoxColors.Controls.Add(this.label6);
            this.groupBoxColors.Controls.Add(this.label3);
            this.groupBoxColors.Controls.Add(this.label2);
            this.groupBoxColors.Controls.Add(this.label1);
            this.groupBoxColors.Location = new System.Drawing.Point(13, 13);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(517, 114);
            this.groupBoxColors.TabIndex = 0;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Colors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Printer base:";
            // 
            // printerBase
            // 
            this.printerBase.BackColor = System.Drawing.Color.White;
            this.printerBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printerBase.Location = new System.Drawing.Point(341, 20);
            this.printerBase.Name = "printerBase";
            this.printerBase.Size = new System.Drawing.Size(104, 22);
            this.printerBase.TabIndex = 4;
            this.printerBase.Click += new System.EventHandler(this.printerBase_Click);
            // 
            // filament
            // 
            this.filament.BackColor = System.Drawing.Color.Yellow;
            this.filament.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filament.Location = new System.Drawing.Point(341, 76);
            this.filament.Name = "filament";
            this.filament.Size = new System.Drawing.Size(104, 22);
            this.filament.TabIndex = 4;
            this.filament.Click += new System.EventHandler(this.filament_Click);
            // 
            // selectedFaces
            // 
            this.selectedFaces.BackColor = System.Drawing.Color.Fuchsia;
            this.selectedFaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedFaces.Location = new System.Drawing.Point(111, 76);
            this.selectedFaces.Name = "selectedFaces";
            this.selectedFaces.Size = new System.Drawing.Size(104, 22);
            this.selectedFaces.TabIndex = 4;
            this.selectedFaces.Click += new System.EventHandler(this.selectedFaces_Click);
            // 
            // edges
            // 
            this.edges.BackColor = System.Drawing.Color.RosyBrown;
            this.edges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edges.Location = new System.Drawing.Point(341, 48);
            this.edges.Name = "edges";
            this.edges.Size = new System.Drawing.Size(104, 22);
            this.edges.TabIndex = 4;
            this.edges.Click += new System.EventHandler(this.edges_Click);
            // 
            // faces
            // 
            this.faces.BackColor = System.Drawing.Color.Red;
            this.faces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.faces.Location = new System.Drawing.Point(111, 48);
            this.faces.Name = "faces";
            this.faces.Size = new System.Drawing.Size(104, 22);
            this.faces.TabIndex = 4;
            this.faces.Click += new System.EventHandler(this.faces_Click);
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Black;
            this.background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.background.Location = new System.Drawing.Point(111, 20);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(104, 22);
            this.background.TabIndex = 4;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filament:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Edges:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selected faces:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faces:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Background:";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(439, 314);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.useVBOs);
            this.groupBox1.Controls.Add(this.textWidthOverThickness);
            this.groupBox1.Controls.Add(this.textLayerHeight);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboFilamentVisualization);
            this.groupBox1.Controls.Add(this.showPrintbed);
            this.groupBox1.Controls.Add(this.showEdges);
            this.groupBox1.Location = new System.Drawing.Point(13, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualization";
            // 
            // useVBOs
            // 
            this.useVBOs.AutoSize = true;
            this.useVBOs.Checked = true;
            this.useVBOs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useVBOs.Location = new System.Drawing.Point(13, 67);
            this.useVBOs.Name = "useVBOs";
            this.useVBOs.Size = new System.Drawing.Size(139, 17);
            this.useVBOs.TabIndex = 8;
            this.useVBOs.Text = "Use VBOs (much faster)";
            this.useVBOs.UseVisualStyleBackColor = true;
            this.useVBOs.CheckedChanged += new System.EventHandler(this.showEdges_CheckedChanged);
            // 
            // textWidthOverThickness
            // 
            this.textWidthOverThickness.Location = new System.Drawing.Point(352, 75);
            this.textWidthOverThickness.Name = "textWidthOverThickness";
            this.textWidthOverThickness.Size = new System.Drawing.Size(100, 20);
            this.textWidthOverThickness.TabIndex = 7;
            this.textWidthOverThickness.Text = "1.8";
            this.textWidthOverThickness.TextChanged += new System.EventHandler(this.textLayerHeight_TextChanged);
            // 
            // textLayerHeight
            // 
            this.textLayerHeight.Location = new System.Drawing.Point(352, 48);
            this.textLayerHeight.Name = "textLayerHeight";
            this.textLayerHeight.Size = new System.Drawing.Size(100, 20);
            this.textLayerHeight.TabIndex = 6;
            this.textLayerHeight.Text = "0.38";
            this.textLayerHeight.TextChanged += new System.EventHandler(this.textLayerHeight_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Width over thickness:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Layer height:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Filament visualization:";
            // 
            // comboFilamentVisualization
            // 
            this.comboFilamentVisualization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilamentVisualization.FormattingEnabled = true;
            this.comboFilamentVisualization.Items.AddRange(new object[] {
            "Simple",
            "Medium",
            "Fine",
            "Ultra fine"});
            this.comboFilamentVisualization.Location = new System.Drawing.Point(352, 20);
            this.comboFilamentVisualization.Name = "comboFilamentVisualization";
            this.comboFilamentVisualization.Size = new System.Drawing.Size(121, 21);
            this.comboFilamentVisualization.TabIndex = 2;
            this.comboFilamentVisualization.SelectedIndexChanged += new System.EventHandler(this.comboFilamentVisualization_SelectedIndexChanged);
            // 
            // showPrintbed
            // 
            this.showPrintbed.AutoSize = true;
            this.showPrintbed.Checked = true;
            this.showPrintbed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPrintbed.Location = new System.Drawing.Point(13, 44);
            this.showPrintbed.Name = "showPrintbed";
            this.showPrintbed.Size = new System.Drawing.Size(94, 17);
            this.showPrintbed.TabIndex = 1;
            this.showPrintbed.Text = "Show printbed";
            this.showPrintbed.UseVisualStyleBackColor = true;
            this.showPrintbed.CheckedChanged += new System.EventHandler(this.showEdges_CheckedChanged);
            // 
            // showEdges
            // 
            this.showEdges.AutoSize = true;
            this.showEdges.Location = new System.Drawing.Point(13, 20);
            this.showEdges.Name = "showEdges";
            this.showEdges.Size = new System.Drawing.Size(85, 17);
            this.showEdges.TabIndex = 0;
            this.showEdges.Text = "Show edges";
            this.showEdges.UseVisualStyleBackColor = true;
            this.showEdges.CheckedChanged += new System.EventHandler(this.showEdges_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.enableLight4);
            this.groupBox2.Controls.Add(this.enableLight3);
            this.groupBox2.Controls.Add(this.enableLight2);
            this.groupBox2.Controls.Add(this.enableLight1);
            this.groupBox2.Location = new System.Drawing.Point(12, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 53);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lightning";
            // 
            // enableLight4
            // 
            this.enableLight4.AutoSize = true;
            this.enableLight4.Location = new System.Drawing.Point(305, 20);
            this.enableLight4.Name = "enableLight4";
            this.enableLight4.Size = new System.Drawing.Size(90, 17);
            this.enableLight4.TabIndex = 3;
            this.enableLight4.Text = "Enable light 4";
            this.enableLight4.UseVisualStyleBackColor = true;
            this.enableLight4.CheckedChanged += new System.EventHandler(this.showEdges_CheckedChanged);
            // 
            // enableLight3
            // 
            this.enableLight3.AutoSize = true;
            this.enableLight3.Location = new System.Drawing.Point(208, 20);
            this.enableLight3.Name = "enableLight3";
            this.enableLight3.Size = new System.Drawing.Size(90, 17);
            this.enableLight3.TabIndex = 2;
            this.enableLight3.Text = "Enable light 3";
            this.enableLight3.UseVisualStyleBackColor = true;
            this.enableLight3.CheckedChanged += new System.EventHandler(this.showEdges_CheckedChanged);
            // 
            // enableLight2
            // 
            this.enableLight2.AutoSize = true;
            this.enableLight2.Checked = true;
            this.enableLight2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableLight2.Location = new System.Drawing.Point(111, 20);
            this.enableLight2.Name = "enableLight2";
            this.enableLight2.Size = new System.Drawing.Size(90, 17);
            this.enableLight2.TabIndex = 1;
            this.enableLight2.Text = "Enable light 2";
            this.enableLight2.UseVisualStyleBackColor = true;
            this.enableLight2.CheckedChanged += new System.EventHandler(this.showEdges_CheckedChanged);
            // 
            // enableLight1
            // 
            this.enableLight1.AutoSize = true;
            this.enableLight1.Checked = true;
            this.enableLight1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableLight1.Location = new System.Drawing.Point(13, 20);
            this.enableLight1.Name = "enableLight1";
            this.enableLight1.Size = new System.Drawing.Size(90, 17);
            this.enableLight1.TabIndex = 0;
            this.enableLight1.Text = "Enable light 1";
            this.enableLight1.UseVisualStyleBackColor = true;
            this.enableLight1.CheckedChanged += new System.EventHandler(this.showEdges_CheckedChanged);
            // 
            // ThreeDSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 349);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxColors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThreeDSettings";
            this.Opacity = 0.85;
            this.Text = "3D settings";
            this.TopMost = true;
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxColors.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Panel faces;
        public System.Windows.Forms.Panel background;
        public System.Windows.Forms.Panel selectedFaces;
        public System.Windows.Forms.Panel filament;
        public System.Windows.Forms.Panel printerBase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox showPrintbed;
        public System.Windows.Forms.CheckBox showEdges;
        public System.Windows.Forms.CheckBox enableLight4;
        public System.Windows.Forms.CheckBox enableLight3;
        public System.Windows.Forms.CheckBox enableLight2;
        public System.Windows.Forms.CheckBox enableLight1;
        public System.Windows.Forms.Panel edges;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textWidthOverThickness;
        private System.Windows.Forms.TextBox textLayerHeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboFilamentVisualization;
        public System.Windows.Forms.CheckBox useVBOs;
    }
}