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
using görsel3ajanda.kullanıcı.notlar;


namespace görsel3ajanda.kullanıcı
{
    public partial class  not: Form
    {
        public not()
        {
            InitializeComponent();
        }
        public string a;
        bool move;
        int mouse_x;
        int mouse_y;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            kllncsayfa s= new kllncsayfa();
            s.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notekle_Click(object sender, EventArgs e)
        {
            notekle ne = new notekle();
            ne.a = lblis.Text;
            ne.Show();
            this.Hide();
        }

        private void notbak_Click(object sender, EventArgs e)
        {
            notbak nb = new notbak();
            nb.a= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            nb.b= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            nb.Show();
            this.Hide();
        }

        private void notsil_Click(object sender, EventArgs e)
        {
            notsil ns = new notsil();
            ns.a= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ns.b= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ns.Show();
            this.Hide();
        }

        private void notlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select n.notID,k.isim,k.soyisim,n.baslik,n.icerik,kt.kullanicitürü from notlar n inner join kullanici k on n.kllncID=k.kllncID " +
                "inner join kullanicitürü kt on k.turID = kt.turID where n.kllncID=" + kllncgrs.kid, sqlbaglantisi.connection);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sqlbaglantisi.CheckConnection();
            da.Fill(ds, "notlar");
            dataGridView1.DataSource = ds.Tables[0];

            da.Dispose();
            sqlbaglantisi.connection.Close();

            lblis.Text = a;
        }

        private void notlar_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void notlar_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void notlar_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void düzenle_Click(object sender, EventArgs e)
        {
            notdüzenle nb = new notdüzenle();
            nb.a = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            nb.b = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            nb.c = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nb.Show();
            this.Hide();
        }
    }
}
