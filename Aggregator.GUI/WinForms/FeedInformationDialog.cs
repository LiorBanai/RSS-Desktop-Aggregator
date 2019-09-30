using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aggregator.Core;
using Aggregator.Data;
using Aggregator.Util;

namespace Aggregator.GUI.WinForms
{
    public partial class FeedInformationDialog : Form
    {
        private AppSettings Settings { get; set; }
        public IRSSFeed Feed { get; set; }
        public RSSFeedsContainer  FeedsContainer { get; set; }
        public bool SuppressErrorDisplay { get; private set; }
        #region Events
        public event EventHandler<FeedArgs> OnFeedActiveStatusChanged = delegate { };
        public event EventHandler<RSSArgs> OnPostChanged = delegate { };
        #endregion
     
        #region Ctor
        public FeedInformationDialog(RSSFeedsContainer  feedsContainer,IRSSFeed feed, AppSettings settings, bool suppressErrorDisplay)
        {
            InitializeComponent();
            FeedsContainer = feedsContainer;
            ToolTip ttBtns = new ToolTip();
            ttBtns.SetToolTip(btnDelete, "Delete the selected post");
            ttBtns.SetToolTip(btnHide, "Hide/Show the selected post");
            Feed = feed;
            Settings = settings;
            this.SuppressErrorDisplay = suppressErrorDisplay;
            OnPostChanged += PostChanged;
        }


        #endregion

