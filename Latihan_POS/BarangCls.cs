using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Latihan_POS
{
    class BarangCls
    {
        public int ID { private set; get; }
        public string Kode { private set; get; }
        public string Nama { private set; get; }
        public int JlhAwal { private set; get; }
        public decimal HargaHPP { private set; get; }
        public decimal HargaJual { private set; get; }
        public DateTime created_at { private set; get; }
        public DateTime updated_at { private set; get; }

        private static string table = "barang";

        public void SetId(int ID)
        {
            this.ID = ID;
        }
        public void SetKode(string Kode)
        {
            this.Kode = Kode;
        }
        public void SetNama(string Nama)
        {
            this.Nama = Nama;
        }
        public void SetJlhAwal(int JlhAwal)
        {
            this.JlhAwal = JlhAwal;
        }
        public void SetHargaHpp(decimal HargaHPP)
        {
            this.HargaHPP = HargaHPP;
        }
        public void SetHargaJual(decimal HargaJual)
        {
            this.HargaJual = HargaJual;
        }
        public void SetCreatetime(DateTime created_at)
        {
            this.created_at = created_at;
        }
        public void SetUpdatetime(DateTime updated_at)
        {
            this.updated_at = updated_at;
        }
        public MySqlDataAdapter SelectFromTable()
        {
            MySqlDataAdapter da;
            string selectString = "SELECT * FROM " + table;
            da = new MySqlDataAdapter(selectString, DatabaseCls.con);
            try
            {
                DatabaseCls.openDB();
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
        public int InsertBarang()
        {
            int jlhrecord = 0;
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            string sqlcmd = "Insert into " + table + " (name,kode,jumlahawal,hargahpp,hargajual,created_at,updated_at) values (@name,@kode,@jlhawal,@hargahpp,@hargajual,@create,@update)";
            cmd.CommandText = sqlcmd;
            try
            {

                cmd.Parameters.AddWithValue("@name", Nama);
                cmd.Parameters.AddWithValue("@kode", Kode);
                cmd.Parameters.AddWithValue("@jlhawal", JlhAwal);
                cmd.Parameters.AddWithValue("@hargahpp", HargaHPP);
                cmd.Parameters.AddWithValue("@hargajual", HargaJual);
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
        public int UpdateBarang(int id)
        {
            int jlhrecord = 0;
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            string sqlcmd = "UPDATE " + table + " SET name = @name, kode = @kode, jumlahawal = @jlhawal, hargahpp = @hargahpp, hargajual = @hargajual, updated_at = @update WHERE ID = @id";
            cmd.CommandText = sqlcmd;
            try
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", Nama);
                cmd.Parameters.AddWithValue("@kode", Kode);
                cmd.Parameters.AddWithValue("@jlhawal", JlhAwal);
                cmd.Parameters.AddWithValue("@hargahpp", HargaHPP);
                cmd.Parameters.AddWithValue("@hargajual", HargaJual);
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
        public int DeleteBarang(int id)
        {
            int jlhrecord = 0;
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            string sqlcmd = "delete from " + table + " where ID = @id";
            cmd.CommandText = sqlcmd;
            try
            {
                DatabaseCls.openDB();
                cmd.Parameters.AddWithValue("@id", id);
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
            this.Kode = row[1].ToString();
            this.Nama = row[2].ToString();
            this.JlhAwal = Convert.ToInt32(row[3]);
            this.HargaHPP = Convert.ToDecimal(row[4]);
            this.HargaJual = Convert.ToDecimal(row[5]);
            this.created_at = Convert.ToDateTime(row[6]);
            this.updated_at = Convert.ToDateTime(row[7]);
        }
    }
}
