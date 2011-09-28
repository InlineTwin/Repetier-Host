namespace RepetierHost
{
    partial class Main
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eeprom = new System.Windows.Forms.ToolStripMenuItem();
            this.skeinforgeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeDSettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.repetierSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internalSlicingParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printerInformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skeinforgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testCaseGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repetierHostHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutRepetierHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.fpsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolLoadGCode = new System.Windows.Forms.ToolStripButton();
            this.toolRunJob = new System.Windows.Forms.ToolStripButton();
            this.toolKillJob = new System.Windows.Forms.ToolStripButton();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPrint = new System.Windows.Forms.TabPage();
            this.splitVert = new System.Windows.Forms.SplitContainer();
            this.splitContainerPrinterGraphic = new System.Windows.Forms.SplitContainer();
            this.tabGCode = new System.Windows.Forms.TabPage();
            this.toolStripJob = new System.Windows.Forms.ToolStrip();
            this.toolStripSaveGCode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSavePrepend = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveAppend = new System.Windows.Forms.ToolStripButton();
            this.toolStripJobPreview = new System.Windows.Forms.ToolStripButton();
            this.splitJob = new System.Windows.Forms.SplitContainer();
            this.tabGCodes = new System.Windows.Forms.TabControl();
            this.tabPageGCode = new System.Windows.Forms.TabPage();
            this.textGCode = new System.Windows.Forms.TextBox();
            this.tabPagePrepend = new System.Windows.Forms.TabPage();
            this.textGCodePrepend = new System.Windows.Forms.TextBox();
            this.tabPageGCodeAppend = new System.Windows.Forms.TabPage();
            this.textGCodeAppend = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolGCodeCol = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolGCodeRow = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabModel = new System.Windows.Forms.TabPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.openGCode = new System.Windows.Forms.OpenFileDialog();
            this.saveJobDialog = new System.Windows.Forms.SaveFileDialog();
            this.stlComposer1 = new RepetierHost.view.STLComposer();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabPrint.SuspendLayout();
            this.splitVert.Panel1.SuspendLayout();
            this.splitVert.SuspendLayout();
            this.splitContainerPrinterGraphic.SuspendLayout();
            this.tabGCode.SuspendLayout();
            this.toolStripJob.SuspendLayout();
            this.splitJob.Panel1.SuspendLayout();
            this.splitJob.SuspendLayout();
            this.tabGCodes.SuspendLayout();
            this.tabPageGCode.SuspendLayout();
            this.tabPagePrepend.SuspendLayout();
            this.tabPageGCodeAppend.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabModel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(942, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadGCodeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadGCodeToolStripMenuItem
            // 
            this.loadGCodeToolStripMenuItem.Name = "loadGCodeToolStripMenuItem";
            this.loadGCodeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.loadGCodeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.loadGCodeToolStripMenuItem.Text = "&Load GCode";
            this.loadGCodeToolStripMenuItem.Click += new System.EventHandler(this.toolGCodeLoad_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printerSettingsToolStripMenuItem,
            this.eeprom,
            this.skeinforgeSettingsToolStripMenuItem,
            this.threeDSettingsMenu,
            this.repetierSettingsToolStripMenuItem,
            this.internalSlicingParameterToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // printerSettingsToolStripMenuItem
            // 
            this.printerSettingsToolStripMenuItem.Name = "printerSettingsToolStripMenuItem";
            this.printerSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printerSettingsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.printerSettingsToolStripMenuItem.Text = "&Printer settings";
            this.printerSettingsToolStripMenuItem.Click += new System.EventHandler(this.printerSettingsToolStripMenuItem_Click);
            // 
            // eeprom
            // 
            this.eeprom.Name = "eeprom";
            this.eeprom.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.eeprom.Size = new System.Drawing.Size(252, 22);
            this.eeprom.Text = "Firmware EEPROM settings";
            this.eeprom.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // skeinforgeSettingsToolStripMenuItem
            // 
            this.skeinforgeSettingsToolStripMenuItem.Name = "skeinforgeSettingsToolStripMenuItem";
            this.skeinforgeSettingsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.skeinforgeSettingsToolStripMenuItem.Text = "Skeinforge settings";
            this.skeinforgeSettingsToolStripMenuItem.Click += new System.EventHandler(this.skeinforgeSettingsToolStripMenuItem_Click);
            // 
            // threeDSettingsMenu
            // 
            this.threeDSettingsMenu.Name = "threeDSettingsMenu";
            this.threeDSettingsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.threeDSettingsMenu.Size = new System.Drawing.Size(252, 22);
            this.threeDSettingsMenu.Text = "3D settings";
            this.threeDSettingsMenu.Click += new System.EventHandler(this.threeDSettingsMenu_Click);
            // 
            // repetierSettingsToolStripMenuItem
            // 
            this.repetierSettingsToolStripMenuItem.Name = "repetierSettingsToolStripMenuItem";
            this.repetierSettingsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.repetierSettingsToolStripMenuItem.Text = "Repetier settings";
            this.repetierSettingsToolStripMenuItem.Click += new System.EventHandler(this.repetierSettingsToolStripMenuItem_Click);
            // 
            // internalSlicingParameterToolStripMenuItem
            // 
            this.internalSlicingParameterToolStripMenuItem.Name = "internalSlicingParameterToolStripMenuItem";
            this.internalSlicingParameterToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.internalSlicingParameterToolStripMenuItem.Text = "Internal slicing parameter";
            this.internalSlicingParameterToolStripMenuItem.Click += new System.EventHandler(this.internalSlicingParameterToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperatureMonitorToolStripMenuItem,
            this.printerInformationsToolStripMenuItem,
            this.jobStatusToolStripMenuItem,
            this.skeinforgeToolStripMenuItem,
            this.testCaseGeneratorToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "&Windows";
            // 
            // temperatureMonitorToolStripMenuItem
            // 
            this.temperatureMonitorToolStripMenuItem.Name = "temperatureMonitorToolStripMenuItem";
            this.temperatureMonitorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.temperatureMonitorToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.temperatureMonitorToolStripMenuItem.Text = "Temperature monitor";
            this.temperatureMonitorToolStripMenuItem.Click += new System.EventHandler(this.temperatureMonitorToolStripMenuItem_Click);
            // 
            // printerInformationsToolStripMenuItem
            // 
            this.printerInformationsToolStripMenuItem.Name = "printerInformationsToolStripMenuItem";
            this.printerInformationsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.printerInformationsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.printerInformationsToolStripMenuItem.Text = "Printer informations";
            this.printerInformationsToolStripMenuItem.Click += new System.EventHandler(this.printerInformationsToolStripMenuItem_Click);
            // 
            // jobStatusToolStripMenuItem
            // 
            this.jobStatusToolStripMenuItem.Name = "jobStatusToolStripMenuItem";
            this.jobStatusToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.J)));
            this.jobStatusToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.jobStatusToolStripMenuItem.Text = "Job status";
            this.jobStatusToolStripMenuItem.Click += new System.EventHandler(this.jobStatusToolStripMenuItem_Click);
            // 
            // skeinforgeToolStripMenuItem
            // 
            this.skeinforgeToolStripMenuItem.Name = "skeinforgeToolStripMenuItem";
            this.skeinforgeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.skeinforgeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.skeinforgeToolStripMenuItem.Text = "Skeinforge";
            this.skeinforgeToolStripMenuItem.Click += new System.EventHandler(this.skeinforgeToolStripMenuItem_Click);
            // 
            // testCaseGeneratorToolStripMenuItem
            // 
            this.testCaseGeneratorToolStripMenuItem.Name = "testCaseGeneratorToolStripMenuItem";
            this.testCaseGeneratorToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.testCaseGeneratorToolStripMenuItem.Text = "Test case generator";
            this.testCaseGeneratorToolStripMenuItem.Click += new System.EventHandler(this.testCaseGeneratorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repetierHostHomepageToolStripMenuItem,
            this.manualToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutRepetierHostToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // repetierHostHomepageToolStripMenuItem
            // 
            this.repetierHostHomepageToolStripMenuItem.Name = "repetierHostHomepageToolStripMenuItem";
            this.repetierHostHomepageToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.repetierHostHomepageToolStripMenuItem.Text = "Repetier-Host homepage";
            this.repetierHostHomepageToolStripMenuItem.Click += new System.EventHandler(this.repetierHostHomepageToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(204, 6);
            // 
            // aboutRepetierHostToolStripMenuItem
            // 
            this.aboutRepetierHostToolStripMenuItem.Name = "aboutRepetierHostToolStripMenuItem";
            this.aboutRepetierHostToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.aboutRepetierHostToolStripMenuItem.Text = "&About Repetier-Host";
            this.aboutRepetierHostToolStripMenuItem.Click += new System.EventHandler(this.aboutRepetierHostToolStripMenuItem_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolConnection,
            this.toolAction,
            this.toolProgress,
            this.fpsLabel});
            this.status.Location = new System.Drawing.Point(0, 505);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(942, 22);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // toolConnection
            // 
            this.toolConnection.Name = "toolConnection";
            this.toolConnection.Size = new System.Drawing.Size(86, 17);
            this.toolConnection.Text = "Not connected";
            // 
            // toolAction
            // 
            this.toolAction.Name = "toolAction";
            this.toolAction.Size = new System.Drawing.Size(26, 17);
            this.toolAction.Text = "Idle";
            // 
            // toolProgress
            // 
            this.toolProgress.Name = "toolProgress";
            this.toolProgress.Size = new System.Drawing.Size(200, 16);
            // 
            // fpsLabel
            // 
            this.fpsLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(34, 17);
            this.fpsLabel.Text = "- FPS";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLoadGCode,
            this.toolRunJob,
            this.toolKillJob});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(942, 39);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolLoadGCode
            // 
            this.toolLoadGCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLoadGCode.Image = ((System.Drawing.Image)(resources.GetObject("toolLoadGCode.Image")));
            this.toolLoadGCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLoadGCode.Name = "toolLoadGCode";
            this.toolLoadGCode.Size = new System.Drawing.Size(36, 36);
            this.toolLoadGCode.Text = "Load G-Code";
            this.toolLoadGCode.Click += new System.EventHandler(this.toolGCodeLoad_Click);
            // 
            // toolRunJob
            // 
            this.toolRunJob.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRunJob.Image = ((System.Drawing.Image)(resources.GetObject("toolRunJob.Image")));
            this.toolRunJob.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRunJob.Name = "toolRunJob";
            this.toolRunJob.Size = new System.Drawing.Size(36, 36);
            this.toolRunJob.Text = "Run job";
            this.toolRunJob.Click += new System.EventHandler(this.toolPrintJob_Click);
            // 
            // toolKillJob
            // 
            this.toolKillJob.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolKillJob.Enabled = false;
            this.toolKillJob.Image = ((System.Drawing.Image)(resources.GetObject("toolKillJob.Image")));
            this.toolKillJob.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolKillJob.Name = "toolKillJob";
            this.toolKillJob.Size = new System.Drawing.Size(36, 36);
            this.toolKillJob.Text = "Kill Job";
            this.toolKillJob.Click += new System.EventHandler(this.toolKillJob_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPrint);
            this.tab.Controls.Add(this.tabGCode);
            this.tab.Controls.Add(this.tabModel);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 63);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(942, 442);
            this.tab.TabIndex = 3;
            // 
            // tabPrint
            // 
            this.tabPrint.Controls.Add(this.splitVert);
            this.tabPrint.Location = new System.Drawing.Point(4, 22);
            this.tabPrint.Name = "tabPrint";
            this.tabPrint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrint.Size = new System.Drawing.Size(934, 416);
            this.tabPrint.TabIndex = 0;
            this.tabPrint.Text = "Print";
            this.tabPrint.UseVisualStyleBackColor = true;
            // 
            // splitVert
            // 
            this.splitVert.BackColor = System.Drawing.Color.Transparent;
            this.splitVert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitVert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitVert.Location = new System.Drawing.Point(3, 3);
            this.splitVert.Name = "splitVert";
            this.splitVert.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitVert.Panel1
            // 
            this.splitVert.Panel1.Controls.Add(this.splitContainerPrinterGraphic);
            this.splitVert.Size = new System.Drawing.Size(928, 410);
            this.splitVert.SplitterDistance = 301;
            this.splitVert.TabIndex = 0;
            // 
            // splitContainerPrinterGraphic
            // 
            this.splitContainerPrinterGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPrinterGraphic.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerPrinterGraphic.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPrinterGraphic.Name = "splitContainerPrinterGraphic";
            this.splitContainerPrinterGraphic.Size = new System.Drawing.Size(926, 299);
            this.splitContainerPrinterGraphic.SplitterDistance = 465;
            this.splitContainerPrinterGraphic.TabIndex = 0;
            // 
            // tabGCode
            // 
            this.tabGCode.AutoScroll = true;
            this.tabGCode.Controls.Add(this.toolStripJob);
            this.tabGCode.Controls.Add(this.splitJob);
            this.tabGCode.Controls.Add(this.statusStrip1);
            this.tabGCode.Location = new System.Drawing.Point(4, 22);
            this.tabGCode.Name = "tabGCode";
            this.tabGCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabGCode.Size = new System.Drawing.Size(934, 416);
            this.tabGCode.TabIndex = 1;
            this.tabGCode.Text = "Job";
            this.tabGCode.UseVisualStyleBackColor = true;
            // 
            // toolStripJob
            // 
            this.toolStripJob.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSaveGCode,
            this.toolStripSavePrepend,
            this.toolStripSaveAppend,
            this.toolStripJobPreview});
            this.toolStripJob.Location = new System.Drawing.Point(3, 3);
            this.toolStripJob.Name = "toolStripJob";
            this.toolStripJob.Size = new System.Drawing.Size(928, 25);
            this.toolStripJob.TabIndex = 4;
            this.toolStripJob.Text = "toolStripJob";
            // 
            // toolStripSaveGCode
            // 
            this.toolStripSaveGCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSaveGCode.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveGCode.Image")));
            this.toolStripSaveGCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveGCode.Name = "toolStripSaveGCode";
            this.toolStripSaveGCode.Size = new System.Drawing.Size(79, 22);
            this.toolStripSaveGCode.Text = "Save G-Code";
            this.toolStripSaveGCode.Click += new System.EventHandler(this.toolStripSaveGCode_Click);
            // 
            // toolStripSavePrepend
            // 
            this.toolStripSavePrepend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSavePrepend.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSavePrepend.Image")));
            this.toolStripSavePrepend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSavePrepend.Name = "toolStripSavePrepend";
            this.toolStripSavePrepend.Size = new System.Drawing.Size(82, 22);
            this.toolStripSavePrepend.Text = "Save prepend";
            this.toolStripSavePrepend.Click += new System.EventHandler(this.toolStripSavePrepend_Click);
            // 
            // toolStripSaveAppend
            // 
            this.toolStripSaveAppend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSaveAppend.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveAppend.Image")));
            this.toolStripSaveAppend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveAppend.Name = "toolStripSaveAppend";
            this.toolStripSaveAppend.Size = new System.Drawing.Size(78, 22);
            this.toolStripSaveAppend.Text = "Save append";
            this.toolStripSaveAppend.Click += new System.EventHandler(this.toolStripSaveAppend_Click);
            // 
            // toolStripJobPreview
            // 
            this.toolStripJobPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripJobPreview.Image = ((System.Drawing.Image)(resources.GetObject("toolStripJobPreview.Image")));
            this.toolStripJobPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripJobPreview.Name = "toolStripJobPreview";
            this.toolStripJobPreview.Size = new System.Drawing.Size(86, 22);
            this.toolStripJobPreview.Text = "Visual preview";
            this.toolStripJobPreview.Click += new System.EventHandler(this.toolStripJobPreview_Click);
            // 
            // splitJob
            // 
            this.splitJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitJob.BackColor = System.Drawing.Color.Transparent;
            this.splitJob.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitJob.Location = new System.Drawing.Point(3, 31);
            this.splitJob.Name = "splitJob";
            // 
            // splitJob.Panel1
            // 
            this.splitJob.Panel1.Controls.Add(this.tabGCodes);
            this.splitJob.Panel2Collapsed = true;
            this.splitJob.Size = new System.Drawing.Size(928, 357);
            this.splitJob.SplitterDistance = 542;
            this.splitJob.TabIndex = 3;
            // 
            // tabGCodes
            // 
            this.tabGCodes.Controls.Add(this.tabPageGCode);
            this.tabGCodes.Controls.Add(this.tabPagePrepend);
            this.tabGCodes.Controls.Add(this.tabPageGCodeAppend);
            this.tabGCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGCodes.Location = new System.Drawing.Point(0, 0);
            this.tabGCodes.Name = "tabGCodes";
            this.tabGCodes.SelectedIndex = 0;
            this.tabGCodes.Size = new System.Drawing.Size(928, 357);
            this.tabGCodes.TabIndex = 2;
            // 
            // tabPageGCode
            // 
            this.tabPageGCode.Controls.Add(this.textGCode);
            this.tabPageGCode.Location = new System.Drawing.Point(4, 22);
            this.tabPageGCode.Name = "tabPageGCode";
            this.tabPageGCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGCode.Size = new System.Drawing.Size(920, 331);
            this.tabPageGCode.TabIndex = 0;
            this.tabPageGCode.Text = "GCode";
            this.tabPageGCode.UseVisualStyleBackColor = true;
            // 
            // textGCode
            // 
            this.textGCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textGCode.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGCode.Location = new System.Drawing.Point(3, 3);
            this.textGCode.MaxLength = 327670000;
            this.textGCode.Multiline = true;
            this.textGCode.Name = "textGCode";
            this.textGCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textGCode.Size = new System.Drawing.Size(914, 325);
            this.textGCode.TabIndex = 0;
            this.textGCode.Click += new System.EventHandler(this.textGCode_Click);
            this.textGCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textGCode_Key);
            this.textGCode.Enter += new System.EventHandler(this.textGCode_Enter);
            // 
            // tabPagePrepend
            // 
            this.tabPagePrepend.Controls.Add(this.textGCodePrepend);
            this.tabPagePrepend.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrepend.Name = "tabPagePrepend";
            this.tabPagePrepend.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrepend.Size = new System.Drawing.Size(920, 331);
            this.tabPagePrepend.TabIndex = 1;
            this.tabPagePrepend.Text = "Prepend";
            this.tabPagePrepend.UseVisualStyleBackColor = true;
            // 
            // textGCodePrepend
            // 
            this.textGCodePrepend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textGCodePrepend.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGCodePrepend.Location = new System.Drawing.Point(3, 3);
            this.textGCodePrepend.MaxLength = 327670;
            this.textGCodePrepend.Multiline = true;
            this.textGCodePrepend.Name = "textGCodePrepend";
            this.textGCodePrepend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textGCodePrepend.Size = new System.Drawing.Size(914, 325);
            this.textGCodePrepend.TabIndex = 0;
            this.textGCodePrepend.Click += new System.EventHandler(this.textGCodePrepend_Click);
            this.textGCodePrepend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textGCode_Key);
            this.textGCodePrepend.Enter += new System.EventHandler(this.textGCode_Enter);
            // 
            // tabPageGCodeAppend
            // 
            this.tabPageGCodeAppend.Controls.Add(this.textGCodeAppend);
            this.tabPageGCodeAppend.Location = new System.Drawing.Point(4, 22);
            this.tabPageGCodeAppend.Name = "tabPageGCodeAppend";
            this.tabPageGCodeAppend.Size = new System.Drawing.Size(920, 331);
            this.tabPageGCodeAppend.TabIndex = 2;
            this.tabPageGCodeAppend.Text = "Append";
            this.tabPageGCodeAppend.UseVisualStyleBackColor = true;
            // 
            // textGCodeAppend
            // 
            this.textGCodeAppend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textGCodeAppend.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGCodeAppend.Location = new System.Drawing.Point(0, 0);
            this.textGCodeAppend.MaxLength = 327670;
            this.textGCodeAppend.Multiline = true;
            this.textGCodeAppend.Name = "textGCodeAppend";
            this.textGCodeAppend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textGCodeAppend.Size = new System.Drawing.Size(920, 331);
            this.textGCodeAppend.TabIndex = 0;
            this.textGCodeAppend.Click += new System.EventHandler(this.textGCodeAppend_Click);
            this.textGCodeAppend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textGCode_Key);
            this.textGCodeAppend.Enter += new System.EventHandler(this.textGCode_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGCodeCol,
            this.toolGCodeRow});
            this.statusStrip1.Location = new System.Drawing.Point(3, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(928, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolGCodeCol
            // 
            this.toolGCodeCol.Name = "toolGCodeCol";
            this.toolGCodeCol.Size = new System.Drawing.Size(34, 17);
            this.toolGCodeCol.Text = "Col 0";
            // 
            // toolGCodeRow
            // 
            this.toolGCodeRow.Name = "toolGCodeRow";
            this.toolGCodeRow.Size = new System.Drawing.Size(39, 17);
            this.toolGCodeRow.Text = "Row 1";
            // 
            // tabModel
            // 
            this.tabModel.Controls.Add(this.stlComposer1);
            this.tabModel.Location = new System.Drawing.Point(4, 22);
            this.tabModel.Name = "tabModel";
            this.tabModel.Size = new System.Drawing.Size(934, 416);
            this.tabModel.TabIndex = 2;
            this.tabModel.Text = "Model";
            this.tabModel.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "switch_off.bmp");
            this.imageList.Images.SetKeyName(1, "switch_on.bmp");
            this.imageList.Images.SetKeyName(2, "runjob32.png");
            // 
            // openGCode
            // 
            this.openGCode.DefaultExt = "gcode";
            this.openGCode.Filter = "GCode/STL-Files|*.gcode;*.stl|All files|*.*";
            this.openGCode.Title = "Import GCode";
            // 
            // saveJobDialog
            // 
            this.saveJobDialog.DefaultExt = "gcode";
            this.saveJobDialog.Filter = "GCode|*.gcode|All files|*.*";
            this.saveJobDialog.Title = "Save G-Code";
            // 
            // stlComposer1
            // 
            this.stlComposer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stlComposer1.Location = new System.Drawing.Point(0, 0);
            this.stlComposer1.Name = "stlComposer1";
            this.stlComposer1.Size = new System.Drawing.Size(934, 416);
            this.stlComposer1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 527);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Main";
            this.Text = "Repetier-Host V0.24";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tabPrint.ResumeLayout(false);
            this.splitVert.Panel1.ResumeLayout(false);
            this.splitVert.ResumeLayout(false);
            this.splitContainerPrinterGraphic.ResumeLayout(false);
            this.tabGCode.ResumeLayout(false);
            this.tabGCode.PerformLayout();
            this.toolStripJob.ResumeLayout(false);
            this.toolStripJob.PerformLayout();
            this.splitJob.Panel1.ResumeLayout(false);
            this.splitJob.ResumeLayout(false);
            this.tabGCodes.ResumeLayout(false);
            this.tabPageGCode.ResumeLayout(false);
            this.tabPageGCode.PerformLayout();
            this.tabPagePrepend.ResumeLayout(false);
            this.tabPagePrepend.PerformLayout();
            this.tabPageGCodeAppend.ResumeLayout(false);
            this.tabPageGCodeAppend.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabModel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutRepetierHostToolStripMenuItem;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPrint;
        private System.Windows.Forms.TabPage tabGCode;
        private System.Windows.Forms.ToolStripStatusLabel toolConnection;
        private System.Windows.Forms.ToolStripStatusLabel toolAction;
        private System.Windows.Forms.ToolStripProgressBar toolProgress;
        private System.Windows.Forms.SplitContainer splitVert;
        private System.Windows.Forms.SplitContainer splitContainerPrinterGraphic;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eeprom;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TabPage tabPageGCode;
        private System.Windows.Forms.TextBox textGCode;
        private System.Windows.Forms.TabPage tabPagePrepend;
        private System.Windows.Forms.TabPage tabPageGCodeAppend;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolGCodeCol;
        private System.Windows.Forms.TextBox textGCodeAppend;
        private System.Windows.Forms.OpenFileDialog openGCode;
        private System.Windows.Forms.ToolStripStatusLabel toolGCodeRow;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skeinforgeSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skeinforgeToolStripMenuItem;
        private System.Windows.Forms.TabPage tabModel;
        private System.Windows.Forms.ToolStripMenuItem threeDSettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem printerInformationsToolStripMenuItem;
        private RepetierHost.view.STLComposer stlComposer1;
        private System.Windows.Forms.ToolStripButton toolLoadGCode;
        private System.Windows.Forms.ToolStripMenuItem repetierSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repetierHostHomepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        public System.Windows.Forms.ToolStripButton toolRunJob;
        public System.Windows.Forms.ToolStripButton toolKillJob;
        private System.Windows.Forms.ToolStrip toolStripJob;
        private System.Windows.Forms.ToolStripButton toolStripSavePrepend;
        private System.Windows.Forms.SplitContainer splitJob;
        private System.Windows.Forms.ToolStripButton toolStripSaveGCode;
        private System.Windows.Forms.ToolStripButton toolStripSaveAppend;
        private System.Windows.Forms.ToolStripButton toolStripJobPreview;
        private System.Windows.Forms.SaveFileDialog saveJobDialog;
        public System.Windows.Forms.ToolStripStatusLabel fpsLabel;
        private System.Windows.Forms.ToolStripMenuItem testCaseGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internalSlicingParameterToolStripMenuItem;
        public System.Windows.Forms.TabControl tabGCodes;
        public System.Windows.Forms.TextBox textGCodePrepend;
    }
}

