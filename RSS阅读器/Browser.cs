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
    public partial class Browser : Form
    {
        private string _url;
        private WebBrowser _browser;

        public string Url
        {
            get => _url;
            set
            {
                _url = value;
                _browser.Url = new Uri(value);
            }
        }


        public Browser()
        {
            InitializeComponent();

            _browser = new WebBrowser();
            this.Controls.Add(_browser);
            _browser.Dock = DockStyle.Fill;
        }
    }
}