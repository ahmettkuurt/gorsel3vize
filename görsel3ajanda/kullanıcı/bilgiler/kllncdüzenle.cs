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
    public partial class kllncdüzenle : Form
    {
        public kllncdüzenle()
        {
            InitializeComponent();
        }
        public string a;
        bool move;
        int mouse_x;
        int mouse_y;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            kllncsayfa sy = new kllncsayfa();
            sy.Show();
            this.Hide();
        }

        private void kllncdüzenle_Load(object sender, EventArgs e)
        {
            kllnctur.Enabled = false;
            lblid.Text = a;
                 


            SqlCommand komut = new SqlCommand("select * from kullanici where kllncID = @id", sqlbaglantisi.connection);
            komut.Parameters.AddWithValue("@id", lblid.Text);
            sqlbaglantisi.CheckConnection();
            SqlDataReader dr = komut.ExecuteReader();
             if (dr.HasRows)
             {
                while (dr.Read())
                {
                    txtisim.Text = dr["isim"].ToString();
                    txtsoyisim.Text = dr["soyisim"].ToString();
                    txttel.Text = dr["telefon"].ToString();
                    txtkadi.Text = dr["kadi"].ToString();
                    txtsifre.Text = dr["sifre"].ToString();
                    txttc.Text = dr["tc"].ToString();
                    txtadres.Text = dr["adres"].ToString();
                    lblab.Text = dr["turID"].ToString();
                    
                }
             }
            dr.Close();
            sqlbaglantisi.connection.Close();
            //kullanıcı id çekme
            
            SqlDataReader oku;
            object sonuc;
            SqlCommand kllncID_cek = new SqlCommand("SELECT kullanicitürü FROM kullanicitürü where turID='" + Convert.ToInt32(lblab.Text) + "'", sqlbaglantisi.connection);
            sqlbaglantisi.connection.Open();
            sonuc = kllncID_cek.ExecuteScalar();
            if (sonuc != null)
            {
                oku = kllncID_cek.ExecuteReader();
                while (oku.Read())
                {

                    kllnctur.Text = oku.GetString(0);
                }
            }
            sqlbaglantisi.connection.Close();
            //kullanıcı id çekme 

        }

        private void kllncgüncelle_Click(object sender, EventArgs e)
        {
            sqlbaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("update  kullanici set isim=@isim,soyisim=@soyisim,telefon=@tel,kadi=@kadi,sifre=@sifre,tc=@tc,adres=@adres where kllncID=@id", sqlbaglantisi.connection);

            komut.Parameters.AddWithValue("@isim", txtisim.Text);
            komut.Parameters.AddWithValue("@soyisim", txtsoyisim.Text);
            komut.Parameters.AddWithValue("@tel", txttel.Text);
            komut.Parameters.AddWithValue("@kadi", txtkadi.Text);
            komut.Parameters.AddWithValue("@sifre", txtsifre.Text);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@adres", txtadres.Text);
            komut.Parameters.AddWithValue("@id", lblid.Text);

            komut.ExecuteNonQuery();
            sqlbaglantisi.connection.Close();

            kllncsayfa k = new kllncsayfa();
            MessageBox.Show("Kullanıcı Bilgileri Başarıyla Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            k.Show();
            this.Hide();
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
    }
}
