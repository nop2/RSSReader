using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RssReader.Rss;

namespace RssReader
{
    public partial class LinksManager : Form
    {
        private DataSet _linkSet;


        public LinksManager()
        {
            InitializeComponent();
            LoadLinks();
        }

        private void LoadLinks()
        {
            _linkSet = RssLinkXMLTool.GetLinkDataSet("RssLinks.xml");
            rssBindingSource.DataSource = _linkSet;
            rssBindingSource.DataMember = _linkSet.Tables[0].TableName;

            linksGridView.DataSource = rssBindingSource;
            linksGridView.AllowUserToAddRows = false;
            linksGridView.Columns["title"].HeaderText = "标题";
            linksGridView.Columns["title"].Width = 160;
            linksGridView.Columns["uri"].HeaderText = "URL";
            linksGridView.Columns["uri"].Width = 200;
            linksGridView.Columns["defaultShow"].HeaderText = "默认显示";
            linksGridView.Columns["defaultShow"].Width = 160;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            RssLinkXMLTool.SaveLinkDataSet(_linkSet, "RssLinks.xml");
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            rssBindingSource.AddNew();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除？", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes)
            {
                rssBindingSource.RemoveCurrent();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}