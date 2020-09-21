using QuanLyCoSoSX.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoSoSX.BAL
{
    public class PhieuDKBAL
    {
        public List<PhieuDK> GetAll(MySqlConnection conn)
        {
            conn.Open();

            string sql = "SELECT * FROM phieudangky";

            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
            List<PhieuDK> list = new List<PhieuDK>();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    PhieuDK a = new PhieuDK();
                    a.Macs = rdr.GetInt16("macs");
                    a.Masp = rdr.GetString("masp");
                    a.Ngdk = rdr.GetDateTime("ngdk");
                    a.Nghh = rdr.GetDateTime("nghh");
                    a.sl = rdr.GetInt32("SL");
                    a.Spdk = rdr.GetString("spdk");
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }
        public PhieuDK GetByID(MySqlConnection conn, string id)
        {
            conn.Open();
            PhieuDK a = new PhieuDK();
            string sql = "SELECT * FROM phieudangky where spdk= @id";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    a.Macs = rdr.GetInt16("macs");
                    a.Masp = rdr.GetString("masp");
                    a.Ngdk = rdr.GetDateTime("ngdk");
                    a.Nghh = rdr.GetDateTime("nghh");
                    a.sl = rdr.GetInt32("SL");
                    a.Spdk = rdr.GetString("spdk");
                }
            }
            conn.Close();
            return a;
        }
        public void Insert(MySqlConnection conn, string spdk, int macs, 
            string masp,string ngdk,string nghh,int sl)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO `phieudangky` (`spdk`, `ngdk`, `nghh`, `macs`, `masp`, `sl`)" +
                    " VALUES (@spdk, @ngdk, @nghh, @macs, @masp, @sl);";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@spdk", spdk);
                cmd.Parameters.AddWithValue("@ngdk", ngdk);
                cmd.Parameters.AddWithValue("@nghh", nghh);
                cmd.Parameters.AddWithValue("@macs", macs);
                cmd.Parameters.AddWithValue("@masp", masp);
                cmd.Parameters.AddWithValue("@sl", sl);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }




        }

        public void Update(MySqlConnection conn, string spdk, int macs,
            string masp, string ngdk, string nghh, int sl)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE `phieudangky` " +
            "SET `ngdk` = @ngdk, `nghh` = @nghh, `macs` = @macs, `masp` = @masp, `sl` = @sl " +
            "WHERE `phieudangky`.`spdk` = @spdk;";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@spdk", spdk);
                cmd.Parameters.AddWithValue("@ngdk", ngdk);
                cmd.Parameters.AddWithValue("@nghh", nghh);
                cmd.Parameters.AddWithValue("@macs", macs);
                cmd.Parameters.AddWithValue("@masp", masp);
                cmd.Parameters.AddWithValue("@sl", sl);



                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }
        }

        public void Delete(MySqlConnection conn, string spdk)
        {
            try
            {
                conn.Open();
                string sql = "Delete from phieudangky where spdk= @spdk";
                var cmd = new MySqlCommand(sql, conn);
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
