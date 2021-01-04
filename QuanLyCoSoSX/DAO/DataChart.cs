using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCoSoSX.DAO;

namespace QuanLyCoSoSX.DAO
{
    class DataChart
    {
        List<Thongke> lstThongKe;
        public DataChart()
        {
            this.lstThongKe = new List<Thongke>();
        }
        public void Add(string chitieu, int soluong)
        {
            foreach(var thongke in lstThongKe)
            {
                if(chitieu == thongke.chitieu)
                {
                    thongke.soluong+=soluong;
                    return;
                }
            }

            Thongke tk = new Thongke(chitieu, soluong);
            lstThongKe.Add(tk);
        }

        public void Del(string chitieu, int soluong)
        {
            foreach (var thongke in lstThongKe)
            {
                if (chitieu == thongke.chitieu)
                {
                    thongke.soluong -= soluong;
                    return;
                }
            }
        }

        public List<Thongke> Data { get => lstThongKe; set => lstThongKe = value; }
    }
}
