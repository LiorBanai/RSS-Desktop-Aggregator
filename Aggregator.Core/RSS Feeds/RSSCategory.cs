using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Timers;


namespace Aggregator.Core
{
    [Serializable]
    public class RSSCategory : IRSSCategory
    {
        public string CategoryName { get; set; }
        private int minutesToUpdate;
        public int MinutesToUpdate
        {
            get { return minutesToUpdate; }
            set { minutesToUpdate = value ; }
        }
        public int ImageIndex { get; set; }
        public int FeedsCount
        {
            get
            {
                return FeedsInCategory != null ? FeedsInCategory.Count : 0;
            }
        }
        public bool Undeletable { get; set; }
        public List<IRSSFeed> FeedsInCategory { get; private set; }
        [NonSerialized ]
        private Timer CategoryTimer;


        public RSSCategory(string categoryName, int minutesToUpdate=5,ISynchronizeInvoke syncObject=null)
        {
            CategoryName = categoryName;
            this.minutesToUpdate = minutesToUpdate;
            FeedsInCategory = new List<IRSSFeed>();
            CategoryTimer = new Timer(minutesToUpdate);
            CategoryTimer.AutoReset = true;
            CategoryTimer.SynchronizingObject = syncObject;
        }

        public void AddFeed(IRSSFeed feed)
        {
            FeedsInCategory.Add(feed);
            if (!feed.BelongsToCategories.Contains(this))
            {
                feed.BelongsToCategories.Add(this);
            }
        }
        public void RemoveFeed(IRSSFeed feed)
        {
            FeedsInCategory.Remove(feed);
            if (feed.BelongsToCategories .Contains( this))
            feed.RemoveFromCategory(this);
        }  
        }
    }

