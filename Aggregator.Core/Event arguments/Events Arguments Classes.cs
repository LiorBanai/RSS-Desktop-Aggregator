using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aggregator.Core
{
    public class Args : EventArgs
    {

        public Args()
        {

        }

    }
    public class LogArgs : EventArgs
    {
        public string Message { get; protected set; }
        public LogArgs(string message)
        {
            Message = message;
        }

    }
    public class RefreshArgs : EventArgs
    {
        public IEnumerable<IRSSPost> Feeds { get; protected set; }
        public RefreshArgs(IEnumerable<IRSSPost> feeds)
        {
            Feeds = feeds;
        }

    }
    public class FeedArgs : EventArgs
    {
        public IRSSFeed Feed { get; internal set; }
        public bool IsNewFeed { get; internal set; }
        public FeedArgs(IRSSFeed feed, bool newfeed)
        {
            this.Feed = feed;
            IsNewFeed = newfeed;
        }

    }
    public class RSSErrorArgs : EventArgs
    {

        public string Message { get; internal set; }
        public Exception RSSException { get; internal set; }
        public RSSErrorArgs(Exception ex)
        {
            this.RSSException = ex;
            this.Message = ex.Message;
        }

    }
    public class RSSArgs : EventArgs
    {
        public IRSSPost Post { get; internal set; }
        public RSSArgs(IRSSPost rssitem)
        {
            this.Post = rssitem;
        }

    }
}
