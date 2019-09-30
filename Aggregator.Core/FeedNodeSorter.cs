using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aggregator.Core
{
    public class FeedNodeSorter : IComparer
    {
        public int Compare(object x, object y)
        {
            TreeNode thisNode = x as TreeNode;
            TreeNode otherNode = y as TreeNode;

            if (thisNode == null || otherNode == null)
                throw new ArgumentException("Objects are not of type TreeNode");

            IRSSFeed thisFeed = thisNode.Tag as IRSSFeed;
            IRSSFeed otherFeed = otherNode.Tag as IRSSFeed;

         if (thisFeed == null || otherFeed == null)
             throw new ArgumentException("Tree Node Tags are not of type IRSSFeed");

         if (!thisFeed.Disabled  && otherFeed.Disabled)
             return -1;

         if (thisFeed.Disabled && !otherFeed.Disabled)
             return 1;
         if (thisFeed.UnreadItemsCount > otherFeed.UnreadItemsCount)
             return -1;
         if (thisFeed.UnreadItemsCount < otherFeed.UnreadItemsCount)
             return 1;
         return thisFeed.RSSName.CompareTo(otherFeed.RSSName);
        }
    }
}
