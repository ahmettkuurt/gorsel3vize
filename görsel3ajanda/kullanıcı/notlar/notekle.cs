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
    public partial class notekle : Form
    {
        public notekle()
        {
            InitializeComponent();
        }
        public string a;
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into notlar (baslik,icerik,kllncID)values(@baslik,@icerik,@kllncid)", sqlbaglantisi.connection);

            sqlbaglantisi.CheckConnection();
            komut.Parameters.AddWithValue("@baslik",baslik.Text);
            komut.Parameters.AddWithValue("@icerik",icerik.Text);
            komut.Parameters.AddWithValue("@kllncid",kllncgrs.kid);

            komut.ExecuteNonQuery();
            sqlbaglantisi.connection.Close();

            MessageBox.Show("Notun Başarıyla Eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            baslik.Text = " ";
            icerik.Text = " ";

        }

        private void notekle_Load(object sender, EventArgs e)
        {
            lblis.Text = a;
        }

        private void notekle_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void notekle_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void notekle_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
