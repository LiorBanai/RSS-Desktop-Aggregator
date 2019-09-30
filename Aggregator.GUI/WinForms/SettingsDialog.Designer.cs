namespace Aggregator.GUI.WinForms
{
    partial class SettingsDialog
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("General Settings", "appicon.png");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("RSS Settings", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("RSS Categories", "rsscategories.jpg");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Outlook Settings", "thumb_Outlook.ico");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.txtbRSSURL = new System.Windows.Forms.TextBox();
            this.lblRSSURL = new System.Windows.Forms.Label();
            this.chkblstRSSItems = new System.Windows.Forms.CheckedListBox();
            this.lblRSSName = new System.Windows.Forms.Label();
            this.txtbRSSName = new System.Windows.Forms.TextBox();
            this.lblUpdatreFeedName = new System.Windows.Forms.Label();
            this.txtbUpdateFeedName = new System.Windows.Forms.TextBox();
            this.btnUpdateFeedName = new System.Windows.Forms.Button();
            this.lblUpdateRSSURL = new System.Windows.Forms.Label();
            this.txtbUpdateFeedURL = new System.Windows.Forms.TextBox();
            this.lblTotalDownloaded = new System.Windows.Forms.Label();
            this.chkbNewPrivate = new System.Windows.Forms.CheckBox();
            this.chkbPrivate = new System.Windows.Forms.CheckBox();
            this.gpNewFeed = new System.Windows.Forms.GroupBox();
            this.tbNewFeeds = new System.Windows.Forms.TabControl();
            this.tpStandardFeeds = new System.Windows.Forms.TabPage();
            this.gbEncodings = new System.Windows.Forms.GroupBox();
            this.rbEncodingUTF8 = new System.Windows.Forms.RadioButton();
            this.cbCodepages = new System.Windows.Forms.ComboBox();
            this.rbcodepage = new System.Windows.Forms.RadioButton();
            this.rbEncodingUnicode = new System.Windows.Forms.RadioButton();
            this.rbEncodingUTF32 = new System.Windows.Forms.RadioButton();
            this.rbEncodingUTF7 = new System.Windows.Forms.RadioButton();
            this.lblEncoding = new System.Windows.Forms.Label();
            this.chkbDontKeepHistory = new System.Windows.Forms.CheckBox();
            this.btnAddRSS = new System.Windows.Forms.Button();
            this.tpCustomFeeds = new System.Windows.Forms.TabPage();
            this.rbCustomFeedFBReaderSourceForgeFiles = new System.Windows.Forms.RadioButton();
            this.rbCustomFeedFBReaderFBWall = new System.Windows.Forms.RadioButton();
            this.rbCustomFeedSourceForgeFiles = new System.Windows.Forms.RadioButton();
            this.rbCustomFeedFBWall = new System.Windows.Forms.RadioButton();
            this.btnAddRSSCustom = new System.Windows.Forms.Button();
            this.rbCustomFeedGmail = new System.Windows.Forms.RadioButton();
            this.pnlRSSSettings = new System.Windows.Forms.Panel();
            this.lblSaveTime = new System.Windows.Forms.Label();
            this.gbavailableFeeds = new System.Windows.Forms.GroupBox();
            this.chkbDisabledFeed = new System.Windows.Forms.CheckBox();
            this.btnClearAllHistories = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnUnselectAll = new System.Windows.Forms.Button();
            this.btnClearPosts = new System.Windows.Forms.Button();
            this.btnDeleteRSS = new System.Windows.Forms.Button();
            this.btnUpdateResetDownloadCount = new System.Windows.Forms.Button();
            this.btnViewPosts = new System.Windows.Forms.Button();
            this.spltcMain = new System.Windows.Forms.SplitContainer();
            this.lvItems = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlGeneralSettings = new System.Windows.Forms.Panel();
            this.lblColor = new System.Windows.Forms.Label();
            this.chkColorUnreadPosts = new System.Windows.Forms.CheckBox();
            this.chkBoldUnreadPosts = new System.Windows.Forms.CheckBox();
            this.chkRemoveAfterRead = new System.Windows.Forms.CheckBox();
            this.chkbTaskBarIcon = new System.Windows.Forms.CheckBox();
            this.chkbRSSSaveToDiskOnRefresh = new System.Windows.Forms.CheckBox();
            this.chkbNotifyOnRSSErrors = new System.Windows.Forms.CheckBox();
            this.gbFilesLocation = new System.Windows.Forms.GroupBox();
            this.rbtnPerUsers = new System.Windows.Forms.RadioButton();
            this.rbtnForAllUsers = new System.Windows.Forms.RadioButton();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.nudOutlookInterval = new System.Windows.Forms.NumericUpDown();
            this.lblOutlookInterval = new System.Windows.Forms.Label();
            this.nudRSSInterval = new System.Windows.Forms.NumericUpDown();
            this.lblRSSInterval = new System.Windows.Forms.Label();
            this.chkbEnableOutlookOnStart = new System.Windows.Forms.CheckBox();
            this.pnlOutlook = new System.Windows.Forms.Panel();
            this.btnOutlookSAveSettings = new System.Windows.Forms.Button();
            this.tvOutlookFolders = new System.Windows.Forms.TreeView();
            this.lblbOutlookFolders = new System.Windows.Forms.Label();
            this.pnlRSScategories = new System.Windows.Forms.Panel();
            this.spltcFeedsCategories = new System.Windows.Forms.SplitContainer();
            this.gbFeedsForCategories = new System.Windows.Forms.GroupBox();
            this.lblFeedForCategories = new System.Windows.Forms.Label();
            this.lstbFeedsForCategories = new System.Windows.Forms.ListBox();
            this.gbCategories = new System.Windows.Forms.GroupBox();
            this.chklstbCategories = new System.Windows.Forms.CheckedListBox();
            this.lblNewCategoryName = new System.Windows.Forms.Label();
            this.txtbNewCategoryName = new System.Windows.Forms.TextBox();
            this.btnCategoriesDelete = new System.Windows.Forms.Button();
            this.btnCategoriesAdd = new System.Windows.Forms.Button();
            this.gpNewFeed.SuspendLayout();
            this.tbNewFeeds.SuspendLayout();
            this.tpStandardFeeds.SuspendLayout();
            this.gbEncodings.SuspendLayout();
            this.tpCustomFeeds.SuspendLayout();
            this.pnlRSSSettings.SuspendLayout();
            this.gbavailableFeeds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcMain)).BeginInit();
            this.spltcMain.Panel1.SuspendLayout();
            this.spltcMain.Panel2.SuspendLayout();
            this.spltcMain.SuspendLayout();
            this.pnlGeneralSettings.SuspendLayout();
            this.gbFilesLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutlookInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRSSInterval)).BeginInit();
            this.pnlOutlook.SuspendLayout();
            this.pnlRSScategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcFeedsCategories)).BeginInit();
            this.spltcFeedsCategories.Panel1.SuspendLayout();
            this.spltcFeedsCategories.Panel2.SuspendLayout();
            this.spltcFeedsCategories.SuspendLayout();
            this.gbFeedsForCategories.SuspendLayout();
            this.gbCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbRSSURL
            // 
            this.txtbRSSURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbRSSURL.Location = new System.Drawing.Point(117, 8);
            this.txtbRSSURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtbRSSURL.Name = "txtbRSSURL";
            this.txtbRSSURL.Size = new System.Drawing.Size(445, 28);
            this.txtbRSSURL.TabIndex = 0;
            // 
            // lblRSSURL
            // 
            this.lblRSSURL.AutoSize = true;
            this.lblRSSURL.Location = new System.Drawing.Point(4, 11);
            this.lblRSSURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRSSURL.Name = "lblRSSURL";
            this.lblRSSURL.Size = new System.Drawing.Size(91, 21);
            this.lblRSSURL.TabIndex = 1;
            this.lblRSSURL.Text = "RSS URL:";
            // 
            // chkblstRSSItems
            // 
            this.chkblstRSSItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkblstRSSItems.FormattingEnabled = true;
            this.chkblstRSSItems.Location = new System.Drawing.Point(6, 62);
            this.chkblstRSSItems.Name = "chkblstRSSItems";
            this.chkblstRSSItems.Size = new System.Drawing.Size(614, 165);
            this.chkblstRSSItems.TabIndex = 3;
            this.chkblstRSSItems.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkbRSSItems_ItemCheck);
            this.chkblstRSSItems.Click += new System.EventHandler(this.chkbRSSItems_Click);
            this.chkblstRSSItems.SelectedIndexChanged += new System.EventHandler(this.chkbRSSItems_SelectedIndexChanged);
            // 
            // lblRSSName
            // 
            this.lblRSSName.AutoSize = true;
            this.lblRSSName.Location = new System.Drawing.Point(3, 47);
            this.lblRSSName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRSSName.Name = "lblRSSName";
            this.lblRSSName.Size = new System.Drawing.Size(97, 21);
            this.lblRSSName.TabIndex = 6;
            this.lblRSSName.Text = "RSS Name:";
            // 
            // txtbRSSName
            // 
            this.txtbRSSName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbRSSName.Location = new System.Drawing.Point(117, 44);
            this.txtbRSSName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbRSSName.Name = "txtbRSSName";
            this.txtbRSSName.Size = new System.Drawing.Size(445, 28);
            this.txtbRSSName.TabIndex = 5;
            // 
            // lblUpdatreFeedName
            // 
            this.lblUpdatreFeedName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpdatreFeedName.AutoSize = true;
            this.lblUpdatreFeedName.Location = new System.Drawing.Point(7, 308);
            this.lblUpdatreFeedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdatreFeedName.Name = "lblUpdatreFeedName";
            this.lblUpdatreFeedName.Size = new System.Drawing.Size(97, 21);
            this.lblUpdatreFeedName.TabIndex = 8;
            this.lblUpdatreFeedName.Text = "RSS Name:";
            // 
            // txtbUpdateFeedName
            // 
            this.txtbUpdateFeedName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbUpdateFeedName.Location = new System.Drawing.Point(144, 308);
            this.txtbUpdateFeedName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbUpdateFeedName.Name = "txtbUpdateFeedName";
            this.txtbUpdateFeedName.Size = new System.Drawing.Size(481, 28);
            this.txtbUpdateFeedName.TabIndex = 7;
            // 
            // btnUpdateFeedName
            // 
            this.btnUpdateFeedName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateFeedName.Location = new System.Drawing.Point(526, 339);
            this.btnUpdateFeedName.Name = "btnUpdateFeedName";
            this.btnUpdateFeedName.Size = new System.Drawing.Size(99, 28);
            this.btnUpdateFeedName.TabIndex = 9;
            this.btnUpdateFeedName.Text = "Update";
            this.btnUpdateFeedName.UseVisualStyleBackColor = true;
            this.btnUpdateFeedName.Click += new System.EventHandler(this.btnUpdateFeedName_Click);
            // 
            // lblUpdateRSSURL
            // 
            this.lblUpdateRSSURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpdateRSSURL.AutoSize = true;
            this.lblUpdateRSSURL.Location = new System.Drawing.Point(7, 277);
            this.lblUpdateRSSURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateRSSURL.Name = "lblUpdateRSSURL";
            this.lblUpdateRSSURL.Size = new System.Drawing.Size(91, 21);
            this.lblUpdateRSSURL.TabIndex = 11;
            this.lblUpdateRSSURL.Text = "RSS URL:";
            // 
            // txtbUpdateFeedURL
            // 
            this.txtbUpdateFeedURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbUpdateFeedURL.Location = new System.Drawing.Point(144, 274);
            this.txtbUpdateFeedURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtbUpdateFeedURL.Name = "txtbUpdateFeedURL";
            this.txtbUpdateFeedURL.Size = new System.Drawing.Size(481, 28);
            this.txtbUpdateFeedURL.TabIndex = 10;
            // 
            // lblTotalDownloaded
            // 
            this.lblTotalDownloaded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalDownloaded.AutoEllipsis = true;
            this.lblTotalDownloaded.Location = new System.Drawing.Point(7, 241);
            this.lblTotalDownloaded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDownloaded.Name = "lblTotalDownloaded";
            this.lblTotalDownloaded.Size = new System.Drawing.Size(291, 26);
            this.lblTotalDownloaded.TabIndex = 14;
            this.lblTotalDownloaded.Text = "Total Downloaded Size is:";
            this.lblTotalDownloaded.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkbNewPrivate
            // 
            this.chkbNewPrivate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbNewPrivate.AutoEllipsis = true;
            this.chkbNewPrivate.Location = new System.Drawing.Point(8, 79);
            this.chkbNewPrivate.Name = "chkbNewPrivate";
            this.chkbNewPrivate.Size = new System.Drawing.Size(630, 25);
            this.chkbNewPrivate.TabIndex = 17;
            this.chkbNewPrivate.Text = "This is private RSS (do not cache old posts to file)";
            this.chkbNewPrivate.UseVisualStyleBackColor = true;
            // 
            // chkbPrivate
            // 
            this.chkbPrivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbPrivate.AutoSize = true;
            this.chkbPrivate.Location = new System.Drawing.Point(471, 245);
            this.chkbPrivate.Name = "chkbPrivate";
            this.chkbPrivate.Size = new System.Drawing.Size(154, 21);
            this.chkbPrivate.TabIndex = 18;
            this.chkbPrivate.Text = "This is private RSS ";
            this.chkbPrivate.UseVisualStyleBackColor = true;
            // 
            // gpNewFeed
            // 
            this.gpNewFeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpNewFeed.Controls.Add(this.tbNewFeeds);
            this.gpNewFeed.Location = new System.Drawing.Point(14, 33);
            this.gpNewFeed.Name = "gpNewFeed";
            this.gpNewFeed.Size = new System.Drawing.Size(672, 310);
            this.gpNewFeed.TabIndex = 19;
            this.gpNewFeed.TabStop = false;
            this.gpNewFeed.Text = "New Feed";
            // 
            // tbNewFeeds
            // 
            this.tbNewFeeds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewFeeds.Controls.Add(this.tpStandardFeeds);
            this.tbNewFeeds.Controls.Add(this.tpCustomFeeds);
            this.tbNewFeeds.Location = new System.Drawing.Point(6, 24);
            this.tbNewFeeds.Name = "tbNewFeeds";
            this.tbNewFeeds.SelectedIndex = 0;
            this.tbNewFeeds.Size = new System.Drawing.Size(657, 280);
            this.tbNewFeeds.TabIndex = 18;
            // 
            // tpStandardFeeds
            // 
            this.tpStandardFeeds.Controls.Add(this.gbEncodings);
            this.tpStandardFeeds.Controls.Add(this.lblEncoding);
            this.tpStandardFeeds.Controls.Add(this.chkbDontKeepHistory);
            this.tpStandardFeeds.Controls.Add(this.btnAddRSS);
            this.tpStandardFeeds.Controls.Add(this.lblRSSName);
            this.tpStandardFeeds.Controls.Add(this.chkbNewPrivate);
            this.tpStandardFeeds.Controls.Add(this.txtbRSSName);
            this.tpStandardFeeds.Controls.Add(this.lblRSSURL);
            this.tpStandardFeeds.Controls.Add(this.txtbRSSURL);
            this.tpStandardFeeds.Location = new System.Drawing.Point(4, 29);
            this.tpStandardFeeds.Name = "tpStandardFeeds";
            this.tpStandardFeeds.Padding = new System.Windows.Forms.Padding(3);
            this.tpStandardFeeds.Size = new System.Drawing.Size(649, 247);
            this.tpStandardFeeds.TabIndex = 0;
            this.tpStandardFeeds.Text = "Standard Feeds";
            this.tpStandardFeeds.UseVisualStyleBackColor = true;
            // 
            // gbEncodings
            // 
            this.gbEncodings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEncodings.Controls.Add(this.rbEncodingUTF8);
            this.gbEncodings.Controls.Add(this.cbCodepages);
            this.gbEncodings.Controls.Add(this.rbcodepage);
            this.gbEncodings.Controls.Add(this.rbEncodingUnicode);
            this.gbEncodings.Controls.Add(this.rbEncodingUTF32);
            this.gbEncodings.Controls.Add(this.rbEncodingUTF7);
            this.gbEncodings.Location = new System.Drawing.Point(144, 129);
            this.gbEncodings.Name = "gbEncodings";
            this.gbEncodings.Size = new System.Drawing.Size(496, 112);
            this.gbEncodings.TabIndex = 26;
            this.gbEncodings.TabStop = false;
            // 
            // rbEncodingUTF8
            // 
            this.rbEncodingUTF8.AutoSize = true;
            this.rbEncodingUTF8.Checked = true;
            this.rbEncodingUTF8.Location = new System.Drawing.Point(6, 17);
            this.rbEncodingUTF8.Name = "rbEncodingUTF8";
            this.rbEncodingUTF8.Size = new System.Drawing.Size(340, 25);
            this.rbEncodingUTF8.TabIndex = 20;
            this.rbEncodingUTF8.TabStop = true;
            this.rbEncodingUTF8.Text = "UTF-8 (leave checked if you don\'t know)";
            this.rbEncodingUTF8.UseVisualStyleBackColor = true;
            this.rbEncodingUTF8.Click += new System.EventHandler(this.chkbEncodings);
            // 
            // cbCodepages
            // 
            this.cbCodepages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCodepages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodepages.Enabled = false;
            this.cbCodepages.FormattingEnabled = true;
            this.cbCodepages.Location = new System.Drawing.Point(225, 77);
            this.cbCodepages.Name = "cbCodepages";
            this.cbCodepages.Size = new System.Drawing.Size(262, 28);
            this.cbCodepages.TabIndex = 25;
            // 
            // rbcodepage
            // 
            this.rbcodepage.AutoSize = true;
            this.rbcodepage.Location = new System.Drawing.Point(6, 79);
            this.rbcodepage.Name = "rbcodepage";
            this.rbcodepage.Size = new System.Drawing.Size(208, 25);
            this.rbcodepage.TabIndex = 21;
            this.rbcodepage.Text = "Or Specific Code Page:";
            this.rbcodepage.UseVisualStyleBackColor = true;
            this.rbcodepage.Click += new System.EventHandler(this.chkbEncodings);
            // 
            // rbEncodingUnicode
            // 
            this.rbEncodingUnicode.AutoSize = true;
            this.rbEncodingUnicode.Location = new System.Drawing.Point(6, 48);
            this.rbEncodingUnicode.Name = "rbEncodingUnicode";
            this.rbEncodingUnicode.Size = new System.Drawing.Size(94, 25);
            this.rbEncodingUnicode.TabIndex = 22;
            this.rbEncodingUnicode.Text = "Unicode";
            this.rbEncodingUnicode.UseVisualStyleBackColor = true;
            this.rbEncodingUnicode.Click += new System.EventHandler(this.chkbEncodings);
            // 
            // rbEncodingUTF32
            // 
            this.rbEncodingUTF32.AutoSize = true;
            this.rbEncodingUTF32.Location = new System.Drawing.Point(217, 48);
            this.rbEncodingUTF32.Name = "rbEncodingUTF32";
            this.rbEncodingUTF32.Size = new System.Drawing.Size(91, 25);
            this.rbEncodingUTF32.TabIndex = 24;
            this.rbEncodingUTF32.Text = "UTF-32";
            this.rbEncodingUTF32.UseVisualStyleBackColor = true;
            this.rbEncodingUTF32.Click += new System.EventHandler(this.chkbEncodings);
            // 
            // rbEncodingUTF7
            // 
            this.rbEncodingUTF7.AutoSize = true;
            this.rbEncodingUTF7.Location = new System.Drawing.Point(119, 48);
            this.rbEncodingUTF7.Name = "rbEncodingUTF7";
            this.rbEncodingUTF7.Size = new System.Drawing.Size(82, 25);
            this.rbEncodingUTF7.TabIndex = 23;
            this.rbEncodingUTF7.Text = "UTF-7";
            this.rbEncodingUTF7.UseVisualStyleBackColor = true;
            this.rbEncodingUTF7.Click += new System.EventHandler(this.chkbEncodings);
            // 
            // lblEncoding
            // 
            this.lblEncoding.AutoEllipsis = true;
            this.lblEncoding.Location = new System.Drawing.Point(6, 146);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(144, 30);
            this.lblEncoding.TabIndex = 19;
            this.lblEncoding.Text = "Select Encoding:";
            // 
            // chkbDontKeepHistory
            // 
            this.chkbDontKeepHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbDontKeepHistory.Location = new System.Drawing.Point(8, 109);
            this.chkbDontKeepHistory.Name = "chkbDontKeepHistory";
            this.chkbDontKeepHistory.Size = new System.Drawing.Size(620, 25);
            this.chkbDontKeepHistory.TabIndex = 18;
            this.chkbDontKeepHistory.Text = "Don\'t keep history for each post (ignore changes in posts\' content)";
            this.chkbDontKeepHistory.UseVisualStyleBackColor = true;
            // 
            // btnAddRSS
            // 
            this.btnAddRSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRSS.BackgroundImage = global::Aggregator.GUI.Properties.Resources.rssadd;
            this.btnAddRSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddRSS.Location = new System.Drawing.Point(570, 7);
            this.btnAddRSS.Name = "btnAddRSS";
            this.btnAddRSS.Size = new System.Drawing.Size(68, 63);
            this.btnAddRSS.TabIndex = 2;
            this.btnAddRSS.UseVisualStyleBackColor = true;
            this.btnAddRSS.Click += new System.EventHandler(this.btnAddRSS_Click);
            // 
            // tpCustomFeeds
            // 
            this.tpCustomFeeds.Controls.Add(this.rbCustomFeedFBReaderSourceForgeFiles);
            this.tpCustomFeeds.Controls.Add(this.rbCustomFeedFBReaderFBWall);
            this.tpCustomFeeds.Controls.Add(this.rbCustomFeedSourceForgeFiles);
            this.tpCustomFeeds.Controls.Add(this.rbCustomFeedFBWall);
            this.tpCustomFeeds.Controls.Add(this.btnAddRSSCustom);
            this.tpCustomFeeds.Controls.Add(this.rbCustomFeedGmail);
            this.tpCustomFeeds.Location = new System.Drawing.Point(4, 25);
            this.tpCustomFeeds.Name = "tpCustomFeeds";
            this.tpCustomFeeds.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomFeeds.Size = new System.Drawing.Size(649, 251);
            this.tpCustomFeeds.TabIndex = 1;
            this.tpCustomFeeds.Text = "Custom Feeds (Gmail Account & Others)";
            this.tpCustomFeeds.UseVisualStyleBackColor = true;
            // 
            // rbCustomFeedFBReaderSourceForgeFiles
            // 
            this.rbCustomFeedFBReaderSourceForgeFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCustomFeedFBReaderSourceForgeFiles.AutoEllipsis = true;
            this.rbCustomFeedFBReaderSourceForgeFiles.Location = new System.Drawing.Point(27, 166);
            this.rbCustomFeedFBReaderSourceForgeFiles.Name = "rbCustomFeedFBReaderSourceForgeFiles";
            this.rbCustomFeedFBReaderSourceForgeFiles.Size = new System.Drawing.Size(452, 31);
            this.rbCustomFeedFBReaderSourceForgeFiles.TabIndex = 7;
            this.rbCustomFeedFBReaderSourceForgeFiles.Text = "Facebook News Feed Reader SourceForge Files";
            this.rbCustomFeedFBReaderSourceForgeFiles.UseVisualStyleBackColor = true;
            // 
            // rbCustomFeedFBReaderFBWall
            // 
            this.rbCustomFeedFBReaderFBWall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCustomFeedFBReaderFBWall.AutoEllipsis = true;
            this.rbCustomFeedFBReaderFBWall.Location = new System.Drawing.Point(27, 128);
            this.rbCustomFeedFBReaderFBWall.Name = "rbCustomFeedFBReaderFBWall";
            this.rbCustomFeedFBReaderFBWall.Size = new System.Drawing.Size(452, 31);
            this.rbCustomFeedFBReaderFBWall.TabIndex = 6;
            this.rbCustomFeedFBReaderFBWall.Text = "Facebook News Feed Reader Facebook Wall";
            this.rbCustomFeedFBReaderFBWall.UseVisualStyleBackColor = true;
            // 
            // rbCustomFeedSourceForgeFiles
            // 
            this.rbCustomFeedSourceForgeFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCustomFeedSourceForgeFiles.AutoEllipsis = true;
            this.rbCustomFeedSourceForgeFiles.Location = new System.Drawing.Point(27, 90);
            this.rbCustomFeedSourceForgeFiles.Name = "rbCustomFeedSourceForgeFiles";
            this.rbCustomFeedSourceForgeFiles.Size = new System.Drawing.Size(452, 31);
            this.rbCustomFeedSourceForgeFiles.TabIndex = 5;
            this.rbCustomFeedSourceForgeFiles.Text = "RSS Aggregator SourceForge Files";
            this.rbCustomFeedSourceForgeFiles.UseVisualStyleBackColor = true;
            // 
            // rbCustomFeedFBWall
            // 
            this.rbCustomFeedFBWall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCustomFeedFBWall.AutoEllipsis = true;
            this.rbCustomFeedFBWall.Location = new System.Drawing.Point(27, 52);
            this.rbCustomFeedFBWall.Name = "rbCustomFeedFBWall";
            this.rbCustomFeedFBWall.Size = new System.Drawing.Size(452, 31);
            this.rbCustomFeedFBWall.TabIndex = 4;
            this.rbCustomFeedFBWall.Text = "RSS Aggregator Facebook Wall";
            this.rbCustomFeedFBWall.UseVisualStyleBackColor = true;
            // 
            // btnAddRSSCustom
            // 
            this.btnAddRSSCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRSSCustom.BackgroundImage = global::Aggregator.GUI.Properties.Resources.rssadd;
            this.btnAddRSSCustom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddRSSCustom.Location = new System.Drawing.Point(570, 7);
            this.btnAddRSSCustom.Name = "btnAddRSSCustom";
            this.btnAddRSSCustom.Size = new System.Drawing.Size(68, 63);
            this.btnAddRSSCustom.TabIndex = 3;
            this.btnAddRSSCustom.UseVisualStyleBackColor = true;
            this.btnAddRSSCustom.Click += new System.EventHandler(this.btnAddRSSCustom_Click);
            // 
            // rbCustomFeedGmail
            // 
            this.rbCustomFeedGmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCustomFeedGmail.AutoEllipsis = true;
            this.rbCustomFeedGmail.Checked = true;
            this.rbCustomFeedGmail.Location = new System.Drawing.Point(27, 14);
            this.rbCustomFeedGmail.Name = "rbCustomFeedGmail";
            this.rbCustomFeedGmail.Size = new System.Drawing.Size(452, 31);
            this.rbCustomFeedGmail.TabIndex = 0;
            this.rbCustomFeedGmail.TabStop = true;
            this.rbCustomFeedGmail.Text = "GMail Account";
            this.rbCustomFeedGmail.UseVisualStyleBackColor = true;
            // 
            // pnlRSSSettings
            // 
            this.pnlRSSSettings.AutoScroll = true;
            this.pnlRSSSettings.Controls.Add(this.lblSaveTime);
            this.pnlRSSSettings.Controls.Add(this.gbavailableFeeds);
            this.pnlRSSSettings.Controls.Add(this.gpNewFeed);
            this.pnlRSSSettings.Location = new System.Drawing.Point(61, 64);
            this.pnlRSSSettings.Name = "pnlRSSSettings";
            this.pnlRSSSettings.Size = new System.Drawing.Size(693, 732);
            this.pnlRSSSettings.TabIndex = 20;
            // 
            // lblSaveTime
            // 
            this.lblSaveTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaveTime.AutoEllipsis = true;
            this.lblSaveTime.Location = new System.Drawing.Point(10, 9);
            this.lblSaveTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaveTime.Name = "lblSaveTime";
            this.lblSaveTime.Size = new System.Drawing.Size(676, 21);
            this.lblSaveTime.TabIndex = 22;
            this.lblSaveTime.Text = "*Changes to feeds are saved automatically on form closing";
            // 
            // gbavailableFeeds
            // 
            this.gbavailableFeeds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbavailableFeeds.Controls.Add(this.chkbDisabledFeed);
            this.gbavailableFeeds.Controls.Add(this.btnClearAllHistories);
            this.gbavailableFeeds.Controls.Add(this.btnSelectAll);
            this.gbavailableFeeds.Controls.Add(this.btnUnselectAll);
            this.gbavailableFeeds.Controls.Add(this.chkblstRSSItems);
            this.gbavailableFeeds.Controls.Add(this.chkbPrivate);
            this.gbavailableFeeds.Controls.Add(this.btnClearPosts);
            this.gbavailableFeeds.Controls.Add(this.btnDeleteRSS);
            this.gbavailableFeeds.Controls.Add(this.btnUpdateResetDownloadCount);
            this.gbavailableFeeds.Controls.Add(this.lblTotalDownloaded);
            this.gbavailableFeeds.Controls.Add(this.btnViewPosts);
            this.gbavailableFeeds.Controls.Add(this.lblUpdateRSSURL);
            this.gbavailableFeeds.Controls.Add(this.txtbUpdateFeedName);
            this.gbavailableFeeds.Controls.Add(this.txtbUpdateFeedURL);
            this.gbavailableFeeds.Controls.Add(this.lblUpdatreFeedName);
            this.gbavailableFeeds.Controls.Add(this.btnUpdateFeedName);
            this.gbavailableFeeds.Location = new System.Drawing.Point(3, 349);
            this.gbavailableFeeds.Name = "gbavailableFeeds";
            this.gbavailableFeeds.Size = new System.Drawing.Size(683, 375);
            this.gbavailableFeeds.TabIndex = 21;
            this.gbavailableFeeds.TabStop = false;
            this.gbavailableFeeds.Text = "Aavailable Feeds";
            // 
            // chkbDisabledFeed
            // 
            this.chkbDisabledFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkbDisabledFeed.AutoEllipsis = true;
            this.chkbDisabledFeed.Location = new System.Drawing.Point(11, 348);
            this.chkbDisabledFeed.Name = "chkbDisabledFeed";
            this.chkbDisabledFeed.Size = new System.Drawing.Size(488, 21);
            this.chkbDisabledFeed.TabIndex = 22;
            this.chkbDisabledFeed.Text = "Disabled Feed (won\'t be refreshed at all)";
            this.chkbDisabledFeed.UseVisualStyleBackColor = true;
            // 
            // btnClearAllHistories
            // 
            this.btnClearAllHistories.Location = new System.Drawing.Point(233, 22);
            this.btnClearAllHistories.Name = "btnClearAllHistories";
            this.btnClearAllHistories.Size = new System.Drawing.Size(249, 31);
            this.btnClearAllHistories.TabIndex = 21;
            this.btnClearAllHistories.Text = "Clear all Feeds Histories";
            this.btnClearAllHistories.UseVisualStyleBackColor = true;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(119, 22);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(107, 31);
            this.btnSelectAll.TabIndex = 20;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            // 
            // btnUnselectAll
            // 
            this.btnUnselectAll.Location = new System.Drawing.Point(6, 22);
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.Size = new System.Drawing.Size(107, 31);
            this.btnUnselectAll.TabIndex = 19;
            this.btnUnselectAll.Text = "Unselect All";
            this.btnUnselectAll.UseVisualStyleBackColor = true;
            // 
            // btnClearPosts
            // 
            this.btnClearPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearPosts.BackgroundImage = global::Aggregator.GUI.Properties.Resources.history_clear;
            this.btnClearPosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearPosts.Location = new System.Drawing.Point(625, 124);
            this.btnClearPosts.Name = "btnClearPosts";
            this.btnClearPosts.Size = new System.Drawing.Size(52, 54);
            this.btnClearPosts.TabIndex = 12;
            this.btnClearPosts.UseVisualStyleBackColor = true;
            this.btnClearPosts.Click += new System.EventHandler(this.btnClearPosts_Click);
            // 
            // btnDeleteRSS
            // 
            this.btnDeleteRSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRSS.Image = global::Aggregator.GUI.Properties.Resources.delete;
            this.btnDeleteRSS.Location = new System.Drawing.Point(625, 64);
            this.btnDeleteRSS.Name = "btnDeleteRSS";
            this.btnDeleteRSS.Size = new System.Drawing.Size(52, 54);
            this.btnDeleteRSS.TabIndex = 4;
            this.btnDeleteRSS.UseVisualStyleBackColor = true;
            this.btnDeleteRSS.Click += new System.EventHandler(this.btnDeleteRSS_Click);
            // 
            // btnUpdateResetDownloadCount
            // 
            this.btnUpdateResetDownloadCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateResetDownloadCount.Image = global::Aggregator.GUI.Properties.Resources.resetIcon;
            this.btnUpdateResetDownloadCount.Location = new System.Drawing.Point(305, 234);
            this.btnUpdateResetDownloadCount.Name = "btnUpdateResetDownloadCount";
            this.btnUpdateResetDownloadCount.Size = new System.Drawing.Size(86, 38);
            this.btnUpdateResetDownloadCount.TabIndex = 15;
            this.btnUpdateResetDownloadCount.UseVisualStyleBackColor = true;
            this.btnUpdateResetDownloadCount.Click += new System.EventHandler(this.btnUpdateResetDownloadCount_Click);
            // 
            // btnViewPosts
            // 
            this.btnViewPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewPosts.BackgroundImage = global::Aggregator.GUI.Properties.Resources.rss_icon_transparent;
            this.btnViewPosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewPosts.Location = new System.Drawing.Point(625, 184);
            this.btnViewPosts.Name = "btnViewPosts";
            this.btnViewPosts.Size = new System.Drawing.Size(52, 54);
            this.btnViewPosts.TabIndex = 16;
            this.btnViewPosts.UseVisualStyleBackColor = true;
            this.btnViewPosts.Click += new System.EventHandler(this.btnViewPosts_Click);
            // 
            // spltcMain
            // 
            this.spltcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltcMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spltcMain.Location = new System.Drawing.Point(0, 0);
            this.spltcMain.Name = "spltcMain";
            // 
            // spltcMain.Panel1
            // 
            this.spltcMain.Panel1.Controls.Add(this.lvItems);
            // 
            // spltcMain.Panel2
            // 
            this.spltcMain.Panel2.Controls.Add(this.pnlRSSSettings);
            this.spltcMain.Panel2.Controls.Add(this.pnlGeneralSettings);
            this.spltcMain.Panel2.Controls.Add(this.pnlOutlook);
            this.spltcMain.Panel2.Controls.Add(this.pnlRSScategories);
            this.spltcMain.Size = new System.Drawing.Size(1055, 808);
            this.spltcMain.SplitterDistance = 144;
            this.spltcMain.TabIndex = 21;
            // 
            // lvItems
            // 
            this.lvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvItems.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lvItems.LargeImageList = this.imageList1;
            this.lvItems.Location = new System.Drawing.Point(0, 0);
            this.lvItems.MultiSelect = false;
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(144, 808);
            this.lvItems.TabIndex = 21;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.SelectedIndexChanged += new System.EventHandler(this.lvItems_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "RSSOUTLOOK.ico");
            this.imageList1.Images.SetKeyName(1, "rss icon transparent.gif");
            this.imageList1.Images.SetKeyName(2, "thumb_Outlook.ico");
            this.imageList1.Images.SetKeyName(3, "appicon.png");
            this.imageList1.Images.SetKeyName(4, "rsscategories.jpg");
            // 
            // pnlGeneralSettings
            // 
            this.pnlGeneralSettings.Controls.Add(this.lblColor);
            this.pnlGeneralSettings.Controls.Add(this.chkColorUnreadPosts);
            this.pnlGeneralSettings.Controls.Add(this.chkBoldUnreadPosts);
            this.pnlGeneralSettings.Controls.Add(this.chkRemoveAfterRead);
            this.pnlGeneralSettings.Controls.Add(this.chkbTaskBarIcon);
            this.pnlGeneralSettings.Controls.Add(this.chkbRSSSaveToDiskOnRefresh);
            this.pnlGeneralSettings.Controls.Add(this.chkbNotifyOnRSSErrors);
            this.pnlGeneralSettings.Controls.Add(this.gbFilesLocation);
            this.pnlGeneralSettings.Controls.Add(this.btnSaveSettings);
            this.pnlGeneralSettings.Controls.Add(this.nudOutlookInterval);
            this.pnlGeneralSettings.Controls.Add(this.lblOutlookInterval);
            this.pnlGeneralSettings.Controls.Add(this.nudRSSInterval);
            this.pnlGeneralSettings.Controls.Add(this.lblRSSInterval);
            this.pnlGeneralSettings.Controls.Add(this.chkbEnableOutlookOnStart);
            this.pnlGeneralSettings.Location = new System.Drawing.Point(19, 46);
            this.pnlGeneralSettings.Name = "pnlGeneralSettings";
            this.pnlGeneralSettings.Size = new System.Drawing.Size(876, 545);
            this.pnlGeneralSettings.TabIndex = 21;
            // 
            // lblColor
            // 
            this.lblColor.AutoEllipsis = true;
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Location = new System.Drawing.Point(486, 234);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(51, 35);
            this.lblColor.TabIndex = 60;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // chkColorUnreadPosts
            // 
            this.chkColorUnreadPosts.AutoEllipsis = true;
            this.chkColorUnreadPosts.Location = new System.Drawing.Point(16, 242);
            this.chkColorUnreadPosts.Name = "chkColorUnreadPosts";
            this.chkColorUnreadPosts.Size = new System.Drawing.Size(437, 25);
            this.chkColorUnreadPosts.TabIndex = 59;
            this.chkColorUnreadPosts.Text = "Mark unread posts with different background color:";
            this.chkColorUnreadPosts.UseVisualStyleBackColor = true;
            // 
            // chkBoldUnreadPosts
            // 
            this.chkBoldUnreadPosts.AutoEllipsis = true;
            this.chkBoldUnreadPosts.Location = new System.Drawing.Point(16, 212);
            this.chkBoldUnreadPosts.Name = "chkBoldUnreadPosts";
            this.chkBoldUnreadPosts.Size = new System.Drawing.Size(831, 25);
            this.chkBoldUnreadPosts.TabIndex = 58;
            this.chkBoldUnreadPosts.Text = "Mark unread posts with bold font";
            this.chkBoldUnreadPosts.UseVisualStyleBackColor = true;
            // 
            // chkRemoveAfterRead
            // 
            this.chkRemoveAfterRead.AutoEllipsis = true;
            this.chkRemoveAfterRead.Location = new System.Drawing.Point(16, 272);
            this.chkRemoveAfterRead.Name = "chkRemoveAfterRead";
            this.chkRemoveAfterRead.Size = new System.Drawing.Size(831, 34);
            this.chkRemoveAfterRead.TabIndex = 57;
            this.chkRemoveAfterRead.Text = "Remove Posts from List as soon as it read (keep only Unread posts visible)";
            this.chkRemoveAfterRead.UseVisualStyleBackColor = true;
            // 
            // chkbTaskBarIcon
            // 
            this.chkbTaskBarIcon.AutoEllipsis = true;
            this.chkbTaskBarIcon.Location = new System.Drawing.Point(16, 176);
            this.chkbTaskBarIcon.Name = "chkbTaskBarIcon";
            this.chkbTaskBarIcon.Size = new System.Drawing.Size(715, 31);
            this.chkbTaskBarIcon.TabIndex = 24;
            this.chkbTaskBarIcon.Text = "Show Taskbar Icon";
            this.chkbTaskBarIcon.UseVisualStyleBackColor = true;
            // 
            // chkbRSSSaveToDiskOnRefresh
            // 
            this.chkbRSSSaveToDiskOnRefresh.AutoEllipsis = true;
            this.chkbRSSSaveToDiskOnRefresh.Location = new System.Drawing.Point(16, 311);
            this.chkbRSSSaveToDiskOnRefresh.Name = "chkbRSSSaveToDiskOnRefresh";
            this.chkbRSSSaveToDiskOnRefresh.Size = new System.Drawing.Size(667, 25);
            this.chkbRSSSaveToDiskOnRefresh.TabIndex = 23;
            this.chkbRSSSaveToDiskOnRefresh.Text = "Save RSS feeds to disk on every refresh";
            this.chkbRSSSaveToDiskOnRefresh.UseVisualStyleBackColor = true;
            // 
            // chkbNotifyOnRSSErrors
            // 
            this.chkbNotifyOnRSSErrors.AutoEllipsis = true;
            this.chkbNotifyOnRSSErrors.Checked = true;
            this.chkbNotifyOnRSSErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbNotifyOnRSSErrors.Location = new System.Drawing.Point(16, 341);
            this.chkbNotifyOnRSSErrors.Name = "chkbNotifyOnRSSErrors";
            this.chkbNotifyOnRSSErrors.Size = new System.Drawing.Size(682, 31);
            this.chkbNotifyOnRSSErrors.TabIndex = 10;
            this.chkbNotifyOnRSSErrors.Text = "Notify me of RSS Reading Errors (Timeouts, DNS Errors and so on)";
            this.chkbNotifyOnRSSErrors.UseVisualStyleBackColor = true;
            // 
            // gbFilesLocation
            // 
            this.gbFilesLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilesLocation.Controls.Add(this.rbtnPerUsers);
            this.gbFilesLocation.Controls.Add(this.rbtnForAllUsers);
            this.gbFilesLocation.Location = new System.Drawing.Point(11, 12);
            this.gbFilesLocation.Name = "gbFilesLocation";
            this.gbFilesLocation.Size = new System.Drawing.Size(857, 127);
            this.gbFilesLocation.TabIndex = 0;
            this.gbFilesLocation.TabStop = false;
            this.gbFilesLocation.Text = "File locations";
            // 
            // rbtnPerUsers
            // 
            this.rbtnPerUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnPerUsers.AutoEllipsis = true;
            this.rbtnPerUsers.Location = new System.Drawing.Point(18, 63);
            this.rbtnPerUsers.Name = "rbtnPerUsers";
            this.rbtnPerUsers.Size = new System.Drawing.Size(822, 58);
            this.rbtnPerUsers.TabIndex = 1;
            this.rbtnPerUsers.Text = "Per User (files will be saved in the following folder: )";
            this.rbtnPerUsers.UseVisualStyleBackColor = true;
            // 
            // rbtnForAllUsers
            // 
            this.rbtnForAllUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnForAllUsers.AutoEllipsis = true;
            this.rbtnForAllUsers.Checked = true;
            this.rbtnForAllUsers.Location = new System.Drawing.Point(19, 25);
            this.rbtnForAllUsers.Name = "rbtnForAllUsers";
            this.rbtnForAllUsers.Size = new System.Drawing.Size(822, 35);
            this.rbtnForAllUsers.TabIndex = 0;
            this.rbtnForAllUsers.TabStop = true;
            this.rbtnForAllUsers.Text = "For all Users (files will be saved in the application folder)";
            this.rbtnForAllUsers.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveSettings.Location = new System.Drawing.Point(372, 494);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(132, 39);
            this.btnSaveSettings.TabIndex = 9;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            // 
            // nudOutlookInterval
            // 
            this.nudOutlookInterval.Enabled = false;
            this.nudOutlookInterval.Location = new System.Drawing.Point(368, 446);
            this.nudOutlookInterval.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.nudOutlookInterval.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudOutlookInterval.Name = "nudOutlookInterval";
            this.nudOutlookInterval.Size = new System.Drawing.Size(52, 28);
            this.nudOutlookInterval.TabIndex = 6;
            this.nudOutlookInterval.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblOutlookInterval
            // 
            this.lblOutlookInterval.AutoEllipsis = true;
            this.lblOutlookInterval.Location = new System.Drawing.Point(12, 448);
            this.lblOutlookInterval.Name = "lblOutlookInterval";
            this.lblOutlookInterval.Size = new System.Drawing.Size(337, 26);
            this.lblOutlookInterval.TabIndex = 5;
            this.lblOutlookInterval.Text = "Time (in minutes) for outlook update:";
            // 
            // nudRSSInterval
            // 
            this.nudRSSInterval.Location = new System.Drawing.Point(368, 147);
            this.nudRSSInterval.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.nudRSSInterval.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudRSSInterval.Name = "nudRSSInterval";
            this.nudRSSInterval.Size = new System.Drawing.Size(52, 28);
            this.nudRSSInterval.TabIndex = 4;
            this.nudRSSInterval.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblRSSInterval
            // 
            this.lblRSSInterval.AutoEllipsis = true;
            this.lblRSSInterval.Location = new System.Drawing.Point(12, 150);
            this.lblRSSInterval.Name = "lblRSSInterval";
            this.lblRSSInterval.Size = new System.Drawing.Size(337, 24);
            this.lblRSSInterval.TabIndex = 3;
            this.lblRSSInterval.Text = "Time (in minutes) for update:";
            // 
            // chkbEnableOutlookOnStart
            // 
            this.chkbEnableOutlookOnStart.AutoEllipsis = true;
            this.chkbEnableOutlookOnStart.Location = new System.Drawing.Point(16, 405);
            this.chkbEnableOutlookOnStart.Name = "chkbEnableOutlookOnStart";
            this.chkbEnableOutlookOnStart.Size = new System.Drawing.Size(684, 37);
            this.chkbEnableOutlookOnStart.TabIndex = 2;
            this.chkbEnableOutlookOnStart.Text = "Launch Outlook reader on startup";
            this.chkbEnableOutlookOnStart.UseVisualStyleBackColor = true;
            this.chkbEnableOutlookOnStart.CheckedChanged += new System.EventHandler(this.chkbEnableOutlook_CheckedChanged);
            // 
            // pnlOutlook
            // 
            this.pnlOutlook.Controls.Add(this.btnOutlookSAveSettings);
            this.pnlOutlook.Controls.Add(this.tvOutlookFolders);
            this.pnlOutlook.Controls.Add(this.lblbOutlookFolders);
            this.pnlOutlook.Location = new System.Drawing.Point(3, 17);
            this.pnlOutlook.Name = "pnlOutlook";
            this.pnlOutlook.Size = new System.Drawing.Size(725, 421);
            this.pnlOutlook.TabIndex = 22;
            // 
            // btnOutlookSAveSettings
            // 
            this.btnOutlookSAveSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOutlookSAveSettings.Enabled = false;
            this.btnOutlookSAveSettings.Location = new System.Drawing.Point(306, 370);
            this.btnOutlookSAveSettings.Name = "btnOutlookSAveSettings";
            this.btnOutlookSAveSettings.Size = new System.Drawing.Size(132, 39);
            this.btnOutlookSAveSettings.TabIndex = 8;
            this.btnOutlookSAveSettings.Text = "Save";
            this.btnOutlookSAveSettings.UseVisualStyleBackColor = true;
            // 
            // tvOutlookFolders
            // 
            this.tvOutlookFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvOutlookFolders.CheckBoxes = true;
            this.tvOutlookFolders.Location = new System.Drawing.Point(12, 47);
            this.tvOutlookFolders.Name = "tvOutlookFolders";
            this.tvOutlookFolders.Size = new System.Drawing.Size(702, 317);
            this.tvOutlookFolders.TabIndex = 6;
            // 
            // lblbOutlookFolders
            // 
            this.lblbOutlookFolders.AutoEllipsis = true;
            this.lblbOutlookFolders.Enabled = false;
            this.lblbOutlookFolders.Location = new System.Drawing.Point(9, 14);
            this.lblbOutlookFolders.Name = "lblbOutlookFolders";
            this.lblbOutlookFolders.Size = new System.Drawing.Size(696, 30);
            this.lblbOutlookFolders.TabIndex = 7;
            this.lblbOutlookFolders.Text = "Show unread mails from the following folders only: (pending)";
            // 
            // pnlRSScategories
            // 
            this.pnlRSScategories.Controls.Add(this.spltcFeedsCategories);
            this.pnlRSScategories.Location = new System.Drawing.Point(119, 87);
            this.pnlRSScategories.Name = "pnlRSScategories";
            this.pnlRSScategories.Size = new System.Drawing.Size(713, 338);
            this.pnlRSScategories.TabIndex = 23;
            // 
            // spltcFeedsCategories
            // 
            this.spltcFeedsCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltcFeedsCategories.Location = new System.Drawing.Point(0, 0);
            this.spltcFeedsCategories.Name = "spltcFeedsCategories";
            // 
            // spltcFeedsCategories.Panel1
            // 
            this.spltcFeedsCategories.Panel1.Controls.Add(this.gbFeedsForCategories);
            // 
            // spltcFeedsCategories.Panel2
            // 
            this.spltcFeedsCategories.Panel2.Controls.Add(this.gbCategories);
            this.spltcFeedsCategories.Size = new System.Drawing.Size(713, 338);
            this.spltcFeedsCategories.SplitterDistance = 284;
            this.spltcFeedsCategories.TabIndex = 2;
            // 
            // gbFeedsForCategories
            // 
            this.gbFeedsForCategories.Controls.Add(this.lblFeedForCategories);
            this.gbFeedsForCategories.Controls.Add(this.lstbFeedsForCategories);
            this.gbFeedsForCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFeedsForCategories.Location = new System.Drawing.Point(0, 0);
            this.gbFeedsForCategories.Name = "gbFeedsForCategories";
            this.gbFeedsForCategories.Size = new System.Drawing.Size(284, 338);
            this.gbFeedsForCategories.TabIndex = 2;
            this.gbFeedsForCategories.TabStop = false;
            this.gbFeedsForCategories.Text = "Feeds:";
            // 
            // lblFeedForCategories
            // 
            this.lblFeedForCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFeedForCategories.AutoEllipsis = true;
            this.lblFeedForCategories.Location = new System.Drawing.Point(6, 300);
            this.lblFeedForCategories.Name = "lblFeedForCategories";
            this.lblFeedForCategories.Size = new System.Drawing.Size(271, 28);
            this.lblFeedForCategories.TabIndex = 4;
            this.lblFeedForCategories.Text = "Selected:";
            // 
            // lstbFeedsForCategories
            // 
            this.lstbFeedsForCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbFeedsForCategories.FormattingEnabled = true;
            this.lstbFeedsForCategories.ItemHeight = 20;
            this.lstbFeedsForCategories.Location = new System.Drawing.Point(6, 26);
            this.lstbFeedsForCategories.Name = "lstbFeedsForCategories";
            this.lstbFeedsForCategories.Size = new System.Drawing.Size(272, 264);
            this.lstbFeedsForCategories.TabIndex = 0;
            this.lstbFeedsForCategories.SelectedIndexChanged += new System.EventHandler(this.lstbFeedsForCategories_SelectedIndexChanged);
            // 
            // gbCategories
            // 
            this.gbCategories.Controls.Add(this.chklstbCategories);
            this.gbCategories.Controls.Add(this.lblNewCategoryName);
            this.gbCategories.Controls.Add(this.txtbNewCategoryName);
            this.gbCategories.Controls.Add(this.btnCategoriesDelete);
            this.gbCategories.Controls.Add(this.btnCategoriesAdd);
            this.gbCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCategories.Location = new System.Drawing.Point(0, 0);
            this.gbCategories.Name = "gbCategories";
            this.gbCategories.Size = new System.Drawing.Size(425, 338);
            this.gbCategories.TabIndex = 1;
            this.gbCategories.TabStop = false;
            this.gbCategories.Text = "Categories:";
            // 
            // chklstbCategories
            // 
            this.chklstbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chklstbCategories.FormattingEnabled = true;
            this.chklstbCategories.Location = new System.Drawing.Point(10, 26);
            this.chklstbCategories.Name = "chklstbCategories";
            this.chklstbCategories.Size = new System.Drawing.Size(347, 257);
            this.chklstbCategories.TabIndex = 5;
            this.chklstbCategories.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstbCategories_ItemCheck);
            // 
            // lblNewCategoryName
            // 
            this.lblNewCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNewCategoryName.AutoEllipsis = true;
            this.lblNewCategoryName.Location = new System.Drawing.Point(6, 295);
            this.lblNewCategoryName.Name = "lblNewCategoryName";
            this.lblNewCategoryName.Size = new System.Drawing.Size(184, 28);
            this.lblNewCategoryName.TabIndex = 4;
            this.lblNewCategoryName.Text = "New Category Name:";
            // 
            // txtbNewCategoryName
            // 
            this.txtbNewCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbNewCategoryName.Location = new System.Drawing.Point(198, 295);
            this.txtbNewCategoryName.Name = "txtbNewCategoryName";
            this.txtbNewCategoryName.Size = new System.Drawing.Size(160, 28);
            this.txtbNewCategoryName.TabIndex = 3;
            // 
            // btnCategoriesDelete
            // 
            this.btnCategoriesDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategoriesDelete.BackgroundImage = global::Aggregator.GUI.Properties.Resources.deleteicon2;
            this.btnCategoriesDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCategoriesDelete.Location = new System.Drawing.Point(364, 88);
            this.btnCategoriesDelete.Name = "btnCategoriesDelete";
            this.btnCategoriesDelete.Size = new System.Drawing.Size(55, 45);
            this.btnCategoriesDelete.TabIndex = 2;
            this.btnCategoriesDelete.UseVisualStyleBackColor = true;
            this.btnCategoriesDelete.Click += new System.EventHandler(this.btnCategoriesDelete_Click);
            // 
            // btnCategoriesAdd
            // 
            this.btnCategoriesAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategoriesAdd.BackgroundImage = global::Aggregator.GUI.Properties.Resources._1;
            this.btnCategoriesAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCategoriesAdd.Location = new System.Drawing.Point(364, 287);
            this.btnCategoriesAdd.Name = "btnCategoriesAdd";
            this.btnCategoriesAdd.Size = new System.Drawing.Size(55, 45);
            this.btnCategoriesAdd.TabIndex = 1;
            this.btnCategoriesAdd.UseVisualStyleBackColor = true;
            this.btnCategoriesAdd.Click += new System.EventHandler(this.btnCategoriesAdd_Click);
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 808);
            this.Controls.Add(this.spltcMain);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(18, 570);
            this.Name = "SettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS feeds Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsDialog_FormClosing);
            this.Load += new System.EventHandler(this.SettingsDialog_Load);
            this.gpNewFeed.ResumeLayout(false);
            this.tbNewFeeds.ResumeLayout(false);
            this.tpStandardFeeds.ResumeLayout(false);
            this.tpStandardFeeds.PerformLayout();
            this.gbEncodings.ResumeLayout(false);
            this.gbEncodings.PerformLayout();
            this.tpCustomFeeds.ResumeLayout(false);
            this.pnlRSSSettings.ResumeLayout(false);
            this.gbavailableFeeds.ResumeLayout(false);
            this.gbavailableFeeds.PerformLayout();
            this.spltcMain.Panel1.ResumeLayout(false);
            this.spltcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltcMain)).EndInit();
            this.spltcMain.ResumeLayout(false);
            this.pnlGeneralSettings.ResumeLayout(false);
            this.gbFilesLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudOutlookInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRSSInterval)).EndInit();
            this.pnlOutlook.ResumeLayout(false);
            this.pnlRSScategories.ResumeLayout(false);
            this.spltcFeedsCategories.Panel1.ResumeLayout(false);
            this.spltcFeedsCategories.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltcFeedsCategories)).EndInit();
            this.spltcFeedsCategories.ResumeLayout(false);
            this.gbFeedsForCategories.ResumeLayout(false);
            this.gbCategories.ResumeLayout(false);
            this.gbCategories.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbRSSURL;
        private System.Windows.Forms.Label lblRSSURL;
        private System.Windows.Forms.Button btnAddRSS;
        private System.Windows.Forms.CheckedListBox chkblstRSSItems;
        private System.Windows.Forms.Button btnDeleteRSS;
        private System.Windows.Forms.Label lblRSSName;
        private System.Windows.Forms.TextBox txtbRSSName;
        private System.Windows.Forms.Label lblUpdatreFeedName;
        private System.Windows.Forms.TextBox txtbUpdateFeedName;
        private System.Windows.Forms.Button btnUpdateFeedName;
        private System.Windows.Forms.Label lblUpdateRSSURL;
        private System.Windows.Forms.TextBox txtbUpdateFeedURL;
        private System.Windows.Forms.Button btnClearPosts;
        private System.Windows.Forms.Label lblTotalDownloaded;
        private System.Windows.Forms.Button btnUpdateResetDownloadCount;
        private System.Windows.Forms.Button btnViewPosts;
        private System.Windows.Forms.CheckBox chkbNewPrivate;
        private System.Windows.Forms.CheckBox chkbPrivate;
        private System.Windows.Forms.GroupBox gpNewFeed;
        private System.Windows.Forms.Panel pnlRSSSettings;
        private System.Windows.Forms.SplitContainer spltcMain;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlGeneralSettings;
        private System.Windows.Forms.GroupBox gbFilesLocation;
        private System.Windows.Forms.RadioButton rbtnPerUsers;
        private System.Windows.Forms.RadioButton rbtnForAllUsers;
        private System.Windows.Forms.Panel pnlOutlook;
        private System.Windows.Forms.TreeView tvOutlookFolders;
        private System.Windows.Forms.Label lblbOutlookFolders;
        private System.Windows.Forms.Button btnOutlookSAveSettings;
        private System.Windows.Forms.CheckBox chkbEnableOutlookOnStart;
        private System.Windows.Forms.NumericUpDown nudOutlookInterval;
        private System.Windows.Forms.Label lblOutlookInterval;
        private System.Windows.Forms.NumericUpDown nudRSSInterval;
        private System.Windows.Forms.Label lblRSSInterval;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.GroupBox gbavailableFeeds;
        private System.Windows.Forms.CheckBox chkbNotifyOnRSSErrors;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnUnselectAll;
        private System.Windows.Forms.Label lblSaveTime;
        private System.Windows.Forms.TabControl tbNewFeeds;
        private System.Windows.Forms.TabPage tpStandardFeeds;
        private System.Windows.Forms.TabPage tpCustomFeeds;
        private System.Windows.Forms.RadioButton rbCustomFeedGmail;
        private System.Windows.Forms.Button btnAddRSSCustom;
        private System.Windows.Forms.Button btnClearAllHistories;
        private System.Windows.Forms.CheckBox chkbRSSSaveToDiskOnRefresh;
        private System.Windows.Forms.CheckBox chkbTaskBarIcon;
        private System.Windows.Forms.CheckBox chkbDontKeepHistory;
        private System.Windows.Forms.Label lblEncoding;
        private System.Windows.Forms.RadioButton rbcodepage;
        private System.Windows.Forms.RadioButton rbEncodingUTF8;
        private System.Windows.Forms.RadioButton rbEncodingUTF32;
        private System.Windows.Forms.RadioButton rbEncodingUTF7;
        private System.Windows.Forms.RadioButton rbEncodingUnicode;
        private System.Windows.Forms.CheckBox chkbDisabledFeed;
        private System.Windows.Forms.Panel pnlRSScategories;
        private System.Windows.Forms.GroupBox gbCategories;
        private System.Windows.Forms.Button btnCategoriesAdd;
        private System.Windows.Forms.Button btnCategoriesDelete;
        private System.Windows.Forms.Label lblNewCategoryName;
        private System.Windows.Forms.TextBox txtbNewCategoryName;
        private System.Windows.Forms.SplitContainer spltcFeedsCategories;
        private System.Windows.Forms.GroupBox gbFeedsForCategories;
        private System.Windows.Forms.Label lblFeedForCategories;
        private System.Windows.Forms.ListBox lstbFeedsForCategories;
        private System.Windows.Forms.CheckedListBox chklstbCategories;
        private System.Windows.Forms.ComboBox cbCodepages;
        private System.Windows.Forms.GroupBox gbEncodings;
        private System.Windows.Forms.RadioButton rbCustomFeedFBWall;
        private System.Windows.Forms.RadioButton rbCustomFeedFBReaderSourceForgeFiles;
        private System.Windows.Forms.RadioButton rbCustomFeedFBReaderFBWall;
        private System.Windows.Forms.RadioButton rbCustomFeedSourceForgeFiles;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.CheckBox chkColorUnreadPosts;
        private System.Windows.Forms.CheckBox chkBoldUnreadPosts;
        private System.Windows.Forms.CheckBox chkRemoveAfterRead;
    }
}