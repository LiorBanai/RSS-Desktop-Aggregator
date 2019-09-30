using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Aggregator.Core;
using Aggregator.Data;
using Aggregator.GUI.Properties;
using Aggregator.Util;
using Outlook.GUI.WinForms;
using Microsoft.Office.Interop.Outlook;
using System.Drawing;
using Action = System.Action;
using Application = System.Windows.Forms.Application;
using Exception = System.Exception;

namespace Aggregator.GUI.WinForms
{
    public partial class MainForm : Form
    {
        private int sourgeForgeCountdown = 60 * 30;
        #region EventArgs Classes

        public class LogArgs : EventArgs
        {
            public string Message { get; protected set; }
            public LogArgs(string message)
            {
                Message = message;
            }

        }

        #endregion

        #region Events Declerations

        public delegate void EventHandler<in T>(object sender, T e) where T : EventArgs;
        public event EventHandler<LogArgs> OnLogOperation = delegate { };

        #endregion

        #region Data Members

        private bool sourceForgeView = false;
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

        private ulong TotalDownloadedKB { get; set; }
        private OutlookConnection OutlookConnection { get; set; }
        public static List<RSSFeedsContainer> FeedsGroup { get; private set; }
        private AppSettings Settings { get; set; }
        private ErrorsForm errorLIst;
        private LogsForm logLIst;
        private int RSSCount { get; set; }
        private int OutlookCount { get; set; }
        private bool NewItems { get; set; }
        private int RSStimeToRefreshSecondsCountdown;
        private int OutlookTimeRefreshSeconds;
        private int OutlooktimeToRefreshSecondsCountdown;
        private bool EnableOutlook = false;
        private bool EnableRSS = false;

        #endregion

        #region Ctor related

        public MainForm()
        {
            InitializeComponent();

            this.TransparencyKey = transparentColor;
            BlurBehindWindowEnabled = false;
            blurRegion = null;
            errorLIst = new ErrorsForm();
            logLIst = new LogsForm();
            dgvUnreadMails.DataSource = new List<MyOutlookItem>(0);
            dgvRSSItems.DataSource = new List<IRSSPost>(0);

            // Settings = settings;
            LoadSettings();

            #region Events Subscribings

            #region MenuItems Subscribings

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

            tsmiRestart.Click += (sender, args) =>
            {
                     Application.Exit();
                                         Application.Restart();
                                     };
            tsmiVersion.Click += (sender, args) => new VersionHistoryDialog().ShowDialog();
            tsmiAbout.Click += (sender, args) => new AboutBoxDesktopAggregator().ShowDialog();
            tsmiStatistics.Click += (sender, e) => new NetworkStatistics().Show();
            tsmiErrorsList.Click += (sender, args) => errorLIst.ShowDialog();
            tsmiViewLogOperations.Click += (sender, args) => logLIst.Show();
            tsmiRefresh.Click += (sender, args) =>
                      {
                          RSStimeToRefreshSecondsCountdown = 0;
                          OutlooktimeToRefreshSecondsCountdown = 0;
                      };
            tsmiClose.Click += (sender, args) => Close();
            tsmiExit.Click += (sender, args) => Close();
            tsmiApplicationSettings.Click += (sender, args) =>
            {
                tmrRefreshRSS.Enabled = false;
                var settingdlg = new SettingsDialog(FeedsGroup.FirstOrDefault(), Settings);
                settingdlg.OnSettingsSaved += (s, a) => LoadSettings();
                settingdlg.OnNewFeedAdded += (s, a) =>
                {
                    DisplayRSSItems(a.Feed.GetAllItemsFromCache(false, true).ToList(), dgvRSSItems);
                    OnFeedsChanges(s, a);
                    SetAllGUIParameters();
                };
                settingdlg.OnFeedRemoval += OnFeedsChanges;
                settingdlg.ShowDialog();
                tmrRefreshRSS.Enabled = true;
            };
            #endregion

            btnFeedInfo.Click += (sender, e) =>
                                     {
                                         IRSSFeed currentFeed = cbFeeds.SelectedItem as IRSSFeed;

                                         if (currentFeed != null)
                                         {

                                             var posts =
                                                 new FeedInformationDialog(FeedsGroup.FirstOrDefault() ,currentFeed, Settings,
                                                                           !Settings.AppRSSSetings.NotifyOnRSSErrors).
                                                     ShowDialog();
                                         }
                                         else
                                         {
                                             MessageShow.ShowMessage(this,
                                                                     "Feed information is available only when a single feed is selected.",
                                                                     "Feed Information");
                                         }
                                     };
            btnRefreshNonActiveRSS.Click += (sender, e) =>
                                                {
                                                    if (!bwRefreshRSS.IsBusy && EnableRSS)
                                                    {
                                                        RSSCount++;
                                                        tsmiApplicationSettings.Enabled = false;
                                                        chkbAllRSSItem.Text =
                                                            Resources.UnReadRSSPostsReading;
                                                        bwRefreshRSS.RunWorkerAsync(false);
                                                    }
                                                    else
                                                    {
                                                        chkbAllRSSItem.Text =
                                                            Resources.UnReadRSSPostsAlreadyReading;
                                                    }
                                                    tsslRefreshedCountRSS.Text = "Number of RSS refreshes: " + RSSCount;
                                                };
            btnRefreshActiveRSS.Click += (sender, e) =>
                                    {
                                        if (!bwRefreshRSS.IsBusy && EnableRSS)
                                        {
                                            RSStimeToRefreshSecondsCountdown = 0;

                                        }
                                        else
                                        {
                                            chkbAllRSSItem.Text =
                                                       Resources.UnReadRSSPostsAlreadyReading;
                                        }
                                    };
            btnRefreshMail.Click += (sender, e) => OutlooktimeToRefreshSecondsCountdown = 0;
            btnFaceBook.Click += (sender, e) =>
                                     {
                                         try
                                         { Process.Start("http://www.facebook.com/LBDesktopAggregator"); }
                                         catch (System.Exception ex) { MessageShow.ShowException(this, ex); }
                                     };
            btnRefreshFromWeb.Click += (sender, e) => RefreshCurrentSpecificFeedFromWeb();
            btnLoadCurrentFeed.Click += LoadCurrentSpecificFeed;

            notifyIconStatus.Click += (sender, args) =>
                                          {
                                              if (Visible && !NewItems)
                                                  Visible = false;
                                              else
                                              {
                                                  Visible = true;
                                                  Activate();
                                              }
                                          };

            notifyIconStatus.BalloonTipClicked += (sender, args) => { Visible = true; Activate(); };

            MessageShow.OnExceptionLogin += (sender, e) => errorLIst.AddError(e.Message);
            OnLogOperation += (sender, args) => logLIst.AddOperation(args.Message + "\n");

            #endregion

        }



