
using DoAnTrucQuan.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTrucQuan.BAL
{
    public class SanPhamBAL
    {
      

        public List<SanPham> GetAll(MySqlConnection conn)
        {
            conn.Open();

            string sql = "SELECT * FROM sanpham";

            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
            List<SanPham> list = new List<SanPham>();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    SanPham a = new SanPham();
                    a.Macs = rdr.GetInt16("macs");
                    a.Masp = rdr.GetString("masp");
                    a.Tensp = rdr.GetString("tensp");
                    a.Donvi = rdr.GetString("donvi");
                    
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }
        public SanPham GetByID(MySqlConnection conn, string id)
        {
            conn.Open();
            SanPham a = new SanPham();
            string sql = "SELECT * FROM sanpham where masp= @id";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    a.Macs = rdr.GetInt16("macs");
                    a.Masp = rdr.GetString("masp");
                    a.Tensp = rdr.GetString("tensp");
                    a.Donvi = rdr.GetString("donvi");

                }
            }
            conn.Close();
            return a;
        }
        public List<SanPham> GetByMacs(MySqlConnection conn, int macs )
        {
            conn.Open();
            List<SanPham> list = new List<SanPham>();
            string sql = "SELECT * FROM sanpham where macs= @macs";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@macs", macs);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    SanPham a = new SanPham();
                    a.Macs = rdr.GetInt16("macs");
                    a.Masp = rdr.GetString("masp");
                    a.Tensp = rdr.GetString("tensp");
                    a.Donvi = rdr.GetString("donvi");

                    list.Add(a);

                }
            }
            conn.Close();
            return list;
        }

        public void Insert(MySqlConnection conn, string masp, string tensp, string donvi,
            int macs)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO `sanpham` (`masp`, `tensp`, `donvi`, `macs`) " +
                    "VALUES (@masp, @tensp,@donvi ,@macs);";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@masp", masp);
                cmd.Parameters.AddWithValue("@tensp", tensp);
                cmd.Parameters.AddWithValue("@donvi", donvi);
                cmd.Parameters.AddWithValue("@macs", macs);
                
                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }




        }

        public void Update(MySqlConnection conn, string masp, string tensp, string donvi,
            int macs)
        {
            try
            {
                conn.Open();
                string sql = "Update `SanPham` Set `tensp`=@tennv, `donvi`=@donvi, `macs`=@macs," +
                    " where masp =@masp";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@masp", masp);
                cmd.Parameters.AddWithValue("@tensp", tensp);
                cmd.Parameters.AddWithValue("@donvi", donvi);
                cmd.Parameters.AddWithValue("@macs", macs);


                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }
        }

        public void Delete(MySqlConnection conn, string masp)
        {
            try
            {
                conn.Open();
                string sql = "Delete from SanPham where masp= @masp";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@masp", masp);

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
