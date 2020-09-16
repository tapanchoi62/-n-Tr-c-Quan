using DoAnTrucQuan.BAL;
using DoAnTrucQuan.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTrucQuan.DAO
{
    public class CTPhieuKN
    {
        MySqlConnection conn = DBConnect.GetDBConnection();
        private int cskn;
        private int cskq;
        private string mact;
        private string spkn;
        private ChiTieu ChiTieu;
        private CTPhieuKN list;
        public ChiTieu getCT()
        {
            if (this.ChiTieu == null)
            {
                ChiTieuBAL db = new ChiTieuBAL();
                ChiTieu = db.GetByID(conn, mact);

            }
            return ChiTieu;
        }
        public CTPhieuKN get()
        {
            if (list == null)
            {
                CTPhieuKNBAL a = new CTPhieuKNBAL();

                this.list = a.GetByspkn(conn, spkn);

            }
            return list;
        }
        public int Cskn { get => cskn; set => cskn = value; }
        public int Cskq { get => cskq; set => cskq = value; }
        public string Mact { get => mact; set => mact = value; }
        public string Spkn { get => spkn; set => spkn = value; }
    }
}
