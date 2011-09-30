namespace RepetierHost.view
{
    partial class Skeinforge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skeinforge));
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textSkainforge = new System.Windows.Forms.TextBox();
            this.buttonSerach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textExtension = new System.Windows.Forms.TextBox();
            this.textPostfix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.textPython = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSerachPy = new System.Windows.Forms.Button();
            this.openPython = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.textSkeinforgeCraft = new System.Windows.Forms.TextBox();
            this.buttonSearchCraft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Filter = "Python|*.py|All files|*.*";
            this.openFile.Title = "Skeinforge application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skeinforge application:";
            // 
            // textSkainforge
            // 
            this.textSkainforge.Location = new System.Drawing.Point(135, 13);
            this.textSkainforge.Name = "textSkainforge";
            this.textSkainforge.Size = new System.Drawing.Size(376, 20);
            this.textSkainforge.TabIndex = 1;
            // 
            // buttonSerach
            // 
            this.buttonSerach.Location = new System.Drawing.Point(518, 13);
            this.buttonSerach.Name = "buttonSerach";
            this.buttonSerach.Size = new System.Drawing.Size(75, 23);
            this.buttonSerach.TabIndex = 2;
            this.buttonSerach.Text = "Browse ...";
            this.buttonSerach.UseVisualStyleBackColor = true;
            this.buttonSerach.Click += new System.EventHandler(this.buttonSerach_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "GCode extension:";
            // 
            // textExtension
            // 
            this.textExtension.Location = new System.Drawing.Point(135, 65);
            this.textExtension.Name = "textExtension";
            this.textExtension.Size = new System.Drawing.Size(100, 20);
            this.textExtension.TabIndex = 4;
            this.textExtension.Text = ".gcode";
            // 
            // textPostfix
            // 
            this.textPostfix.Location = new System.Drawing.Point(135, 92);
            this.textPostfix.Name = "textPostfix";
            this.textPostfix.Size = new System.Drawing.Size(100, 20);
            this.textPostfix.TabIndex = 5;
            this.textPostfix.Text = "_export";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filename postfix:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(71, 146);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(473, 145);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(75, 23);
            this.buttonAbort.TabIndex = 8;
            this.buttonAbort.Text = "Cancel";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // textPython
            // 
            this.textPython.Location = new System.Drawing.Point(135, 119);
            this.textPython.Name = "textPython";
            this.textPython.Size = new System.Drawing.Size(376, 20);
            this.textPython.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Python interpreter:";
            // 
            // buttonSerachPy
            // 
            this.buttonSerachPy.Location = new System.Drawing.Point(518, 119);
            this.buttonSerachPy.Name = "buttonSerachPy";
            this.buttonSerachPy.Size = new System.Drawing.Size(75, 23);
            this.buttonSerachPy.TabIndex = 11;
            this.buttonSerachPy.Text = "Browse ...";
            this.buttonSerachPy.UseVisualStyleBackColor = true;
            this.buttonSerachPy.Click += new System.EventHandler(this.buttonSerachPy_Click);
            // 
            // openPython
            // 
            this.openPython.Filter = "All files|*.*";
            this.openPython.Title = "Python interpreter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Skeinforge craft:";
            // 
            // textSkeinforgeCraft
            // 
            this.textSkeinforgeCraft.Location = new System.Drawing.Point(135, 39);
            this.textSkeinforgeCraft.Name = "textSkeinforgeCraft";
            this.textSkeinforgeCraft.Size = new System.Drawing.Size(376, 20);
            this.textSkeinforgeCraft.TabIndex = 1;
            // 
            // buttonSearchCraft
            // 
            this.buttonSearchCraft.Location = new System.Drawing.Point(518, 39);
            this.buttonSearchCraft.Name = "buttonSearchCraft";
            this.buttonSearchCraft.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchCraft.TabIndex = 2;
            this.buttonSearchCraft.Text = "Browse ...";
            this.buttonSearchCraft.UseVisualStyleBackColor = true;
            this.buttonSearchCraft.Click += new System.EventHandler(this.buttonSearchCraft_Click);
            // 
            // Skeinforge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 186);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSerachPy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPython);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPostfix);
            this.Controls.Add(this.textExtension);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearchCraft);
            this.Controls.Add(this.buttonSerach);
            this.Controls.Add(this.textSkeinforgeCraft);
            this.Controls.Add(this.textSkainforge);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Skeinforge";
            this.Text = "Skeinforge settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSkainforge;
        private System.Windows.Forms.Button buttonSerach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textExtension;
        private System.Windows.Forms.TextBox textPostfix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.TextBox textPython;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSerachPy;
        private System.Windows.Forms.OpenFileDialog openPython;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSkeinforgeCraft;
        private System.Windows.Forms.Button buttonSearchCraft;
    }
}