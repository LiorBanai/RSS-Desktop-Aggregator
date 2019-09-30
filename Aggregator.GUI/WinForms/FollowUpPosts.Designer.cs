namespace Aggregator.GUI.WinForms
{
    partial class FollowUpPosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FollowUpPosts));
            this.gbPosts = new System.Windows.Forms.GroupBox();
            this.spltcMain = new System.Windows.Forms.SplitContainer();
            this.olvPosts = new BrightIdeasSoftware.ObjectListView();
            this.columnFeed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnHeaderTitle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnPubDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvRead = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnAddedDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnHeader16 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.webbPostViewer = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSaveToHTML = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbntHideShowPost = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCheckAsRead = new System.Windows.Forms.ToolStripButton();
            this.tsbtnBack = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNext = new System.Windows.Forms.ToolStripButton();
            this.btnToggleState = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcMain)).BeginInit();
            this.spltcMain.Panel1.SuspendLayout();
            this.spltcMain.Panel2.SuspendLayout();
            this.spltcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPosts)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPosts
            // 
            this.gbPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPosts.Controls.Add(this.spltcMain);
            this.gbPosts.Controls.Add(this.btnToggleState);
            this.gbPosts.Location = new System.Drawing.Point(12, 12);
            this.gbPosts.Name = "gbPosts";
            this.gbPosts.Size = new System.Drawing.Size(1098, 622);
            this.gbPosts.TabIndex = 12;
            this.gbPosts.TabStop = false;
            this.gbPosts.Text = "Feed\'s Posts:";
            // 
            // spltcMain
            // 
            this.spltcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.spltcMain.Location = new System.Drawing.Point(9, 78);
            this.spltcMain.Name = "spltcMain";
            this.spltcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltcMain.Panel1
            // 
            this.spltcMain.Panel1.Controls.Add(this.olvPosts);
            // 
            // spltcMain.Panel2
            // 
            this.spltcMain.Panel2.Controls.Add(this.webbPostViewer);
            this.spltcMain.Panel2.Controls.Add(this.toolStrip1);
            this.spltcMain.Size = new System.Drawing.Size(1083, 538);
            this.spltcMain.SplitterDistance = 241;
            this.spltcMain.TabIndex = 12;
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
            this.olvPosts.CheckedAspectName = "Read";
            this.olvPosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFeed,
            this.columnHeaderTitle,
            this.columnPubDate,
            this.olvRead,
            this.columnAddedDate,
            this.columnHeader16});
            this.olvPosts.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvPosts.FullRowSelect = true;
            this.olvPosts.GridLines = true;
            this.olvPosts.HeaderUsesThemes = false;
            this.olvPosts.HeaderWordWrap = true;
            this.olvPosts.HideSelection = false;
            this.olvPosts.IncludeColumnHeadersInCopy = true;
            this.olvPosts.Location = new System.Drawing.Point(0, 0);
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
            this.olvPosts.Size = new System.Drawing.Size(1083, 241);
            this.olvPosts.SortGroupItemsByPrimaryColumn = false;
            this.olvPosts.TabIndex = 29;
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
            // webbPostViewer
            // 
            this.webbPostViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webbPostViewer.Location = new System.Drawing.Point(0, 39);
            this.webbPostViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.webbPostViewer.Name = "webbPostViewer";
            this.webbPostViewer.ScriptErrorsSuppressed = true;
            this.webbPostViewer.Size = new System.Drawing.Size(1083, 254);
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
            this.toolStrip1.Size = new System.Drawing.Size(1083, 39);
            this.toolStrip1.TabIndex = 24;
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
            // btnToggleState
            // 
            this.btnToggleState.BackgroundImage = global::Aggregator.GUI.Properties.Resources.hearth;
            this.btnToggleState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnToggleState.Location = new System.Drawing.Point(9, 21);
            this.btnToggleState.Name = "btnToggleState";
            this.btnToggleState.Size = new System.Drawing.Size(59, 51);
            this.btnToggleState.TabIndex = 11;
            this.btnToggleState.UseVisualStyleBackColor = true;
            this.btnToggleState.Click += new System.EventHandler(this.btnToggleState_Click);
            // 
            // FollowUpPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 640);
            this.Controls.Add(this.gbPosts);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FollowUpPosts";
            this.Text = "For Later Read Posts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FollowUpPosts_Load);
            this.gbPosts.ResumeLayout(false);
            this.spltcMain.Panel1.ResumeLayout(false);
            this.spltcMain.Panel2.ResumeLayout(false);
            this.spltcMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcMain)).EndInit();
            this.spltcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvPosts)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPosts;
        private System.Windows.Forms.Button btnToggleState;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer spltcMain;
        private System.Windows.Forms.WebBrowser webbPostViewer;
        private BrightIdeasSoftware.ObjectListView olvPosts;
        private BrightIdeasSoftware.OLVColumn columnFeed;
        private BrightIdeasSoftware.OLVColumn columnHeaderTitle;
        private BrightIdeasSoftware.OLVColumn columnPubDate;
        private BrightIdeasSoftware.OLVColumn olvRead;
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