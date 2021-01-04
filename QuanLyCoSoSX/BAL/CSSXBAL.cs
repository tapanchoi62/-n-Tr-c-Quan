
using QuanLyCoSoSX.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoSoSX.BAL
{
    

    public class CSSXBAL

    {
        public List<CSSX> GetAll(MySqlConnection conn)
        {
            conn.Open();

            string sql = "SELECT * FROM cssx";

            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
            List<CSSX> list = new List<CSSX>();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    CSSX a = new CSSX();
                    a.Macs = rdr.GetInt16("macs");
                    a.Tenchu = rdr.GetString("tenchu");
                    a.Tencs = rdr.GetString("tencs");
                    a.Diachi = rdr.GetString("diachi");
                    a.Sodt = rdr.GetString("sodt");
                    list.Add(a);
                }
            }
            conn.Close();
            return list;
        }

        public int GetIDByName(MySqlConnection conn, string name)
        {
            conn.Open();
            string sqlcommand = "SELECT * FROM cssx WHERE tencs LIKE '%" + name + "%'";
            MySqlCommand cmd = new MySqlCommand(sqlcommand, conn);
            MySqlDataReader data = cmd.ExecuteReader();
            if(data.HasRows)
            {
                int macs = -1;
                while (data.Read())
                {
                    macs = data.GetInt16("macs");
                        
                }
                conn.Close();
                return macs;
            }
            else
            {
                conn.Close();
                return -1;
            }
        }
        public CSSX GetByID(MySqlConnection conn, int id)
        {
            conn.Open();
            CSSX a = new CSSX();
            string sql = "SELECT * FROM cssx where macs= @id";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    a.Macs = rdr.GetInt16("macs");
                    a.Tenchu = rdr.GetString("tenchu");
                    a.Tencs = rdr.GetString("tencs");
                    a.Diachi = rdr.GetString("diachi");
                    a.Sodt = rdr.GetString("sodt");

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


        public List<CSSX> SearchByInfo(MySqlConnection conn, string info)
        {
            conn.Open();
            string sqlcommand = "select * from cssx where macs like '%" + info +"%' or tenchu like '%"+ info + "%' or tencs like '%" + info +"%' or diachi like '%" + info +"%' or sodt like '" + info + "'";
            MySqlCommand cmd = new MySqlCommand(sqlcommand, conn);
            
            MySqlDataReader data = cmd.ExecuteReader();
            List<CSSX> lstCSSX = new List<CSSX>();
            if (data.HasRows)
            {
                while(data.Read())
                {
                    CSSX cssx = new CSSX();
                    cssx.Macs = data.GetInt16("macs");
                    cssx.Tenchu = data.GetString("tenchu");
                    cssx.Tencs = data.GetString("tencs");
                    cssx.Diachi = data.GetString("diachi");
                    cssx.Sodt = data.GetString("sodt");
                    lstCSSX.Add(cssx);
                }
            }

            return lstCSSX;
            
        }
        public void Insert(MySqlConnection conn, string tencs, string diachi, string tenchu, string sodt)
        {
            try
            {
                conn.Open();

                string slqmacs = "SELECT MAX(macs) FROM cssx";
                var cmd1 = new MySqlCommand(slqmacs, conn);
                MySqlDataReader mrd =  cmd1.ExecuteReader();
                int macs = 1;
                if(mrd.HasRows)
                {
                    mrd.Read();
                    macs = mrd.GetInt16("MAX(macs)") + 1;
                }

                mrd.Close();
                string sql = "INSERT INTO cssx (`macs`, `tencs`, `diachi`, `tenchu`, `sodt`) VALUES (@macs, @tencs, @diachi, @tenchu,@sodt);";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@macs", macs);
                cmd.Parameters.AddWithValue("@tencs", tencs);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@tenchu", tenchu);
                cmd.Parameters.AddWithValue("@sodt", sodt);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }




        }

        public void Update(MySqlConnection conn, int macs, string tencs,
            string diachi, string tenchu, string sodt)
        {
            try
            {
                conn.Open();
                string sql = "Update cssx Set `tencs`=@tencs, `diachi`=@diachi, `tenchu`=@tenchu," +
                    "`sodt`=@sodt where macs =@macs;";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@macs", macs);
                cmd.Parameters.AddWithValue("@tencs", tencs);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@tenchu", tenchu);
                cmd.Parameters.AddWithValue("@sodt", sodt);



                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }
        }

        public void Delete(MySqlConnection conn, string macs)
        {
            try
            {
                conn.Open();
                SanPhamBAL SPBAL = new SanPhamBAL();
                SPBAL.DeleteByCSSX(conn,macs);
                string sql = "Delete from cssx where macs= @macs";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@macs", macs);
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
