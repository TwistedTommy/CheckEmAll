namespace CheckEmAll_GUI
{
    partial class FrmCheckEmAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckEmAll));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckEmAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbSaveLog = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCheckEmAll = new System.Windows.Forms.ToolStripButton();
            this.tsbLog = new System.Windows.Forms.ToolStripButton();
            this.tsbViewHelp = new System.Windows.Forms.ToolStripButton();
            this.tsbViewLicense = new System.Windows.Forms.ToolStripButton();
            this.tsbViewToolbar = new System.Windows.Forms.ToolStripButton();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgwStartupTasks = new System.ComponentModel.BackgroundWorker();
            this.bgwCheckDats = new System.ComponentModel.BackgroundWorker();
            this.tabCheckEmAll = new System.Windows.Forms.TabPage();
            this.gbLists = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbLeftNames = new System.Windows.Forms.ListBox();
            this.btnSaveLeftList = new System.Windows.Forms.Button();
            this.txtPathLeftDatFile = new System.Windows.Forms.TextBox();
            this.btnLoadLeftDat = new System.Windows.Forms.Button();
            this.lbRightNames = new System.Windows.Forms.ListBox();
            this.btnSaveRightList = new System.Windows.Forms.Button();
            this.txtPathRightDatFile = new System.Windows.Forms.TextBox();
            this.btnLoadRightDat = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.chkShowNonmatchingROMNames = new System.Windows.Forms.CheckBox();
            this.chkShowNonmatchingGameNames = new System.Windows.Forms.CheckBox();
            this.tabLicense = new System.Windows.Forms.TabPage();
            this.rtbLicense = new System.Windows.Forms.RichTextBox();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.rtbHelp = new System.Windows.Forms.RichTextBox();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.msMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.tabCheckEmAll.SuspendLayout();
            this.gbLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.tabLicense.SuspendLayout();
            this.tabHelp.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCommands,
            this.tsmiView});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(784, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "msMain";
            // 
            // tsmiCommands
            // 
            this.tsmiCommands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveLog,
            this.toolStripSeparator5,
            this.tsmiExit});
            this.tsmiCommands.Name = "tsmiCommands";
            this.tsmiCommands.Size = new System.Drawing.Size(83, 20);
            this.tsmiCommands.Text = "CheckEmAll";
            // 
            // tsmiSaveLog
            // 
            this.tsmiSaveLog.Enabled = false;
            this.tsmiSaveLog.Image = global::CheckEmAll_GUI.Properties.Resources.SaveLog_32x32;
            this.tsmiSaveLog.Name = "tsmiSaveLog";
            this.tsmiSaveLog.Size = new System.Drawing.Size(121, 22);
            this.tsmiSaveLog.Text = "Save Log";
            this.tsmiSaveLog.Click += new System.EventHandler(this.SaveLog_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(118, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = global::CheckEmAll_GUI.Properties.Resources.Exit_32x32;
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(121, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCheckEmAll,
            this.toolStripSeparator1,
            this.tsmiLog,
            this.toolStripSeparator2,
            this.tsmiHelp,
            this.toolStripSeparator3,
            this.tsmiLicense,
            this.toolStripSeparator4,
            this.tsmiToolbar});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(44, 20);
            this.tsmiView.Text = "View";
            // 
            // tsmiCheckEmAll
            // 
            this.tsmiCheckEmAll.Checked = true;
            this.tsmiCheckEmAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiCheckEmAll.Name = "tsmiCheckEmAll";
            this.tsmiCheckEmAll.Size = new System.Drawing.Size(138, 22);
            this.tsmiCheckEmAll.Text = "CheckEmAll";
            this.tsmiCheckEmAll.Click += new System.EventHandler(this.ViewCheckEmAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // tsmiLog
            // 
            this.tsmiLog.Checked = true;
            this.tsmiLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiLog.Name = "tsmiLog";
            this.tsmiLog.Size = new System.Drawing.Size(138, 22);
            this.tsmiLog.Text = "Log";
            this.tsmiLog.Click += new System.EventHandler(this.ViewLog_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(138, 22);
            this.tsmiHelp.Text = "Help";
            this.tsmiHelp.Click += new System.EventHandler(this.ViewHelp_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(135, 6);
            // 
            // tsmiLicense
            // 
            this.tsmiLicense.Name = "tsmiLicense";
            this.tsmiLicense.Size = new System.Drawing.Size(138, 22);
            this.tsmiLicense.Text = "License";
            this.tsmiLicense.Click += new System.EventHandler(this.ViewLicense_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(135, 6);
            // 
            // tsmiToolbar
            // 
            this.tsmiToolbar.Checked = true;
            this.tsmiToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiToolbar.Name = "tsmiToolbar";
            this.tsmiToolbar.Size = new System.Drawing.Size(138, 22);
            this.tsmiToolbar.Text = "Toolbar";
            this.tsmiToolbar.Click += new System.EventHandler(this.ViewToolbar_Click);
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSaveLog,
            this.toolStripSeparator6,
            this.tsbCheckEmAll,
            this.tsbLog,
            this.tsbViewHelp,
            this.tsbViewLicense,
            this.tsbViewToolbar});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(784, 39);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "tsMain";
            // 
            // tsbSaveLog
            // 
            this.tsbSaveLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveLog.Enabled = false;
            this.tsbSaveLog.Image = global::CheckEmAll_GUI.Properties.Resources.SaveLog_32x32;
            this.tsbSaveLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveLog.Name = "tsbSaveLog";
            this.tsbSaveLog.Size = new System.Drawing.Size(36, 36);
            this.tsbSaveLog.Text = "Save Log";
            this.tsbSaveLog.Click += new System.EventHandler(this.SaveLog_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbCheckEmAll
            // 
            this.tsbCheckEmAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCheckEmAll.Image = global::CheckEmAll_GUI.Properties.Resources.CheckEmAll_32x32;
            this.tsbCheckEmAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCheckEmAll.Name = "tsbCheckEmAll";
            this.tsbCheckEmAll.Size = new System.Drawing.Size(36, 36);
            this.tsbCheckEmAll.Text = "CheckEmAll";
            this.tsbCheckEmAll.Click += new System.EventHandler(this.ViewCheckEmAll_Click);
            // 
            // tsbLog
            // 
            this.tsbLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLog.Image = global::CheckEmAll_GUI.Properties.Resources.Log_32x32;
            this.tsbLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLog.Name = "tsbLog";
            this.tsbLog.Size = new System.Drawing.Size(36, 36);
            this.tsbLog.Text = "Log";
            this.tsbLog.Click += new System.EventHandler(this.ViewLog_Click);
            // 
            // tsbViewHelp
            // 
            this.tsbViewHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewHelp.Image = global::CheckEmAll_GUI.Properties.Resources.Help_32x32;
            this.tsbViewHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewHelp.Name = "tsbViewHelp";
            this.tsbViewHelp.Size = new System.Drawing.Size(36, 36);
            this.tsbViewHelp.Text = "Help";
            this.tsbViewHelp.Click += new System.EventHandler(this.ViewHelp_Click);
            // 
            // tsbViewLicense
            // 
            this.tsbViewLicense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewLicense.Image = global::CheckEmAll_GUI.Properties.Resources.License_32x32;
            this.tsbViewLicense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewLicense.Name = "tsbViewLicense";
            this.tsbViewLicense.Size = new System.Drawing.Size(36, 36);
            this.tsbViewLicense.Text = "License";
            this.tsbViewLicense.Click += new System.EventHandler(this.ViewLicense_Click);
            // 
            // tsbViewToolbar
            // 
            this.tsbViewToolbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewToolbar.Image = global::CheckEmAll_GUI.Properties.Resources.Toolbar_32x32;
            this.tsbViewToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewToolbar.Name = "tsbViewToolbar";
            this.tsbViewToolbar.Size = new System.Drawing.Size(36, 36);
            this.tsbViewToolbar.Text = "Toolbar";
            this.tsbViewToolbar.Click += new System.EventHandler(this.ViewToolbar_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.ssMain.Location = new System.Drawing.Point(0, 440);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(784, 22);
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "ssMain";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(617, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(152, 17);
            this.toolStripStatusLabel3.Text = "Performing Startup Tasks ...";
            // 
            // bgwStartupTasks
            // 
            this.bgwStartupTasks.DoWork += new System.ComponentModel.DoWorkEventHandler(this.StartupTasks_DoWork);
            this.bgwStartupTasks.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.StartupTasks_RunWorkerCompleted);
            // 
            // bgwCheckDats
            // 
            this.bgwCheckDats.WorkerReportsProgress = true;
            this.bgwCheckDats.WorkerSupportsCancellation = true;
            this.bgwCheckDats.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CheckDats_DoWork);
            this.bgwCheckDats.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.CheckDats_ProgressChanged);
            this.bgwCheckDats.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CheckDats_RunWorkerCompleted);
            // 
            // tabCheckEmAll
            // 
            this.tabCheckEmAll.Controls.Add(this.gbLists);
            this.tabCheckEmAll.Controls.Add(this.gbOptions);
            this.tabCheckEmAll.Location = new System.Drawing.Point(4, 22);
            this.tabCheckEmAll.Name = "tabCheckEmAll";
            this.tabCheckEmAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheckEmAll.Size = new System.Drawing.Size(776, 351);
            this.tabCheckEmAll.TabIndex = 4;
            this.tabCheckEmAll.Text = " CheckEmAll ";
            this.tabCheckEmAll.UseVisualStyleBackColor = true;
            // 
            // gbLists
            // 
            this.gbLists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLists.Controls.Add(this.splitContainer2);
            this.gbLists.Location = new System.Drawing.Point(6, 77);
            this.gbLists.Name = "gbLists";
            this.gbLists.Size = new System.Drawing.Size(764, 268);
            this.gbLists.TabIndex = 2;
            this.gbLists.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(6, 19);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lbLeftNames);
            this.splitContainer2.Panel1.Controls.Add(this.btnSaveLeftList);
            this.splitContainer2.Panel1.Controls.Add(this.txtPathLeftDatFile);
            this.splitContainer2.Panel1.Controls.Add(this.btnLoadLeftDat);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lbRightNames);
            this.splitContainer2.Panel2.Controls.Add(this.btnSaveRightList);
            this.splitContainer2.Panel2.Controls.Add(this.txtPathRightDatFile);
            this.splitContainer2.Panel2.Controls.Add(this.btnLoadRightDat);
            this.splitContainer2.Size = new System.Drawing.Size(752, 243);
            this.splitContainer2.SplitterDistance = 374;
            this.splitContainer2.TabIndex = 1;
            // 
            // lbLeftNames
            // 
            this.lbLeftNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLeftNames.FormattingEnabled = true;
            this.lbLeftNames.Location = new System.Drawing.Point(3, 35);
            this.lbLeftNames.Name = "lbLeftNames";
            this.lbLeftNames.Size = new System.Drawing.Size(368, 173);
            this.lbLeftNames.TabIndex = 5;
            // 
            // btnSaveLeftList
            // 
            this.btnSaveLeftList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveLeftList.Enabled = false;
            this.btnSaveLeftList.Image = global::CheckEmAll_GUI.Properties.Resources.SaveList_16x16;
            this.btnSaveLeftList.Location = new System.Drawing.Point(3, 214);
            this.btnSaveLeftList.Name = "btnSaveLeftList";
            this.btnSaveLeftList.Size = new System.Drawing.Size(78, 26);
            this.btnSaveLeftList.TabIndex = 6;
            this.btnSaveLeftList.Text = "Save List";
            this.btnSaveLeftList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveLeftList.UseVisualStyleBackColor = true;
            this.btnSaveLeftList.Click += new System.EventHandler(this.SaveLeftList_Click);
            // 
            // txtPathLeftDatFile
            // 
            this.txtPathLeftDatFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathLeftDatFile.Location = new System.Drawing.Point(87, 6);
            this.txtPathLeftDatFile.Name = "txtPathLeftDatFile";
            this.txtPathLeftDatFile.ReadOnly = true;
            this.txtPathLeftDatFile.Size = new System.Drawing.Size(284, 20);
            this.txtPathLeftDatFile.TabIndex = 4;
            // 
            // btnLoadLeftDat
            // 
            this.btnLoadLeftDat.Enabled = false;
            this.btnLoadLeftDat.Image = global::CheckEmAll_GUI.Properties.Resources.LoadDat_16x16;
            this.btnLoadLeftDat.Location = new System.Drawing.Point(3, 3);
            this.btnLoadLeftDat.Name = "btnLoadLeftDat";
            this.btnLoadLeftDat.Size = new System.Drawing.Size(78, 26);
            this.btnLoadLeftDat.TabIndex = 3;
            this.btnLoadLeftDat.Text = "Load Dat";
            this.btnLoadLeftDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadLeftDat.UseVisualStyleBackColor = true;
            this.btnLoadLeftDat.Click += new System.EventHandler(this.LoadLeftDat_Click);
            // 
            // lbRightNames
            // 
            this.lbRightNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRightNames.FormattingEnabled = true;
            this.lbRightNames.Location = new System.Drawing.Point(3, 35);
            this.lbRightNames.Name = "lbRightNames";
            this.lbRightNames.Size = new System.Drawing.Size(368, 173);
            this.lbRightNames.TabIndex = 5;
            // 
            // btnSaveRightList
            // 
            this.btnSaveRightList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveRightList.Enabled = false;
            this.btnSaveRightList.Image = global::CheckEmAll_GUI.Properties.Resources.SaveList_16x16;
            this.btnSaveRightList.Location = new System.Drawing.Point(3, 214);
            this.btnSaveRightList.Name = "btnSaveRightList";
            this.btnSaveRightList.Size = new System.Drawing.Size(78, 26);
            this.btnSaveRightList.TabIndex = 6;
            this.btnSaveRightList.Text = "Save List";
            this.btnSaveRightList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveRightList.UseVisualStyleBackColor = true;
            this.btnSaveRightList.Click += new System.EventHandler(this.SaveRightList_Click);
            // 
            // txtPathRightDatFile
            // 
            this.txtPathRightDatFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathRightDatFile.Location = new System.Drawing.Point(87, 6);
            this.txtPathRightDatFile.Name = "txtPathRightDatFile";
            this.txtPathRightDatFile.ReadOnly = true;
            this.txtPathRightDatFile.Size = new System.Drawing.Size(284, 20);
            this.txtPathRightDatFile.TabIndex = 3;
            // 
            // btnLoadRightDat
            // 
            this.btnLoadRightDat.Enabled = false;
            this.btnLoadRightDat.Image = global::CheckEmAll_GUI.Properties.Resources.LoadDat_16x16;
            this.btnLoadRightDat.Location = new System.Drawing.Point(3, 3);
            this.btnLoadRightDat.Name = "btnLoadRightDat";
            this.btnLoadRightDat.Size = new System.Drawing.Size(78, 26);
            this.btnLoadRightDat.TabIndex = 4;
            this.btnLoadRightDat.Text = "Load Dat";
            this.btnLoadRightDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadRightDat.UseVisualStyleBackColor = true;
            this.btnLoadRightDat.Click += new System.EventHandler(this.LoadRightDat_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.chkShowNonmatchingROMNames);
            this.gbOptions.Controls.Add(this.chkShowNonmatchingGameNames);
            this.gbOptions.Location = new System.Drawing.Point(6, 6);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(764, 65);
            this.gbOptions.TabIndex = 1;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // chkShowNonmatchingROMNames
            // 
            this.chkShowNonmatchingROMNames.AutoSize = true;
            this.chkShowNonmatchingROMNames.Enabled = false;
            this.chkShowNonmatchingROMNames.Location = new System.Drawing.Point(6, 42);
            this.chkShowNonmatchingROMNames.Name = "chkShowNonmatchingROMNames";
            this.chkShowNonmatchingROMNames.Size = new System.Drawing.Size(181, 17);
            this.chkShowNonmatchingROMNames.TabIndex = 1;
            this.chkShowNonmatchingROMNames.Text = "Show nonmatching ROM Names";
            this.chkShowNonmatchingROMNames.UseVisualStyleBackColor = true;
            this.chkShowNonmatchingROMNames.CheckedChanged += new System.EventHandler(this.ShowNonmatchingROMNames_CheckedChanged);
            // 
            // chkShowNonmatchingGameNames
            // 
            this.chkShowNonmatchingGameNames.AutoSize = true;
            this.chkShowNonmatchingGameNames.Enabled = false;
            this.chkShowNonmatchingGameNames.Location = new System.Drawing.Point(6, 19);
            this.chkShowNonmatchingGameNames.Name = "chkShowNonmatchingGameNames";
            this.chkShowNonmatchingGameNames.Size = new System.Drawing.Size(186, 17);
            this.chkShowNonmatchingGameNames.TabIndex = 0;
            this.chkShowNonmatchingGameNames.Text = "Show Nonmatching Game Names";
            this.chkShowNonmatchingGameNames.UseVisualStyleBackColor = true;
            this.chkShowNonmatchingGameNames.CheckedChanged += new System.EventHandler(this.ShowNonmatchingGameNames_CheckedChanged);
            // 
            // tabLicense
            // 
            this.tabLicense.Controls.Add(this.rtbLicense);
            this.tabLicense.Location = new System.Drawing.Point(4, 22);
            this.tabLicense.Name = "tabLicense";
            this.tabLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tabLicense.Size = new System.Drawing.Size(776, 351);
            this.tabLicense.TabIndex = 2;
            this.tabLicense.Text = " License ";
            this.tabLicense.UseVisualStyleBackColor = true;
            // 
            // rtbLicense
            // 
            this.rtbLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLicense.Location = new System.Drawing.Point(6, 6);
            this.rtbLicense.Name = "rtbLicense";
            this.rtbLicense.ReadOnly = true;
            this.rtbLicense.Size = new System.Drawing.Size(764, 339);
            this.rtbLicense.TabIndex = 0;
            this.rtbLicense.Text = "";
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.rtbHelp);
            this.tabHelp.Location = new System.Drawing.Point(4, 22);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelp.Size = new System.Drawing.Size(776, 351);
            this.tabHelp.TabIndex = 1;
            this.tabHelp.Text = " Help ";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // rtbHelp
            // 
            this.rtbHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbHelp.Location = new System.Drawing.Point(6, 6);
            this.rtbHelp.Name = "rtbHelp";
            this.rtbHelp.ReadOnly = true;
            this.rtbHelp.Size = new System.Drawing.Size(764, 339);
            this.rtbHelp.TabIndex = 0;
            this.rtbHelp.Text = "";
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.rtbLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(776, 351);
            this.tabLog.TabIndex = 3;
            this.tabLog.Text = " Log ";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.Location = new System.Drawing.Point(6, 6);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(764, 339);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabCheckEmAll);
            this.tcMain.Controls.Add(this.tabLog);
            this.tcMain.Controls.Add(this.tabHelp);
            this.tcMain.Controls.Add(this.tabLicense);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 63);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(784, 377);
            this.tcMain.TabIndex = 3;
            // 
            // FrmCheckEmAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Name = "FrmCheckEmAll";
            this.Text = "CheckEmAll";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tabCheckEmAll.ResumeLayout(false);
            this.gbLists.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.tabLicense.ResumeLayout(false);
            this.tabHelp.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiCommands;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripButton tsbCheckEmAll;
        private System.Windows.Forms.ToolStripButton tsbViewHelp;
        private System.Windows.Forms.ToolStripButton tsbViewLicense;
        private System.Windows.Forms.ToolStripButton tsbViewToolbar;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckEmAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiToolbar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.ComponentModel.BackgroundWorker bgwStartupTasks;
        private System.ComponentModel.BackgroundWorker bgwCheckDats;
        private System.Windows.Forms.ToolStripButton tsbLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbSaveLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.TabPage tabCheckEmAll;
        private System.Windows.Forms.GroupBox gbLists;
        private System.Windows.Forms.Button btnSaveLeftList;
        private System.Windows.Forms.ListBox lbLeftNames;
        private System.Windows.Forms.TextBox txtPathLeftDatFile;
        private System.Windows.Forms.Button btnLoadLeftDat;
        private System.Windows.Forms.Button btnSaveRightList;
        private System.Windows.Forms.ListBox lbRightNames;
        private System.Windows.Forms.Button btnLoadRightDat;
        private System.Windows.Forms.TextBox txtPathRightDatFile;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.CheckBox chkShowNonmatchingROMNames;
        private System.Windows.Forms.CheckBox chkShowNonmatchingGameNames;
        private System.Windows.Forms.TabPage tabLicense;
        private System.Windows.Forms.RichTextBox rtbLicense;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.RichTextBox rtbHelp;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

