using QuanLyCoSoSX.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoSoSX.BAL
{
    public class CTPhieuKNBAL
    {
        public List<CTPhieuKN> GetAll(MySqlConnection conn)
        {
            conn.Open();

            string sql = "SELECT * FROM ctphieukiemnghiem";

            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
            List<CTPhieuKN> list = new List<CTPhieuKN>();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    CTPhieuKN a = new CTPhieuKN();
                    a.Mact = rdr.GetString("mact");
                    a.Spkn = rdr.GetString("spkn");
                    a.Cskn = rdr.GetInt16("cskn");
                    a.Cskq = rdr.GetInt16("cskq");
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }
        public CTPhieuKN GetByID(MySqlConnection conn, string mact, string spkn)
        {
            conn.Open();
            CTPhieuKN a = new CTPhieuKN();
            string sql = "SELECT * FROM ctphieukiemnghiem where mact= @mact and spkn = @spkn";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@mact", mact);
            cmd.Parameters.AddWithValue("@spkn", spkn);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    a.Mact = rdr.GetString("mact");
                    a.Spkn = rdr.GetString("spkn");
                    a.Cskn = rdr.GetInt16("cskn");
                    a.Cskq = rdr.GetInt16("cskq");
                }
            }
            else
            {
                conn.Close();
                return null;
            }
            conn.Close();
            return a;
        }
        public List<CTPhieuKN> GetByspkn(MySqlConnection conn,string spkn)
        {
            conn.Open();
            List<CTPhieuKN> ctpkn = new List<CTPhieuKN>();
            string sql = "SELECT * FROM ctphieukiemnghiem where spkn = @spkn";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@spkn", spkn);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    CTPhieuKN a = new CTPhieuKN();
                    a.Mact = rdr.GetString("mact");
                    a.Spkn = rdr.GetString("spkn");
                    a.Cskn = rdr.GetInt16("cskn");
                    ctpkn.Add(a);
                    a.Cskq = rdr.GetInt16("cskq");
                }
            }
            conn.Close();
            return ctpkn;
        }

        public void Insert(MySqlConnection conn, string spkn, string mact, int cskn,int cskq)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO `ctphieukiemnghiem` (`spkn`, `mact`, `cskn`, `cskq`) " +
                    "VALUES (@spkn, @mact, @cskn, @cskq);";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@spkn", spkn);
                cmd.Parameters.AddWithValue("@mact", mact);
                cmd.Parameters.AddWithValue("@cskn", cskn);
                cmd.Parameters.AddWithValue("@cskq", cskq);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }




        }

        public void Update(MySqlConnection conn, string spkn, string mact, int cskn, int cskq)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE `ctphieukiemnghiem`" +
                    " SET `cskn` = @cskn, `cskq` = @cskq " +
                    "WHERE `ctphieukiemnghiem`.`spkn` = @spkn AND `ctphieukiemnghiem`.`mact` = @mact";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@spkn", spkn);
                cmd.Parameters.AddWithValue("@mact", mact);
                cmd.Parameters.AddWithValue("@cskn", cskn);
                cmd.Parameters.AddWithValue("@cskq", cskq);



                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }
        }

        public void Delete(MySqlConnection conn, string spkn, string mact)
        {
            try
            {
                conn.Open();
                string sql = "DELETE FROM `ctphieukiemnghiem`" +
            " WHERE `ctphieukiemnghiem`.`spkn` = @spkn AND `ctphieukiemnghiem`.`mact` = @mact";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@spkn", spkn);
                cmd.Parameters.AddWithValue("@mact", mact);



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
