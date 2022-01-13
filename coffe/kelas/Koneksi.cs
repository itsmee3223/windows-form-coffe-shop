using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;

namespace Kelas
{
    class Koneksi
    {
        public MySqlConnection getConn()
        {
            string host = "localhost";
            string user = "root";
            string password = "";
            string database = "cofee";
            string connStr = "server=" + host + ";user=" + user + ";database=" + database + ";password=" + password + ";";
            MySqlConnection conn = new MySqlConnection(connStr);
            return conn;
        }
    }
}