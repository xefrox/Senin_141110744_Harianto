using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing.Text;

namespace Latihan_4_1
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
                toolStripComboBox2.Items.Add(oneFontFamily.Name);
            }

            toolStripComboBox2.Text = this.richTextBox1.Font.Name.ToString();
            toolStripComboBox1.Text = "8";
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
            toolStripComboBox2.Text = "Calibri";
            comboBox3.Text = "Black";
            this.comboBox3.DrawItem += new DrawItemEventHandler(comboBox3_DrawItem);
            toolStripButton1.CheckOnClick = true;
            toolStripButton2.CheckOnClick = true;
            toolStripButton3.CheckOnClick = true;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            float size = Convert.ToSingle(((ComboBox)sender).Text);

            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, size);
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



        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            float size = Convert.ToSingle(((ToolStripComboBox)sender).Text);

            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, size);
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(toolStripComboBox2.SelectedItem.ToString(), 8);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            System.Drawing.FontStyle state = (toolStripButton1.Checked) ? FontStyle.Bold : FontStyle.Regular;
            state |= (toolStripButton2.Checked) ? FontStyle.Italic : FontStyle.Regular;
            state |= (toolStripButton3.Checked) ? FontStyle.Underline : FontStyle.Regular;
            int start = richTextBox1.SelectionStart;
            int finish = richTextBox1.SelectionLength;

            if (finish != 0)
            {

                for (int i = start; i < start + finish; i++)
                {
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = 1;
                    Font font = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, state);
                    richTextBox1.SelectionFont = font;
                }
                richTextBox1.SelectionStart = start;
                richTextBox1.SelectionLength = finish;
            }
            else
            {
                Font font = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, state);
                richTextBox1.SelectionFont = font;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            System.Drawing.FontStyle state = (toolStripButton1.Checked) ? FontStyle.Bold : FontStyle.Regular;
            state |= (toolStripButton2.Checked) ? FontStyle.Italic : FontStyle.Regular;
            state |= (toolStripButton3.Checked) ? FontStyle.Underline : FontStyle.Regular;
            int start = richTextBox1.SelectionStart;
            int finish = richTextBox1.SelectionLength;
            if (finish != 0)
            {
                for (int i = start; i < start + finish; i++)
                {
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = 1;
                    Font font = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, state);
                    richTextBox1.SelectionFont = font;
                }
                richTextBox1.SelectionStart = start;
                richTextBox1.SelectionLength = finish;
            }
            else
            {
                Font font = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, state);
                richTextBox1.SelectionFont = font;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            System.Drawing.FontStyle state = (toolStripButton1.Checked) ? FontStyle.Bold : FontStyle.Regular;
            state |= (toolStripButton2.Checked) ? FontStyle.Italic : FontStyle.Regular;
            state |= (toolStripButton3.Checked) ? FontStyle.Underline : FontStyle.Regular;
            int start = richTextBox1.SelectionStart;
            int finish = richTextBox1.SelectionLength;
            if (finish != 0)
            {
                for (int i = start; i < start + finish; i++)
                {
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = 1;
                    Font font = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, state);
                    richTextBox1.SelectionFont = font;
                }
                richTextBox1.SelectionStart = start;
                richTextBox1.SelectionLength = finish;
            }
            else
            {
                Font font = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, state);
                richTextBox1.SelectionFont = font;
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = false;
            toolStripButton3.Checked = false;
            if (richTextBox1.SelectionFont != null)
            {
                toolStripComboBox1.Text = richTextBox1.SelectionFont.Size.ToString();
                toolStripComboBox2.Text = richTextBox1.SelectionFont.FontFamily.Name;
                comboBox3.Text = richTextBox1.SelectionColor.Name;
                if (richTextBox1.SelectionFont.Style.ToString().IndexOf("Bold") >= 0) toolStripButton1.Checked = true;
                if (richTextBox1.SelectionFont.Style.ToString().IndexOf("Italic") >= 0) toolStripButton2.Checked = true;
                if (richTextBox1.SelectionFont.Style.ToString().IndexOf("Underline") >= 0) toolStripButton2.Checked = true;
            }
            else
            {
                toolStripComboBox1.Text = "";
                toolStripComboBox2.Text = "";
                comboBox3.Text = "";
            }
        }



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            try
            {
                saveDialog.DefaultExt = "*.rtf";
                saveDialog.Filter = "RTF Files (*.rtf*)|*.rtf*";
                saveDialog.Title = "Save";
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveDialog.FileName.Length > 0)
                {
                    richTextBox1.SaveFile(saveDialog.FileName);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            try
            {
                openFile.DefaultExt = "*.rtf";
                openFile.Filter = "RTF Files | *.rtf";
                if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile.FileName.Length > 0)
                {
                    richTextBox1.LoadFile(openFile.FileName);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
