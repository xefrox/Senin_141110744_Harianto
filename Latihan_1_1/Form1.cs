using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "0";
            label4.Text = "0";
        }

        public void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int a = 0;
            a = vScrollBar1.Value;
            int tahun = DateTime.Now.Year - a;
            label3.Text = a.ToString();
            dateTimePicker1.MinDate = new DateTime(tahun,DateTime.Now.Month,DateTime.Now.Day);

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int b = 0;
            b = vScrollBar2.Value;
            int tahun = DateTime.Now.Year + b;
            label4.Text = b.ToString();
            dateTimePicker1.MaxDate = new DateTime(tahun,DateTime.Now.Month,DateTime.Now.Day);
        }


    }
}
