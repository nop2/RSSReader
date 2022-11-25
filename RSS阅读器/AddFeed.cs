using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssReader
{
    public partial class AddFeed : Form
    {
        public string Url { get; private set; } = string.Empty;

        public AddFeed()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Url = textUrl.Text;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textUrl_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = textUrl.Text.Length != 0;
        }
    }
}