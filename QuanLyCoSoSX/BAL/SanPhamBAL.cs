
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

        public List<string> GetIDByName(MySqlConnection conn, string name)
        {
            conn.Open();
            string sqlcommand = "select masp from sanpham where tensp like '%" + name + "%'";
            MySqlCommand cmd = new MySqlCommand(sqlcommand, conn);
            MySqlDataReader data = cmd.ExecuteReader();
            List<string> lstID = new List<string>();
            if(data.HasRows)
            {
                while(data.Read())
                {
                    string id = data.GetString("masp");
                    lstID.Add(id);
                }
            }
            conn.Close();
            return lstID;
        }
        public List<SanPham> SearchByInfo(MySqlConnection conn, string info)
        {
            CSSXBAL cssx = new CSSXBAL();
            int macs = cssx.GetIDByName(conn, info);
            conn.Open();
            string sqlcommand = "SELECT * FROM sanpham WHERE masp LIKE '%" + info +"%' OR tensp LIKE '%" + info +"%' OR donvi LIKE '%" + info+ "%' OR macs LIKE '%" + macs+ "%' OR macs = @info";
            MySqlCommand cmd = new MySqlCommand(sqlcommand,conn);
            cmd.Parameters.AddWithValue("@info", info);
            cmd.Parameters.AddWithValue("@macs",macs);
            MySqlDataReader data = cmd.ExecuteReader();
            List<SanPham> lstSanPham = new List<SanPham>();
            while(data.Read())
            {
                SanPham sp = new SanPham();
                sp.Masp = data.GetString("masp");
                sp.Tensp = data.GetString("tensp");
                sp.Donvi = data.GetString("donvi");
                sp.Macs = data.GetInt16("macs");
                lstSanPham.Add(sp);
            }
            conn.Close();
            return lstSanPham;
            
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

        public bool IsExist(MySqlConnection conn, string tensp, string donvi, int macs)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM sanpham WHERE tensp = @tensp AND donvi = @donvi AND macs = @macs";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tensp", tensp);
                cmd.Parameters.AddWithValue("@donvi", donvi);
                cmd.Parameters.AddWithValue("@macs", macs);
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
        public void Insert(MySqlConnection conn, string tensp, string donvi, int macs)
        {
            try
            {
                if (IsExist(conn, tensp, donvi, macs))
                    throw new Exception("Thông tin sản phẩm đã tồn tại");
                else
                {
                    conn.Open();
                    string sqlmasp = "SELECT MAX(RIGHT(masp,length(masp)-2)) FROM sanpham";
                    var cmd1 = new MySqlCommand(sqlmasp, conn);
                    MySqlDataReader mdr = cmd1.ExecuteReader();
                    string masp = "sp001";
                    if (mdr.HasRows)
                    {
                        mdr.Read();
                        string i = (mdr.GetInt16("MAX(RIGHT(masp,length(masp)-2))") + 1).ToString();
                        masp = "sp";
                        for (int t = 0; t < 3 - i.Length; t++)
                            masp += "0";
                        masp += i;
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
                if (IsExist(conn, tensp, donvi, macs))
                    throw new Exception("Thông tin sản phẩm bị trùng lặp");
                else
                {

                    conn.Open();
                    string sql = "Update `sanpham`" +
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteByCSSX(MySqlConnection conn, string macs)
        {
            string sql2 = "SELECT masp FROM sanpham WHERE macs = @macs";
            var cmd2 = new MySqlCommand(sql2, conn);
            cmd2.Parameters.AddWithValue("@macs", macs);
            MySqlDataReader rdr = cmd2.ExecuteReader();
            List<string> list = new List<string>();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    string a = rdr.GetString("masp");
                    list.Add(a);
                }
            }
            rdr.Close();
            
            foreach(var masp in list)
            {
                PhieuDKBAL PDKBAL = new PhieuDKBAL();
                PDKBAL.DeleteByMasp(conn, masp);
                string sql = "Delete from sanpham where masp= @masp";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@masp", masp);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(MySqlConnection conn, string masp)
        {
            try
            {
                PhieuDKBAL PDKBAL = new PhieuDKBAL();
                PDKBAL.DeleteByMasp(conn, masp);
                conn.Open();
                string sql = "Delete from sanpham where masp= @masp";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@masp", masp);
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
