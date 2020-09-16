﻿using DoAnTrucQuan.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTrucQuan.BAL
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
        public void Insert(MySqlConnection conn, int matk, string tentk, string matkhau,
            int manv,string quyen)
        {
            try
            {
                conn.Open();
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
                Console.WriteLine("That bai," + ex.Message);
            }




        }

        public void Update(MySqlConnection conn, int matk, string tentk, string matkhau,
            int manv, string quyen)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE `taikhoan` " +
                    "SET `tentk` = @tentk, `matkhau` = @matkhau, `manv` = @manv, `quyen` = @quyen" +
                    " WHERE `taikhoan`.`matk` = @matk;";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@matk", matk);
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
