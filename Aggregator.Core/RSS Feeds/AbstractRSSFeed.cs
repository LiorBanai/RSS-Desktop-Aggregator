using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Aggregator.Util;

namespace Aggregator.Core
{
    [Serializable]
    public abstract class AbstractRSSFeed : IRSSFeed
    {
        #region Data Members
        #region IRSSFeed Members

        public string RSSUrl { get; set; }
        public string RSSName { get; set; }
        public bool Active { get; set; }
        public bool Disabled { get; set; }
        public bool IsPersonalFeed { get; set; }
        public bool DontKeepHistory { get; set; }
        public UInt64 TotalDownloadedKB { get; set; }
        public UInt32 TotalUpdates { get; set; }
        public UInt32 MinutesToUpdate { get; set; }
        public int LastDownloadSizeKb { get; protected set; }
        public TimeSpan LastDownloadTime { get; protected set; }
        public int UnreadItemsCount
        {
            get
            {
                return RSSItemsList == null ? 0 : RSSItemsList.Count(post => post.Read == false);
            }

        }
        public int ReadItemsCount
        {
            get
            {
                return RSSItemsList == null ? 0 : RSSItemsList.Count(post => post.Read == true);
            }

        }
        public int TotalItemsCount
        {
            get
            {
                return RSSItemsList == null ? 0 : RSSItemsList.Count();
            }

        }
        public int FeedEncodingCodePage { get; set; }
        public Encoding FeedEncoding { get; set; }
        public List<IRSSCategory> BelongsToCategories { get; protected set; }
        public int LastNewPostsCount
        {
            get
            {
                return LastNewPosts == null ? 0 : LastNewPosts.Count();
            }
        }
        public List<IRSSPost> LastNewPosts { get; protected set; }
        public abstract string RSSNameWithCount { get; }
        public event EventHandler<RSSErrorArgs> RSSReadingError = delegate { };
        //public event EventHandler<RSSPostArgs>  RSSPostsReadChanged = delegate { };
        #endregion
        protected List<IRSSPost> RSSItemsList;
        public IRSSPost this[int i]
        {
            get
            {
                if (i < RSSItemsList.Count)
                    return RSSItemsList[i];
                else
                    return null;
            }

        }

        //breaking changes
        //public IEnumerable<IRSSPost> UnreadItems
        //{
        //    get
        //    {
        //        IEnumerable<IRSSPost> items = RSSItemsList ?? new List<IRSSPost>();
        //        return items.Where(itm => !itm.Read);
        //    }
        //}
        [NonSerialized ]
        protected WebClient Client;
        #endregion

        #region Ctor

        protected AbstractRSSFeed(string url, bool isPersonal,bool  dontKeepHistory, Encoding feedEncoding,string feedName, int encodingCode=0)
        {
            TotalDownloadedKB = 0;
            TotalUpdates = 0;
            Active = true;
            RSSName = string.Empty;
            RSSItemsList = new List<IRSSPost>();
            Client = new WebClient();
            BelongsToCategories = new List<IRSSCategory >();
            Client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            

            FeedEncodingCodePage = encodingCode;
            FeedEncoding = feedEncoding;

            Client.Encoding =
                (FeedEncodingCodePage == 0)
                    ? FeedEncoding
                    : Encoding.GetEncoding(FeedEncodingCodePage);
            

            RSSName = string.IsNullOrEmpty(feedName) ? string.Empty : feedName;
            IsPersonalFeed = isPersonal;
            RSSUrl = url;
            DontKeepHistory = dontKeepHistory;
        }
        #endregion

        #region Methods
        #region Getters Methods
        protected abstract List<IRSSPost> RefreshCurrentItems(bool suppressErrorDisplay);
        public virtual IEnumerable<IRSSPost> GetAllItemsFromWeb(bool onlyUnreadItems, bool suppressErrorDisplay, bool showHiddenPosts = false)
        {
            IEnumerable<IRSSPost> items = RefreshCurrentItems(suppressErrorDisplay);
            if (!showHiddenPosts)
                items = items.Where(p => !p.IgnoreThisPost);
           if (onlyUnreadItems)
            {
                items=(from itm in items
                        where itm.Read == false
                        select itm);
            }
           return items.OrderBy(x => (x.Date.HasValue) ? x.Date.Value : DateTime.MinValue).ThenByDescending(x => x.AddedDate).ToList(); 
        }
        public virtual IEnumerable<IRSSPost> GetAllItemsFromCache(bool onlyUnreadItems, bool showHiddenPosts = false)
        {
            IEnumerable<IRSSPost> items = RSSItemsList ?? new List<IRSSPost>();
            if (!showHiddenPosts)
                items = items.Where(p => !p.IgnoreThisPost);
          if (onlyUnreadItems)
            {
                items=(from itm in items
                        where itm.Read == false
                        select itm);
            }
          return items.OrderBy(x => (x.Date.HasValue) ? x.Date.Value : DateTime.MinValue).ThenByDescending(x => x.AddedDate).ToList(); ;
        }
        
