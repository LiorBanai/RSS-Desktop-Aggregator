using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aggregator.Util;
using FBReader.Core.Interfaces;

namespace Aggregator.Core
{
    [Serializable ]
    public abstract class AbstractRSSPost : IRSSPost
    {
        public  DateTime? Date { get; protected set; }
        public string Title { get; protected set; }
        public string Description { get; protected set; }
        public string Url { get; set; }
        public string Creator { get; set; }
        public string Content { get; set; }
        private bool read;
        public bool Read
        {
            get { return read; }
            set
            {
                read = value;
               // OnRSSPostReadingChanged(new RSSPostArgs(this));
            }
        }
        public string Link { get; set; }
        public string FeedName{get
            {
                if (BelongsToFeed == null) return string.Empty;
                return BelongsToFeed.RSSName;
            }}
        public IRSSFeed BelongsToFeed { get; protected set; }
        public DateTime AddedDate { get; protected set; }
        public bool IgnoreThisPost { get; set; }
        public bool IgnorePostContentIncomparison { get; set; }
        public bool FollowUp { get; set; }
        public string PlainTextPostContent { get;  set; }
        //  public  event EventHandler<RSSPostArgs> RSSPostReadingChanged = delegate { };
        public bool DisplayedInSystemNotification { get; set; }
       public byte ShowedInPopupCount { get; set; }
        #region AbsractRSSPost Methods

        public void DeleteThisPost()
        {
            try
            {
                BelongsToFeed .RemovePost(this);
            }
            catch (Exception ex )
            {
                MessageShow.ShowException(this, ex, false);
            }
        }

        #endregion
       
        #region Object Methods

        public override string ToString()
        {
            return String.Format("{0} by {1}", Title ?? "no title", Creator ?? "Unknown");
        }


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType().BaseType  != typeof(AbstractRSSPost )) return false;
            return Equals((AbstractRSSPost) obj);
        }

        public bool Equals(AbstractRSSPost other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

           bool contentComparison = (IgnorePostContentIncomparison) || (Equals(other.Content, Content) && Equals(other.Description, Description));
           return other.Date.Equals(Date) && Equals(other.Title, Title) &&
                   Equals(other.Url, Url) && Equals(other.Link, Link) && Equals(other.Creator, Creator) && contentComparison;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = (Date.HasValue ? Date.Value.GetHashCode() : 0);
                result = (result * 397) ^ (Title != null ? Title.GetHashCode() : 0);
                
                result = (result * 397) ^ (Url != null ? Url.GetHashCode() : 0);
                result = (result * 397) ^ (Link != null ? Link.GetHashCode() : 0);
                result = (result * 397) ^ (Creator != null ? Creator.GetHashCode() : 0);

                if (!IgnorePostContentIncomparison)
                {
                    result = (result * 397) ^ (Description != null ? Description.GetHashCode() : 0);
                    result = (result * 397) ^ (Content != null ? Content.GetHashCode() : 0);
                }
                return result;
            }
        } 
        #endregion

        //protected virtual void OnRSSPostReadingChanged(RSSPostArgs e)
        //{
        //    if (RSSPostReadingChanged != null)
        //    {
        //        RSSPostReadingChanged(this, e);
        //    }

        //}
  }
    }

