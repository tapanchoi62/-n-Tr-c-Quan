using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoSoSX.DAO
{
    class Thongke
    {
        string chiTieu;
        int soLuong;

        public Thongke()
        {
            this.chiTieu = null;
            this.soLuong = 0;
        }

        public Thongke(string chitieu, int soluong)
        {
            this.chiTieu = chitieu;
            this.soLuong = soluong;
        }

        public  string chitieu { get => this.chiTieu; set => this.chiTieu = value; }
        public int soluong { get => this.soLuong; set => this.soLuong = value; }
    }
}
