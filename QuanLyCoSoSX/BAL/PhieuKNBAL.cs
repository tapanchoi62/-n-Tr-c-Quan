using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using QuanLyCoSoSX.DAO;

namespace QuanLyCoSoSX.BAL
{
    public class PhieuKNBAL
    {
        public List<PhieuKN> GetAll(MySqlConnection conn)
        {
            conn.Open();

            string sql = "SELECT * FROM phieukiemnghiem";

            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
            List<PhieuKN> list = new List<PhieuKN>();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    PhieuKN a = new PhieuKN();
                    a.Spkn = rdr.GetString("spkn");
                    a.Spdk = rdr.GetString("spdk");
                    a.Ngkn = rdr.GetDateTime("ngaykn");
                    a.Manv = rdr.GetInt16("manv");
                    a.Masp = rdr.GetString("masp");
                    a.KL1 = rdr.GetString("kl");
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }
        public PhieuKN GetByID(MySqlConnection conn, string id)
        {
            conn.Open();
            PhieuKN a = new PhieuKN();
            string sql = "SELECT * FROM phieukiemnghiem where spkn= @id";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    a.Spkn = rdr.GetString("spkn");
                    a.Spdk = rdr.GetString("spdk");
                    a.Ngkn = rdr.GetDateTime("ngaykn");
                    a.Manv = rdr.GetInt16("manv");
                    a.Masp = rdr.GetString("masp");
                    a.KL1 = rdr.GetString("kl");
                }
            }
            conn.Close();
            return a;
        }
        public void Insert(MySqlConnection conn, string spkn, string spdk,
            string ngaykn, int manv, string masp, string kl)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO `phieukiemnghiem` (`spkn`, `spdk`, `ngaykn`, `manv`, `masp`, `kl`)" +
                    " VALUES ('PKN10001', 'PDK0002', '2020-09-30', '2', 'sp004', 'Khong ');";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@spkn", spkn);
                cmd.Parameters.AddWithValue("@spdk", spdk);
                cmd.Parameters.AddWithValue("@ngaykn", ngaykn);
                cmd.Parameters.AddWithValue("@manv", manv);
                cmd.Parameters.AddWithValue("@masp", masp);
                cmd.Parameters.AddWithValue("@kl", kl);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }
        }

        public void Update(MySqlConnection conn, string spkn, string spdk,
            string ngaykn, int manv, string masp, string kl)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE `phieukiemnghiem` " +
        "SET `spdk` = @spdk, `ngaykn` = @ngaykn, `manv` = @manv, `masp` = @masp, `kl` =@kl " +
        "WHERE `phieukiemnghiem`.`spkn` = @spkn";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@spkn", spkn);
                cmd.Parameters.AddWithValue("@spdk", spdk);
                cmd.Parameters.AddWithValue("@ngaykn", ngaykn);
                cmd.Parameters.AddWithValue("@manv", manv);
                cmd.Parameters.AddWithValue("@masp", masp);
                cmd.Parameters.AddWithValue("@kl", kl);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }
        }

        public void Delete(MySqlConnection conn, string spkn)
        {
            try
            {
                conn.Open();
                string sql = "Delete from phieukiemnghiem where spkn= @spkn";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@spkn", spkn);
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
