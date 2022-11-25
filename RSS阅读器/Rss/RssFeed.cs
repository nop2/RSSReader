using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RssReader.Rss
{
    public class RssFeed
    {
        private List<RssChannel> _channels;


        public string Uri { get; }
        public IList<RssChannel> Channels => _channels.AsReadOnly();

        public RssChannel MainChannel => _channels[0];

        public RssFeed(string uri)
        {
            Uri = uri;
            Load(uri);
        }


        private void Load(string uri)
        {
            var httpClient = new HttpClient();
            var rssXml = new XmlDocument();
            using var rssStream = httpClient.GetStreamAsync(uri).Result;
            rssXml.Load(rssStream);

            _channels = new List<RssChannel>();
            var rssNode = rssXml.SelectSingleNode("rss");
            var nodes = rssNode.ChildNodes;
            foreach (XmlNode node in nodes)
            {
                var channel = new RssChannel(node);
                _channels.Add(channel);
            }

        }

    }
}