        private void LoadSettings()
        {
            var ttipButtons = new ToolTip();
            ttipButtons.SetToolTip(btnRSSStopStart, "Stop/Start the RSS countdown");
            ttipButtons.SetToolTip(btnRefreshActiveRSS, "Refresh the active RSS Feeds now");
            ttipButtons.SetToolTip(btnRefreshNonActiveRSS, "Refresh the active RSS Feeds now");
            

            bool aggregatorPerUser = Aggregator.GUI.Properties.Settings.Default.StorePerUser;

            Settings = AppSettings.LoadSettings(aggregatorPerUser, false);

            FeedsGroup = new List<RSSFeedsContainer>(0);
            FeedsGroup.Add(RSSFeedsContainer.DeSerializeBinaryFile(Settings.AppRSSSetings.FileName));

            OnFeedsChanges(this, new Core.FeedArgs(null, false));
            OutlookCount = RSSCount = 0;
            dgvUnreadMails.Height = 0;
            dgvRSSItems.Height = 0;
            EnableOutlook = Settings.AppOutlookSettings. EnabledOutlookReader;
            EnableRSS = Settings.AppRSSSetings.EnabledRSSReader;

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
            string belongstoFeed = Reflection.GetPropertyName(((IRSSPost itm) => itm.BelongsToFeed));
            string addeddate = Reflection.GetPropertyName(((IRSSPost itm) => itm.AddedDate));
            string ignoreThisPost = Reflection.GetPropertyName(((IRSSPost itm) => itm.IgnoreThisPost));
               
            dateToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[date];
            titleToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[title];
            descriptionToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[description];
            URLToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[url];
            creatorToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[creator];
            contentToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[content];
            readToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[read];
            linkToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[link];
            feedNameToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[feedname];
            addedDateToolStripMenuItem.Checked = Settings.AppGUISettings.RSSColumnsVisibleStatus[addeddate];
            //==================== end columns settings =======================
            #endregion

            RSStimeToRefreshSecondsCountdown =  Settings.AppRSSSetings.IntervalMinutes * 60;
            ShowInTaskbar = Settings.AppGUISettings.ShowTaskbarIcon;

            OutlooktimeToRefreshSecondsCountdown = OutlookTimeRefreshSeconds = Settings.AppOutlookSettings.IntervalMinutes * 60;
            if (RSStimeToRefreshSecondsCountdown < 120)
                RSStimeToRefreshSecondsCountdown =  120;

            if (OutlookTimeRefreshSeconds < 120)
                OutlooktimeToRefreshSecondsCountdown = OutlookTimeRefreshSeconds = 120;

            if (EnableOutlook)

                try
                {
                    OutlookConnection = new OutlookConnection();
                }
                catch (System.Exception ex)
                {

                    MessageShow.ShowException(this, ex, true);
                }

            spltcMain.Panel1Collapsed = !EnableOutlook;
            spltcMain.Panel2Collapsed = !EnableRSS;
            if (!EnableOutlook && !EnableRSS)
            {
                spltcMain.Visible = false;
                this.Height = 10;
            }
            else
                spltcMain.Visible = true;

            if (InvokeRequired)
                BeginInvoke(new MethodInvoker(SetAllGUIParameters));
            else
                SetAllGUIParameters();
        }

        #endregion

        #region Aero Effect Methods

        /// <summary>
        /// When the size of this form changes, redraw the form.
        /// </summary>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Invalidate();
        }

