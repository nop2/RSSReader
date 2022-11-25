using RssReader;
using RssReader.Rss;

namespace RSS阅读器
{
    public partial class MainForm : Form
    {
        // rss文档
        private RssFeed _feed;

        // item列表
        private IList<RssItem> _items;


        public MainForm()
        {
            InitializeComponent();
            InitRssItems();
            timer1.Tick += (_, _) => { timeToolStripStatusLabel.Text = DateTime.Now.ToLongTimeString(); };
            KeyPreview = true;
        }


        /// <summary>
        /// 从文件中读取RSS订阅信息，并展示在树形列表中
        /// </summary>
        private void InitRssItems()
        {
            RssTreeView.Nodes.Clear();
            var rssLinks = RssLinkXMLTool.GetLinkList("RssLinks.xml");
            foreach (var rssLink in rssLinks.Where(rssLink => rssLink.DefaultShow))
            {
                AddRssLinkNode(rssLink.Title, rssLink.Uri);
            }
        }

        /// <summary>
        /// 向RSS链接树形列表添加节点
        /// </summary>
        /// <param name="title"></param>
        /// <param name="url"></param>
        private void AddRssLinkNode(string title, string url)
        {
            var node = new TreeNode { Text = title, Tag = url };
            RssTreeView.Nodes.Add(node);
        }

        /// <summary>
        /// 点击RSS导航栏事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RssTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var oldCCursor = Cursor;
            Cursor = Cursors.WaitCursor;

            var url = (string)RssTreeView.SelectedNode.Tag;
            _feed = new RssFeed(url);
            _items = _feed.MainChannel.Items;

            RssListView.Items.Clear();
            foreach (var rssItem in _items)
            {
                RssListView.Items.Add(new ListViewItem(
                    new[]
                    {
                        rssItem.Title, rssItem.Description[..Math.Min(50, rssItem.Description.Length)], rssItem.Link
                    }));
            }

            Cursor = oldCCursor;
        }

        /// <summary>
        /// 双击列表中的选项打开浏览器窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RssListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = RssListView.SelectedIndices[0];
            var tabPage = new TabPage();
            var title = _feed.MainChannel.Items[index].Title;
            tabPage.Text = $"{title[..Math.Min(title.Length - 1, 10)]}...";
            rssToolStripStatusLabel.Text = title;

            var browserForm = new WebBrowser();
            browserForm.Dock = DockStyle.Fill;
            browserForm.Url = new Uri(_feed.MainChannel.Items[index].Link);
            tabPage.Controls.Add(browserForm);

            linkTabControl.TabPages.Add(tabPage);
            linkTabControl.SelectedTab = tabPage;

            if (splitContainer2.Panel2Collapsed)
            {
                splitContainer2.Panel2Collapsed = false;
                rssToolStripStatusLabel.Text = string.Empty;
            }
        }

        /// <summary>
        /// 打开前一个RSS订阅源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbPrevious_Click(object sender, EventArgs e)
        {
            if (RssTreeView.SelectedNode.PrevNode != null)
            {
                RssTreeView.SelectedNode = RssTreeView.SelectedNode.PrevNode;
            }
        }

        /// <summary>
        /// 打开后一个RSS订阅源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbNext_Click(object sender, EventArgs e)
        {
            if (RssTreeView.SelectedNode.NextNode != null)
            {
                RssTreeView.SelectedNode = RssTreeView.SelectedNode.NextNode;
            }
        }

        /// <summary>
        /// 刷新订阅源列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            InitRssItems();
        }

        /// <summary>
        /// 添加订阅源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            var addFeed = new AddFeed();
            addFeed.ShowDialog();
            var url = addFeed.Url;
            if (url == string.Empty) return;
            var feed = new RssFeed(url);
            RssLinkXMLTool.AddLink("RssLinks.xml", new RssLink(feed.MainChannel.Title, url, true));
            InitRssItems();
        }

        /// <summary>
        /// 管理订阅源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbLink_Click(object sender, EventArgs e)
        {
            var linkManger = new LinksManager();
            linkManger.ShowDialog();
        }

        /// <summary>
        /// 展开、关闭rss订阅源列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbRssList_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
        }

        /// <summary>
        /// 关闭选项卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkTabControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            linkTabControl.TabPages.Remove(linkTabControl.SelectedTab);
            if (linkTabControl.TabPages.Count == 0)
            {
                splitContainer2.Panel2Collapsed = true;
            }
        }


        #region Menu

        private void 链接管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LinksManager().ShowDialog();
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 新增频道ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tsbAdd_Click(null, null);
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbRefresh_Click(null, null);
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        #endregion


        private void 刷新ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tsbRefresh_Click(null, null);
        }

        private void 新增频道ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tsbAdd_Click(null, null);
        }

        private void RssListView_MouseMove(object sender, MouseEventArgs e)
        {
            var item = RssListView.GetItemAt(e.Location.X, e.Location.Y);
            if (item != null)
            {
                rssToolStripStatusLabel.Text = item.Text;
            }
        }

        private void RssTreeView_DoubleClick(object sender, EventArgs e)
        {
            tsbLink_Click(null, null);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L && e.Modifiers == Keys.Control)
            {
                tsbLink_Click(null, null);
            }
        }
    }
}