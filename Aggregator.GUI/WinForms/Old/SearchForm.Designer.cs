namespace Aggregator.GUI.WinForms.Old
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.spltcMain = new System.Windows.Forms.SplitContainer();
            this.gbSearchCriteria = new System.Windows.Forms.GroupBox();
            this.gbLimitFeeds = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtbTextForSearch = new System.Windows.Forms.TextBox();
            this.dgvRSSItems = new System.Windows.Forms.DataGridView();
            this.btnSavetoHTML = new System.Windows.Forms.Button();
            this.tc = new System.Windows.Forms.TabControl();
            this.tpHTML = new System.Windows.Forms.TabPage();
            this.webbPostViewer = new System.Windows.Forms.WebBrowser();
            this.tpSourcecode = new System.Windows.Forms.TabPage();
            this.rtxtbSource = new System.Windows.Forms.RichTextBox();
            this.lblbPostTitle = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslRecords = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.spltcMain)).BeginInit();
            this.spltcMain.Panel1.SuspendLayout();
            this.spltcMain.Panel2.SuspendLayout();
            this.spltcMain.SuspendLayout();
            this.gbSearchCriteria.SuspendLayout();
            this.gbLimitFeeds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRSSItems)).BeginInit();
            this.tc.SuspendLayout();
            this.tpHTML.SuspendLayout();
            this.tpSourcecode.SuspendLayout();
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
            this.spltcMain.Panel1.Controls.Add(this.gbSearchCriteria);
            this.spltcMain.Panel1.Controls.Add(this.dgvRSSItems);
            this.spltcMain.Panel1MinSize = 0;
            // 
            // spltcMain.Panel2
            // 
            this.spltcMain.Panel2.Controls.Add(this.btnSavetoHTML);
            this.spltcMain.Panel2.Controls.Add(this.tc);
            this.spltcMain.Panel2.Controls.Add(this.lblbPostTitle);
            this.spltcMain.Panel2MinSize = 0;
            this.spltcMain.Size = new System.Drawing.Size(1154, 597);
            this.spltcMain.SplitterDistance = 246;
            this.spltcMain.SplitterWidth = 6;
            this.spltcMain.TabIndex = 13;
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
            // dgvRSSItems
            // 
            this.dgvRSSItems.AllowUserToAddRows = false;
            this.dgvRSSItems.AllowUserToDeleteRows = false;
            this.dgvRSSItems.AllowUserToOrderColumns = true;
            this.dgvRSSItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRSSItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRSSItems.Location = new System.Drawing.Point(3, 135);
            this.dgvRSSItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRSSItems.Name = "dgvRSSItems";
            this.dgvRSSItems.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRSSItems.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRSSItems.RowTemplate.Height = 24;
            this.dgvRSSItems.Size = new System.Drawing.Size(1147, 107);
            this.dgvRSSItems.TabIndex = 8;
            this.dgvRSSItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRSSItems_CellDoubleClick);
            this.dgvRSSItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRSSItems_CellValueChanged);
            this.dgvRSSItems.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvRSSItems_CurrentCellDirtyStateChanged);
            this.dgvRSSItems.SelectionChanged += new System.EventHandler(this.dgvRSSItems_SelectionChanged);
            this.dgvRSSItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvRSSItems_KeyPress);
            // 
            // btnSavetoHTML
            // 
            this.btnSavetoHTML.Image = global::Aggregator.GUI.Properties.Resources.htmliconsmall;
            this.btnSavetoHTML.Location = new System.Drawing.Point(8, 9);
            this.btnSavetoHTML.Name = "btnSavetoHTML";
            this.btnSavetoHTML.Size = new System.Drawing.Size(42, 42);
            this.btnSavetoHTML.TabIndex = 17;
            this.btnSavetoHTML.UseVisualStyleBackColor = true;
            this.btnSavetoHTML.Click += new System.EventHandler(this.btnSavetoHTML_Click);
            // 
            // tc
            // 
            this.tc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tc.Controls.Add(this.tpHTML);
            this.tc.Controls.Add(this.tpSourcecode);
            this.tc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tc.Location = new System.Drawing.Point(8, 57);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(1136, 241);
            this.tc.TabIndex = 15;
            // 
            // tpHTML
            // 
            this.tpHTML.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpHTML.Controls.Add(this.webbPostViewer);
            this.tpHTML.Location = new System.Drawing.Point(4, 31);
            this.tpHTML.Name = "tpHTML";
            this.tpHTML.Padding = new System.Windows.Forms.Padding(3);
            this.tpHTML.Size = new System.Drawing.Size(1128, 206);
            this.tpHTML.TabIndex = 0;
            this.tpHTML.Text = "Post Viewer";
            this.tpHTML.UseVisualStyleBackColor = true;
            // 
            // webbPostViewer
            // 
            this.webbPostViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webbPostViewer.Location = new System.Drawing.Point(3, 3);
            this.webbPostViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.webbPostViewer.Name = "webbPostViewer";
            this.webbPostViewer.ScriptErrorsSuppressed = true;
            this.webbPostViewer.Size = new System.Drawing.Size(1118, 196);
            this.webbPostViewer.TabIndex = 1;
            this.webbPostViewer.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webbPostViewer_DocumentCompleted);
            this.webbPostViewer.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webbPostViewer_Navigating);
            this.webbPostViewer.NewWindow += new System.ComponentModel.CancelEventHandler(this.webbPostViewer_NewWindow);
            // 
            // tpSourcecode
            // 
            this.tpSourcecode.Controls.Add(this.rtxtbSource);
            this.tpSourcecode.Location = new System.Drawing.Point(4, 31);
            this.tpSourcecode.Name = "tpSourcecode";
            this.tpSourcecode.Padding = new System.Windows.Forms.Padding(3);
            this.tpSourcecode.Size = new System.Drawing.Size(1128, 204);
            this.tpSourcecode.TabIndex = 1;
            this.tpSourcecode.Text = "Source code";
            this.tpSourcecode.UseVisualStyleBackColor = true;
            // 
            // rtxtbSource
            // 
            this.rtxtbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtbSource.Location = new System.Drawing.Point(3, 3);
            this.rtxtbSource.Name = "rtxtbSource";
            this.rtxtbSource.Size = new System.Drawing.Size(1122, 198);
            this.rtxtbSource.TabIndex = 0;
            this.rtxtbSource.Text = "";
            // 
            // lblbPostTitle
            // 
            this.lblbPostTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblbPostTitle.AutoEllipsis = true;
            this.lblbPostTitle.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblbPostTitle.Location = new System.Drawing.Point(54, 0);
            this.lblbPostTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbPostTitle.Name = "lblbPostTitle";
            this.lblbPostTitle.Size = new System.Drawing.Size(1100, 54);
            this.lblbPostTitle.TabIndex = 14;
            this.lblbPostTitle.Text = "Post:";
            this.lblbPostTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            ((System.ComponentModel.ISupportInitialize)(this.spltcMain)).EndInit();
            this.spltcMain.ResumeLayout(false);
            this.gbSearchCriteria.ResumeLayout(false);
            this.gbSearchCriteria.PerformLayout();
            this.gbLimitFeeds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRSSItems)).EndInit();
            this.tc.ResumeLayout(false);
            this.tpHTML.ResumeLayout(false);
            this.tpSourcecode.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spltcMain;
        private System.Windows.Forms.GroupBox gbSearchCriteria;
        private System.Windows.Forms.DataGridView dgvRSSItems;
        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tpHTML;
        private System.Windows.Forms.WebBrowser webbPostViewer;
        private System.Windows.Forms.TabPage tpSourcecode;
        private System.Windows.Forms.RichTextBox rtxtbSource;
        private System.Windows.Forms.Label lblbPostTitle;
        private System.Windows.Forms.TextBox txtbTextForSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslRecords;
        private System.Windows.Forms.GroupBox gbLimitFeeds;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnSavetoHTML;
    }
}