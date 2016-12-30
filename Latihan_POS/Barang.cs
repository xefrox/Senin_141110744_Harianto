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
    public partial class Barang : Form
    {
        public Barang()
        {
            InitializeComponent();
        }
        public void dbbarang()
        {
            BarangCls Brg = new BarangCls();
            Brg.Daftar(dgridviewBrg);
        }
        //Barang 
        private void oktmbhBrg_Click_1(object sender, EventArgs e)
        {
            int jlhrecord = 0;
            BarangCls Brg = new BarangCls();
            try
            {
                Brg.SetKode(txtKodeBrg.Text);
                Brg.SetNama(txtNamaBrg.Text);
                Brg.SetJlhAwal(Convert.ToInt32(txtJlhAwalBrg.Text));
                Brg.SetHargaHpp(Convert.ToDecimal(txtHargaHPPBrg.Text));
                Brg.SetHargaJual(Convert.ToDecimal(txtHargaJualBrg.Text));
                Brg.SetCreatetime(DateTime.Now);
                Brg.SetUpdatetime(DateTime.Now);
                jlhrecord = Brg.InsertBarang();
                MessageBox.Show(jlhrecord.ToString() + " saved successfully", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
            }
        }

        private void EditBrg_Click(object sender, EventArgs e)
        {
            int jlhrecord = 0;
            BarangCls Brg = new BarangCls();
            try
            {
                Brg.SetKode(txtKodeEdit.Text);
                Brg.SetNama(txtNamaEdit.Text);
                Brg.SetJlhAwal(Convert.ToInt32(txtJlhAwalEdit.Text));
                Brg.SetHargaHpp(Convert.ToDecimal(txtHargaHppEdit.Text));
                Brg.SetHargaJual(Convert.ToDecimal(txtHargaJualEdit.Text));
                Brg.SetCreatetime(DateTime.Now);
                Brg.SetUpdatetime(DateTime.Now);
                jlhrecord = Brg.UpdateBarang(Convert.ToInt32(txtIDEdit.Text));
                MessageBox.Show(jlhrecord.ToString() + " Updated successfully", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
            }
        }

        private void DeleteBrg_Click(object sender, EventArgs e)
        {
            int jlhrecord = 0;
            BarangCls Brg = new BarangCls();
            try
            {
                jlhrecord = Brg.DeleteBarang(Convert.ToInt32(txtIDDelete.Text));
                MessageBox.Show(jlhrecord.ToString() + " deleted successfully", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
            }
        }

        private void tmbl_cancel_Click(object sender, EventArgs e)
        {
            txtKodeBrg.Text = "";
            txtNamaBrg.Text = "";
            txtJlhAwalBrg.Text = "";
            txtHargaHPPBrg.Text = "";
            txtHargaJualBrg.Text = "";
            txtKodeBrg.Focus();
        }

        private void tmbl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIDEdit.Text = "";
            txtKodeEdit.Text = "";
            txtNamaEdit.Text = "";
            txtJlhAwalEdit.Text = "";
            txtHargaHppEdit.Text = "";
            txtHargaJualEdit.Text = "";
            txtIDEdit.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtIDDelete.Text = "";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage4)
            {
                dbbarang();
            }
            //Barang



        }
    }
}
