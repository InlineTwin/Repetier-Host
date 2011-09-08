namespace RepetierHost.view
{
    partial class PrinterInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrinterInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFirmwareURL = new System.Windows.Forms.LinkLabel();
            this.labelNumExtruder = new System.Windows.Forms.Label();
            this.labelProtocol = new System.Windows.Forms.Label();
            this.labelFirmware = new System.Windows.Forms.Label();
            this.labelMachine = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelErrorsReceived = new System.Windows.Forms.Label();
            this.labelBytesSend = new System.Windows.Forms.Label();
            this.labelLinesSend = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFirmwareURL);
            this.groupBox1.Controls.Add(this.labelNumExtruder);
            this.groupBox1.Controls.Add(this.labelProtocol);
            this.groupBox1.Controls.Add(this.labelFirmware);
            this.groupBox1.Controls.Add(this.labelMachine);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Printer data";
            // 
            // labelFirmwareURL
            // 
            this.labelFirmwareURL.AutoSize = true;
            this.labelFirmwareURL.Location = new System.Drawing.Point(121, 64);
            this.labelFirmwareURL.Name = "labelFirmwareURL";
            this.labelFirmwareURL.Size = new System.Drawing.Size(55, 13);
            this.labelFirmwareURL.TabIndex = 6;
            this.labelFirmwareURL.TabStop = true;
            this.labelFirmwareURL.Text = "linkLabel1";
            // 
            // labelNumExtruder
            // 
            this.labelNumExtruder.AutoSize = true;
            this.labelNumExtruder.Location = new System.Drawing.Point(118, 111);
            this.labelNumExtruder.Name = "labelNumExtruder";
            this.labelNumExtruder.Size = new System.Drawing.Size(35, 13);
            this.labelNumExtruder.TabIndex = 5;
            this.labelNumExtruder.Text = "label9";
            // 
            // labelProtocol
            // 
            this.labelProtocol.AutoSize = true;
            this.labelProtocol.Location = new System.Drawing.Point(118, 87);
            this.labelProtocol.Name = "labelProtocol";
            this.labelProtocol.Size = new System.Drawing.Size(35, 13);
            this.labelProtocol.TabIndex = 5;
            this.labelProtocol.Text = "label9";
            // 
            // labelFirmware
            // 
            this.labelFirmware.AutoSize = true;
            this.labelFirmware.Location = new System.Drawing.Point(118, 41);
            this.labelFirmware.Name = "labelFirmware";
            this.labelFirmware.Size = new System.Drawing.Size(35, 13);
            this.labelFirmware.TabIndex = 5;
            this.labelFirmware.Text = "label9";
            // 
            // labelMachine
            // 
            this.labelMachine.AutoSize = true;
            this.labelMachine.Location = new System.Drawing.Point(118, 20);
            this.labelMachine.Name = "labelMachine";
            this.labelMachine.Size = new System.Drawing.Size(35, 13);
            this.labelMachine.TabIndex = 5;
            this.labelMachine.Text = "label9";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number extruder:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Protocol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Firmware URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firmware:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Machine type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelErrorsReceived);
            this.groupBox2.Controls.Add(this.labelBytesSend);
            this.groupBox2.Controls.Add(this.labelLinesSend);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection information";
            // 
            // labelErrorsReceived
            // 
            this.labelErrorsReceived.AutoSize = true;
            this.labelErrorsReceived.Location = new System.Drawing.Point(118, 65);
            this.labelErrorsReceived.Name = "labelErrorsReceived";
            this.labelErrorsReceived.Size = new System.Drawing.Size(35, 13);
            this.labelErrorsReceived.TabIndex = 5;
            this.labelErrorsReceived.Text = "label9";
            // 
            // labelBytesSend
            // 
            this.labelBytesSend.AutoSize = true;
            this.labelBytesSend.Location = new System.Drawing.Point(118, 43);
            this.labelBytesSend.Name = "labelBytesSend";
            this.labelBytesSend.Size = new System.Drawing.Size(35, 13);
            this.labelBytesSend.TabIndex = 5;
            this.labelBytesSend.Text = "label9";
            // 
            // labelLinesSend
            // 
            this.labelLinesSend.AutoSize = true;
            this.labelLinesSend.Location = new System.Drawing.Point(118, 20);
            this.labelLinesSend.Name = "labelLinesSend";
            this.labelLinesSend.Size = new System.Drawing.Size(35, 13);
            this.labelLinesSend.TabIndex = 5;
            this.labelLinesSend.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Bytes send:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Errors received:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lines send:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(374, 275);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PrinterInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 317);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrinterInfo";
            this.Text = "Printer information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelNumExtruder;
        private System.Windows.Forms.Label labelProtocol;
        private System.Windows.Forms.Label labelFirmware;
        private System.Windows.Forms.Label labelMachine;
        private System.Windows.Forms.Label labelLinesSend;
        private System.Windows.Forms.Label labelBytesSend;
        private System.Windows.Forms.Label labelErrorsReceived;
        private System.Windows.Forms.LinkLabel labelFirmwareURL;
    }
}