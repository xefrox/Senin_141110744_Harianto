using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Latihan_POS
{
    class CustomerCls
    {
        public int ID { private set; get; }
        public string Nama { private set; get; }
        public string Alamat { private set; get; }
        public string Email { private set; get; }
        public string Telepon { private set; get; }
        public string Kodepos { private set; get; }
        public DateTime created_at { private set; get; }
        public DateTime updated_at { private set; get; }

        private static string table = "customer";

        public void SetID(int id)
        {
            this.ID = id;
        }
        public void SetNama(string Nama)
        {
            this.Nama = Nama;
        }
        public void SetAlamat(string Alamat)
        {
            this.Alamat = Alamat;
        }
        public void SetEmail(string Email)
        {
            this.Email = Email;
        }
        public void SetTelepon(string Telepon)
        {
            this.Telepon = Telepon;
        }
        public void SetPos(string Kodepos)
        {
            this.Kodepos = Kodepos;
        }
        public void SetCreatetime(DateTime created_at)
        {
            this.created_at = created_at;
        }
        public void SetUpdatedtime(DateTime updated_at)
        {
            this.updated_at = updated_at;
        }

        public int InsertCustomer()
        {
            int jlhrecord = 0;
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            string sqlcmd = "Insert into " + table + " (name,address,zip_code,phone_number,email,created_at,updated_at) values (@nama,@alamat,@kodepos,@telepon,@email,@create,@update)";
            cmd.CommandText = sqlcmd;
            try
            {
                cmd.Parameters.AddWithValue("@nama", Nama);
                cmd.Parameters.AddWithValue("@alamat", Alamat);
                cmd.Parameters.AddWithValue("@kodepos", Kodepos);
                cmd.Parameters.AddWithValue("@telepon", Telepon);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@create", created_at);
                cmd.Parameters.AddWithValue("@update", updated_at);
                DatabaseCls.openDB();
                cmd.Connection = DatabaseCls.con;
                da.InsertCommand = cmd;
                jlhrecord = da.InsertCommand.ExecuteNonQuery();
                DatabaseCls.closeDB();
            }
            catch (Exception ex)
            {
                DatabaseCls.closeDB();
                throw new Exception(ex.Message);
            }
            return jlhrecord;
        }

        public int UpdateCustomer(int id)
        {
            int jlhrecord = 0;
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            string sqlcmd = "update " + table + " set name=@name,address=@alamat,zip_code=@kodepos,phone_number=@telepon,email=@email,updated_at=@update where " + table + ".ID=" + id;
            cmd.CommandText = sqlcmd;
            try
            {
                cmd.Parameters.AddWithValue("@name", Nama);
                cmd.Parameters.AddWithValue("@alamat", Alamat);
                cmd.Parameters.AddWithValue("@kodepos", Kodepos);
                cmd.Parameters.AddWithValue("@telepon", Telepon);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@create", created_at);
                cmd.Parameters.AddWithValue("@update", updated_at);
                DatabaseCls.openDB();
                cmd.Connection = DatabaseCls.con;
                da.UpdateCommand = cmd;
                jlhrecord = da.UpdateCommand.ExecuteNonQuery();
                DatabaseCls.closeDB();
            }
            catch (Exception ex)
            {
                DatabaseCls.closeDB();
                throw new Exception(ex.Message);
            }
            return jlhrecord;
        }

        public int DeleteCustomer(int id)
        {
            int jlhrecord = 0;
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            string sqlcmd = "delete from " + table + " where " + table + ".ID=" + id;
            cmd.CommandText = sqlcmd;
            try
            {
                DatabaseCls.openDB();
                cmd.Connection = DatabaseCls.con;
                da.DeleteCommand = cmd;
                jlhrecord = da.DeleteCommand.ExecuteNonQuery();
                DatabaseCls.closeDB();
            }
            catch (Exception ex)
            {
                DatabaseCls.closeDB();
                throw new Exception(ex.Message);
            }
            return jlhrecord;
        }
        public MySqlDataAdapter Daftar(DataGridView dgv)
        {
            MySqlDataAdapter da;
            DataSet ds;
            string select = "SELECT * FROM " + table;
            try
            {
                DatabaseCls.openDB();
                ds = new DataSet();
                da = new MySqlDataAdapter(select, DatabaseCls.con);
                da.SelectCommand.ExecuteScalar();
                da.Fill(ds, table);
                dgv.ReadOnly = true;
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.DataSource = ds.Tables[table];
                DatabaseCls.closeDB();
            }
            catch (Exception ex)
            {
                DatabaseCls.closeDB();
                throw new Exception(ex.Message);
            }
            return da;
        }
        public static MySqlDataAdapter Daftar()
        {
            MySqlDataAdapter da;
            string select = "SELECT * FROM " + table;
            try
            {
                DatabaseCls.openDB();
                da = new MySqlDataAdapter(select, DatabaseCls.con);
                da.SelectCommand.ExecuteScalar();
                DatabaseCls.closeDB();
            }
            catch (Exception ex)
            {
                DatabaseCls.closeDB();
                throw new Exception(ex.Message);
            }
            return da;
        }
        public void setProperties(DataRow row)
        {
            this.ID = Convert.ToInt32(row[0]);
            this.Nama = row[1].ToString();
            this.Alamat = row[2].ToString();
            this.Kodepos = row[3].ToString();
            this.Telepon = row[4].ToString();
            this.Email = row[5].ToString();
            this.created_at = Convert.ToDateTime(row[6]);
            this.updated_at = Convert.ToDateTime(row[7]);
        }

    }
}
