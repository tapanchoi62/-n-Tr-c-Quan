
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

            string sql = "SELECT * FROM nhanvien";

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

        public List<NhanVien> GetByMaPB(MySqlConnection conn , string mapb)
        {
            conn.Open();
            string sqlcommand = "SELECT * FROM nhanvien WHERE mapb = @mapb";
            MySqlCommand cmd = new MySqlCommand(sqlcommand, conn);
            cmd.Parameters.AddWithValue("@mapb", mapb);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<NhanVien> lstNhanVien = new List<NhanVien>();
            if (rdr.HasRows)
            {
                
                while(rdr.Read())
                {
                    NhanVien a = new NhanVien();
                    a.Manv = rdr.GetInt16("manv");
                    a.Tennv = rdr.GetString("tennv");
                    a.Ngsinh = rdr.GetDateTime("ngsinh");
                    a.Gioitinh = rdr.GetString("gioitinh");
                    a.Mapb = rdr.GetString("mapb");
                    a.Sdt = rdr.GetString("sdt");
                    lstNhanVien.Add(a);
                }
                
            }
            conn.Close();
            return lstNhanVien;


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
            string sql = "SELECT * FROM nhanvien where manv= @id";

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

        public bool IsExist(MySqlConnection conn, string tennv, string ngsinh, string gioitinh,string mapb)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM nhanvien WHERE tennv=@tennv AND ngsinh=@ngsinh AND gioitinh=@gioitinh AND mapb = @mapb";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tennv", tennv);
                cmd.Parameters.AddWithValue("@ngsinh", ngsinh);
                cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                cmd.Parameters.AddWithValue("@mapb", mapb);
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

        public void Insert(MySqlConnection conn, string tennv, string ngsinh, 
            string gioitinh, string mapb,string sdt)
        {
            try
            {
                if (IsExist(conn, tennv, ngsinh, gioitinh,mapb))
                    throw new Exception("Thông tin nhân viên đã tồn tại");
                else
                {
                    conn.Open();
                    string sql = "INSERT INTO `nhanvien` (`tennv`, `ngsinh`, `gioitinh`, `mapb`,`sdt`)" +
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
            }
            catch (Exception ex)
            {
                throw ex;
            }




        }

        public void Update(MySqlConnection conn, int manv, string tennv, string ngsinh,
            string gioitinh, string mapb, string sdt)
        {
            try
            {
                conn.Open();
                string sql = "Update `nhanvien` Set `tennv`=@tennv, `ngsinh`=@ngsinh, `gioitinh`=@gioitinh," +
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
                throw ex;
            }
        }

        public void Delete(MySqlConnection conn, int manv)
        {
            try
            {
                conn.Open();
                string sql = "Delete from nhanvien where manv= @manv";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@manv", manv);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<NhanVien> FindNV(MySqlConnection conn,string key)
        {
            conn.Open();
            List<NhanVien> list = new List<NhanVien>();
            string sql = " Select manv,tennv,ngsinh,gioitinh,mapb,sdt from nhanvien where manv LIKE '%" + key + "%' OR tennv LIKE '%" + key + "%'"
                + "OR CAST(ngsinh AS CHAR) = " + key + " OR gioitinh LIKE '%" + key + "%'"
                + "OR sdt LIKE '%" + key + "%' OR mapb LIKE '%" + key + "%'";
            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
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
