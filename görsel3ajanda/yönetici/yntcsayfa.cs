using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using görsel3ajanda.yönetici;

namespace görsel3ajanda
{
    public partial class yntcsayfa : Form
    {
        public yntcsayfa()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            MessageBox.Show("Oturum kapatıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm.Show();
            this.Hide();
        }

        private void kllncekle_Click(object sender, EventArgs e)
        {
            klnccekle a = new klnccekle ();
            a.Show();
            this.Hide();
        }

        private void kllncılar_Click(object sender, EventArgs e)
        {
            kllnclar sd = new kllnclar ();  
            sd.Show();
            this.Hide ();
        }

        private void yntcsayfa_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void yntcsayfa_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void yntcsayfa_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
