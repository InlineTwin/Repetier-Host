namespace RepetierHost.view
{
    partial class TestGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestGenerator));
            this.label1 = new System.Windows.Forms.Label();
            this.comboTestCase = new System.Windows.Forms.ComboBox();
            this.buttonCreateTestCase = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.labelP3 = new System.Windows.Forms.Label();
            this.textP1 = new System.Windows.Forms.TextBox();
            this.textP2 = new System.Windows.Forms.TextBox();
            this.textP3 = new System.Windows.Forms.TextBox();
            this.labelU1 = new System.Windows.Forms.Label();
            this.labelU2 = new System.Windows.Forms.Label();
            this.labelU3 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelP4 = new System.Windows.Forms.Label();
            this.textP4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelU4 = new System.Windows.Forms.Label();
            this.labelU5 = new System.Windows.Forms.Label();
            this.textP5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test case:";
            // 
            // comboTestCase
            // 
            this.comboTestCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTestCase.FormattingEnabled = true;
            this.comboTestCase.Items.AddRange(new object[] {
            "Advance calibration Test 1",
            "Advance calibration Test 2"});
            this.comboTestCase.Location = new System.Drawing.Point(93, 13);
            this.comboTestCase.Name = "comboTestCase";
            this.comboTestCase.Size = new System.Drawing.Size(195, 21);
            this.comboTestCase.TabIndex = 1;
            this.comboTestCase.SelectedIndexChanged += new System.EventHandler(this.comboTestCase_SelectedIndexChanged);
            // 
            // buttonCreateTestCase
            // 
            this.buttonCreateTestCase.Location = new System.Drawing.Point(57, 175);
            this.buttonCreateTestCase.Name = "buttonCreateTestCase";
            this.buttonCreateTestCase.Size = new System.Drawing.Size(124, 23);
            this.buttonCreateTestCase.TabIndex = 2;
            this.buttonCreateTestCase.Text = "Create test case";
            this.buttonCreateTestCase.UseVisualStyleBackColor = true;
            this.buttonCreateTestCase.Click += new System.EventHandler(this.buttonCreateTestCase_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(213, 175);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(75, 23);
            this.buttonAbort.TabIndex = 3;
            this.buttonAbort.Text = "Cancel";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Location = new System.Drawing.Point(13, 45);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(62, 13);
            this.labelP1.TabIndex = 4;
            this.labelP1.Text = "Low speed:";
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Location = new System.Drawing.Point(13, 71);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(64, 13);
            this.labelP2.TabIndex = 5;
            this.labelP2.Text = "High speed:";
            // 
            // labelP3
            // 
            this.labelP3.AutoSize = true;
            this.labelP3.Location = new System.Drawing.Point(13, 97);
            this.labelP3.Name = "labelP3";
            this.labelP3.Size = new System.Drawing.Size(69, 13);
            this.labelP3.TabIndex = 6;
            this.labelP3.Text = "Acceleration:";
            // 
            // textP1
            // 
            this.textP1.Location = new System.Drawing.Point(93, 42);
            this.textP1.Name = "textP1";
            this.textP1.Size = new System.Drawing.Size(100, 20);
            this.textP1.TabIndex = 7;
            this.textP1.Text = "10";
            this.textP1.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textP2
            // 
            this.textP2.Location = new System.Drawing.Point(93, 68);
            this.textP2.Name = "textP2";
            this.textP2.Size = new System.Drawing.Size(100, 20);
            this.textP2.TabIndex = 8;
            this.textP2.Text = "80";
            this.textP2.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textP3
            // 
            this.textP3.Location = new System.Drawing.Point(93, 94);
            this.textP3.Name = "textP3";
            this.textP3.Size = new System.Drawing.Size(100, 20);
            this.textP3.TabIndex = 9;
            this.textP3.Text = "1000";
            this.textP3.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // labelU1
            // 
            this.labelU1.AutoSize = true;
            this.labelU1.Location = new System.Drawing.Point(224, 49);
            this.labelU1.Name = "labelU1";
            this.labelU1.Size = new System.Drawing.Size(39, 13);
            this.labelU1.TabIndex = 10;
            this.labelU1.Text = "[mm/s]";
            // 
            // labelU2
            // 
            this.labelU2.AutoSize = true;
            this.labelU2.Location = new System.Drawing.Point(224, 71);
            this.labelU2.Name = "labelU2";
            this.labelU2.Size = new System.Drawing.Size(39, 13);
            this.labelU2.TabIndex = 11;
            this.labelU2.Text = "[mm/s]";
            // 
            // labelU3
            // 
            this.labelU3.AutoSize = true;
            this.labelU3.Location = new System.Drawing.Point(224, 96);
            this.labelU3.Name = "labelU3";
            this.labelU3.Size = new System.Drawing.Size(42, 13);
            this.labelU3.TabIndex = 12;
            this.labelU3.Text = "[mm/s²]";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // labelP4
            // 
            this.labelP4.AutoSize = true;
            this.labelP4.Location = new System.Drawing.Point(13, 119);
            this.labelP4.Name = "labelP4";
            this.labelP4.Size = new System.Drawing.Size(52, 13);
            this.labelP4.TabIndex = 13;
            this.labelP4.Text = "Length 1:";
            // 
            // textP4
            // 
            this.textP4.Location = new System.Drawing.Point(93, 116);
            this.textP4.Name = "textP4";
            this.textP4.Size = new System.Drawing.Size(100, 20);
            this.textP4.TabIndex = 14;
            this.textP4.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Length 2:";
            // 
            // labelU4
            // 
            this.labelU4.AutoSize = true;
            this.labelU4.Location = new System.Drawing.Point(224, 119);
            this.labelU4.Name = "labelU4";
            this.labelU4.Size = new System.Drawing.Size(29, 13);
            this.labelU4.TabIndex = 16;
            this.labelU4.Text = "[mm]";
            // 
            // labelU5
            // 
            this.labelU5.AutoSize = true;
            this.labelU5.Location = new System.Drawing.Point(224, 146);
            this.labelU5.Name = "labelU5";
            this.labelU5.Size = new System.Drawing.Size(29, 13);
            this.labelU5.TabIndex = 17;
            this.labelU5.Text = "[mm]";
            // 
            // textP5
            // 
            this.textP5.Location = new System.Drawing.Point(93, 143);
            this.textP5.Name = "textP5";
            this.textP5.Size = new System.Drawing.Size(100, 20);
            this.textP5.TabIndex = 18;
            this.textP5.Text = "80";
            // 
            // TestGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 211);
            this.ControlBox = false;
            this.Controls.Add(this.textP5);
            this.Controls.Add(this.labelU5);
            this.Controls.Add(this.labelU4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textP4);
            this.Controls.Add(this.labelP4);
            this.Controls.Add(this.labelU3);
            this.Controls.Add(this.labelU2);
            this.Controls.Add(this.labelU1);
            this.Controls.Add(this.textP3);
            this.Controls.Add(this.textP2);
            this.Controls.Add(this.textP1);
            this.Controls.Add(this.labelP3);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelP1);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonCreateTestCase);
            this.Controls.Add(this.comboTestCase);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestGenerator";
            this.Text = "Test generator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTestCase;
        private System.Windows.Forms.Button buttonCreateTestCase;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Label labelP3;
        private System.Windows.Forms.TextBox textP1;
        private System.Windows.Forms.TextBox textP2;
        private System.Windows.Forms.TextBox textP3;
        private System.Windows.Forms.Label labelU1;
        private System.Windows.Forms.Label labelU2;
        private System.Windows.Forms.Label labelU3;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox textP4;
        private System.Windows.Forms.Label labelP4;
        private System.Windows.Forms.TextBox textP5;
        private System.Windows.Forms.Label labelU5;
        private System.Windows.Forms.Label labelU4;
        private System.Windows.Forms.Label label2;
    }
}