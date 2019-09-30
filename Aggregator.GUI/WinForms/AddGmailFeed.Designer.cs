namespace Aggregator.GUI
{
    partial class AddGmailFeed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGmailFeed));
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtbFeedName = new System.Windows.Forms.TextBox();
            this.lblFeedName = new System.Windows.Forms.Label();
            this.chkbPrivate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtbPassword
            // 
            this.txtbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbPassword.Location = new System.Drawing.Point(173, 58);
            this.txtbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '*';
            this.txtbPassword.Size = new System.Drawing.Size(294, 28);
            this.txtbPassword.TabIndex = 7;
            // 
            // txtbUsername
            // 
            this.txtbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbUsername.Location = new System.Drawing.Point(173, 13);
            this.txtbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(294, 28);
            this.txtbUsername.TabIndex = 5;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(11, 54);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(154, 28);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "&Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Location = new System.Drawing.Point(13, 10);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(154, 28);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "&User name";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.AutoEllipsis = true;
            this.lbl.ForeColor = System.Drawing.Color.Red;
            this.lbl.Location = new System.Drawing.Point(13, 195);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(459, 119);
            this.lbl.TabIndex = 8;
            this.lbl.Text = resources.GetString("lbl.Text");
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.Location = new System.Drawing.Point(98, 319);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(121, 38);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(312, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 38);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtbFeedName
            // 
            this.txtbFeedName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbFeedName.Location = new System.Drawing.Point(173, 110);
            this.txtbFeedName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbFeedName.Name = "txtbFeedName";
            this.txtbFeedName.Size = new System.Drawing.Size(294, 28);
            this.txtbFeedName.TabIndex = 12;
            // 
            // lblFeedName
            // 
            this.lblFeedName.Location = new System.Drawing.Point(13, 109);
            this.lblFeedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedName.Name = "lblFeedName";
            this.lblFeedName.Size = new System.Drawing.Size(154, 28);
            this.lblFeedName.TabIndex = 11;
            this.lblFeedName.Text = "Feed Name";
            this.lblFeedName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkbPrivate
            // 
            this.chkbPrivate.AutoEllipsis = true;
            this.chkbPrivate.Checked = true;
            this.chkbPrivate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbPrivate.Location = new System.Drawing.Point(17, 150);
            this.chkbPrivate.Name = "chkbPrivate";
            this.chkbPrivate.Size = new System.Drawing.Size(454, 28);
            this.chkbPrivate.TabIndex = 13;
            this.chkbPrivate.Text = "Set Gmail mode to privaty mode";
            this.chkbPrivate.UseVisualStyleBackColor = true;
            // 
            // AddGmailFeed
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(485, 369);
            this.Controls.Add(this.chkbPrivate);
            this.Controls.Add(this.txtbFeedName);
            this.Controls.Add(this.lblFeedName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbUsername);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddGmailFeed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New GMail RSS Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtbPassword;
        internal System.Windows.Forms.TextBox txtbUsername;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UsernameLabel;
        internal System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.TextBox txtbFeedName;
        internal System.Windows.Forms.Label lblFeedName;
        private System.Windows.Forms.CheckBox chkbPrivate;
    }
}