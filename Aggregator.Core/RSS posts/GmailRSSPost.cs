using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


namespace Aggregator.Core
{
    [Serializable]
    public class GmailRSSPost : AbstractRSSPost
    {

        public GmailRSSPost(XContainer post, IRSSFeed feed)
        {
           
            BelongsToFeed = feed;
            // Get the string properties from the post's element values
            Title = GetElementValue(post, "title");
            Link = GetElementValue(post, "link");
            if (Link == "")
                Link = @"http://mail.google.com/mail/";
            Url = GetElementValue(post, "url");
            Description = GetElementValue(post, "summary");
            Creator = GetElementValue(post, "author");
            Content = GetElementValue(post, "content");

            // The Date property is a nullable DateTime? -- if the pubDate element
            // can't be parsed into a valid date, the Date property is set to null
            DateTime result;
            if (DateTime.TryParse(GetElementValue(post, "modified"), out result))
                Date = (DateTime?)result;

            Read = false;
            AddedDate = DateTime.Now;
            IgnorePostContentIncomparison = feed.DontKeepHistory;
        }

        public GmailRSSPost(string title, string url, string link, string description, string creator, string content,
                         DateTime? pubDate, IRSSFeed feed)
        {
            Title = title ?? string.Empty;
            Url = url ?? string.Empty;
            Link = link ?? @"http://mail.google.com/mail/";
            Description = description ?? string.Empty;
            Creator = creator ?? string.Empty;
            Content = content ?? string.Empty;
            Date = pubDate;
            Read = false;
            BelongsToFeed = feed;
            AddedDate = DateTime.Now;
            IgnorePostContentIncomparison = feed.DontKeepHistory;
        }

        private static string GetElementValue(XContainer element, string name)
        {
            if ((element == null) || (element.Element(name) == null))
                return String.Empty;
            return element.Element(name).Value;
        }


    }
}
