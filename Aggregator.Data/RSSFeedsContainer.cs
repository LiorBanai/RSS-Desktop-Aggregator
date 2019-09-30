using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Aggregator.Core;
using Aggregator.Util;


namespace Aggregator.Data
{
    [Serializable]
    public class RSSFeedsContainer : IDeserializationCallback
    {
        #region Data Members

        //public string Filename { get; set; }
        //   private bool IsFileExist { get { return File.Exists(Filename); } }
        private List<IRSSFeed> Feeds { get; set; }
        public int FeedsCount { get { return (Feeds != null) ? Feeds.Count() : 0; } }
        private BindingList<IRSSCategory> Categories { get; set; }
        public int CategoriesCount { get { return (Categories != null) ? Categories.Count() : 0; } }
        public IRSSFeed this[int id] { get { return Feeds[id]; } }
        [NonSerialized]
        public ReaderWriterLockSlim RssLock = new ReaderWriterLockSlim();
        #endregion

        #region Ctor

        public RSSFeedsContainer()
        {
            Categories = new BindingList<IRSSCategory>();
            Feeds = new List<IRSSFeed>();
            //Filename = string.Empty;
        }

        #endregion

        #region Feeds Methods

        public void AddFeed(IRSSFeed feed)
        {
            RssLock.EnterWriteLock();

            try
            {
                Feeds.Add(feed);
            }
            finally
            {
                RssLock.ExitWriteLock();
            }
        }
        public IRSSFeed RemoveAt(int id)
        {
            RssLock.EnterWriteLock();
            try
            {
                IRSSFeed feed = null;
                if (Feeds.Count() > id)
                {
                    feed = Feeds[id];
                    Feeds.RemoveAt(id);

                }
                return feed;
            }
            finally
            {
                RssLock.ExitWriteLock();
            }
        }
        public IEnumerable<IRSSFeed> GetFeeds()
        {
            if (Feeds == null)
                Feeds = new List<IRSSFeed>(0);
            return Feeds;
        }

        public IEnumerable<IRSSFeed> GetNonDisabledFeeds()
        {
            if (Feeds == null)
                Feeds = new List<IRSSFeed>(0);
            RssLock.EnterReadLock();
            try
            {
                return Feeds.Where(feed => !feed.Disabled).ToList();
            }
            finally { RssLock.ExitReadLock(); }

        }
        public IEnumerable<IRSSPost> GetAllFeedsPostsFromCache(bool unreadOnly)
        {
            RssLock.EnterReadLock();
            try
            {
                var posts = new List<IRSSPost>(0);
                foreach (IRSSFeed rssFeed in Feeds)
                {
                    posts.AddRange(rssFeed.GetAllItemsFromCache(unreadOnly, false));
                }
                return posts;
            }
            finally { RssLock.ExitReadLock(); }
        }
        public IEnumerable<IRSSPost> GetAllFollowUpPosts()
        {
             RssLock.EnterReadLock();
            try
            {
            return (from feed in Feeds
                   from post in feed.GetAllItemsFromCache(false, false)
                   where post.FollowUp
                   select post).ToList();
            }
            finally { RssLock.ExitReadLock(); }
        }
        #endregion

        #region Categories Methods
        public IEnumerable<IRSSCategory> GetCategories()
        {
            foreach (IRSSCategory rssCategory in Categories)
            {
                yield return rssCategory;
            }
        }
        public IRSSCategory GetCategoryAt(int i)
        {
            return Categories[i];
        }
        public void AddCategory(IRSSCategory category)
        {
            if (Categories == null)
                Categories = new BindingList<IRSSCategory>();
            if (Categories.Contains(category))
            {
                var msg = string.Format("The category {0} already exists.", category.CategoryName);
                MessageShow.ShowMessage(this, msg, "Can't add category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Categories.Add(category);
            }
        }
        public void RemoveCategory(IRSSCategory category)
        {
            if (Categories == null)
                Categories = new BindingList<IRSSCategory>();

            if (category.FeedsCount > 0)
            {
                var msg = string.Format("The category {0} has {1} feeds in it. Can't delete the category", category.CategoryName, category.FeedsCount);
                MessageShow.ShowMessage(this, msg, "Can't delete category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Categories.Remove(category);
            }
        }
        public void RemoveFeedFromAllCategories(IRSSFeed feed)
        {
            foreach (IRSSCategory rssCategory in Categories)
            {
                rssCategory.RemoveFeed(feed);
            }

        }

        public void DeleteFeed(IRSSFeed feed)
        {
            RemoveFeedFromAllCategories(feed);
            Feeds.Remove(feed);
        }
        #endregion

        #region Serialization/DeSerialization
        public void SerializeToBinaryFile(string fileName)
        {
            Util.Utils.SerializeToBinaryFile(this, fileName, false);
        }
        public static RSSFeedsContainer DeSerializeBinaryFile(string fileName)
        {
            return Util.Utils.DeSerializeBinaryFile<RSSFeedsContainer>(fileName, false);
        }

        void IDeserializationCallback.OnDeserialization(Object sender)
        {
            RssLock = new ReaderWriterLockSlim();
        }
        #endregion

    }
}
