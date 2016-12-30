using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_POS
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        //customer
        public void dbcustomer()
        {
            CustomerCls cs = new CustomerCls();
            cs.Daftar(dgridviewcust);
        }
        private void OkCustSave_Click(object sender, EventArgs e)
        {
            int jlhrecord = 0;
            CustomerCls cs = new CustomerCls();
            try
            {
                cs.SetNama(txtNamaCust.Text);
                cs.SetAlamat(txtAlamatCust.Text);
                cs.SetPos(txtKodePosCust.Text);
                cs.SetTelepon(txtTeleponCust.Text);
                cs.SetEmail(txtEmailCust.Text);
                cs.SetCreatetime(DateTime.Now);
                cs.SetUpdatedtime(DateTime.Now);
                jlhrecord = cs.InsertCustomer();
                MessageBox.Show(jlhrecord.ToString() + " saved successfully", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
            }
        }
        private void OkCustDelete_Click(object sender, EventArgs e)
        {
            int jlhrecord = 0;
            CustomerCls cs = new CustomerCls();
            try
            {
                jlhrecord = cs.DeleteCustomer(Convert.ToInt32(txtIDDeleteCust.Text));
                MessageBox.Show(jlhrecord.ToString() + " deleted successfully", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
            }
        }

        private void CancelCustReset_Click(object sender, EventArgs e)
        {
            txtNamaCust.Text = "";
            txtAlamatCust.Text = "";
            txtKodePosCust.Text = "";
            txtTeleponCust.Text = "";
            txtEmailCust.Text = "";
            txtNamaCust.Focus();
        }

        private void exitCustClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkCustEdit_Click(object sender, EventArgs e)
        {
            int jlhrecord = 0;
            CustomerCls cs = new CustomerCls();
            try
            {
                cs.SetNama(txtNamaEditCust.Text);
                cs.SetAlamat(txtAlamatEditCust.Text);
                cs.SetPos(txtKodePosEditCust.Text);
                cs.SetTelepon(txtTeleponEditCust.Text);
                cs.SetEmail(txtEmailEditCust.Text);
                cs.SetUpdatedtime(DateTime.Now);
                jlhrecord = cs.UpdateCustomer(Convert.ToInt32(txtIDEditCust.Text));
                MessageBox.Show(jlhrecord.ToString() + " updated successfully", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
            }
        }

        private void ResetCustEdit_Click(object sender, EventArgs e)
        {
            txtIDEditCust.Text = "";
            txtNamaEditCust.Text = "";
            txtAlamatEditCust.Text = "";
            txtKodePosEditCust.Text = "";
            txtTeleponEditCust.Text = "";
            txtEmailEditCust.Text = "";
            txtIDEditCust.Focus();
        }

        private void ExitCustEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void ResetCustDelete_Click(object sender, EventArgs e)
        {
            txtIDDeleteCust.Clear();
        }

        private void ExitCustDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedTab == tabPage4)
            {
                dbcustomer();
            }
        }
        //customer
    }
}
