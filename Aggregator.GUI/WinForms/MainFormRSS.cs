using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
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

namespace Aggregator.GUI.WinForms
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
        public event EventHandler<RSSArgs> OnPostChanged = delegate { };
        public event EventHandler<LogArgs> OnWebRefresh = delegate { };
        public event EventHandler<LogArgs> OnWebEndRefresh = delegate { };

        //public event EventHandler<RefreshArgs> OnPostReadStatusChange = delegate { };

        #endregion

        #region Data Members

        private bool UserActive { get; set; }
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
            var cancelButton = new Button();
            cancelButton.Click += ((s, e) => Close());
            CancelButton = cancelButton;

            this.TransparencyKey = transparentColor;
            BlurBehindWindowEnabled = false;
            blurRegion = null;
            errorLIst = new ErrorsForm();
            RSSOperationLog = new StringBuilder();
            logLIst = new LogsForm();
            DisplayPosts = new List<IRSSPost>(0);
            DisplayFeeds = new List<IRSSFeed>(0);
            DisplayFeedsName = string.Empty;
            LoadSettings();

            #region Events Subscribings

            #region ToolStrip MenuItems Subscribings

       
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

            tsbtnSearch.Click += (sender, e) => new SearchForm(FeedsGroup, Settings).Show();
            tsbtnSettings.Click += (sender, args) => OpenSettingsDialog(true);
            tsbtnNewFeed.Click += (sender, args) => OpenSettingsDialog(true);
            tsbtnExportFeed.Click += (sender, e) => new FeedExports(FeedsGroup, Settings).ShowDialog();
            tsbtnRefreshNonActive.Click += (sender, e) => RefreshRSS(false);
            tsbtnRefreshActive.Click += (sender, e) => RefreshRSS(true);

            tsbtnFacebookNewsFeedPage.Click += (sender, e) =>
            {
                try
                {
                    Process.Start("http://www.facebook.com/pages/News-Feed-Reader-Page/217847334952654");
                }
                catch (System.Exception ex)
                {
                    MessageShow.ShowException(this, ex);
                }
            };

            tsbtnFacebook.Click += (sender, e) =>
            {
                try
                {
                    Process.Start("http://www.facebook.com/LBDesktopAggregator");
                }
                catch (System.Exception ex)
                {
                    MessageShow.ShowException(this, ex);
                }
            };

            #endregion

            #region General Subscribings

            OnCurrentFeedsChanged += DisplayFeedsChanged;
            OnPostChanged += PostChanged;
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
            notifyIconStatus.MouseClick += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {

                    Visible = !Visible;

                    if (Visible)
                        Activate();
                }
            };

            notifyIconStatus.BalloonTipClicked += (sender, args) =>
            {
                Visible = true;
                Activate();
            };

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
            Text = string.Format("RSS Desktop Aggregator ({0})",
                                 Assembly.GetExecutingAssembly().GetName().Version.ToString());
            //	this.TransparencyKey = BackColor;
            if (Settings.AppOutlookSettings.LaunchOutlookReaderOnStartup)
            {
                new MainFormOutlook(Settings).Show();
            }
            spltcMain.SplitterDistance = Settings.AppGUISettings.MainRSSFormLeftPanelWidth;
            
            if (Settings.AppGUISettings.MainFormRightPanelWidth>0)
                spltcFeeds.SplitterDistance = Settings.AppGUISettings.MainFormRightPanelWidth;
            if (Settings.AppGUISettings.MainFormLeftTopPanelWidth > 0)
                spltcLeft.SplitterDistance = Settings.AppGUISettings.MainFormLeftTopPanelWidth;
            notifyIconStatus.ShowBalloonTip(1000, "RSS Desktop Aggregator", "When there are new items a popup will be shown here which can be clicked on to open the main window. Clicking on the tray icon will show/hide the main window", ToolTipIcon.None);

            BuildFeedsGroups();
          //  tvFeedsGroup.SelectedNode = tvFeedsGroup.Nodes[0];
            SetDispalyFeeds(DisplayFeedsType.All, null);
            LoadDisplayFeedsToBottomControl();
            UpdateFeedsCountsAfterChange();
            tstxtbSearchFeed.Text = "Search in All Feeds";
            tvFeedsGroup.Focus();

        }

        private void MainFormRSS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancelExit && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Visible = false;
                notifyIconStatus.ShowBalloonTip(1000, "RSS Desktop Aggregator",
                                                "The program will keep running in the background. To close it right click this icon and choose Close or select exit from the File menu",
                                                ToolTipIcon.Info);
            }
            else
            {
                notifyIconStatus.Visible = false;
                notifyIconStatus.Dispose();
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
                OnPostChanged(this,new RSSArgs(post));
               
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
                    if (!Settings.AppGUISettings.RemovePostFromListAfterRead || !chkbWhenToMarkAsRead.Checked)
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
                    if (!Settings.AppGUISettings.RemovePostFromListAfterRead || !chkbWhenToMarkAsRead.Checked)
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


        private void tsbtnFeedStatus_Click(object sender, EventArgs e)
        {
            if (DisplayFeeds != null && DisplayFeeds.Count == 1)
            {
                IRSSFeed feed = DisplayFeeds.FirstOrDefault();
                if (feed == null) return;
                if (feed.Disabled)
                {
                    feed.Disabled = false;
                    string msg = string.Format("Feed {0}\nhas been enabled.", feed.RSSName);
                    MessageShow.ShowMessage(this, msg, "Feed restored");

                }
                else
                {
                    string msg =
                        string.Format("Feed {0} is enabled. Do you want to disable it?",
                                      feed.RSSName);
                    var result = MessageShow.ShowMessage(this, msg, "Disable Confirmation",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) feed.Disabled = true;
                }
                tsbtnFeedStatus.Image = (feed.Disabled) ? Resources.buttonOFF : Resources.buttonOn;

            }

            else
            {
                MessageShow.ShowMessage(this, "No Feed was selected.", "Unable To Proceed");
            }
        }

        private void tsbtnRSSStopStart_Click(object sender, EventArgs e)
        {
            tmrRefreshRSS.Enabled = !tmrRefreshRSS.Enabled;
            tsbtnRSSStopStart.Image = tmrRefreshRSS.Enabled ? Resources.Pauseicon : Resources.Playicon;
            tsbtnRSSStopStart.Text  = tmrRefreshRSS.Enabled ? "Pause" : "Resume";
        }

        private void tsbtnFeedInformation_Click(object sender, EventArgs e)
        {
            if (DisplayFeeds.Count == 1)
            {
                var posts =
                    new FeedInformationDialog(FeedsGroup.FirstOrDefault(), DisplayFeeds.First(), Settings,
                                              !Settings.AppRSSSetings.NotifyOnRSSErrors);
                posts.OnFeedActiveStatusChanged += (s, a) =>
                                                       {
                                                           TreeNode selectedNode = tvFeedsGroup.SelectedNode;
                                                           if (selectedNode !=null)
                                                            LoadFeeds(selectedNode.Name, selectedNode.Tag as IRSSCategory);
                                                           
                                                       };
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
            if (olvPosts.SelectedObject != null)
            {
                IRSSPost post = olvPosts.SelectedObject as IRSSPost;
                if (post != null)
                {
                    if (!post.FollowUp)
                    {
                        post.FollowUp = true;
                        string msg = string.Format("post {0} has been marked for later read.", post.Title);
                        MessageShow.ShowMessage(this, msg, "Post marked for later read");

                    }
                    else
                    {
                        string msg =
                            string.Format("post {0} is already marked for later read.\n Do you want to unmark it?",
                                          post.Title);
                        var result = MessageShow.ShowMessage(this, msg, "Post is already marked for later read",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) post.FollowUp = false;
                    }
                    OnPostChanged(this, new RSSArgs(post));
                }

            }
            //dgvRSSItems.Refresh();
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

        //private void UpdateRSSColumns(DataGridView RSSdataGridView)
        //{
        //    RSSdataGridView.ReadOnly = false;

        //    foreach (var columnname in Settings.AppGUISettings.RSSColumnsVisibleStatus)
        //    {
        //        if (RSSdataGridView.Columns.Contains(columnname.Key))
        //        {
        //            RSSdataGridView.Columns[columnname.Key].Visible = columnname.Value.Visible;
        //            RSSdataGridView.Columns[columnname.Key].HeaderText = columnname.Value.HeaderText;
        //        }

        //    }

        //    string title = Reflection.GetPropertyName(((IRSSPost itm) => itm.Title));
        //    string feedName = Reflection.GetPropertyName(((IRSSPost itm) => itm.FeedName));
        //    string read = Reflection.GetPropertyName(((IRSSPost itm) => itm.Read));
        //    string IgnorePostContentIncomparison =
        //        Reflection.GetPropertyName(((IRSSPost itm) => itm.IgnorePostContentIncomparison));
        //    RSSdataGridView.Columns[IgnorePostContentIncomparison].Visible = false;

        //    RSSdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; //Row height autosize
        //    RSSdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        //    RSSdataGridView.Columns[title].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    RSSdataGridView.Columns[title].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        //    RSSdataGridView.Columns[feedName].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
        //    if (RSSdataGridView.Columns.Contains(read))
        //    {
        //        RSSdataGridView.Columns[read].ReadOnly = false;

        //    }
        //}

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
            if (olvPosts.SelectedObject != null)
            {
                IRSSPost currentitem = olvPosts.SelectedObject as IRSSPost;
                if (currentitem != null)
                    LoadItemInViewer(currentitem);
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
                    OnPostChanged(this, new RSSArgs(currentitem));
                    UpdateFeedsCountsAfterChange();

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
                    OnPostChanged(this, new RSSArgs(currentitem));
                    UpdateFeedsCountsAfterChange();
                }
            }
        }

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
                    DisplayRSSItems(chkbUnreadposts.Checked);
                else
                {
                    List<IRSSPost> allMatchedPosts;
                    if (DisplayFeeds == null)
                        allMatchedPosts = SearchForm.SearchInPosts(DisplayPosts, tstxtbSearchFeed.Text).ToList();
                    else
                        allMatchedPosts = SearchForm.SearchInFeeds(DisplayFeeds, tstxtbSearchFeed.Text).ToList();

                    DisplayRSSItems(chkbUnreadposts.Checked, allMatchedPosts);
                    tsslblRecordsInSearch.Text = "Number of records: " + allMatchedPosts.Count;

                }

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
        private void btnMarkAllRSSAsRead_Click(object sender, EventArgs e)
        {
            tmrRefreshRSS.Enabled = false;
            foreach (IRSSPost post in olvPosts.Objects)
            {
                post.Read = true;
            }
            UpdateFeedsCountsAfterChange();
            olvPosts.RefreshObjects(DisplayPosts);
            tmrRefreshRSS.Enabled = true;

            if (Settings.AppGUISettings.RemovePostFromListAfterRead)
                olvPosts.ClearObjects();
            else
                olvPosts.RefreshObjects(olvPosts.Objects as List<IRSSPost >);
        }

        private void chkbUnreadposts_CheckedChanged(object sender, EventArgs e)
        {
            if (DisplayPosts == null)
                LoadFeedsPosts();
            DisplayRSSItems(chkbUnreadposts.Checked);

        }
        private void chkbGroupResults_Click(object sender, EventArgs e)
        {
            olvPosts.ShowGroups = chkbGroupResults.Checked;
            
            olvPosts.ShowItemCountOnGroups = true;

        }

        //#region Data Grid View Methods
        ////private void dgvRSSItems_SelectionChanged(object sender, EventArgs e)
        ////{
        ////    if (Visible && dgvRSSItems.CurrentRow != null)
        ////    {
        ////        IRSSPost currentitem = (IRSSPost)dgvRSSItems.CurrentRow.DataBoundItem;
        ////        LoadItemInViewer(currentitem);

        ////    }
        ////}
        //private void dgvRSSItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
        //private void dgvRSSItems_RowLeave(object sender, DataGridViewCellEventArgs e)
        //{

        //}
        //private void dgvRSSItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    //UpdateFeedsCountsAfterChange();
        //}
        //private void dgvRSSItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        //{
        //}
        //private void dgvRSSItems_CellValidated(object sender, DataGridViewCellEventArgs e)
        //{
        //}
        //private void dgvRSSItems_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        //{
        //    //dgvRSSItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
        //}
        //private void dgvRSSItems_KeyPress(object sender, KeyPressEventArgs e)
        //{


        //}
        //#endregion

        private void tmrUser_Tick(object sender, EventArgs e)
        {
            TimeSpan time = TimeSpan.FromSeconds(UserIdle.GetLastInputTime());
            UserActive = time.TotalMinutes <= 10;
            tsslUseActive.Text = (time.TotalMinutes <= 10) ? "User was active in the last 10 minutes." : "User Idle: " + time.ToString();
            
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

            chkbWhenToMarkAsRead.Checked = Settings.AppGUISettings.MarkRSSPostasReadOnRead;
            ShowInTaskbar = Settings.AppGUISettings.ShowTaskbarIcon;

            RSStimeToRefreshSecondsCountdown = Settings.AppRSSSetings.IntervalMinutes * 60;

            tmrRefreshRSS.Enabled = Settings.AppRSSSetings.EnabledRSSReader;
            if (RSStimeToRefreshSecondsCountdown < 120)
                RSStimeToRefreshSecondsCountdown = 120;

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

        private void SaveAppSettings()
        {
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


            Settings.AppGUISettings.RSSColumnsVisibleStatus[date].Visible = olvPosts.GetColumn("Published Date") != null && olvPosts.GetColumn("Published Date").IsVisible ;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[title].Visible = olvPosts.GetColumn("Title") != null && olvPosts.GetColumn("Title").IsVisible;

            Settings.AppGUISettings.RSSColumnsVisibleStatus[read].Visible = olvPosts.GetColumn("Read") != null && olvPosts.GetColumn("Read").IsVisible;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[feedname].Visible = olvPosts.GetColumn("Feed Name") != null && olvPosts.GetColumn("Feed Name").IsVisible;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[addeddate].Visible = olvPosts.GetColumn("Added Date") != null && olvPosts.GetColumn("Added Date").IsVisible;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[readlater].Visible = olvPosts.GetColumn("Later Read?") != null && olvPosts.GetColumn("Later Read?").IsVisible;


            Settings.AppGUISettings.MainRSSFormLeftPanelWidth = spltcMain.SplitterDistance;
            Settings.AppGUISettings.MainFormRightPanelWidth = spltcFeeds.SplitterDistance;
            Settings.AppGUISettings.MainFormLeftTopPanelWidth = spltcLeft.SplitterDistance;

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
                            feed1.GetAllItemsFromWeb(false, !Settings.AppRSSSetings.NotifyOnRSSErrors));

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
                                                       Resources.UnReadRSSPostsReading,
                                                       ++finished, numOfTasks);
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
                    DisplayRSSItems(unreadOnly);
                    UpdateFeedsCountsAfterChange(true);
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
                    Util.Utils.UpdateControl(tpFeeds,
                                             string.Format("Feeds Viewer (Selected Feeds: {0})", oldDispalyName));

                    return posts;


                });
            mainTask.Start();
            return null;

        }

        private void DisplayRSSItems(bool unreadonly, List<IRSSPost> alternativePost = null)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(() => DisplayRSSItems(unreadonly)));
                return;
            }
            List<IRSSPost> postsToDisplay = alternativePost;
            if (postsToDisplay == null)
                postsToDisplay = DisplayPosts;
            postsToDisplay = postsToDisplay.Where(itm => !itm.Read || itm.Read != unreadonly).ToList();
            postsToDisplay = postsToDisplay.OrderByDescending(itm => itm.AddedDate).ToList() ;
            olvPosts.SetObjects(postsToDisplay);
           // olvPosts.ShowGroups = chkbGroupResults.Checked;
          
            if (postsToDisplay.Count > 0)
                olvPosts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            int countnewitems = (postsToDisplay).Count(itm => itm != null && itm.Read == false);

            chkbUnreadposts.Text = Resources.UnReadRSSPostsAlreadyTotalItems + postsToDisplay.Count;
            tsslTotalDownloaded.Text = Utils.FormatKBytes(TotalDownloadedKB) + " Total Downloaded";

            if (countnewitems > 0 && UserActive )
                notifyIconStatus.ShowBalloonTip(1000, "RSS Desktop Aggregator",
                                                string.Format("{0} new RSS Items", countnewitems), ToolTipIcon.None);

        }

        private void LoadFeedsPosts()
        {
            if (DisplayFeeds != null)
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
        private void DisplayFeedsChanged(object sender,LogArgs msg)
        {
            tpFeeds.Text = string.Format("Feeds Viewer (Selected Feed:{0})", DisplayFeedsName);
            tsbtnRefreshCurrentFeeds.Enabled = true;
            chkbUnreadposts.Enabled = true;
            LoadFeedsPosts();
            tstxtbSearchFeed.Text = "Search in feed : " + DisplayFeedsName;
            if (DisplayFeeds.Count != 1)
            {
                tsbtnFeedInformation.Enabled = false;
                tsbtnFeedStatus.Enabled = false;
               tsbtnFeedStatus.Image = Resources.buttonOn;
                tsbtnFeedStatus.Enabled = false;
            }
            else
            {
                tsbtnFeedInformation.Enabled = true;
                tsbtnFeedStatus.Enabled = true;
               
                tsbtnFeedStatus.Image = DisplayFeeds.FirstOrDefault().Disabled ? Resources.buttonOFF : Resources.buttonOn;
                tsbtnFeedStatus.Enabled = true;
            }
        }
        private void PostChanged(object sender, RSSArgs e)
        {
            olvPosts.RefreshObject(e.Post);
            UpdateFeedsCountsAfterChange();
        }

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
            settingdlg.OnFeedActiveStatusChanged += (s, a) =>
                                                        {
                                                            TreeNode selectedNode = tvFeedsGroup.SelectedNode;
                                                            if (selectedNode != null)
                                                                LoadFeeds(selectedNode.Name, selectedNode.Tag as IRSSCategory);
                                                        };
            settingdlg.OnNewFeedAdded += (s, a) =>
            {
                DisplayRSSItems(false,
                                a.Feed.GetAllItemsFromCache(false, true).ToList());
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

            TreeNode selectedNode = tvFeedsGroup.SelectedNode;
            if (selectedNode != null)
                LoadFeeds(selectedNode.Name, selectedNode.Tag as IRSSCategory);

            if (firstFeed != null)
            {
                if (feedArgs != null && feedArgs.IsNewFeed)
                    DisplayRSSItems(false, feedArgs.Feed.GetAllItemsFromCache(false, true).ToList());
                else
                    DisplayRSSItems(false, new List<IRSSPost>(0));

            }

        }

        private void WebRefreshStarted(object sender, LogArgs logArg)
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
                OnPostChanged(this, new RSSArgs(post));
                UpdateFeedsCountsAfterChange();
            if (Settings.AppGUISettings.RemovePostFromListAfterRead)
            {
                olvPosts.RemoveObject(post);
            }
        }

        tsbtnCheckAsRead.Tag = post;
            tsbntHideShowPost.Image = (post.IgnoreThisPost) ? Properties.Resources.buttonOFF : Properties.Resources.buttonOn;
            tsbntHideShowPost.Text = (post.IgnoreThisPost) ? "Restore post visibility " : "Hide post On Main Screen";
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

        }

        private void webbPostViewer_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webbPostViewer.Navigating += webbPostViewer_Navigating;
            if (lastControl == tstxtbSearchFeed)
                tstxtbSearchFeed.Focus();
            else
                olvPosts.Focus();

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

        private enum DisplayFeedsType
        {
            All,
            Active,
            NonActive,
            Privates,
            Disabled,
            NotInCategory,
            InSomeCategory
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
                tcFeeds.SelectedIndex = 0;
                LastSelectedNode = e.Node;
                lblSelectedGroup.Text = "Selected: " + e.Node.Text;
                LoadFeeds(e.Node.Name, e.Node.Tag as IRSSCategory);
                LoadFeedsPosts();
                OnCurrentFeedsChanged(this, new LogArgs("Current feeds: " + DisplayFeedsName));
                DisplayRSSItems(chkbUnreadposts.Checked);
            }

            tvFeedsGroup.SelectedNode = null;
        }
        private void LoadFeeds(string nodename, IRSSCategory category)
        {

            switch (nodename)
            {
                case "": //this is category
                    SetDispalyFeeds(DisplayFeedsType.InSomeCategory, category);
                    
                    tstxtbSearchFeed.Text = "Search in category: " + category.CategoryName;
                    break;
                case "AllFeeds":
                    SetDispalyFeeds(DisplayFeedsType.All, null);
                    tstxtbSearchFeed.Text = "Search in All Feeds";
                    break;
                case "ActiveFeeds":
                    SetDispalyFeeds(DisplayFeedsType.Active, null);
                    tstxtbSearchFeed.Text = "Search in Active Feeds";
                    break;
                case "NonActiveFeeds":
                    SetDispalyFeeds(DisplayFeedsType.NonActive, null);
                    tstxtbSearchFeed.Text = "Search in Non Active Feeds";
                    break;
                case "DisabledFeeds":
                    SetDispalyFeeds(DisplayFeedsType.Disabled, null);
                    tstxtbSearchFeed.Text = "Search in Disabled Feeds";
                    break;
                case "PrivatesFeeds":
                    SetDispalyFeeds(DisplayFeedsType.Privates, null);
                    tstxtbSearchFeed.Text = "Search in Private Feeds";
                    break;
                case "NotInCategory":
                    SetDispalyFeeds(DisplayFeedsType.NotInCategory, null);
                    tstxtbSearchFeed.Text = "Search in Other Feeds";
                    break;

            }
            LoadDisplayFeedsToBottomControl();
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
                        DisplayFeeds =
                            feeds.GetFeeds().Where(feed => !feed.Disabled && feed.BelongsToCategories.Count == 0).ToList
                                ();
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
                tvFeeds .TreeViewNodeSorter = new FeedNodeSorter();
                tvFeeds.Nodes.AddRange(nodes.ToArray());
                UpdateFeedsCountsAfterChange();
                tvFeeds.EndUpdate();
            }
        }

     

      

      

        private void tvFeeds_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tcFeeds.SelectedIndex = 0;
            lastControl = null;
            IRSSFeed currentFeed = (IRSSFeed)e.Node.Tag;
            DisplayFeeds = new List<IRSSFeed>(1) { currentFeed };
            DisplayFeedsName = currentFeed.RSSName;
            bool unreadonly = currentFeed.UnreadItemsCount > 0;
            OnCurrentFeedsChanged(this, new LogArgs("Current feeds: " + DisplayFeedsName));

            DisplayRSSItems(unreadonly);
            chkbUnreadposts.Checked = unreadonly;
        }

        private void UpdateFeedsCountsAfterChange(bool doReorder = false)
        {

            if (tvFeeds.InvokeRequired)
                tvFeeds.BeginInvoke(new MethodInvoker(() => UpdateFeedsCountsAfterChange(doReorder)));
            else
            {
                tvFeeds.BeginUpdate();
                if (doReorder)
                 tvFeeds.TreeViewNodeSorter = new FeedNodeSorter();
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

                        Font newfont = feed.UnreadItemsCount > 0
                                           ? new Font(tempfont, FontStyle.Bold)
                                           : new Font(tempfont, FontStyle.Regular);
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
                tvFeeds.BeginInvoke(new MethodInvoker(()=> UpdateFeedsCountsAfterChange(false)));
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







