
using QuanLyCoSoSX.DTO;
using QuanLyCoSoSX.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyCoSoSX.BAL
{
    public class NhanVienBAL
    {
        MySqlConnection conn = DBConnect.GetDBConnection();

        public List<NhanVien> GetAll(MySqlConnection conn)
        {
            conn.Open();

            string sql = "SELECT * FROM NhanVien";

            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
            List<NhanVien> list = new List<NhanVien>();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    NhanVien a = new NhanVien();
                    a.Manv = rdr.GetInt16("manv");
                    a.Tennv = rdr.GetString("tennv");
                    a.Ngsinh = rdr.GetDateTime("ngsinh");
                    a.Gioitinh = rdr.GetString("gioitinh");
                    a.Mapb = rdr.GetString("mapb");
                    a.Sdt = rdr.GetString("sdt");
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }

        public bool CheackMaNV(MySqlConnection conn, int manv)
        {
            conn.Open();
            string sql = "SELECT * FROM nhanvien Where manv =@id";
            var cmd = new MySqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("@id", manv);
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
        public NhanVien GetByID(MySqlConnection conn, int id)
        {
            conn.Open();
            NhanVien a = new NhanVien();
            string sql = "SELECT * FROM NhanVien where manv= @id";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    a.Manv = rdr.GetInt16("manv");
                    a.Tennv = rdr.GetString("tennv");
                    a.Ngsinh = rdr.GetDateTime("ngsinh");
                    a.Gioitinh = rdr.GetString("gioitinh");
                    a.Mapb = rdr.GetString("mapb");
                    a.Sdt = rdr.GetString("sdt");

                }
            }
            conn.Close();
            return a;
        }
        public void Insert(MySqlConnection conn, string tennv, string ngsinh, 
            string gioitinh, string mapb,string sdt)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO `NhanVien` (`tennv`, `ngsinh`, `gioitinh`, `mapb`,`sdt`)" +
                    " VALUES (@tennv, @ngsinh, @gioitinh,@mapb,@sdt);";
                var cmd = new MySqlCommand(sql, conn);
              
                cmd.Parameters.AddWithValue("@tennv", tennv);
                cmd.Parameters.AddWithValue("@ngsinh", ngsinh);
                cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                cmd.Parameters.AddWithValue("@mapb", mapb);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }




        }

        public void Update(MySqlConnection conn, int manv, string tennv, string ngsinh,
            string gioitinh, string mapb, string sdt)
        {
            try
            {
                conn.Open();
                string sql = "Update `NhanVien` Set `tennv`=@tennv, `ngsinh`=@ngsinh, `gioitinh`=@gioitinh," +
                    "`mapb`=@mapb,`sdt`=@sdt where manv =@manv;";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@manv", manv);
                cmd.Parameters.AddWithValue("@tennv", tennv);
                cmd.Parameters.AddWithValue("@ngsinh", ngsinh);
                cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                cmd.Parameters.AddWithValue("@mapb", mapb);
                cmd.Parameters.AddWithValue("@sdt", sdt);



                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }
        }

        public void Delete(MySqlConnection conn, int manv)
        {
            try
            {
                conn.Open();
                string sql = "Delete from NhanVien where manv= @manv";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@manv", manv);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }
        }

        public List<NhanVien> FindNV(MySqlConnection conn,string key)
        {
            conn.Open();
            string sql = "Select manv,tennv,ngsinh,gioitinh,phongban.mapb,sdt from nhanvien,phongban where nhanvien.mapb=phongban.mapb";
            if (key.Length > 0)
            {
                sql = sql + " AND (manv LIKE '%" + key + "%' OR tennv LIKE '%" + key + "%'"
                + "OR CAST(ngsinh AS CHAR) LIKE '%" + key + "%' OR gioitinh LIKE '%" + key + "%'"
                + "OR sdt LIKE '%" + key + "%' OR tenpb LIKE '%" + key + "%')";
            }
            else
            {
                return null;
            }
            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
            List<NhanVien> list = new List<NhanVien>();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    NhanVien a = new NhanVien();
                    a.Manv = rdr.GetInt16("manv");
                    a.Tennv = rdr.GetString("tennv");
                    a.Ngsinh = rdr.GetDateTime("ngsinh");
                    a.Gioitinh = rdr.GetString("gioitinh");
                    a.Mapb = rdr.GetString("mapb");
                    a.Sdt = rdr.GetString("sdt");
                    list.Add(a);
                }

            }
            conn.Close();
            return list;
        }
          
    }
}
