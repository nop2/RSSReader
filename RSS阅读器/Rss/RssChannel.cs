using System.Xml;

namespace RssReader.Rss
{
    public class RssChannel
    {
        private List<RssItem> _items;
        private List<string> _itemTitles;


        public string Title { get; }
        public string Link { get; }
        public string Description { get; }
        public IList<RssItem> Items => _items.AsReadOnly();
        public IList<string> ItemTitles => _itemTitles.AsReadOnly();

        public RssChannel(XmlNode node)
        {
            Title = node.SelectSingleNode("title").InnerText;
            Link = node.SelectSingleNode("link").InnerText;
            Description = node.SelectSingleNode("description").InnerText;

            _items = new List<RssItem>();
            _itemTitles = new List<string>();

            
            var itemNodes = node.SelectNodes("item");
            foreach (XmlNode itemNode in itemNodes)
            {
                var item = new RssItem(itemNode);
                _items.Add(item);
                _itemTitles.Add(item.Title);
            }
        }
    }
}