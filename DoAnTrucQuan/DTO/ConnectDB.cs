using DoAnTrucQuan.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTrucQuan.DTO
{
    public class DBConnect
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            string database = "qlcssx_clsp";
            string username = "root";
            string password = "";

            return DBMySQLUtils.GetDBConnection(host, database, username, password);
        }
    } 
}
