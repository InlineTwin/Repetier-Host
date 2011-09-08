namespace RepetierHost.view
{
    partial class LogView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSend = new System.Windows.Forms.ToolStripButton();
            this.toolInfo = new System.Windows.Forms.ToolStripButton();
            this.toolWarning = new System.Windows.Forms.ToolStripButton();
            this.toolErrors = new System.Windows.Forms.ToolStripButton();
            this.toolACK = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAutoscroll = new System.Windows.Forms.ToolStripButton();
            this.toolClear = new System.Windows.Forms.ToolStripButton();
            this.toolCopy = new System.Windows.Forms.ToolStripButton();
            this.listLog = new System.Windows.Forms.ListView();
            this.column = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSend,
            this.toolInfo,
            this.toolWarning,
            this.toolErrors,
            this.toolACK,
            this.toolStripSeparator1,
            this.toolAutoscroll,
            this.toolClear,
            this.toolCopy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(947, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSend
            // 
            this.toolSend.Checked = true;
            this.toolSend.CheckOnClick = true;
            this.toolSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSend.Image = ((System.Drawing.Image)(resources.GetObject("toolSend.Image")));
            this.toolSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSend.Name = "toolSend";
            this.toolSend.Size = new System.Drawing.Size(37, 22);
            this.toolSend.Text = "Send";
            this.toolSend.ToolTipText = "Show commands send";
            this.toolSend.CheckStateChanged += new System.EventHandler(this.toolSend_CheckStateChanged);
            // 
            // toolInfo
            // 
            this.toolInfo.Checked = true;
            this.toolInfo.CheckOnClick = true;
            this.toolInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolInfo.Image")));
            this.toolInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolInfo.Name = "toolInfo";
            this.toolInfo.Size = new System.Drawing.Size(32, 22);
            this.toolInfo.Text = "Info";
            this.toolInfo.CheckStateChanged += new System.EventHandler(this.toolInfo_CheckStateChanged);
            // 
            // toolWarning
            // 
            this.toolWarning.Checked = true;
            this.toolWarning.CheckOnClick = true;
            this.toolWarning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolWarning.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolWarning.Image = ((System.Drawing.Image)(resources.GetObject("toolWarning.Image")));
            this.toolWarning.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolWarning.Name = "toolWarning";
            this.toolWarning.Size = new System.Drawing.Size(61, 22);
            this.toolWarning.Text = "Warnings";
            this.toolWarning.CheckStateChanged += new System.EventHandler(this.toolWarning_CheckStateChanged);
            // 
            // toolErrors
            // 
            this.toolErrors.Checked = true;
            this.toolErrors.CheckOnClick = true;
            this.toolErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolErrors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolErrors.Image = ((System.Drawing.Image)(resources.GetObject("toolErrors.Image")));
            this.toolErrors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolErrors.Name = "toolErrors";
            this.toolErrors.Size = new System.Drawing.Size(41, 22);
            this.toolErrors.Text = "Errors";
            this.toolErrors.CheckStateChanged += new System.EventHandler(this.toolErrors_CheckStateChanged);
            // 
            // toolACK
            // 
            this.toolACK.CheckOnClick = true;
            this.toolACK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolACK.Image = ((System.Drawing.Image)(resources.GetObject("toolACK.Image")));
            this.toolACK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolACK.Name = "toolACK";
            this.toolACK.Size = new System.Drawing.Size(34, 22);
            this.toolACK.Text = "ACK";
            this.toolACK.ToolTipText = "Show received acknowledgement";
            this.toolACK.Click += new System.EventHandler(this.toolACK_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolAutoscroll
            // 
            this.toolAutoscroll.Checked = true;
            this.toolAutoscroll.CheckOnClick = true;
            this.toolAutoscroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolAutoscroll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolAutoscroll.Image = ((System.Drawing.Image)(resources.GetObject("toolAutoscroll.Image")));
            this.toolAutoscroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAutoscroll.Name = "toolAutoscroll";
            this.toolAutoscroll.Size = new System.Drawing.Size(65, 22);
            this.toolAutoscroll.Text = "Autoscroll";
            this.toolAutoscroll.ToolTipText = "Always show the end, if new logs appear.";
            // 
            // toolClear
            // 
            this.toolClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolClear.Image = ((System.Drawing.Image)(resources.GetObject("toolClear.Image")));
            this.toolClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolClear.Name = "toolClear";
            this.toolClear.Size = new System.Drawing.Size(58, 22);
            this.toolClear.Text = "Clear log";
            this.toolClear.Click += new System.EventHandler(this.toolClear_Click);
            // 
            // toolCopy
            // 
            this.toolCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolCopy.Image")));
            this.toolCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCopy.Name = "toolCopy";
            this.toolCopy.Size = new System.Drawing.Size(39, 22);
            this.toolCopy.Text = "Copy";
            this.toolCopy.Click += new System.EventHandler(this.toolCopy_Click);
            // 
            // listLog
            // 
            this.listLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column});
            this.listLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listLog.Location = new System.Drawing.Point(0, 25);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(947, 376);
            this.listLog.TabIndex = 1;
            this.listLog.UseCompatibleStateImageBehavior = false;
            this.listLog.View = System.Windows.Forms.View.Details;
            this.listLog.Resize += new System.EventHandler(this.listLog_Resize);
            // 
            // column
            // 
            this.column.Text = "Log";
            this.column.Width = 1280;
            // 
            // LogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.toolStrip1);
            this.Name = "LogView";
            this.Size = new System.Drawing.Size(947, 401);
            this.Load += new System.EventHandler(this.LogView_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSend;
        private System.Windows.Forms.ToolStripButton toolInfo;
        private System.Windows.Forms.ListView listLog;
        private System.Windows.Forms.ColumnHeader column;
        private System.Windows.Forms.ToolStripButton toolWarning;
        private System.Windows.Forms.ToolStripButton toolErrors;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolAutoscroll;
        private System.Windows.Forms.ToolStripButton toolClear;
        private System.Windows.Forms.ToolStripButton toolCopy;
        public System.Windows.Forms.ToolStripButton toolACK;
    }
}
