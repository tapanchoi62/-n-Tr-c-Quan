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
    public class TaiKhoan
    {
        MySqlConnection conn = DBConnect.GetDBConnection();
        private int manv;
        private int matk;
        private string tentk;
        private string matkhau;
        private string quyen;

        private NhanVien nv;
        public TaiKhoan()
        {
            quyen = null;
        }
        public NhanVien getnv()
        {
            if (nv == null)
            {
                NhanVienBAL a = new NhanVienBAL();
                nv = a.GetByID(conn, manv);
            }
            return nv;
        }

        public int Manv { get => manv; set => manv = value; }
        public int Matk { get => matk; set => matk = value; }
        public string Tentk { get => tentk; set => tentk = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Quyen { get => quyen; set => quyen = value; }
    }
}
