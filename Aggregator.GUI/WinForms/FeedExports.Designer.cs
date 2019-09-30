namespace Aggregator.GUI.WinForms
{
    partial class FeedExports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedExports));
            this.chklstFeeds = new System.Windows.Forms.CheckedListBox();
            this.lblSelectFeeds = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.chkExportHiddenPost = new System.Windows.Forms.CheckBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnUnselectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklstFeeds
            // 
            this.chklstFeeds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chklstFeeds.CheckOnClick = true;
            this.chklstFeeds.FormattingEnabled = true;
            this.chklstFeeds.Location = new System.Drawing.Point(469, 34);
            this.chklstFeeds.Margin = new System.Windows.Forms.Padding(4);
            this.chklstFeeds.Name = "chklstFeeds";
            this.chklstFeeds.Size = new System.Drawing.Size(449, 354);
            this.chklstFeeds.TabIndex = 0;
            // 
            // lblSelectFeeds
            // 
            this.lblSelectFeeds.AutoSize = true;
            this.lblSelectFeeds.Location = new System.Drawing.Point(13, 34);
            this.lblSelectFeeds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectFeeds.Name = "lblSelectFeeds";
            this.lblSelectFeeds.Size = new System.Drawing.Size(448, 22);
            this.lblSelectFeeds.TabIndex = 1;
            this.lblSelectFeeds.Text = "Select the feeds you would like to export to HTML file:";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExport.Image = global::Aggregator.GUI.Properties.Resources.rsshtmlsmall;
            this.btnExport.Location = new System.Drawing.Point(400, 453);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(146, 54);
            this.btnExport.TabIndex = 14;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chkExportHiddenPost
            // 
            this.chkExportHiddenPost.AutoSize = true;
            this.chkExportHiddenPost.Location = new System.Drawing.Point(17, 69);
            this.chkExportHiddenPost.Name = "chkExportHiddenPost";
            this.chkExportHiddenPost.Size = new System.Drawing.Size(269, 26);
            this.chkExportHiddenPost.TabIndex = 15;
            this.chkExportHiddenPost.Text = "Include hidden posts in export";
            this.chkExportHiddenPost.UseVisualStyleBackColor = true;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAll.Location = new System.Drawing.Point(619, 405);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(107, 31);
            this.btnSelectAll.TabIndex = 22;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            // 
            // btnUnselectAll
            // 
            this.btnUnselectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnselectAll.Location = new System.Drawing.Point(743, 405);
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.Size = new System.Drawing.Size(107, 31);
            this.btnUnselectAll.TabIndex = 21;
            this.btnUnselectAll.Text = "Unselect All";
            this.btnUnselectAll.UseVisualStyleBackColor = true;
            // 
            // FeedExports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 513);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnUnselectAll);
            this.Controls.Add(this.chkExportHiddenPost);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblSelectFeeds);
            this.Controls.Add(this.chklstFeeds);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(877, 400);
            this.Name = "FeedExports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feeds Export";
            this.Load += new System.EventHandler(this.FeedExports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklstFeeds;
        private System.Windows.Forms.Label lblSelectFeeds;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkExportHiddenPost;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnUnselectAll;
    }
}