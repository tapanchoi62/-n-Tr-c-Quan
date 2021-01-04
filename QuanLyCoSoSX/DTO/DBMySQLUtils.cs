using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyCoSoSX.DTO
{
    public class DBMySQLUtils
    {
        public static MySqlConnection GetDBConnection(string host, string database, string username, string password)
        {
            // Connection String.
            //String connString = "Server=" + host + ";Database=" + database
            //    + ";User Id=" + username + ";password=" + password+ ";convert zero datetime = True";

            String connString = ConfigurationManager.ConnectionStrings["QuanLyCoSoSX.Properties.Settings.qlcssx_clspConnectionString"].ConnectionString;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
    }
}
