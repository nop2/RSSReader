using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace RssReader.Rss
{
    /// <summary>
    /// 用于处理RssLink的静态工具类
    /// </summary>
    public static class RssLinkXMLTool
    {
        /// <summary>
        /// 读取文件中所有Rss订阅节点信息
        /// </summary>
        /// <param name="fileName">XML文件路径</param>
        /// <returns>RSS订阅列表</returns>
        public static List<RssLink> GetLinkList(string fileName)
        {
            var doc = new XmlDocument();
            doc.Load(fileName);

            var rootNode = doc.SelectSingleNode("links");
            var linkNodes = rootNode.ChildNodes;

            var links = (from XmlNode linkNode in linkNodes
                let title = linkNode.SelectSingleNode("title").InnerText
                let uri = linkNode.SelectSingleNode("uri").InnerText
                let defaultShow = bool.Parse(linkNode.SelectSingleNode("defaultShow").InnerText)
                select new RssLink(title, uri, defaultShow)).ToList();

            return links;
        }

        /// <summary>
        /// 读取文件中Rss订阅信息，并封装为DataSet
        /// </summary>
        /// <param name="fileName">XML文件路径</param>
        /// <returns>RSS订阅数据表</returns>
        public static DataSet GetLinkDataSet(string fileName)
        {
            var linkDataSet = new DataSet("links");
            linkDataSet.Tables.Add("link");
            linkDataSet.Tables["link"]?.Columns.Add("title", typeof(string));
            linkDataSet.Tables["link"]?.Columns.Add("uri", typeof(string));
            linkDataSet.Tables["link"]?.Columns.Add("defaultShow", typeof(bool));
            // 使用dataset的方法读取XML文件
            linkDataSet.ReadXml(fileName, XmlReadMode.IgnoreSchema);
            return linkDataSet;
        }

        /// <summary>
        /// 保存订阅到XML文件
        /// </summary>
        /// <param name="linkDataSet">数据表</param>
        /// <param name="path">文件名</param>
        public static void SaveLinkDataSet(DataSet linkDataSet, string path)
        {
            linkDataSet.WriteXml(path);
        }

        /// <summary>
        /// 判断一个RSS文档的路径是否存在于XML文件中
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static bool IsLinkExist(string fileName,string uri)
        {
            var doc = new XPathDocument(fileName);
            var navigator = doc.CreateNavigator();

            // 为定位和编辑XML数据提供游标模型
            var it = navigator.Select($"/links/link[uri='{uri}']");

            return it.Count != 0;
        }

        /// <summary>
        /// 向Rss订阅文件中添加一条记录并保存
        /// </summary>
        /// <param name="fileName">Rss XML文件</param>
        /// <param name="link">要添加的记录</param>
        public static void AddLink(string fileName, RssLink link)
        {
            var doc = new XmlDocument();
            doc.Load(fileName);

            XmlNode rootNode = doc.SelectSingleNode("links");
            XmlNode linkNode = doc.CreateElement("link");

            XmlNode titleNode = doc.CreateElement("title");
            XmlText titleText = doc.CreateTextNode(link.Title);
            titleNode.AppendChild(titleText);

            XmlNode uriNode = doc.CreateElement("uri");
            XmlText uriText = doc.CreateTextNode(link.Uri);
            uriNode.AppendChild(uriText);

            XmlNode defaultShowNode = doc.CreateElement("defaultShow");
            XmlText defaultShowText = doc.CreateTextNode(link.DefaultShow.ToString().ToLower());
            defaultShowNode.AppendChild(defaultShowText);

            linkNode.AppendChild(titleNode);
            linkNode.AppendChild(uriNode);
            linkNode.AppendChild(defaultShowNode);

            rootNode.AppendChild(linkNode);

            doc.Save(fileName);
        }
    }
}