namespace RepetierHost.view
{
    partial class PrintPanel
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
            this.buttonJobStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textGCode = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.buttonHomeX = new System.Windows.Forms.Button();
            this.buttonXM100 = new System.Windows.Forms.Button();
            this.buttonXM10 = new System.Windows.Forms.Button();
            this.buttonXM1 = new System.Windows.Forms.Button();
            this.buttonXM01 = new System.Windows.Forms.Button();
            this.buttonXP01 = new System.Windows.Forms.Button();
            this.buttonXP1 = new System.Windows.Forms.Button();
            this.buttonXP10 = new System.Windows.Forms.Button();
            this.buttonXP100 = new System.Windows.Forms.Button();
            this.buttonYP100 = new System.Windows.Forms.Button();
            this.buttonYP10 = new System.Windows.Forms.Button();
            this.buttonYP1 = new System.Windows.Forms.Button();
            this.buttonYP01 = new System.Windows.Forms.Button();
            this.buttonYM01 = new System.Windows.Forms.Button();
            this.buttonYM1 = new System.Windows.Forms.Button();
            this.buttonYM10 = new System.Windows.Forms.Button();
            this.buttonYM100 = new System.Windows.Forms.Button();
            this.buttonHomeY = new System.Windows.Forms.Button();
            this.labelY = new System.Windows.Forms.Label();
            this.buttonZP100 = new System.Windows.Forms.Button();
            this.buttonZP10 = new System.Windows.Forms.Button();
            this.buttonZP1 = new System.Windows.Forms.Button();
            this.buttonZP01 = new System.Windows.Forms.Button();
            this.buttonZM01 = new System.Windows.Forms.Button();
            this.buttonZM1 = new System.Windows.Forms.Button();
            this.buttonZM10 = new System.Windows.Forms.Button();
            this.buttonZM100 = new System.Windows.Forms.Button();
            this.buttonHomeZ = new System.Windows.Forms.Button();
            this.labelZ = new System.Windows.Forms.Label();
            this.buttonHomeAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonExtrude = new System.Windows.Forms.Button();
            this.trackExtruderSpeed = new System.Windows.Forms.TrackBar();
            this.labelExtruderSpeed = new System.Windows.Forms.Label();
            this.labelExtruderLength = new System.Windows.Forms.Label();
            this.trackExtruderLength = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExtruderSetTemp = new System.Windows.Forms.Button();
            this.textExtruderSetTemp = new System.Windows.Forms.TextBox();
            this.labelExtruderTemp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPrintbedSendTemp = new System.Windows.Forms.Button();
            this.textPrintbedTemp = new System.Windows.Forms.TextBox();
            this.labelPrintbedTemp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelVoltage = new System.Windows.Forms.Label();
            this.trackFanVoltage = new System.Windows.Forms.TrackBar();
            this.buttonGoDisposeArea = new System.Windows.Forms.Button();
            this.buttonSimulateOK = new System.Windows.Forms.Button();
            this.switchFanOn = new RepetierHost.view.SwitchButton();
            this.switchBedHeat = new RepetierHost.view.SwitchButton();
            this.switchExtruderReverse = new RepetierHost.view.SwitchButton();
            this.switchExtruderHeatOn = new RepetierHost.view.SwitchButton();
            this.switchDryRun = new RepetierHost.view.SwitchButton();
            this.switchErrors = new RepetierHost.view.SwitchButton();
            this.switchInfo = new RepetierHost.view.SwitchButton();
            this.switchEcho = new RepetierHost.view.SwitchButton();
            this.switchPower = new RepetierHost.view.SwitchButton();
            this.switchConnect = new RepetierHost.view.SwitchButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackExtruderSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackExtruderLength)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackFanVoltage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonJobStatus
            // 
            this.buttonJobStatus.Location = new System.Drawing.Point(324, 3);
            this.buttonJobStatus.Name = "buttonJobStatus";
            this.buttonJobStatus.Size = new System.Drawing.Size(100, 23);
            this.buttonJobStatus.TabIndex = 3;
            this.buttonJobStatus.Text = "Job status";
            this.buttonJobStatus.UseVisualStyleBackColor = true;
            this.buttonJobStatus.Click += new System.EventHandler(this.buttonJobStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "GCode:";
            // 
            // textGCode
            // 
            this.textGCode.Location = new System.Drawing.Point(54, 63);
            this.textGCode.Name = "textGCode";
            this.textGCode.Size = new System.Drawing.Size(305, 20);
            this.textGCode.TabIndex = 8;
            this.textGCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textGCode_KeyDown);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(365, 63);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(59, 23);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(4, 97);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(35, 13);
            this.labelX.TabIndex = 10;
            this.labelX.Text = "X=0.0";
            // 
            // buttonHomeX
            // 
            this.buttonHomeX.Location = new System.Drawing.Point(63, 92);
            this.buttonHomeX.Name = "buttonHomeX";
            this.buttonHomeX.Size = new System.Drawing.Size(45, 23);
            this.buttonHomeX.TabIndex = 10;
            this.buttonHomeX.Text = "Home";
            this.buttonHomeX.UseVisualStyleBackColor = true;
            this.buttonHomeX.Click += new System.EventHandler(this.buttonHomeX_Click);
            // 
            // buttonXM100
            // 
            this.buttonXM100.Location = new System.Drawing.Point(114, 92);
            this.buttonXM100.Name = "buttonXM100";
            this.buttonXM100.Size = new System.Drawing.Size(36, 23);
            this.buttonXM100.TabIndex = 11;
            this.buttonXM100.Text = "-100";
            this.buttonXM100.UseVisualStyleBackColor = true;
            this.buttonXM100.Click += new System.EventHandler(this.buttonXM100_Click);
            // 
            // buttonXM10
            // 
            this.buttonXM10.Location = new System.Drawing.Point(156, 92);
            this.buttonXM10.Name = "buttonXM10";
            this.buttonXM10.Size = new System.Drawing.Size(30, 23);
            this.buttonXM10.TabIndex = 12;
            this.buttonXM10.Text = "-10";
            this.buttonXM10.UseVisualStyleBackColor = true;
            this.buttonXM10.Click += new System.EventHandler(this.buttonXM10_Click);
            // 
            // buttonXM1
            // 
            this.buttonXM1.Location = new System.Drawing.Point(192, 92);
            this.buttonXM1.Name = "buttonXM1";
            this.buttonXM1.Size = new System.Drawing.Size(24, 23);
            this.buttonXM1.TabIndex = 13;
            this.buttonXM1.Text = "-1";
            this.buttonXM1.UseVisualStyleBackColor = true;
            this.buttonXM1.Click += new System.EventHandler(this.buttonXM1_Click);
            // 
            // buttonXM01
            // 
            this.buttonXM01.Location = new System.Drawing.Point(222, 92);
            this.buttonXM01.Name = "buttonXM01";
            this.buttonXM01.Size = new System.Drawing.Size(36, 23);
            this.buttonXM01.TabIndex = 14;
            this.buttonXM01.Text = "-0.1";
            this.buttonXM01.UseVisualStyleBackColor = true;
            this.buttonXM01.Click += new System.EventHandler(this.buttonXM01_Click);
            // 
            // buttonXP01
            // 
            this.buttonXP01.Location = new System.Drawing.Point(264, 92);
            this.buttonXP01.Name = "buttonXP01";
            this.buttonXP01.Size = new System.Drawing.Size(36, 23);
            this.buttonXP01.TabIndex = 15;
            this.buttonXP01.Text = "+0.1";
            this.buttonXP01.UseVisualStyleBackColor = true;
            this.buttonXP01.Click += new System.EventHandler(this.buttonXP01_Click);
            // 
            // buttonXP1
            // 
            this.buttonXP1.Location = new System.Drawing.Point(306, 92);
            this.buttonXP1.Name = "buttonXP1";
            this.buttonXP1.Size = new System.Drawing.Size(28, 23);
            this.buttonXP1.TabIndex = 16;
            this.buttonXP1.Text = "+1";
            this.buttonXP1.UseVisualStyleBackColor = true;
            this.buttonXP1.Click += new System.EventHandler(this.buttonXP1_Click);
            // 
            // buttonXP10
            // 
            this.buttonXP10.Location = new System.Drawing.Point(340, 92);
            this.buttonXP10.Name = "buttonXP10";
            this.buttonXP10.Size = new System.Drawing.Size(36, 23);
            this.buttonXP10.TabIndex = 17;
            this.buttonXP10.Text = "+10";
            this.buttonXP10.UseVisualStyleBackColor = true;
            this.buttonXP10.Click += new System.EventHandler(this.buttonXP10_Click);
            // 
            // buttonXP100
            // 
            this.buttonXP100.Location = new System.Drawing.Point(382, 92);
            this.buttonXP100.Name = "buttonXP100";
            this.buttonXP100.Size = new System.Drawing.Size(43, 23);
            this.buttonXP100.TabIndex = 18;
            this.buttonXP100.Text = "+100";
            this.buttonXP100.UseVisualStyleBackColor = true;
            this.buttonXP100.Click += new System.EventHandler(this.buttonXP100_Click);
            // 
            // buttonYP100
            // 
            this.buttonYP100.Location = new System.Drawing.Point(382, 121);
            this.buttonYP100.Name = "buttonYP100";
            this.buttonYP100.Size = new System.Drawing.Size(43, 23);
            this.buttonYP100.TabIndex = 27;
            this.buttonYP100.Text = "+100";
            this.buttonYP100.UseVisualStyleBackColor = true;
            this.buttonYP100.Click += new System.EventHandler(this.buttonYP100_Click);
            // 
            // buttonYP10
            // 
            this.buttonYP10.Location = new System.Drawing.Point(340, 121);
            this.buttonYP10.Name = "buttonYP10";
            this.buttonYP10.Size = new System.Drawing.Size(36, 23);
            this.buttonYP10.TabIndex = 26;
            this.buttonYP10.Text = "+10";
            this.buttonYP10.UseVisualStyleBackColor = true;
            this.buttonYP10.Click += new System.EventHandler(this.buttonYP10_Click);
            // 
            // buttonYP1
            // 
            this.buttonYP1.Location = new System.Drawing.Point(306, 121);
            this.buttonYP1.Name = "buttonYP1";
            this.buttonYP1.Size = new System.Drawing.Size(28, 23);
            this.buttonYP1.TabIndex = 25;
            this.buttonYP1.Text = "+1";
            this.buttonYP1.UseVisualStyleBackColor = true;
            this.buttonYP1.Click += new System.EventHandler(this.buttonYP1_Click);
            // 
            // buttonYP01
            // 
            this.buttonYP01.Location = new System.Drawing.Point(264, 121);
            this.buttonYP01.Name = "buttonYP01";
            this.buttonYP01.Size = new System.Drawing.Size(36, 23);
            this.buttonYP01.TabIndex = 24;
            this.buttonYP01.Text = "+0.1";
            this.buttonYP01.UseVisualStyleBackColor = true;
            this.buttonYP01.Click += new System.EventHandler(this.buttonYP01_Click);
            // 
            // buttonYM01
            // 
            this.buttonYM01.Location = new System.Drawing.Point(222, 121);
            this.buttonYM01.Name = "buttonYM01";
            this.buttonYM01.Size = new System.Drawing.Size(36, 23);
            this.buttonYM01.TabIndex = 23;
            this.buttonYM01.Text = "-0.1";
            this.buttonYM01.UseVisualStyleBackColor = true;
            this.buttonYM01.Click += new System.EventHandler(this.buttonYM01_Click);
            // 
            // buttonYM1
            // 
            this.buttonYM1.Location = new System.Drawing.Point(192, 121);
            this.buttonYM1.Name = "buttonYM1";
            this.buttonYM1.Size = new System.Drawing.Size(24, 23);
            this.buttonYM1.TabIndex = 22;
            this.buttonYM1.Text = "-1";
            this.buttonYM1.UseVisualStyleBackColor = true;
            this.buttonYM1.Click += new System.EventHandler(this.buttonYM1_Click);
            // 
            // buttonYM10
            // 
            this.buttonYM10.Location = new System.Drawing.Point(156, 121);
            this.buttonYM10.Name = "buttonYM10";
            this.buttonYM10.Size = new System.Drawing.Size(30, 23);
            this.buttonYM10.TabIndex = 21;
            this.buttonYM10.Text = "-10";
            this.buttonYM10.UseVisualStyleBackColor = true;
            this.buttonYM10.Click += new System.EventHandler(this.buttonYM10_Click);
            // 
            // buttonYM100
            // 
            this.buttonYM100.Location = new System.Drawing.Point(114, 121);
            this.buttonYM100.Name = "buttonYM100";
            this.buttonYM100.Size = new System.Drawing.Size(36, 23);
            this.buttonYM100.TabIndex = 20;
            this.buttonYM100.Text = "-100";
            this.buttonYM100.UseVisualStyleBackColor = true;
            this.buttonYM100.Click += new System.EventHandler(this.buttonYM100_Click);
            // 
            // buttonHomeY
            // 
            this.buttonHomeY.Location = new System.Drawing.Point(63, 121);
            this.buttonHomeY.Name = "buttonHomeY";
            this.buttonHomeY.Size = new System.Drawing.Size(45, 23);
            this.buttonHomeY.TabIndex = 19;
            this.buttonHomeY.Text = "Home";
            this.buttonHomeY.UseVisualStyleBackColor = true;
            this.buttonHomeY.Click += new System.EventHandler(this.buttonHomeY_Click);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(4, 126);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(35, 13);
            this.labelY.TabIndex = 20;
            this.labelY.Text = "Y=0.0";
            // 
            // buttonZP100
            // 
            this.buttonZP100.Location = new System.Drawing.Point(382, 150);
            this.buttonZP100.Name = "buttonZP100";
            this.buttonZP100.Size = new System.Drawing.Size(43, 23);
            this.buttonZP100.TabIndex = 36;
            this.buttonZP100.Text = "+100";
            this.buttonZP100.UseVisualStyleBackColor = true;
            this.buttonZP100.Click += new System.EventHandler(this.buttonZP100_Click);
            // 
            // buttonZP10
            // 
            this.buttonZP10.Location = new System.Drawing.Point(340, 150);
            this.buttonZP10.Name = "buttonZP10";
            this.buttonZP10.Size = new System.Drawing.Size(36, 23);
            this.buttonZP10.TabIndex = 35;
            this.buttonZP10.Text = "+10";
            this.buttonZP10.UseVisualStyleBackColor = true;
            this.buttonZP10.Click += new System.EventHandler(this.buttonZP10_Click);
            // 
            // buttonZP1
            // 
            this.buttonZP1.Location = new System.Drawing.Point(306, 150);
            this.buttonZP1.Name = "buttonZP1";
            this.buttonZP1.Size = new System.Drawing.Size(28, 23);
            this.buttonZP1.TabIndex = 34;
            this.buttonZP1.Text = "+1";
            this.buttonZP1.UseVisualStyleBackColor = true;
            this.buttonZP1.Click += new System.EventHandler(this.buttonZP1_Click);
            // 
            // buttonZP01
            // 
            this.buttonZP01.Location = new System.Drawing.Point(264, 150);
            this.buttonZP01.Name = "buttonZP01";
            this.buttonZP01.Size = new System.Drawing.Size(36, 23);
            this.buttonZP01.TabIndex = 33;
            this.buttonZP01.Text = "+0.1";
            this.buttonZP01.UseVisualStyleBackColor = true;
            this.buttonZP01.Click += new System.EventHandler(this.buttonZP01_Click);
            // 
            // buttonZM01
            // 
            this.buttonZM01.Location = new System.Drawing.Point(222, 150);
            this.buttonZM01.Name = "buttonZM01";
            this.buttonZM01.Size = new System.Drawing.Size(36, 23);
            this.buttonZM01.TabIndex = 32;
            this.buttonZM01.Text = "-0.1";
            this.buttonZM01.UseVisualStyleBackColor = true;
            this.buttonZM01.Click += new System.EventHandler(this.buttonZM01_Click);
            // 
            // buttonZM1
            // 
            this.buttonZM1.Location = new System.Drawing.Point(192, 150);
            this.buttonZM1.Name = "buttonZM1";
            this.buttonZM1.Size = new System.Drawing.Size(24, 23);
            this.buttonZM1.TabIndex = 31;
            this.buttonZM1.Text = "-1";
            this.buttonZM1.UseVisualStyleBackColor = true;
            this.buttonZM1.Click += new System.EventHandler(this.buttonZM1_Click);
            // 
            // buttonZM10
            // 
            this.buttonZM10.Location = new System.Drawing.Point(156, 150);
            this.buttonZM10.Name = "buttonZM10";
            this.buttonZM10.Size = new System.Drawing.Size(30, 23);
            this.buttonZM10.TabIndex = 30;
            this.buttonZM10.Text = "-10";
            this.buttonZM10.UseVisualStyleBackColor = true;
            this.buttonZM10.Click += new System.EventHandler(this.buttonZM10_Click);
            // 
            // buttonZM100
            // 
            this.buttonZM100.Location = new System.Drawing.Point(114, 150);
            this.buttonZM100.Name = "buttonZM100";
            this.buttonZM100.Size = new System.Drawing.Size(36, 23);
            this.buttonZM100.TabIndex = 29;
            this.buttonZM100.Text = "-100";
            this.buttonZM100.UseVisualStyleBackColor = true;
            this.buttonZM100.Click += new System.EventHandler(this.buttonZM100_Click);
            // 
            // buttonHomeZ
            // 
            this.buttonHomeZ.Location = new System.Drawing.Point(63, 150);
            this.buttonHomeZ.Name = "buttonHomeZ";
            this.buttonHomeZ.Size = new System.Drawing.Size(45, 23);
            this.buttonHomeZ.TabIndex = 28;
            this.buttonHomeZ.Text = "Home";
            this.buttonHomeZ.UseVisualStyleBackColor = true;
            this.buttonHomeZ.Click += new System.EventHandler(this.buttonHomeZ_Click);
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(4, 155);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(35, 13);
            this.labelZ.TabIndex = 30;
            this.labelZ.Text = "Z=0.0";
            // 
            // buttonHomeAll
            // 
            this.buttonHomeAll.Location = new System.Drawing.Point(7, 179);
            this.buttonHomeAll.Name = "buttonHomeAll";
            this.buttonHomeAll.Size = new System.Drawing.Size(75, 23);
            this.buttonHomeAll.TabIndex = 37;
            this.buttonHomeAll.Text = "Home all";
            this.buttonHomeAll.UseVisualStyleBackColor = true;
            this.buttonHomeAll.Click += new System.EventHandler(this.buttonHomeAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonExtrude);
            this.groupBox1.Controls.Add(this.switchExtruderReverse);
            this.groupBox1.Controls.Add(this.trackExtruderSpeed);
            this.groupBox1.Controls.Add(this.labelExtruderSpeed);
            this.groupBox1.Controls.Add(this.labelExtruderLength);
            this.groupBox1.Controls.Add(this.trackExtruderLength);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonExtruderSetTemp);
            this.groupBox1.Controls.Add(this.textExtruderSetTemp);
            this.groupBox1.Controls.Add(this.labelExtruderTemp);
            this.groupBox1.Controls.Add(this.switchExtruderHeatOn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 112);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extruder";
            // 
            // buttonExtrude
            // 
            this.buttonExtrude.Location = new System.Drawing.Point(327, 79);
            this.buttonExtrude.Name = "buttonExtrude";
            this.buttonExtrude.Size = new System.Drawing.Size(84, 23);
            this.buttonExtrude.TabIndex = 6;
            this.buttonExtrude.Text = "Extrude";
            this.buttonExtrude.UseVisualStyleBackColor = true;
            this.buttonExtrude.Click += new System.EventHandler(this.buttonExtrude_Click);
            // 
            // trackExtruderSpeed
            // 
            this.trackExtruderSpeed.Location = new System.Drawing.Point(105, 81);
            this.trackExtruderSpeed.Maximum = 1000;
            this.trackExtruderSpeed.Minimum = 10;
            this.trackExtruderSpeed.Name = "trackExtruderSpeed";
            this.trackExtruderSpeed.Size = new System.Drawing.Size(216, 45);
            this.trackExtruderSpeed.TabIndex = 5;
            this.trackExtruderSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackExtruderSpeed.Value = 50;
            this.trackExtruderSpeed.ValueChanged += new System.EventHandler(this.trackExtruderSpeed_ValueChanged);
            // 
            // labelExtruderSpeed
            // 
            this.labelExtruderSpeed.AutoSize = true;
            this.labelExtruderSpeed.Location = new System.Drawing.Point(56, 81);
            this.labelExtruderSpeed.Name = "labelExtruderSpeed";
            this.labelExtruderSpeed.Size = new System.Drawing.Size(19, 13);
            this.labelExtruderSpeed.TabIndex = 9;
            this.labelExtruderSpeed.Text = "50";
            // 
            // labelExtruderLength
            // 
            this.labelExtruderLength.AutoSize = true;
            this.labelExtruderLength.Location = new System.Drawing.Point(53, 50);
            this.labelExtruderLength.Name = "labelExtruderLength";
            this.labelExtruderLength.Size = new System.Drawing.Size(19, 13);
            this.labelExtruderLength.TabIndex = 8;
            this.labelExtruderLength.Text = "10";
            // 
            // trackExtruderLength
            // 
            this.trackExtruderLength.LargeChange = 50;
            this.trackExtruderLength.Location = new System.Drawing.Point(103, 49);
            this.trackExtruderLength.Maximum = 150;
            this.trackExtruderLength.Minimum = 1;
            this.trackExtruderLength.Name = "trackExtruderLength";
            this.trackExtruderLength.Size = new System.Drawing.Size(224, 45);
            this.trackExtruderLength.TabIndex = 3;
            this.trackExtruderLength.TickFrequency = 50;
            this.trackExtruderLength.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackExtruderLength.Value = 10;
            this.trackExtruderLength.ValueChanged += new System.EventHandler(this.trackExtruderLength_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Length";
            // 
            // buttonExtruderSetTemp
            // 
            this.buttonExtruderSetTemp.Location = new System.Drawing.Point(336, 20);
            this.buttonExtruderSetTemp.Name = "buttonExtruderSetTemp";
            this.buttonExtruderSetTemp.Size = new System.Drawing.Size(75, 23);
            this.buttonExtruderSetTemp.TabIndex = 2;
            this.buttonExtruderSetTemp.Text = "Set temp";
            this.buttonExtruderSetTemp.UseVisualStyleBackColor = true;
            this.buttonExtruderSetTemp.Click += new System.EventHandler(this.buttonExtruderSetTemp_Click);
            // 
            // textExtruderSetTemp
            // 
            this.textExtruderSetTemp.Location = new System.Drawing.Point(245, 23);
            this.textExtruderSetTemp.Name = "textExtruderSetTemp";
            this.textExtruderSetTemp.Size = new System.Drawing.Size(82, 20);
            this.textExtruderSetTemp.TabIndex = 1;
            this.textExtruderSetTemp.Text = "200";
            // 
            // labelExtruderTemp
            // 
            this.labelExtruderTemp.AutoSize = true;
            this.labelExtruderTemp.Location = new System.Drawing.Point(185, 26);
            this.labelExtruderTemp.Name = "labelExtruderTemp";
            this.labelExtruderTemp.Size = new System.Drawing.Size(36, 13);
            this.labelExtruderTemp.TabIndex = 2;
            this.labelExtruderTemp.Text = "200°C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Temperature";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonPrintbedSendTemp);
            this.groupBox2.Controls.Add(this.textPrintbedTemp);
            this.groupBox2.Controls.Add(this.labelPrintbedTemp);
            this.groupBox2.Controls.Add(this.switchBedHeat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(8, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 55);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Printbed";
            // 
            // buttonPrintbedSendTemp
            // 
            this.buttonPrintbedSendTemp.Location = new System.Drawing.Point(335, 19);
            this.buttonPrintbedSendTemp.Name = "buttonPrintbedSendTemp";
            this.buttonPrintbedSendTemp.Size = new System.Drawing.Size(75, 23);
            this.buttonPrintbedSendTemp.TabIndex = 2;
            this.buttonPrintbedSendTemp.Text = "Set temp";
            this.buttonPrintbedSendTemp.UseVisualStyleBackColor = true;
            this.buttonPrintbedSendTemp.Click += new System.EventHandler(this.buttonPrintbedSendTemp_Click);
            // 
            // textPrintbedTemp
            // 
            this.textPrintbedTemp.Location = new System.Drawing.Point(244, 22);
            this.textPrintbedTemp.Name = "textPrintbedTemp";
            this.textPrintbedTemp.Size = new System.Drawing.Size(82, 20);
            this.textPrintbedTemp.TabIndex = 1;
            this.textPrintbedTemp.Text = "55";
            // 
            // labelPrintbedTemp
            // 
            this.labelPrintbedTemp.AutoSize = true;
            this.labelPrintbedTemp.Location = new System.Drawing.Point(184, 25);
            this.labelPrintbedTemp.Name = "labelPrintbedTemp";
            this.labelPrintbedTemp.Size = new System.Drawing.Size(36, 13);
            this.labelPrintbedTemp.TabIndex = 7;
            this.labelPrintbedTemp.Text = "200°C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Temperature";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelVoltage);
            this.groupBox3.Controls.Add(this.trackFanVoltage);
            this.groupBox3.Controls.Add(this.switchFanOn);
            this.groupBox3.Location = new System.Drawing.Point(10, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 62);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fan";
            // 
            // labelVoltage
            // 
            this.labelVoltage.AutoSize = true;
            this.labelVoltage.Location = new System.Drawing.Point(110, 16);
            this.labelVoltage.Name = "labelVoltage";
            this.labelVoltage.Size = new System.Drawing.Size(43, 13);
            this.labelVoltage.TabIndex = 2;
            this.labelVoltage.Text = "Voltage";
            // 
            // trackFanVoltage
            // 
            this.trackFanVoltage.LargeChange = 11;
            this.trackFanVoltage.Location = new System.Drawing.Point(109, 32);
            this.trackFanVoltage.Maximum = 255;
            this.trackFanVoltage.Name = "trackFanVoltage";
            this.trackFanVoltage.Size = new System.Drawing.Size(270, 45);
            this.trackFanVoltage.TabIndex = 1;
            this.trackFanVoltage.TickFrequency = 21;
            this.trackFanVoltage.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackFanVoltage.Value = 106;
            this.trackFanVoltage.ValueChanged += new System.EventHandler(this.trackFanVoltage_ValueChanged);
            // 
            // buttonGoDisposeArea
            // 
            this.buttonGoDisposeArea.Location = new System.Drawing.Point(88, 179);
            this.buttonGoDisposeArea.Name = "buttonGoDisposeArea";
            this.buttonGoDisposeArea.Size = new System.Drawing.Size(75, 23);
            this.buttonGoDisposeArea.TabIndex = 38;
            this.buttonGoDisposeArea.Text = "Go dispose";
            this.buttonGoDisposeArea.UseVisualStyleBackColor = true;
            this.buttonGoDisposeArea.Click += new System.EventHandler(this.buttonGoDisposeArea_Click);
            // 
            // buttonSimulateOK
            // 
            this.buttonSimulateOK.Location = new System.Drawing.Point(217, 4);
            this.buttonSimulateOK.Name = "buttonSimulateOK";
            this.buttonSimulateOK.Size = new System.Drawing.Size(100, 23);
            this.buttonSimulateOK.TabIndex = 2;
            this.buttonSimulateOK.Text = "Simulate OK";
            this.buttonSimulateOK.UseVisualStyleBackColor = true;
            this.buttonSimulateOK.Click += new System.EventHandler(this.buttonSimulateOK_Click);
            // 
            // switchFanOn
            // 
            this.switchFanOn.Location = new System.Drawing.Point(6, 19);
            this.switchFanOn.Name = "switchFanOn";
            this.switchFanOn.On = false;
            this.switchFanOn.Size = new System.Drawing.Size(97, 23);
            this.switchFanOn.TabIndex = 0;
            this.switchFanOn.TextOff = "Fan on";
            this.switchFanOn.TextOn = "Fan on";
            this.switchFanOn.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchFanOn_Change);
            // 
            // switchBedHeat
            // 
            this.switchBedHeat.Location = new System.Drawing.Point(6, 19);
            this.switchBedHeat.Name = "switchBedHeat";
            this.switchBedHeat.On = false;
            this.switchBedHeat.Size = new System.Drawing.Size(100, 23);
            this.switchBedHeat.TabIndex = 0;
            this.switchBedHeat.TextOff = "Heat on";
            this.switchBedHeat.TextOn = "Heat on";
            this.switchBedHeat.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchBedHeat_Change);
            // 
            // switchExtruderReverse
            // 
            this.switchExtruderReverse.Location = new System.Drawing.Point(327, 50);
            this.switchExtruderReverse.Name = "switchExtruderReverse";
            this.switchExtruderReverse.On = false;
            this.switchExtruderReverse.Size = new System.Drawing.Size(84, 23);
            this.switchExtruderReverse.TabIndex = 4;
            this.switchExtruderReverse.TextOff = "Reverse";
            this.switchExtruderReverse.TextOn = "Reverse";
            // 
            // switchExtruderHeatOn
            // 
            this.switchExtruderHeatOn.Location = new System.Drawing.Point(7, 20);
            this.switchExtruderHeatOn.Name = "switchExtruderHeatOn";
            this.switchExtruderHeatOn.On = false;
            this.switchExtruderHeatOn.Size = new System.Drawing.Size(100, 23);
            this.switchExtruderHeatOn.TabIndex = 0;
            this.switchExtruderHeatOn.TextOff = "Heat on";
            this.switchExtruderHeatOn.TextOn = "Heat on";
            this.switchExtruderHeatOn.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchExtruderHeatOn_Change);
            // 
            // switchDryRun
            // 
            this.switchDryRun.Location = new System.Drawing.Point(324, 34);
            this.switchDryRun.Name = "switchDryRun";
            this.switchDryRun.On = false;
            this.switchDryRun.Size = new System.Drawing.Size(100, 23);
            this.switchDryRun.TabIndex = 7;
            this.switchDryRun.TextOff = "Dry run";
            this.switchDryRun.TextOn = "Dry run";
            this.switchDryRun.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchDryRun_Change);
            // 
            // switchErrors
            // 
            this.switchErrors.Location = new System.Drawing.Point(217, 34);
            this.switchErrors.Name = "switchErrors";
            this.switchErrors.On = true;
            this.switchErrors.Size = new System.Drawing.Size(100, 23);
            this.switchErrors.TabIndex = 6;
            this.switchErrors.TextOff = "Errors";
            this.switchErrors.TextOn = "Errors";
            this.switchErrors.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchErrors_Change);
            // 
            // switchInfo
            // 
            this.switchInfo.Location = new System.Drawing.Point(110, 33);
            this.switchInfo.Name = "switchInfo";
            this.switchInfo.On = true;
            this.switchInfo.Size = new System.Drawing.Size(100, 23);
            this.switchInfo.TabIndex = 5;
            this.switchInfo.TextOff = "Info";
            this.switchInfo.TextOn = "Info";
            this.switchInfo.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchInfo_Change);
            // 
            // switchEcho
            // 
            this.switchEcho.Location = new System.Drawing.Point(4, 33);
            this.switchEcho.Name = "switchEcho";
            this.switchEcho.On = false;
            this.switchEcho.Size = new System.Drawing.Size(100, 23);
            this.switchEcho.TabIndex = 4;
            this.switchEcho.TextOff = "Echo";
            this.switchEcho.TextOn = "Echo";
            this.switchEcho.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchEcho_Change);
            // 
            // switchPower
            // 
            this.switchPower.Location = new System.Drawing.Point(110, 3);
            this.switchPower.Name = "switchPower";
            this.switchPower.On = false;
            this.switchPower.Size = new System.Drawing.Size(100, 23);
            this.switchPower.TabIndex = 1;
            this.switchPower.TextOff = "Power on";
            this.switchPower.TextOn = "Power off";
            this.switchPower.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchPower_Change);
            // 
            // switchConnect
            // 
            this.switchConnect.Location = new System.Drawing.Point(3, 3);
            this.switchConnect.Name = "switchConnect";
            this.switchConnect.On = false;
            this.switchConnect.Size = new System.Drawing.Size(100, 23);
            this.switchConnect.TabIndex = 0;
            this.switchConnect.TextOff = "Connect";
            this.switchConnect.TextOn = "Disconnect";
            this.switchConnect.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchConnect_Changed);
            // 
            // PrintPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.buttonSimulateOK);
            this.Controls.Add(this.buttonGoDisposeArea);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonHomeAll);
            this.Controls.Add(this.buttonZP100);
            this.Controls.Add(this.buttonZP10);
            this.Controls.Add(this.buttonZP1);
            this.Controls.Add(this.buttonZP01);
            this.Controls.Add(this.buttonZM01);
            this.Controls.Add(this.buttonZM1);
            this.Controls.Add(this.buttonZM10);
            this.Controls.Add(this.buttonZM100);
            this.Controls.Add(this.buttonHomeZ);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.buttonYP100);
            this.Controls.Add(this.buttonYP10);
            this.Controls.Add(this.buttonYP1);
            this.Controls.Add(this.buttonYP01);
            this.Controls.Add(this.buttonYM01);
            this.Controls.Add(this.buttonYM1);
            this.Controls.Add(this.buttonYM10);
            this.Controls.Add(this.buttonYM100);
            this.Controls.Add(this.buttonHomeY);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.buttonXP100);
            this.Controls.Add(this.buttonXP10);
            this.Controls.Add(this.buttonXP1);
            this.Controls.Add(this.buttonXP01);
            this.Controls.Add(this.buttonXM01);
            this.Controls.Add(this.buttonXM1);
            this.Controls.Add(this.buttonXM10);
            this.Controls.Add(this.buttonXM100);
            this.Controls.Add(this.buttonHomeX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textGCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.switchDryRun);
            this.Controls.Add(this.switchErrors);
            this.Controls.Add(this.switchInfo);
            this.Controls.Add(this.switchEcho);
            this.Controls.Add(this.buttonJobStatus);
            this.Controls.Add(this.switchPower);
            this.Controls.Add(this.switchConnect);
            this.Name = "PrintPanel";
            this.Size = new System.Drawing.Size(430, 464);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackExtruderSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackExtruderLength)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackFanVoltage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SwitchButton switchConnect;
        private SwitchButton switchPower;
        private System.Windows.Forms.Button buttonJobStatus;
        private SwitchButton switchEcho;
        private SwitchButton switchInfo;
        private SwitchButton switchErrors;
        private SwitchButton switchDryRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textGCode;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Button buttonHomeX;
        private System.Windows.Forms.Button buttonXM100;
        private System.Windows.Forms.Button buttonXM10;
        private System.Windows.Forms.Button buttonXM1;
        private System.Windows.Forms.Button buttonXM01;
        private System.Windows.Forms.Button buttonXP01;
        private System.Windows.Forms.Button buttonXP1;
        private System.Windows.Forms.Button buttonXP10;
        private System.Windows.Forms.Button buttonXP100;
        private System.Windows.Forms.Button buttonYP100;
        private System.Windows.Forms.Button buttonYP10;
        private System.Windows.Forms.Button buttonYP1;
        private System.Windows.Forms.Button buttonYP01;
        private System.Windows.Forms.Button buttonYM01;
        private System.Windows.Forms.Button buttonYM1;
        private System.Windows.Forms.Button buttonYM10;
        private System.Windows.Forms.Button buttonYM100;
        private System.Windows.Forms.Button buttonHomeY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button buttonZP100;
        private System.Windows.Forms.Button buttonZP10;
        private System.Windows.Forms.Button buttonZP1;
        private System.Windows.Forms.Button buttonZP01;
        private System.Windows.Forms.Button buttonZM01;
        private System.Windows.Forms.Button buttonZM1;
        private System.Windows.Forms.Button buttonZM10;
        private System.Windows.Forms.Button buttonZM100;
        private System.Windows.Forms.Button buttonHomeZ;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Button buttonHomeAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelExtruderTemp;
        private SwitchButton switchExtruderHeatOn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExtruderSetTemp;
        private System.Windows.Forms.TextBox textExtruderSetTemp;
        private System.Windows.Forms.Label labelExtruderLength;
        private System.Windows.Forms.TrackBar trackExtruderLength;
        private System.Windows.Forms.Button buttonExtrude;
        private SwitchButton switchExtruderReverse;
        private System.Windows.Forms.TrackBar trackExtruderSpeed;
        private System.Windows.Forms.Label labelExtruderSpeed;
        private System.Windows.Forms.Button buttonPrintbedSendTemp;
        private System.Windows.Forms.TextBox textPrintbedTemp;
        private System.Windows.Forms.Label labelPrintbedTemp;
        private SwitchButton switchBedHeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelVoltage;
        private System.Windows.Forms.TrackBar trackFanVoltage;
        private SwitchButton switchFanOn;
        private System.Windows.Forms.Button buttonGoDisposeArea;
        private System.Windows.Forms.Button buttonSimulateOK;
    }
}
