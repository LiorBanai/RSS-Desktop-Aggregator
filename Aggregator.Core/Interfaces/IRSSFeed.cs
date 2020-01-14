using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Aggregator.Core
{
    
    public interface IRSSFeed
    {
        #region Data Members
        
        string RSSUrl { get; set; }
        string RSSName { get; set; }
        bool Active { get; set; }
        bool Disabled { get; set; }
        bool IsPersonalFeed { get; set; }
        UInt64 TotalDownloadedKB { get; set; }
        UInt32 TotalUpdates { get; set; }
        UInt32 MinutesToUpdate { get; set; }
        int LastDownloadSizeKb { get;   }
        TimeSpan LastDownloadTime { get;   }
        List<IRSSCategory > BelongsToCategories { get; }
        event EventHandler<RSSErrorArgs> RSSReadingError;
        int UnreadItemsCount { get; }
        int ReadItemsCount { get; }
        int TotalItemsCount { get; }
        bool DontKeepHistory { get; set; }
        int LastNewPostsCount { get; }
        List<IRSSPost> LastNewPosts { get; }
        int FeedEncodingCodePage { get; set; }
        Encoding FeedEncoding { get; set; }
        string RSSNameWithCount { get; }
        #endregion
        //Methods
        IEnumerable<IRSSPost> GetAllItemsFromWeb(bool onlyUnreadItems, bool suppressErrorDisplay, bool showHiddenPosts = false);
        IEnumerable<IRSSPost> GetAllItemsFromCache(bool onlyUnreadItems, bool showHiddenPosts = false);
        void ClearFeedPosts();
        void AddToCategory(IRSSCategory category);
        void RemoveFromCategory(IRSSCategory category);
        void ClearCategories();

        void RemovePost(IRSSPost post);


    }
}
