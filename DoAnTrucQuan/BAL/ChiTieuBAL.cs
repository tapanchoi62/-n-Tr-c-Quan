
using DoAnTrucQuan.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTrucQuan.BAL
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
        public void Insert(MySqlConnection conn,string mact,string tenct,string ynghia)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO chitieu(mact,tenct, ynghia) VALUES (@mact, @tenct, @ynghia)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mact", mact);
                cmd.Parameters.AddWithValue("@tenct", tenct);
                cmd.Parameters.AddWithValue("@ynghia", ynghia);

                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
            }
      
            
           
          
        }

        public void Update(MySqlConnection conn, string mact, string tenct, string ynghia)
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine("That bai," + ex.Message);
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
                Console.WriteLine("That bai," + ex.Message);
            }
        }
    }
}
