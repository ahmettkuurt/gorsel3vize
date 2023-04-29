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

namespace görsel3ajanda.kullanıcı
{
    public partial class aktivite : Form
    {
        public aktivite()
        {
            InitializeComponent();
        }
        public string a;
        public string b;
        bool move;
        int mouse_x;
        int mouse_y;

        private void aktivite_Load(object sender, EventArgs e)
        {
            txttarih.Enabled = false;
            txttarih.Text = UserControlDays.static_day + "/"+takvim.static_month+"/" + takvim.static_year;
            lblis.Text = kllncgrs.kid.ToString();

        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into aktivite(tarih,aktivite,kllncID)values(@tarih,@akt,@id)", sqlbaglantisi.connection);
            sqlbaglantisi.CheckConnection();

            komut.Parameters.AddWithValue("@tarih", DateTime.Parse(txttarih.Text));
            komut.Parameters.AddWithValue("@akt",txtaktivite.Text);
            komut.Parameters.AddWithValue("@id",lblis.Text);

            komut.ExecuteNonQuery();

            MessageBox.Show("Başarıyla kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            komut.Dispose();
            sqlbaglantisi.connection.Close();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            takvim t = new takvim();
            t.Show();
            this.Hide();
        }

        private void aktivite_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void aktivite_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void aktivite_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
