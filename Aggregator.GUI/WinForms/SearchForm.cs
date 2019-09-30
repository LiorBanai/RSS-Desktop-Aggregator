using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class SearchForm : Form
    {
        public delegate void EventHandler<in T>(object sender, T e) where T : EventArgs;
        public event EventHandler<RSSArgs> OnRSSItemChanged = delegate { };

        #region Data Members
        private List<RSSFeedsContainer> FeedsGroup { get; set; }
        private AppSettings Settings { get; set; }

        #endregion

        #region Ctors
        public SearchForm(List<RSSFeedsContainer> feedsGroup, AppSettings settings)
        {
            InitializeComponent();

            FeedsGroup = feedsGroup;
            Settings = settings;
            OnRSSItemChanged += PostChanged;
        }

        #endregion

        #region Form controls Methods

        private void tsbntHideShowPost_Click(object sender, EventArgs e)
        {
            var selectedPost = tsbtnCheckAsRead.Tag as IRSSPost;
            if (selectedPost != null)
            {
                selectedPost.IgnoreThisPost = !selectedPost.IgnoreThisPost;
                tsbntHideShowPost.Image = (selectedPost.IgnoreThisPost) ? Properties.Resources.buttonOFF : Properties.Resources.buttonOn;
                tsbntHideShowPost.Text = (selectedPost.IgnoreThisPost) ? "Restore post visibility " : "Hide post On Main Screen";
            }

        }
        private void tsbtnCheckAsRead_Click(object sender, EventArgs e)
        {
            IRSSPost post = tsbtnCheckAsRead.Tag as IRSSPost;
            if (post != null)
            {
                post.Read = true;
                if (olvPosts != null && Settings.AppGUISettings.RemovePostFromListAfterRead)
                {
                    olvPosts.RemoveObject(post);
                }
                else
                {
                    olvPosts.RefreshObject(post);
                }
            }
        }
        private void tsbtnNext_Click(object sender, EventArgs e)
        {

            if (olvPosts.Objects != null)
            {
                var itm = olvPosts.GetNextItem(olvPosts.SelectedItem);
                if (itm != null)
                    if (!Settings.AppGUISettings.RemovePostFromListAfterRead)
                        olvPosts.SelectedItem = itm;
                    else
                        LoadItemInViewer(itm.RowObject as IRSSPost);

            }

        }
        private void tsbtnBack_Click(object sender, EventArgs e)
        {
            if (olvPosts.Objects != null)
            {
                var itm = olvPosts.GetPreviousItem(olvPosts.SelectedItem);
                if (itm != null)
                    if (!Settings.AppGUISettings.RemovePostFromListAfterRead)
                        olvPosts.SelectedItem = itm;
                    else
                        LoadItemInViewer(itm.RowObject as IRSSPost);

            }
        }
        private void tsbtnSaveToHTML_Click(object sender, EventArgs e)
        {
            if (webbPostViewer.Document != null && webbPostViewer.Document.Body != null &&
                            webbPostViewer.Document.Body.Parent != null)
            {
                // Displays a SaveFileDialog so the user can save the list
                SaveFileDialog saveFileDialoglist = new SaveFileDialog();
                saveFileDialoglist.Filter = "HTML file|*.html";
                saveFileDialoglist.Title = "Save post to HTML";
                var result = saveFileDialoglist.ShowDialog();
                if (result == DialogResult.OK)
                    // If the file name is not an empty string open it for saving.
                    if (saveFileDialoglist.FileName != "")
                    {
                        try
                        {

                            File.WriteAllText(saveFileDialoglist.FileName, webbPostViewer.Document.Body.Parent.OuterHtml,
                                              Encoding.GetEncoding(webbPostViewer.Document.Encoding));
                            MessageShow.ShowMessage(this,
                                                    "Post Content was saved to file:\n" +
                                                    saveFileDialoglist.FileName,
                                                    "Operation completed Successfully", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);

                        }
                        catch (Exception ex)
                        {

                            MessageShow.ShowException(this, ex);
                        }
                    }
            }

        }





        private void olvPosts_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            var post = e.Item.RowObject as IRSSPost;
            if (post != null && (Settings.AppGUISettings.MarkUnreadPostWithBackgroundColor || Settings.AppGUISettings.MarkUnreadPostsWithBold))
            {
                if (Settings.AppGUISettings.MarkUnreadPostsWithBold)
                    e.Item.Font = (post.Read) ? new Font(e.Item.Font, FontStyle.Regular) : new Font(e.Item.Font, FontStyle.Bold);
                e.Item.UseItemStyleForSubItems = true;
                if (Settings.AppGUISettings.MarkUnreadPostWithBackgroundColor && (!post.Read))
                {
                    e.Item.BackColor = Settings.AppGUISettings.UnreadPostBackgroundColor;
                }

            }
        }
        private void olvPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (olvPosts.SelectedObject == null) return;
            var currentitem = olvPosts.SelectedObject as IRSSPost;
            if (currentitem != null)
                LoadItemInViewer(currentitem);
        }
        private void olvPosts_DoubleClick(object sender, EventArgs e)
        {
            if (olvPosts.SelectedObject == null) return;
            var currentitem = olvPosts.SelectedObject as IRSSPost;
            if (currentitem != null)
            {
                var rssDisplay = new RSSItemViewer(currentitem);
                rssDisplay.OnRSSItemChanged += (s2, e2) => olvPosts.RefreshObject(e2.Post);

                rssDisplay.Show();
                currentitem.Read = true;
                OnRSSItemChanged(this, new RSSArgs(currentitem));

            }
        }
        private void olvPosts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (olvPosts.SelectedObject == null || (e.KeyChar != (char)Keys.Space)) return;
            var currentitem = olvPosts.SelectedObject as IRSSPost;
            if (currentitem != null)
            {
                currentitem.Read = !currentitem.Read;
                OnRSSItemChanged(this, new RSSArgs(currentitem));

            }
        }
        private void txtbTextForSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Return)
            //{
                var allMatchedPosts = Search(FeedsGroup.FirstOrDefault(), txtbTextForSearch.Text).ToList();
                olvPosts.SetObjects(allMatchedPosts);

                tsslRecords.Text = "Number of records: " + allMatchedPosts.Count;
           // }
        }

        #endregion
        
        #region Search  methods
        

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
                                 post.PlainTextPostContent.Contains(text,StringComparison.OrdinalIgnoreCase)))
                               || (post.Title.Contains(text,StringComparison.OrdinalIgnoreCase)))
                          select post;
            return results;
        }
        #endregion

        #region Post viewer related
        private void LoadItemInViewer(IRSSPost post)
        {
            webbPostViewer.Navigating -= webbPostViewer_Navigating;
            string link = string.Empty;
            if (!string.IsNullOrEmpty(post.Link))
                link = string.Format("<a href=\"{0}\">Link</a>", post.Link);

        
            if (string.IsNullOrEmpty(post.Description) && string.IsNullOrEmpty(post.Content))
            {
                webbPostViewer.DocumentText = post.Title;
            
            }
            else
            {
                webbPostViewer.DocumentText = link + " <br>" + post.Description + "<br>" + post.Content;
           
            }
            tsbtnCheckAsRead.Tag = post;
            tsbntHideShowPost.Image = (post.IgnoreThisPost) ? Properties.Resources.buttonOFF : Properties.Resources.buttonOn;
            tsbntHideShowPost.Text = (post.IgnoreThisPost) ? "Restore post visibility " : "Hide post On Main Screen";
        }

        private void webbPostViewer_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webbPostViewer.Navigating += webbPostViewer_Navigating;
            olvPosts .Focus();
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

        private void btnSavetoHTML_Click(object sender, EventArgs e)
        {
            if (webbPostViewer.Document != null && webbPostViewer.Document.Body != null && webbPostViewer.Document.Body.Parent != null)
            {
                // Displays a SaveFileDialog so the user can save the list
                SaveFileDialog saveFileDialoglist = new SaveFileDialog();
                saveFileDialoglist.Filter = "HTML file|*.html";
                saveFileDialoglist.Title = "Save post to HTML";
                var result = saveFileDialoglist.ShowDialog();
                if (result == DialogResult.OK)
                    // If the file name is not an empty string open it for saving.
                    if (saveFileDialoglist.FileName != "")
                    {
                        try
                        {

                            File.WriteAllText(saveFileDialoglist.FileName, webbPostViewer.Document.Body.Parent.OuterHtml,
                                              Encoding.GetEncoding(webbPostViewer.Document.Encoding));
                            MessageShow.ShowMessage(this,
                                                    "Post Content was saved to file:\n" +
                                                    saveFileDialoglist.FileName,
                                                    "Operation completed Successfully", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);

                        }
                        catch (Exception ex)
                        {

                            MessageShow.ShowException(this, ex);
                        }
                    }
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

        #region General Methods
        private void PostChanged(object sender, RSSArgs e)
        {
            olvPosts.RefreshObject(e.Post);
        }
        #endregion

    }
}
