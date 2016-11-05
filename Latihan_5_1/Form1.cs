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
using System.Collections;
using System.IO;

namespace Latihan_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