        #endregion

        #region Posts Related
        public void ClearFeedPosts()
        {
            lock (this)
            {
                if (RSSItemsList != null)
                    RSSItemsList.Clear();
            }
        }
        public void RemovePost(IRSSPost post)
        {
            var itemsComparer = new FullRSSPostComparer();
            if (RSSItemsList.Contains(post, itemsComparer))
            {

                int pos = RSSItemsList.FindIndex(item => itemsComparer.Equals(item, post));
                if (pos>=0)
                RSSItemsList.RemoveAt(pos);
            }
        }
        #endregion

        #region Categories Related

        public void AddToCategory(IRSSCategory  category)
        {
            if (!BelongsToCategories.Contains(category))
            {
                BelongsToCategories.Add(category);
                category.AddFeed(this);
            }

        }
        public void RemoveFromCategory(IRSSCategory category)
        {
            if (BelongsToCategories.Contains(category))
            {
                BelongsToCategories.Remove(category);
                category.RemoveFeed(this);
            }
        }
        public void ClearCategories()
        {
         throw new NotImplementedException();
            BelongsToCategories = new List<IRSSCategory>();
        }

        #endregion

        protected virtual void OnRSSReadingError(RSSErrorArgs e)
        {
            if (RSSReadingError != null)
            {
                RSSReadingError(this, e);
            }

        }

        //protected virtual void OnRSSPostsReadChanged(object sender , RSSPostArgs e)
        //{
        //    if (RSSPostsReadChanged != null)
        //    {
        //        RSSPostsReadChanged(sender, e);
        //    }

        //}

        //private List<IRSSPost> ReadDocumentPerElement(string rssUrl)
        //{

        //    string XmlFileUrl = rssUrl;
        //    List<IRSSPost> items = new List<IRSSPost>();

        //    XmlReaderSettings settings = new XmlReaderSettings
        //    {
        //        ConformanceLevel = ConformanceLevel.Fragment,
        //        IgnoreWhitespace = true,
        //        IgnoreComments = true
        //    };

        //    using (XmlReader reader = XmlReader.Create(XmlFileUrl, settings))
        //    {

        //        // boolean to see if a node was opened before
        //        bool openItem = false;
        //        string title = "";
        //        string link = "";
        //        string url = "";
        //        string description = "";
        //        string creator = "";
        //        string content = "";
        //        DateTime? date = null;
        //        // Loop the reader, till it cant read anymore
        //        while (reader.Read())
        //        {

        //            // An object with the type Element was found.
        //            if (reader.NodeType == XmlNodeType.Element)
        //            {
        //                // Check name of the node and write the contents in the object accordingly.
        //                if (reader.Name == "item")
        //                {
        //                    openItem = true;
        //                }
        //                try
        //                {

        //                    if (reader.Name == "title" && openItem)
        //                        title = reader.ReadElementContentAsString();
        //                    else if (reader.Name == "url" && openItem)
        //                        url = reader.ReadElementContentAsString();
        //                    else if (reader.Name == "link" && openItem)
        //                        link = reader.ReadElementContentAsString();
        //                    else if (reader.Name == "description" && openItem)
        //                        description = reader.ReadElementContentAsString();
        //                    else if (reader.Name == "creator" && openItem)
        //                        creator = reader.ReadElementContentAsString();
        //                    else if (reader.Name == "content" && openItem)
        //                        content = reader.ReadElementContentAsString();
        //                    else if (reader.Name == "pubDate" && openItem)
        //                    {
        //                        string strdate = reader.ReadElementContentAsString();
        //                        DateTime result;
        //                        if (DateTime.TryParse(strdate, out result))
        //                            date = (DateTime?)result;
        //                    }
        //                }
        //                catch (Exception)
        //                {


        //                }
        //            }
        //            // EndElement was found, check if it is named item, if it is, store the object in the list and set openItem to false.
        //            else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "item" && openItem)
        //            {
        //                openItem = false;
        //                IRSSPost rssitem = new StandardRSSPost(title, url, link, description, creator, content, date, this);
        //                items.Add(rssitem);
        //                title = "";
        //                link = "";
        //                description = "";
        //                creator = "";
        //                content = "";
        //            }
        //        }
        //    }
        //    return items;
        //}

       
        #endregion

    }
}
