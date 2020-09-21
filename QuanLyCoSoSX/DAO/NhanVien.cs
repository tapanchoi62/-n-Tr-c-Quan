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
    public class NhanVien
    {
        MySqlConnection conn = DBConnect.GetDBConnection();
        private int manv;
        private string gioitinh;
        private string mapb;
        private DateTime ngsinh;
        private string sdt;
        private string tennv;

        private PhongBan pb;

        public PhongBan getpb()
        {
            if(pb == null)
            {
                PhongBanBAL a = new PhongBanBAL();
                pb = a.GetByID(conn, mapb);
            }
            return pb;
        }


        public int Manv { get => manv; set => manv = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Mapb { get => mapb; set => mapb = value; }
        public DateTime Ngsinh { get => ngsinh; set => ngsinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Tennv { get => tennv; set => tennv = value; }
    }
}
