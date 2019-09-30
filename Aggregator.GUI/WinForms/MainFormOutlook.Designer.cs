namespace Aggregator.GUI.WinForms
{
    partial class MainFormOutlook
    {
        /// <summary>s
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormOutlook));
            this.notifyIconStatus = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripOperations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvUnreadMails = new System.Windows.Forms.DataGridView();
            this.bwRefreshMail = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiApplicationSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiErrorsList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewLogOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefreshMail = new System.Windows.Forms.Button();
            this.btnMailReply = new System.Windows.Forms.Button();
            this.btnMailDelete = new System.Windows.Forms.Button();
            this.btnMailsStopStart = new System.Windows.Forms.Button();
            this.ssOutlook = new System.Windows.Forms.StatusStrip();
            this.tsslRefreshedCountOutlook = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNextRefreshOutlook = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnMarkAllMailsAsRead = new System.Windows.Forms.Button();
            this.tmrRefreshOutlook = new System.Windows.Forms.Timer(this.components);
            this.tmrUser = new System.Windows.Forms.Timer(this.components);
            this.tsslUseActive = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStripOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnreadMails)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.ssOutlook.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvUnreadMails.Location = new System.Drawing.Point(4, 85);
            this.dgvUnreadMails.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUnreadMails.Name = "dgvUnreadMails";
            this.dgvUnreadMails.ReadOnly = true;
            this.dgvUnreadMails.RowTemplate.Height = 24;
            this.dgvUnreadMails.Size = new System.Drawing.Size(1083, 303);
            this.dgvUnreadMails.TabIndex = 7;
            this.dgvUnreadMails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnreadMails_CellDoubleClick);
            // 
            // bwRefreshMail
            // 
            this.bwRefreshMail.WorkerReportsProgress = true;
            this.bwRefreshMail.WorkerSupportsCancellation = true;
            this.bwRefreshMail.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRefreshMail_DoWork);
            this.bwRefreshMail.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRefreshMail_RunWorkerCompleted);
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
            this.tsmiClose2});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(54, 26);
            this.tsmiFile.Text = "File";
            // 
            // tsmiClose2
            // 
            this.tsmiClose2.Name = "tsmiClose2";
            this.tsmiClose2.Size = new System.Drawing.Size(126, 26);
            this.tsmiClose2.Text = "Close";
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
            // btnRefreshMail
            // 
            this.btnRefreshMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshMail.BackgroundImage = global::Aggregator.GUI.Properties.Resources.RefreshIconSmall;
            this.btnRefreshMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshMail.Location = new System.Drawing.Point(667, 34);
            this.btnRefreshMail.Name = "btnRefreshMail";
            this.btnRefreshMail.Size = new System.Drawing.Size(43, 43);
            this.btnRefreshMail.TabIndex = 20;
            this.btnRefreshMail.UseVisualStyleBackColor = true;
            // 
            // btnMailReply
            // 
            this.btnMailReply.BackgroundImage = global::Aggregator.GUI.Properties.Resources.reply;
            this.btnMailReply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMailReply.Location = new System.Drawing.Point(53, 34);
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
            this.btnMailDelete.Location = new System.Drawing.Point(4, 34);
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
            this.btnMailsStopStart.Location = new System.Drawing.Point(716, 34);
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
            this.tsslUseActive,
            this.tsslRefreshedCountOutlook,
            this.tsslNextRefreshOutlook});
            this.ssOutlook.Location = new System.Drawing.Point(0, 402);
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
            this.btnMarkAllMailsAsRead.Location = new System.Drawing.Point(766, 34);
            this.btnMarkAllMailsAsRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarkAllMailsAsRead.Name = "btnMarkAllMailsAsRead";
            this.btnMarkAllMailsAsRead.Size = new System.Drawing.Size(321, 43);
            this.btnMarkAllMailsAsRead.TabIndex = 11;
            this.btnMarkAllMailsAsRead.Text = "Mark all mails as read";
            this.btnMarkAllMailsAsRead.UseVisualStyleBackColor = true;
            this.btnMarkAllMailsAsRead.Click += new System.EventHandler(this.btnMarkAllMailsAsRead_Click);
            // 
            // tmrRefreshOutlook
            // 
            this.tmrRefreshOutlook.Enabled = true;
            this.tmrRefreshOutlook.Interval = 1000;
            this.tmrRefreshOutlook.Tick += new System.EventHandler(this.tmrRefreshOutlook_Tick);
            // 
            // tmrUser
            // 
            this.tmrUser.Enabled = true;
            this.tmrUser.Interval = 1000;
            this.tmrUser.Tick += new System.EventHandler(this.tmrUser_Tick);
            // 
            // tsslUseActive
            // 
            this.tsslUseActive.Name = "tsslUseActive";
            this.tsslUseActive.Size = new System.Drawing.Size(123, 22);
            this.tsslUseActive.Text = "User is Active";
            // 
            // MainFormOutlook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 429);
            this.Controls.Add(this.ssOutlook);
            this.Controls.Add(this.btnMailReply);
            this.Controls.Add(this.dgvUnreadMails);
            this.Controls.Add(this.btnRefreshMail);
            this.Controls.Add(this.btnMailDelete);
            this.Controls.Add(this.btnMailsStopStart);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnMarkAllMailsAsRead);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MainFormOutlook";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Outlook Reader (RSS Desktop Aggregator)";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStripOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnreadMails)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ssOutlook.ResumeLayout(false);
            this.ssOutlook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOperations;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
        private System.Windows.Forms.ToolStripSeparator tsmiSeperator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.DataGridView dgvUnreadMails;
        private System.ComponentModel.BackgroundWorker bwRefreshMail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiApplicationSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose2;
        private System.Windows.Forms.Button btnMarkAllMailsAsRead;
        private System.Windows.Forms.ToolStripMenuItem tsmiErrorsList;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiVersion;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.StatusStrip ssOutlook;
        private System.Windows.Forms.ToolStripStatusLabel tsslRefreshedCountOutlook;
        private System.Windows.Forms.ToolStripStatusLabel tsslNextRefreshOutlook;
        private System.Windows.Forms.Timer tmrRefreshOutlook;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatistics;
        private System.Windows.Forms.Button btnMailsStopStart;
        private System.Windows.Forms.Button btnMailDelete;
        private System.Windows.Forms.Button btnMailReply;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewLogOperations;
        private System.Windows.Forms.Button btnRefreshMail;
        private System.Windows.Forms.Timer tmrUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslUseActive;
    }
}