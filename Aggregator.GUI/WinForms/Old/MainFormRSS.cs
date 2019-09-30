using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aggregator.Core;
using Aggregator.Data;
using Aggregator.GUI.Properties;
using Aggregator.Util;
using Outlook.GUI.WinForms;
using System.Drawing;
using Application = System.Windows.Forms.Application;
using Exception = System.Exception;

namespace Aggregator.GUI.WinForms.Old
{
    public partial class MainFormRSS : Form
    {
        #region Aero Efect Data Members

        // Inform all top-level windows that Desktop Window Manager (DWM) 
        // composition has been enabled or disabled.
        private const int WM_DWMCOMPOSITIONCHANGED = 0x031E;

        // Sent to a window in order to determine what part of the window 
        // corresponds to a particular screen coordinate.
        private const int WM_NCHITTEST = 0x84;

        // In a client area.
        private const int HTCLIENT = 0x01;

        // A less frequently used Color that is used as the TransparencyKey.  
        private static Color transparentColor = Color.DarkTurquoise;

        /// <summary>
        /// Specify whether extending the frame is enabled.
        /// </summary>
        public bool ExtendFrameEnabled { get; set; }

        /// <summary>
        /// Specify whether the blur effect is enabled.
        /// </summary>
        public bool BlurBehindWindowEnabled { get; set; }

        private Region marginRegion = null;

        /// <summary>
        /// Set the frame border. 
        /// </summary>
        public NativeMethods.MARGINS GlassMargins { get; set; }

        private Region blurRegion = null;

        /// <summary>
        /// The region that the blur effect will be applied.
        /// </summary>
        public Region BlurRegion
        {
            get
            {
                return blurRegion;
                ;
            }
            set
            {
                if (blurRegion != null)
                {
                    blurRegion.Dispose();
                }
                blurRegion = value;
            }
        }

        public event EventHandler DWMCompositionChanged;

        #endregion
        //#region Aero Effect Methods

        ///// <summary>
        ///// When the size of this form changes, redraw the form.
        ///// </summary>
        //protected override void OnSizeChanged(EventArgs e)
        //{
        //    base.OnSizeChanged(e);
        //    this.Invalidate();
        //}

