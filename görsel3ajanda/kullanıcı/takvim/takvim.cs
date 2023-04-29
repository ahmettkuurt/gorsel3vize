using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görsel3ajanda.kullanıcı
{
    public partial class takvim : Form
    {
        public takvim()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        int month, year;
        public static int static_month,static_year;
        public string a;
        

        private void takvim_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void takvim_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void takvim_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
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

        private void takvim_Load(object sender, EventArgs e)
        {
            UserControlDays ycd = new UserControlDays();
            ycd.displayEvent();
            disPlays();
            lblis.Text = a;
        }
        private void disPlays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblay.Text = monthname+"  "+year;

            static_month = month;
            static_year = year;

            DateTime startofmonth = new DateTime(year, month,1);
            
            int days = DateTime.DaysInMonth(year, month)+1;

            int dayoftheweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d"));


            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucb = new UserControlBlank();
                daycontainer.Controls.Add(ucb);
            }
            for (int i = 1;i<days;i++)
            {
                UserControlDays ucd = new UserControlDays();
                ucd.days(i);
                daycontainer.Controls.Add(ucd); 
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month--;

            static_month = month;
            static_year = year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblay.Text = monthname + "  " + year;

            DateTime startofmonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month)+1;

            int dayoftheweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d"));


            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucb = new UserControlBlank();
                daycontainer.Controls.Add(ucb);
            }
            for (int i = 1; i < days; i++)
            {
                UserControlDays ucd = new UserControlDays();
                ucd.days(i);
                daycontainer.Controls.Add(ucd);
            }
            UserControlDays userControlDays = new UserControlDays();
            userControlDays.displayEvent();
        }

        private void ileri_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month++;

            static_month = month;
            static_year = year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblay.Text = monthname + "  " + year;

            DateTime startofmonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month)+1;

            int dayoftheweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d"));


            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucb = new UserControlBlank();
                daycontainer.Controls.Add(ucb);
            }
            for (int i = 1; i < days; i++)
            {
                UserControlDays ucd = new UserControlDays();
                ucd.days(i);
                daycontainer.Controls.Add(ucd);
            }

            UserControlDays userControlDays = new UserControlDays();
            userControlDays.displayEvent();
        }
    }
}
