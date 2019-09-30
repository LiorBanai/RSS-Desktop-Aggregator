using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aggregator.Core;
using Aggregator.Data;
using Aggregator.Util;

namespace Aggregator.GUI.WinForms
{
    public partial class FeedExports : Form
    {
        #region Data Members
        private List<RSSFeedsContainer> FeedsGroup { get; set; }
        private AppSettings Settings { get; set; }

        #endregion

        #region Ctors
        public FeedExports(List<RSSFeedsContainer> feedsGroup, AppSettings settings)
        {
            InitializeComponent();

            FeedsGroup = feedsGroup;
            Settings = settings;

            btnUnselectAll.Click += (sender, e) => SelectDeselectItems(false);
            btnSelectAll.Click += (sender, e) => SelectDeselectItems(true);
        }
        #endregion

        #region Methods

        #region Form Methods
        private void FeedExports_Load(object sender, EventArgs e)
        {
            LoadFeeds();
        }
        #endregion

        #region Form Controls Methods
        private void btnExport_Click(object sender, EventArgs e)
        {

            string HTMLContent = GenerateHTMLConent();
            SaveFeedsToHtml(HTMLContent);
        }
        #endregion
        #region General Methods
        private void LoadFeeds()
        {
            chklstFeeds.Items.Clear();

            List<IRSSFeed> AllFeeds = new List<IRSSFeed>();
            foreach (RSSFeedsContainer rssGroup in FeedsGroup)
            {
                AllFeeds.AddRange(rssGroup.GetFeeds().ToList());
            }

            string RSSName = Reflection.GetPropertyName(((IRSSFeed itm) => itm.RSSName));
            chklstFeeds.DataSource = AllFeeds;
            chklstFeeds.DisplayMember = RSSName;


        }
        private string GenerateHTMLConent()
        {
            StringBuilder fullText = new StringBuilder();
            var feedsToExport = chklstFeeds.CheckedItems;
            if (feedsToExport.Count > 0)
            {
                foreach (IRSSFeed feed in feedsToExport)
                {
                    fullText.Append(string.Format(
                        @"<table border=""1"" cellpadding=""5"" cellspacing=""5"" width=""100%""> <tr> <th colspan=""2"">{0}</th></tr>",
                        string.Format("Feed Name: {0} <br> Feed URL: {1}", feed.RSSName, feed.RSSUrl)));

                    foreach (IRSSPost Post in feed.GetAllItemsFromCache(false,  chkExportHiddenPost.Checked))
                    {
                        string link = string.Empty;
                        if (!string.IsNullOrEmpty(Post.Link))
                            link = string.Format("<a href=\"{0}\">Link</a>", Post.Link);

                        fullText.Append(string.Format(@"<tr><td width=""80%"">{0}</td><td>{1}</td></tr>",
                                                      string.Format(
                                                          "{0}<br> Title: {1} <br> Published Time: {2}<br>{3}<br>{4}",
                                                          link, Post.Title, Post.Date, Post.Description, Post.Content),
                                                      "Aggregation Time: " + Post.AddedDate));
                    }

                    fullText.Append("</table>" + " <br>");

                }
            }

            return fullText.ToString();
        }
        private void SaveFeedsToHtml(String content)
        {
            // Displays a SaveFileDialog so the user can save the list
            SaveFileDialog saveFileDialoglist = new SaveFileDialog();
            saveFileDialoglist.Filter = "HTML file|*.html";
            saveFileDialoglist.Title = "RSS Feeds Export";
            var result = saveFileDialoglist.ShowDialog();
            if (result == DialogResult.OK)
                // If the file name is not an empty string open it for saving.
                if (saveFileDialoglist.FileName != "")
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(File.Open(saveFileDialoglist.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            sw.Write(content);
                        }

                        MessageShow.ShowMessage(this,
                                                "Feeds Content has been saved to file:\n" + saveFileDialoglist.FileName,
                                                "Operation completed Successfully", MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {

                        MessageShow.ShowException(this, ex);
                    }
                }
        }

        private void SelectDeselectItems(bool markAllSelected)
        {
            for (int j = 0; j < chklstFeeds.Items.Count; j++)
            {
                chklstFeeds.SetItemChecked(j, markAllSelected);
            }


        }
        #endregion



        #endregion

    }
}
