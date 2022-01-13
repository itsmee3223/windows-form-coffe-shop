using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace coffe.gui
{
    public partial class masterpembeli : Form
    {
        Kelas.Koneksi koneksi = new Kelas.Koneksi();
        public masterpembeli()
        {
            InitializeComponent();
            loadDaftar();
        }

        public void loadDaftar()
        {
            DataSet data = getData();
            gridpembeli.DataSource = data;
            gridpembeli.DataMember = "pembeli";
            header();

        }

        public void header()
        {
            gridpembeli.Columns[0].HeaderText = "ID Pembeli";
            gridpembeli.Columns[1].HeaderText = "Nama Pembeli";

        }

        public DataSet getData()
        {
            DataSet dts = new DataSet();
            try
            {
                string sql = "SELECT * FROM pembeli";
                MySqlCommand command = new MySqlCommand();
                command.Connection = koneksi.getConn();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                data.Fill(dts, "pembeli");
            }
            catch (Exception e)
            {
                MessageBox.Show("get\n" + e.ToString());
            }
            return dts;
        }

        private void btn_simpandata_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string sql = "insert into pembeli(id_pembeli, nama_pembeli) values(@idPembeli, @namaPembeli)";
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = koneksi.getConn();
                    command.Connection.Open();
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@idPembeli", txt_idpembeli.Text);
                    command.Parameters.AddWithValue("@namaPembeli", txt_namapembeli.Text);
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Data berhasil disimpan", "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDaftar();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal disimpan\n" + ex, "info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_hapusdata_Click(object sender, EventArgs e)
        {

            DialogResult akses = MessageBox.Show("Apakah anda yakin?",
                                            "Informasi", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
            if (akses == DialogResult.Yes)
            {
                try
                {
                    string sql = "delete from transaksi where id_pembeli=@kode";
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = koneksi.getConn();
                    command.Connection.Open();
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@kode", txt_idpembeli.Text);
                    command.ExecuteNonQuery();
                    command.Connection.Close();

                    command.Parameters.Clear();

                    sql = "delete from pembeli where id_pembeli=@kode";
                    command.Connection = koneksi.getConn();
                    command.Connection.Open();
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@kode", txt_idpembeli.Text);
                    command.ExecuteNonQuery();
                    command.Connection.Close();

                    MessageBox.Show("Data berhasil dihapus", "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDaftar();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal disimpan\n" + ex, "info", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

        }
        void clear()
        {
            txt_idpembeli.Clear();
            txt_namapembeli.Clear();
            txt_idpembeli.ReadOnly = false;
        }

        private void btn_editdata_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE pembeli SET nama_pembeli = @Nama WHERE id_pembeli = @Kode";
                MySqlCommand command = new MySqlCommand();
                command.Connection = koneksi.getConn();
                command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Parameters.Add("@Nama", MySqlDbType.VarChar).Value = txt_namapembeli.Text;
                command.Parameters.Add("@Kode", MySqlDbType.VarChar).Value = txt_idpembeli.Text;

                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Data berhasil diupdate", "info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDaftar();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal disimpan\n" + ex, "info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void gridpembeli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idpembeli.Text = gridpembeli.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_namapembeli.Text = gridpembeli.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_idpembeli.ReadOnly = true;
        }
    }
}