using QuanLyCoSoSX.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;

namespace QuanLyCoSoSX.BAL
{
    public class TaiKhoanBAL
    {
        public List<TaiKhoan> GetAll(MySqlConnection conn)
        {
            conn.Open();

            string sql = "SELECT * FROM taikhoan";

            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
            List<TaiKhoan> list = new List<TaiKhoan>();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    TaiKhoan a = new TaiKhoan();
                    a.Matk = rdr.GetInt16("matk");
                    a.Tentk = rdr.GetString("tentk");
                    a.Quyen = rdr.GetString("quyen");
                    a.Matkhau = rdr.GetString("matkhau");
                    a.Manv = rdr.GetInt16("manv");
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }
        public bool CheckUser(MySqlConnection conn,string tentk,string manv)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM taikhoan where tentk= @tentk or manv = @manv";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tentk", tentk);
                cmd.Parameters.AddWithValue("@manv", manv);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    conn.Close();
                    return true;
                }
                conn.Close();
                return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }           
        }

        public bool CheckUserName(MySqlConnection conn, string tentk, string manv)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM taikhoan where tentk= @tentk and manv <> @manv";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tentk", tentk);
                cmd.Parameters.AddWithValue("@manv", manv);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    conn.Close();
                    return true;
                }
                conn.Close();
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TaiKhoan GetByID(MySqlConnection conn, int id)
        {
            conn.Open();
            TaiKhoan a = new TaiKhoan();
            string sql = "SELECT * FROM taikhoan where matk= @id";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    a.Matk = rdr.GetInt16("matk");
                    a.Tentk = rdr.GetString("tentk");
                    a.Quyen = rdr.GetString("quyen");
                    a.Matkhau = rdr.GetString("matkhau");
                    a.Manv = rdr.GetInt16("manv");
                }
            }
            conn.Close();
            return a;
        }
        public TaiKhoan GetByTenTK(MySqlConnection conn, string tentk, string pass)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach(byte item in hasData)
            {
                hasPass += item;
            }

            conn.Open();
            TaiKhoan a = new TaiKhoan();
            string sql = "SELECT * FROM taikhoan where tentk= @tentk and matkhau = @hasPass";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@tentk", tentk);
            cmd.Parameters.AddWithValue("@hasPass", hasPass);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    a.Matk = rdr.GetInt16("matk");
                    a.Tentk = rdr.GetString("tentk");
                    a.Quyen = rdr.GetString("quyen");
                    a.Matkhau = rdr.GetString("matkhau");
                    a.Manv = rdr.GetInt16("manv");

                }
            }
            conn.Close();
            return a;
        }

        public void Insert(MySqlConnection conn, string tentk, string matkhau,
            int manv,string quyen)
        {
            try
            {

                conn.Open();
                string sql1 = "SELECT MAX(matk) FROM taikhoan";
                var cmd1 = new MySqlCommand(sql1, conn);
                MySqlDataReader rdr1 = cmd1.ExecuteReader();
                int matk = 0;
                if (rdr1.HasRows)
                {
                    rdr1.Read();
                    if (!rdr1.IsDBNull(rdr1.GetOrdinal("Max(matk)")))
                        matk = rdr1.GetInt16("Max(matk)") + 1;
                    else
                        matk = 0;
                }
                else
                {
                    matk = 1;
                }
                rdr1.Close();

                string sql = "INSERT INTO `taikhoan` (`matk`, `tentk`, `matkhau`, `manv`, `quyen`) " +
                    "VALUES (@matk, @tentk, @matkhau, @manv, @quyen);";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@matk", matk);
                cmd.Parameters.AddWithValue("@tentk", tentk);
                cmd.Parameters.AddWithValue("@matkhau", matkhau);
                cmd.Parameters.AddWithValue("@manv", manv);
                cmd.Parameters.AddWithValue("@quyen", quyen);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }




        }

        public void Update(MySqlConnection conn, string tentk, string matkhau,
            int manv, string quyen)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE `taikhoan` " +
                    "SET `tentk` = @tentk, `matkhau` = @matkhau, `quyen` = @quyen" +
                    " WHERE manv = @manv";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tentk", tentk);
                cmd.Parameters.AddWithValue("@matkhau", matkhau);
                cmd.Parameters.AddWithValue("@manv", manv);
                cmd.Parameters.AddWithValue("@quyen", quyen);


                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }
        }

        public void Delete(MySqlConnection conn, int matk)
        {
            try
            {
                conn.Open();
                string sql = "Delete from taikhoan where matk= @matk";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@matk", matk);

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
