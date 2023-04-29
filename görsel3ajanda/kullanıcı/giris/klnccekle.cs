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

namespace görsel3ajanda.kullanıcı
{
    public partial class klnccekle : Form
    {
        public klnccekle()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            kllncgrs sr = new kllncgrs();
            sr.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kllncekle_Click(object sender, EventArgs e)
        {
            //kullanıcı id çekme
            string kullanicitür;
            int turID = 0;
            kullanicitür = kllnctur.SelectedItem.ToString();
            SqlDataReader oku;
            object sonuc;
            SqlCommand kllncID_cek = new SqlCommand("SELECT turID FROM kullanicitürü where kullanicitürü='" + kullanicitür + "'", sqlbaglantisi.connection);
            sqlbaglantisi.connection.Open();
            sonuc = kllncID_cek.ExecuteScalar();
            if (sonuc != null)
            {
                oku = kllncID_cek.ExecuteReader();
                while (oku.Read())
                {
                    turID = int.Parse(oku[0].ToString());
                }
            }
            
            sqlbaglantisi.connection.Close();
            //kullanıcı id çekme       

            sqlbaglantisi.CheckConnection();
            SqlCommand komutt = new SqlCommand("INSERT INTO kullanici  (isim,soyisim,telefon,kadi,sifre,tc,adres,turID) VALUES (@isim,@soyisim,@tel,@kadi,@sifre,@tc,@adres,@tur)", sqlbaglantisi.connection);

            komutt.Parameters.AddWithValue("@isim", txtisim.Text);
            komutt.Parameters.AddWithValue("@soyisim", txtsoyisim.Text);
            komutt.Parameters.AddWithValue("@tel", txttel.Text);
            komutt.Parameters.AddWithValue("@kadi", txtkadi.Text);
            komutt.Parameters.AddWithValue("@sifre", txtsifre.Text);
            komutt.Parameters.AddWithValue("@tc", txttc.Text);
            komutt.Parameters.AddWithValue("@adres", txtadres.Text);
            komutt.Parameters.AddWithValue("@tur", turID.ToString());

            komutt.ExecuteNonQuery();
            sqlbaglantisi.connection.Close();

            MessageBox.Show("Kullanıcı Başarıyla Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtisim.Text = "";
            txtsoyisim.Text = "";
            txttel.Text = "";
            txtkadi.Text = "";
            txtsifre.Text = "";
            txttc.Text = "";
            txtadres.Text = "";
            kllnctur.Items.Clear();
        }

        private void klnccekle_Load(object sender, EventArgs e)
        {
            sqlbaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("select kullanicitürü from kullanicitürü", sqlbaglantisi.connection);
            SqlDataReader dd = komut.ExecuteReader();
            while (dd.Read())
            {
                kllnctur.Items.Add(dd.GetString(0));
            }
            sqlbaglantisi.connection.Close();
        }

        private void klnccekle_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void klnccekle_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void klnccekle_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
