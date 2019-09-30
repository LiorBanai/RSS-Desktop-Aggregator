using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Aggregator.Core;

namespace Aggregator.GUI.WinForms
{
    public partial class FeedTester : Form
    {
        public FeedTester()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument XMLDoc = XDocument.Parse(richTextBox1 .Text);
            //List<IRSSPost> newItems = (from post in XMLDoc.Descendants(txtbItemID .Text)
            //                            select new StandardRSSPost(post, null)).ToList<IRSSPost>();
            var newItems = (from post in XMLDoc.Descendants("entry")
                           select post).ToList() ;
            lblCount.Text = newItems.Count.ToString( );
        }
    }
}
