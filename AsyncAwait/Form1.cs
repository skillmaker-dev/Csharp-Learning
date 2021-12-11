using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Htmlbox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Download_Click(object sender, EventArgs e)
        {
            var html = await DownloadHtmlAsync("https://cloudconvert.com/");
            Htmlbox.Text = html;
        }

        public async Task<string> DownloadHtmlAsync(string url)
        {
            var webclient = new WebClient();
            return await webclient.DownloadStringTaskAsync(url);
        }
    }
}
