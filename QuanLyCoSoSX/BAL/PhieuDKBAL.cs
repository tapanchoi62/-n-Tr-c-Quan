using QuanLyCoSoSX.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace QuanLyCoSoSX.BAL
{
    public class PhieuDKBAL
    {
        public List<PhieuDK> GetAll(MySqlConnection conn)
        {
            conn.Open();

            string sql = "SELECT * FROM phieudangky";

            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
            List<PhieuDK> list = new List<PhieuDK>();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    PhieuDK a = new PhieuDK();
                    a.Macs = rdr.GetInt16("macs");
                    a.Masp = rdr.GetString("masp");
                    a.Ngdk = rdr.GetDateTime("ngdk");
                    a.Nghh = rdr.GetDateTime("nghh");
                    a.sl = rdr.GetInt32("SL");
                    a.Spdk = rdr.GetString("spdk");
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }

        public PhieuDK GetByID(MySqlConnection conn,string id)
        {
            conn.Open();
            string sql = "SELECT * FROM phieudangky where spdk= @id";;
            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {

                PhieuDK a = new PhieuDK();
                while (rdr.Read())
                {
                    a.Macs = rdr.GetInt16("macs");
                    a.Masp = rdr.GetString("masp");
                    a.Ngdk = rdr.GetDateTime("ngdk");
                    a.Nghh = rdr.GetDateTime("nghh");
                    a.sl = rdr.GetInt32("SL");
                    a.Spdk = rdr.GetString("spdk");
                    
                    
                }
                conn.Close();
                return a;
            }
            else
            {
                conn.Close();
                return null;
            }

        }

        public List<PhieuDK> GetByCSSX(MySqlConnection conn, string cssx)
        {
            conn.Open();
            string sqlcommand = "SELECT * FROM phieudangky WHERE macs = @macs";
            MySqlCommand cmd = new MySqlCommand(sqlcommand, conn);
            cmd.Parameters.AddWithValue("@macs", cssx);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<PhieuDK> lstPhieuDK = new List<PhieuDK>();
            if (rdr.HasRows)
            {
                
                while(rdr.Read())
                {
                    PhieuDK a = new PhieuDK();
                    a.Macs = rdr.GetInt16("macs");
                    a.Masp = rdr.GetString("masp");
                    a.Ngdk = rdr.GetDateTime("ngdk");
                    a.Nghh = rdr.GetDateTime("nghh");
                    a.sl = rdr.GetInt32("SL");
                    a.Spdk = rdr.GetString("spdk");
                    lstPhieuDK.Add(a);
                }
                
                
                
            }
            conn.Close();
            return lstPhieuDK;
        }

        public List<PhieuDK> GetByNgDK(MySqlConnection conn, string tungay,string denngay)
        {
            conn.Open();
            string sqlcommand = "SELECT * FROM phieudangky WHERE ngdk >= @tungay AND ngdk <= @denngay";
            MySqlCommand cmd = new MySqlCommand(sqlcommand, conn);
            cmd.Parameters.AddWithValue("@tungay", tungay);
            cmd.Parameters.AddWithValue("@denngay", denngay);
            List<PhieuDK> lstPhieuDK = new List<PhieuDK>();
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
               
                while (rdr.Read())
                {
                    PhieuDK a = new PhieuDK();
                    a.Macs = rdr.GetInt16("macs");
                    a.Masp = rdr.GetString("masp");
                    a.Ngdk = rdr.GetDateTime("ngdk");
                    a.Nghh = rdr.GetDateTime("nghh");
                    a.sl = rdr.GetInt32("SL");
                    a.Spdk = rdr.GetString("spdk");
                    lstPhieuDK.Add(a);
                }
               


            }
            conn.Close();
            return lstPhieuDK;
        }

        public List<PhieuDK> GetByNgHH(MySqlConnection conn, string tungay, string denngay)
        {
            conn.Open();
            string sqlcommand = "SELECT * FROM phieudangky WHERE nghh >= @tungay AND nghh <= @denngay";
            MySqlCommand cmd = new MySqlCommand(sqlcommand, conn);
            cmd.Parameters.AddWithValue("@tungay", tungay);
            cmd.Parameters.AddWithValue("@denngay", denngay);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<PhieuDK> lstPhieuDK = new List<PhieuDK>();
            if (rdr.HasRows)
            {
               
                while (rdr.Read())
                {
                    PhieuDK a = new PhieuDK();
                    a.Macs = rdr.GetInt16("macs");
                    a.Masp = rdr.GetString("masp");
                    a.Ngdk = rdr.GetDateTime("ngdk");
                    a.Nghh = rdr.GetDateTime("nghh");
                    a.sl = rdr.GetInt32("SL");
                    a.Spdk = rdr.GetString("spdk");
                    lstPhieuDK.Add(a);
                }
              


            }
            conn.Close();
            return lstPhieuDK;
        }
        public List<PhieuDK> SearchByInfo(MySqlConnection conn, string id)
        {
            
            string sql= null;
            List<PhieuDK> lstPhieuDK = new List<PhieuDK>();
            MySqlCommand cmd;
            DateTime dateValue;
           
            if (DateTime.TryParseExact(id, "d/M/yyyy",CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
            {
                conn.Open();
                string strdate = dateValue.ToString("yyyy/MM/dd");
                sql = "SELECT * FROM phieudangky WHERE ngdk = @id OR nghh = @id";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", strdate);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    
                    while (rdr.Read())
                    {
                        PhieuDK a = new PhieuDK();
                        a.Macs = rdr.GetInt16("macs");
                        a.Masp = rdr.GetString("masp");
                        a.Ngdk = rdr.GetDateTime("ngdk");
                        a.Nghh = rdr.GetDateTime("nghh");
                        a.sl = rdr.GetInt32("SL");
                        a.Spdk = rdr.GetString("spdk");
                        lstPhieuDK.Add(a);
                    }
                }
                conn.Close();
            }
            else
            {
                SanPhamBAL sanpham = new SanPhamBAL();
                List<string> lstid = sanpham.GetIDByName(conn, id);
                if(lstid.Count<=0)
                {

                    conn.Open();
                    sql = "SELECT * FROM phieudangky WHERE spdk LIKE '%" + id + "%' OR macs LIKE '%" + id+ "%'";
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            PhieuDK a = new PhieuDK();
                            a.Macs = rdr.GetInt16("macs");
                            a.Masp = rdr.GetString("masp");
                            a.Ngdk = rdr.GetDateTime("ngdk");
                            a.Nghh = rdr.GetDateTime("nghh");
                            a.sl = rdr.GetInt32("SL");
                            a.Spdk = rdr.GetString("spdk");
                            lstPhieuDK.Add(a);
                        }
                    }
                    conn.Close();
                }
                else
                    foreach (var idsp in lstid)
                    {
                        conn.Open();
                        sql = "SELECT * FROM phieudangky WHERE spdk LIKE '% " +id +"%' OR macs LIKE '%" + id + "%' OR masp = @id";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", idsp);
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                PhieuDK a = new PhieuDK();
                                a.Macs = rdr.GetInt16("macs");
                                a.Masp = rdr.GetString("masp");
                                a.Ngdk = rdr.GetDateTime("ngdk");
                                a.Nghh = rdr.GetDateTime("nghh");
                                a.sl = rdr.GetInt32("SL");
                                a.Spdk = rdr.GetString("spdk");
                                lstPhieuDK.Add(a);
                            }
                        }
                        conn.Close();
                    }
            }
            
            
            return lstPhieuDK;
        }

        public bool IsExist(MySqlConnection conn,int macs, string masp,string ngdk,string nghh)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM phieudangky WHERE macs=@macs AND masp=@masp AND ngdk = @ngdk AND nghh = @nghh";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@macs", macs);
                cmd.Parameters.AddWithValue("@masp", masp);
                cmd.Parameters.AddWithValue("@ngdk", ngdk);
                cmd.Parameters.AddWithValue("@nghh", nghh);
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

        public void Insert(MySqlConnection conn, int macs, 
            string masp,string ngdk,string nghh,int sl)
        {
            try
            {
                if (IsExist(conn, macs,masp,ngdk,nghh))
                    throw new Exception("Thông tin phiếu đăng ký đã tồn tại");
                else
                {
                    conn.Open();
                    string sqlspdk = "SELECT MAX(RIGHT(spdk,length(spdk)-3)) FROM phieudangky";
                    var cmd1 = new MySqlCommand(sqlspdk, conn);
                    MySqlDataReader mdr = cmd1.ExecuteReader();
                    string spdk = "PDK0001";
                    if (mdr.HasRows)
                    {
                        mdr.Read();
                        string i = (mdr.GetInt16("MAX(RIGHT(spdk,length(spdk)-3))") + 1).ToString();
                        spdk = "PDK";
                        for (int t = 0; t < 4 - i.Length; t++)
                            spdk += "0";
                        spdk += i;

                    }

                    mdr.Close();
                    string sql = "INSERT INTO `phieudangky` (`spdk`, `ngdk`, `nghh`, `macs`, `masp`, `sl`)" +
                        " VALUES (@spdk, @ngdk, @nghh, @macs, @masp, @sl);";
                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@spdk", spdk);
                    cmd.Parameters.AddWithValue("@ngdk", ngdk);
                    cmd.Parameters.AddWithValue("@nghh", nghh);
                    cmd.Parameters.AddWithValue("@macs", macs);
                    cmd.Parameters.AddWithValue("@masp", masp);
                    cmd.Parameters.AddWithValue("@sl", sl);
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

        public void Update(MySqlConnection conn, string spdk, int macs,
            string masp, string ngdk, string nghh, int sl)
        {
            try
            {
                if (IsExist(conn, macs, masp, ngdk, nghh))
                    throw new Exception("Thông tin phiếu đăng ký bị trùng lặp");
                else
                {
                    conn.Open();
                    string sql = "UPDATE `phieudangky` " +
                    "SET `ngdk` = @ngdk, `nghh` = @nghh, `macs` = @macs, `masp` = @masp, `sl` = @sl " +
                    "WHERE `phieudangky`.`spdk` = @spdk;";
                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@spdk", spdk);
                    cmd.Parameters.AddWithValue("@ngdk", ngdk);
                    cmd.Parameters.AddWithValue("@nghh", nghh);
                    cmd.Parameters.AddWithValue("@macs", macs);
                    cmd.Parameters.AddWithValue("@masp", masp);
                    cmd.Parameters.AddWithValue("@sl", sl);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }    
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(MySqlConnection conn, string spdk)
        {
            try
            {
                conn.Open();
                string sql = "Delete from phieudangky where spdk= @spdk";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@spdk", spdk);
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
