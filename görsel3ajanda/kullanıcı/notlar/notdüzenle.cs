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

namespace görsel3ajanda.kullanıcı.notlar
{
    public partial class notdüzenle : Form
    {
        public notdüzenle()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        public string a, b,c;

        private void notdüzenle_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void notdüzenle_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void düzenle_Click(object sender, EventArgs e)
        {
            sqlbaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("update notlar set baslik=@baslik,icerik=@icerik where notID=@id", sqlbaglantisi.connection);


            komut.Parameters.AddWithValue("@icerik", icerik.Text);      
            komut.Parameters.AddWithValue("@baslik", baslik.Text);
            komut.Parameters.AddWithValue("@id", c);

            komut.ExecuteNonQuery();

            komut.Dispose();
            sqlbaglantisi.connection.Close();
            MessageBox.Show("Not Başarıyla Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            not a = new not();
            a.Show();
            this.Hide();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            not n= new not();
            n.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notdüzenle_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void notdüzenle_Load(object sender, EventArgs e)
        {
            baslik.Text = a;
            icerik.Text = b;
            lblis.Text =c;
        }
    }
}
