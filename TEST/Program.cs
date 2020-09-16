using DoAnTrucQuan.BAL;
using DoAnTrucQuan.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection ...");
            MySqlConnection conn = DBConnect.GetDBConnection();

            try
            {
                Console.WriteLine("Openning Connection ...");

                PhieuDKBAL a = new PhieuDKBAL();

                foreach (var item in a.GetAll(conn))

                {
                    foreach (var item1 in item.get())
                    {
                        Console.WriteLine(item1.get().Tenchitieu);
                    }
                }
                

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            

            Console.Read();
        }
    }
}
