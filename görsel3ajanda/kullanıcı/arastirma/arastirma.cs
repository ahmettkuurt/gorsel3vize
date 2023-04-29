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

namespace görsel3ajanda.kullanıcı
{
    public partial class arastirma : Form
    {
        public arastirma()
        {
            InitializeComponent();
        }

        

        private void arastirma_Load(object sender, EventArgs e)
        {
            ChromiumWebBrowser browser = new ChromiumWebBrowser("www.google.com");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
    }
}
