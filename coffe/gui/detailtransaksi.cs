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
    public partial class detailtransaksi : Form
    {
        Kelas.Koneksi koneksi = new Kelas.Koneksi();

        public DataSet getData()
        {
            DataSet dts = new DataSet();
            try
            {
                string sql = "SELECT transaksi.id_transaksi, pembeli.nama_pembeli, detail_transaksi.alamat, detail_transaksi.handphone, detail_transaksi.tanggal, SUM(menu.harga) AS total_harga FROM transaksi INNER JOIN menu ON transaksi.id_menu = menu.id_menu INNER JOIN detail_transaksi ON transaksi.id_transaksi = detail_transaksi.id_transaksi INNER JOIN pembeli ON transaksi.id_pembeli = pembeli.id_pembeli GROUP BY transaksi.id_transaksi";
                MySqlCommand command = new MySqlCommand();
                command.Connection = koneksi.getConn();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                data.Fill(dts, "menu");
            }
            catch (Exception e)
            {
                MessageBox.Show("get\n" + e.ToString());
            }
            return dts;
        }

        public void header()
        {
            gridpembayaran.Columns[0].HeaderText = "ID Transaksi";
            gridpembayaran.Columns[1].HeaderText = "Nama Pembeli";
            gridpembayaran.Columns[2].HeaderText = "Alamat";
            gridpembayaran.Columns[3].HeaderText = "Handphone";
            gridpembayaran.Columns[4].HeaderText = "Tanggal";
            gridpembayaran.Columns[5].HeaderText = "Total Bayar";

        }

        void clear()
        {
            //txt_idmenu.Clear();
            //txt_namamenu.Clear();
            //txt_harga.Clear();
            //txt_idmenu.ReadOnly = false;
        }

        public void loadDaftar()
        {
            DataSet data = getData();
            gridpembayaran.DataSource = data;
            gridpembayaran.DataMember = "menu";
            header();

        }

        public void getTransaksi()
        {

            using (MySqlConnection con = koneksi.getConn())
            {
                con.Open();
                var query = "SELECT id_transaksi FROM transaksi GROUP BY id_transaksi";
                using (var command = new MySqlCommand(query, con))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader.GetString("id_transaksi"));
                        }
                    }
                }
            }

        }
        public detailtransaksi()
        {
            InitializeComponent();
            loadDaftar();
            getTransaksi();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            lblTanggal.Text = DateTime.UtcNow.Date.ToString("yyyy-MM-dd");
        }

        private void btn_simpandata_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into detail_transaksi(id_transaksi , tanggal, alamat, handphone) values(@idTransaksi, @Tanggal, @Alamat, @Hp)";
                MySqlCommand command = new MySqlCommand();
                command.Connection = koneksi.getConn();
                command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Parameters.AddWithValue("@idTransaksi", comboBox1.Text.Trim());
                command.Parameters.AddWithValue("@Tanggal", lblTanggal.Text);
                command.Parameters.AddWithValue("@Alamat", txt_alamat.Text);
                command.Parameters.AddWithValue("@Hp", txt_hp.Text);

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

        private void btn_hapusdata_Click(object sender, EventArgs e)
        {
            DialogResult akses = MessageBox.Show("Apakah anda yakin?",
                                           "Informasi", MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
            if (akses == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM detail_transaksi WHERE id_transaksi=@kode";
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = koneksi.getConn();
                    command.Connection.Open();
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@kode", comboBox1.Text);

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

        private void gridpembayaran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = gridpembayaran.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_alamat.Text = gridpembayaran.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_hp.Text = gridpembayaran.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_editdata_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE detail_transaksi SET alamat = @Alamat, Handphone = @Hp WHERE id_transaksi = @Kode";
                MySqlCommand command = new MySqlCommand();
                command.Connection = koneksi.getConn();
                command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Parameters.Add("@Alamat", MySqlDbType.VarChar).Value = txt_alamat.Text;
                command.Parameters.Add("@Hp", MySqlDbType.VarChar).Value = txt_hp.Text;
                command.Parameters.Add("@Kode", MySqlDbType.VarChar).Value = comboBox1.Text;

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

        private void btn_databaru_Click(object sender, EventArgs e)
        {
            txt_alamat.Text = txt_hp.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet dts = new DataSet();
            try
            {
                string sql = "SELECT transaksi.id_transaksi, pembeli.nama_pembeli, detail_transaksi.alamat, detail_transaksi.handphone, detail_transaksi.tanggal, SUM(menu.harga) AS total_harga FROM transaksi INNER JOIN menu ON transaksi.id_menu = menu.id_menu INNER JOIN detail_transaksi ON transaksi.id_transaksi = detail_transaksi.id_transaksi INNER JOIN pembeli ON transaksi.id_pembeli = pembeli.id_pembeli WHERE pembeli.nama_pembeli LIKE '%" + textBox1.Text + "%'" + "GROUP BY transaksi.id_transaksi";
                MySqlCommand command = new MySqlCommand();
                command.Connection = koneksi.getConn();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                data.Fill(dts, "menu");
            }
            catch (Exception er)
            {
                MessageBox.Show("get\n" + er.ToString());
            }
            gridpembayaran.DataSource = dts;
            gridpembayaran.DataMember = "menu";
            header();
        }

        private void detailtransaksi_Load(object sender, EventArgs e)
        {

        }
    }
}
