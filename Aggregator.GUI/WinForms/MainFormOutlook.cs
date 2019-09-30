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
    public partial class MainFormOutlook : Form
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
        private bool UserActive { get; set; }
        //TODO
        //private OutlookConnection OutlookConnection { get; set; }
        private AppSettings Settings { get; set; }
        private ErrorsForm errorLIst;
        private LogsForm logLIst;
        private bool cancelExit = true;
        private int OutlookCount { get; set; }
        private bool NewItems { get; set; }

        private int OutlookTimeRefreshSeconds;
        private int OutlooktimeToRefreshSecondsCountdown;


        #endregion

        #region Ctor related

        public MainFormOutlook(AppSettings settings)
        {
            InitializeComponent();

            this.TransparencyKey = transparentColor;
            BlurBehindWindowEnabled = false;
            blurRegion = null;
            errorLIst = new ErrorsForm();
            logLIst = new LogsForm();
            dgvUnreadMails.DataSource = new List<MyOutlookItem>(0);

            Settings = settings;
            OutlookCount = 0;
            ShowInTaskbar = Settings.AppGUISettings.ShowTaskbarIcon;
            OutlooktimeToRefreshSecondsCountdown = OutlookTimeRefreshSeconds = Settings.AppOutlookSettings.IntervalMinutes * 60;

            if (OutlookTimeRefreshSeconds < 120)
                OutlooktimeToRefreshSecondsCountdown = OutlookTimeRefreshSeconds = 120;

            try
            {
                //OutlookConnection = new OutlookConnection();
            }
            catch (System.Exception ex)
            {

                MessageShow.ShowException(this, ex, true);
            }

            #region Events Subscribings

            #region MenuItems Subscribings
          
            tsmiVersion.Click += (sender, args) => new VersionHistoryDialog().ShowDialog();
            tsmiAbout.Click += (sender, args) => new AboutBoxDesktopAggregator().ShowDialog();
            tsmiStatistics.Click += (sender, e) => new NetworkStatistics().Show();
            tsmiErrorsList.Click += (sender, args) => errorLIst.ShowDialog();
            tsmiViewLogOperations.Click += (sender, args) => logLIst.Show();
            tsmiRefresh.Click += (sender, args) => OutlooktimeToRefreshSecondsCountdown = 0;


            tsmiClose.Click += (sender, args) =>
            {
                cancelExit = false;
                Close();
            };
            tsmiClose2.Click += (sender, args) =>
            {
                cancelExit = false;
                Close();
            };
            tsmiApplicationSettings.Click += (sender, args) =>
            {

                //var settingdlg = new SettingsDialog(FeedsGroup.FirstOrDefault(), Settings);
                //settingdlg.OnSettingsSaved += (s, a) => LoadSettings();
                //settingdlg.ShowDialog();

            };
            #endregion

            btnRefreshMail.Click += (sender, e) => OutlooktimeToRefreshSecondsCountdown = 0;
       
            notifyIconStatus.Click += (sender, args) =>
                                          {
                                              Visible = !Visible;
                                             if (Visible )
                                               
                                                  Activate();
                                              
                                          };

            notifyIconStatus.BalloonTipClicked += (sender, args) => { Visible = true; Activate(); };

            MessageShow.OnExceptionLogin += (sender, e) => errorLIst.AddError(e.Message);
            OnLogOperation += (sender, args) => logLIst.AddOperation(args.Message + "\n");

            #endregion

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
            
            var ttipButtons = new ToolTip();
            ttipButtons.SetToolTip(btnMailReply, "Reply to the selected mail");
            ttipButtons.SetToolTip(btnMailDelete, "Delete (move to deleted folder) the selected mail");
            ttipButtons.SetToolTip(btnMailsStopStart, "Stop/Start the Mail countdown");
            notifyIconStatus.ShowBalloonTip(1000, "Desktop Aggregator", "When there are new items a popup will be shown here which can be clicked on to open the main window. Clicking on the tray icon will show/hide the main window", ToolTipIcon.None);

            //	this.TransparencyKey = BackColor;
            RefreshMails();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (cancelExit)
            {
                e.Cancel = true;
                Visible = false;
                notifyIconStatus.ShowBalloonTip(1000, "Desktop Aggregator",
                                                "The program will keep running in the background. To close it right click this icon and choose Close or select exit from the File menu",
                                                ToolTipIcon.Info);
            }
            else
            {
                notifyIconStatus.Visible = false;
                notifyIconStatus.Dispose();
            }


        }

        #endregion

        //#region Set Form GUI elements Location

        //private void SetAllGUIParameters()
        //{
        //    //  spltcMain.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        //    SetMailGUIParameters();
        //    SetRSSGUIParameters();
        //    // spltcMain.Dock = DockStyle.Fill;
        //}
        //private void SetMailGUIParameters()
        //{
        //    var ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
        //    spltcMain.Height = ScreenHeight;
        //    int unreadMailItemsHeight = dgvUnreadMails.Rows.GetRowsHeight(DataGridViewElementStates.None);
        //    int dgvUnreadMailsstartPosition = spltcMain.Location.Y + dgvUnreadMails.Location.Y;
        //    int dgvUnreadMailsEndPosition = dgvUnreadMailsstartPosition + unreadMailItemsHeight + 40;

        //    spltcMain.SplitterDistance = dgvUnreadMailsEndPosition;

        //    if (spltcMain.Panel2Collapsed)
        //    {
        //        if (Location.Y + dgvUnreadMailsEndPosition - 40 > ScreenHeight)
        //            spltcMain.Height = ScreenHeight - spltcMain.Location.Y - Location.Y - 20 - ssOutlook.Height;
        //        else
        //        {
        //            dgvUnreadMails.Height = dgvUnreadMailsEndPosition - dgvUnreadMailsstartPosition + 20;
        //            spltcMain.Height = dgvUnreadMailsEndPosition;
        //        }
        //    }
        //    else
        //    {
        //        if (dgvUnreadMailsEndPosition > ScreenHeight / 2)
        //            spltcMain.Height = ScreenHeight / 2;
        //    }

        //    dgvUnreadMails.Height = spltcMain.Panel1.Height - dgvUnreadMailsstartPosition - 10;




        //}
        //private void SetRSSGUIParameters()
        //{
        //    if (InvokeRequired)
        //    {
        //        Invoke(new MethodInvoker(SetRSSGUIParameters));
        //        return;
        //    }

        //    var rssItemsHeight = dgvRSSItems.Rows.GetRowsHeight(DataGridViewElementStates.None);

        //    int dgvRSSStartPosition = spltcMain.Location.Y + spltcMain.SplitterDistance + dgvRSSItems.Location.Y;
        //    if (spltcMain.Panel1Collapsed)
        //        dgvRSSStartPosition -= spltcMain.SplitterDistance;
        //    int dgvRSSEndPosition = dgvRSSStartPosition + rssItemsHeight + 50;
        //    var ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;


        //    if (!spltcMain.Panel2Collapsed) //show RSS panel:
        //    {

        //        if (Location.Y + dgvRSSEndPosition + 40 >= ScreenHeight - Location.Y)
        //        {
        //            // spltcMain.Height = ScreenHeight - 30 - ( spltcMain.Location.Y+ spltcMain.Panel1.Height);
        //            spltcMain.Height = ScreenHeight - spltcMain.Location.Y - Location.Y - 20 - ssRSS.Height;
        //        }
        //        else
        //        {
        //            spltcMain.Height = dgvRSSEndPosition;

        //        }
        //    }
        //    dgvRSSItems.Height = spltcMain.Height - dgvRSSStartPosition - 20;
        //    this.Height = menuStrip1.Height + spltcMain.Location.Y + spltcMain.Height + 20;

        //}

        //#endregion

        #region Mail Related
        private void RefreshMails()
        {
            OutlookCount++;
            tsslRefreshedCountOutlook.Text = "Number of Mail refreshes: " + OutlookCount;
            if (!bwRefreshMail.IsBusy)
            {

                bwRefreshMail.RunWorkerAsync();
            }
        }
        private void bwRefreshMail_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<MyOutlookItem> items = new List<MyOutlookItem>(0);
            //TODO
            //if (OutlookConnection != null)
            //{
            //    foreach (Folder folder in OutlookConnection.Allfolders)
            //    {
            //        {
            //            items.AddRange(OutlookConnection.GetAllUnreadItemsInFolder(folder, true));
            //        }
            //    }
            //}
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

                int countnewitems = dgvUnreadMails.Rows.Count;
                NewItems = countnewitems > 0;
                if (countnewitems > 0 && UserActive )
                {

                    //	Activate();
                    //NotifyPopUpParameters(string.Format("{0} new items", countnewitems),string.Format("{0} new Mails", countnewitems));
                    notifyIconStatus.ShowBalloonTip(1000, string.Format("{0} new items", countnewitems), string.Format("{0} new Mails", countnewitems), ToolTipIcon.None);
                }
            }
        }

        #endregion

        #region Form Controls Methods

        private void dgvUnreadMails_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

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
            tmrRefreshOutlook.Enabled = true;
        }
        private void btnMailsStopStart_Click(object sender, EventArgs e)
        {
            tmrRefreshOutlook.Enabled = !tmrRefreshOutlook.Enabled;
            btnMailsStopStart.BackgroundImage = tmrRefreshOutlook.Enabled ? Properties.Resources.Pauseicon : Properties.Resources.Playicon;
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

        private void tmrUser_Tick(object sender, EventArgs e)
        {
            TimeSpan time = TimeSpan.FromSeconds(UserIdle.GetLastInputTime());
            UserActive = time.TotalMinutes <= 10;
            tsslUseActive.Text = (time.TotalMinutes <= 10) ? "User was active in the last 10 minutes." : "User Idle: " + time.ToString();
            
        
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

        }
        #endregion

    }
}

