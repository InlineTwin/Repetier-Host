namespace RepetierHost.view
{
    partial class GlobalSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textWorkdir = new System.Windows.Forms.TextBox();
            this.buttonSearchWorkdir = new System.Windows.Forms.Button();
            this.checkLogfile = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkLogfile);
            this.groupBox1.Controls.Add(this.buttonSearchWorkdir);
            this.groupBox1.Controls.Add(this.textWorkdir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files and directories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work directory:";
            // 
            // textWorkdir
            // 
            this.textWorkdir.Location = new System.Drawing.Point(93, 20);
            this.textWorkdir.Name = "textWorkdir";
            this.textWorkdir.Size = new System.Drawing.Size(307, 20);
            this.textWorkdir.TabIndex = 0;
            // 
            // buttonSearchWorkdir
            // 
            this.buttonSearchWorkdir.Location = new System.Drawing.Point(406, 20);
            this.buttonSearchWorkdir.Name = "buttonSearchWorkdir";
            this.buttonSearchWorkdir.Size = new System.Drawing.Size(58, 23);
            this.buttonSearchWorkdir.TabIndex = 1;
            this.buttonSearchWorkdir.Text = "Search";
            this.buttonSearchWorkdir.UseVisualStyleBackColor = true;
            this.buttonSearchWorkdir.Click += new System.EventHandler(this.buttonSearchWorkdir_Click);
            // 
            // checkLogfile
            // 
            this.checkLogfile.AutoSize = true;
            this.checkLogfile.Location = new System.Drawing.Point(10, 52);
            this.checkLogfile.Name = "checkLogfile";
            this.checkLogfile.Size = new System.Drawing.Size(82, 17);
            this.checkLogfile.TabIndex = 2;
            this.checkLogfile.Text = "Log session";
            this.checkLogfile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(326, 164);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(407, 164);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(75, 23);
            this.buttonAbort.TabIndex = 1;
            this.buttonAbort.Text = "Abort";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // folderBrowser
            // 
            this.folderBrowser.Description = "Select working directory";
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // GlobalSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 200);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GlobalSettings";
            this.Text = "Repetier settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkLogfile;
        private System.Windows.Forms.Button buttonSearchWorkdir;
        private System.Windows.Forms.TextBox textWorkdir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;

    }
}