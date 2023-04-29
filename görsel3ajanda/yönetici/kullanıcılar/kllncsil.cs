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
    public partial class kllncsil : Form
    {
        public kllncsil()
        {
            InitializeComponent();
        }
        public string lbl, lbl1;
        bool move;
        int mouse_x;
        int mouse_y;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kllnclar syf = new kllnclar();
            syf.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            kllnclar syf = new kllnclar();
            MessageBox.Show("Kayıt Silme İşlemi İptal Edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            syf.Show();
            this.Hide();
        }

        private void kllncsil_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void kllncsil_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        
        private void kllncsil_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void kllncsil_Load(object sender, EventArgs e)
        {
            lblad.Text = lbl;
            lblid.Text = lbl1;
        }

        private void sil_Click(object sender, EventArgs e)
        {
            sqlbaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("delete from aktivite where kllncID=@id;delete from notlar where kllncID =@id2;delete from kullanici where kllncID = @id2", sqlbaglantisi.connection);
            
            komut.Parameters.AddWithValue("@id", lblid.Text);
            komut.Parameters.AddWithValue("@id1", lblid.Text);
            komut.Parameters.AddWithValue("@id2", lblid.Text);


              komut.ExecuteNonQuery();
            sqlbaglantisi.connection.Close();
            kllnclar syf = new kllnclar();
            MessageBox.Show("Öğrencinin Kaydı Başarıyla Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            syf.Show();
            this.Hide();
        }
    }
}
