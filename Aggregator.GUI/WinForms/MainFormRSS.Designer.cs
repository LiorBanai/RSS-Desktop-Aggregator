namespace Aggregator.GUI.WinForms
{
    partial class MainFormRSS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormRSS));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("All Feeds", 0, 0);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Active Feeds", 0, 0);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Non Active Feeds", 1, 1);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Disabled Feeds");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Privates Feeds");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Other Feeds (Not in category)");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node4");
            this.tmrRefreshRSS = new System.Windows.Forms.Timer(this.components);
            this.notifyIconStatus = new System.Windows.Forms.NotifyIcon(this.components);
            this.cntmsOperations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
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
            this.followUpPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMarkAllRSSAsRead = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOutlook = new System.Windows.Forms.ToolStripMenuItem();
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
            this.spltcFeeds = new System.Windows.Forms.SplitContainer();
            this.olvPosts = new BrightIdeasSoftware.ObjectListView();
            this.columnFeed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnHeaderTitle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnPubDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvRead = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnAddedDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnHeader16 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.chkbGroupResults = new System.Windows.Forms.CheckBox();
            this.chkbWhenToMarkAsRead = new System.Windows.Forms.CheckBox();
            this.tsCurrentFeed = new System.Windows.Forms.ToolStrip();
            this.tsbtnFeedStatus = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFeedInformation = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnRefreshCurrentFeeds = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFollowupPostMark = new System.Windows.Forms.ToolStripButton();
            this.tstxtbSearchFeed = new System.Windows.Forms.ToolStripTextBox();
            this.chkbUnreadposts = new System.Windows.Forms.CheckBox();
            this.webbPostViewer = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSaveToHTML = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbntHideShowPost = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCheckAsRead = new System.Windows.Forms.ToolStripButton();
            this.tsbtnBack = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNext = new System.Windows.Forms.ToolStripButton();
            this.ssRSS = new System.Windows.Forms.StatusStrip();
            this.tsslUseActive = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRefreshedCountRSS = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNextRefreshRSS = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTotalDownloaded = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSourgeForge = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblRecordsInSearch = new System.Windows.Forms.ToolStripStatusLabel();
            this.spltcMain = new System.Windows.Forms.SplitContainer();
            this.spltcLeft = new System.Windows.Forms.SplitContainer();
            this.tvFeedsGroup = new System.Windows.Forms.TreeView();
            this.imglstFeedGroup = new System.Windows.Forms.ImageList(this.components);
            this.lblSelectedGroup = new System.Windows.Forms.Label();
            this.tsFeedsGroup = new System.Windows.Forms.ToolStrip();
            this.tsbFeedsGroupRefresh = new System.Windows.Forms.ToolStripButton();
            this.tvFeeds = new System.Windows.Forms.TreeView();
            this.imglstFeeds = new System.Windows.Forms.ImageList(this.components);
            this.tcFeeds = new System.Windows.Forms.TabControl();
            this.tpFeeds = new System.Windows.Forms.TabPage();
            this.tpLog = new System.Windows.Forms.TabPage();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.rtxbMsg = new System.Windows.Forms.RichTextBox();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbtnNewFeed = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnRSSStopStart = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnRefreshActive = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRefreshNonActive = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRefreshGroup = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFacebookNewsFeedPage = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFacebook = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSettings = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExportFeed = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnFavoriteFeeds = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFollowUpPosts = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tmrUser = new System.Windows.Forms.Timer(this.components);
            this.cntmsOperations.SuspendLayout();
            this.cntmsRSSColumns.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcFeeds)).BeginInit();
            this.spltcFeeds.Panel1.SuspendLayout();
            this.spltcFeeds.Panel2.SuspendLayout();
            this.spltcFeeds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPosts)).BeginInit();
            this.tsCurrentFeed.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ssRSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcMain)).BeginInit();
            this.spltcMain.Panel1.SuspendLayout();
            this.spltcMain.Panel2.SuspendLayout();
            this.spltcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcLeft)).BeginInit();
            this.spltcLeft.Panel1.SuspendLayout();
            this.spltcLeft.Panel2.SuspendLayout();
            this.spltcLeft.SuspendLayout();
            this.tsFeedsGroup.SuspendLayout();
            this.tcFeeds.SuspendLayout();
            this.tpFeeds.SuspendLayout();
            this.tpLog.SuspendLayout();
            this.tsMain.SuspendLayout();
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
            this.notifyIconStatus.ContextMenuStrip = this.cntmsOperations;
            this.notifyIconStatus.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconStatus.Icon")));
            this.notifyIconStatus.Visible = true;
            // 
            // cntmsOperations
            // 
            this.cntmsOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRefresh,
            this.tsmiSeperator1,
            this.tsmiClose});
            this.cntmsOperations.Name = "contextMenuStripOperations";
            this.cntmsOperations.Size = new System.Drawing.Size(127, 54);
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
            this.addedDateToolStripMenuItem,
            this.followUpPostToolStripMenuItem});
            this.cntmsRSSColumns.Name = "cntmsRSSColumns";
            this.cntmsRSSColumns.Size = new System.Drawing.Size(171, 246);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.CheckOnClick = true;
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.dateToolStripMenuItem.Text = "Date";
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.CheckOnClick = true;
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.titleToolStripMenuItem.Text = "Title";
            // 
            // descriptionToolStripMenuItem
            // 
            this.descriptionToolStripMenuItem.CheckOnClick = true;
            this.descriptionToolStripMenuItem.Name = "descriptionToolStripMenuItem";
            this.descriptionToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.descriptionToolStripMenuItem.Text = "Description";
            this.descriptionToolStripMenuItem.Visible = false;
            // 
            // URLToolStripMenuItem
            // 
            this.URLToolStripMenuItem.CheckOnClick = true;
            this.URLToolStripMenuItem.Name = "URLToolStripMenuItem";
            this.URLToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.URLToolStripMenuItem.Text = "URL";
            this.URLToolStripMenuItem.Visible = false;
            // 
            // creatorToolStripMenuItem
            // 
            this.creatorToolStripMenuItem.CheckOnClick = true;
            this.creatorToolStripMenuItem.Name = "creatorToolStripMenuItem";
            this.creatorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.creatorToolStripMenuItem.Text = "Creator";
            // 
            // contentToolStripMenuItem
            // 
            this.contentToolStripMenuItem.CheckOnClick = true;
            this.contentToolStripMenuItem.Name = "contentToolStripMenuItem";
            this.contentToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.contentToolStripMenuItem.Text = "Content";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.CheckOnClick = true;
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.readToolStripMenuItem.Text = "Read";
            // 
            // linkToolStripMenuItem
            // 
            this.linkToolStripMenuItem.CheckOnClick = true;
            this.linkToolStripMenuItem.Name = "linkToolStripMenuItem";
            this.linkToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.linkToolStripMenuItem.Text = "Link";
            this.linkToolStripMenuItem.Visible = false;
            // 
            // feedNameToolStripMenuItem
            // 
            this.feedNameToolStripMenuItem.CheckOnClick = true;
            this.feedNameToolStripMenuItem.Name = "feedNameToolStripMenuItem";
            this.feedNameToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.feedNameToolStripMenuItem.Text = "Feed Name";
            // 
            // addedDateToolStripMenuItem
            // 
            this.addedDateToolStripMenuItem.CheckOnClick = true;
            this.addedDateToolStripMenuItem.Name = "addedDateToolStripMenuItem";
            this.addedDateToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addedDateToolStripMenuItem.Text = "Added Date";
            // 
            // followUpPostToolStripMenuItem
            // 
            this.followUpPostToolStripMenuItem.CheckOnClick = true;
            this.followUpPostToolStripMenuItem.Name = "followUpPostToolStripMenuItem";
            this.followUpPostToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.followUpPostToolStripMenuItem.Text = "Follow Up Post";
            // 
            // btnMarkAllRSSAsRead
            // 
            this.btnMarkAllRSSAsRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkAllRSSAsRead.Location = new System.Drawing.Point(715, 72);
            this.btnMarkAllRSSAsRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarkAllRSSAsRead.Name = "btnMarkAllRSSAsRead";
            this.btnMarkAllRSSAsRead.Size = new System.Drawing.Size(248, 43);
            this.btnMarkAllRSSAsRead.TabIndex = 10;
            this.btnMarkAllRSSAsRead.Text = "Mark all RSS Items as read";
            this.btnMarkAllRSSAsRead.UseVisualStyleBackColor = true;
            this.btnMarkAllRSSAsRead.Click += new System.EventHandler(this.btnMarkAllRSSAsRead_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiApplicationSettings,
            this.tsmiHelp,
            this.tsmiErrorsList,
            this.tsmiStatistics,
            this.tsmiViewLogOperations});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(1230, 30);
            this.mainMenuStrip.TabIndex = 11;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOutlook,
            this.tsmiRestart,
            this.tss1,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(54, 26);
            this.tsmiFile.Text = "File";
            // 
            // tsmiOutlook
            // 
            this.tsmiOutlook.Name = "tsmiOutlook";
            this.tsmiOutlook.Size = new System.Drawing.Size(242, 26);
            this.tsmiOutlook.Text = "Open Outlook  Form";
            // 
            // tsmiRestart
            // 
            this.tsmiRestart.Name = "tsmiRestart";
            this.tsmiRestart.Size = new System.Drawing.Size(242, 26);
            this.tsmiRestart.Text = "Restart";
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(239, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(242, 26);
            this.tsmiExit.Text = "Exit";
            // 
            // tsmiApplicationSettings
            // 
            this.tsmiApplicationSettings.Name = "tsmiApplicationSettings";
            this.tsmiApplicationSettings.Size = new System.Drawing.Size(256, 26);
            this.tsmiApplicationSettings.Text = "Application and RSS Settings";
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
            // spltcFeeds
            // 
            this.spltcFeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltcFeeds.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spltcFeeds.Location = new System.Drawing.Point(3, 3);
            this.spltcFeeds.Margin = new System.Windows.Forms.Padding(4);
            this.spltcFeeds.Name = "spltcFeeds";
            this.spltcFeeds.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltcFeeds.Panel1
            // 
            this.spltcFeeds.Panel1.AutoScroll = true;
            this.spltcFeeds.Panel1.Controls.Add(this.olvPosts);
            this.spltcFeeds.Panel1.Controls.Add(this.chkbGroupResults);
            this.spltcFeeds.Panel1.Controls.Add(this.chkbWhenToMarkAsRead);
            this.spltcFeeds.Panel1.Controls.Add(this.tsCurrentFeed);
            this.spltcFeeds.Panel1.Controls.Add(this.chkbUnreadposts);
            this.spltcFeeds.Panel1.Controls.Add(this.btnMarkAllRSSAsRead);
            this.spltcFeeds.Panel1MinSize = 275;
            // 
            // spltcFeeds.Panel2
            // 
            this.spltcFeeds.Panel2.AutoScroll = true;
            this.spltcFeeds.Panel2.Controls.Add(this.webbPostViewer);
            this.spltcFeeds.Panel2.Controls.Add(this.toolStrip1);
            this.spltcFeeds.Panel2MinSize = 0;
            this.spltcFeeds.Size = new System.Drawing.Size(972, 606);
            this.spltcFeeds.SplitterDistance = 275;
            this.spltcFeeds.SplitterWidth = 6;
            this.spltcFeeds.TabIndex = 12;
            // 
            // olvPosts
            // 
            this.olvPosts.AllColumns.Add(this.columnFeed);
            this.olvPosts.AllColumns.Add(this.columnHeaderTitle);
            this.olvPosts.AllColumns.Add(this.columnPubDate);
            this.olvPosts.AllColumns.Add(this.olvRead);
            this.olvPosts.AllColumns.Add(this.columnAddedDate);
            this.olvPosts.AllColumns.Add(this.columnHeader16);
            this.olvPosts.AllowColumnReorder = true;
            this.olvPosts.AllowDrop = true;
            this.olvPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.olvPosts.CheckedAspectName = "Read";
            this.olvPosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFeed,
            this.columnHeaderTitle,
            this.columnPubDate,
            this.olvRead,
            this.columnAddedDate,
            this.columnHeader16});
            this.olvPosts.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPosts.FullRowSelect = true;
            this.olvPosts.GridLines = true;
            this.olvPosts.HeaderUsesThemes = false;
            this.olvPosts.HeaderWordWrap = true;
            this.olvPosts.HideSelection = false;
            this.olvPosts.IncludeColumnHeadersInCopy = true;
            this.olvPosts.Location = new System.Drawing.Point(6, 160);
            this.olvPosts.Margin = new System.Windows.Forms.Padding(4);
            this.olvPosts.MultiSelect = false;
            this.olvPosts.Name = "olvPosts";
            this.olvPosts.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.olvPosts.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.olvPosts.OverlayText.BorderWidth = 2F;
            this.olvPosts.OverlayText.Rotation = -20;
            this.olvPosts.OverlayText.Text = "";
            this.olvPosts.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvPosts.ShowCommandMenuOnRightClick = true;
            this.olvPosts.ShowGroups = false;
            this.olvPosts.ShowImagesOnSubItems = true;
            this.olvPosts.ShowItemCountOnGroups = true;
            this.olvPosts.ShowItemToolTips = true;
            this.olvPosts.Size = new System.Drawing.Size(962, 108);
            this.olvPosts.SortGroupItemsByPrimaryColumn = false;
            this.olvPosts.TabIndex = 28;
            this.olvPosts.UseAlternatingBackColors = true;
            this.olvPosts.UseCellFormatEvents = true;
            this.olvPosts.UseCompatibleStateImageBehavior = false;
            this.olvPosts.UseFiltering = true;
            this.olvPosts.UseHotItem = true;
            this.olvPosts.UseSubItemCheckBoxes = true;
            this.olvPosts.View = System.Windows.Forms.View.Details;
            this.olvPosts.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvPosts_FormatCell);
            this.olvPosts.SelectedIndexChanged += new System.EventHandler(this.olvPosts_SelectedIndexChanged);
            this.olvPosts.DoubleClick += new System.EventHandler(this.olvPosts_DoubleClick);
            this.olvPosts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.olvPosts_KeyPress);
            // 
            // columnFeed
            // 
            this.columnFeed.AspectName = "FeedName";
            this.columnFeed.HeaderForeColor = System.Drawing.Color.Black;
            this.columnFeed.Text = "Feed Name";
            this.columnFeed.Width = 150;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.AspectName = "Title";
            this.columnHeaderTitle.FillsFreeSpace = true;
            this.columnHeaderTitle.MinimumWidth = 100;
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.ToolTipText = "";
            this.columnHeaderTitle.Width = 140;
            this.columnHeaderTitle.WordWrap = true;
            // 
            // columnPubDate
            // 
            this.columnPubDate.AspectName = "Date";
            this.columnPubDate.Text = "Published Date";
            this.columnPubDate.Width = 150;
            // 
            // olvRead
            // 
            this.olvRead.AspectName = "Read";
            this.olvRead.CheckBoxes = true;
            this.olvRead.HeaderImageKey = "";
            this.olvRead.IsTileViewColumn = true;
            this.olvRead.Text = "Read";
            this.olvRead.Width = 74;
            // 
            // columnAddedDate
            // 
            this.columnAddedDate.AspectName = "AddedDate";
            this.columnAddedDate.AspectToStringFormat = "";
            this.columnAddedDate.Text = "Added Date";
            this.columnAddedDate.Width = 121;
            // 
            // columnHeader16
            // 
            this.columnHeader16.AspectName = "FollowUp";
            this.columnHeader16.AspectToStringFormat = "";
            this.columnHeader16.CheckBoxes = true;
            this.columnHeader16.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Text = "Later Read?";
            this.columnHeader16.Width = 100;
            // 
            // chkbGroupResults
            // 
            this.chkbGroupResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbGroupResults.AutoEllipsis = true;
            this.chkbGroupResults.Location = new System.Drawing.Point(10, 126);
            this.chkbGroupResults.Name = "chkbGroupResults";
            this.chkbGroupResults.Size = new System.Drawing.Size(696, 27);
            this.chkbGroupResults.TabIndex = 27;
            this.chkbGroupResults.Text = "Group Results (Click on a column to group by)";
            this.chkbGroupResults.UseVisualStyleBackColor = true;
            this.chkbGroupResults.Click += new System.EventHandler(this.chkbGroupResults_Click);
            // 
            // chkbWhenToMarkAsRead
            // 
            this.chkbWhenToMarkAsRead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbWhenToMarkAsRead.AutoEllipsis = true;
            this.chkbWhenToMarkAsRead.Location = new System.Drawing.Point(10, 92);
            this.chkbWhenToMarkAsRead.Name = "chkbWhenToMarkAsRead";
            this.chkbWhenToMarkAsRead.Size = new System.Drawing.Size(696, 32);
            this.chkbWhenToMarkAsRead.TabIndex = 21;
            this.chkbWhenToMarkAsRead.Text = "Mark a post as read as soon as it viewed";
            this.chkbWhenToMarkAsRead.UseVisualStyleBackColor = true;
            // 
            // tsCurrentFeed
            // 
            this.tsCurrentFeed.ImageScalingSize = new System.Drawing.Size(46, 46);
            this.tsCurrentFeed.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnFeedStatus,
            this.tsbtnFeedInformation,
            this.tsSeparator5,
            this.tsbtnRefreshCurrentFeeds,
            this.tsbtnFollowupPostMark,
            this.tstxtbSearchFeed});
            this.tsCurrentFeed.Location = new System.Drawing.Point(0, 0);
            this.tsCurrentFeed.Name = "tsCurrentFeed";
            this.tsCurrentFeed.Size = new System.Drawing.Size(972, 53);
            this.tsCurrentFeed.TabIndex = 21;
            this.tsCurrentFeed.Text = "toolStrip2";
            // 
            // tsbtnFeedStatus
            // 
            this.tsbtnFeedStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFeedStatus.Image = global::Aggregator.GUI.Properties.Resources.buttonGray;
            this.tsbtnFeedStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFeedStatus.Name = "tsbtnFeedStatus";
            this.tsbtnFeedStatus.Size = new System.Drawing.Size(50, 50);
            this.tsbtnFeedStatus.Text = "Feed Status";
            this.tsbtnFeedStatus.Click += new System.EventHandler(this.tsbtnFeedStatus_Click);
            // 
            // tsbtnFeedInformation
            // 
            this.tsbtnFeedInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFeedInformation.Image = global::Aggregator.GUI.Properties.Resources.rssfeedinfo;
            this.tsbtnFeedInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFeedInformation.Name = "tsbtnFeedInformation";
            this.tsbtnFeedInformation.Size = new System.Drawing.Size(50, 50);
            this.tsbtnFeedInformation.Text = "Feed information";
            this.tsbtnFeedInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnFeedInformation.Click += new System.EventHandler(this.tsbtnFeedInformation_Click);
            // 
            // tsSeparator5
            // 
            this.tsSeparator5.Name = "tsSeparator5";
            this.tsSeparator5.Size = new System.Drawing.Size(6, 53);
            // 
            // tsbtnRefreshCurrentFeeds
            // 
            this.tsbtnRefreshCurrentFeeds.Image = global::Aggregator.GUI.Properties.Resources.refresh;
            this.tsbtnRefreshCurrentFeeds.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefreshCurrentFeeds.Name = "tsbtnRefreshCurrentFeeds";
            this.tsbtnRefreshCurrentFeeds.Size = new System.Drawing.Size(260, 50);
            this.tsbtnRefreshCurrentFeeds.Text = "Refresh Current selected feeds";
            this.tsbtnRefreshCurrentFeeds.Click += new System.EventHandler(this.tsbtnRefreshCurrentFeeds_Click);
            // 
            // tsbtnFollowupPostMark
            // 
            this.tsbtnFollowupPostMark.Image = global::Aggregator.GUI.Properties.Resources.hearth;
            this.tsbtnFollowupPostMark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFollowupPostMark.Name = "tsbtnFollowupPostMark";
            this.tsbtnFollowupPostMark.Size = new System.Drawing.Size(214, 50);
            this.tsbtnFollowupPostMark.Text = "mark post for later read";
            this.tsbtnFollowupPostMark.Click += new System.EventHandler(this.tsbtnFollowupPostMark_Click);
            // 
            // tstxtbSearchFeed
            // 
            this.tstxtbSearchFeed.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstxtbSearchFeed.Name = "tstxtbSearchFeed";
            this.tstxtbSearchFeed.Size = new System.Drawing.Size(250, 53);
            this.tstxtbSearchFeed.Text = "search";
            this.tstxtbSearchFeed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tstxtbSearchFeed_KeyUp);
            this.tstxtbSearchFeed.Click += new System.EventHandler(this.tstxtbSearchFeed_Click);
            // 
            // chkbUnreadposts
            // 
            this.chkbUnreadposts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbUnreadposts.AutoEllipsis = true;
            this.chkbUnreadposts.Checked = true;
            this.chkbUnreadposts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbUnreadposts.Location = new System.Drawing.Point(10, 61);
            this.chkbUnreadposts.Name = "chkbUnreadposts";
            this.chkbUnreadposts.Size = new System.Drawing.Size(696, 29);
            this.chkbUnreadposts.TabIndex = 20;
            this.chkbUnreadposts.Text = "Show unread posts only";
            this.chkbUnreadposts.UseVisualStyleBackColor = true;
            this.chkbUnreadposts.CheckedChanged += new System.EventHandler(this.chkbUnreadposts_CheckedChanged);
            // 
            // webbPostViewer
            // 
            this.webbPostViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webbPostViewer.Location = new System.Drawing.Point(0, 39);
            this.webbPostViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.webbPostViewer.Name = "webbPostViewer";
            this.webbPostViewer.ScriptErrorsSuppressed = true;
            this.webbPostViewer.Size = new System.Drawing.Size(972, 288);
            this.webbPostViewer.TabIndex = 1;
            this.webbPostViewer.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webbPostViewer_DocumentCompleted);
            this.webbPostViewer.NewWindow += new System.ComponentModel.CancelEventHandler(this.webbPostViewer_NewWindow);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSaveToHTML,
            this.toolStripSeparator1,
            this.tsbntHideShowPost,
            this.tsbtnCheckAsRead,
            this.tsbtnBack,
            this.tsbtnNext});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(972, 39);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "Current Posts";
            // 
            // tsbtnSaveToHTML
            // 
            this.tsbtnSaveToHTML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSaveToHTML.Image = global::Aggregator.GUI.Properties.Resources.htmliconsmall;
            this.tsbtnSaveToHTML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSaveToHTML.Name = "tsbtnSaveToHTML";
            this.tsbtnSaveToHTML.Size = new System.Drawing.Size(36, 36);
            this.tsbtnSaveToHTML.Text = "Save post to HTML file";
            this.tsbtnSaveToHTML.Click += new System.EventHandler(this.tsbtnSaveToHTML_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbntHideShowPost
            // 
            this.tsbntHideShowPost.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbntHideShowPost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbntHideShowPost.Image = global::Aggregator.GUI.Properties.Resources.buttonGray;
            this.tsbntHideShowPost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbntHideShowPost.Name = "tsbntHideShowPost";
            this.tsbntHideShowPost.Size = new System.Drawing.Size(36, 36);
            this.tsbntHideShowPost.Text = "Hide Post";
            this.tsbntHideShowPost.Click += new System.EventHandler(this.tsbntHideShowPost_Click);
            // 
            // tsbtnCheckAsRead
            // 
            this.tsbtnCheckAsRead.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCheckAsRead.Image = global::Aggregator.GUI.Properties.Resources.CheckedIcon;
            this.tsbtnCheckAsRead.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCheckAsRead.Name = "tsbtnCheckAsRead";
            this.tsbtnCheckAsRead.Size = new System.Drawing.Size(36, 36);
            this.tsbtnCheckAsRead.Text = "Checked post as read";
            this.tsbtnCheckAsRead.Click += new System.EventHandler(this.tsbtnCheckAsRead_Click);
            // 
            // tsbtnBack
            // 
            this.tsbtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBack.Image = global::Aggregator.GUI.Properties.Resources.arrow1;
            this.tsbtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBack.Name = "tsbtnBack";
            this.tsbtnBack.Size = new System.Drawing.Size(36, 36);
            this.tsbtnBack.Text = "Back";
            this.tsbtnBack.Click += new System.EventHandler(this.tsbtnBack_Click);
            // 
            // tsbtnNext
            // 
            this.tsbtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNext.Image = global::Aggregator.GUI.Properties.Resources.arrow2;
            this.tsbtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNext.Name = "tsbtnNext";
            this.tsbtnNext.Size = new System.Drawing.Size(36, 36);
            this.tsbtnNext.Text = "Next Post";
            this.tsbtnNext.Click += new System.EventHandler(this.tsbtnNext_Click);
            // 
            // ssRSS
            // 
            this.ssRSS.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ssRSS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUseActive,
            this.tsslRefreshedCountRSS,
            this.tsslNextRefreshRSS,
            this.tsslTotalDownloaded,
            this.tsslSourgeForge,
            this.tsslblRecordsInSearch});
            this.ssRSS.Location = new System.Drawing.Point(0, 745);
            this.ssRSS.Name = "ssRSS";
            this.ssRSS.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this.ssRSS.Size = new System.Drawing.Size(1230, 27);
            this.ssRSS.TabIndex = 16;
            this.ssRSS.Text = "statusStrip1";
            // 
            // tsslUseActive
            // 
            this.tsslUseActive.Name = "tsslUseActive";
            this.tsslUseActive.Size = new System.Drawing.Size(123, 22);
            this.tsslUseActive.Text = "User is Active";
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
            // tsslblRecordsInSearch
            // 
            this.tsslblRecordsInSearch.Name = "tsslblRecordsInSearch";
            this.tsslblRecordsInSearch.Size = new System.Drawing.Size(223, 22);
            this.tsslblRecordsInSearch.Text = "numbe of records in search";
            this.tsslblRecordsInSearch.Visible = false;
            // 
            // spltcMain
            // 
            this.spltcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltcMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spltcMain.Location = new System.Drawing.Point(0, 98);
            this.spltcMain.Name = "spltcMain";
            // 
            // spltcMain.Panel1
            // 
            this.spltcMain.Panel1.Controls.Add(this.spltcLeft);
            // 
            // spltcMain.Panel2
            // 
            this.spltcMain.Panel2.AutoScroll = true;
            this.spltcMain.Panel2.Controls.Add(this.tcFeeds);
            this.spltcMain.Size = new System.Drawing.Size(1230, 647);
            this.spltcMain.SplitterDistance = 240;
            this.spltcMain.TabIndex = 19;
            // 
            // spltcLeft
            // 
            this.spltcLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltcLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spltcLeft.Location = new System.Drawing.Point(0, 0);
            this.spltcLeft.Name = "spltcLeft";
            this.spltcLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltcLeft.Panel1
            // 
            this.spltcLeft.Panel1.Controls.Add(this.tvFeedsGroup);
            this.spltcLeft.Panel1.Controls.Add(this.lblSelectedGroup);
            this.spltcLeft.Panel1.Controls.Add(this.tsFeedsGroup);
            // 
            // spltcLeft.Panel2
            // 
            this.spltcLeft.Panel2.Controls.Add(this.tvFeeds);
            this.spltcLeft.Size = new System.Drawing.Size(240, 647);
            this.spltcLeft.SplitterDistance = 243;
            this.spltcLeft.TabIndex = 24;
            // 
            // tvFeedsGroup
            // 
            this.tvFeedsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFeedsGroup.ImageIndex = 0;
            this.tvFeedsGroup.ImageList = this.imglstFeedGroup;
            this.tvFeedsGroup.Location = new System.Drawing.Point(0, 22);
            this.tvFeedsGroup.Name = "tvFeedsGroup";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "NodeAllFeeds";
            treeNode1.SelectedImageIndex = 0;
            treeNode1.Text = "All Feeds";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "NodeActiveFeeds";
            treeNode2.SelectedImageIndex = 0;
            treeNode2.Text = "Active Feeds";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "NodeNonActiveFeeds";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Non Active Feeds";
            treeNode4.Name = "NodeDisabled";
            treeNode4.Text = "Disabled Feeds";
            treeNode5.Name = "NodePrivates";
            treeNode5.Text = "Privates Feeds";
            treeNode6.Name = "NodeOthers";
            treeNode6.Text = "Other Feeds (Not in category)";
            this.tvFeedsGroup.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.tvFeedsGroup.SelectedImageIndex = 0;
            this.tvFeedsGroup.Size = new System.Drawing.Size(240, 221);
            this.tvFeedsGroup.TabIndex = 17;
            this.tvFeedsGroup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFeedsGroup_AfterSelect);
            // 
            // imglstFeedGroup
            // 
            this.imglstFeedGroup.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstFeedGroup.ImageStream")));
            this.imglstFeedGroup.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstFeedGroup.Images.SetKeyName(0, "rssicon1.jpg");
            this.imglstFeedGroup.Images.SetKeyName(1, "rssicongray.jpg");
            this.imglstFeedGroup.Images.SetKeyName(2, "loading.gif");
            this.imglstFeedGroup.Images.SetKeyName(3, "rssheart.png");
            this.imglstFeedGroup.Images.SetKeyName(4, "rsspink.png");
            // 
            // lblSelectedGroup
            // 
            this.lblSelectedGroup.AutoEllipsis = true;
            this.lblSelectedGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelectedGroup.Location = new System.Drawing.Point(0, 0);
            this.lblSelectedGroup.Name = "lblSelectedGroup";
            this.lblSelectedGroup.Size = new System.Drawing.Size(240, 22);
            this.lblSelectedGroup.TabIndex = 22;
            this.lblSelectedGroup.Text = "Selected:";
            // 
            // tsFeedsGroup
            // 
            this.tsFeedsGroup.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsFeedsGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFeedsGroupRefresh});
            this.tsFeedsGroup.Location = new System.Drawing.Point(0, 0);
            this.tsFeedsGroup.Name = "tsFeedsGroup";
            this.tsFeedsGroup.Size = new System.Drawing.Size(240, 47);
            this.tsFeedsGroup.TabIndex = 22;
            this.tsFeedsGroup.Text = "toolStrip3";
            this.tsFeedsGroup.Visible = false;
            // 
            // tsbFeedsGroupRefresh
            // 
            this.tsbFeedsGroupRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFeedsGroupRefresh.Image = global::Aggregator.GUI.Properties.Resources.RefreshIconSmall;
            this.tsbFeedsGroupRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFeedsGroupRefresh.Name = "tsbFeedsGroupRefresh";
            this.tsbFeedsGroupRefresh.Size = new System.Drawing.Size(44, 44);
            this.tsbFeedsGroupRefresh.Text = "Refresh";
            // 
            // tvFeeds
            // 
            this.tvFeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFeeds.ImageIndex = 0;
            this.tvFeeds.ImageList = this.imglstFeeds;
            this.tvFeeds.Location = new System.Drawing.Point(0, 0);
            this.tvFeeds.Name = "tvFeeds";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Node0";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "Node1";
            treeNode8.SelectedImageKey = "rssicongray.jpg";
            treeNode8.Text = "Node1";
            treeNode9.Name = "Node2";
            treeNode9.Text = "Node2";
            treeNode10.Name = "Node3";
            treeNode10.Text = "Node3";
            treeNode11.Name = "Node4";
            treeNode11.Text = "Node4";
            this.tvFeeds.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            this.tvFeeds.SelectedImageIndex = 0;
            this.tvFeeds.Size = new System.Drawing.Size(240, 400);
            this.tvFeeds.TabIndex = 16;
            this.tvFeeds.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFeeds_AfterSelect);
            // 
            // imglstFeeds
            // 
            this.imglstFeeds.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstFeeds.ImageStream")));
            this.imglstFeeds.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstFeeds.Images.SetKeyName(0, "rssicon1.jpg");
            this.imglstFeeds.Images.SetKeyName(1, "rssicongray.jpg");
            this.imglstFeeds.Images.SetKeyName(2, "loading.gif");
            // 
            // tcFeeds
            // 
            this.tcFeeds.Controls.Add(this.tpFeeds);
            this.tcFeeds.Controls.Add(this.tpLog);
            this.tcFeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFeeds.Location = new System.Drawing.Point(0, 0);
            this.tcFeeds.Name = "tcFeeds";
            this.tcFeeds.SelectedIndex = 0;
            this.tcFeeds.Size = new System.Drawing.Size(986, 647);
            this.tcFeeds.TabIndex = 19;
            // 
            // tpFeeds
            // 
            this.tpFeeds.Controls.Add(this.spltcFeeds);
            this.tpFeeds.Location = new System.Drawing.Point(4, 31);
            this.tpFeeds.Name = "tpFeeds";
            this.tpFeeds.Padding = new System.Windows.Forms.Padding(3);
            this.tpFeeds.Size = new System.Drawing.Size(978, 612);
            this.tpFeeds.TabIndex = 0;
            this.tpFeeds.Text = "Feeds Viewer";
            this.tpFeeds.UseVisualStyleBackColor = true;
            // 
            // tpLog
            // 
            this.tpLog.Controls.Add(this.btnClearLog);
            this.tpLog.Controls.Add(this.rtxbMsg);
            this.tpLog.Location = new System.Drawing.Point(4, 31);
            this.tpLog.Name = "tpLog";
            this.tpLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpLog.Size = new System.Drawing.Size(978, 612);
            this.tpLog.TabIndex = 1;
            this.tpLog.Text = "Log";
            this.tpLog.UseVisualStyleBackColor = true;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Image = global::Aggregator.GUI.Properties.Resources.resetIcon;
            this.btnClearLog.Location = new System.Drawing.Point(6, 11);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(91, 36);
            this.btnClearLog.TabIndex = 2;
            this.btnClearLog.UseVisualStyleBackColor = true;
            // 
            // rtxbMsg
            // 
            this.rtxbMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxbMsg.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbMsg.Location = new System.Drawing.Point(6, 53);
            this.rtxbMsg.Name = "rtxbMsg";
            this.rtxbMsg.Size = new System.Drawing.Size(966, 571);
            this.rtxbMsg.TabIndex = 1;
            this.rtxbMsg.Text = "";
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNewFeed,
            this.tsSeparator1,
            this.tsbtnRSSStopStart,
            this.tsSeparator2,
            this.tsbtnRefreshActive,
            this.tsbtnRefreshNonActive,
            this.tsbtnRefreshGroup,
            this.tsbtnFacebookNewsFeedPage,
            this.tsbtnFacebook,
            this.tsbtnSettings,
            this.tsbtnExportFeed,
            this.tsSeparator3,
            this.tsbtnFavoriteFeeds,
            this.tsbtnFollowUpPosts,
            this.tsbtnSearch,
            this.tsSeparator4});
            this.tsMain.Location = new System.Drawing.Point(0, 30);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1230, 68);
            this.tsMain.TabIndex = 21;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbtnNewFeed
            // 
            this.tsbtnNewFeed.Image = global::Aggregator.GUI.Properties.Resources.rssadd;
            this.tsbtnNewFeed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNewFeed.Name = "tsbtnNewFeed";
            this.tsbtnNewFeed.Size = new System.Drawing.Size(75, 65);
            this.tsbtnNewFeed.Text = "new Feed";
            this.tsbtnNewFeed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 68);
            // 
            // tsbtnRSSStopStart
            // 
            this.tsbtnRSSStopStart.Image = global::Aggregator.GUI.Properties.Resources.Pauseicon;
            this.tsbtnRSSStopStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRSSStopStart.Name = "tsbtnRSSStopStart";
            this.tsbtnRSSStopStart.Size = new System.Drawing.Size(51, 65);
            this.tsbtnRSSStopStart.Text = "Pause";
            this.tsbtnRSSStopStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnRSSStopStart.Click += new System.EventHandler(this.tsbtnRSSStopStart_Click);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 68);
            // 
            // tsbtnRefreshActive
            // 
            this.tsbtnRefreshActive.Image = global::Aggregator.GUI.Properties.Resources.refresh;
            this.tsbtnRefreshActive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefreshActive.Name = "tsbtnRefreshActive";
            this.tsbtnRefreshActive.Size = new System.Drawing.Size(113, 65);
            this.tsbtnRefreshActive.Text = "Refresh Actives";
            this.tsbtnRefreshActive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnRefreshActive.ToolTipText = "Refresh All Active Feeds";
            // 
            // tsbtnRefreshNonActive
            // 
            this.tsbtnRefreshNonActive.Image = global::Aggregator.GUI.Properties.Resources.RefreshIconSmallgray1;
            this.tsbtnRefreshNonActive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefreshNonActive.Name = "tsbtnRefreshNonActive";
            this.tsbtnRefreshNonActive.Size = new System.Drawing.Size(144, 65);
            this.tsbtnRefreshNonActive.Text = "Refresh Non Actives";
            this.tsbtnRefreshNonActive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnRefreshGroup
            // 
            this.tsbtnRefreshGroup.Image = global::Aggregator.GUI.Properties.Resources.refreshspecificcategory;
            this.tsbtnRefreshGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefreshGroup.Name = "tsbtnRefreshGroup";
            this.tsbtnRefreshGroup.Size = new System.Drawing.Size(184, 65);
            this.tsbtnRefreshGroup.Text = "Refresh selected Category";
            this.tsbtnRefreshGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnRefreshGroup.Click += new System.EventHandler(this.tsbtnRefreshGroup_Click);
            // 
            // tsbtnFacebookNewsFeedPage
            // 
            this.tsbtnFacebookNewsFeedPage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnFacebookNewsFeedPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFacebookNewsFeedPage.Image = global::Aggregator.GUI.Properties.Resources.logo4;
            this.tsbtnFacebookNewsFeedPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFacebookNewsFeedPage.Name = "tsbtnFacebookNewsFeedPage";
            this.tsbtnFacebookNewsFeedPage.Size = new System.Drawing.Size(44, 65);
            this.tsbtnFacebookNewsFeedPage.Text = "Facebook News Feed Reader Page";
            // 
            // tsbtnFacebook
            // 
            this.tsbtnFacebook.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnFacebook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFacebook.Image = global::Aggregator.GUI.Properties.Resources.rsslike;
            this.tsbtnFacebook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFacebook.Name = "tsbtnFacebook";
            this.tsbtnFacebook.Size = new System.Drawing.Size(44, 65);
            this.tsbtnFacebook.Text = "Visit Desktop Aggregator\'s Facebook Page";
            // 
            // tsbtnSettings
            // 
            this.tsbtnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnSettings.Image = global::Aggregator.GUI.Properties.Resources.configurations1;
            this.tsbtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSettings.Name = "tsbtnSettings";
            this.tsbtnSettings.Size = new System.Drawing.Size(63, 65);
            this.tsbtnSettings.Text = "Settings";
            this.tsbtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnExportFeed
            // 
            this.tsbtnExportFeed.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnExportFeed.Image = global::Aggregator.GUI.Properties.Resources.export;
            this.tsbtnExportFeed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnExportFeed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExportFeed.Name = "tsbtnExportFeed";
            this.tsbtnExportFeed.Size = new System.Drawing.Size(89, 65);
            this.tsbtnExportFeed.Text = "Export";
            this.tsbtnExportFeed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsSeparator3
            // 
            this.tsSeparator3.Name = "tsSeparator3";
            this.tsSeparator3.Size = new System.Drawing.Size(6, 68);
            // 
            // tsbtnFavoriteFeeds
            // 
            this.tsbtnFavoriteFeeds.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFavoriteFeeds.Enabled = false;
            this.tsbtnFavoriteFeeds.Image = global::Aggregator.GUI.Properties.Resources.rsspink;
            this.tsbtnFavoriteFeeds.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFavoriteFeeds.Name = "tsbtnFavoriteFeeds";
            this.tsbtnFavoriteFeeds.Size = new System.Drawing.Size(44, 65);
            this.tsbtnFavoriteFeeds.Text = "View Favorites feeds posts";
            this.tsbtnFavoriteFeeds.Visible = false;
            // 
            // tsbtnFollowUpPosts
            // 
            this.tsbtnFollowUpPosts.Image = global::Aggregator.GUI.Properties.Resources.hearth;
            this.tsbtnFollowUpPosts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFollowUpPosts.Name = "tsbtnFollowUpPosts";
            this.tsbtnFollowUpPosts.Size = new System.Drawing.Size(80, 65);
            this.tsbtnFollowUpPosts.Text = "Follow Ups";
            this.tsbtnFollowUpPosts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnFollowUpPosts.Click += new System.EventHandler(this.tsbtnFollowUpPosts_Click);
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnSearch.Image = global::Aggregator.GUI.Properties.Resources.search;
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(56, 65);
            this.tsbtnSearch.Text = "Search";
            this.tsbtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsSeparator4
            // 
            this.tsSeparator4.Name = "tsSeparator4";
            this.tsSeparator4.Size = new System.Drawing.Size(6, 68);
            // 
            // tmrUser
            // 
            this.tmrUser.Enabled = true;
            this.tmrUser.Interval = 1000;
            this.tmrUser.Tick += new System.EventHandler(this.tmrUser_Tick);
            // 
            // MainFormRSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 772);
            this.Controls.Add(this.spltcMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.ssRSS);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MainFormRSS";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RSS Desktop Aggregator";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormRSS_FormClosing);
            this.Load += new System.EventHandler(this.MainFormRSS_Load);
            this.Resize += new System.EventHandler(this.MainFormRSS_Resize);
            this.cntmsOperations.ResumeLayout(false);
            this.cntmsRSSColumns.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.spltcFeeds.Panel1.ResumeLayout(false);
            this.spltcFeeds.Panel1.PerformLayout();
            this.spltcFeeds.Panel2.ResumeLayout(false);
            this.spltcFeeds.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcFeeds)).EndInit();
            this.spltcFeeds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvPosts)).EndInit();
            this.tsCurrentFeed.ResumeLayout(false);
            this.tsCurrentFeed.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ssRSS.ResumeLayout(false);
            this.ssRSS.PerformLayout();
            this.spltcMain.Panel1.ResumeLayout(false);
            this.spltcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltcMain)).EndInit();
            this.spltcMain.ResumeLayout(false);
            this.spltcLeft.Panel1.ResumeLayout(false);
            this.spltcLeft.Panel1.PerformLayout();
            this.spltcLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltcLeft)).EndInit();
            this.spltcLeft.ResumeLayout(false);
            this.tsFeedsGroup.ResumeLayout(false);
            this.tsFeedsGroup.PerformLayout();
            this.tcFeeds.ResumeLayout(false);
            this.tpFeeds.ResumeLayout(false);
            this.tpLog.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrRefreshRSS;
        private System.Windows.Forms.NotifyIcon notifyIconStatus;
        private System.Windows.Forms.ContextMenuStrip cntmsOperations;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
        private System.Windows.Forms.ToolStripSeparator tsmiSeperator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.Button btnMarkAllRSSAsRead;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiApplicationSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.SplitContainer spltcFeeds;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripMenuItem tsmiErrorsList;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiVersion;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatistics;
        private System.Windows.Forms.StatusStrip ssRSS;
        private System.Windows.Forms.ToolStripStatusLabel tsslRefreshedCountRSS;
        private System.Windows.Forms.ToolStripStatusLabel tsslNextRefreshRSS;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalDownloaded;
        private System.Windows.Forms.ToolStripStatusLabel tsslSourgeForge;
        private System.Windows.Forms.WebBrowser webbPostViewer;
        private System.Windows.Forms.SplitContainer spltcMain;
        private System.Windows.Forms.TabControl tcFeeds;
        private System.Windows.Forms.TabPage tpFeeds;
        private System.Windows.Forms.TabPage tpLog;
        private System.Windows.Forms.RichTextBox rtxbMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmiRestart;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewLogOperations;
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
        private System.Windows.Forms.SplitContainer spltcLeft;
        private System.Windows.Forms.TreeView tvFeeds;
        private System.Windows.Forms.TreeView tvFeedsGroup;
        private System.Windows.Forms.ImageList imglstFeeds;
        private System.Windows.Forms.ToolStrip tsCurrentFeed;
        private System.Windows.Forms.ToolStripButton tsbtnRefreshCurrentFeeds;
        private System.Windows.Forms.ToolStrip tsFeedsGroup;
        private System.Windows.Forms.ToolStripButton tsbFeedsGroupRefresh;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbtnRefreshActive;
        private System.Windows.Forms.ToolStripButton tsbtnRefreshNonActive;
        private System.Windows.Forms.ToolStripButton tsbtnRSSStopStart;
        private System.Windows.Forms.CheckBox chkbUnreadposts;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.CheckBox chkbWhenToMarkAsRead;
        private System.Windows.Forms.ToolStripButton tsbtnRefreshGroup;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.ToolStripButton tsbtnFeedInformation;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnExportFeed;
        private System.Windows.Forms.ToolStripButton tsbtnFollowUpPosts;
        private System.Windows.Forms.ToolStripMenuItem followUpPostToolStripMenuItem;
        private System.Windows.Forms.ImageList imglstFeedGroup;
        private System.Windows.Forms.ToolStripButton tsbtnFavoriteFeeds;
        private System.Windows.Forms.ToolStripSeparator tsSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripButton tsbtnSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiOutlook;
        private System.Windows.Forms.ToolStripButton tsbtnFacebook;
        private System.Windows.Forms.ToolStripButton tsbtnFollowupPostMark;
        private System.Windows.Forms.Label lblSelectedGroup;
        private System.Windows.Forms.ToolStripButton tsbtnNewFeed;
        private System.Windows.Forms.ToolStripSeparator tsSeparator4;
        private System.Windows.Forms.ToolStripTextBox tstxtbSearchFeed;
        private System.Windows.Forms.ToolStripStatusLabel tsslblRecordsInSearch;
        private System.Windows.Forms.CheckBox chkbGroupResults;
        private System.Windows.Forms.ToolStripButton tsbtnFeedStatus;
        private System.Windows.Forms.ToolStripSeparator tsSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnFacebookNewsFeedPage;
        private BrightIdeasSoftware.ObjectListView olvPosts;
        private BrightIdeasSoftware.OLVColumn columnHeaderTitle;
        private BrightIdeasSoftware.OLVColumn columnPubDate;
        private BrightIdeasSoftware.OLVColumn olvRead;
        private BrightIdeasSoftware.OLVColumn columnFeed;
        private BrightIdeasSoftware.OLVColumn columnAddedDate;
        private BrightIdeasSoftware.OLVColumn columnHeader16;
        private System.Windows.Forms.Timer tmrUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslUseActive;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSaveToHTML;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbntHideShowPost;
        private System.Windows.Forms.ToolStripButton tsbtnCheckAsRead;
        private System.Windows.Forms.ToolStripButton tsbtnBack;
        private System.Windows.Forms.ToolStripButton tsbtnNext;
    }
}