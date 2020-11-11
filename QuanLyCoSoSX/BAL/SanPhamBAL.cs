
using QuanLyCoSoSX.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace QuanLyCoSoSX.BAL
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
            else
            {
                conn.Close();
                return null;
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

        public void Insert(MySqlConnection conn, string tensp, string donvi,
            int macs)
        {
            try
            {
                conn.Open();
                string sqlmasp = "SELECT MAX(RIGHT(masp,length(masp)-2-length(macs)-1)) FROM sanpham where macs= @macs";
                var cmd1 = new MySqlCommand(sqlmasp, conn);
                cmd1.Parameters.AddWithValue("@macs", macs);
                MySqlDataReader mdr = cmd1.ExecuteReader();
                string masp = "sp" + macs.ToString() + "01";
                if(mdr.HasRows)
                {
                    mdr.Read();
                    masp = "sp" + macs.ToString() + "0" + (mdr.GetInt16("MAX(RIGHT(masp,length(masp)-2-length(macs)-1))")+1).ToString();
                }
                mdr.Close();
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
                throw ex;
            }




        }

        public void Update(MySqlConnection conn, string masp, string tensp, string donvi,
            int macs)
        {
            try
            {
                conn.Open();
                string sql = "Update `SanPham`" +
                    " Set `tensp`=@tensp, `donvi`=@donvi, `macs`=@macs" +
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
                throw ex;
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
