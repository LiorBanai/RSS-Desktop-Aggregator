using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;
using Aggregator.Core;
using System.Xml;
using Aggregator.Util;

namespace Aggregator.Data
{
    [Serializable]
    public class RSSFeed : AbstractRSSFeed
    {
   
        #region Ctor

        public RSSFeed(string url, bool isPersonal, bool dontKeepHistory,Encoding feedEncoding, string feedName = null,  int encodingCode=0)
            : base(url, isPersonal, dontKeepHistory,feedEncoding,feedName,encodingCode)
        { }

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
            lock (this)
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
                        Client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705; .NET CLR 1.1.4322; .NET CLR 2.0.50727)");
                    DateTime  first = DateTime.Now;
                    
                    var xmlData = Client.DownloadString(RSSUrl);
                    DateTime last = DateTime.Now;
                    LastDownloadTime = last.Subtract(first);
                    LastDownloadSizeKb = (System.Text.Encoding.UTF8.GetByteCount(xmlData)) / 1024;
                    TotalDownloadedKB += (UInt64) LastDownloadSizeKb;

                    XDocument XMLDoc = XDocument.Parse(xmlData);
                    List<IRSSPost> newItems = (from post in XMLDoc.Descendants("item")
                                               select new StandardRSSPost(post, this)).ToList<IRSSPost>();

                    if (IsPersonalFeed)
                    {
                        RSSItemsList = null;
                        return newItems;
                        //newItems.OrderByDescending(x => (x.Date.HasValue) ? x.Date.Value : DateTime.MinValue).ThenByDescending(x => x.AddedDate ).ToList();
                    }

                    if (RSSItemsList == null || RSSItemsList.Count() == 0)
                        RSSItemsList = newItems.ToList<IRSSPost>();
                    else
                    {
                     
                        var newdistinctItems = (from newitm in newItems
                                               where !RSSItemsList.Contains(newitm)
                                               select newitm).ToList()  ;

                        var browser = new PostHTMLStripperGenerator( );
 
                        foreach (IRSSPost newdistinctItem in newdistinctItems)
                        {
                            //string HTMLToParse = newdistinctItem.Link + "<br>" + newdistinctItem.Title + "<br>" +
                            //                 newdistinctItem.Description + "<br>" + newdistinctItem.Content +"<br>" +
                            //                 newdistinctItem.Creator;
                            string HTMLToParse = newdistinctItem.Description + "<br>" + newdistinctItem.Content;
                            newdistinctItem.PlainTextPostContent = browser.GetPlainText(HTMLToParse);
                            
                       
                        } 

                        LastNewPosts = newdistinctItems.ToList()  ;
                        ////get all read items
                        //var readitems = (from rssitem in RSSItemsList
                        //                 where rssitem.Read
                        //                 select rssitem).ToList();

                        //if (readitems.Count() > 0) //all were read: set new items to read
                        //    foreach (var newitm in newItems)
                        //    {
                        //        if (readitems.Contains(newitm))
                        //        {
                        //            var olditem = readitems.Find(f => f.Equals(newitm ));
                        //            newitm.Read = true;
                        //            newitm.IgnoreThisPost = olditem.IgnoreThisPost;
                        //        }
                        //    }

                        RSSItemsList.AddRange(LastNewPosts);
                        //RSSItemsList = RSSItemsList.OrderByDescending(x => (x.Date.HasValue) ? x.Date.Value : DateTime.MinValue).ThenByDescending(x => x.AddedDate).ToList();

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
        }

        #endregion
    }
}
