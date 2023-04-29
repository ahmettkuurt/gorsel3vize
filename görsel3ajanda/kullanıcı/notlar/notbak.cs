using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görsel3ajanda.kullanıcı
{
    public partial class notbak : Form
    {
        public notbak()
        {
            InitializeComponent();
        }
        public string a, b;
        bool move;
        int mouse_x;
        int mouse_y;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            not n = new not();
            n.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notbak_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void notbak_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void notbak_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void notbak_Load(object sender, EventArgs e)
        {
            icerik.Enabled = false;
            baslik.Enabled = false;

            baslik.Text = a;
            icerik.Text = b;
        }
    }
}