        #region Form Methods
        private void FeedInformationDialog_Load(object sender, EventArgs e)
        {
            chklstbCategories.ItemCheck -= chklstbCategories_ItemCheck;
            chklstbCategories.BeginUpdate();
            chklstbCategories.DataSource = FeedsContainer.GetCategories().ToList();
            chklstbCategories.DisplayMember = Util.Reflection.GetPropertyName((IRSSCategory cat) => cat.CategoryName);

            for (int i = 0; i < FeedsContainer.CategoriesCount; i++)
            {
                bool belongtocategory = Feed.BelongsToCategories.Contains(FeedsContainer.GetCategoryAt(i));
                chklstbCategories.SetItemChecked(i,belongtocategory);
            }
            chklstbCategories.EndUpdate();
            chklstbCategories.ItemCheck += chklstbCategories_ItemCheck;
            GetFeedPosts(true);
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
                    olvPosts.Refresh();
                }
            }
        }
        private void olvPosts_Click(object sender, EventArgs e)
        {
            if (olvPosts.SelectedObject != null)
            {
                IRSSPost currentitem = olvPosts.SelectedObject as IRSSPost;
                if (currentitem != null)
                {
                    gbSelectedPost.Text = "Selected Post: " + currentitem.Title;
                    chkbHistory.Checked = currentitem.IgnorePostContentIncomparison;
                    OnPostChanged(this, new RSSArgs(currentitem));
                }
            }
        }

        private void DisplayRSSItems(List<IRSSPost> RSSPosts)
        {
            
            int countnewitems = 0;
            if (RSSPosts != null)
            {
                olvPosts .SetObjects(RSSPosts);
                olvPosts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                countnewitems = (RSSPosts).Count(itm => itm.Read == false);
      
                //string title = Reflection.GetPropertyName(((IRSSPost itm) => itm.Title));
                //string feedName = Reflection.GetPropertyName(((IRSSPost itm) => itm.FeedName));
                //string IgnorePostContentIncomparison = Reflection.GetPropertyName(((IRSSPost itm) => itm.IgnorePostContentIncomparison));
                //string IgnoreThisPost = Reflection.GetPropertyName(((IRSSPost itm) => itm.IgnoreThisPost));
                //string followup = Reflection.GetPropertyName(((IRSSPost itm) => itm.FollowUp));

            }
        tsslblRowCount.Text = "Number of rows: " + countnewitems;

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
              if (olvPosts.SelectedObject != null)
            {
                var currentitem = olvPosts.SelectedObject as IRSSPost;
                   if (currentitem != null)
                   {
                       DialogResult result = MessageShow.ShowMessage(this,
                                                                     "Are you sure you want to delete the selected post?",
                                                                     "Post Deletion confirmation",
                                                                     MessageBoxButtons.YesNo,
                                                                     MessageBoxIcon.
                                                                         Exclamation);
                       if (result == DialogResult.Yes)
                       {
                           currentitem.DeleteThisPost();
                           GetFeedPosts(chkbShowHiddenPosts.Checked);

                       }
                   }
            }
        }
        
        private void chkbShowHiddenPosts_CheckedChanged(object sender, EventArgs e)
        {
            GetFeedPosts(chkbShowHiddenPosts.Checked);
        }
        #endregion
        
        #region General Methods
        private void PostChanged(object sender, RSSArgs e)
        {
            olvPosts.RefreshObject(e.Post);
        }
        private void GetFeedPosts(bool showHiddenPosts)
        {
            lblRSSURL.Text = "RSS URL: " + Feed.RSSUrl;
            txtbRSSName.Text = "RSS Name: " + Feed.RSSName ;
            lbldownloadedSize.Text = "Downloaded Size: " + Util.Utils.FormatKBytes(Feed.TotalDownloadedKB);
            lblTotalUpdates.Text = "Number of updates: " + Feed.TotalUpdates;
            chkbActiveFeed.Checked = Feed.Active;
            chkbPrivateFeed.Checked = Feed.IsPersonalFeed;
            chkbIgnoreHistory.Checked = Feed.DontKeepHistory;
            chkbDisabled.Checked = Feed.Disabled;
            lblUnreadItems.Text = string.Format("Unread Posts: {0} out of {1}", Feed.UnreadItemsCount, Feed.TotalItemsCount);

            var feedPosts = Feed.GetAllItemsFromCache(false,  showHiddenPosts).ToList();
            DisplayRSSItems(feedPosts);
        }
        #endregion

        private void btnHide_Click(object sender, EventArgs e)
        {
              if (olvPosts.SelectedObject != null)
            {
                IRSSPost currentitem = olvPosts.SelectedObject as IRSSPost;
                if (currentitem != null)
                {
                    currentitem.IgnoreThisPost = !currentitem.IgnoreThisPost;
                    OnPostChanged(this, new RSSArgs(currentitem));
                }

            }
        }
    
        private void chkbHistory_Click(object sender, EventArgs e)
        {
                  if (olvPosts.SelectedObject != null)
            {
                IRSSPost currentitem = olvPosts.SelectedObject as IRSSPost;
                if (currentitem != null)
                {
                currentitem.IgnorePostContentIncomparison = !currentitem.IgnorePostContentIncomparison;
                OnPostChanged(this, new RSSArgs(currentitem));
            }
        }}

        private void chkbActiveFeed_Click(object sender, EventArgs e)
        {
            Feed.Active = chkbActiveFeed.Checked;
            OnFeedActiveStatusChanged(this, new FeedArgs(Feed, false));
        }

        private void chkbPrivateFeed_Click(object sender, EventArgs e)
        {
            Feed.IsPersonalFeed = chkbPrivateFeed.Checked;
            if (Feed.IsPersonalFeed)
            {
                MessageShow.ShowMessage(this, "Changing a feed to private will reset the posts ONLY ON NEXT web refresh (Manual/Automatic refresh).",
                                        "Caution");
            }
        }

        private void chkbIgnoreHistory_Click(object sender, EventArgs e)
        {
            Feed.DontKeepHistory= chkbIgnoreHistory.Checked;
        }

  
        private void chklstbCategories_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.Index >= 0)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    IRSSCategory cat = chklstbCategories.SelectedItem as IRSSCategory;
                    if (cat != null)
                        Feed.AddToCategory(cat);
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    IRSSCategory cat = chklstbCategories.SelectedItem as IRSSCategory;
                    if (cat != null)
                        Feed.RemoveFromCategory(cat);
                }
                OnFeedActiveStatusChanged(this, new FeedArgs(FeedsContainer[e.Index], false));
            }
        }

        private void chkbDisabled_Click(object sender, EventArgs e)
        {
            Feed.Disabled = chkbDisabled.Checked;
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
                    OnPostChanged(this, new RSSArgs(currentitem));
                 
                }
            }
        }


   

        

        



    }
}
