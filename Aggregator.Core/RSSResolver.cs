using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Aggregator.Core
{
    class RSSResolver : System.Xml.XmlResolver
    {
        public override Uri ResolveUri(Uri baseUri, string relativeUri)
        {
            return baseUri;
        }
        public override object GetEntity(Uri absoluteUri, string role, Type type)
        {
            return null;
        }
        public override ICredentials Credentials
        {
            set
            {
            }
        }
    }
}
