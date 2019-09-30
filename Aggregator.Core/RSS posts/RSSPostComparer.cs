using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aggregator.Core
{
    public class FullRSSPostComparer : IEqualityComparer<IRSSPost>
    {

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType().BaseType != typeof (AbstractRSSPost)) return false;
            return Equals((AbstractRSSPost) obj);
        }

        public bool Equals(IRSSPost x, IRSSPost y)
        {
            if (x == null || y == null)
                return x == y;

            return x.Date.Equals(y.Date) && x.Title.Equals(y.Title) &&
                   x.Url.Equals(y.Url) && x.Link.Equals(y.Link) && x.Creator.Equals(y.Creator) &&
                   (x.Content.Equals(y.Content) && x.Description.Equals(y.Description));
        }

        public int GetHashCode(IRSSPost obj)
        {
            if (obj == null)
                throw new ArgumentNullException();

            unchecked
            {
                int result = (obj.Date.HasValue ? obj.Date.Value.GetHashCode() : 0);
                result = (result*397) ^ (obj.Title != null ? obj.Title.GetHashCode() : 0);

                result = (result*397) ^ (obj.Url != null ? obj.Url.GetHashCode() : 0);
                result = (result*397) ^ (obj.Link != null ? obj.Link.GetHashCode() : 0);
                result = (result*397) ^ (obj.Creator != null ? obj.Creator.GetHashCode() : 0);

                result = (result*397) ^ (obj.Description != null ? obj.Description.GetHashCode() : 0);
                result = (result*397) ^ (obj.Content != null ? obj.Content.GetHashCode() : 0);

                return result;
            }
        }
    }
}
