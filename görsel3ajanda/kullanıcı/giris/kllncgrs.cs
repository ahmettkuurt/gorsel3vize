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
using görsel3ajanda.kullanıcı;

namespace görsel3ajanda
{
    public partial class kllncgrs : Form
    {
        public kllncgrs()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        public static int kid;

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
            SqlCommand koumut = new SqlCommand("select k.kllncID from kullanici as k where k.kadi like '" + kadi.Text + "' and k.sifre like " + sifre.Text,sqlbaglantisi.connection);
            sqlbaglantisi.CheckConnection();
            
            kid = Convert.ToInt32(koumut.ExecuteScalar());
            SqlDataReader dr = koumut.ExecuteReader();
            if (dr.Read())
            {
                
                MessageBox.Show("Hoş Geldin  " + kadi.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kllncsayfa aa = new kllncsayfa();
                aa.a = kid.ToString(); 
                dr.Close();
                aa.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dr.Close();
            sqlbaglantisi.connection.Close();
            

            
            
        }

        private void kllncgrs_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void kllncgrs_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void kllncgrs_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            klnccekle kl = new klnccekle();
            kl.Show();
            this.Hide();
        }
    }
}
