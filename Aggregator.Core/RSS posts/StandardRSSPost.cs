using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


namespace Aggregator.Core
{
    [Serializable]
    public class StandardRSSPost : AbstractRSSPost
    {

        public StandardRSSPost(XContainer post, IRSSFeed feed)
        {
            BelongsToFeed = feed;
            // Get the string properties from the post's element values
            Title = GetElementValue(post, "title");
            Link = GetElementValue(post, "link");
            Url = GetElementValue(post, "guid");
            Description = GetElementValue(post, "description");
            Creator = GetElementValue(post,
                                      "{http://purl.org/dc/elements/1.1/}creator");
            Content = GetElementValue(post,
                                      "{http://purl.org/dc/elements/1.0/modules/content}encoded");

            // The Date property is a nullable DateTime? -- if the pubDate element
            // can't be parsed into a valid date, the Date property is set to null
            DateTime result;
            if (DateTime.TryParse(GetElementValue(post, "pubDate"), out result))
                Date = (DateTime?)result;

            Read = false;
            AddedDate = DateTime.Now;
            IgnorePostContentIncomparison =feed. DontKeepHistory;
        }

        public StandardRSSPost(string title, string url, string link, string description, string creator, string content,
                         DateTime? pubDate, IRSSFeed feed)
        {
            Title = title ?? string.Empty;
            Url = url ?? string.Empty;
            Link = link ?? string.Empty;
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
