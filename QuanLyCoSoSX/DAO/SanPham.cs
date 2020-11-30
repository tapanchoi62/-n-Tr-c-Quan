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
    public class SanPham
    {
        MySqlConnection conn = DBConnect.GetDBConnection();

        private string masp;
        private int macs;
        private string tensp;
        private string donvi;

        private CSSX Coso;

        public CSSX getCS()
        {
            if(Coso == null)
            {
                CSSXBAL a = new CSSXBAL();
                this.Coso = a.GetByID(conn, macs);

            }
            return Coso;
        }

        public string Masp { get => masp; set => masp = value; }
        public int Macs { get => macs; set => macs = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public string Donvi { get => donvi; set => donvi = value; }
    }
}
