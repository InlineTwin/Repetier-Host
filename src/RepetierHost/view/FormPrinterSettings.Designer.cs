namespace RepetierHost.view
{
    partial class FormPrinterSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrinterSettings));
            this.panelPrinterSelect = new System.Windows.Forms.Panel();
            this.comboPrinter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.checkPingPong = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textReceiveCacheSize = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboTransferProtocol = new System.Windows.Forms.ComboBox();
            this.comboParity = new System.Windows.Forms.ComboBox();
            this.comboStopbits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBaud = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPagePrinter = new System.Windows.Forms.TabPage();
            this.checkDisbaleHeatedBedAfterJob = new System.Windows.Forms.CheckBox();
            this.checkDisableExtruderAfterJob = new System.Windows.Forms.CheckBox();
            this.checkGoDisposeAfterJob = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textDisposeY = new System.Windows.Forms.TextBox();
            this.textDisposeX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelCheckInterval = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trackTempPeriod = new System.Windows.Forms.TrackBar();
            this.checkTemp = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textZFeedrate = new System.Windows.Forms.TextBox();
            this.textTravelFeedrate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageShape = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.checkHasDumpArea = new System.Windows.Forms.CheckBox();
            this.textPrintAreaHeight = new System.Windows.Forms.TextBox();
            this.textDumpAreaDepth = new System.Windows.Forms.TextBox();
            this.textDumpAreaWidth = new System.Windows.Forms.TextBox();
            this.textDumpAreaFront = new System.Windows.Forms.TextBox();
            this.textDumpAreaLeft = new System.Windows.Forms.TextBox();
            this.textPrintAreaDepth = new System.Windows.Forms.TextBox();
            this.textPrintAreaWidth = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelPrinterSelect.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.tabPagePrinter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackTempPeriod)).BeginInit();
            this.tabPageShape.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrinterSelect
            // 
            this.panelPrinterSelect.Controls.Add(this.comboPrinter);
            this.panelPrinterSelect.Controls.Add(this.label1);
            this.panelPrinterSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrinterSelect.Location = new System.Drawing.Point(0, 0);
            this.panelPrinterSelect.Name = "panelPrinterSelect";
            this.panelPrinterSelect.Size = new System.Drawing.Size(458, 30);
            this.panelPrinterSelect.TabIndex = 0;
            // 
            // comboPrinter
            // 
            this.comboPrinter.FormattingEnabled = true;
            this.comboPrinter.Location = new System.Drawing.Point(47, 3);
            this.comboPrinter.Name = "comboPrinter";
            this.comboPrinter.Size = new System.Drawing.Size(399, 21);
            this.comboPrinter.TabIndex = 0;
            this.comboPrinter.SelectedIndexChanged += new System.EventHandler(this.comboPrinter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Printer";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageConnection);
            this.tabControl1.Controls.Add(this.tabPagePrinter);
            this.tabControl1.Controls.Add(this.tabPageShape);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.checkPingPong);
            this.tabPageConnection.Controls.Add(this.label17);
            this.tabPageConnection.Controls.Add(this.textReceiveCacheSize);
            this.tabPageConnection.Controls.Add(this.label16);
            this.tabPageConnection.Controls.Add(this.buttonDelete);
            this.tabPageConnection.Controls.Add(this.label6);
            this.tabPageConnection.Controls.Add(this.comboTransferProtocol);
            this.tabPageConnection.Controls.Add(this.comboParity);
            this.tabPageConnection.Controls.Add(this.comboStopbits);
            this.tabPageConnection.Controls.Add(this.label5);
            this.tabPageConnection.Controls.Add(this.label4);
            this.tabPageConnection.Controls.Add(this.comboBaud);
            this.tabPageConnection.Controls.Add(this.label3);
            this.tabPageConnection.Controls.Add(this.comboPort);
            this.tabPageConnection.Controls.Add(this.label2);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(450, 396);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // checkPingPong
            // 
            this.checkPingPong.AutoSize = true;
            this.checkPingPong.Location = new System.Drawing.Point(15, 177);
            this.checkPingPong.Name = "checkPingPong";
            this.checkPingPong.Size = new System.Drawing.Size(264, 17);
            this.checkPingPong.TabIndex = 14;
            this.checkPingPong.Text = "Use Ping-Pong communication (send only after ok)";
            this.checkPingPong.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Receive cache size:";
            // 
            // textReceiveCacheSize
            // 
            this.textReceiveCacheSize.Location = new System.Drawing.Point(129, 147);
            this.textReceiveCacheSize.Name = "textReceiveCacheSize";
            this.textReceiveCacheSize.Size = new System.Drawing.Size(100, 20);
            this.textReceiveCacheSize.TabIndex = 5;
            this.textReceiveCacheSize.Text = "120";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 222);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(371, 52);
            this.label16.TabIndex = 11;
            this.label16.Text = resources.GetString("label16.Text");
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(256, 310);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(169, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete this printer settings";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Transfer protocol";
            // 
            // comboTransferProtocol
            // 
            this.comboTransferProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTransferProtocol.FormattingEnabled = true;
            this.comboTransferProtocol.Items.AddRange(new object[] {
            "Autodetect",
            "ASCII",
            "Repetier protocol"});
            this.comboTransferProtocol.Location = new System.Drawing.Point(129, 119);
            this.comboTransferProtocol.Name = "comboTransferProtocol";
            this.comboTransferProtocol.Size = new System.Drawing.Size(121, 21);
            this.comboTransferProtocol.TabIndex = 4;
            // 
            // comboParity
            // 
            this.comboParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboParity.FormattingEnabled = true;
            this.comboParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.comboParity.Location = new System.Drawing.Point(129, 91);
            this.comboParity.Name = "comboParity";
            this.comboParity.Size = new System.Drawing.Size(121, 21);
            this.comboParity.TabIndex = 3;
            // 
            // comboStopbits
            // 
            this.comboStopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStopbits.FormattingEnabled = true;
            this.comboStopbits.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboStopbits.Location = new System.Drawing.Point(129, 63);
            this.comboStopbits.Name = "comboStopbits";
            this.comboStopbits.Size = new System.Drawing.Size(121, 21);
            this.comboStopbits.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stopbits:";
            // 
            // comboBaud
            // 
            this.comboBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBaud.FormattingEnabled = true;
            this.comboBaud.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "76800",
            "115200",
            "128000",
            "250000",
            "256000"});
            this.comboBaud.Location = new System.Drawing.Point(129, 34);
            this.comboBaud.Name = "comboBaud";
            this.comboBaud.Size = new System.Drawing.Size(121, 21);
            this.comboBaud.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Baud rate:";
            // 
            // comboPort
            // 
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Location = new System.Drawing.Point(129, 7);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(121, 21);
            this.comboPort.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port:";
            // 
            // tabPagePrinter
            // 
            this.tabPagePrinter.Controls.Add(this.checkDisbaleHeatedBedAfterJob);
            this.tabPagePrinter.Controls.Add(this.checkDisableExtruderAfterJob);
            this.tabPagePrinter.Controls.Add(this.checkGoDisposeAfterJob);
            this.tabPagePrinter.Controls.Add(this.label15);
            this.tabPagePrinter.Controls.Add(this.textDisposeY);
            this.tabPagePrinter.Controls.Add(this.textDisposeX);
            this.tabPagePrinter.Controls.Add(this.label14);
            this.tabPagePrinter.Controls.Add(this.label13);
            this.tabPagePrinter.Controls.Add(this.label12);
            this.tabPagePrinter.Controls.Add(this.labelCheckInterval);
            this.tabPagePrinter.Controls.Add(this.label11);
            this.tabPagePrinter.Controls.Add(this.trackTempPeriod);
            this.tabPagePrinter.Controls.Add(this.checkTemp);
            this.tabPagePrinter.Controls.Add(this.label10);
            this.tabPagePrinter.Controls.Add(this.label9);
            this.tabPagePrinter.Controls.Add(this.label8);
            this.tabPagePrinter.Controls.Add(this.textZFeedrate);
            this.tabPagePrinter.Controls.Add(this.textTravelFeedrate);
            this.tabPagePrinter.Controls.Add(this.label7);
            this.tabPagePrinter.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrinter.Name = "tabPagePrinter";
            this.tabPagePrinter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrinter.Size = new System.Drawing.Size(450, 396);
            this.tabPagePrinter.TabIndex = 1;
            this.tabPagePrinter.Text = "Printer";
            this.tabPagePrinter.UseVisualStyleBackColor = true;
            // 
            // checkDisbaleHeatedBedAfterJob
            // 
            this.checkDisbaleHeatedBedAfterJob.AutoSize = true;
            this.checkDisbaleHeatedBedAfterJob.Location = new System.Drawing.Point(15, 194);
            this.checkDisbaleHeatedBedAfterJob.Name = "checkDisbaleHeatedBedAfterJob";
            this.checkDisbaleHeatedBedAfterJob.Size = new System.Drawing.Size(193, 17);
            this.checkDisbaleHeatedBedAfterJob.TabIndex = 7;
            this.checkDisbaleHeatedBedAfterJob.Text = "Disable heated bed after job/job kill";
            this.checkDisbaleHeatedBedAfterJob.UseVisualStyleBackColor = true;
            // 
            // checkDisableExtruderAfterJob
            // 
            this.checkDisableExtruderAfterJob.AutoSize = true;
            this.checkDisableExtruderAfterJob.Checked = true;
            this.checkDisableExtruderAfterJob.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDisableExtruderAfterJob.Location = new System.Drawing.Point(15, 170);
            this.checkDisableExtruderAfterJob.Name = "checkDisableExtruderAfterJob";
            this.checkDisableExtruderAfterJob.Size = new System.Drawing.Size(177, 17);
            this.checkDisableExtruderAfterJob.TabIndex = 6;
            this.checkDisableExtruderAfterJob.Text = "Disable extruder after job/job kill";
            this.checkDisableExtruderAfterJob.UseVisualStyleBackColor = true;
            // 
            // checkGoDisposeAfterJob
            // 
            this.checkGoDisposeAfterJob.AutoSize = true;
            this.checkGoDisposeAfterJob.Checked = true;
            this.checkGoDisposeAfterJob.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkGoDisposeAfterJob.Location = new System.Drawing.Point(15, 146);
            this.checkGoDisposeAfterJob.Name = "checkGoDisposeAfterJob";
            this.checkGoDisposeAfterJob.Size = new System.Drawing.Size(190, 17);
            this.checkGoDisposeAfterJob.TabIndex = 5;
            this.checkGoDisposeAfterJob.Text = "Go to dispose area after job/job kill";
            this.checkGoDisposeAfterJob.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(195, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Y:";
            // 
            // textDisposeY
            // 
            this.textDisposeY.Location = new System.Drawing.Point(218, 119);
            this.textDisposeY.Name = "textDisposeY";
            this.textDisposeY.Size = new System.Drawing.Size(57, 20);
            this.textDisposeY.TabIndex = 14;
            this.textDisposeY.Text = "0";
            this.textDisposeY.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textDisposeX
            // 
            this.textDisposeX.Location = new System.Drawing.Point(129, 119);
            this.textDisposeX.Name = "textDisposeX";
            this.textDisposeX.Size = new System.Drawing.Size(60, 20);
            this.textDisposeX.TabIndex = 4;
            this.textDisposeX.Text = "130";
            this.textDisposeX.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(106, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "X:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Dispose position:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "seconds.";
            // 
            // labelCheckInterval
            // 
            this.labelCheckInterval.AutoSize = true;
            this.labelCheckInterval.Location = new System.Drawing.Point(86, 83);
            this.labelCheckInterval.Name = "labelCheckInterval";
            this.labelCheckInterval.Size = new System.Drawing.Size(13, 13);
            this.labelCheckInterval.TabIndex = 9;
            this.labelCheckInterval.Text = "3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Check every";
            // 
            // trackTempPeriod
            // 
            this.trackTempPeriod.BackColor = System.Drawing.SystemColors.Window;
            this.trackTempPeriod.Location = new System.Drawing.Point(187, 82);
            this.trackTempPeriod.Maximum = 60;
            this.trackTempPeriod.Minimum = 1;
            this.trackTempPeriod.Name = "trackTempPeriod";
            this.trackTempPeriod.Size = new System.Drawing.Size(190, 45);
            this.trackTempPeriod.TabIndex = 3;
            this.trackTempPeriod.TickFrequency = 5;
            this.trackTempPeriod.Value = 3;
            this.trackTempPeriod.ValueChanged += new System.EventHandler(this.trackTempPeriod_ValueChanged);
            // 
            // checkTemp
            // 
            this.checkTemp.AutoSize = true;
            this.checkTemp.Checked = true;
            this.checkTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTemp.Location = new System.Drawing.Point(15, 59);
            this.checkTemp.Name = "checkTemp";
            this.checkTemp.Size = new System.Drawing.Size(199, 17);
            this.checkTemp.TabIndex = 2;
            this.checkTemp.Text = "Check extruder and bed temperature";
            this.checkTemp.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "[mm/min]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "[mm/min]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Z-axis feed rate:";
            // 
            // textZFeedrate
            // 
            this.textZFeedrate.Location = new System.Drawing.Point(101, 33);
            this.textZFeedrate.Name = "textZFeedrate";
            this.textZFeedrate.Size = new System.Drawing.Size(100, 20);
            this.textZFeedrate.TabIndex = 1;
            this.textZFeedrate.Text = "70";
            this.textZFeedrate.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textTravelFeedrate
            // 
            this.textTravelFeedrate.Location = new System.Drawing.Point(101, 7);
            this.textTravelFeedrate.Name = "textTravelFeedrate";
            this.textTravelFeedrate.Size = new System.Drawing.Size(100, 20);
            this.textTravelFeedrate.TabIndex = 0;
            this.textTravelFeedrate.Text = "4800";
            this.textTravelFeedrate.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Travel feed rate:";
            // 
            // tabPageShape
            // 
            this.tabPageShape.Controls.Add(this.label31);
            this.tabPageShape.Controls.Add(this.label30);
            this.tabPageShape.Controls.Add(this.label29);
            this.tabPageShape.Controls.Add(this.label28);
            this.tabPageShape.Controls.Add(this.label27);
            this.tabPageShape.Controls.Add(this.label26);
            this.tabPageShape.Controls.Add(this.label25);
            this.tabPageShape.Controls.Add(this.label24);
            this.tabPageShape.Controls.Add(this.label23);
            this.tabPageShape.Controls.Add(this.label22);
            this.tabPageShape.Controls.Add(this.label21);
            this.tabPageShape.Controls.Add(this.checkHasDumpArea);
            this.tabPageShape.Controls.Add(this.textPrintAreaHeight);
            this.tabPageShape.Controls.Add(this.textDumpAreaDepth);
            this.tabPageShape.Controls.Add(this.textDumpAreaWidth);
            this.tabPageShape.Controls.Add(this.textDumpAreaFront);
            this.tabPageShape.Controls.Add(this.textDumpAreaLeft);
            this.tabPageShape.Controls.Add(this.textPrintAreaDepth);
            this.tabPageShape.Controls.Add(this.textPrintAreaWidth);
            this.tabPageShape.Controls.Add(this.label20);
            this.tabPageShape.Controls.Add(this.label19);
            this.tabPageShape.Controls.Add(this.label18);
            this.tabPageShape.Location = new System.Drawing.Point(4, 22);
            this.tabPageShape.Name = "tabPageShape";
            this.tabPageShape.Size = new System.Drawing.Size(450, 396);
            this.tabPageShape.TabIndex = 2;
            this.tabPageShape.Text = "Printer shape";
            this.tabPageShape.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(240, 198);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(23, 13);
            this.label31.TabIndex = 6;
            this.label31.Text = "mm";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(240, 172);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(23, 13);
            this.label30.TabIndex = 6;
            this.label30.Text = "mm";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(240, 146);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 13);
            this.label29.TabIndex = 6;
            this.label29.Text = "mm";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(240, 120);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(23, 13);
            this.label28.TabIndex = 6;
            this.label28.Text = "mm";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(240, 67);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 13);
            this.label27.TabIndex = 6;
            this.label27.Text = "mm";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(240, 41);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(23, 13);
            this.label26.TabIndex = 6;
            this.label26.Text = "mm";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(240, 15);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(23, 13);
            this.label25.TabIndex = 6;
            this.label25.Text = "mm";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 198);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "Dump area depth:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 172);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 13);
            this.label23.TabIndex = 5;
            this.label23.Text = "Dump area width:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 146);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "Dump area front:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 120);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Dump area left:";
            // 
            // checkHasDumpArea
            // 
            this.checkHasDumpArea.AutoSize = true;
            this.checkHasDumpArea.Checked = true;
            this.checkHasDumpArea.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHasDumpArea.Location = new System.Drawing.Point(11, 94);
            this.checkHasDumpArea.Name = "checkHasDumpArea";
            this.checkHasDumpArea.Size = new System.Drawing.Size(129, 17);
            this.checkHasDumpArea.TabIndex = 3;
            this.checkHasDumpArea.Text = "Printer has dump area";
            this.checkHasDumpArea.UseVisualStyleBackColor = true;
            // 
            // textPrintAreaHeight
            // 
            this.textPrintAreaHeight.Location = new System.Drawing.Point(114, 64);
            this.textPrintAreaHeight.Name = "textPrintAreaHeight";
            this.textPrintAreaHeight.Size = new System.Drawing.Size(100, 20);
            this.textPrintAreaHeight.TabIndex = 2;
            this.textPrintAreaHeight.Text = "100";
            this.textPrintAreaHeight.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textDumpAreaDepth
            // 
            this.textDumpAreaDepth.Location = new System.Drawing.Point(114, 195);
            this.textDumpAreaDepth.Name = "textDumpAreaDepth";
            this.textDumpAreaDepth.Size = new System.Drawing.Size(100, 20);
            this.textDumpAreaDepth.TabIndex = 7;
            this.textDumpAreaDepth.Text = "40";
            this.textDumpAreaDepth.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textDumpAreaWidth
            // 
            this.textDumpAreaWidth.Location = new System.Drawing.Point(114, 169);
            this.textDumpAreaWidth.Name = "textDumpAreaWidth";
            this.textDumpAreaWidth.Size = new System.Drawing.Size(100, 20);
            this.textDumpAreaWidth.TabIndex = 6;
            this.textDumpAreaWidth.Text = "22";
            this.textDumpAreaWidth.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textDumpAreaFront
            // 
            this.textDumpAreaFront.Location = new System.Drawing.Point(114, 143);
            this.textDumpAreaFront.Name = "textDumpAreaFront";
            this.textDumpAreaFront.Size = new System.Drawing.Size(100, 20);
            this.textDumpAreaFront.TabIndex = 5;
            this.textDumpAreaFront.Text = "0";
            this.textDumpAreaFront.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textDumpAreaLeft
            // 
            this.textDumpAreaLeft.Location = new System.Drawing.Point(114, 117);
            this.textDumpAreaLeft.Name = "textDumpAreaLeft";
            this.textDumpAreaLeft.Size = new System.Drawing.Size(100, 20);
            this.textDumpAreaLeft.TabIndex = 4;
            this.textDumpAreaLeft.Text = "125";
            this.textDumpAreaLeft.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textPrintAreaDepth
            // 
            this.textPrintAreaDepth.Location = new System.Drawing.Point(114, 38);
            this.textPrintAreaDepth.Name = "textPrintAreaDepth";
            this.textPrintAreaDepth.Size = new System.Drawing.Size(100, 20);
            this.textPrintAreaDepth.TabIndex = 1;
            this.textPrintAreaDepth.Text = "200";
            this.textPrintAreaDepth.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textPrintAreaWidth
            // 
            this.textPrintAreaWidth.Location = new System.Drawing.Point(114, 12);
            this.textPrintAreaWidth.Name = "textPrintAreaWidth";
            this.textPrintAreaWidth.Size = new System.Drawing.Size(100, 20);
            this.textPrintAreaWidth.TabIndex = 0;
            this.textPrintAreaWidth.Text = "200";
            this.textPrintAreaWidth.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Print area height:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Print area depth:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Print area width:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Controls.Add(this.buttonAbort);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 53);
            this.panel1.TabIndex = 2;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(273, 14);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(354, 14);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(75, 23);
            this.buttonAbort.TabIndex = 2;
            this.buttonAbort.Text = "Abort";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(192, 14);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormPrinterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 452);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelPrinterSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrinterSettings";
            this.ShowIcon = false;
            this.Text = "Printer settings";
            this.Shown += new System.EventHandler(this.FormPrinterSettings_Shown);
            this.panelPrinterSelect.ResumeLayout(false);
            this.panelPrinterSelect.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            this.tabPagePrinter.ResumeLayout(false);
            this.tabPagePrinter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackTempPeriod)).EndInit();
            this.tabPageShape.ResumeLayout(false);
            this.tabPageShape.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrinterSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.TabPage tabPagePrinter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox comboParity;
        private System.Windows.Forms.ComboBox comboStopbits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBaud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboTransferProtocol;
        private System.Windows.Forms.CheckBox checkTemp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textZFeedrate;
        private System.Windows.Forms.TextBox textTravelFeedrate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelCheckInterval;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackTempPeriod;
        private System.Windows.Forms.CheckBox checkGoDisposeAfterJob;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textDisposeY;
        private System.Windows.Forms.TextBox textDisposeX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox checkDisbaleHeatedBedAfterJob;
        private System.Windows.Forms.CheckBox checkDisableExtruderAfterJob;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textReceiveCacheSize;
        private System.Windows.Forms.TabPage tabPageShape;
        private System.Windows.Forms.TextBox textPrintAreaHeight;
        private System.Windows.Forms.TextBox textDumpAreaLeft;
        private System.Windows.Forms.TextBox textPrintAreaDepth;
        private System.Windows.Forms.TextBox textPrintAreaWidth;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox checkHasDumpArea;
        private System.Windows.Forms.TextBox textDumpAreaDepth;
        private System.Windows.Forms.TextBox textDumpAreaWidth;
        private System.Windows.Forms.TextBox textDumpAreaFront;
        private System.Windows.Forms.CheckBox checkPingPong;
        public System.Windows.Forms.ComboBox comboPrinter;
    }
}