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
    public partial class kllnclar : Form
    {
        public kllnclar()
        {
            InitializeComponent();
        }
            bool move;
            int mouse_x;
            int mouse_y;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            yntcsayfa syf  = new yntcsayfa();
            syf.Show();
            this.Hide();
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kllnclar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select k.kllncID, k.isim, k.soyisim, k.telefon,k.kadi,k.sifre,k.tc, k.adres, kt.kullanicitürü from kullanici k inner join kullanicitürü kt on k.turID = kt.turID", sqlbaglantisi.connection);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds= new DataSet();
            sqlbaglantisi.CheckConnection();
            da.Fill(ds,"kullanici");
            dataGridView1.DataSource= ds.Tables[0];
            sqlbaglantisi.connection.Close();
            
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            kllncdüzenle dzn = new kllncdüzenle();
            dzn.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dzn.b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dzn.c = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dzn.d = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dzn.dd = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dzn.h = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dzn.i = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dzn.j = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dzn.k = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            dzn.Show();
            this.Hide();
        }

        private void kllncarama_TextChanged(object sender, EventArgs e)
        {
            string bul = "Select * from kullanici where isim + +soyisim like '%" + kllncarama.Text + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(bul, sqlbaglantisi.connection);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void sil_Click(object sender, EventArgs e)
        {
            kllncsil sl = new kllncsil();
            sl.lbl = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();
            sl.lbl1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            sl.Show();
            this.Hide();
        }
    }
}
