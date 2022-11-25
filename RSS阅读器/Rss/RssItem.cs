using System.Xml;

namespace RssReader.Rss
{
    public class RssItem
    {
        public string Title { get;  }
        public string Link { get;  }
        public string Description { get; }


        public RssItem(XmlNode itemNode)
        {
            Title = itemNode.SelectSingleNode("title").InnerText;
            Link = itemNode.SelectSingleNode("link").InnerText;
            Description = itemNode.SelectSingleNode("description").InnerText;
        }
    }
}