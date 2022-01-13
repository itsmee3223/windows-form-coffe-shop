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

namespace coffe.gui
{
    public partial class mastertransaksi : Form
    {
        Kelas.Koneksi koneksi = new Kelas.Koneksi();

        public void getPembeli()
        {

            using (MySqlConnection con = koneksi.getConn())
            {
                con.Open();
                var query = "SELECT id_pembeli FROM pembeli";
                using (var command = new MySqlCommand(query, con))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader.GetString("id_pembeli"));
                        }
                    }
                }
            }

        }

        public void getMenu()
        {

            using (MySqlConnection con = koneksi.getConn())
            {
                con.Open();
                var query = "SELECT id_menu FROM menu";
                using (var command = new MySqlCommand(query, con))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader.GetString("id_menu"));
                        }
                    }
                }
            }

        }

        public mastertransaksi()
        {
            InitializeComponent();
            loadDaftar();
            getPembeli();
            getMenu();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            txtNamaPb.ReadOnly = true;
            txtMenu.ReadOnly = true;
        }

        public void loadDaftar()
        {
            DataSet data = getData();
            gridtransaksi.DataSource = data;
            gridtransaksi.DataMember = "transaksi";
            header();

        }

        void clear()
        {
            txt_idtransaksi.ReadOnly = false;
        }

        public void header()
        {
            gridtransaksi.Columns[0].HeaderText = "ID Pembeli";
            gridtransaksi.Columns[1].HeaderText = "ID Menu";
            gridtransaksi.Columns[2].HeaderText = "ID Transaksi";

        }

        public DataSet getData()
        {
            DataSet dts = new DataSet();
            try
            {
                string sql = "SELECT * FROM transaksi";
                MySqlCommand command = new MySqlCommand();
                command.Connection = koneksi.getConn();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                data.Fill(dts, "transaksi");
            }
            catch (Exception e)
            {
                MessageBox.Show("get\n" + e.ToString());
            }
            return dts;
        }

        private void gridtransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_idpembeli.Text = gridtransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txt_idmenu.Text = gridtransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txt_idtransaksi.Text = gridtransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void btn_simpandata_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into transaksi(id_pembeli, id_menu, id_transaksi) values(@idPembeli, @idMenu, @idTransaksi)";
                MySqlCommand command = new MySqlCommand();
                command.Connection = koneksi.getConn();
                command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Parameters.AddWithValue("@idPembeli", comboBox1.Text.Trim());
                command.Parameters.AddWithValue("@idMenu", comboBox2.Text.Trim());
                command.Parameters.AddWithValue("@idTransaksi", txt_idtransaksi.Text);

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

            clear();
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            string sql = "SELECT nama_pembeli FROM pembeli WHERE id_pembeli = @idddd;";

            MySqlConnection con = koneksi.getConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idddd", MySqlDbType.VarChar).Value = comboBox1.SelectedItem.ToString();
            try
            {
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtNamaPb.Text = reader.GetString("nama_pembeli");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed.\n" + ex, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void comboBox2_DropDownClosed(object sender, EventArgs e)
        {
            string sql = "SELECT nama_menu FROM menu WHERE id_menu = @idddd;";

            MySqlConnection con = koneksi.getConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idddd", MySqlDbType.VarChar).Value = comboBox2.SelectedItem.ToString();
            try
            {
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtMenu.Text = reader.GetString("nama_menu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed.\n" + ex, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void gridtransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idtransaksi.Text = gridtransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_idtransaksi.ReadOnly = true;
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
                    string sql = "DELETE FROM transaksi WHERE id_transaksi=@kode";
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = koneksi.getConn();
                    command.Connection.Open();
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@kode", txt_idtransaksi.Text);

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

    }
}
