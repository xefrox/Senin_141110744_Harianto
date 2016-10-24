using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;
using System.Drawing.Text;

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
            comboBox1.Text = "8";
            richTextBox1.Focus();
            Color clr = new Color();
            PropertyInfo[] colors = clr.GetType().GetProperties();
            this.comboBox3.DrawMode = DrawMode.OwnerDrawFixed;

            foreach (PropertyInfo color in colors)
            {
                if (color.PropertyType == typeof(System.Drawing.Color))
                {
                    comboBox3.Items.Add(color.Name);
                }
            }
            comboBox3.SelectedIndex = 3;
            comboBox3.Text = "Calibri";
            comboBox3.Text = "Black";
            this.comboBox3.DrawItem += new DrawItemEventHandler(comboBox3_DrawItem);

            
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            float size = Convert.ToSingle(((ComboBox)sender).Text);

            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, size);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBox2.SelectedItem.ToString(), 40);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.FromName(comboBox3.Text);
        }

        private void comboBox3_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);

                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.comboBox3.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                // Draw a rectangle and fill it with the current color
                // and add the name to the right of the color
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }




    }
}
