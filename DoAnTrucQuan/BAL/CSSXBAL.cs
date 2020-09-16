
using DoAnTrucQuan.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTrucQuan.BAL
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
        public CSSX GetByID(MySqlConnection conn, int id)
        {
            conn.Open();
            CSSX a = new CSSX();
            string sql = "SELECT * FROM CSSX where macs= @id";

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
            conn.Close();
            return a;
        }
        public void Insert(MySqlConnection conn, int macs, string tencs, string diachi, string tenchu, string sodt)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO `cssx` (`macs`, `tencs`, `diachi`, `tenchu`, `sodt`) VALUES (@macs, @tencs, @diachi, @tenchu,@sodt);";
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
                Console.WriteLine("That bai," + ex.Message);
            }




        }

        public void Update(MySqlConnection conn, int macs, string tencs,
            string diachi, string tenchu, string sodt)
        {
            try
            {
                conn.Open();
                string sql = "Update `cssx` Set `tencs`=@tencs, `diachi`=@diachi, `tenchu`=@tenchu," +
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
                string sql = "Delete from CSSX where macs= @macs";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@macs", macs);




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
