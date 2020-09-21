using QuanLyCoSoSX.BAL;
using QuanLyCoSoSX.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoSoSX.DAO
{
    public class CSSX
    {
        MySqlConnection conn = DBConnect.GetDBConnection();

        private string diachi;
        private int macs;
        private string sodt;
        private string tenchu;
        private string tencs;

        private List<SanPham> list;
        
        public List<SanPham> get()
        {
            if(list == null)
            {
                SanPhamBAL a = new SanPhamBAL();
                this.list = a.GetByMacs(conn, macs);
            }
            return list;
        }


        public string Diachi { get => diachi; set => diachi = value; }
        public int Macs { get => macs; set => macs = value; }
        public string Sodt { get => sodt; set => sodt = value; }
        public string Tenchu { get => tenchu; set => tenchu = value; }
        public string Tencs { get => tencs; set => tencs = value; }
    }
}
