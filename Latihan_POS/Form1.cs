using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Barang brg;
        Customer cust;
        private void tambahBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brg = new Barang();
            brg.MdiParent = this;
            brg.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cust = new Customer();
            cust.MdiParent = this;
            cust.Show();
        }
    }
}
