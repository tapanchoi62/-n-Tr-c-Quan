using QuanLyCoSoSX.BAL;
using QuanLyCoSoSX.DTO;
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

                NhanVienBAL a = new NhanVienBAL();
                a.Insert(conn, "a", "2020-09-16", "Nam", "pb01", "1111");

/*                INSERT INTO `nhanvien` (`tennv`, `ngsinh`, `gioitinh`, `mapb`, `sdt`) VALUES('c', '2020-09-16', 'Nam', 'pb02', 'aaa')
*/
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            

            Console.Read();
        }
    }
}
