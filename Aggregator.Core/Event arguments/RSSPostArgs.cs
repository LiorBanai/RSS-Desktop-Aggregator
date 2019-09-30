using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aggregator.Core
{
    public class RSSPostArgs:EventArgs 
    {
        public IRSSPost Post { get; internal set; }
        public RSSPostArgs(IRSSPost post)
        {
            Post = post;
        }
    }
}
