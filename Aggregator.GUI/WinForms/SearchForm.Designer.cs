namespace Aggregator.GUI.WinForms
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.spltcMain = new System.Windows.Forms.SplitContainer();
            this.olvPosts = new BrightIdeasSoftware.ObjectListView();
            this.columnHeaderTitle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnPubDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvRead = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnFeed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnAddedDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnHeader16 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.gbSearchCriteria = new System.Windows.Forms.GroupBox();
            this.gbLimitFeeds = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtbTextForSearch = new System.Windows.Forms.TextBox();
            this.webbPostViewer = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSaveToHTML = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbntHideShowPost = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCheckAsRead = new System.Windows.Forms.ToolStripButton();
            this.tsbtnBack = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNext = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslRecords = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.spltcMain)).BeginInit();
            this.spltcMain.Panel1.SuspendLayout();
            this.spltcMain.Panel2.SuspendLayout();
            this.spltcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPosts)).BeginInit();
            this.gbSearchCriteria.SuspendLayout();
            this.gbLimitFeeds.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltcMain
            // 
            this.spltcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltcMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spltcMain.Location = new System.Drawing.Point(0, 0);
            this.spltcMain.Margin = new System.Windows.Forms.Padding(4);
            this.spltcMain.Name = "spltcMain";
            this.spltcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltcMain.Panel1
            // 
            this.spltcMain.Panel1.Controls.Add(this.olvPosts);
            this.spltcMain.Panel1.Controls.Add(this.gbSearchCriteria);
            this.spltcMain.Panel1MinSize = 0;
            // 
            // spltcMain.Panel2
            // 
            this.spltcMain.Panel2.Controls.Add(this.webbPostViewer);
            this.spltcMain.Panel2.Controls.Add(this.toolStrip1);
            this.spltcMain.Panel2MinSize = 0;
            this.spltcMain.Size = new System.Drawing.Size(1154, 597);
            this.spltcMain.SplitterDistance = 332;
            this.spltcMain.SplitterWidth = 6;
            this.spltcMain.TabIndex = 13;
            // 
            // olvPosts
            // 
            this.olvPosts.AllColumns.Add(this.columnHeaderTitle);
            this.olvPosts.AllColumns.Add(this.columnPubDate);
            this.olvPosts.AllColumns.Add(this.olvRead);
            this.olvPosts.AllColumns.Add(this.columnFeed);
            this.olvPosts.AllColumns.Add(this.columnAddedDate);
            this.olvPosts.AllColumns.Add(this.columnHeader16);
            this.olvPosts.AllowColumnReorder = true;
            this.olvPosts.AllowDrop = true;
            this.olvPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.olvPosts.CheckedAspectName = "Read";
            this.olvPosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnPubDate,
            this.olvRead,
            this.columnFeed,
            this.columnAddedDate,
            this.columnHeader16});
            this.olvPosts.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPosts.FullRowSelect = true;
            this.olvPosts.GridLines = true;
            this.olvPosts.HeaderUsesThemes = false;
            this.olvPosts.HeaderWordWrap = true;
            this.olvPosts.HideSelection = false;
            this.olvPosts.Location = new System.Drawing.Point(8, 125);
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
            this.olvPosts.Size = new System.Drawing.Size(1136, 203);
            this.olvPosts.SortGroupItemsByPrimaryColumn = false;
            this.olvPosts.TabIndex = 13;
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
            // columnFeed
            // 
            this.columnFeed.AspectName = "FeedName";
            this.columnFeed.HeaderForeColor = System.Drawing.Color.Black;
            this.columnFeed.Text = "Feed Name";
            this.columnFeed.Width = 150;
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
            // gbSearchCriteria
            // 
            this.gbSearchCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearchCriteria.Controls.Add(this.gbLimitFeeds);
            this.gbSearchCriteria.Controls.Add(this.txtbTextForSearch);
            this.gbSearchCriteria.Location = new System.Drawing.Point(8, 12);
            this.gbSearchCriteria.Name = "gbSearchCriteria";
            this.gbSearchCriteria.Size = new System.Drawing.Size(1142, 111);
            this.gbSearchCriteria.TabIndex = 9;
            this.gbSearchCriteria.TabStop = false;
            this.gbSearchCriteria.Text = "Search Criteria";
            // 
            // gbLimitFeeds
            // 
            this.gbLimitFeeds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLimitFeeds.Controls.Add(this.comboBox1);
            this.gbLimitFeeds.Controls.Add(this.radioButton4);
            this.gbLimitFeeds.Controls.Add(this.radioButton3);
            this.gbLimitFeeds.Controls.Add(this.radioButton2);
            this.gbLimitFeeds.Controls.Add(this.radioButton1);
            this.gbLimitFeeds.Location = new System.Drawing.Point(619, 17);
            this.gbLimitFeeds.Name = "gbLimitFeeds";
            this.gbLimitFeeds.Size = new System.Drawing.Size(517, 88);
            this.gbLimitFeeds.TabIndex = 1;
            this.gbLimitFeeds.TabStop = false;
            this.gbLimitFeeds.Text = "Limit to:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(346, 30);
            this.comboBox1.TabIndex = 4;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoEllipsis = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 51);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(140, 30);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Category:";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoEllipsis = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(140, 26);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "All feeds";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoEllipsis = true;
            this.radioButton2.Location = new System.Drawing.Point(339, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(169, 26);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Non Active feeds";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoEllipsis = true;
            this.radioButton1.Location = new System.Drawing.Point(179, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(140, 26);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Active feeds";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtbTextForSearch
            // 
            this.txtbTextForSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbTextForSearch.Location = new System.Drawing.Point(9, 29);
            this.txtbTextForSearch.Name = "txtbTextForSearch";
            this.txtbTextForSearch.Size = new System.Drawing.Size(604, 30);
            this.txtbTextForSearch.TabIndex = 0;
            this.txtbTextForSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbTextForSearch_KeyPress);
            // 
            // webbPostViewer
            // 
            this.webbPostViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webbPostViewer.Location = new System.Drawing.Point(0, 39);
            this.webbPostViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.webbPostViewer.Name = "webbPostViewer";
            this.webbPostViewer.ScriptErrorsSuppressed = true;
            this.webbPostViewer.Size = new System.Drawing.Size(1154, 220);
            this.webbPostViewer.TabIndex = 1;
            this.webbPostViewer.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webbPostViewer_DocumentCompleted);
            this.webbPostViewer.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webbPostViewer_Navigating);
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
            this.toolStrip1.Size = new System.Drawing.Size(1154, 39);
            this.toolStrip1.TabIndex = 25;
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslRecords});
            this.statusStrip1.Location = new System.Drawing.Point(0, 597);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1154, 23);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslRecords
            // 
            this.tsslRecords.Name = "tsslRecords";
            this.tsslRecords.Size = new System.Drawing.Size(149, 18);
            this.tsslRecords.Text = "Number of records: 0";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 620);
            this.Controls.Add(this.spltcMain);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.spltcMain.Panel1.ResumeLayout(false);
            this.spltcMain.Panel2.ResumeLayout(false);
            this.spltcMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcMain)).EndInit();
            this.spltcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvPosts)).EndInit();
            this.gbSearchCriteria.ResumeLayout(false);
            this.gbSearchCriteria.PerformLayout();
            this.gbLimitFeeds.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spltcMain;
        private System.Windows.Forms.GroupBox gbSearchCriteria;
        private System.Windows.Forms.WebBrowser webbPostViewer;
        private System.Windows.Forms.TextBox txtbTextForSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslRecords;
        private System.Windows.Forms.GroupBox gbLimitFeeds;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private BrightIdeasSoftware.ObjectListView olvPosts;
        private BrightIdeasSoftware.OLVColumn columnHeaderTitle;
        private BrightIdeasSoftware.OLVColumn columnPubDate;
        private BrightIdeasSoftware.OLVColumn olvRead;
        private BrightIdeasSoftware.OLVColumn columnFeed;
        private BrightIdeasSoftware.OLVColumn columnAddedDate;
        private BrightIdeasSoftware.OLVColumn columnHeader16;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSaveToHTML;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbntHideShowPost;
        private System.Windows.Forms.ToolStripButton tsbtnCheckAsRead;
        private System.Windows.Forms.ToolStripButton tsbtnBack;
        private System.Windows.Forms.ToolStripButton tsbtnNext;
    }
}