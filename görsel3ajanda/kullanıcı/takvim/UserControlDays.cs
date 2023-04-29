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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }
        public static string static_day;
        public string a;


        private void UserControlDays_Load(object sender, EventArgs e)
        {
            displayEvent();
            lblid.Text = kllncgrs.kid.ToString();



        }
        public void days(int numday)
        {
            lbldays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbldays.Text;
            timer1.Start();
            aktivite frm = new aktivite();
            frm.Show();
        }

        public void displayEvent()
        {
            SqlCommand komut = new SqlCommand("select*from aktivite where tarih=@date and kllncID=@id ", sqlbaglantisi.connection);

            sqlbaglantisi.CheckConnection();
            komut.Parameters.AddWithValue("@date",takvim.static_year+"-" + takvim.static_month + "/"+ lbldays.Text);
            komut.Parameters.AddWithValue("@id",kllncgrs.kid);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            { 
                while (dr.Read())
                {
                    lblevent.Text = dr["aktivite"].ToString();
                }
            
                
            }




            dr.Dispose();
            komut.Dispose();
            sqlbaglantisi.connection.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