        ///// <summary>
        ///// When the form is painted, set the region where the glass effect 
        ///// is applied.
        ///// </summary>
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    if ((!ExtendFrameEnabled && !BlurBehindWindowEnabled)
        //        || !IsAeroGlassStyleSupported())
        //    {
        //        return;
        //    }

        //    using (Brush transparentBrush = new SolidBrush(transparentColor))
        //    {

        //        // Extend the frame.
        //        if (ExtendFrameEnabled)
        //        {
        //            var glassMargins = this.GlassMargins;

        //            // Extend the frame.
        //            NativeMethods.DwmExtendFrameIntoClientArea(this.Handle,
        //                                                       ref glassMargins);

        //            // Make the region in the margins transparent. 
        //            marginRegion = new Region(this.ClientRectangle);

        //            // If the glassMargins contains a negative value, or the values are not valid,
        //            // then make the whole form transparent.
        //            if (this.GlassMargins.IsNegativeOrOverride(this.ClientSize))
        //            {
        //                e.Graphics.FillRegion(transparentBrush, marginRegion);
        //            }

        //                // By default, exclude the region of the client area.
        //            else
        //            {
        //                marginRegion.Exclude(new Rectangle(
        //                                         this.GlassMargins.cxLeftWidth,
        //                                         this.GlassMargins.cyTopHeight,
        //                                         this.ClientSize.Width - this.GlassMargins.cxLeftWidth -
        //                                         this.GlassMargins.cxRightWidth,
        //                                         this.ClientSize.Height - this.GlassMargins.cyTopHeight -
        //                                         this.GlassMargins.cyBottomHeight));
        //                e.Graphics.FillRegion(transparentBrush, marginRegion);
        //            }
        //        }

        //            // Reset the frame to the default state.
        //        else
        //        {
        //            var glassMargins = new NativeMethods.MARGINS(-1);
        //            NativeMethods.DwmExtendFrameIntoClientArea(this.Handle,
        //                                                       ref glassMargins);
        //        }

        //        // Enable the blur effect on the form.
        //        if (BlurBehindWindowEnabled)
        //        {
        //            ResetDwmBlurBehind(true, e.Graphics);

        //            if (this.BlurRegion != null)
        //            {
        //                e.Graphics.FillRegion(transparentBrush, BlurRegion);
        //            }
        //            else
        //            {
        //                e.Graphics.FillRectangle(transparentBrush, this.ClientRectangle);
        //            }
        //        }
        //        else
        //        {
        //            ResetDwmBlurBehind(false, null);
        //        }
        //    }
        //}

        ///// <summary>
        ///// Enable or disable the blur effect on the form.
        ///// </summary>
        //private void ResetDwmBlurBehind(bool enable, Graphics graphics)
        //{
        //    try
        //    {
        //        NativeMethods.DWM_BLURBEHIND bbh = new NativeMethods.DWM_BLURBEHIND();

        //        if (enable)
        //        {
        //            bbh.dwFlags = NativeMethods.DWM_BLURBEHIND.DWM_BB_ENABLE;
        //            bbh.fEnable = true;

        //            if (this.BlurRegion != null)
        //            {
        //                bbh.hRegionBlur = this.BlurRegion.GetHrgn(graphics);
        //            }
        //            else
        //            {
        //                // Apply the blur glass effect to the entire window.
        //                bbh.hRegionBlur = IntPtr.Zero;
        //            }
        //        }
        //        else
        //        {
        //            bbh.dwFlags = NativeMethods.DWM_BLURBEHIND.DWM_BB_ENABLE |
        //                          NativeMethods.DWM_BLURBEHIND.DWM_BB_BLURREGION;
        //            // Turn off the glass effect.
        //            bbh.fEnable = false;
        //            // Apply the blur glass effect to the entire window.
        //            bbh.hRegionBlur = IntPtr.Zero;
        //        }
        //        NativeMethods.DwmEnableBlurBehindWindow(this.Handle, bbh);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        MessageShow.ShowException(this, ex);
        //    }
        //}

        ///// <summary>
        ///// Make sure the current computer is able to display the glass style windows.
        ///// </summary>
        ///// <returns>
        ///// The flag that specify whether DWM composition is enabled or not.
        ///// </returns>
        //public static bool IsAeroGlassStyleSupported()
        //{
        //    bool isDWMEnable = false;
        //    try
        //    {
        //        // Check that the glass is enabled by using the DwmIsCompositionEnabled. 
        //        // It is supported in version 6.0 or above of the operating system.
        //        if (System.Environment.OSVersion.Version.Major >= 6)
        //        {
        //            // Make sure the Glass is enabled by the user.
        //            NativeMethods.DwmIsCompositionEnabled(out isDWMEnable);
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {

        //    }

        //    return isDWMEnable;
        //}

        ///// <summary>
        ///// This method makes that users can drag the form by click the extended frame.
        ///// </summary>
        //protected override void WndProc(ref Message m)
        //{
        //    // Let the normal WndProc process it.
        //    base.WndProc(ref m);

        //    switch (m.Msg)
        //    {
        //        case WM_NCHITTEST:
        //            // The mouse is inside the client area
        //            if (HTCLIENT == m.Result.ToInt32())
        //            {
        //                // Parse the WM_NCHITTEST message parameters
        //                // get the mouse pointer coordinates (in screen coordinates)
        //                Point p = new Point();
        //                // low order word
        //                p.X = (m.LParam.ToInt32() & 0xFFFF);
        //                // high order word
        //                p.Y = (m.LParam.ToInt32() >> 16);

        //                // Convert screen coordinates to client area coordinates
        //                p = PointToClient(p);

        //                // If it's on glass, then convert it from an HTCLIENT
        //                // message to an HTCAPTION message and let Windows handle it 
        //                // from then on.
        //                if (PointIsOnGlass(p))
        //                {
        //                    m.Result = new IntPtr(2);
        //                }
        //            }
        //            break;
        //        case WM_DWMCOMPOSITIONCHANGED:

        //            // Release the resource when glass effect is not supported.
        //            if (DWMCompositionChanged != null)
        //            {
        //                DWMCompositionChanged(this, EventArgs.Empty);
        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //}

        ///// <summary>
        ///// Check that the point is inside the glass area.
        ///// </summary>
        //private bool PointIsOnGlass(Point p)
        //{
        //    if (this.marginRegion == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return this.marginRegion.IsVisible(p);
        //    }
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    base.Dispose(disposing);

        //    if (this.marginRegion != null)
        //    {
        //        marginRegion.Dispose();
        //    }

        //    if (this.BlurRegion != null)
        //    {
        //        this.BlurRegion.Dispose();
        //    }
        //}

        //#endregion

        #region Events Declerations

        public delegate void EventHandler<in T>(object sender, T e) where T : EventArgs;
        public event EventHandler<LogArgs> OnLogOperation = delegate { };
        public event EventHandler<LogArgs> OnCurrentFeedsChanged = delegate { };
        public event EventHandler<LogArgs> OnWebRefresh = delegate { };
        public event EventHandler<LogArgs> OnWebEndRefresh = delegate { };
        //public event EventHandler<RefreshArgs> OnPostReadStatusChange = delegate { };

        #endregion

        #region Data Members
        private ulong TotalDownloadedKB { get; set; }
        public static List<RSSFeedsContainer> FeedsGroup { get; private set; }
        private AppSettings Settings { get; set; }
        private ErrorsForm errorLIst;
        private LogsForm logLIst;
        private int RSSCount { get; set; }
        private bool NewItems { get; set; }
        private int RSStimeToRefreshSecondsCountdown;
        private bool cancelExit = true;
        private StringBuilder RSSOperationLog;
        private List<IRSSPost> DisplayPosts { get; set; }
        private List<IRSSFeed> DisplayFeeds { get; set; }
        private string DisplayFeedsName { get; set; }
        private bool BusyRefreshingFromWeb { get; set; }
        private TreeNode LastSelectedNode { get; set; }

        private object lastControl;
        #endregion

        #region GUI Data Members
        #endregion

        #region Ctor related

        public MainFormRSS()
        {
            InitializeComponent();
            BusyRefreshingFromWeb = false;

            this.TransparencyKey = transparentColor;
            BlurBehindWindowEnabled = false;
            blurRegion = null;
            errorLIst = new ErrorsForm();
            RSSOperationLog = new StringBuilder();
            logLIst = new LogsForm();
            dgvRSSItems.DataSource = new List<IRSSPost>(0);
            DisplayPosts = new List<IRSSPost>(0);
            dgvRSSItems.DataSource = DisplayPosts;
            DisplayFeeds = new List<IRSSFeed>(0);
            DisplayFeedsName = string.Empty;
            LoadSettings();

            #region Events Subscribings

            #region ToolStrip MenuItems Subscribings

            dateToolStripMenuItem.CheckedChanged += new EventHandler(RSSColumnsToolStripMenuItem_CheckedChanged);
            titleToolStripMenuItem.CheckedChanged += new EventHandler(RSSColumnsToolStripMenuItem_CheckedChanged);
            descriptionToolStripMenuItem.CheckedChanged += new EventHandler(RSSColumnsToolStripMenuItem_CheckedChanged);
            URLToolStripMenuItem.CheckedChanged += new EventHandler(RSSColumnsToolStripMenuItem_CheckedChanged);
            creatorToolStripMenuItem.CheckedChanged += new EventHandler(RSSColumnsToolStripMenuItem_CheckedChanged);
            contentToolStripMenuItem.CheckedChanged += new EventHandler(RSSColumnsToolStripMenuItem_CheckedChanged);
            readToolStripMenuItem.CheckedChanged += new EventHandler(RSSColumnsToolStripMenuItem_CheckedChanged);
            linkToolStripMenuItem.CheckedChanged += new EventHandler(RSSColumnsToolStripMenuItem_CheckedChanged);
            feedNameToolStripMenuItem.CheckedChanged += new EventHandler(RSSColumnsToolStripMenuItem_CheckedChanged);
            addedDateToolStripMenuItem.CheckedChanged += new EventHandler(RSSColumnsToolStripMenuItem_CheckedChanged);
            followUpPostToolStripMenuItem.CheckedChanged += new EventHandler(RSSColumnsToolStripMenuItem_CheckedChanged);

            tsmiRestart.Click += (sender, args) =>
                                     {
                                         cancelExit = false;
                                         Application.Restart();
                                     };
            tsmiExit.Click += (sender, args) =>
            {
                cancelExit = false;
                Close();
            };
            tsmiVersion.Click += (sender, args) => new VersionHistoryDialog().ShowDialog();
            tsmiAbout.Click += (sender, args) => new AboutBoxDesktopAggregator().ShowDialog();
            tsmiStatistics.Click += (sender, e) => new NetworkStatistics().Show();
            tsmiErrorsList.Click += (sender, args) => errorLIst.ShowDialog();
            tsmiViewLogOperations.Click += (sender, args) => logLIst.Show();

            tsmiRefresh.Click += (sender, args) => RSStimeToRefreshSecondsCountdown = 0;
            tsmiClose.Click += (sender, args) =>
                                   {
                                       cancelExit = false;
                                       Close();
                                   };

            tsmiApplicationSettings.Click += (sender, args) => OpenSettingsDialog(false);
            tsmiOutlook.Click += (sender, e) =>
                            {
                                var outlookform = new MainFormOutlook(Settings);
                                outlookform.Show();
                            };
            #endregion
        
            #region ToolStrips Buttons Subscribings

            tsbtnSearch.Click += (sender, e) => new SearchForm(FeedsGroup, Settings).Show( );
            tsbtnSettings.Click += (sender, args) => OpenSettingsDialog(true);
            tsbtnNewFeed.Click += (sender, args) => OpenSettingsDialog(true);
            tsbtnExportFeed.Click += (sender, e) => new FeedExports(FeedsGroup, Settings).ShowDialog();
            tsbtnRefreshNonActive.Click += (sender, e) => RefreshRSS(false);
            tsbtnRefreshActive.Click += (sender, e) => RefreshRSS(true);


            tsbtnFacebook.Click += (sender, e) =>
            {
                try
                { Process.Start("http://www.facebook.com/LBDesktopAggregator"); }
                catch (System.Exception ex) { MessageShow.ShowException(this, ex); }
            };
            #endregion

            #region General Subscribings
            OnWebRefresh += WebRefreshStarted;
            OnWebEndRefresh += WebRefreshEnded;
            btnClearLog.Click += (sender, e) =>
                                     {
                                         lock (RSSOperationLog)
                                         {
                                             RSSOperationLog.Clear();
                                             rtxbMsg.Text = "";
                                         }
                                     };
            notifyIconStatus.Click += (sender, args) =>
                                          {
                                              Visible = !Visible;
                                              if (Visible)
                                                  Activate();
                                          };

            notifyIconStatus.BalloonTipClicked += (sender, args) => { Visible = true; Activate(); };

            MessageShow.OnExceptionLogin += (sender, e) => errorLIst.AddError(e.Message);
            OnLogOperation += (sender, args) =>
                                  {
                                      logLIst.AddOperation(args.Message + "\n");
                                      lock (RSSOperationLog)
                                      {
                                          RSSOperationLog.Append(args.Message + "\n");
                                          LogInThisForm(args.Message + "\n");
                                      }
                                  };

            #endregion
            #endregion
        }

        #endregion
        
        #region Form Methods

        private void MainFormRSS_Load(object sender, System.EventArgs e)
        {
            UpdateRSSColumns(dgvRSSItems);
            spltcMain.SplitterDistance = Settings.AppGUISettings.MainRSSFormLeftPanelWidth;

            UpdateFeedsCountsAfterChange();

            notifyIconStatus.ShowBalloonTip(1000, "Desktop Aggregator", "When there are new items a popup will be shown here which can be clicked on to open the main window. Clicking on the tray icon will show/hide the main window", ToolTipIcon.None);

            //	this.TransparencyKey = BackColor;

            //clear the RRS datagrid
            DisplayRSSItems(dgvRSSItems,false);

            BuildFeedsGroups();
            LoadAllFeedsToControl();
            tvFeedsGroup.Focus();

        }

        private void MainFormRSS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancelExit)
            {
                e.Cancel = true;
                Visible = false;
                notifyIconStatus.ShowBalloonTip(1000, "Desktop Aggregator", "The program will keep running in the background. To close it right click this icon and choose Close or select exit from the File menu", ToolTipIcon.Info);
            }
            else
            {
                SaveAllFeedsToDisk();
                SaveAppSettings();
            }
        }

