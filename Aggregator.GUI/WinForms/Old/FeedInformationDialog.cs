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

namespace Aggregator.GUI.WinForms.Old
{
    public partial class FeedInformationDialog : Form
    {
        private AppSettings Settings { get; set; }
        public IRSSFeed Feed { get; set; }
        public RSSFeedsContainer  FeedsContainer { get; set; }
        public bool SuppressErrorDisplay { get; private set; }
        #region Events
        public event EventHandler<FeedArgs> OnFeedActiveStatusChanged = delegate { };
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
        }
        #endregion

        #region Form Methods
        private void FeedInformationDialog_Load(object sender, EventArgs e)
        {
            chklstbCategories.BeginUpdate();
            chklstbCategories.DataSource = FeedsContainer.GetCategories().ToList();
            chklstbCategories.DisplayMember = Util.Reflection.GetPropertyName((IRSSCategory cat) => cat.CategoryName);
            for (int i = 0; i < FeedsContainer.CategoriesCount; i++)
            {
                bool belongtocategory = Feed.BelongsToCategories.Contains(FeedsContainer.GetCategoryAt(i));
                chklstbCategories.SetItemChecked(i,belongtocategory);
            }
            chklstbCategories.EndUpdate();
            GetFeedPosts(true);
        }
        #endregion

        #region Form controls Methods
        private void DisplayRSSItems(List<IRSSPost> RSSPosts)
        {
            dgvRSSPosts.SuspendLayout();
            
            int countnewitems = 0;
            if (RSSPosts != null)
            {
                dgvRSSPosts.DataSource = RSSPosts;
                countnewitems = (RSSPosts).Count(itm => itm.Read == false);
            }
            if (dgvRSSPosts.DataSource != null)
            {
      
                foreach (var columnname in Settings.AppGUISettings.RSSColumnsVisibleStatus)
                {
                    if (dgvRSSPosts.Columns.Contains(columnname.Key))
                        dgvRSSPosts.Columns[columnname.Key].Visible = columnname.Value.Visible;
                        dgvRSSPosts.Columns[columnname.Key].HeaderText = columnname.Value.HeaderText;
                }

                string title = Reflection.GetPropertyName(((IRSSPost itm) => itm.Title));
                string feedName = Reflection.GetPropertyName(((IRSSPost itm) => itm.FeedName));
                string IgnorePostContentIncomparison = Reflection.GetPropertyName(((IRSSPost itm) => itm.IgnorePostContentIncomparison));
                string IgnoreThisPost = Reflection.GetPropertyName(((IRSSPost itm) => itm.IgnoreThisPost));
                string followup = Reflection.GetPropertyName(((IRSSPost itm) => itm.FollowUp));

                dgvRSSPosts.Columns[followup].HeaderText = "for later read?";
                dgvRSSPosts.Columns[followup].Visible = true;

                dgvRSSPosts.Columns[IgnorePostContentIncomparison].HeaderText = "Don't keep history?";
                dgvRSSPosts.Columns[IgnorePostContentIncomparison].Visible = true;

                dgvRSSPosts.Columns[IgnoreThisPost].HeaderText = "Hidden post?";
                dgvRSSPosts.Columns[IgnoreThisPost].Visible = true;

                dgvRSSPosts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; //Row height autosize
                dgvRSSPosts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvRSSPosts.Columns[title].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvRSSPosts.Columns[title].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvRSSPosts.Columns[feedName].DefaultCellStyle.WrapMode = DataGridViewTriState.False;

                dgvRSSPosts.ResumeLayout();
            }

        }
        private void dgvRSSPosts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRSSPosts.CurrentRow != null)
            {
                IRSSPost currentitem = (IRSSPost)dgvRSSPosts.CurrentRow.DataBoundItem;
                var rssDisplay = new RSSItemViewer(currentitem);
                rssDisplay.OnRSSItemChanged += delegate { dgvRSSPosts.Refresh(); };

                rssDisplay.Show();
                currentitem.Read = true;
                dgvRSSPosts.Refresh();
            }
        }
        private void dgvRSSPosts_Click(object sender, EventArgs e)
        {
            if (dgvRSSPosts.CurrentRow != null)
            {
                IRSSPost currentitem = (IRSSPost)dgvRSSPosts.CurrentRow.DataBoundItem;
                gbSelectedPost.Text = "Selected Post: " + currentitem.Title;
                chkbHistory.Checked = currentitem.IgnorePostContentIncomparison;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvRSSPosts.CurrentRow != null)
            {
                IRSSPost currentitem = (IRSSPost)dgvRSSPosts.CurrentRow.DataBoundItem;
                DialogResult result = MessageShow.ShowMessage(this,
                                                           "Are you sure you want to delete the selected post?",
                                                           "Post Deletion confirmation",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.
                                                               Exclamation);
                if (result == DialogResult.Yes)
                {
                    currentitem.DeleteThisPost();
                    GetFeedPosts(chkbShowHiddenPosts.Checked );
                    
                }
            }
        }
        
        private void chkbShowHiddenPosts_CheckedChanged(object sender, EventArgs e)
        {
            GetFeedPosts(chkbShowHiddenPosts.Checked);
        }
        #endregion
        
        #region General Methods

        private void GetFeedPosts(bool showHiddenPosts)
        {
            lblRSSURL.Text = "RSS URL: " + Feed.RSSName;
            txtbRSSName.Text = "RSS Name: " + Feed.RSSUrl;
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
            if (dgvRSSPosts.CurrentRow != null)
            {
                IRSSPost currentitem = (IRSSPost)dgvRSSPosts.CurrentRow.DataBoundItem;
                currentitem.IgnoreThisPost = !currentitem.IgnoreThisPost;
                dgvRSSPosts.Refresh();
                
            }
        }

        

        private void chkbHistory_Click(object sender, EventArgs e)
        {
            if (dgvRSSPosts.CurrentRow != null)
            {
                IRSSPost currentitem = (IRSSPost)dgvRSSPosts.CurrentRow.DataBoundItem;
                currentitem.IgnorePostContentIncomparison = !currentitem.IgnorePostContentIncomparison;
                dgvRSSPosts.Refresh();
            }
        }

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

   

        

        



    }
}
