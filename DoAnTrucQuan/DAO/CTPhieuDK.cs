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

    public class CTPhieuDK
    {
        MySqlConnection conn = DBConnect.GetDBConnection();
        
        private int csdk;
        private string mact;
        private string spdk;
        private ChiTieu ChiTieu;
        public ChiTieu get()
        {
            if (this.ChiTieu == null)
            {
                ChiTieuBAL db = new ChiTieuBAL();
                ChiTieu = db.GetByID(conn, mact);

            }
            return ChiTieu;
        }
        public int Csdk { get => csdk; set => csdk = value; }
        public string Mact { get => mact; set => mact = value; }
        public string Spdk { get => spdk; set => spdk = value; }

        
    }
}
