using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FBReader.Core.Interfaces;

namespace Aggregator.Core
{
    public interface IRSSPost : IDisplayedInSystemNotification
    {
        DateTime? Date { get; }
        string Title { get;  }
        string Description { get;   }
         string Url { get; set; }
         string Creator { get; set; }
         string Content { get; set; }
         bool Read { get; set; }
         string Link { get; set; }
        string FeedName { get; }
        IRSSFeed BelongsToFeed { get; }
         DateTime AddedDate { get;   }
         bool IgnoreThisPost { get; set; }
         bool IgnorePostContentIncomparison { get; set; }
         bool FollowUp { get; set; }
         string PlainTextPostContent { get; set; }
        //  event EventHandler<RSSPostArgs> RSSPostReadingChanged;
         

        void DeleteThisPost();
    }
}
