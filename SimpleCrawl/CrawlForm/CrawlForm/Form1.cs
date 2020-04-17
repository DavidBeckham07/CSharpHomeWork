using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlForm
{

    public partial class Form1 : Form
    {
        private Crawl crawler = new Crawl();
        public Form1()
        {
            InitializeComponent();
            crawler.PageDownLoaded += Crawler_PageDownloaded;
            
        }

        private void Crawler_PageDownloaded(String url)
        {
            if (this.listBoxCrawl.InvokeRequired)
            {
                Action<String> action = this.AddUrl;
                this.Invoke(action, new object[] { url });
            }
            else
            {
                AddUrl(url);
            }
        }

        private void AddUrl(string url)
        {
            listBoxCrawl.Items.Add(url);
        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            crawler.starUrl = textBoxStartUrl.Text;
            listBoxCrawl.Items.Clear();
            new Thread(crawler.relativeCraw).Start();
        }
    }
}
