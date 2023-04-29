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
    public partial class notsil : Form
    {
        public notsil()
        {
            InitializeComponent();
        }
        public string a, b;
        bool move;
        int mouse_x;
        int mouse_y;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            not not = new not();
            not.Show();
            this.Hide();
        }

        private void notsil_Load(object sender, EventArgs e)
        {
            lblid.Text = a;
            lblad.Text = b;
        }

        private void sil_Click(object sender, EventArgs e)
        {
            sqlbaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("delete from notlar where notID=@id", sqlbaglantisi.connection);

            komut.Parameters.AddWithValue("@id", lblid.Text);

            komut.ExecuteNonQuery();
            komut.Dispose();
            sqlbaglantisi.connection.Close();
            not syf = new not();
            MessageBox.Show("Öğrencinin Kaydı Başarıyla Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            syf.Show();
            this.Hide();
            
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            not syf = new not();
            MessageBox.Show("Kayıt Silme İşlemi İptal Edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            syf.Show();
            this.Hide();
        }

        private void notsil_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void notsil_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void notsil_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
