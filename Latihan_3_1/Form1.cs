using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public FontFamily[] Families { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                comboBox2.Items.Add(oneFontFamily.Name);
            }

            comboBox2.Text = this.richTextBox1.Font.Name.ToString();
            comboBox1.Text = this.richTextBox1.Font.Size.ToString();

            richTextBox1.Focus();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

    }
}
