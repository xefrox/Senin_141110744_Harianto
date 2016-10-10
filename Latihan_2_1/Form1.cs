using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime sm = new DateTime(2016, 1, 1);
            for (int i = 0; i < 365; i++)
            {
                if (sm.DayOfWeek == DayOfWeek.Saturday || sm.DayOfWeek == DayOfWeek.Sunday)
                {
                    monthCalendar1.AddBoldedDate(sm);
                }
                sm = sm.AddDays(1);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            domainUpDown1.Text = "Month";
            DateTime lahir = new DateTime(1996,7,12);
            monthCalendar1.AddAnnuallyBoldedDate(lahir);
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            
            DateTime ne = new DateTime();
            decimal a;
            int b;
            b = domainUpDown1.SelectedIndex + 1;
            a = numericUpDown1.Value;
            ne = new DateTime(2016, b, (int)a);
            monthCalendar1.AddAnnuallyBoldedDate(ne);
            monthCalendar1.UpdateBoldedDates();
            monthCalendar1.SetDate(ne);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime ne = new DateTime();
            decimal a;
            int b;
            b = domainUpDown1.SelectedIndex + 1;
            a = numericUpDown1.Value;
            ne = new DateTime(2016, b, (int)a);
            monthCalendar1.RemoveAnnuallyBoldedDate(ne);
            monthCalendar1.UpdateBoldedDates();
            monthCalendar1.SetDate(ne);
        }
    }
}
