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
    public class PhieuKN
    {

        MySqlConnection conn = DBConnect.GetDBConnection();
        private string spkn;
        private int manv;
        private string masp;
        private DateTime ngkn;
        private string spdk;
        private string KL;

        private NhanVien nv;

        private PhieuDK phieudk;
        private SanPham sanpham;
        public NhanVien getnv()
        {
            if(nv == null)
            {
                NhanVienBAL a = new NhanVienBAL();
                nv = a.GetByID(conn, manv);
            }
            return nv;
        }
        public SanPham getSanPham()
        {
            if (sanpham == null)
            {
                SanPhamBAL a = new SanPhamBAL();
                sanpham = a.GetByID(conn, masp);
            }
            return sanpham;
        }

        public PhieuDK getPhieudk()
        {
            if(phieudk == null)
            {
                PhieuDKBAL a = new PhieuDKBAL();
                phieudk = a.GetByID(conn, spdk);
            }
            return phieudk;
        }

        public string Spkn { get => spkn; set => spkn = value; }
        public int Manv { get => manv; set => manv = value; }
        public string Masp { get => masp; set => masp = value; }
        public DateTime Ngkn { get => ngkn; set => ngkn = value; }
        public string Spdk { get => spdk; set => spdk = value; }
        public string KL1 { get => KL; set => KL = value; }
    }
}
