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
    public class CTPhieuKN
    {
        MySqlConnection conn = DBConnect.GetDBConnection();
        private int cskn;
        private int cskq;
        private string mact;
        private string spkn;
        private ChiTieu ChiTieu;
        public ChiTieu getCT()
        {
            if (this.ChiTieu == null)
            {
                ChiTieuBAL db = new ChiTieuBAL();
                ChiTieu = db.GetByID(conn, mact);

            }
            return ChiTieu;
        }
        public int Cskn { get => cskn; set => cskn = value; }
        public int Cskq { get => cskq; set => cskq = value; }
        public string Mact { get => mact; set => mact = value; }
        public string Spkn { get => spkn; set => spkn = value; }
    }
}
