using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace görsel3ajanda.kullanıcı.kitap
{
    public partial class ekitap : Form
    {
        public ekitap()
        {
            InitializeComponent();
        }

        private void ekitap_Load(object sender, EventArgs e)
        {
            ChromiumWebBrowser browser = new ChromiumWebBrowser("www.altkitap.net");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
    }
}
