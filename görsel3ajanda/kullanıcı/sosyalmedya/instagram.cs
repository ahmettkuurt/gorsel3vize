using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görsel3ajanda.kullanıcı.sosyalmedya
{
    public partial class instagram : Form
    {
        public instagram()
        {
            InitializeComponent();
        }

        



        private void instagram_Load(object sender, EventArgs e)
        {
            
            ChromiumWebBrowser browser = new ChromiumWebBrowser("www.instagram.com");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

            
        }
    }
}
