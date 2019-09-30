namespace Aggregator.GUI.WinForms.Old
{
    partial class FeedInformationDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedInformationDialog));
            this.lblRSSURL = new System.Windows.Forms.Label();
            this.dgvRSSPosts = new System.Windows.Forms.DataGridView();
            this.lbldownloadedSize = new System.Windows.Forms.Label();
            this.gbFeedInfo = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkbIgnoreHistory = new System.Windows.Forms.CheckBox();
            this.txtbRSSName = new System.Windows.Forms.TextBox();
            this.chkbPrivateFeed = new System.Windows.Forms.CheckBox();
            this.chkbActiveFeed = new System.Windows.Forms.CheckBox();
            this.lblTotalUpdates = new System.Windows.Forms.Label();
            this.lblUnreadItems = new System.Windows.Forms.Label();
            this.gbCategories = new System.Windows.Forms.GroupBox();
            this.chklstbCategories = new System.Windows.Forms.CheckedListBox();
            this.gbPosts = new System.Windows.Forms.GroupBox();
            this.gbSelectedPost = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.chkbHistory = new System.Windows.Forms.CheckBox();
            this.chkbShowHiddenPosts = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkbDisabled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRSSPosts)).BeginInit();
            this.gbFeedInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbCategories.SuspendLayout();
            this.gbPosts.SuspendLayout();
            this.gbSelectedPost.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRSSURL
            // 
            this.lblRSSURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRSSURL.AutoEllipsis = true;
            this.lblRSSURL.Location = new System.Drawing.Point(9, 10);
            this.lblRSSURL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRSSURL.Name = "lblRSSURL";
            this.lblRSSURL.Size = new System.Drawing.Size(508, 22);
            this.lblRSSURL.TabIndex = 7;
            this.lblRSSURL.Text = "RSS URL:";
            // 
            // dgvRSSPosts
            // 
            this.dgvRSSPosts.AllowUserToAddRows = false;
            this.dgvRSSPosts.AllowUserToDeleteRows = false;
            this.dgvRSSPosts.AllowUserToOrderColumns = true;
            this.dgvRSSPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRSSPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRSSPosts.Location = new System.Drawing.Point(9, 138);
            this.dgvRSSPosts.Name = "dgvRSSPosts";
            this.dgvRSSPosts.ReadOnly = true;
            this.dgvRSSPosts.RowTemplate.Height = 24;
            this.dgvRSSPosts.Size = new System.Drawing.Size(1079, 182);
            this.dgvRSSPosts.TabIndex = 9;
            this.dgvRSSPosts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRSSPosts_CellDoubleClick);
            this.dgvRSSPosts.Click += new System.EventHandler(this.dgvRSSPosts_Click);
            // 
            // lbldownloadedSize
            // 
            this.lbldownloadedSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldownloadedSize.AutoEllipsis = true;
            this.lbldownloadedSize.Location = new System.Drawing.Point(9, 97);
            this.lbldownloadedSize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbldownloadedSize.Name = "lbldownloadedSize";
            this.lbldownloadedSize.Size = new System.Drawing.Size(508, 22);
            this.lbldownloadedSize.TabIndex = 10;
            this.lbldownloadedSize.Text = "Downloaded Size:";
            // 
            // gbFeedInfo
            // 
            this.gbFeedInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFeedInfo.Controls.Add(this.splitContainer1);
            this.gbFeedInfo.Location = new System.Drawing.Point(18, 11);
            this.gbFeedInfo.Name = "gbFeedInfo";
            this.gbFeedInfo.Size = new System.Drawing.Size(1104, 291);
            this.gbFeedInfo.TabIndex = 11;
            this.gbFeedInfo.TabStop = false;
            this.gbFeedInfo.Text = "Feed Information";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkbDisabled);
            this.splitContainer1.Panel1.Controls.Add(this.chkbIgnoreHistory);
            this.splitContainer1.Panel1.Controls.Add(this.txtbRSSName);
            this.splitContainer1.Panel1.Controls.Add(this.chkbPrivateFeed);
            this.splitContainer1.Panel1.Controls.Add(this.chkbActiveFeed);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalUpdates);
            this.splitContainer1.Panel1.Controls.Add(this.lblUnreadItems);
            this.splitContainer1.Panel1.Controls.Add(this.lblRSSURL);
            this.splitContainer1.Panel1.Controls.Add(this.lbldownloadedSize);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbCategories);
            this.splitContainer1.Size = new System.Drawing.Size(1098, 264);
            this.splitContainer1.SplitterDistance = 529;
            this.splitContainer1.TabIndex = 0;
            // 
            // chkbIgnoreHistory
            // 
            this.chkbIgnoreHistory.AutoEllipsis = true;
            this.chkbIgnoreHistory.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbIgnoreHistory.Location = new System.Drawing.Point(11, 201);
            this.chkbIgnoreHistory.Name = "chkbIgnoreHistory";
            this.chkbIgnoreHistory.Size = new System.Drawing.Size(338, 29);
            this.chkbIgnoreHistory.TabIndex = 18;
            this.chkbIgnoreHistory.Text = "Don\'t keep history for new posts in feed";
            this.chkbIgnoreHistory.UseVisualStyleBackColor = true;
            this.chkbIgnoreHistory.Click += new System.EventHandler(this.chkbIgnoreHistory_Click);
            // 
            // txtbRSSName
            // 
            this.txtbRSSName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbRSSName.BackColor = System.Drawing.SystemColors.Control;
            this.txtbRSSName.Location = new System.Drawing.Point(11, 38);
            this.txtbRSSName.Name = "txtbRSSName";
            this.txtbRSSName.Size = new System.Drawing.Size(505, 28);
            this.txtbRSSName.TabIndex = 17;
            this.txtbRSSName.Text = "RSS Name:";
            // 
            // chkbPrivateFeed
            // 
            this.chkbPrivateFeed.AutoEllipsis = true;
            this.chkbPrivateFeed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbPrivateFeed.Location = new System.Drawing.Point(11, 174);
            this.chkbPrivateFeed.Name = "chkbPrivateFeed";
            this.chkbPrivateFeed.Size = new System.Drawing.Size(338, 29);
            this.chkbPrivateFeed.TabIndex = 15;
            this.chkbPrivateFeed.Text = "Private feed (No caching):";
            this.chkbPrivateFeed.UseVisualStyleBackColor = true;
            this.chkbPrivateFeed.Click += new System.EventHandler(this.chkbPrivateFeed_Click);
            // 
            // chkbActiveFeed
            // 
            this.chkbActiveFeed.AutoEllipsis = true;
            this.chkbActiveFeed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbActiveFeed.Location = new System.Drawing.Point(8, 145);
            this.chkbActiveFeed.Name = "chkbActiveFeed";
            this.chkbActiveFeed.Size = new System.Drawing.Size(341, 29);
            this.chkbActiveFeed.TabIndex = 14;
            this.chkbActiveFeed.Text = "Active Feed: ";
            this.chkbActiveFeed.UseVisualStyleBackColor = true;
            this.chkbActiveFeed.Click += new System.EventHandler(this.chkbActiveFeed_Click);
            // 
            // lblTotalUpdates
            // 
            this.lblTotalUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalUpdates.AutoEllipsis = true;
            this.lblTotalUpdates.Location = new System.Drawing.Point(9, 72);
            this.lblTotalUpdates.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalUpdates.Name = "lblTotalUpdates";
            this.lblTotalUpdates.Size = new System.Drawing.Size(508, 22);
            this.lblTotalUpdates.TabIndex = 11;
            this.lblTotalUpdates.Text = "Number of updates: ";
            // 
            // lblUnreadItems
            // 
            this.lblUnreadItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnreadItems.AutoEllipsis = true;
            this.lblUnreadItems.Location = new System.Drawing.Point(9, 123);
            this.lblUnreadItems.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUnreadItems.Name = "lblUnreadItems";
            this.lblUnreadItems.Size = new System.Drawing.Size(508, 22);
            this.lblUnreadItems.TabIndex = 12;
            this.lblUnreadItems.Text = "Unread Posts: ";
            // 
            // gbCategories
            // 
            this.gbCategories.Controls.Add(this.chklstbCategories);
            this.gbCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCategories.Location = new System.Drawing.Point(0, 0);
            this.gbCategories.Name = "gbCategories";
            this.gbCategories.Size = new System.Drawing.Size(565, 264);
            this.gbCategories.TabIndex = 0;
            this.gbCategories.TabStop = false;
            this.gbCategories.Text = "Belongs to Categories:";
            // 
            // chklstbCategories
            // 
            this.chklstbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chklstbCategories.FormattingEnabled = true;
            this.chklstbCategories.Location = new System.Drawing.Point(8, 27);
            this.chklstbCategories.Name = "chklstbCategories";
            this.chklstbCategories.Size = new System.Drawing.Size(549, 234);
            this.chklstbCategories.TabIndex = 0;
            this.chklstbCategories.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstbCategories_ItemCheck);
            // 
            // gbPosts
            // 
            this.gbPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPosts.Controls.Add(this.gbSelectedPost);
            this.gbPosts.Controls.Add(this.chkbShowHiddenPosts);
            this.gbPosts.Controls.Add(this.dgvRSSPosts);
            this.gbPosts.Location = new System.Drawing.Point(21, 306);
            this.gbPosts.Name = "gbPosts";
            this.gbPosts.Size = new System.Drawing.Size(1098, 328);
            this.gbPosts.TabIndex = 12;
            this.gbPosts.TabStop = false;
            this.gbPosts.Text = "Feed\'s Posts:";
            // 
            // gbSelectedPost
            // 
            this.gbSelectedPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSelectedPost.Controls.Add(this.btnDelete);
            this.gbSelectedPost.Controls.Add(this.btnHide);
            this.gbSelectedPost.Controls.Add(this.chkbHistory);
            this.gbSelectedPost.Location = new System.Drawing.Point(10, 57);
            this.gbSelectedPost.Name = "gbSelectedPost";
            this.gbSelectedPost.Size = new System.Drawing.Size(1076, 78);
            this.gbSelectedPost.TabIndex = 14;
            this.gbSelectedPost.TabStop = false;
            this.gbSelectedPost.Text = "Selected Post:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Aggregator.GUI.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Location = new System.Drawing.Point(10, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 51);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackgroundImage = global::Aggregator.GUI.Properties.Resources.rsshide;
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHide.Location = new System.Drawing.Point(70, 24);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(54, 51);
            this.btnHide.TabIndex = 11;
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // chkbHistory
            // 
            this.chkbHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbHistory.AutoEllipsis = true;
            this.chkbHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbHistory.Location = new System.Drawing.Point(130, 31);
            this.chkbHistory.Name = "chkbHistory";
            this.chkbHistory.Size = new System.Drawing.Size(940, 32);
            this.chkbHistory.TabIndex = 12;
            this.chkbHistory.Text = "Don\'t keep history for this post (Changes in posts\' content won\'t create new post" +
                ")";
            this.chkbHistory.UseVisualStyleBackColor = true;
            this.chkbHistory.Click += new System.EventHandler(this.chkbHistory_Click);
            // 
            // chkbShowHiddenPosts
            // 
            this.chkbShowHiddenPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbShowHiddenPosts.AutoEllipsis = true;
            this.chkbShowHiddenPosts.Checked = true;
            this.chkbShowHiddenPosts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbShowHiddenPosts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbShowHiddenPosts.Location = new System.Drawing.Point(11, 22);
            this.chkbShowHiddenPosts.Name = "chkbShowHiddenPosts";
            this.chkbShowHiddenPosts.Size = new System.Drawing.Size(1077, 32);
            this.chkbShowHiddenPosts.TabIndex = 13;
            this.chkbShowHiddenPosts.Text = "Show Hidden posts";
            this.chkbShowHiddenPosts.UseVisualStyleBackColor = true;
            this.chkbShowHiddenPosts.CheckedChanged += new System.EventHandler(this.chkbShowHiddenPosts_CheckedChanged);
            // 
            // chkbDisabled
            // 
            this.chkbDisabled.AutoEllipsis = true;
            this.chkbDisabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbDisabled.Location = new System.Drawing.Point(11, 229);
            this.chkbDisabled.Name = "chkbDisabled";
            this.chkbDisabled.Size = new System.Drawing.Size(338, 29);
            this.chkbDisabled.TabIndex = 19;
            this.chkbDisabled.Text = "Disabled Feed:";
            this.chkbDisabled.UseVisualStyleBackColor = true;
            this.chkbDisabled.Click += new System.EventHandler(this.chkbDisabled_Click);
            // 
            // FeedInformationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 640);
            this.Controls.Add(this.gbPosts);
            this.Controls.Add(this.gbFeedInfo);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FeedInformationDialog";
            this.Text = "Feed Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FeedInformationDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRSSPosts)).EndInit();
            this.gbFeedInfo.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbCategories.ResumeLayout(false);
            this.gbPosts.ResumeLayout(false);
            this.gbSelectedPost.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRSSURL;
        private System.Windows.Forms.DataGridView dgvRSSPosts;
        private System.Windows.Forms.Label lbldownloadedSize;
        private System.Windows.Forms.GroupBox gbFeedInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbCategories;
        private System.Windows.Forms.CheckedListBox chklstbCategories;
        private System.Windows.Forms.Label lblTotalUpdates;
        private System.Windows.Forms.Label lblUnreadItems;
        private System.Windows.Forms.CheckBox chkbPrivateFeed;
        private System.Windows.Forms.CheckBox chkbActiveFeed;
        private System.Windows.Forms.GroupBox gbPosts;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkbHistory;
        private System.Windows.Forms.CheckBox chkbShowHiddenPosts;
        private System.Windows.Forms.GroupBox gbSelectedPost;
        private System.Windows.Forms.TextBox txtbRSSName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkbIgnoreHistory;
        private System.Windows.Forms.CheckBox chkbDisabled;
    }
}