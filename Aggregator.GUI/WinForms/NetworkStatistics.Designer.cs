namespace Aggregator.GUI.WinForms
{
    partial class NetworkStatistics
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblstatUploaded = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstatDownloaded = new System.Windows.Forms.Label();
            this.lblNetworkNameSelection = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tmrStatistics = new System.Windows.Forms.Timer(this.components);
            this.lblType = new System.Windows.Forms.Label();
            this.lblTypeValue = new System.Windows.Forms.Label();
            this.Operational = new System.Windows.Forms.Label();
            this.lblNetworkStatus = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescriptionValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Upload:";
            // 
            // lblstatUploaded
            // 
            this.lblstatUploaded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblstatUploaded.AutoEllipsis = true;
            this.lblstatUploaded.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblstatUploaded.Location = new System.Drawing.Point(218, 114);
            this.lblstatUploaded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstatUploaded.Name = "lblstatUploaded";
            this.lblstatUploaded.Size = new System.Drawing.Size(511, 30);
            this.lblstatUploaded.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total Download:";
            // 
            // lblstatDownloaded
            // 
            this.lblstatDownloaded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblstatDownloaded.AutoEllipsis = true;
            this.lblstatDownloaded.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblstatDownloaded.Location = new System.Drawing.Point(218, 80);
            this.lblstatDownloaded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstatDownloaded.Name = "lblstatDownloaded";
            this.lblstatDownloaded.Size = new System.Drawing.Size(511, 30);
            this.lblstatDownloaded.TabIndex = 8;
            // 
            // lblNetworkNameSelection
            // 
            this.lblNetworkNameSelection.AutoEllipsis = true;
            this.lblNetworkNameSelection.Location = new System.Drawing.Point(9, 13);
            this.lblNetworkNameSelection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetworkNameSelection.Name = "lblNetworkNameSelection";
            this.lblNetworkNameSelection.Size = new System.Drawing.Size(201, 30);
            this.lblNetworkNameSelection.TabIndex = 7;
            this.lblNetworkNameSelection.Text = "Network Connection:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(218, 13);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(515, 30);
            this.comboBox1.TabIndex = 6;
            // 
            // tmrStatistics
            // 
            this.tmrStatistics.Enabled = true;
            this.tmrStatistics.Interval = 500;
            this.tmrStatistics.Tick += new System.EventHandler(this.tmrStatistics_Tick);
            // 
            // lblType
            // 
            this.lblType.AutoEllipsis = true;
            this.lblType.Location = new System.Drawing.Point(12, 149);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(198, 30);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type:";
            // 
            // lblTypeValue
            // 
            this.lblTypeValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTypeValue.AutoEllipsis = true;
            this.lblTypeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTypeValue.Location = new System.Drawing.Point(218, 149);
            this.lblTypeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeValue.Name = "lblTypeValue";
            this.lblTypeValue.Size = new System.Drawing.Size(125, 30);
            this.lblTypeValue.TabIndex = 12;
            // 
            // Operational
            // 
            this.Operational.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Operational.AutoEllipsis = true;
            this.Operational.Location = new System.Drawing.Point(351, 149);
            this.Operational.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Operational.Name = "Operational";
            this.Operational.Size = new System.Drawing.Size(190, 30);
            this.Operational.TabIndex = 15;
            this.Operational.Text = "Operational Status:";
            // 
            // lblNetworkStatus
            // 
            this.lblNetworkStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetworkStatus.AutoEllipsis = true;
            this.lblNetworkStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetworkStatus.Location = new System.Drawing.Point(549, 149);
            this.lblNetworkStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetworkStatus.Name = "lblNetworkStatus";
            this.lblNetworkStatus.Size = new System.Drawing.Size(180, 30);
            this.lblNetworkStatus.TabIndex = 14;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 47);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(201, 30);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Description:";
            // 
            // lblDescriptionValue
            // 
            this.lblDescriptionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescriptionValue.AutoEllipsis = true;
            this.lblDescriptionValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescriptionValue.Location = new System.Drawing.Point(218, 47);
            this.lblDescriptionValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptionValue.Name = "lblDescriptionValue";
            this.lblDescriptionValue.Size = new System.Drawing.Size(511, 30);
            this.lblDescriptionValue.TabIndex = 16;
            // 
            // NetworkStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 200);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDescriptionValue);
            this.Controls.Add(this.Operational);
            this.Controls.Add(this.lblNetworkStatus);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTypeValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblstatUploaded);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblstatDownloaded);
            this.Controls.Add(this.lblNetworkNameSelection);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetworkStatistics";
            this.Text = "Network Statistics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblstatUploaded;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblstatDownloaded;
        private System.Windows.Forms.Label lblNetworkNameSelection;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer tmrStatistics;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTypeValue;
        private System.Windows.Forms.Label Operational;
        private System.Windows.Forms.Label lblNetworkStatus;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDescriptionValue;
    }
}