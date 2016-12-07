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
    public partial class Daftar : Form
    {
        public Daftar()
        {
            InitializeComponent();
        }

        private void tmbl_save_Click(object sender, EventArgs e)
        {
            DateTime wkt = DateTime.Now;
            string query = "Server=localhost;Database=latihan_pos;Uid=root;Pwd=;";
            MySqlConnection con = new MySqlConnection(query);
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO barang (Kode, Nama, JumlahAwal, HargaHPP, HargaJual, created_at, updated_at) VALUES (@Kode, @Nama, @JumlahAwal, @HargaHPP, @HargaJual, @created_at, @updated_at)";
            cmd.Parameters.AddWithValue("@Kode", txtKode.Text);
            cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
            cmd.Parameters.AddWithValue("@JumlahAwal", Convert.ToInt32(txtJlhAwal.Text));
            cmd.Parameters.AddWithValue("@HargaHPP", Convert.ToDecimal(txtHargaHPP.Text));
            cmd.Parameters.AddWithValue("@HargaJual", Convert.ToDecimal(txtHargaJual.Text));
            cmd.Parameters.AddWithValue("@created_at", wkt);
            cmd.Parameters.AddWithValue("@updated_at", wkt);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void tmbl_cancel_Click(object sender, EventArgs e)
        {
            txtKode.Text = "";
            txtNama.Text = "";
            txtJlhAwal.Text = "";
            txtHargaHPP.Text = "";
            txtHargaJual.Text = "";
            txtKode.Focus();
        }

        private void tmbl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
