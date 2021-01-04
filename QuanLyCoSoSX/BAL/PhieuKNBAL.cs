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

        public List<SanPham> GetAllMaSanPham(MySqlConnection conn)
        {
            conn.Open();
            SanPhamBAL DBSP = new SanPhamBAL();
            string sql = "select distinct masp from phieukiemnghiem";
            var cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<string> lstMasp = new List<string>();
            List<SanPham> list = new List<SanPham>();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    lstMasp.Add(rdr.GetString("masp"));
                    
                }
            }
            conn.Close();

            foreach(var masp in lstMasp)
            {
                list.Add(DBSP.GetByID(conn, masp));
            }
            return list;
        }
        public List<PhieuKN> GetByKL(MySqlConnection conn, string kl)
        {
            conn.Open();
            string sql = "SELECT * FROM phieukiemnghiem WHERE kl = @kl";
            var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kl", kl);
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
                    if (!rdr.IsDBNull(rdr.GetOrdinal("kl")))
                        a.KL1 = rdr.GetString("kl");
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }

        public List<PhieuKN> GetBySPDK(MySqlConnection conn,string spdk)
        {
            conn.Open();

            string sql = "SELECT * FROM phieukiemnghiem WHERE spdk = @spdk";
            var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@spdk", spdk);
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
                    if (!rdr.IsDBNull(rdr.GetOrdinal("kl")))
                        a.KL1 = rdr.GetString("kl");
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }


        public List<PhieuKN> GetBYNV(MySqlConnection conn, string manv)
        {
            conn.Open();
            string sql = "SELECT * FROM phieukiemnghiem WHERE manv = @manv";
            var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@manv", manv);
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
                    if (!rdr.IsDBNull(rdr.GetOrdinal("kl")))
                        a.KL1 = rdr.GetString("kl");
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }


        public List<PhieuKN> GetBYSP(MySqlConnection conn, string masp)
        {
            conn.Open();
            string sql = "SELECT * FROM phieukiemnghiem WHERE masp = @masp";
            var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@masp", masp);
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
                    if (!rdr.IsDBNull(rdr.GetOrdinal("kl")))
                        a.KL1 = rdr.GetString("kl");
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }

        public List<PhieuKN> GetByNgKN(MySqlConnection conn, string tungay, string denngay)
        {
            conn.Open();

            string sql = "SELECT * FROM phieukiemnghiem WHERE ngaykn >= @tungay AND ngkn <= @denngay";
            var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tungay", tungay);
            cmd.Parameters.AddWithValue("@denngay", denngay);
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
                    if (!rdr.IsDBNull(rdr.GetOrdinal("kl")))
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

        public bool IsExist(MySqlConnection conn, string spdk,string ngaykn,int manv,string masp)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM phieukiemnghiem WHERE spdk=@spdk AND ngaykn=@ngaykn AND manv = @manv AND masp = @masp";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@spdk", spdk);
                cmd.Parameters.AddWithValue("@ngaykn", ngaykn);
                cmd.Parameters.AddWithValue("@manv", manv);
                cmd.Parameters.AddWithValue("@masp", masp);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void Insert(MySqlConnection conn, string spdk,
            string ngaykn, int manv, string masp, string kl)
        {
            try
            {
                if (IsExist(conn, spdk, ngaykn, manv, masp))
                    throw new Exception("Phiếu kiểm nghiệm đã tồn tại");
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

        public void DeleteBySPDK(MySqlConnection conn, string spdk)
        {
            try
            {
                string sql2 = "SELECT spkn FROM phieukiemnghiem WHERE spdk = @spdk";
                var cmd2 = new MySqlCommand(sql2, conn);
                cmd2.Parameters.AddWithValue("@spdk", spdk);
                MySqlDataReader rdr = cmd2.ExecuteReader();
                List<string> list = new List<string>();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        string a = rdr.GetString("spkn");
                        list.Add(a);
                    }
                }
                rdr.Close();
                
                foreach (var spkn in list)
                {
                    string sql1 = "delete from ctphieukiemnghiem where spkn = @spkn";
                    var cmd1 = new MySqlCommand(sql1, conn);
                    cmd1.Parameters.AddWithValue("@spkn",spkn);
                    cmd1.ExecuteNonQuery();
                    cmd1.Cancel();
                }
               

                string sql = "delete from  phieukiemnghiem where spdk= @spdk";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@spdk", spdk);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