        /// <summary>
        /// When the form is painted, set the region where the glass effect 
        /// is applied.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if ((!ExtendFrameEnabled && !BlurBehindWindowEnabled)
                || !IsAeroGlassStyleSupported())
            {
                return;
            }

            using (Brush transparentBrush = new SolidBrush(transparentColor))
            {

                // Extend the frame.
                if (ExtendFrameEnabled)
                {
                    var glassMargins = this.GlassMargins;

                    // Extend the frame.
                    NativeMethods.DwmExtendFrameIntoClientArea(this.Handle,
                                                               ref glassMargins);

                    // Make the region in the margins transparent. 
                    marginRegion = new Region(this.ClientRectangle);

                    // If the glassMargins contains a negative value, or the values are not valid,
                    // then make the whole form transparent.
                    if (this.GlassMargins.IsNegativeOrOverride(this.ClientSize))
                    {
                        e.Graphics.FillRegion(transparentBrush, marginRegion);
                    }

                        // By default, exclude the region of the client area.
                    else
                    {
                        marginRegion.Exclude(new Rectangle(
                                                 this.GlassMargins.cxLeftWidth,
                                                 this.GlassMargins.cyTopHeight,
                                                 this.ClientSize.Width - this.GlassMargins.cxLeftWidth -
                                                 this.GlassMargins.cxRightWidth,
                                                 this.ClientSize.Height - this.GlassMargins.cyTopHeight -
                                                 this.GlassMargins.cyBottomHeight));
                        e.Graphics.FillRegion(transparentBrush, marginRegion);
                    }
                }

                    // Reset the frame to the default state.
                else
                {
                    var glassMargins = new NativeMethods.MARGINS(-1);
                    NativeMethods.DwmExtendFrameIntoClientArea(this.Handle,
                                                               ref glassMargins);
                }

                // Enable the blur effect on the form.
                if (BlurBehindWindowEnabled)
                {
                    ResetDwmBlurBehind(true, e.Graphics);

                    if (this.BlurRegion != null)
                    {
                        e.Graphics.FillRegion(transparentBrush, BlurRegion);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(transparentBrush, this.ClientRectangle);
                    }
                }
                else
                {
                    ResetDwmBlurBehind(false, null);
                }
            }
        }

        /// <summary>
        /// Enable or disable the blur effect on the form.
        /// </summary>
        private void ResetDwmBlurBehind(bool enable, Graphics graphics)
        {
            try
            {
                NativeMethods.DWM_BLURBEHIND bbh = new NativeMethods.DWM_BLURBEHIND();

                if (enable)
                {
                    bbh.dwFlags = NativeMethods.DWM_BLURBEHIND.DWM_BB_ENABLE;
                    bbh.fEnable = true;

                    if (this.BlurRegion != null)
                    {
                        bbh.hRegionBlur = this.BlurRegion.GetHrgn(graphics);
                    }
                    else
                    {
                        // Apply the blur glass effect to the entire window.
                        bbh.hRegionBlur = IntPtr.Zero;
                    }
                }
                else
                {
                    bbh.dwFlags = NativeMethods.DWM_BLURBEHIND.DWM_BB_ENABLE |
                                  NativeMethods.DWM_BLURBEHIND.DWM_BB_BLURREGION;
                    // Turn off the glass effect.
                    bbh.fEnable = false;
                    // Apply the blur glass effect to the entire window.
                    bbh.hRegionBlur = IntPtr.Zero;
                }
                NativeMethods.DwmEnableBlurBehindWindow(this.Handle, bbh);
            }
            catch (System.Exception ex)
            {
                MessageShow.ShowException(this, ex);
            }
        }

        /// <summary>
        /// Make sure the current computer is able to display the glass style windows.
        /// </summary>
        /// <returns>
        /// The flag that specify whether DWM composition is enabled or not.
        /// </returns>
        public static bool IsAeroGlassStyleSupported()
        {
            bool isDWMEnable = false;
            try
            {
                // Check that the glass is enabled by using the DwmIsCompositionEnabled. 
                // It is supported in version 6.0 or above of the operating system.
                if (System.Environment.OSVersion.Version.Major >= 6)
                {
                    // Make sure the Glass is enabled by the user.
                    NativeMethods.DwmIsCompositionEnabled(out isDWMEnable);
                }
            }
            catch (System.Exception ex)
            {

            }

            return isDWMEnable;
        }

        /// <summary>
        /// This method makes that users can drag the form by click the extended frame.
        /// </summary>
        protected override void WndProc(ref Message m)
        {
            // Let the normal WndProc process it.
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    // The mouse is inside the client area
                    if (HTCLIENT == m.Result.ToInt32())
                    {
                        // Parse the WM_NCHITTEST message parameters
                        // get the mouse pointer coordinates (in screen coordinates)
                        Point p = new Point();
                        // low order word
                        p.X = (m.LParam.ToInt32() & 0xFFFF);
                        // high order word
                        p.Y = (m.LParam.ToInt32() >> 16);

                        // Convert screen coordinates to client area coordinates
                        p = PointToClient(p);

                        // If it's on glass, then convert it from an HTCLIENT
                        // message to an HTCAPTION message and let Windows handle it 
                        // from then on.
                        if (PointIsOnGlass(p))
                        {
                            m.Result = new IntPtr(2);
                        }
                    }
                    break;
                case WM_DWMCOMPOSITIONCHANGED:

                    // Release the resource when glass effect is not supported.
                    if (DWMCompositionChanged != null)
                    {
                        DWMCompositionChanged(this, EventArgs.Empty);
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Check that the point is inside the glass area.
        /// </summary>
        private bool PointIsOnGlass(Point p)
        {
            if (this.marginRegion == null)
            {
                return false;
            }
            else
            {
                return this.marginRegion.IsVisible(p);
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (this.marginRegion != null)
            {
                marginRegion.Dispose();
            }

            if (this.BlurRegion != null)
            {
                this.BlurRegion.Dispose();
            }
        }

        #endregion

        #region Form Methods

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            tmrSourgeForge.Enabled = btnCount.Visible = sourceForgeView;
            var ttipButtons = new ToolTip();
            ttipButtons.SetToolTip(btnRSSStopStart, "Stop/Start the RSS countdown");
            ttipButtons.SetToolTip(btnRefreshActiveRSS, "Refresh Unread Mail items");
            ttipButtons.SetToolTip(btnRefreshActiveRSS, "Refresh the active RSS Feeds now");
            ttipButtons.SetToolTip(btnRefreshNonActiveRSS, "Refresh the non active RSS Feeds now");
            ttipButtons.SetToolTip(btnMailReply, "Reply to the selected mail");
            ttipButtons.SetToolTip(btnMailDelete, "Delete (move to deleted folder) the selected mail");
            ttipButtons.SetToolTip(btnMailsStopStart, "Stop/Start the Mail countdown");
            notifyIconStatus.ShowBalloonTip(1000, "Desktop Aggregator", "When there are new items a popup will be shown here which can be clicked on to open the main window. Clicking on the tray icon will show/hide the main window", ToolTipIcon.None);

            //	this.TransparencyKey = BackColor;
            RefreshMails();

            //clear the RRS datagrid
            DisplayRSSItems(new List<IRSSPost>(0), dgvRSSItems);
            //OnFeedsChanges(this, null);


        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAllFeedsToDisk();
            SaveAppSettings();
        }

        private void SaveAppSettings()
        {
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

        #region Set Form GUI elements Location

        private void SetAllGUIParameters()
        {
            //  spltcMain.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            SetMailGUIParameters();
            SetRSSGUIParameters();
            // spltcMain.Dock = DockStyle.Fill;
        }
        private void SetMailGUIParameters()
        {
            var ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            spltcMain.Height = ScreenHeight;
            int unreadMailItemsHeight = dgvUnreadMails.Rows.GetRowsHeight(DataGridViewElementStates.None);
            int dgvUnreadMailsstartPosition = spltcMain.Location.Y + dgvUnreadMails.Location.Y;
            int dgvUnreadMailsEndPosition = dgvUnreadMailsstartPosition + unreadMailItemsHeight + 40;

            spltcMain.SplitterDistance = dgvUnreadMailsEndPosition;

            if (spltcMain.Panel2Collapsed)
            {
                if (Location.Y + dgvUnreadMailsEndPosition - 40 > ScreenHeight)
                    spltcMain.Height = ScreenHeight - spltcMain.Location.Y - Location.Y - 20 - ssOutlook.Height;
                else
                {
                    dgvUnreadMails.Height = dgvUnreadMailsEndPosition - dgvUnreadMailsstartPosition + 20;
                    spltcMain.Height = dgvUnreadMailsEndPosition;
                }
            }
            else
            {
                if (dgvUnreadMailsEndPosition > ScreenHeight / 2)
                    spltcMain.Height = ScreenHeight / 2;
            }

            dgvUnreadMails.Height = spltcMain.Panel1.Height - dgvUnreadMailsstartPosition - 10;




        }
        private void SetRSSGUIParameters()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(SetRSSGUIParameters));
                return;
            }

            var rssItemsHeight = dgvRSSItems.Rows.GetRowsHeight(DataGridViewElementStates.None);

            int dgvRSSStartPosition = spltcMain.Location.Y + spltcMain.SplitterDistance + dgvRSSItems.Location.Y;
            if (spltcMain.Panel1Collapsed)
                dgvRSSStartPosition -= spltcMain.SplitterDistance;
            int dgvRSSEndPosition = dgvRSSStartPosition + rssItemsHeight + 50;
            var ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;


            if (!spltcMain.Panel2Collapsed) //show RSS panel:
            {

                if (Location.Y + dgvRSSEndPosition + 40 >= ScreenHeight - Location.Y)
                {
                    // spltcMain.Height = ScreenHeight - 30 - ( spltcMain.Location.Y+ spltcMain.Panel1.Height);
                    spltcMain.Height = ScreenHeight - spltcMain.Location.Y - Location.Y - 20 - ssRSS.Height;
                }
                else
                {
                    spltcMain.Height = dgvRSSEndPosition;

                }
            }
            dgvRSSItems.Height = spltcMain.Height - dgvRSSStartPosition - 20;
            this.Height = menuStrip1.Height + spltcMain.Location.Y + spltcMain.Height + 20;

        }

        #endregion

        #region Background Worker for reading mails

        private void bwRefreshMail_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<MyOutlookItem> items = new List<MyOutlookItem>(0);
            if (OutlookConnection != null)
            {
                foreach (Folder folder in OutlookConnection.Allfolders)
                {
                    {
                        items.AddRange(OutlookConnection.GetAllUnreadItemsInFolder(folder, true));
                    }
                }
            }
            e.Result = items;

        }

        private void bwRefreshMail_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            dgvUnreadMails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; //Row height autosize
            dgvUnreadMails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (e.Result != null && e.Error == null)
                dgvUnreadMails.DataSource = (List<MyOutlookItem>)e.Result;
            if (dgvUnreadMails.DataSource != null)
            {
                string subject = Reflection.GetPropertyName(((MyOutlookItem itm) => itm.Subject));
                string index = Reflection.GetPropertyName(((MyOutlookItem itm) => itm.Index));
                string foldername = Reflection.GetPropertyName(((MyOutlookItem itm) => itm.Folder));


                dgvUnreadMails.Columns[subject].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvUnreadMails.Columns[subject].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                SetAllGUIParameters();

                int countnewitems = dgvUnreadMails.Rows.Count;
                NewItems = countnewitems > 0;
                if (countnewitems > 0)
                {

                    //	Activate();
                    //NotifyPopUpParameters(string.Format("{0} new items", countnewitems),string.Format("{0} new Mails", countnewitems));
                    notifyIconStatus.ShowBalloonTip(1000, string.Format("{0} new items", countnewitems), string.Format("{0} new Mails", countnewitems), ToolTipIcon.None);
                }
            }
        }


        #endregion

        #region Background Worker For reading RSS items

        private void bwRefreshRSS_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            bool activeFeeds = (bool)e.Argument;
            tmrRefreshRSS.Enabled = false;
            try
            {
                List<IRSSPost> posts = new List<IRSSPost>();
                if (activeFeeds)
                    posts = GetRSSItemsFromAllFeeds(true, false, true, false);
                else
                {
                    posts = GetRSSItemsFromAllFeeds(true, false, false, true);
                }
                e.Result = posts;

            }
            catch (System.Exception ex)
            {
                MessageShow.ShowException(this, ex, true);
            }

        }

        private void bwRefreshRSS_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            tsmiApplicationSettings.Enabled = true;
            if (e.Error == null && e.Result != null)
            {
                DisplayRSSItems((List<IRSSPost>)e.Result, dgvRSSItems);
                SetAllGUIParameters();
            }
            tmrRefreshRSS.Enabled = true;
        }

        #endregion

        #region RSS GET/SET methods

        private List<IRSSPost> GetRSSItemsFromAllFeeds(bool unreadOnly, bool fromCache, bool fromActiveFeeds, bool fromNonActiveFeeds)
        {
            // Query the <item>s in the XML RSS data and select each one into a new Post()
            List<IRSSPost> posts = new List<IRSSPost>();

            if (fromActiveFeeds && fromNonActiveFeeds )
                OnLogOperation(this, new LogArgs(DateTime.Now + ": Start refreshing all feeds."));
            else if (!fromActiveFeeds)
                OnLogOperation(this, new LogArgs(DateTime.Now + ": Start refreshing Non Active feeds."));
            else
                OnLogOperation(this, new LogArgs(DateTime.Now + ": starting refreshing all active feeds"));
            int numOfTasks = 0;

            foreach (RSSFeedsContainer rssGrouping in FeedsGroup)
            {
                numOfTasks += rssGrouping.GetFeeds().Count(feed => (feed.Active == fromActiveFeeds) || (feed.Active == !fromNonActiveFeeds));
            }
            Task<IEnumerable<IRSSPost>>[] Tasks = new Task<IEnumerable<IRSSPost>>[numOfTasks];
            int i = 0;

            foreach (RSSFeedsContainer rssGrouping in FeedsGroup)
                foreach (var feed in rssGrouping.GetFeeds())
                {
                    if ((feed.Active == fromActiveFeeds) || (feed.Active == !fromNonActiveFeeds))
                    {
                        IRSSFeed feed1 = feed;
                        Task<IEnumerable<IRSSPost>> tsk = new Task<IEnumerable<IRSSPost>>(
                            () => feed1.GetAllItems(unreadOnly, !fromCache, !Settings.AppRSSSetings.NotifyOnRSSErrors));
                        OnLogOperation(this,
                                       new LogArgs(string.Format("\t{0}: creating task {1} for feed {2}",
                                                                 DateTime.Now, i, feed1.RSSName)));
                        Tasks[i] = tsk;
                        int i1 = i;
                        Tasks[i].ContinueWith(delegate
                                                  {
                                                      string op = string.Format("\t{0}: Task {1} finished for feed {2} (Time: {3} Seconds, Download size: {4} KB)", DateTime.Now, i1, feed1.RSSName, feed1.LastDownloadTime.TotalSeconds, feed1.LastDownloadSizeKb);
                                                      OnLogOperation(this, new LogArgs(string.Format(op)));
                                                  });
                        tsk.Start();
                        i++;

                    }

                }
            Task.WaitAll(Tasks);

            if (logLIst != null && !logLIst.IsDisposed)
                logLIst.AddOperation(string.Format("\t{0} :Finished\n", DateTime.Now.ToString()));

            foreach (var task in Tasks)
            {
                if (task.Status == TaskStatus.RanToCompletion)
                {
                    var results = task.Result;
                    posts.AddRange(results);

                }
            }
            ulong totalFeedsKB = 0;
            foreach (RSSFeedsContainer rssGrouping in FeedsGroup)
                foreach (var feed in rssGrouping.GetFeeds())
                {
                    totalFeedsKB += feed.TotalDownloadedKB;
                }

            TotalDownloadedKB = totalFeedsKB;
           
            //posts = posts.OrderByDescending((IRSSPost itm) => itm.Date).ToList();

            //save feeds to disk
            if (Settings.AppRSSSetings.SaveRSSFeedsOnEveryRefresh && !fromCache && posts.Count > 0)
            {
                SaveAllFeedsToDisk();
            }

            return posts;
        }

        private void DisplayRSSItems(List<IRSSPost> MyRSSPosts, DataGridView RSSdataGridView)
        {

            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(() => DisplayRSSItems(MyRSSPosts, RSSdataGridView)));
                return;
            }

       

            int countnewitems = 0;
            tsslTotalDownloaded.Text = Utils.FormatKBytes(TotalDownloadedKB) + " Total Downloaded";
            if (MyRSSPosts != null)
            {
                var bindingsource = new BindingSource();

                bindingsource.RaiseListChangedEvents = false;
                bindingsource.DataSource = MyRSSPosts;
                RSSdataGridView.DataSource = bindingsource;
                countnewitems = (MyRSSPosts).Count(itm => itm.Read == false);
                bindingsource.RaiseListChangedEvents = true;
                bindingsource.ResetBindings(false);


            }
            if (RSSdataGridView.DataSource != null)
            {
                //update RSS datagridview columns
                UpdateRSSColumns(RSSdataGridView);
                
                chkbAllRSSItem.Text = Resources.UnReadRSSPostsAlreadyTotalItems + dgvRSSItems.Rows.Count;
                NewItems = countnewitems > 0;
                if (countnewitems > 0)
                {
                    notifyIconStatus.ShowBalloonTip(1000, string.Format("{0} new items", countnewitems), string.Format("{0} new RSS Items", countnewitems), ToolTipIcon.None);
                }

            }


        }
        private void UpdateRSSColumns(DataGridView RSSdataGridView)
        {
          
            foreach (var columnname in Settings.AppGUISettings.RSSColumnsVisibleStatus)
            {
                if (RSSdataGridView.Columns.Contains(columnname.Key))
                    RSSdataGridView.Columns[columnname.Key].Visible = columnname.Value;
            }


            string title = Reflection.GetPropertyName(((IRSSPost itm) => itm.Title));
            string feedName = Reflection.GetPropertyName(((IRSSPost itm) => itm.FeedName));
            string IgnorePostContentIncomparison = Reflection.GetPropertyName(((IRSSPost itm) => itm.IgnorePostContentIncomparison));
            RSSdataGridView.Columns[IgnorePostContentIncomparison].Visible = false;

            RSSdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; //Row height autosize
            RSSdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            RSSdataGridView.Columns[title].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RSSdataGridView.Columns[title].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            RSSdataGridView.Columns[feedName].DefaultCellStyle.WrapMode = DataGridViewTriState.False;

        }
        private void LoadCurrentSpecificFeed(object sender, EventArgs e)
        {
            IRSSFeed currentFeed = cbFeeds.SelectedItem as IRSSFeed;

            if (currentFeed != null)
            {
                lblIsActiveFeed.Text = "Active feed: " + currentFeed.Active.ToString();
                DisplayRSSItems(currentFeed.GetAllItems(false, false, true).ToList(), dgvRSSItems);
                SetRSSGUIParameters();
            }
        }
        private void RefreshCurrentSpecificFeedFromWeb()
        {
            IRSSFeed currentFeed = cbFeeds.SelectedItem as IRSSFeed;
            bool unreadOnly = chkbAllRSSItem.Checked;
            if (currentFeed != null)
            {
                lblIsActiveFeed.Text = "Active feed: " + currentFeed.Active.ToString();
                btnRefreshFromWeb.Image = Aggregator.GUI.Properties.Resources.loading;
                OnLogOperation(this, new LogArgs(DateTime.Now + ": Start refreshing Specific feed (" + currentFeed.RSSName + ")"));

                var tsk = new Task<IEnumerable<IRSSPost>>(() => currentFeed.GetAllItems(unreadOnly, true, false));
                tsk.ContinueWith(delegate
                                     {
                                         string op = string.Format("{0}: Refreshed feed {1} (Time: {2} Seconds, Download size: {3}KB)", DateTime.Now.ToString(), currentFeed.RSSName, currentFeed.LastDownloadTime.TotalSeconds, currentFeed.LastDownloadSizeKb.ToString());
                                         OnLogOperation(this, new LogArgs(op));
                                         btnRefreshFromWeb.Image = null;

                                         var results = tsk.Result.ToList();
                                         //save feeds to disk?
                                         if (Settings.AppRSSSetings. SaveRSSFeedsOnEveryRefresh && results.Count > 0)
                                         {
                                             SaveAllFeedsToDisk();
                                         }


                                         if (tsk.Status == TaskStatus.RanToCompletion)
                                         {
                                             DisplayRSSItems(results, dgvRSSItems);
                                             SetRSSGUIParameters();
                                         }
                                     });
                tsk.Start();

            }
        }


        #endregion

        #region Form Controls Methods

        void RSSColumnsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
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

          
            Settings.AppGUISettings.RSSColumnsVisibleStatus[date] = dateToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[title] = titleToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[description] = descriptionToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[url] = URLToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[creator] = creatorToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[content] = contentToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[read] = readToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[link] = linkToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[feedname] = feedNameToolStripMenuItem.Checked;
            Settings.AppGUISettings.RSSColumnsVisibleStatus[addeddate] = addedDateToolStripMenuItem.Checked;

            SaveAppSettings();
            UpdateRSSColumns(dgvRSSItems);
        }
        private void dgvUnreadMails_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (dgvUnreadMails.CurrentRow != null)
            {
                try
                {
                    MyOutlookItem currentitem = (MyOutlookItem)dgvUnreadMails.CurrentRow.DataBoundItem;
                    currentitem.RunMethod("Display");
                }
                catch (System.Exception ex)
                {

                    MessageShow.ShowException(this, ex);
                }
            }
        }
        private void dgvUnreadMails_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (dgvUnreadMails.CurrentRow != null)
            {
                try
                {
                    MyOutlookItem currentitem = (MyOutlookItem)dgvUnreadMails.CurrentRow.DataBoundItem;
                    currentitem.RunMethod("Display");
                }
                catch (System.Exception ex)
                {

                    MessageShow.ShowException(this, ex);
                }
            }
        }
        private void dgvRSSItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRSSItems.CurrentRow != null)
            {
                IRSSPost currentitem = (IRSSPost)dgvRSSItems.CurrentRow.DataBoundItem;
                var rssDisplay = new RSSItemViewer(currentitem);
                rssDisplay.OnRSSItemChanged += delegate { dgvRSSItems.Refresh(); };

                rssDisplay.Show();
                currentitem.Read = true;
                dgvRSSItems.Refresh();
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
                dgvRSSItems.Refresh();
            }
        }
        private void chkbAllRSSItem_Click(object sender, EventArgs e)
        {

            var posts = FeedsGroup.First().GetAllFeedsPostsFromCache(chkbAllRSSItem.Checked).ToList();
            DisplayRSSItems(posts, dgvRSSItems);
            SetAllGUIParameters();
            
            //if (EnableRSS)
            //{
            //    if (bwRefreshRSS.IsBusy)
            //    {
            //        chkbAllRSSItem.Text = "Show Only Unread RSS posts (active feeds). Already reading posts...";
            //    }
            //    else
            //    {
            //        chkbAllRSSItem.Text = "Show Only Unread RSS posts (active feeds). Reading posts...";
            //        var RSSitems = GetRSSItemsFromAllFeeds(chkbAllRSSItem.Checked,true,true,false);
            //        DisplayRSSItems(RSSitems, dgvRSSItems);
            //        SetAllGUIParameters();
            //    }
            //}
        }

        private void btnMarkAllRSSAsRead_Click(object sender, EventArgs e)
        {
            tmrRefreshRSS.Enabled = false;
            foreach (DataGridViewRow row in dgvRSSItems.Rows)
            {
                IRSSPost currentitem = (IRSSPost)row.DataBoundItem;
                currentitem.Read = true;
            }
            dgvRSSItems.Refresh();
            tmrRefreshRSS.Enabled = true;
        }
        private void btnMarkAllMailsAsRead_Click(object sender, EventArgs e)
        {
            tmrRefreshOutlook.Enabled = false;
            foreach (DataGridViewRow row in dgvUnreadMails.Rows)
            {
                MyOutlookItem currentitem = (MyOutlookItem)row.DataBoundItem;
                var outlookmail = currentitem.OutlookMailItem as dynamic;
                if (outlookmail != null)

                    try
                    {
                        outlookmail.UnRead = false;
                    }
                    catch (System.Exception ex)
                    {
                        MessageShow.ShowException(this, ex, false);
                    }
            }
            if (!bwRefreshMail.IsBusy)
                bwRefreshMail.RunWorkerAsync();
            SetAllGUIParameters();
            tmrRefreshOutlook.Enabled = true;
        }
        private void btnMailsStopStart_Click(object sender, EventArgs e)
        {
            tmrRefreshOutlook.Enabled = !tmrRefreshOutlook.Enabled;
            btnMailsStopStart.BackgroundImage = tmrRefreshOutlook.Enabled ? Properties.Resources.Pauseicon : Properties.Resources.Playicon;
        }
        private void btnRSSStopStart_Click(object sender, EventArgs e)
        {
            tmrRefreshRSS.Enabled = !tmrRefreshRSS.Enabled;
            btnRSSStopStart.BackgroundImage = tmrRefreshRSS.Enabled ? Properties.Resources.Pauseicon : Properties.Resources.Playicon;
        }
        private void btnCount_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient { Encoding = Encoding.UTF8 };
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            try
            {
                string url = @"http://sourceforge.net/projects/deskaggregator/files/stats/timeline";
                var xmlData = client.DownloadString(url);
                var substr1 = xmlData.Remove(0, xmlData.IndexOf("<strong>") + 8);
                var pos = substr1.IndexOf(("<"));
                var count = substr1.Substring(0, pos);
                StandardRSSPost post = new StandardRSSPost("Number of downloads", "", "", xmlData, "", "", null, null);
                RSSItemViewer viewer = new RSSItemViewer(post);
                viewer.WindowState = FormWindowState.Maximized;
                // viewer.ShowDialog();
                btnCount.Text = count;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnMailDelete_Click(object sender, EventArgs e)
        {
            if (dgvUnreadMails.CurrentRow != null)
            {
                try
                {
                    MyOutlookItem currentitem = (MyOutlookItem)dgvUnreadMails.CurrentRow.DataBoundItem;
                    currentitem.SetProperty("Unread", false);
                    currentitem.RunMethod("Delete");
                    RefreshMails();
                }
                catch (System.Exception ex)
                {

                    MessageShow.ShowException(this, ex);
                }
            }
        }
        private void btnMailReply_Click(object sender, EventArgs e)
        {
            if (dgvUnreadMails.CurrentRow != null)
            {
                try
                {
                    MyOutlookItem currentitem = (MyOutlookItem)dgvUnreadMails.CurrentRow.DataBoundItem;
                    currentitem.RunMethod("Reply");
                }
                catch (System.Exception ex)
                {

                    MessageShow.ShowException(this, ex);
                }
            }
        }

        private void cbFeeds_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            int index = e.Index;
            if (index >= 0)
            {
                Color color = (((IRSSFeed)cbFeeds.Items[index]).Active) ? Color.White : Color.LightGray;
                g.FillRectangle(new SolidBrush(color), e.Bounds);
                bool selected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
                string text = ((IRSSFeed)cbFeeds.Items[index]).RSSName;

                SolidBrush drawBrush = new SolidBrush(Color.Black);
                g.DrawString(text, e.Font, drawBrush, e.Bounds);

                e.DrawFocusRectangle();

            }

        }


        private void tmrRefreshRSS_Tick(object sender, System.EventArgs e)
        {
            if (RSStimeToRefreshSecondsCountdown <= 0) //do routing
            {
                RSStimeToRefreshSecondsCountdown = Settings.AppRSSSetings.IntervalMinutes * 60; ;
                RefreshRSS();
            }
            else
            {
                RSStimeToRefreshSecondsCountdown--;
            }

            TimeSpan time = TimeSpan.FromSeconds(RSStimeToRefreshSecondsCountdown);
            tsslNextRefreshRSS.Text = time.ToString();
        }
        private void tmrRefreshOutlook_Tick(object sender, EventArgs e)
        {
            if (OutlooktimeToRefreshSecondsCountdown <= 0) //do routing
            {
                OutlooktimeToRefreshSecondsCountdown = OutlookTimeRefreshSeconds = Settings.AppOutlookSettings.IntervalMinutes * 60;
                RefreshMails();
            }
            else
            {
                OutlooktimeToRefreshSecondsCountdown--;
            }

            TimeSpan time = TimeSpan.FromSeconds(OutlooktimeToRefreshSecondsCountdown);
            tsslNextRefreshOutlook.Text = time.ToString();
        }
        private void tmrSourgeForge_Tick(object sender, EventArgs e)
        {
            if (sourgeForgeCountdown <= 0) //do routing
            {
                sourgeForgeCountdown = 60 * 30;
                btnCount_Click(this, e);
            }
            else
            {
                sourgeForgeCountdown--;
            }
            TimeSpan time = TimeSpan.FromSeconds(sourgeForgeCountdown);
            tsslSourgeForge.Text = time.ToString();
        }
        #endregion

        #region General methods

        private void RefreshRSS()
        {
            if (!bwRefreshRSS.IsBusy && EnableRSS)
            {
                RSSCount++;
                tsmiApplicationSettings.Enabled = false;
                chkbAllRSSItem.Text = Resources.UnReadRSSPostsReading;
                bwRefreshRSS.RunWorkerAsync(true);
            }
            else
            {
                chkbAllRSSItem.Text = Resources.UnReadRSSPostsAlreadyReading;
            }
            tsslRefreshedCountRSS.Text = "Number of RSS refreshes: " + RSSCount;
        }
        private void RefreshMails()
        {
            OutlookCount++;
            tsslRefreshedCountOutlook.Text = "Number of Mail refreshes: " + OutlookCount;
            if (!bwRefreshMail.IsBusy && EnableOutlook)
            {

                bwRefreshMail.RunWorkerAsync();
            }
        }
        private void OnFeedsChanges(object sender, Core.FeedArgs feedArgs)
        {
            cbFeeds.SelectedIndexChanged -= LoadCurrentSpecificFeed;
            RSSFeedsContainer firstFeed = FeedsGroup.FirstOrDefault();

            if (firstFeed != null)
            {
                if (feedArgs != null && feedArgs.IsNewFeed)
                    DisplayRSSItems(feedArgs.Feed.GetAllItemsFromCache(false, true).ToList(), dgvRSSItems);
                else
                    DisplayRSSItems(new List<IRSSPost>(0), dgvRSSItems);
                SetAllGUIParameters();

                var items = firstFeed.GetFeeds().ToList();
                cbFeeds.DataSource = items;
                cbFeeds.DisplayMember = Reflection.GetPropertyName(((RSSFeed feed) => feed.RSSName));
                IRSSFeed currentFeed = cbFeeds.SelectedItem as IRSSFeed;
                if (currentFeed != null)
                {
                    lblIsActiveFeed.Text = "Active feed: " + currentFeed.Active.ToString();
                }
            }
            if (cbFeeds.Items.Count == 0)
            {
                dgvRSSItems.DataSource = null;
                DisplayRSSItems(new List<IRSSPost>(0), dgvRSSItems);
            }
            cbFeeds.SelectedIndexChanged += LoadCurrentSpecificFeed;
        }

        #endregion
    }
}

