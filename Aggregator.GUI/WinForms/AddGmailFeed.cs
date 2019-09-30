using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Aggregator.Core;
using Aggregator.Data;

namespace Aggregator.GUI
{
    public partial class AddGmailFeed : Form
    {
        #region Data Members

        public IRSSFeed GmailFeed { get; private set; }
        #endregion

        #region Ctor

        public AddGmailFeed()
        {
            InitializeComponent();
        }

        
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            Encoding encoding = Encoding.UTF8;
            int codepage = 0;

            this .GmailFeed = new GmailRSSFeed(@"https://mail.google.com/mail/feed/atom",chkbPrivate .Checked ,true, txtbUsername.Text, txtbPassword.Text , "",encoding, txtbFeedName .Text );
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
