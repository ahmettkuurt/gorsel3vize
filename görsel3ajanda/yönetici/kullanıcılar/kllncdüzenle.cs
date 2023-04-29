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

namespace görsel3ajanda.yönetici
{
    public partial class kllncdüzenle : Form
    {
        public kllncdüzenle()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        public string a, b, c, d, dd, h, i, j,k;

        private void kllncgüncelle_Click(object sender, EventArgs e)
        {
            sqlbaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("update  kullanici set isim=@isim,soyisim=@soyisim,telefon=@tel,tc=@tc,adres=@adres where kllncID=@id", sqlbaglantisi.connection);

            komut.Parameters.AddWithValue("@isim",txtisim.Text);
            komut.Parameters.AddWithValue("@soyisim",txtsoyisim.Text);
            komut.Parameters.AddWithValue("@tel",txttel.Text);
            komut.Parameters.AddWithValue("@tc",txttc.Text);
            komut.Parameters.AddWithValue("@adres",txtadres.Text);
            komut.Parameters.AddWithValue("@id",lblid.Text);

            komut.ExecuteNonQuery();
            sqlbaglantisi.connection.Close();

            kllnclar k = new kllnclar();
            MessageBox.Show("Kullanıcı Bilgileri Başarıyla Güncellendi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            k.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            kllnclar k = new kllnclar();
            k.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kllncdüzenle_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void kllncdüzenle_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void kllncdüzenle_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void kllncdüzenle_Load(object sender, EventArgs e)
        {
            txtkadi.Enabled = false;
            txtsifre.Enabled = false;
            kllnctur.Enabled = false;   

            lblid.Text = a;
            txtisim.Text = b;
            txtsoyisim.Text = c;
            txttel.Text = d;
            txtkadi.Text = dd;
            txtsifre.Text = h;
            txttc.Text = i;
            txtadres.Text = j;
            kllnctur.Text = k;
        }
    }
}
