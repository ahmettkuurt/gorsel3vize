using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace görsel3ajanda
{
    public partial class yntcgrs : Form
    {
        public yntcgrs()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            SqlCommand koumut = new SqlCommand("select * from yöneticigiris where kadi=@kadi and sifre=@sifre", sqlbaglantisi.connection);
            sqlbaglantisi.CheckConnection();
            koumut.Parameters.AddWithValue("@kadi", kadi.Text);
            koumut.Parameters.AddWithValue("@sifre", sifre.Text);
            SqlDataReader dr = koumut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Hoş Geldiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yntcsayfa syf = new yntcsayfa();
                 syf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            sqlbaglantisi.connection.Close();
        }

        private void yntcgrs_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void yntcgrs_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void yntcgrs_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
