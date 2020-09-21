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
    public class PhieuDK
    {
        MySqlConnection conn = DBConnect.GetDBConnection();

        private string spdk;
        private DateTime ngdk;
        private DateTime nghh;
        private int macs;
        private string masp;
        private int SL;
        private SanPham sanpham;
        private List<CTPhieuDK> list;
        private CSSX coso;

        public CSSX getCoso()
        {
            if (coso == null)
            {
                CSSXBAL a = new CSSXBAL();
                coso = a.GetByID(conn, macs);
            }
            return coso;
        }
        public SanPham getSanPham()
        {
            if(sanpham == null)
            {
                SanPhamBAL a = new SanPhamBAL();
                sanpham = a.GetByID(conn, masp);
            }
            return sanpham;
        }

        public List<CTPhieuDK> get()
        {
            if(list == null)
            {
                CTPhieuDKBAL a = new CTPhieuDKBAL();

                this.list = a.GetByspdk(conn,spdk);

            }
            return list;
        }

       

        public string Spdk { get => spdk; set => spdk = value; }
        public DateTime Ngdk { get => ngdk; set => ngdk = value; }
        public DateTime Nghh { get => nghh; set => nghh = value; }
        public int Macs { get => macs; set => macs = value; }
        public string Masp { get => masp; set => masp = value; }
        public int sl { get => SL; set => SL = value; }
    }
}
