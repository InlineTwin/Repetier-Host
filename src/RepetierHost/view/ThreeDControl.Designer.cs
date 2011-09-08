namespace RepetierHost.view
{
    partial class ThreeDControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThreeDControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolRotate = new System.Windows.Forms.ToolStripButton();
            this.toolMove = new System.Windows.Forms.ToolStripButton();
            this.toolMoveViewpoint = new System.Windows.Forms.ToolStripButton();
            this.toolZoom = new System.Windows.Forms.ToolStripButton();
            this.toolResetView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMoveObject = new System.Windows.Forms.ToolStripButton();
            this.gl = new OpenTK.GLControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolAutoupdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripClear = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRotate,
            this.toolMove,
            this.toolMoveViewpoint,
            this.toolZoom,
            this.toolResetView,
            this.toolStripSeparator1,
            this.toolMoveObject,
            this.toolAutoupdate,
            this.toolStripClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(830, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolRotate
            // 
            this.toolRotate.Checked = true;
            this.toolRotate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolRotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolRotate.Image = ((System.Drawing.Image)(resources.GetObject("toolRotate.Image")));
            this.toolRotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRotate.Name = "toolRotate";
            this.toolRotate.Size = new System.Drawing.Size(45, 22);
            this.toolRotate.Text = "Rotate";
            this.toolRotate.Click += new System.EventHandler(this.toolRotate_Click);
            // 
            // toolMove
            // 
            this.toolMove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolMove.Image = ((System.Drawing.Image)(resources.GetObject("toolMove.Image")));
            this.toolMove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMove.Name = "toolMove";
            this.toolMove.Size = new System.Drawing.Size(87, 22);
            this.toolMove.Text = "Move position";
            this.toolMove.Click += new System.EventHandler(this.toolMove_Click);
            // 
            // toolMoveViewpoint
            // 
            this.toolMoveViewpoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolMoveViewpoint.Image = ((System.Drawing.Image)(resources.GetObject("toolMoveViewpoint.Image")));
            this.toolMoveViewpoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMoveViewpoint.Name = "toolMoveViewpoint";
            this.toolMoveViewpoint.Size = new System.Drawing.Size(96, 22);
            this.toolMoveViewpoint.Text = "Move viewpoint";
            this.toolMoveViewpoint.Click += new System.EventHandler(this.toolMoveViewpoint_Click);
            // 
            // toolZoom
            // 
            this.toolZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolZoom.Image = ((System.Drawing.Image)(resources.GetObject("toolZoom.Image")));
            this.toolZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoom.Name = "toolZoom";
            this.toolZoom.Size = new System.Drawing.Size(43, 22);
            this.toolZoom.Text = "Zoom";
            this.toolZoom.Click += new System.EventHandler(this.toolZoom_Click);
            // 
            // toolResetView
            // 
            this.toolResetView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolResetView.Image = ((System.Drawing.Image)(resources.GetObject("toolResetView.Image")));
            this.toolResetView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolResetView.Name = "toolResetView";
            this.toolResetView.Size = new System.Drawing.Size(66, 22);
            this.toolResetView.Text = "Reset view";
            this.toolResetView.Click += new System.EventHandler(this.toolResetView_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolMoveObject
            // 
            this.toolMoveObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolMoveObject.Image = ((System.Drawing.Image)(resources.GetObject("toolMoveObject.Image")));
            this.toolMoveObject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMoveObject.Name = "toolMoveObject";
            this.toolMoveObject.Size = new System.Drawing.Size(77, 22);
            this.toolMoveObject.Text = "Move object";
            this.toolMoveObject.Click += new System.EventHandler(this.toolMoveObject_Click);
            // 
            // gl
            // 
            this.gl.BackColor = System.Drawing.Color.Black;
            this.gl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gl.Location = new System.Drawing.Point(0, 25);
            this.gl.Name = "gl";
            this.gl.Size = new System.Drawing.Size(830, 479);
            this.gl.TabIndex = 2;
            this.gl.VSync = false;
            this.gl.Paint += new System.Windows.Forms.PaintEventHandler(this.gl_Paint);
            this.gl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gl_MouseMove);
            this.gl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gl_MouseDown);
            this.gl.Resize += new System.EventHandler(this.gl_Resize);
            this.gl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ThreeDControl_KeyPress);
            this.gl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gl_MouseUp);
            // 
            // timer
            // 
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // toolAutoupdate
            // 
            this.toolAutoupdate.Checked = true;
            this.toolAutoupdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolAutoupdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolAutoupdate.Image = ((System.Drawing.Image)(resources.GetObject("toolAutoupdate.Image")));
            this.toolAutoupdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAutoupdate.Name = "toolAutoupdate";
            this.toolAutoupdate.Size = new System.Drawing.Size(74, 22);
            this.toolAutoupdate.Text = "Autoupdate";
            // 
            // toolStripClear
            // 
            this.toolStripClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripClear.Image")));
            this.toolStripClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripClear.Name = "toolStripClear";
            this.toolStripClear.Size = new System.Drawing.Size(38, 22);
            this.toolStripClear.Text = "Clear";
            this.toolStripClear.Click += new System.EventHandler(this.toolStripClear_Click);
            // 
            // ThreeDControl
            // 
            this.Controls.Add(this.gl);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ThreeDControl";
            this.Size = new System.Drawing.Size(830, 504);
            this.Load += new System.EventHandler(this.ThreeDControl_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ThreeDControl_KeyPress);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private OpenTK.GLControl gl;
        private System.Windows.Forms.ToolStripButton toolRotate;
        private System.Windows.Forms.ToolStripButton toolMove;
        private System.Windows.Forms.ToolStripButton toolResetView;
        private System.Windows.Forms.ToolStripButton toolMoveViewpoint;
        private System.Windows.Forms.ToolStripButton toolZoom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolMoveObject;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripButton toolAutoupdate;
        private System.Windows.Forms.ToolStripButton toolStripClear;
    }
}
