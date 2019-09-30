using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Xml.Linq;
using Aggregator.Core;
using Aggregator.Util;

namespace Aggregator.Data
{
    [Serializable ]
   public class GmailRSSFeed : AbstractRSSFeed 
    {
        #region Data Members
   
        private string UserName { get; set; }
        private string Password { get; set; }
        private string Domain { get; set; }
        
        #endregion

        #region Ctor


        public GmailRSSFeed(string url, bool isPersonal, bool dontKeepHistory, string userName, string password, string domain, Encoding feedEncoding , string feedName,int encodingCode=0)
            : base(url, isPersonal, dontKeepHistory, feedEncoding, feedName, encodingCode)
        {
            UserName = userName;
            Password = password;
            Domain = domain;
          
        }

        #endregion

        #region Methods

       
        public override string RSSNameWithCount
        {
            get { string name = RSSName;
                   if (UnreadItemsCount >0)
                       name += string.Format(" ({0})", UnreadItemsCount);
                return name;

            }
        
        
        }

        protected override List<IRSSPost> RefreshCurrentItems(bool suppressErrorDisplay)
        {
            TotalUpdates++;
            try
            {
                //should be remove later on
                if (FeedEncoding == null) FeedEncoding = Encoding.UTF8;
                if (Client == null)
                {
                    Client = new WebClient
                    {
                        Encoding =
                            (FeedEncodingCodePage == 0)
                                ? FeedEncoding
                                : Encoding.GetEncoding(FeedEncodingCodePage)
                    };
                }
                if (Client.Headers.Count == 0)
                    Client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                if (Client.Credentials == null)
                    Client.Credentials  = new NetworkCredential( UserName ,Password ,Domain );
               
                DateTime first = DateTime.Now;
                var xmlData = Client.DownloadString(RSSUrl);
                DateTime last = DateTime.Now;
                LastDownloadTime = last.Subtract(first);
                              LastDownloadSizeKb = (System.Text.Encoding.UTF8.GetByteCount(xmlData)) / 1024;
                TotalDownloadedKB += (UInt64)LastDownloadSizeKb;
                
                xmlData = xmlData.Replace(@"<feed version=""0.3"" xmlns=""http://purl.org/atom/ns#"">", "<feed>");

  
                
                XDocument XMLDoc = XDocument.Parse(xmlData);
                List<GmailRSSPost> newItems = (from post in XMLDoc.Descendants("entry")
                                               select new GmailRSSPost(post, this)).ToList();

                if (IsPersonalFeed)
                {
                    RSSItemsList = null;
                    return newItems.OrderByDescending(x => (x.Date.HasValue) ? x.Date.Value : DateTime.MinValue).ToList<IRSSPost >();
                }

                if (RSSItemsList == null || RSSItemsList.Count() == 0)
                    RSSItemsList = newItems.ToList<IRSSPost>();
                else
                {

                    var newdistinctItems = (from newitm in newItems
                                            where !RSSItemsList.Contains(newitm)
                                            select newitm).ToList() ;

                    var browser = new PostHTMLStripperGenerator();

                    foreach (IRSSPost newdistinctItem in newdistinctItems)
                    {
                        //string HTMLToParse = newdistinctItem.Link + "<br>" + newdistinctItem.Title + "<br>" +
                        //                 newdistinctItem.Description + "<br>" + newdistinctItem.Content +"<br>" +
                        //                 newdistinctItem.Creator;
                        string HTMLToParse = newdistinctItem.Description + "<br>" + newdistinctItem.Content;
                        newdistinctItem.PlainTextPostContent = browser.GetPlainText(HTMLToParse);


                    } 

                    LastNewPosts = new List<IRSSPost>(newdistinctItems.ToList < GmailRSSPost>());
                    ////get all read items
                    //var readitems = (from rssitem in RSSItemsList
                    //                 where rssitem.Read
                    //                 select rssitem).ToList();

                    //if (readitems.Count() > 0) //all were read: set new items to read
                    //    foreach (var newitm in newItems)
                    //    {
                    //        if (readitems.Contains(newitm))
                    //            newitm.Read = true;
                    //    }
                    RSSItemsList.AddRange(LastNewPosts);
                    RSSItemsList = RSSItemsList.OrderByDescending(x => (x.Date.HasValue) ? x.Date.Value : DateTime.MinValue).ToList();

                }

            }
            catch (Exception ex)
            {
                var exc = new ApplicationException("Feed Name: " + this.RSSName + " Feed URL: " + this.RSSUrl, ex);
                OnRSSReadingError(new RSSErrorArgs(exc));
                MessageShow.ShowException(this, exc, suppressErrorDisplay);

            }
            return RSSItemsList;
        }
       
        #endregion
    }
}
