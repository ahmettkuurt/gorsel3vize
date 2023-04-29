using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using görsel3ajanda.kullanıcı;
using görsel3ajanda.kullanıcı.kitap;

namespace görsel3ajanda
{
    public partial class kllncsayfa : Form
    {
        public kllncsayfa()
        {
            InitializeComponent();
        }
        public string a;
        bool move;
        int mouse_x;
        int mouse_y;
        public static string id;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            MessageBox.Show("Oturum kapatıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kllncdüzenle a = new kllncdüzenle();
            a.a = lblis.Text;
            a.Show();
            this.Hide();
        }

        private void kllncsayfa_Load(object sender, EventArgs e)
        {
            lblis.Text = a;
            id= lblis.Text;
            
        }

        private void kllncsayfa_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void kllncsayfa_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void kllncsayfa_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void takvim_Click(object sender, EventArgs e)
        {
            
            takvim t = new takvim();
            t.a = lblis.Text;
            t.Show();
            this.Hide();
        }

        private void kitap_Click(object sender, EventArgs e)
        {
            bool kontrol = internetkontrol.internetcheck();

            if (kontrol == true)
            {
                ekitap i = new ekitap();
                i.Show();
            }
            else
            {
                MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            not not = new not();
            not.a=lblis.Text;
            not.Show();
            this.Hide();
        }

        private void lblis_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool kontrol = internetkontrol.internetcheck();

            if (kontrol == true)
            {
                arastirma i = new arastirma();
                i.Show();
            }
            else
            {
                MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sosyal_medya syf = new sosyal_medya();
            syf.Show();
            this.Hide();
        }
    }
}
