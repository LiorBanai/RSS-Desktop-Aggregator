using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aggregator.Core;
using Aggregator.Data;
using Aggregator.Util;

namespace Aggregator.GUI.WinForms
{
    public partial class SearchForm2 : Form
    {
        public delegate void EventHandler<in T>(object sender, T e) where T : EventArgs;
        public event EventHandler<RSSArgs> OnRSSItemChanged = delegate { };

        #region Data Members
        private List<RSSFeedsContainer> FeedsGroup { get; set; }
        private AppSettings Settings { get; set; }

        #endregion

        #region Ctors
        public SearchForm2(List<RSSFeedsContainer> feedsGroup, AppSettings settings)
        {
            InitializeComponent();

            FeedsGroup = feedsGroup;
            Settings = settings;
            dgvRSSItems.DataSource = new List<IRSSPost>(0);
            UpdateRSSColumns(dgvRSSItems);
        }


        #endregion

        private void UpdateRSSColumns(DataGridView RSSdataGridView)
        {
            RSSdataGridView.ReadOnly = false;

            foreach (var columnname in Settings.AppGUISettings.RSSColumnsVisibleStatus)
            {
                if (RSSdataGridView.Columns.Contains(columnname.Key))
                {
                    RSSdataGridView.Columns[columnname.Key].Visible = columnname.Value.Visible;
                    RSSdataGridView.Columns[columnname.Key].HeaderText = columnname.Value.HeaderText;
                }

            }

            string title = Reflection.GetPropertyName(((IRSSPost itm) => itm.Title));
            string feedName = Reflection.GetPropertyName(((IRSSPost itm) => itm.FeedName));
            string read = Reflection.GetPropertyName(((IRSSPost itm) => itm.Read));
            string IgnorePostContentIncomparison = Reflection.GetPropertyName(((IRSSPost itm) => itm.IgnorePostContentIncomparison));
            RSSdataGridView.Columns[IgnorePostContentIncomparison].Visible = false;

            RSSdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; //Row height autosize
            RSSdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            RSSdataGridView.Columns[title].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RSSdataGridView.Columns[title].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            RSSdataGridView.Columns[feedName].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            if (RSSdataGridView.Columns.Contains(read))
            {
                RSSdataGridView.Columns[read].ReadOnly = false;

            }
        }
        private void txtbTextForSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                var allMatchedPosts = Search(FeedsGroup.FirstOrDefault(), txtbTextForSearch.Text).ToList() ;
                dgvRSSItems.DataSource = allMatchedPosts;
                
                tsslRecords.Text = "Number of records: " + allMatchedPosts.Count;
            }
        }

        public static IEnumerable<IRSSPost> Search(RSSFeedsContainer feedsContainer , string text)
        {
            IEnumerable<IRSSPost> allMatchedPosts = new List<IRSSPost>();
            if (feedsContainer != null)
                allMatchedPosts = SearchInFeeds(feedsContainer.GetFeeds(), text);
            return allMatchedPosts;

        }
        public static IEnumerable<IRSSPost> SearchInFeeds(IEnumerable< IRSSFeed > feeds , string text)
        {
            var allposts = from feed in feeds
                           from post in feed.GetAllItemsFromCache(false)
                           select post;

            IEnumerable<IRSSPost> allMatchedPosts = SearchInPosts(allposts, text);
            return allMatchedPosts;

        }
        public static IEnumerable<IRSSPost> SearchInPosts(IEnumerable< IRSSPost  > posts , string text)
        {
            var results = from post in posts
                          where
                              (((!string.IsNullOrEmpty(post.PlainTextPostContent) &&
                                 post.PlainTextPostContent.Contains(text)))
                               || (post.Title.Contains(text)))
                          select post;
            return results;
        }


        #region Datagridview methods
        private void dgvRSSItems_SelectionChanged(object sender, EventArgs e)
        {
            if (Visible && dgvRSSItems.CurrentRow != null)
            {
                IRSSPost currentitem = (IRSSPost)dgvRSSItems.CurrentRow.DataBoundItem;
                LoadItemInViewer(currentitem);

            }
        }
        
        private void dgvRSSItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRSSItems.CurrentRow != null)
            {
                IRSSPost currentitem = (IRSSPost)dgvRSSItems.CurrentRow.DataBoundItem;
                var rssDisplay = new RSSItemViewer(currentitem);
                rssDisplay.OnRSSItemChanged += delegate { dgvRSSItems.Refresh(); };

                rssDisplay.Show();
                currentitem.Read = true;
                OnRSSItemChanged(this, new RSSArgs(currentitem));
                dgvRSSItems.Refresh();
            }
        }
        private void dgvRSSItems_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvRSSItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRSSItems.CurrentRow != null)
            {
                IRSSPost itm = dgvRSSItems.CurrentRow.DataBoundItem as IRSSPost;
                OnRSSItemChanged(this, new RSSArgs(itm));
            }

        }
        private void dgvRSSItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
        }
        private void dgvRSSItems_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvRSSItems_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

            dgvRSSItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgvRSSItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataGridViewRow row = dgvRSSItems.CurrentRow;
            if (row != null && (e.KeyChar == (char)Keys.Space))
            {
                string read = Reflection.GetPropertyName(((IRSSPost itm) => itm.Read));
                if (row.Cells[read] != null)
                {
                    row.Cells[read].Value = !((bool)row.Cells[read].Value);

                }
            }
        }
        
        #endregion
     

        #region Post viewer related
        private void LoadItemInViewer(IRSSPost post)
        {
            //if (chkbWhenToMarkAsRead.Checked)
            //{
            //    post.Read = true;
            //    UpdateFeedsCountsAfterChange();
            //}

            dgvRSSItems.Refresh();
            webbPostViewer.Navigating -= webbPostViewer_Navigating;
            string link = string.Empty;
            if (!string.IsNullOrEmpty(post.Link))
                link = string.Format("<a href=\"{0}\">Link</a>", post.Link);

            lblbPostTitle.Text = "Post: " + post.Title;

            if (string.IsNullOrEmpty(post.Description) && string.IsNullOrEmpty(post.Content))
            {
                webbPostViewer.DocumentText = post.Title;
                rtxtbSource.Text = post.Title;
            }
            else
            {
                webbPostViewer.DocumentText = link + " <br>" + post.Description + "<br>" + post.Content;
                rtxtbSource.Text = link + " <br>" + post.Description + "<br>" + post.Content;
            }
        }

        private void webbPostViewer_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webbPostViewer.Navigating += webbPostViewer_Navigating;
            dgvRSSItems.Focus();
        }

        private void webbPostViewer_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            e.Cancel = true;
            TryOpenLink(webbPostViewer.StatusText);

        }
        private void webbPostViewer_NewWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            TryOpenLink(webbPostViewer.StatusText);

        }

        private void TryOpenLink(string statusText)
        {
            string url = webbPostViewer.StatusText.Replace("about:", "");
            try
            {
                if (Utils.IsValidUrl(url))
                    Process.Start(url);
            }
            catch (Exception)
            {

            }
        }

     

        //private void webbPostViewer_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        //{
        //    InjectAlertBlocker();
        //}

        //private void InjectAlertBlocker()
        //{
        //    //HtmlElement head = webbPostViewer.Document.GetElementsByTagName("head")[0];
        //    //HtmlElement scriptEl = webbPostViewer.Document.CreateElement("script");
        //    //IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;
        //    //string alertBlocker = "window.alert = function () { }";
        //    //element.text = alertBlocker;
        //    //head.AppendChild(scriptEl);
        //}

        #endregion
    }
}
