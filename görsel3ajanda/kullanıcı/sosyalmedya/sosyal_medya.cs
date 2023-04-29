using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using görsel3ajanda.kullanıcı.sosyalmedya;

namespace görsel3ajanda.kullanıcı
{
    public partial class sosyal_medya : Form
    {
        public sosyal_medya()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            kllncsayfa syf = new kllncsayfa();
            syf.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool kontrol = internetkontrol.internetcheck();

            if (kontrol == true)
            {
                instagram i = new instagram();
                i.Show();
            }
            else
            {
                MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool kontrol = internetkontrol.internetcheck();

            if (kontrol == true)
            {
                facebook i = new facebook();
                i.Show();
            }
            else
            {
                MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool kontrol = internetkontrol.internetcheck();

            if (kontrol == true)
            {
                twitter i = new twitter();
                i.Show();
            }
            else
            {
                MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
