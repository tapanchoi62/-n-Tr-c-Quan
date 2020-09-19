using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTrucQuan.DTO
{
    public class DBMySQLUtils
    {
        public static MySqlConnection GetDBConnection(string host, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";User Id=" + username + ";password=" + password+ ";convert zero datetime = True";

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
    }
}
