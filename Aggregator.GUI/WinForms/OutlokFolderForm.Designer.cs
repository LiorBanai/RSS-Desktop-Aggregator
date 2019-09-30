namespace Aggregator.GUI.WinForms
{
    partial class OutlokFolderForm
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
            this.tsslItemsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslName = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvAllItems = new System.Windows.Forms.DataGridView();
            this.bwFillItems = new System.ComponentModel.BackgroundWorker();
            this.tvOutlookFolders = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllItems)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsslItemsCount
            // 
            this.tsslItemsCount.Name = "tsslItemsCount";
            this.tsslItemsCount.Size = new System.Drawing.Size(88, 18);
            this.tsslItemsCount.Text = "Items count";
            // 
            // tsslName
            // 
            this.tsslName.Name = "tsslName";
            this.tsslName.Size = new System.Drawing.Size(86, 18);
            this.tsslName.Text = "FolderName";
            // 
            // dgvAllItems
            // 
            this.dgvAllItems.AllowUserToAddRows = false;
            this.dgvAllItems.AllowUserToDeleteRows = false;
            this.dgvAllItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAllItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllItems.Location = new System.Drawing.Point(353, 89);
            this.dgvAllItems.Name = "dgvAllItems";
            this.dgvAllItems.RowTemplate.Height = 24;
            this.dgvAllItems.Size = new System.Drawing.Size(685, 439);
            this.dgvAllItems.TabIndex = 4;
            this.dgvAllItems.VirtualMode = true;
            this.dgvAllItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllItems_CellDoubleClick);
            // 
            // bwFillItems
            // 
            this.bwFillItems.WorkerReportsProgress = true;
            this.bwFillItems.WorkerSupportsCancellation = true;
            // 
            // tvOutlookFolders
            // 
            this.tvOutlookFolders.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvOutlookFolders.Location = new System.Drawing.Point(0, 0);
            this.tvOutlookFolders.Name = "tvOutlookFolders";
            this.tvOutlookFolders.Size = new System.Drawing.Size(347, 531);
            this.tvOutlookFolders.TabIndex = 5;
            this.tvOutlookFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvOutlookFolders_AfterSelect);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslName,
            this.tsslItemsCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1050, 23);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 554);
            this.Controls.Add(this.dgvAllItems);
            this.Controls.Add(this.tvOutlookFolders);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllItems)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel tsslItemsCount;
        private System.Windows.Forms.ToolStripStatusLabel tsslName;
        private System.Windows.Forms.DataGridView dgvAllItems;
        private System.ComponentModel.BackgroundWorker bwFillItems;
        private System.Windows.Forms.TreeView tvOutlookFolders;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

