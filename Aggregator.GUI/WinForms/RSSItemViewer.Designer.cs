namespace Aggregator.GUI.WinForms
{
    partial class RSSItemViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSSItemViewer));
            this.wbPostView = new System.Windows.Forms.WebBrowser();
            this.chkbMarkAsUnRead = new System.Windows.Forms.CheckBox();
            this.chkbHistory = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSaveToHTML = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbntHideShowPost = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCheckAsRead = new System.Windows.Forms.ToolStripButton();
            this.tsbtnBack = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNext = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbPostView
            // 
            this.wbPostView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbPostView.Location = new System.Drawing.Point(0, 39);
            this.wbPostView.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPostView.Name = "wbPostView";
            this.wbPostView.ScriptErrorsSuppressed = true;
            this.wbPostView.Size = new System.Drawing.Size(847, 371);
            this.wbPostView.TabIndex = 0;
            this.wbPostView.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbPostView_DocumentCompleted);
            this.wbPostView.NewWindow += new System.ComponentModel.CancelEventHandler(this.wbPostView_NewWindow);
            // 
            // chkbMarkAsUnRead
            // 
            this.chkbMarkAsUnRead.AutoEllipsis = true;
            this.chkbMarkAsUnRead.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkbMarkAsUnRead.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbMarkAsUnRead.Location = new System.Drawing.Point(0, 442);
            this.chkbMarkAsUnRead.Name = "chkbMarkAsUnRead";
            this.chkbMarkAsUnRead.Size = new System.Drawing.Size(847, 32);
            this.chkbMarkAsUnRead.TabIndex = 2;
            this.chkbMarkAsUnRead.Text = "Mark as unread (takes effect immediately)";
            this.chkbMarkAsUnRead.UseVisualStyleBackColor = true;
            this.chkbMarkAsUnRead.Click += new System.EventHandler(this.chkbMarkAsUnRead_Click);
            // 
            // chkbHistory
            // 
            this.chkbHistory.AutoEllipsis = true;
            this.chkbHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkbHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbHistory.Location = new System.Drawing.Point(0, 410);
            this.chkbHistory.Name = "chkbHistory";
            this.chkbHistory.Size = new System.Drawing.Size(847, 32);
            this.chkbHistory.TabIndex = 4;
            this.chkbHistory.Text = "Don\'t track changes in post\'s content (don\'t keep history for this post)";
            this.chkbHistory.UseVisualStyleBackColor = true;
            this.chkbHistory.CheckedChanged += new System.EventHandler(this.chkbHistory_CheckedChanged);
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
            this.toolStrip1.Size = new System.Drawing.Size(847, 39);
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
            this.tsbtnCheckAsRead.Visible = false;
            // 
            // tsbtnBack
            // 
            this.tsbtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBack.Image = global::Aggregator.GUI.Properties.Resources.arrow1;
            this.tsbtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBack.Name = "tsbtnBack";
            this.tsbtnBack.Size = new System.Drawing.Size(36, 36);
            this.tsbtnBack.Text = "Back";
            this.tsbtnBack.Visible = false;
            // 
            // tsbtnNext
            // 
            this.tsbtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNext.Image = global::Aggregator.GUI.Properties.Resources.arrow2;
            this.tsbtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNext.Name = "tsbtnNext";
            this.tsbtnNext.Size = new System.Drawing.Size(36, 36);
            this.tsbtnNext.Text = "Next Post";
            this.tsbtnNext.Visible = false;
            // 
            // RSSItemViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 474);
            this.Controls.Add(this.wbPostView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.chkbHistory);
            this.Controls.Add(this.chkbMarkAsUnRead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RSSItemViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSSItemViewer";
            this.Load += new System.EventHandler(this.RSSItemViewer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbPostView;
        private System.Windows.Forms.CheckBox chkbMarkAsUnRead;
        private System.Windows.Forms.CheckBox chkbHistory;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSaveToHTML;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbntHideShowPost;
        private System.Windows.Forms.ToolStripButton tsbtnCheckAsRead;
        private System.Windows.Forms.ToolStripButton tsbtnBack;
        private System.Windows.Forms.ToolStripButton tsbtnNext;
    }
}