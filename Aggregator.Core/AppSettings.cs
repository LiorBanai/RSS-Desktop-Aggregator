using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Aggregator.Util;

namespace Aggregator.Core
{
    [Serializable]
    public class AppSettings
    {
        public enum FileLocations
        {
            ForAllUsers = 0, PerUser = 1
        }
        [Serializable]
        public class GUISettings
        {
            [Serializable]
            public class ColumnData
            {
                public bool Visible { get; set; }
                public string HeaderText { get; set; }

                public ColumnData(bool visible,string headerText)
                {
                    Visible = visible;
                    HeaderText = headerText;
                }
            }
            #region Data Members

            public int MainRSSFormLeftPanelWidth { get; set; }
            public int MainFormLeftTopPanelWidth { get; set; }
            public int MainFormRightPanelWidth { get; set; }
            public Dictionary<string, ColumnData> RSSColumnsVisibleStatus { get; set; }
            public bool MarkRSSPostasReadOnRead { get; set; }
            public bool ShowTaskbarIcon { get; set; }
            public bool RemovePostFromListAfterRead { get; set; }
            public bool MarkUnreadPostsWithBold { get; set; }
            public bool MarkUnreadPostWithBackgroundColor { get; set; }
            public Color UnreadPostBackgroundColor { get; set; }
            #endregion

            public GUISettings(int mainRSSFormLeftPanelWidthValue = 240, int mainFormLeftTopPanelWidth = 240, int mainFormRightPanelWidth = 260)
            {
                MainRSSFormLeftPanelWidth = mainRSSFormLeftPanelWidthValue;
                MainFormLeftTopPanelWidth = mainFormLeftTopPanelWidth;
                MainFormRightPanelWidth = mainFormRightPanelWidth;
                MarkRSSPostasReadOnRead = false;
                ShowTaskbarIcon = true;
                RemovePostFromListAfterRead = false;
                SetDefaultColumns();
            }

            public void SetDefaultColumns()
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
                string ignorePostContentIncomparison = Reflection.GetPropertyName(((IRSSPost itm) => itm.IgnorePostContentIncomparison));
                string followup = Reflection.GetPropertyName(((IRSSPost itm) => itm.FollowUp));
                string plaintext = Reflection.GetPropertyName(((IRSSPost itm) => itm.PlainTextPostContent ));

                RSSColumnsVisibleStatus = new Dictionary<string, ColumnData>
                                          {
                                              {date,new ColumnData( true,"Publish date")},
                                              {title, new ColumnData( true,"Title")},
                                              {description, new ColumnData( false,"Description")},
                                              {url,  new ColumnData( false,"URL")},
                                              {creator,  new ColumnData( false,"Creator")},
                                              {content,  new ColumnData( false,"Content")},
                                               {read,  new ColumnData( true,"Read")},
                                                {link,  new ColumnData( false,"link")},
                                                {feedname,  new ColumnData( true,"Feed Name")},
                                                {belongstoFeed,  new ColumnData( false,"Belongs to Feed")},
                                                {addeddate,  new ColumnData( false,"Added Date")},
                                                {ignoreThisPost, new ColumnData( false,"Hidden post?")},
                                                {ignorePostContentIncomparison, new ColumnData( false,"Don't keep history")},
                                                {plaintext, new ColumnData( false,"Plain text of post")},
                                                {followup , new ColumnData( false,"For later read?")}

                                          };

            }
        }
        [Serializable]
        public class RSSSettings
        {

            #region Data Members
            private int _interval;
            public int IntervalMinutes
            {
                get { return _interval; }
                set { _interval = value < 2 ? 2 : value; }
            }
            public string FileName
            {
                get
                {
                    return (Location == FileLocations.ForAllUsers) ? Path.Combine(Environment.CurrentDirectory, "RSS Feeds.dat") : Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile),
                                                            @"AppData\local\LB Desktop Aggregator\RSS Feeds.dat"); ;
                }
            }
            public string UserFileName { get; set; }
            public bool SaveRSSFeedsOnEveryRefresh { get; set; }
            public bool NotifyOnRSSErrors { get; set; }
            public bool EnabledRSSReader { get; set; }
            public FileLocations Location { get; set; }
            public bool IncrementalSearch { get; set; }
           #endregion

            #region Ctor
            public RSSSettings(FileLocations location)
            {
                Location = location;
                SaveRSSFeedsOnEveryRefresh = false;
                NotifyOnRSSErrors = true;
                EnabledRSSReader = true;
                IncrementalSearch = false;
                IntervalMinutes = 5;
            }
            #endregion 
        }
        [Serializable]
        public class OutlookSettings
        {
            #region Data Members
            private int _interval;
            public int IntervalMinutes
            {
                get { return _interval; }
                set { _interval = value < 2 ? 2 : value; }
            }
            public bool LaunchOutlookReaderOnStartup { get; set; }
            public bool EnabledOutlookReader { get; set; }
            #endregion 

            #region Ctor
            public OutlookSettings(bool enabledOutlookReader=false,bool launchOnStartup=false)
            {
                LaunchOutlookReaderOnStartup = launchOnStartup;
                EnabledOutlookReader = enabledOutlookReader;
            }
            #endregion 
        }
        #region Data Members
 
        public FileLocations Location { get; set; }
        public string SettingsFilePath
        {
            get
            {
                return (Location == FileLocations.ForAllUsers) ? Path.Combine(Environment.CurrentDirectory, "settings.dat") : Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile),
                                                    @"AppData\local\LB Desktop Aggregator\settings.dat");
            }

        }

        public GUISettings AppGUISettings { get; protected set; }
        public RSSSettings AppRSSSetings { get; protected set; }
        public OutlookSettings AppOutlookSettings { get; protected set; }
        #endregion

        #region Ctor
        public AppSettings()
        {
            Location = FileLocations.ForAllUsers;

            AppGUISettings = new GUISettings();
            AppRSSSetings = new RSSSettings(Location);
        

            AppOutlookSettings = new OutlookSettings(false, false);
            AppOutlookSettings .IntervalMinutes = 2;
        
        }
        #endregion


        #region Methods
        public void SetUserRSSFileName(string filename)
        {
           AppRSSSetings .UserFileName = filename;
        }
        public static AppSettings LoadSettings(bool perUser, bool suppressError = false)
        {
            string settingsfilefullpath = Path.Combine(Environment.CurrentDirectory, "settings.dat");
            if (perUser)
                settingsfilefullpath = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile),
                                                    @"AppData\local\LB Desktop Aggregator\settings.dat");

            BinaryFormatter myformatter = new BinaryFormatter();

            if (File.Exists(settingsfilefullpath))
                try
                {
                    using (Stream myReader = File.Open(settingsfilefullpath, FileMode.Open, FileAccess.Read))
                    {
                        return (AppSettings)myformatter.Deserialize(myReader, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageShow.ShowException("AppSettingsLoader", ex, suppressError);
                    return new AppSettings();

                }
            return new AppSettings();
        }
        public static void SaveSettings(AppSettings settings, bool suppressError = false)
        {
            BinaryFormatter myformatter = new BinaryFormatter();
            string filename = settings.SettingsFilePath;
            string dirpath = System.IO.Path.GetDirectoryName(filename);

            try
            {
                if (dirpath != null && !(Directory.Exists(dirpath)))
                    Directory.CreateDirectory(dirpath);
                using (Stream myWriter = File.Open(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {

                    myformatter.Serialize(myWriter, settings);
                }
            }
            catch (SerializationException ex)
            {
                MessageShow.ShowException("AppSettingsSave", ex, suppressError);
            }

        }
        #endregion
    }
}