namespace Aggregator.GUI.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tmrRefreshRSS = new System.Windows.Forms.Timer(this.components);
            this.notifyIconStatus = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripOperations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvUnreadMails = new System.Windows.Forms.DataGridView();
            this.dgvRSSItems = new System.Windows.Forms.DataGridView();
            this.cntmsRSSColumns = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.URLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addedDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkbAllRSSItem = new System.Windows.Forms.CheckBox();
            this.btnMarkAllRSSAsRead = new System.Windows.Forms.Button();
            this.bwRefreshMail = new System.ComponentModel.BackgroundWorker();
            this.bwRefreshRSS = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiApplicationSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiErrorsList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewLogOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.spltcMain = new System.Windows.Forms.SplitContainer();
            this.btnRefreshMail = new System.Windows.Forms.Button();
            this.btnMailReply = new System.Windows.Forms.Button();
            this.btnMailDelete = new System.Windows.Forms.Button();
            this.btnMailsStopStart = new System.Windows.Forms.Button();
            this.ssOutlook = new System.Windows.Forms.StatusStrip();
            this.tsslRefreshedCountOutlook = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNextRefreshOutlook = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnMarkAllMailsAsRead = new System.Windows.Forms.Button();
            this.btnRefreshNonActiveRSS = new System.Windows.Forms.Button();
            this.btnRefreshActiveRSS = new System.Windows.Forms.Button();
            this.gbSpecificfeed = new System.Windows.Forms.GroupBox();
            this.cbFeeds = new System.Windows.Forms.ComboBox();
            this.btnRefreshFromWeb = new System.Windows.Forms.Button();
            this.lblShowSpecificFeed = new System.Windows.Forms.Label();
            this.btnLoadCurrentFeed = new System.Windows.Forms.Button();
            this.lblIsActiveFeed = new System.Windows.Forms.Label();
            this.btnRSSStopStart = new System.Windows.Forms.Button();
            this.ssRSS = new System.Windows.Forms.StatusStrip();
            this.tsslRefreshedCountRSS = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNextRefreshRSS = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTotalDownloaded = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSourgeForge = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrRefreshOutlook = new System.Windows.Forms.Timer(this.components);
            this.btnCount = new System.Windows.Forms.Button();
            this.tmrSourgeForge = new System.Windows.Forms.Timer(this.components);
            this.btnFaceBook = new System.Windows.Forms.Button();
            this.btnFeedInfo = new System.Windows.Forms.Button();
            this.contextMenuStripOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnreadMails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRSSItems)).BeginInit();
            this.cntmsRSSColumns.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcMain)).BeginInit();
            this.spltcMain.Panel1.SuspendLayout();
            this.spltcMain.Panel2.SuspendLayout();
            this.spltcMain.SuspendLayout();
            this.ssOutlook.SuspendLayout();
            this.gbSpecificfeed.SuspendLayout();
            this.ssRSS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrRefreshRSS
            // 
            this.tmrRefreshRSS.Enabled = true;
            this.tmrRefreshRSS.Interval = 1000;
            this.tmrRefreshRSS.Tick += new System.EventHandler(this.tmrRefreshRSS_Tick);
            // 
            // notifyIconStatus
            // 
            this.notifyIconStatus.ContextMenuStrip = this.contextMenuStripOperations;
            this.notifyIconStatus.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconStatus.Icon")));
            this.notifyIconStatus.Visible = true;
            // 
            // contextMenuStripOperations
            // 
            this.contextMenuStripOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRefresh,
            this.tsmiSeperator1,
            this.tsmiClose});
            this.contextMenuStripOperations.Name = "contextMenuStripOperations";
            this.contextMenuStripOperations.Size = new System.Drawing.Size(127, 54);
            // 
            // tsmiRefresh
            // 
            this.tsmiRefresh.Name = "tsmiRefresh";
            this.tsmiRefresh.Size = new System.Drawing.Size(126, 22);
            this.tsmiRefresh.Text = "Refresh";
            // 
            // tsmiSeperator1
            // 
            this.tsmiSeperator1.Name = "tsmiSeperator1";
            this.tsmiSeperator1.Size = new System.Drawing.Size(123, 6);
            // 
            // tsmiClose
            // 
            this.tsmiClose.Image = global::Aggregator.GUI.Properties.Resources.cancelicon;
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(126, 22);
            this.tsmiClose.Text = "Close";
            // 
            // dgvUnreadMails
            // 
            this.dgvUnreadMails.AllowUserToAddRows = false;
            this.dgvUnreadMails.AllowUserToDeleteRows = false;
            this.dgvUnreadMails.AllowUserToOrderColumns = true;
            this.dgvUnreadMails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnreadMails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnreadMails.Location = new System.Drawing.Point(4, 51);
            this.dgvUnreadMails.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUnreadMails.Name = "dgvUnreadMails";
            this.dgvUnreadMails.ReadOnly = true;
            this.dgvUnreadMails.RowTemplate.Height = 24;
            this.dgvUnreadMails.Size = new System.Drawing.Size(1083, 66);
            this.dgvUnreadMails.TabIndex = 7;
            this.dgvUnreadMails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnreadMails_CellClick);
            this.dgvUnreadMails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnreadMails_CellDoubleClick);
            // 
            // dgvRSSItems
            // 
            this.dgvRSSItems.AllowUserToAddRows = false;
            this.dgvRSSItems.AllowUserToDeleteRows = false;
            this.dgvRSSItems.AllowUserToOrderColumns = true;
            this.dgvRSSItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRSSItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRSSItems.ContextMenuStrip = this.cntmsRSSColumns;
            this.dgvRSSItems.Location = new System.Drawing.Point(4, 137);
            this.dgvRSSItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRSSItems.Name = "dgvRSSItems";
            this.dgvRSSItems.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRSSItems.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRSSItems.RowTemplate.Height = 24;
            this.dgvRSSItems.Size = new System.Drawing.Size(1083, 65);
            this.dgvRSSItems.TabIndex = 8;
            this.dgvRSSItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRSSItems_CellClick);
            this.dgvRSSItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRSSItems_CellDoubleClick);
            // 
            // cntmsRSSColumns
            // 
            this.cntmsRSSColumns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateToolStripMenuItem,
            this.titleToolStripMenuItem,
            this.descriptionToolStripMenuItem,
            this.URLToolStripMenuItem,
            this.creatorToolStripMenuItem,
            this.contentToolStripMenuItem,
            this.readToolStripMenuItem,
            this.linkToolStripMenuItem,
            this.feedNameToolStripMenuItem,
            this.addedDateToolStripMenuItem});
            this.cntmsRSSColumns.Name = "cntmsRSSColumns";
            this.cntmsRSSColumns.Size = new System.Drawing.Size(154, 224);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.CheckOnClick = true;
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dateToolStripMenuItem.Text = "Date";
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.CheckOnClick = true;
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.titleToolStripMenuItem.Text = "Title";
            // 
            // descriptionToolStripMenuItem
            // 
            this.descriptionToolStripMenuItem.CheckOnClick = true;
            this.descriptionToolStripMenuItem.Name = "descriptionToolStripMenuItem";
            this.descriptionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.descriptionToolStripMenuItem.Text = "Description";
            this.descriptionToolStripMenuItem.Visible = false;
            // 
            // URLToolStripMenuItem
            // 
            this.URLToolStripMenuItem.CheckOnClick = true;
            this.URLToolStripMenuItem.Name = "URLToolStripMenuItem";
            this.URLToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.URLToolStripMenuItem.Text = "URL";
            this.URLToolStripMenuItem.Visible = false;
            // 
            // creatorToolStripMenuItem
            // 
            this.creatorToolStripMenuItem.CheckOnClick = true;
            this.creatorToolStripMenuItem.Name = "creatorToolStripMenuItem";
            this.creatorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.creatorToolStripMenuItem.Text = "Creator";
            // 
            // contentToolStripMenuItem
            // 
            this.contentToolStripMenuItem.CheckOnClick = true;
            this.contentToolStripMenuItem.Name = "contentToolStripMenuItem";
            this.contentToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.contentToolStripMenuItem.Text = "Content";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.CheckOnClick = true;
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.readToolStripMenuItem.Text = "Read";
            // 
            // linkToolStripMenuItem
            // 
            this.linkToolStripMenuItem.CheckOnClick = true;
            this.linkToolStripMenuItem.Name = "linkToolStripMenuItem";
            this.linkToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.linkToolStripMenuItem.Text = "Link";
            this.linkToolStripMenuItem.Visible = false;
            // 
            // feedNameToolStripMenuItem
            // 
            this.feedNameToolStripMenuItem.CheckOnClick = true;
            this.feedNameToolStripMenuItem.Name = "feedNameToolStripMenuItem";
            this.feedNameToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.feedNameToolStripMenuItem.Text = "Feed Name";
            // 
            // addedDateToolStripMenuItem
            // 
            this.addedDateToolStripMenuItem.CheckOnClick = true;
            this.addedDateToolStripMenuItem.Name = "addedDateToolStripMenuItem";
            this.addedDateToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addedDateToolStripMenuItem.Text = "Added Date";
            // 
            // chkbAllRSSItem
            // 
            this.chkbAllRSSItem.AutoSize = true;
            this.chkbAllRSSItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkbAllRSSItem.Checked = true;
            this.chkbAllRSSItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbAllRSSItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.chkbAllRSSItem.Location = new System.Drawing.Point(11, 32);
            this.chkbAllRSSItem.Margin = new System.Windows.Forms.Padding(4);
            this.chkbAllRSSItem.Name = "chkbAllRSSItem";
            this.chkbAllRSSItem.Size = new System.Drawing.Size(424, 26);
            this.chkbAllRSSItem.TabIndex = 9;
            this.chkbAllRSSItem.Text = "Show Unread RSS Feeds Only (All active feeds).";
            this.chkbAllRSSItem.UseVisualStyleBackColor = false;
            this.chkbAllRSSItem.Click += new System.EventHandler(this.chkbAllRSSItem_Click);
            // 
            // btnMarkAllRSSAsRead
            // 
            this.btnMarkAllRSSAsRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkAllRSSAsRead.Location = new System.Drawing.Point(753, 19);
            this.btnMarkAllRSSAsRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarkAllRSSAsRead.Name = "btnMarkAllRSSAsRead";
            this.btnMarkAllRSSAsRead.Size = new System.Drawing.Size(321, 43);
            this.btnMarkAllRSSAsRead.TabIndex = 10;
            this.btnMarkAllRSSAsRead.Text = "Mark all RSS Items as read";
            this.btnMarkAllRSSAsRead.UseVisualStyleBackColor = true;
            this.btnMarkAllRSSAsRead.Click += new System.EventHandler(this.btnMarkAllRSSAsRead_Click);
            // 
            // bwRefreshMail
            // 
            this.bwRefreshMail.WorkerReportsProgress = true;
            this.bwRefreshMail.WorkerSupportsCancellation = true;
            this.bwRefreshMail.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRefreshMail_DoWork);
            this.bwRefreshMail.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRefreshMail_RunWorkerCompleted);
            // 
            // bwRefreshRSS
            // 
            this.bwRefreshRSS.WorkerReportsProgress = true;
            this.bwRefreshRSS.WorkerSupportsCancellation = true;
            this.bwRefreshRSS.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRefreshRSS_DoWork);
            this.bwRefreshRSS.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRefreshRSS_RunWorkerCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiApplicationSettings,
            this.tsmiHelp,
            this.tsmiErrorsList,
            this.tsmiStatistics,
            this.tsmiViewLogOperations});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1090, 30);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRestart,
            this.tss1,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(54, 26);
            this.tsmiFile.Text = "File";
            // 
            // tsmiRestart
            // 
            this.tsmiRestart.Name = "tsmiRestart";
            this.tsmiRestart.Size = new System.Drawing.Size(136, 26);
            this.tsmiRestart.Text = "Restart";
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(133, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(136, 26);
            this.tsmiExit.Text = "Exit";
            // 
            // tsmiApplicationSettings
            // 
            this.tsmiApplicationSettings.Name = "tsmiApplicationSettings";
            this.tsmiApplicationSettings.Size = new System.Drawing.Size(183, 26);
            this.tsmiApplicationSettings.Text = "Application Settings";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVersion,
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(61, 26);
            this.tsmiHelp.Text = "Help";
            // 
            // tsmiVersion
            // 
            this.tsmiVersion.Name = "tsmiVersion";
            this.tsmiVersion.Size = new System.Drawing.Size(204, 26);
            this.tsmiVersion.Text = "Version History";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(204, 26);
            this.tsmiAbout.Text = "About";
            // 
            // tsmiErrorsList
            // 
            this.tsmiErrorsList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiErrorsList.Name = "tsmiErrorsList";
            this.tsmiErrorsList.Size = new System.Drawing.Size(108, 26);
            this.tsmiErrorsList.Text = "Errors List";
            // 
            // tsmiStatistics
            // 
            this.tsmiStatistics.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiStatistics.Name = "tsmiStatistics";
            this.tsmiStatistics.Size = new System.Drawing.Size(176, 26);
            this.tsmiStatistics.Text = "Networks Statistics";
            // 
            // tsmiViewLogOperations
            // 
            this.tsmiViewLogOperations.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiViewLogOperations.Name = "tsmiViewLogOperations";
            this.tsmiViewLogOperations.Size = new System.Drawing.Size(92, 26);
            this.tsmiViewLogOperations.Text = "RSS Log";
            // 
            // spltcMain
            // 
            this.spltcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.spltcMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spltcMain.Location = new System.Drawing.Point(0, 35);
            this.spltcMain.Margin = new System.Windows.Forms.Padding(4);
            this.spltcMain.Name = "spltcMain";
            this.spltcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltcMain.Panel1
            // 
            this.spltcMain.Panel1.Controls.Add(this.btnRefreshMail);
            this.spltcMain.Panel1.Controls.Add(this.btnMailReply);
            this.spltcMain.Panel1.Controls.Add(this.btnMailDelete);
            this.spltcMain.Panel1.Controls.Add(this.btnMailsStopStart);
            this.spltcMain.Panel1.Controls.Add(this.ssOutlook);
            this.spltcMain.Panel1.Controls.Add(this.btnMarkAllMailsAsRead);
            this.spltcMain.Panel1.Controls.Add(this.dgvUnreadMails);
            this.spltcMain.Panel1MinSize = 0;
            // 
            // spltcMain.Panel2
            // 
            this.spltcMain.Panel2.Controls.Add(this.btnRefreshNonActiveRSS);
            this.spltcMain.Panel2.Controls.Add(this.btnRefreshActiveRSS);
            this.spltcMain.Panel2.Controls.Add(this.gbSpecificfeed);
            this.spltcMain.Panel2.Controls.Add(this.btnRSSStopStart);
            this.spltcMain.Panel2.Controls.Add(this.ssRSS);
            this.spltcMain.Panel2.Controls.Add(this.dgvRSSItems);
            this.spltcMain.Panel2.Controls.Add(this.btnMarkAllRSSAsRead);
            this.spltcMain.Panel2.Controls.Add(this.chkbAllRSSItem);
            this.spltcMain.Panel2MinSize = 0;
            this.spltcMain.Size = new System.Drawing.Size(1090, 464);
            this.spltcMain.SplitterDistance = 153;
            this.spltcMain.SplitterWidth = 6;
            this.spltcMain.TabIndex = 12;
            // 
            // btnRefreshMail
            // 
            this.btnRefreshMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshMail.BackgroundImage = global::Aggregator.GUI.Properties.Resources.RefreshIconSmall;
            this.btnRefreshMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshMail.Location = new System.Drawing.Point(653, 6);
            this.btnRefreshMail.Name = "btnRefreshMail";
            this.btnRefreshMail.Size = new System.Drawing.Size(43, 43);
            this.btnRefreshMail.TabIndex = 20;
            this.btnRefreshMail.UseVisualStyleBackColor = true;
            // 
            // btnMailReply
            // 
            this.btnMailReply.BackgroundImage = global::Aggregator.GUI.Properties.Resources.reply;
            this.btnMailReply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMailReply.Location = new System.Drawing.Point(61, 6);
            this.btnMailReply.Name = "btnMailReply";
            this.btnMailReply.Size = new System.Drawing.Size(43, 43);
            this.btnMailReply.TabIndex = 15;
            this.btnMailReply.UseVisualStyleBackColor = true;
            this.btnMailReply.Click += new System.EventHandler(this.btnMailReply_Click);
            // 
            // btnMailDelete
            // 
            this.btnMailDelete.BackgroundImage = global::Aggregator.GUI.Properties.Resources.Deleteicon;
            this.btnMailDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMailDelete.Location = new System.Drawing.Point(12, 6);
            this.btnMailDelete.Name = "btnMailDelete";
            this.btnMailDelete.Size = new System.Drawing.Size(43, 43);
            this.btnMailDelete.TabIndex = 14;
            this.btnMailDelete.UseVisualStyleBackColor = true;
            this.btnMailDelete.Click += new System.EventHandler(this.btnMailDelete_Click);
            // 
            // btnMailsStopStart
            // 
            this.btnMailsStopStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMailsStopStart.BackgroundImage = global::Aggregator.GUI.Properties.Resources.Pauseicon;
            this.btnMailsStopStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMailsStopStart.Location = new System.Drawing.Point(702, 6);
            this.btnMailsStopStart.Name = "btnMailsStopStart";
            this.btnMailsStopStart.Size = new System.Drawing.Size(43, 43);
            this.btnMailsStopStart.TabIndex = 13;
            this.btnMailsStopStart.UseVisualStyleBackColor = true;
            this.btnMailsStopStart.Click += new System.EventHandler(this.btnMailsStopStart_Click);
            // 
            // ssOutlook
            // 
            this.ssOutlook.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ssOutlook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslRefreshedCountOutlook,
            this.tsslNextRefreshOutlook});
            this.ssOutlook.Location = new System.Drawing.Point(0, 126);
            this.ssOutlook.Name = "ssOutlook";
            this.ssOutlook.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this.ssOutlook.Size = new System.Drawing.Size(1090, 27);
            this.ssOutlook.TabIndex = 12;
            this.ssOutlook.Text = "statusStrip2";
            // 
            // tsslRefreshedCountOutlook
            // 
            this.tsslRefreshedCountOutlook.Name = "tsslRefreshedCountOutlook";
            this.tsslRefreshedCountOutlook.Size = new System.Drawing.Size(162, 22);
            this.tsslRefreshedCountOutlook.Text = "Refreshed Count: 0";
            // 
            // tsslNextRefreshOutlook
            // 
            this.tsslNextRefreshOutlook.Name = "tsslNextRefreshOutlook";
            this.tsslNextRefreshOutlook.Size = new System.Drawing.Size(132, 22);
            this.tsslNextRefreshOutlook.Text = "Next refresh at:";
            // 
            // btnMarkAllMailsAsRead
            // 
            this.btnMarkAllMailsAsRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkAllMailsAsRead.Location = new System.Drawing.Point(753, 6);
            this.btnMarkAllMailsAsRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarkAllMailsAsRead.Name = "btnMarkAllMailsAsRead";
            this.btnMarkAllMailsAsRead.Size = new System.Drawing.Size(321, 43);
            this.btnMarkAllMailsAsRead.TabIndex = 11;
            this.btnMarkAllMailsAsRead.Text = "Mark all mails as read";
            this.btnMarkAllMailsAsRead.UseVisualStyleBackColor = true;
            this.btnMarkAllMailsAsRead.Click += new System.EventHandler(this.btnMarkAllMailsAsRead_Click);
            // 
            // btnRefreshNonActiveRSS
            // 
            this.btnRefreshNonActiveRSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshNonActiveRSS.BackgroundImage = global::Aggregator.GUI.Properties.Resources.RefreshIconSmallgray;
            this.btnRefreshNonActiveRSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshNonActiveRSS.Location = new System.Drawing.Point(604, 19);
            this.btnRefreshNonActiveRSS.Name = "btnRefreshNonActiveRSS";
            this.btnRefreshNonActiveRSS.Size = new System.Drawing.Size(43, 43);
            this.btnRefreshNonActiveRSS.TabIndex = 20;
            this.btnRefreshNonActiveRSS.UseVisualStyleBackColor = true;
            // 
            // btnRefreshActiveRSS
            // 
            this.btnRefreshActiveRSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshActiveRSS.BackgroundImage = global::Aggregator.GUI.Properties.Resources.RefreshIconSmall;
            this.btnRefreshActiveRSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshActiveRSS.Location = new System.Drawing.Point(653, 19);
            this.btnRefreshActiveRSS.Name = "btnRefreshActiveRSS";
            this.btnRefreshActiveRSS.Size = new System.Drawing.Size(43, 43);
            this.btnRefreshActiveRSS.TabIndex = 19;
            this.btnRefreshActiveRSS.UseVisualStyleBackColor = true;
            // 
            // gbSpecificfeed
            // 
            this.gbSpecificfeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSpecificfeed.Controls.Add(this.btnFeedInfo);
            this.gbSpecificfeed.Controls.Add(this.cbFeeds);
            this.gbSpecificfeed.Controls.Add(this.btnRefreshFromWeb);
            this.gbSpecificfeed.Controls.Add(this.lblShowSpecificFeed);
            this.gbSpecificfeed.Controls.Add(this.btnLoadCurrentFeed);
            this.gbSpecificfeed.Controls.Add(this.lblIsActiveFeed);
            this.gbSpecificfeed.Location = new System.Drawing.Point(4, 65);
            this.gbSpecificfeed.Name = "gbSpecificfeed";
            this.gbSpecificfeed.Size = new System.Drawing.Size(1083, 65);
            this.gbSpecificfeed.TabIndex = 18;
            this.gbSpecificfeed.TabStop = false;
            this.gbSpecificfeed.Text = "Show Specific Feed:";
            // 
            // cbFeeds
            // 
            this.cbFeeds.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFeeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFeeds.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbFeeds.FormattingEnabled = true;
            this.cbFeeds.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbFeeds.Location = new System.Drawing.Point(130, 23);
            this.cbFeeds.Margin = new System.Windows.Forms.Padding(4);
            this.cbFeeds.Name = "cbFeeds";
            this.cbFeeds.Size = new System.Drawing.Size(385, 31);
            this.cbFeeds.TabIndex = 13;
            this.cbFeeds.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbFeeds_DrawItem);
            // 
            // btnRefreshFromWeb
            // 
            this.btnRefreshFromWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshFromWeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefreshFromWeb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshFromWeb.Location = new System.Drawing.Point(850, 23);
            this.btnRefreshFromWeb.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshFromWeb.Name = "btnRefreshFromWeb";
            this.btnRefreshFromWeb.Size = new System.Drawing.Size(183, 30);
            this.btnRefreshFromWeb.TabIndex = 17;
            this.btnRefreshFromWeb.Text = "Refresh from web";
            this.btnRefreshFromWeb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshFromWeb.UseVisualStyleBackColor = true;
            // 
            // lblShowSpecificFeed
            // 
            this.lblShowSpecificFeed.AutoEllipsis = true;
            this.lblShowSpecificFeed.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblShowSpecificFeed.Location = new System.Drawing.Point(9, 23);
            this.lblShowSpecificFeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowSpecificFeed.Name = "lblShowSpecificFeed";
            this.lblShowSpecificFeed.Size = new System.Drawing.Size(124, 30);
            this.lblShowSpecificFeed.TabIndex = 13;
            this.lblShowSpecificFeed.Text = "Select Feed:";
            this.lblShowSpecificFeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLoadCurrentFeed
            // 
            this.btnLoadCurrentFeed.Location = new System.Drawing.Point(523, 23);
            this.btnLoadCurrentFeed.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadCurrentFeed.Name = "btnLoadCurrentFeed";
            this.btnLoadCurrentFeed.Size = new System.Drawing.Size(131, 30);
            this.btnLoadCurrentFeed.TabIndex = 14;
            this.btnLoadCurrentFeed.Text = "Load Cache";
            this.btnLoadCurrentFeed.UseVisualStyleBackColor = true;
            // 
            // lblIsActiveFeed
            // 
            this.lblIsActiveFeed.AutoEllipsis = true;
            this.lblIsActiveFeed.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblIsActiveFeed.Location = new System.Drawing.Point(662, 23);
            this.lblIsActiveFeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsActiveFeed.Name = "lblIsActiveFeed";
            this.lblIsActiveFeed.Size = new System.Drawing.Size(179, 30);
            this.lblIsActiveFeed.TabIndex = 18;
            this.lblIsActiveFeed.Text = "Active feed:";
            this.lblIsActiveFeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRSSStopStart
            // 
            this.btnRSSStopStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRSSStopStart.BackgroundImage = global::Aggregator.GUI.Properties.Resources.Pauseicon;
            this.btnRSSStopStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRSSStopStart.Location = new System.Drawing.Point(702, 19);
            this.btnRSSStopStart.Name = "btnRSSStopStart";
            this.btnRSSStopStart.Size = new System.Drawing.Size(43, 43);
            this.btnRSSStopStart.TabIndex = 15;
            this.btnRSSStopStart.UseVisualStyleBackColor = true;
            this.btnRSSStopStart.Click += new System.EventHandler(this.btnRSSStopStart_Click);
            // 
            // ssRSS
            // 
            this.ssRSS.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ssRSS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslRefreshedCountRSS,
            this.tsslNextRefreshRSS,
            this.tsslTotalDownloaded,
            this.tsslSourgeForge});
            this.ssRSS.Location = new System.Drawing.Point(0, 278);
            this.ssRSS.Name = "ssRSS";
            this.ssRSS.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this.ssRSS.Size = new System.Drawing.Size(1090, 27);
            this.ssRSS.TabIndex = 11;
            this.ssRSS.Text = "statusStrip1";
            // 
            // tsslRefreshedCountRSS
            // 
            this.tsslRefreshedCountRSS.Name = "tsslRefreshedCountRSS";
            this.tsslRefreshedCountRSS.Size = new System.Drawing.Size(197, 22);
            this.tsslRefreshedCountRSS.Text = "Refreshed RSSCount: 0";
            // 
            // tsslNextRefreshRSS
            // 
            this.tsslNextRefreshRSS.Name = "tsslNextRefreshRSS";
            this.tsslNextRefreshRSS.Size = new System.Drawing.Size(132, 22);
            this.tsslNextRefreshRSS.Text = "Next refresh at:";
            // 
            // tsslTotalDownloaded
            // 
            this.tsslTotalDownloaded.Name = "tsslTotalDownloaded";
            this.tsslTotalDownloaded.Size = new System.Drawing.Size(211, 22);
            this.tsslTotalDownloaded.Text = "00 Total KB downloaded";
            // 
            // tsslSourgeForge
            // 
            this.tsslSourgeForge.Name = "tsslSourgeForge";
            this.tsslSourgeForge.Size = new System.Drawing.Size(0, 22);
            // 
            // tmrRefreshOutlook
            // 
            this.tmrRefreshOutlook.Enabled = true;
            this.tmrRefreshOutlook.Interval = 1000;
            this.tmrRefreshOutlook.Tick += new System.EventHandler(this.tmrRefreshOutlook_Tick);
            // 
            // btnCount
            // 
            this.btnCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCount.Location = new System.Drawing.Point(996, 478);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(42, 33);
            this.btnCount.TabIndex = 15;
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Visible = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // tmrSourgeForge
            // 
            this.tmrSourgeForge.Interval = 1000;
            this.tmrSourgeForge.Tick += new System.EventHandler(this.tmrSourgeForge_Tick);
            // 
            // btnFaceBook
            // 
            this.btnFaceBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFaceBook.BackgroundImage = global::Aggregator.GUI.Properties.Resources.facebookicon;
            this.btnFaceBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFaceBook.Location = new System.Drawing.Point(1044, 478);
            this.btnFaceBook.Name = "btnFaceBook";
            this.btnFaceBook.Size = new System.Drawing.Size(43, 33);
            this.btnFaceBook.TabIndex = 14;
            this.btnFaceBook.UseVisualStyleBackColor = true;
            // 
            // btnFeedInfo
            // 
            this.btnFeedInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFeedInfo.BackgroundImage = global::Aggregator.GUI.Properties.Resources.rssfeedinfo;
            this.btnFeedInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFeedInfo.Location = new System.Drawing.Point(1037, 17);
            this.btnFeedInfo.Name = "btnFeedInfo";
            this.btnFeedInfo.Size = new System.Drawing.Size(43, 43);
            this.btnFeedInfo.TabIndex = 21;
            this.btnFeedInfo.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 512);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnFaceBook);
            this.Controls.Add(this.spltcMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LB RSS Desktop Aggregator";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStripOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnreadMails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRSSItems)).EndInit();
            this.cntmsRSSColumns.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.spltcMain.Panel1.ResumeLayout(false);
            this.spltcMain.Panel1.PerformLayout();
            this.spltcMain.Panel2.ResumeLayout(false);
            this.spltcMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcMain)).EndInit();
            this.spltcMain.ResumeLayout(false);
            this.ssOutlook.ResumeLayout(false);
            this.ssOutlook.PerformLayout();
            this.gbSpecificfeed.ResumeLayout(false);
            this.ssRSS.ResumeLayout(false);
            this.ssRSS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrRefreshRSS;
        private System.Windows.Forms.NotifyIcon notifyIconStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOperations;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
        private System.Windows.Forms.ToolStripSeparator tsmiSeperator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.DataGridView dgvUnreadMails;
        private System.Windows.Forms.DataGridView dgvRSSItems;
        private System.Windows.Forms.CheckBox chkbAllRSSItem;
        private System.Windows.Forms.Button btnMarkAllRSSAsRead;
        private System.ComponentModel.BackgroundWorker bwRefreshMail;
        private System.ComponentModel.BackgroundWorker bwRefreshRSS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiApplicationSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.SplitContainer spltcMain;
        private System.Windows.Forms.Button btnMarkAllMailsAsRead;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripMenuItem tsmiErrorsList;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiVersion;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.StatusStrip ssRSS;
        private System.Windows.Forms.ToolStripStatusLabel tsslRefreshedCountRSS;
        private System.Windows.Forms.ToolStripStatusLabel tsslNextRefreshRSS;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalDownloaded;
        private System.Windows.Forms.StatusStrip ssOutlook;
        private System.Windows.Forms.ToolStripStatusLabel tsslRefreshedCountOutlook;
        private System.Windows.Forms.ToolStripStatusLabel tsslNextRefreshOutlook;
        private System.Windows.Forms.Timer tmrRefreshOutlook;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatistics;
        private System.Windows.Forms.Label lblShowSpecificFeed;
        private System.Windows.Forms.Button btnLoadCurrentFeed;
        private System.Windows.Forms.ComboBox cbFeeds;
        private System.Windows.Forms.Button btnMailsStopStart;
        private System.Windows.Forms.Button btnRSSStopStart;
        private System.Windows.Forms.Button btnFaceBook;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Timer tmrSourgeForge;
        private System.Windows.Forms.ToolStripStatusLabel tsslSourgeForge;
        private System.Windows.Forms.GroupBox gbSpecificfeed;
        private System.Windows.Forms.Label lblIsActiveFeed;
        private System.Windows.Forms.Button btnRefreshFromWeb;
        private System.Windows.Forms.Button btnMailDelete;
        private System.Windows.Forms.Button btnMailReply;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewLogOperations;
        private System.Windows.Forms.ToolStripMenuItem tsmiRestart;
        private System.Windows.Forms.Button btnRefreshActiveRSS;
        private System.Windows.Forms.Button btnRefreshNonActiveRSS;
        private System.Windows.Forms.Button btnRefreshMail;
        private System.Windows.Forms.ContextMenuStrip cntmsRSSColumns;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem URLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addedDateToolStripMenuItem;
        private System.Windows.Forms.Button btnFeedInfo;
    }
}