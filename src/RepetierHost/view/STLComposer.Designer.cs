namespace RepetierHost.view
{
    partial class STLComposer
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControls = new System.Windows.Forms.Panel();
            this.buttonLand = new System.Windows.Forms.Button();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.buttonRemoveSTL = new System.Windows.Forms.Button();
            this.buttonAddSTL = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.listSTLObjects = new System.Windows.Forms.ListBox();
            this.checkScaleAll = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textRotZ = new System.Windows.Forms.TextBox();
            this.textScaleZ = new System.Windows.Forms.TextBox();
            this.textTransZ = new System.Windows.Forms.TextBox();
            this.textRotY = new System.Windows.Forms.TextBox();
            this.textRotX = new System.Windows.Forms.TextBox();
            this.textScaleY = new System.Windows.Forms.TextBox();
            this.textScaleX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textTransY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textTransX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSlice = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileSTL = new System.Windows.Forms.OpenFileDialog();
            this.saveSTL = new System.Windows.Forms.SaveFileDialog();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.buttonLand);
            this.panelControls.Controls.Add(this.buttonCenter);
            this.panelControls.Controls.Add(this.buttonRemoveSTL);
            this.panelControls.Controls.Add(this.buttonAddSTL);
            this.panelControls.Controls.Add(this.label13);
            this.panelControls.Controls.Add(this.listSTLObjects);
            this.panelControls.Controls.Add(this.checkScaleAll);
            this.panelControls.Controls.Add(this.label12);
            this.panelControls.Controls.Add(this.label8);
            this.panelControls.Controls.Add(this.label4);
            this.panelControls.Controls.Add(this.label11);
            this.panelControls.Controls.Add(this.label7);
            this.panelControls.Controls.Add(this.label3);
            this.panelControls.Controls.Add(this.label10);
            this.panelControls.Controls.Add(this.label6);
            this.panelControls.Controls.Add(this.label2);
            this.panelControls.Controls.Add(this.textRotZ);
            this.panelControls.Controls.Add(this.textScaleZ);
            this.panelControls.Controls.Add(this.textTransZ);
            this.panelControls.Controls.Add(this.textRotY);
            this.panelControls.Controls.Add(this.textRotX);
            this.panelControls.Controls.Add(this.textScaleY);
            this.panelControls.Controls.Add(this.textScaleX);
            this.panelControls.Controls.Add(this.label9);
            this.panelControls.Controls.Add(this.textTransY);
            this.panelControls.Controls.Add(this.label5);
            this.panelControls.Controls.Add(this.textTransX);
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Controls.Add(this.buttonSlice);
            this.panelControls.Controls.Add(this.buttonSave);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControls.Location = new System.Drawing.Point(643, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(235, 624);
            this.panelControls.TabIndex = 0;
            // 
            // buttonLand
            // 
            this.buttonLand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLand.Location = new System.Drawing.Point(121, 563);
            this.buttonLand.Name = "buttonLand";
            this.buttonLand.Size = new System.Drawing.Size(114, 23);
            this.buttonLand.TabIndex = 14;
            this.buttonLand.Text = "Drop object";
            this.buttonLand.UseVisualStyleBackColor = true;
            this.buttonLand.Click += new System.EventHandler(this.buttonLand_Click);
            // 
            // buttonCenter
            // 
            this.buttonCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCenter.Location = new System.Drawing.Point(0, 563);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(121, 23);
            this.buttonCenter.TabIndex = 13;
            this.buttonCenter.Text = "Center object";
            this.buttonCenter.UseVisualStyleBackColor = true;
            this.buttonCenter.Click += new System.EventHandler(this.buttonCenter_Click);
            // 
            // buttonRemoveSTL
            // 
            this.buttonRemoveSTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveSTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveSTL.Location = new System.Drawing.Point(121, 601);
            this.buttonRemoveSTL.Name = "buttonRemoveSTL";
            this.buttonRemoveSTL.Size = new System.Drawing.Size(114, 23);
            this.buttonRemoveSTL.TabIndex = 16;
            this.buttonRemoveSTL.Text = "Remove STL file";
            this.buttonRemoveSTL.UseVisualStyleBackColor = true;
            this.buttonRemoveSTL.Click += new System.EventHandler(this.buttonRemoveSTL_Click);
            // 
            // buttonAddSTL
            // 
            this.buttonAddSTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddSTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSTL.Location = new System.Drawing.Point(0, 601);
            this.buttonAddSTL.Name = "buttonAddSTL";
            this.buttonAddSTL.Size = new System.Drawing.Size(121, 23);
            this.buttonAddSTL.TabIndex = 15;
            this.buttonAddSTL.Text = "Add STL file";
            this.buttonAddSTL.UseVisualStyleBackColor = true;
            this.buttonAddSTL.Click += new System.EventHandler(this.buttonAddSTL_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "STL objects";
            // 
            // listSTLObjects
            // 
            this.listSTLObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listSTLObjects.FormattingEnabled = true;
            this.listSTLObjects.Location = new System.Drawing.Point(0, 211);
            this.listSTLObjects.Name = "listSTLObjects";
            this.listSTLObjects.Size = new System.Drawing.Size(235, 355);
            this.listSTLObjects.TabIndex = 12;
            this.listSTLObjects.SelectedIndexChanged += new System.EventHandler(this.listSTLObjects_SelectedIndexChanged);
            // 
            // checkScaleAll
            // 
            this.checkScaleAll.AutoSize = true;
            this.checkScaleAll.Checked = true;
            this.checkScaleAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkScaleAll.Location = new System.Drawing.Point(9, 122);
            this.checkScaleAll.Name = "checkScaleAll";
            this.checkScaleAll.Size = new System.Drawing.Size(108, 17);
            this.checkScaleAll.TabIndex = 8;
            this.checkScaleAll.Text = "Lock aspect ratio";
            this.checkScaleAll.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Z";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // textRotZ
            // 
            this.textRotZ.Location = new System.Drawing.Point(162, 164);
            this.textRotZ.Name = "textRotZ";
            this.textRotZ.Size = new System.Drawing.Size(49, 20);
            this.textRotZ.TabIndex = 11;
            this.textRotZ.TextChanged += new System.EventHandler(this.textRotZ_TextChanged);
            this.textRotZ.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textScaleZ
            // 
            this.textScaleZ.Location = new System.Drawing.Point(162, 95);
            this.textScaleZ.Name = "textScaleZ";
            this.textScaleZ.Size = new System.Drawing.Size(49, 20);
            this.textScaleZ.TabIndex = 7;
            this.textScaleZ.TextChanged += new System.EventHandler(this.textScaleZ_TextChanged);
            this.textScaleZ.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textTransZ
            // 
            this.textTransZ.Location = new System.Drawing.Point(162, 50);
            this.textTransZ.Name = "textTransZ";
            this.textTransZ.Size = new System.Drawing.Size(49, 20);
            this.textTransZ.TabIndex = 4;
            this.textTransZ.TextChanged += new System.EventHandler(this.textTransZ_TextChanged);
            this.textTransZ.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textRotY
            // 
            this.textRotY.Location = new System.Drawing.Point(93, 164);
            this.textRotY.Name = "textRotY";
            this.textRotY.Size = new System.Drawing.Size(49, 20);
            this.textRotY.TabIndex = 10;
            this.textRotY.TextChanged += new System.EventHandler(this.textRotY_TextChanged);
            this.textRotY.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textRotX
            // 
            this.textRotX.Location = new System.Drawing.Point(24, 164);
            this.textRotX.Name = "textRotX";
            this.textRotX.Size = new System.Drawing.Size(49, 20);
            this.textRotX.TabIndex = 9;
            this.textRotX.TextChanged += new System.EventHandler(this.textRotX_TextChanged);
            this.textRotX.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textScaleY
            // 
            this.textScaleY.Location = new System.Drawing.Point(93, 95);
            this.textScaleY.Name = "textScaleY";
            this.textScaleY.Size = new System.Drawing.Size(49, 20);
            this.textScaleY.TabIndex = 6;
            this.textScaleY.TextChanged += new System.EventHandler(this.textScaleY_TextChanged);
            this.textScaleY.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textScaleX
            // 
            this.textScaleX.Location = new System.Drawing.Point(24, 95);
            this.textScaleX.Name = "textScaleX";
            this.textScaleX.Size = new System.Drawing.Size(49, 20);
            this.textScaleX.TabIndex = 5;
            this.textScaleX.TextChanged += new System.EventHandler(this.textScaleX_TextChanged);
            this.textScaleX.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Rotate:";
            // 
            // textTransY
            // 
            this.textTransY.Location = new System.Drawing.Point(93, 50);
            this.textTransY.Name = "textTransY";
            this.textTransY.Size = new System.Drawing.Size(49, 20);
            this.textTransY.TabIndex = 3;
            this.textTransY.TextChanged += new System.EventHandler(this.textTransY_TextChanged);
            this.textTransY.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Scale:";
            // 
            // textTransX
            // 
            this.textTransX.Location = new System.Drawing.Point(24, 50);
            this.textTransX.Name = "textTransX";
            this.textTransX.Size = new System.Drawing.Size(49, 20);
            this.textTransX.TabIndex = 2;
            this.textTransX.TextChanged += new System.EventHandler(this.textTransX_TextChanged);
            this.textTransX.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Translation:";
            // 
            // buttonSlice
            // 
            this.buttonSlice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSlice.Location = new System.Drawing.Point(121, 3);
            this.buttonSlice.Name = "buttonSlice";
            this.buttonSlice.Size = new System.Drawing.Size(113, 23);
            this.buttonSlice.TabIndex = 1;
            this.buttonSlice.Text = "Generate G-Code";
            this.buttonSlice.UseVisualStyleBackColor = true;
            this.buttonSlice.Click += new System.EventHandler(this.buttonSlice_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(0, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save as STL";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // openFileSTL
            // 
            this.openFileSTL.DefaultExt = "stl";
            this.openFileSTL.Filter = "STL-Files|*.stl|All files|*.*";
            this.openFileSTL.Title = "Add STL file";
            // 
            // saveSTL
            // 
            this.saveSTL.DefaultExt = "stl";
            this.saveSTL.Filter = "STL-Files|*.stl";
            this.saveSTL.Title = "Save composition";
            // 
            // STLComposer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControls);
            this.Name = "STLComposer";
            this.Size = new System.Drawing.Size(878, 624);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button buttonSlice;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textTransZ;
        private System.Windows.Forms.TextBox textTransY;
        private System.Windows.Forms.TextBox textTransX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkScaleAll;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textRotZ;
        private System.Windows.Forms.TextBox textScaleZ;
        private System.Windows.Forms.TextBox textRotY;
        private System.Windows.Forms.TextBox textRotX;
        private System.Windows.Forms.TextBox textScaleY;
        private System.Windows.Forms.TextBox textScaleX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRemoveSTL;
        private System.Windows.Forms.Button buttonAddSTL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listSTLObjects;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.OpenFileDialog openFileSTL;
        private System.Windows.Forms.SaveFileDialog saveSTL;
        private System.Windows.Forms.Button buttonLand;
        private System.Windows.Forms.Button buttonCenter;
    }
}
