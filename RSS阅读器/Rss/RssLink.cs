using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.Rss
{
    /// <summary>
    /// 用于保存用户喜欢的Rss信息
    /// </summary>
    public class RssLink
    {
        public string Title { get; set; }

        public string Uri { get; set; }

        public bool DefaultShow { get; set; }

        public RssLink(string title, string uri, bool defaultShow)
        {
            Title = title;
            Uri = uri;
            DefaultShow = defaultShow;
        }
    }
}
