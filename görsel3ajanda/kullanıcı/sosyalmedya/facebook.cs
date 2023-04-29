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

namespace görsel3ajanda.kullanıcı.sosyalmedya
{
    public partial class facebook : Form
    {
        public facebook()
        {
            InitializeComponent();
        }

        

        private void facebook_Load(object sender, EventArgs e)
        {
            ChromiumWebBrowser browser = new ChromiumWebBrowser("www.facebook.com");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
    }
}
