using DoAnTrucQuan.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTrucQuan.BAL
{
    public class CTPhieuDKBAL
    {
        public List<CTPhieuDK> GetAll(MySqlConnection conn)
        {
            conn.Open();

            string sql = "SELECT * FROM ctphieudangky";

            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
            List<CTPhieuDK> list = new List<CTPhieuDK>();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    CTPhieuDK a = new CTPhieuDK();
                    a.Spdk = rdr.GetString("spdk");
                    a.Mact = rdr.GetString("mact");
                    a.Csdk = rdr.GetInt16("csdk");
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }
        public List<CTPhieuDK> GetByID(MySqlConnection conn, string mact,string spdk)
        {
            conn.Open();
            List<CTPhieuDK> list = new List<CTPhieuDK>();
            string sql = "SELECT * FROM ctphieudangky where mact= @mact and spdk = @spdk";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@mact", mact);
            cmd.Parameters.AddWithValue("@spdk", spdk);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    CTPhieuDK a = new CTPhieuDK();
                    a.Spdk = rdr.GetString("spdk");
                    a.Mact = rdr.GetString("mact");
                    a.Csdk = rdr.GetInt16("csdk");
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }

        public List<CTPhieuDK> GetByspdk(MySqlConnection conn, string spdk)
        {
            conn.Open();
            List<CTPhieuDK> list = new List<CTPhieuDK>();
            string sql = "SELECT * FROM ctphieudangky where spdk = @spdk";

            var cmd = new MySqlCommand(sql, conn);

            
            cmd.Parameters.AddWithValue("@spdk", spdk);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    CTPhieuDK a = new CTPhieuDK();
                    a.Spdk = rdr.GetString("spdk");
                    a.Mact = rdr.GetString("mact");
                    a.Csdk = rdr.GetInt16("csdk");
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }

        public void Insert(MySqlConnection conn, string mact, string spdk, int csdk)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO `ctphieudangky` (`spdk`, `mact`, `csdk`) " +
                    "VALUES (@spdk, @mact, @csdk);";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mact", mact);
                cmd.Parameters.AddWithValue("@spdk", spdk);
                cmd.Parameters.AddWithValue("@csdk", csdk);

                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }




        }

        public void Update(MySqlConnection conn, string mact, string spdk, int csdk)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE `ctphieudangky` " +
                    "SET `csdk` = @csdk " +
                    "WHERE `ctphieudangky`.`spdk` = @spdk AND `ctphieudangky`.`mact` = @mact";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mact", mact);
                cmd.Parameters.AddWithValue("@spdk", spdk);
                cmd.Parameters.AddWithValue("@csdk", csdk);



                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }
        }

        public void Delete(MySqlConnection conn, string mact, string spdk)
        {
            try
            {
                conn.Open();
                string sql = "DELETE FROM `ctphieudangky`" +
                    " WHERE `ctphieudangky`.`spdk` =@spdk  AND `ctphieudangky`.`mact` =@mact  ";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mact", mact);
                cmd.Parameters.AddWithValue("@spdk", spdk);



                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }
        }
    }
}
