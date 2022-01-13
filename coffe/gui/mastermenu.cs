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
    public partial class mastermenu : Form
    {
        Kelas.Koneksi koneksi = new Kelas.Koneksi();

        public mastermenu()
        {
            InitializeComponent();
            loadDaftar();
            clear();

        }

         public DataSet getData()
        {
            DataSet dts = new DataSet();
            try
            {
                string sql = "SELECT * FROM menu";
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
            datamenu.Columns[0].HeaderText = "ID Menu";
            datamenu.Columns[1].HeaderText = "Nama Menu";
            datamenu.Columns[2].HeaderText = "Harga";

        }

        void clear()
        {
            txt_idmenu.Clear();
            txt_namamenu.Clear();
            txt_harga.Clear();
            txt_idmenu.ReadOnly = false;
        }

        public void loadDaftar()
        {
            DataSet data = getData();
            datamenu.DataSource = data;
            datamenu.DataMember = "menu";
            header();
        
        }

        private void datamenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mastermenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_simpandata_Click(object sender, EventArgs e)
        {
            {
                 try
                {
                     string sql = "insert into menu(id_menu, nama_menu, harga) values(@kode, @nama, @harga)";
                     MySqlCommand command = new MySqlCommand();
                     command.Connection = koneksi.getConn();
                     command.Connection.Open();
                     command.CommandType = CommandType.Text;
                     command.CommandText = sql;
                     command.Parameters.AddWithValue("@kode", txt_idmenu.Text);
                     command.Parameters.AddWithValue("@nama", txt_namamenu.Text);
                     command.Parameters.AddWithValue("@harga", txt_harga.Text);
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
            
            DialogResult akses = MessageBox.Show("Apakah anda yakin?", "Informasi", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
            if (akses == DialogResult.Yes)
            {
                try
                {
                    string sql = "delete from menu where id_menu=@kode";
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = koneksi.getConn();
                    command.Connection.Open();
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@kode", txt_idmenu.Text);

                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Data berhasil dihapus", "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDaftar();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal dihapus\n" + ex, "info", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
           
        }
        
        private void btn_databaru_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_editdata_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE menu SET nama_menu = @Nama, harga = @Harga WHERE id_menu = @Kode";
                MySqlCommand command = new MySqlCommand();
                command.Connection = koneksi.getConn();
                command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Parameters.Add("@Nama", MySqlDbType.VarChar).Value = txt_namamenu.Text;
                command.Parameters.Add("@Harga", MySqlDbType.VarChar).Value = txt_harga.Text;
                command.Parameters.Add("@Kode", MySqlDbType.VarChar).Value = txt_idmenu.Text;

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

        private void datamenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                txt_idmenu.Text = datamenu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_namamenu.Text = datamenu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_harga.Text = datamenu.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_idmenu.ReadOnly = true;
        }
    }
 }



