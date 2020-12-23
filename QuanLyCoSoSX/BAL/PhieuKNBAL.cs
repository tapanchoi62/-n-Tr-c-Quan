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
                    if(!rdr.IsDBNull(rdr.GetOrdinal("kl")))
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
                    if (!rdr.IsDBNull(rdr.GetOrdinal("kl")))
                        a.KL1 = rdr.GetString("kl");
                }
            }
            conn.Close();
            return a;
        }
        public void Insert(MySqlConnection conn, string spdk,
            string ngaykn, int manv, string masp, string kl)
        {
            try
            {
                conn.Open();
                string sophieukn ="PKN0001";
                string sql1 = "SELECT MAX(RIGHT(spkn,length(spkn)-3)) FROM phieukiemnghiem";
                var cmd1 = new MySqlCommand(sql1, conn);
                MySqlDataReader mrd = cmd1.ExecuteReader();
                if(mrd.HasRows)
                {
                    while(mrd.Read())
                    {
                        string pkn = "PKN";
                        string sophieu = (mrd.GetInt16("MAX(RIGHT(spkn,length(spkn)-3))")+1).ToString();
                        for(int i=0;i<4-(sophieu.Length);i++)
                        {
                            pkn += "0";
                        }
                        pkn += sophieu;
                        sophieukn = pkn;
                    }
                        
                }
                mrd.Close();

                string sql = "INSERT INTO `phieukiemnghiem` (`spkn`, `spdk`, `ngaykn`, `manv`, `masp`, `kl`)" +
                    " VALUES (@spkn, @spdk, @ngaykn, @manv, @masp, @kl);";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@spkn", sophieukn);
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
                throw ex;
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
                throw ex;
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
                throw ex;
            }
        }
    }
}
