
using QuanLyCoSoSX.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoSoSX.BAL
{
    
    public class ChiTieuBAL
    {
        

        public List<ChiTieu> GetAll(MySqlConnection conn)
        {
            conn.Open();
            
            string sql = "SELECT * FROM chitieu";

            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
            List<ChiTieu> list = new List<ChiTieu>();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    ChiTieu a = new ChiTieu();
                    a.Mact =  rdr.GetString(0);
                    a.Tenchitieu = rdr.GetString(1);
                    a.Ynghia = rdr.GetString(2);
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }
        public ChiTieu GetByID(MySqlConnection conn,string id)
        {
            conn.Open();
          
            string sql = "SELECT * FROM chitieu where mact= @id";

            var cmd = new MySqlCommand(sql, conn);
            
            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader rdr = cmd.ExecuteReader();
            ChiTieu a = new ChiTieu();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    
                    a.Mact = rdr.GetString(0);
                    a.Tenchitieu = rdr.GetString(1);
                    a.Ynghia = rdr.GetString(2);
                    

                }
            }
            conn.Close();
            return a;
        }

        public string GetIDByTenCT(MySqlConnection conn, string tenct)
        {
            conn.Open();

            string sql = "SELECT * FROM chitieu where tenct= @tenct";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@tenct", tenct);
            string Mact = null;
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                   Mact = rdr.GetString(0);
                }
            }
            conn.Close();
            return Mact;
        }
        public List<ChiTieu> SearchByInfo(MySqlConnection conn, string info)
        {
           
            conn.Open();
            string sqlcommand = "select * from chitieu where mact like '%"+  info +"%'" + " or tenct like '%" +  info + "%' or ynghia like '%" + info + "%'";
            MySqlCommand cmd = new MySqlCommand(sqlcommand, conn);
            MySqlDataReader data = cmd.ExecuteReader();
            List<ChiTieu> lstChiTieu = new List<ChiTieu>();
            if(data.HasRows)
            {
                while(data.Read())
                {
                    ChiTieu ct = new ChiTieu();
                    ct.Mact = data.GetString("mact");
                    ct.Tenchitieu = data.GetString("tenct");
                    ct.Ynghia = data.GetString("ynghia");
                    lstChiTieu.Add(ct);
                }
            }
            return lstChiTieu;
        }

        public bool IsExist(MySqlConnection conn, string tenct, string ynghia)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM chitieu WHERE tenct=@tenct AND ynghia=@ynghia";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tenct",tenct);
                cmd.Parameters.AddWithValue("@ynghia", ynghia);
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
        public void Insert(MySqlConnection conn,string tenct,string ynghia)
        {
            try
            {
                if (IsExist(conn,tenct,ynghia))
                    throw new Exception("Thông tin chỉ tiêu đã tồn tại");
                else
                {
                    conn.Open();
                    string sqlmasp = "SELECT MAX(RIGHT(mact,length(mact)-2)) FROM chitieu";
                    var cmd1 = new MySqlCommand(sqlmasp, conn);
                    MySqlDataReader mdr = cmd1.ExecuteReader();
                    string mact = "CT01";
                    if (mdr.HasRows)
                    {
                        mdr.Read();
                        string i = (mdr.GetInt16("MAX(RIGHT(mact,length(mact)-2))") + 1).ToString();
                        mact = "CT";
                        for (int t = 0; t < 2 - i.Length; t++)
                            mact += "0";
                        mact += i;
                    }
                    mdr.Close();
                    string sql = "INSERT INTO chitieu(mact,tenct, ynghia) VALUES (@mact, @tenct, @ynghia)";
                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@mact", mact);
                    cmd.Parameters.AddWithValue("@tenct", tenct);
                    cmd.Parameters.AddWithValue("@ynghia", ynghia);

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

        public void Update(MySqlConnection conn, string mact, string tenct, string ynghia)
        {
            try
            {
                if (IsExist(conn, tenct, ynghia))
                    throw new Exception("Thông tin chỉ tiêu bị trùng lặp");
                else
                {
                    conn.Open();
                    string sql = "UPDATE chitieu SET tenct= @tenct,ynghia=@ynghia WHERE chitieu.mact = @mact";
                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@mact", mact);
                    cmd.Parameters.AddWithValue("@tenct", tenct);
                    cmd.Parameters.AddWithValue("@ynghia", ynghia);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }    
                    
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(MySqlConnection conn, string mact)
        {
            try
            {
                conn.Open();
                string sql = "Delete from chitieu where mact= @mact";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mact", mact);
            



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
