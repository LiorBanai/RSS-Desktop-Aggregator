using System;
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
    public partial class FollowUpPosts : Form
    {
        private AppSettings Settings { get; set; }
        public RSSFeedsContainer FeedsContainer { get; set; }
      
        #region Events
        public event EventHandler<FeedArgs> OnFeedActiveStatusChanged = delegate { };
        #endregion

        #region Ctor
        public FollowUpPosts(RSSFeedsContainer feedsContainer, AppSettings settings)
        {
            InitializeComponent();
            FeedsContainer = feedsContainer;
            ToolTip ttBtns = new ToolTip();
            ttBtns.SetToolTip(btnToggleState, "toggle post's marked for later read status");

            Settings = settings;

        }
        #endregion

        #region Form Methods
        private void FollowUpPosts_Load(object sender, EventArgs e)
        {
            DisplayRSSItems();
        }
        #endregion

        #region Form controls Methods
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
        private void olvPosts_DoubleClick(object sender, EventArgs e)
        {
            if (olvPosts.SelectedObject != null)
            {
                IRSSPost currentitem = olvPosts.SelectedObject as IRSSPost;
                if (currentitem != null)
                {
                    var rssDisplay = new RSSItemViewer(currentitem);
                    rssDisplay.OnRSSItemChanged += (s2, e2) => olvPosts.RefreshObject(e2.Post);

                    rssDisplay.Show();
                    currentitem.Read = true;
           
                }
            }
        }
        private void olvPosts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (olvPosts.SelectedObject != null && (e.KeyChar == (char)Keys.Space))
            {
                IRSSPost currentitem = olvPosts.SelectedObject as IRSSPost;
                if (currentitem != null)
                {
                    currentitem.Read = !currentitem.Read;
                    olvPosts.RefreshObject(currentitem);
                }
            }
        }
        private void olvPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (olvPosts.SelectedObject != null)
            {
                IRSSPost currentitem = olvPosts.SelectedObject as IRSSPost;
                if (currentitem != null)
                    LoadItemInViewer(currentitem);
            }
        }
       
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
      
        private void btnToggleState_Click(object sender, EventArgs e)
        {
            if (olvPosts.Objects  != null)
            {
                IRSSPost currentitem = olvPosts.SelectedObject as IRSSPost;
                currentitem.FollowUp = !currentitem.FollowUp;
                olvPosts.RefreshObject(currentitem);
            }
        }
        #endregion

        #region General Methods
        private void DisplayRSSItems()
        {
            var posts = FeedsContainer.GetAllFollowUpPosts().ToList(); ;
            olvPosts.SetObjects( posts);
            int countnewitems = (posts).Count(itm => itm.Read == false);

            #region columns settings

            //==================== columns settings =======================
            string date = Reflection.GetPropertyName(((IRSSPost itm) => itm.Date));
            string title = Reflection.GetPropertyName(((IRSSPost itm) => itm.Title));
            string description = Reflection.GetPropertyName(((IRSSPost itm) => itm.Description));
            string url = Reflection.GetPropertyName(((IRSSPost itm) => itm.Url));
            string creator = Reflection.GetPropertyName(((IRSSPost itm) => itm.Creator));
            string content = Reflection.GetPropertyName(((IRSSPost itm) => itm.Content));
            string read = Reflection.GetPropertyName(((IRSSPost itm) => itm.Read));
            string link = Reflection.GetPropertyName(((IRSSPost itm) => itm.Link));
            string feedname = Reflection.GetPropertyName(((IRSSPost itm) => itm.FeedName));
            string addeddate = Reflection.GetPropertyName(((IRSSPost itm) => itm.AddedDate));
            string ignoreThisPost = Reflection.GetPropertyName(((IRSSPost itm) => itm.IgnoreThisPost));
            string belongstoFeed = Reflection.GetPropertyName(((IRSSPost itm) => itm.BelongsToFeed));
            string readlater = Reflection.GetPropertyName(((IRSSPost itm) => itm.FollowUp));
            try
            {
                olvPosts.SelectedItem = null;
                olvPosts.SuspendLayout();


                if (olvPosts.GetColumn("Published Date") != null)
                    olvPosts.GetColumn("Published Date").IsVisible =
                        Settings.AppGUISettings.RSSColumnsVisibleStatus[date].Visible;
                if (olvPosts.GetColumn("Title") != null)
                    olvPosts.GetColumn("Title").IsVisible =
                        Settings.AppGUISettings.RSSColumnsVisibleStatus[title].Visible;
                if (olvPosts.GetColumn("Read") != null)
                    olvPosts.GetColumn("Read").IsVisible = Settings.AppGUISettings.RSSColumnsVisibleStatus[read].Visible;
                if (olvPosts.GetColumn("Feed Name") != null)
                    olvPosts.GetColumn("Feed Name").IsVisible =
                        Settings.AppGUISettings.RSSColumnsVisibleStatus[feedname].Visible;
                if (olvPosts.GetColumn("Added Date") != null)
                    olvPosts.GetColumn("Added Date").IsVisible =
                        Settings.AppGUISettings.RSSColumnsVisibleStatus[addeddate].Visible;
                if (olvPosts.GetColumn("Later Read?") != null)
                    olvPosts.GetColumn("Later Read?").IsVisible =
                        Settings.AppGUISettings.RSSColumnsVisibleStatus[readlater].Visible;
                olvPosts.RebuildColumns();
            }
            catch (Exception)
            {
                if (olvPosts.GetColumn("Published Date") != null)
                    olvPosts.GetColumn("Published Date").IsVisible =
                        Settings.AppGUISettings.RSSColumnsVisibleStatus[date].Visible;
                if (olvPosts.GetColumn("Title") != null)
                    olvPosts.GetColumn("Title").IsVisible =
                        Settings.AppGUISettings.RSSColumnsVisibleStatus[title].Visible;
                if (olvPosts.GetColumn("Read") != null)
                    olvPosts.GetColumn("Read").IsVisible = Settings.AppGUISettings.RSSColumnsVisibleStatus[read].Visible;
                if (olvPosts.GetColumn("Feed Name") != null)
                    olvPosts.GetColumn("Feed Name").IsVisible =
                        Settings.AppGUISettings.RSSColumnsVisibleStatus[feedname].Visible;
                if (olvPosts.GetColumn("Added Date") != null)
                    olvPosts.GetColumn("Added Date").IsVisible =
                        Settings.AppGUISettings.RSSColumnsVisibleStatus[addeddate].Visible;
                if (olvPosts.GetColumn("Later Read?") != null)
                    olvPosts.GetColumn("Later Read?").IsVisible =
                        Settings.AppGUISettings.RSSColumnsVisibleStatus[readlater].Visible;
                olvPosts.RebuildColumns();
                Settings.AppGUISettings.SetDefaultColumns();

            }
            olvPosts.ResumeLayout();
            #endregion
   

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

        #endregion

       
    }
}