        private void MainFormRSS_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
            }
        }

        #endregion

        #region Form Controls Methods
        #region ToolStrips Buttons and menus methods
        private void tsbtnRSSStopStart_Click(object sender, EventArgs e)
        {
            tmrRefreshRSS.Enabled = !tmrRefreshRSS.Enabled;
            tsbtnRSSStopStart.Image = tmrRefreshRSS.Enabled ? Resources.Pauseicon : Resources.Playicon;
        }

        private void tsbtnFeedInformation_Click(object sender, EventArgs e)
        {
            if (DisplayFeeds.Count == 1)
            {
                var posts =
                    new FeedInformationDialog(FeedsGroup.FirstOrDefault(), DisplayFeeds.First(), Settings,
                                              !Settings.AppRSSSetings.NotifyOnRSSErrors);
                posts.OnFeedActiveStatusChanged += (s, a) => LoadFeedsToControl(true);
                posts.ShowDialog();
            }
            else
            {
                MessageShow.ShowMessage(this, "Feed information is available only when a single feed is selected.",
                                        "Feed Information");
            }
        }

        private void tsbtnFollowupPostMark_Click(object sender, EventArgs e)
        {
            if (dgvRSSItems.CurrentRow != null)
            {
                IRSSPost post = dgvRSSItems.CurrentRow.DataBoundItem as IRSSPost;
                if (post != null)
                    if (!post.FollowUp)
                    {
                        post.FollowUp = true;
                        string msg = string.Format("post {0} has been marked for later read.", post.Title);
                        MessageShow.ShowMessage(this, msg, "Post marked for later read");
                    }
                    else
                    {
                        string msg = string.Format("post {0} is already marked for later read.\n Do you want to unmark it?", post.Title);
                        var result = MessageShow.ShowMessage(this, msg, "Post is already marked for later read", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) post.FollowUp = false;
                    }

            }
            dgvRSSItems.Refresh();
        }
        private void tsbtnFollowUpPosts_Click(object sender, EventArgs e)
        {
            var followupPost = new FollowUpPosts(FeedsGroup.FirstOrDefault(), Settings);
            followupPost.Show();
        }

        private void tsbtnRefreshGroup_Click(object sender, EventArgs e)
        {
            if (LastSelectedNode != null)
            {

                LoadFeeds(LastSelectedNode.Name, LastSelectedNode.Tag as IRSSCategory);
                bool unreadOnly = chkbUnreadposts.Checked;
                GetRSSItemsFromFeeds(DisplayFeeds, unreadOnly, true);
            }
            else
                MessageShow.ShowMessage(this, "No category was selected", "Unable to continue");
        }

        private void tsbtnRefreshCurrentFeeds_Click(object sender, EventArgs e)
        {
            if (DisplayFeeds != null)
            {

                bool unreadOnly = chkbUnreadposts.Checked;
                GetRSSItemsFromFeeds(DisplayFeeds, unreadOnly, true);
            }
        }
        #endregion 
        private void tstxtbSearchFeed_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tstxtbSearchFeed.Text))
            {
                tstxtbSearchFeed.SelectionStart = 0;
                tstxtbSearchFeed.SelectionLength = tstxtbSearchFeed.Text.Length;
            }
        }
        private void tstxtbSearchFeed_KeyUp(object sender, KeyEventArgs e)
        {
            // if (Settings .AppRSSSetings .IncrementalSearch || e.KeyChar == (char)Keys.Return)
            lastControl = tstxtbSearchFeed;
            if (true)
            {
                if (string.IsNullOrEmpty(tstxtbSearchFeed.Text))
                    DisplayRSSItems(dgvRSSItems, chkbUnreadposts.Checked);
                else
                {
                    List<IRSSPost> allMatchedPosts;
                    if (DisplayFeeds == null)
                        allMatchedPosts = SearchForm.SearchInPosts(DisplayPosts, tstxtbSearchFeed.Text).ToList();
                    else
                        allMatchedPosts = SearchForm.SearchInFeeds(DisplayFeeds, tstxtbSearchFeed.Text).ToList();

                    DisplayRSSItems(dgvRSSItems, chkbUnreadposts.Checked, allMatchedPosts);
                    tsslblRecordsInSearch.Text = "Number of records: " + allMatchedPosts.Count;

                }

            }

        }

        private void chkbUnreadposts_CheckedChanged(object sender, EventArgs e)
        {
            if (DisplayPosts == null)
                LoadFeedsPosts();
            DisplayRSSItems(dgvRSSItems, chkbUnreadposts.Checked);

        }
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
        private void RSSColumnsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            string date = Reflection.GetPropertyName(((IRSSPost itm) => itm.Date));
            string title = Reflection.GetPropertyName(((IRSSPost itm) => itm.Title));
            string description = Reflection.GetPropertyName(((IRSSPost itm) => itm.Description));
            string url = Reflection.GetPropertyName(((IRSSPost itm) => itm.Url));
            string creator = Reflection.GetPropertyName(((IRSSPost itm) => itm.Creator));
            string content = Reflection.GetPropertyName(((IRSSPost itm) => itm.Content));
            string read = Reflection.GetPropertyName(((IRSSPost itm) => itm.Read));
            string link = Reflection.GetPropertyName(((IRSSPost itm) => itm.Link));
            string feedname = Reflection.GetPropertyName(((IRSSPost itm) => itm.FeedName));
            string belongstoFeed = Reflection.GetPropertyName(((IRSSPost itm) => itm.BelongsToFeed));
            string addeddate = Reflection.GetPropertyName(((IRSSPost itm) => itm.AddedDate));
            string ignoreThisPost = Reflection.GetPropertyName(((IRSSPost itm) => itm.IgnoreThisPost));
            string followup = Reflection.GetPropertyName(((IRSSPost itm) => itm.FollowUp));

            Settings.AppGUISettings.RSSColumnsVisibleStatus[date].Visible = dateToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[title].Visible = titleToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[description].Visible = descriptionToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[url].Visible = URLToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[creator].Visible = creatorToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[content].Visible = contentToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[read].Visible = readToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[link].Visible = linkToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[feedname].Visible = feedNameToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[addeddate].Visible = addedDateToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[followup].Visible = followUpPostToolStripMenuItem.Checked;

            SaveAppSettings();
            UpdateRSSColumns(dgvRSSItems);
        }

        #region Data Grid View Methods
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
                UpdateFeedsCountsAfterChange();
                dgvRSSItems.Refresh();
            }
        }
        private void dgvRSSItems_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvRSSItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateFeedsCountsAfterChange();
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
        private void btnMarkAllRSSAsRead_Click(object sender, EventArgs e)
        {
            tmrRefreshRSS.Enabled = false;
            foreach (DataGridViewRow row in dgvRSSItems.Rows)
            {
                IRSSPost currentitem = (IRSSPost)row.DataBoundItem;
                currentitem.Read = true;
            }
            UpdateFeedsCountsAfterChange();
            dgvRSSItems.Refresh();
            tmrRefreshRSS.Enabled = true;
        }
        private void tmrRefreshRSS_Tick(object sender, System.EventArgs e)
        {
            if (RSStimeToRefreshSecondsCountdown <= 0) //do routing
            {
                RefreshRSS(true);

            }
            else
            {
                RSStimeToRefreshSecondsCountdown--;
            }

            TimeSpan time = TimeSpan.FromSeconds(RSStimeToRefreshSecondsCountdown);
            tsslNextRefreshRSS.Text = time.ToString();
        }

        #endregion

        #region Saving & Loading

        private void LoadSettings()
        {
            bool aggregatorPerUser = Properties.Settings.Default.StorePerUser;

            Settings = AppSettings.LoadSettings(aggregatorPerUser, false);
            FeedsGroup = new List<RSSFeedsContainer>(0);
            FeedsGroup.Add(RSSFeedsContainer.DeSerializeBinaryFile(Settings.AppRSSSetings.FileName));

            OnFeedsChanges(this, new Core.FeedArgs(null, false));
            RSSCount = 0;


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

            dateToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[date].Visible;
            titleToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[title].Visible;
            descriptionToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[description].Visible;
            URLToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[url].Visible;
            creatorToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[creator].Visible;
            contentToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[content].Visible;
            readToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[read].Visible;
            linkToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[link].Visible;
            feedNameToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[feedname].Visible;
            addedDateToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[addeddate].Visible;
            //==================== end columns settings =======================
            #endregion

            chkbWhenToMarkAsRead.Checked = Settings.AppGUISettings.MarkRSSPostasReadOnRead;
            ShowInTaskbar = Settings.AppGUISettings.ShowTaskbarIcon;

            RSStimeToRefreshSecondsCountdown = Settings.AppRSSSetings.IntervalMinutes * 60;

            tmrRefreshRSS.Enabled = Settings.AppRSSSetings.EnabledRSSReader;
            if (RSStimeToRefreshSecondsCountdown < 120)
                RSStimeToRefreshSecondsCountdown = 120;

        }
        private void SaveAppSettings()
        {
            Settings.AppGUISettings.MainRSSFormLeftPanelWidth = spltcMain.SplitterDistance;
            Settings.AppGUISettings.MarkRSSPostasReadOnRead = chkbWhenToMarkAsRead.Checked;
            AppSettings.SaveSettings(Settings, false);
        }
        private void SaveAllFeedsToDisk()
        {
            foreach (RSSFeedsContainer rssGrouping in FeedsGroup)
            {
                rssGrouping.SerializeToBinaryFile(Settings.AppRSSSetings.FileName);
            }
        }
        #endregion

        #region RSS GET/SET methods

        private void RefreshRSS(bool activeFeeds)
        {

            if (!BusyRefreshingFromWeb)
            {
                chkbUnreadposts.CheckedChanged -= chkbUnreadposts_CheckedChanged;
                chkbUnreadposts.Checked = true;
                chkbUnreadposts.Text = Resources.UnReadRSSPostsReading;
                chkbUnreadposts.CheckedChanged += chkbUnreadposts_CheckedChanged;
                if (activeFeeds)
                {
                    RSSCount++;
                    SetDispalyFeeds(DisplayFeedsType.Active, null);
                }
                else
                    SetDispalyFeeds(DisplayFeedsType.NonActive, null);

                GetRSSItemsFromFeeds(DisplayFeeds, true, true);
            }
            else
            {
                chkbUnreadposts.Text = Resources.UnReadRSSPostsAlreadyReading;
            }
            tsslRefreshedCountRSS.Text = "Number of RSS refreshes: " + RSSCount;
        }
        private List<IRSSPost> GetRSSItemsFromFeeds(List<IRSSFeed> feedsToRefresh, bool unreadOnly, bool fromweb)
        {
             if (BusyRefreshingFromWeb)
             {
                 chkbUnreadposts.Text = Resources.UnReadRSSPostsAlreadyReading;
                 return null;
             }
             
            string oldDispalyName = DisplayFeedsName;
            chkbUnreadposts.Checked = unreadOnly;
            tpFeeds.Text = string.Format("Feeds Viewer (Selected Feeds: {0})", DisplayFeedsName);
            tstxtbSearchFeed.Text = "Search in feeds: " + DisplayFeedsName;
            LogInThisForm(string.Empty, true); //clear log
            OnLogOperation(this, new LogArgs(DateTime.Now + ": Start refreshing feed(s): " + DisplayFeedsName));
            string refreshMsg = string.Format("Start refreshing: {0} at {1}", DisplayFeedsName, DateTime.Now);
            OnWebRefresh(this, new LogArgs(refreshMsg));

           
            var mainTask = new Task<IEnumerable<IRSSPost>>(
                () =>
                {
                    var posts = new List<IRSSPost>();
                    int numOfTasks = feedsToRefresh.Count();
                    var tasks = new Task<IEnumerable<IRSSPost>>[numOfTasks];

                    int i = 0;
                    int finished = 0;
                    foreach (var feed in feedsToRefresh)
                    {
                        IRSSFeed feed1 = feed;
                        var tsk = new Task<IEnumerable<IRSSPost>>(
                            () =>
                            feed1.GetAllItemsFromWeb(false,  !Settings.AppRSSSetings.NotifyOnRSSErrors));

                        OnLogOperation(this,
                                       new LogArgs(string.Format("{0}: creating task {1} for feed {2}",
                                                                 DateTime.Now, i, feed1.RSSName)));
                        tasks[i] = tsk;
                        int i1 = i;

                        tasks[i].ContinueWith(delegate
                                                  {
                                                      var op =
                                                          string.Format(
                                                              "{0}: Task {1} finished for feed {2}. Time: {3} Seconds, Download size: {4} KB. {5} new posts",
                                                              DateTime.Now, i1, feed1.RSSName,
                                                              feed1.LastDownloadTime.TotalSeconds,
                                                              feed1.LastDownloadSizeKb,
                                                              feed1.LastNewPostsCount);
                                                      OnLogOperation(this, new LogArgs(string.Format(op)));
                                                      string msg = string.Format("{0} Finished feeds: {1}/{2}",
                                                                                 Resources.UnReadRSSPostsReading, ++finished, numOfTasks);
                                                      Util.Utils.UpdateControl(chkbUnreadposts, msg);
                                                      //if (tasks[i1].Status == TaskStatus.RanToCompletion)
                                                      //{
                                                      //    var results = tasks[i1].Result.ToList();
                                                      //    var unreadposts =
                                                      //        feed1.GetAllItemsFromCache(unreadOnly, true, true).
                                                      //            ToList();
                                                      //    posts.AddRange(unreadposts);
                                                      //    DisplayPosts = posts;
                                                      //    if (unreadposts.Count > 0)
                                                      //    {
                                                      //       // DisplayRSSItems(DisplayPosts, dgvRSSItems);
                                                      //      //  UpdateFeedsCountsAfterChange();
                                                      //    }
                                                      //}
                                                  });
                        tsk.Start();
                        i++;

                    }
                    Task.WaitAll(tasks);
                    OnWebEndRefresh(this, new LogArgs(refreshMsg));
                    
                    Util.Utils.UpdateControl(chkbUnreadposts, oldDispalyName);
                    posts.Clear();
                    //aggregate results
                    foreach (var task in tasks)
                    {
                        if (task.Status == TaskStatus.RanToCompletion)
                        {
                            var results = task.Result;
                            posts.AddRange(results);
                        }
                    }

                    DisplayPosts = posts;
                    DisplayRSSItems( dgvRSSItems, unreadOnly);
                    UpdateFeedsCountsAfterChange();
                    ulong totalFeedsKB = 0;
                    foreach (RSSFeedsContainer rssGrouping in FeedsGroup)
                        foreach (var feed in rssGrouping.GetFeeds())
                        {
                            totalFeedsKB += feed.TotalDownloadedKB;
                        }

                    TotalDownloadedKB = totalFeedsKB;

                    //save feeds to disk?
                    if (Settings.AppRSSSetings.SaveRSSFeedsOnEveryRefresh && fromweb && posts.Count > 0)
                        SaveAllFeedsToDisk();

                    // var postsarg = new RefreshArgs(posts);
                    //  OnWebRefresh(this, postsarg);
                    Util.Utils.UpdateControl(tpFeeds,string.Format("Feeds Viewer (Selected Feeds: {0})", oldDispalyName));
                    
                    return posts;
                   
                    
                });
            mainTask.Start();
            return null;

        }

        //private void RefreshCurrentSpecificFeedFromWeb(IRSSFeed currentFeed, bool unreadOnly)
        //{
        //    if (currentFeed != null)
        //    {
        //        LogInThisForm(string.Empty, true);
        //        OnLogOperation(this,
        //                       new LogArgs(DateTime.Now.ToString() + ": Start refreshing Specific feed (" +
        //                                   currentFeed.RSSName + ")"));
        //        chkbUnreadposts.Text = Resources.UnReadRSSPostsReading;
        //        var tsk = new Task<IEnumerable<IRSSPost>>(() => currentFeed.GetAllItems(unreadOnly, true, false));
        //        tsk.ContinueWith(delegate
        //        {
        //            string op = string.Format("{0}: Refreshed feed {1}. Time: {2} Seconds, Download size: {3}KB. {4} new posts ", DateTime.Now.ToString(), currentFeed.RSSName, currentFeed.LastDownloadTime.TotalSeconds, currentFeed.LastDownloadSizeKb, currentFeed.LastNewPostsCount);
        //            OnLogOperation(this, new LogArgs(op));


        //            var results = tsk.Result.ToList();
        //            var postsarg = new RefreshArgs(results);
        //            OnWebRefresh(this, postsarg);
        //            //save feeds to disk?
        //            if (Settings.AppRSSSetings.SaveRSSFeedsOnEveryRefresh && results.Count > 0)
        //            {
        //                SaveAllFeedsToDisk();
        //            }

        //            if (tsk.Status == TaskStatus.RanToCompletion)
        //            {
        //                DisplayPosts = results;
        //                DisplayRSSItems(DisplayPosts, dgvRSSItems);
        //            }
        //        });
        //        tsk.Start();
        //    }
        //}

        private void DisplayRSSItems(DataGridView RSSdataGridView,bool unreadonly, List< IRSSPost > alternativePost = null)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(() => DisplayRSSItems(RSSdataGridView, unreadonly)));
                return;
            }
            List<IRSSPost> postsToDisplay = alternativePost;
            if (postsToDisplay == null)
                postsToDisplay = DisplayPosts;
            postsToDisplay = postsToDisplay.Where(itm => !itm.Read || itm.Read != unreadonly).ToList();
            RSSdataGridView.DataSource = postsToDisplay;
            int countnewitems = (postsToDisplay).Count(itm => itm != null && itm.Read == false);

            chkbUnreadposts.Text = Resources.UnReadRSSPostsAlreadyTotalItems + dgvRSSItems.Rows.Count;
            tsslTotalDownloaded.Text = Utils.FormatKBytes(TotalDownloadedKB) + " Total Downloaded";
            
            if (countnewitems > 0)
                notifyIconStatus.ShowBalloonTip(1000, string.Format("{0} new items", countnewitems), string.Format("{0} new RSS Items", countnewitems), ToolTipIcon.None);

        }
       
        private void LoadFeedsPosts()
        {
            if (DisplayFeeds  != null)
            {
                chkbUnreadposts.CheckedChanged -= chkbUnreadposts_CheckedChanged;
                DisplayPosts = (from feed in DisplayFeeds
                                from post in feed.GetAllItemsFromCache(false)
                               select post).ToList();
             

                chkbUnreadposts.CheckedChanged += chkbUnreadposts_CheckedChanged;
            }
        }

        #endregion
     

        #region General Methods

        private void OpenSettingsDialog(bool openInRSSPanel)
        {
            tmrRefreshRSS.Enabled = false;
            var settingdlg = new SettingsDialog(FeedsGroup.FirstOrDefault(), Settings, openInRSSPanel);
            settingdlg.OnSettingsSaved += (s, a) =>
                                              {
                                                  LoadSettings();
                                                  UpdateFeedsCountsAfterChange();
                                              };
            settingdlg.OnCategoriesChanged += (s, e) => BuildFeedsGroups();
            settingdlg.OnFeedActiveStatusChanged += (s, a) => LoadFeedsToControl(true);
            settingdlg.OnNewFeedAdded += (s, a) =>
                                             {
                                                 DisplayRSSItems(dgvRSSItems, false, a.Feed.GetAllItemsFromCache(false, true).ToList());
                                                 OnFeedsChanges(s, a);
                                             };
            settingdlg.OnFeedRemoval += OnFeedsChanges;
            settingdlg.ShowDialog();
            tmrRefreshRSS.Enabled = true;
        }
        private void LogInThisForm(string s, bool clearAll = false)
        {

            if (Visible)
            {

                if (rtxbMsg.InvokeRequired)
                {
                    rtxbMsg.BeginInvoke(new MethodInvoker(() => LogInThisForm(s, clearAll)));
                }
                else
                {
                    if (clearAll) rtxbMsg.Text = "";
                    rtxbMsg.Text += s;
                    rtxbMsg.SelectionStart = rtxbMsg.Text.Length;
                }
            }
        }
        private void OnFeedsChanges(object sender, Core.FeedArgs feedArgs)
        {
            RSSFeedsContainer firstFeed = FeedsGroup.FirstOrDefault();

            LoadFeedsToControl(true);

            if (firstFeed != null)
            {
                if (feedArgs != null && feedArgs.IsNewFeed)
                    DisplayRSSItems(dgvRSSItems, false, feedArgs.Feed.GetAllItemsFromCache(false, true).ToList());
                else
                    DisplayRSSItems(dgvRSSItems, false, new List<IRSSPost>(0));

            }

        }
       private void WebRefreshStarted(object sender,LogArgs logArg )
       {
           BusyRefreshingFromWeb = true;
           RSStimeToRefreshSecondsCountdown = Settings.AppRSSSetings.IntervalMinutes * 60;
           tmrRefreshRSS.Enabled = false;
           chkbUnreadposts.Text = Resources.UnReadRSSPostsReading;

       }
       private void WebRefreshEnded(object sender, LogArgs logArg)
       {

           if (InvokeRequired)
           {
               BeginInvoke(new MethodInvoker(() => WebRefreshEnded(sender, logArg)));
               return;
           }
           tmrRefreshRSS.Enabled = true;
           BusyRefreshingFromWeb = false;
       }
  
        #endregion

        #region Post viewer related
        private void LoadItemInViewer(IRSSPost post)
        {
            if (chkbWhenToMarkAsRead.Checked)
            {
                post.Read = true;
                UpdateFeedsCountsAfterChange();
            }

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
            if (lastControl == tstxtbSearchFeed)
                tstxtbSearchFeed.Focus();
            else
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

        #region Treeviews related

        enum DisplayFeedsType
        {
            All, Active, NonActive, Privates, Disabled, NotInCategory, InSomeCategory
        }
        private void SetDispalyFeeds(DisplayFeedsType type, IRSSCategory category)
        {
            RSSFeedsContainer feeds = FeedsGroup.FirstOrDefault();
            if (feeds != null)
            {
                switch (type)
                {
                    case DisplayFeedsType.All:
                        DisplayFeeds = feeds.GetFeeds().Where(feed => !feed.Disabled).ToList();
                        DisplayFeedsName = "All Feeds";
                        break;
                    case DisplayFeedsType.Active:
                        DisplayFeeds = (from feed in feeds.GetFeeds()
                                        where (feed.Active && !feed.Disabled)
                                        select feed).ToList();
                        DisplayFeedsName = "All Active Feeds";
                        break;
                    case DisplayFeedsType.NonActive:
                        DisplayFeeds = (from feed in feeds.GetFeeds()
                                        where (!feed.Active && !feed.Disabled)
                                        select feed).ToList();
                        DisplayFeedsName = "All Non Active Feeds";
                        break;
                    case DisplayFeedsType.Privates:
                        DisplayFeeds = feeds.GetFeeds().Where(feed => !feed.Disabled && feed.IsPersonalFeed).ToList();
                        DisplayFeedsName = "All Private Feeds";
                        break;
                    case DisplayFeedsType.Disabled:
                        DisplayFeeds = feeds.GetFeeds().Where(feed => feed.Disabled).ToList();
                        DisplayFeedsName = "All Disabled Feeds";
                        break;
                    case DisplayFeedsType.NotInCategory:
                        DisplayFeeds = feeds.GetFeeds().Where(feed => !feed.Disabled && feed.BelongsToCategories.Count == 0).ToList();
                        DisplayFeedsName = "All Feeds not in any Category";
                        break;
                    case DisplayFeedsType.InSomeCategory:
                        if (category != null)
                        {
                            DisplayFeeds = (from feed in feeds.GetFeeds()
                                            where feed.BelongsToCategories.Contains(category)
                                            select feed).ToList();
                            DisplayFeedsName = "All Feeds in Category: " + category.CategoryName;
                        }
                        break;

                }
                tpFeeds.Text = string.Format("Feeds Viewer (Selected Feeds: {0})", DisplayFeedsName);
            }
        }

        private void LoadDisplayFeedsToBottomControl()
        {
            if (DisplayFeeds != null)
            {
                tvFeeds.BeginUpdate();
                tvFeeds.Nodes.Clear();
                var nodes = new List<TreeNode>();
                foreach (IRSSFeed feed in DisplayFeeds)
                {
                    var node = new TreeNode(feed.RSSName);
                    node.Tag = feed;
                    if (feed.Active)
                    {
                        node.ImageIndex = 0;
                        node.SelectedImageIndex = 0;

                    }
                    else
                    {
                        node.ImageIndex = 1;
                        node.SelectedImageIndex = 1;
                    }
                    nodes.Add(node);

                }
                tvFeeds.Nodes.AddRange(nodes.ToArray());
                UpdateFeedsCountsAfterChange();
                tvFeeds.EndUpdate();
            }
        }

        private void LoadAllFeedsToControl()
        {
            SetDispalyFeeds(DisplayFeedsType.All, null);
            LoadDisplayFeedsToBottomControl();
        }

        private void LoadDisabledFeedsToControl()
        {
            SetDispalyFeeds(DisplayFeedsType.Disabled, null);
            LoadDisplayFeedsToBottomControl();
        }
        private void LoadPrivatesFeedsToControl()
        {
            SetDispalyFeeds(DisplayFeedsType.Privates, null);
            LoadDisplayFeedsToBottomControl();
        }

        private void LoadNotInCategoryFeedsToControl()
        {
            SetDispalyFeeds(DisplayFeedsType.NotInCategory, null);
            LoadDisplayFeedsToBottomControl();
        }

        private void LoadFeedsToControl(bool activeFeeds)
        {
            SetDispalyFeeds(activeFeeds ? DisplayFeedsType.Active : DisplayFeedsType.NonActive, null);
            LoadDisplayFeedsToBottomControl();
        }

        private void LoadFeedsToControl(IRSSCategory category)
        {
            SetDispalyFeeds(DisplayFeedsType.InSomeCategory, category);
            LoadDisplayFeedsToBottomControl();


        }
        private void BuildFeedsGroups()
        {
            tvFeedsGroup.BeginUpdate();
            tvFeedsGroup.Nodes.Clear();
            tvFeedsGroup.Nodes.Add("AllFeeds", "All Feeds (Excluding Disabled)", 0, 0);
            tvFeedsGroup.Nodes.Add("ActiveFeeds", "Active Feeds", 0, 0);
            tvFeedsGroup.Nodes.Add("NonActiveFeeds", "Non Active Feeds", 1, 1);
            tvFeedsGroup.Nodes.Add("DisabledFeeds", "Disabled Feeds", 0, 0);
            tvFeedsGroup.Nodes.Add("PrivatesFeeds", "Privates Feeds", 0, 0);
            tvFeedsGroup.Nodes.Add("NotInCategory", "Other Feeds (not in any category)", 0, 0);
            List<TreeNode> categoriesNodes = new List<TreeNode>(FeedsGroup.FirstOrDefault().CategoriesCount);
            foreach (IRSSCategory cat in FeedsGroup.FirstOrDefault().GetCategories())
            {
                var newnode = new TreeNode("Category: " + cat.CategoryName, 0, 0);
                newnode.Tag = cat;
                categoriesNodes.Add(newnode);
            }
            tvFeedsGroup.Nodes.AddRange(categoriesNodes.ToArray());
            tvFeedsGroup.SelectedNode = tvFeedsGroup.Nodes[0];
            tvFeedsGroup.EndUpdate();
        }

        private void tvFeedsGroup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lastControl = null;
            if ((e.Node != null) && (e.Action == TreeViewAction.ByMouse || e.Action == TreeViewAction.ByKeyboard))
            {
                LastSelectedNode = e.Node;
                lblSelectedGroup.Text = "Selected: " + e.Node.Text;
                LoadFeeds(e.Node.Name, e.Node.Tag as IRSSCategory);
                //OnFeedPostsChanged(this, null);

            }
            LoadFeedsPosts();
            tvFeedsGroup.SelectedNode = null;
        }

        private void LoadFeeds(string nodename, IRSSCategory category)
        {
            switch (nodename)
            {
                case "": //this is category
                    LoadFeedsToControl(category);
                    tstxtbSearchFeed.Text = "Search in category: " + category.CategoryName;
                    break;
                case "AllFeeds":
                    LoadAllFeedsToControl();
                    tstxtbSearchFeed.Text = "Search in All Feeds";
                    break;
                case "ActiveFeeds":
                    LoadFeedsToControl(true);
                    tstxtbSearchFeed.Text = "Search in Active Feeds";
                    break;
                case "NonActiveFeeds":
                    LoadFeedsToControl(false);
                    tstxtbSearchFeed.Text = "Search in Non Active Feeds";
                    break;
                case "DisabledFeeds":
                    LoadDisabledFeedsToControl();
                    tstxtbSearchFeed.Text = "Search in Disabled Feeds";
                    break;
                case "PrivatesFeeds":
                    LoadPrivatesFeedsToControl();
                    tstxtbSearchFeed.Text = "Search in Private Feeds";
                    break;
                case "NotInCategory":
                    LoadNotInCategoryFeedsToControl();
                    tstxtbSearchFeed.Text = "Search in Other Feeds";
                    break;

            }
        }
        private void tvFeeds_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lastControl = null;
            IRSSFeed currentFeed = (IRSSFeed)e.Node.Tag;
            DisplayFeeds = new List<IRSSFeed>(1) { currentFeed };
            DisplayFeedsName = currentFeed.RSSName;
           bool unreadonly = currentFeed.UnreadItemsCount > 0;
            tpFeeds.Text = string.Format("Feeds Viewer (Selected Feed:{0})", currentFeed.RSSName);
            tsbtnRefreshCurrentFeeds.Enabled = true;
            chkbUnreadposts.Enabled = true;
            LoadFeedsPosts();
            tstxtbSearchFeed.Text = "Search in feed : " + currentFeed.RSSName;
            DisplayRSSItems(dgvRSSItems, unreadonly);
            chkbUnreadposts.Checked = unreadonly;
      
          

        }

        private void UpdateFeedsCountsAfterChange()
        {

            if (tvFeeds.InvokeRequired)
                tvFeeds.BeginInvoke(new MethodInvoker(UpdateFeedsCountsAfterChange));
            else
            {
                tvFeeds.BeginUpdate();
                foreach (TreeNode node in tvFeeds.Nodes)
                {
                    IRSSFeed feed = node.Tag as IRSSFeed;

                    if (feed != null)
                    {
                        TreeNode node1 = node;

                        Font tempfont;
                        if (node1.NodeFont == null)
                            tempfont = new Font(tvFeeds.Font, FontStyle.Bold | tvFeeds.Font.Style);
                        else
                            tempfont = new Font(node1.NodeFont, FontStyle.Bold | node1.NodeFont.Style);

                        Font newfont = feed.UnreadItemsCount > 0 ? new Font(tempfont, FontStyle.Bold) : new Font(tempfont, FontStyle.Regular);
                        string text = feed.RSSName;
                        if (feed.UnreadItemsCount > 0)
                            text += string.Format(" ({0})", feed.UnreadItemsCount);
                        node1.NodeFont = newfont;
                        node1.Text = text;
                    }

                }
                tvFeeds.EndUpdate();
            }
        }

        private void ShowRefreshIconStatus(bool active, bool starRefresh)
        {
            if (tvFeeds.InvokeRequired)
                tvFeeds.BeginInvoke(new MethodInvoker(UpdateFeedsCountsAfterChange));
            else
            {
                var collection = from TreeNode nodes in tvFeeds.Nodes
                                 where ((nodes.Tag as IRSSFeed).Active == active)
                                 select nodes;


                foreach (TreeNode node in collection)
                {
                    if (starRefresh)
                        node.ImageIndex = 3;
                    else
                    {
                        IRSSFeed feed = node.Tag as IRSSFeed;
                        if (feed.Active)
                        {
                            node.ImageIndex = 0;
                            node.SelectedImageIndex = 0;

                        }
                        else
                        {
                            node.ImageIndex = 1;
                            node.SelectedImageIndex = 1;
                        }
                    }
                }
            }
        }


        #endregion


      
    }
}

