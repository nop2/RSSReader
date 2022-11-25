using Microsoft.VisualStudio.TestTools.UnitTesting;
using RssReader.Rss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RssReader.Rss.Tests
{
    [TestClass]
    public class RssFeedTests
    {
        [TestMethod]
        public void RssFeedTest()
        {
            var rssFeeder = new RssFeed("https://www.ithome.com/rss/");
            Console.WriteLine(rssFeeder.Channels.Count);
            foreach (var rssFeederChannel in rssFeeder.Channels)
            {
                Console.WriteLine(rssFeederChannel.Description);
                foreach (var item in rssFeederChannel.Items)
                {
                    Console.WriteLine(item.Title);
                    Console.WriteLine(item.Description);
                }
            }
        }

        [TestMethod]
        public void RssLinkToolTest()
        {
            var path = @"D:\code\C#\RSS阅读器\RSS阅读器\bin\Debug\net7.0-windows\RssLinks.xml";

            var links = RssLinkXMLTool.GetLinkList(path);
            links.ForEach(i => Console.WriteLine($@"{i.Title}: {i.Uri}"));

            var linkSet = RssLinkXMLTool.GetLinkDataSet(path);
            Console.WriteLine(linkSet.Tables["link"]?.Rows.Count);

            Console.WriteLine(RssLinkXMLTool.IsLinkExist(path, "https://zhihu.com/rss"));

            // RssLinkXMLTool.AddLink(path, new RssLink("豆瓣书评", "https://www.douban.com/feed/review/book", true));
        }

        [TestMethod]
        public void BrowserTest()
        {
            Browser browser = new Browser();
            browser.Show();
        }
    }
}