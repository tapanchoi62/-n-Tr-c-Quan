using MySql.Data.MySqlClient;
using QuanLyCoSoSX.BAL;
using QuanLyCoSoSX.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoSoSX.GUI
{
    public partial class FormPhongBan : Form
    {
        private Form parent;
        public FormPhongBan()
        {
            InitializeComponent();
            GetDGVPhongBan();
        }
        public FormPhongBan(Form par)
        {
            this.parent = par;
            InitializeComponent();
            GetDGVPhongBan();
        }

        private void FormPhongBan_FormClosed(object sender, FormClosedEventArgs e)
        {          
            this.parent.Show();
        }
        void GetDGVPhongBan()
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            PhongBanBAL PhongBanbal = new PhongBanBAL();
            var pb = PhongBanbal.GetAll(conn);
            DGVPhongBan.Rows.Clear();
            foreach(var pb1 in pb)
            {
                DGVPhongBan.Rows.Add(pb1.Mapb,pb1.Tenpb);
            }
        }

        private void GetThongTinbt_Click(object sender, EventArgs e)
        {
            GetDGVPhongBan();
        }

        private void DGVChiTieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txtMaPhongBan.Text = DGVPhongBan.Rows[index].Cells[0].Value.ToString();
                txtTenPhongBan.Text = DGVPhongBan.Rows[index].Cells[1].Value.ToString();
            }
        }
        void Search(string key)
        {
            if ( key == "")
            {
                GetDGVPhongBan();
                return;
            }
            MySqlConnection conn = DBConnect.GetDBConnection();
            PhongBanBAL PhongBanbal = new PhongBanBAL();
            var pb = PhongBanbal.GetByID(conn, key);
            DGVPhongBan.Rows.Clear();
            DGVPhongBan.Rows.Add(pb.Mapb, pb.Tenpb);
        }

        private void SearchPhongBan_Click(object sender, EventArgs e)
        {
            Search(txtTimPhongBan.Text);
        }

        private void textBoxSearchPhongBan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                Search(txtTimPhongBan.Text);
            }
        }


        private void xoaPhongBan(string maPB)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhongBanBAL PhongBanbal = new PhongBanBAL();
                PhongBanbal.Delete(conn, maPB);
                GetDGVPhongBan();
                MessageBox.Show("Xóa thành công !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
        }
        private void Xoabt_Click(object sender, EventArgs e)
        {
            xoaPhongBan(txtMaPhongBan.Text);
        }

        private void themPhongBan(string maPB,string tenPB)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhongBanBAL PhongBanbal = new PhongBanBAL();
                var pb = PhongBanbal.GetAll(conn);
                if (maPB=="")
                {
                    throw new ArgumentException("mã phòng ban không được trống !");
                }
                foreach (var pb1 in pb)
                {
                    if (pb1.Mapb == maPB)
                    {
                        throw new ArgumentException("mã phòng ban không được trùng lặp !");
                    }
                }
                
                PhongBanbal.Insert(conn, maPB, tenPB);
                GetDGVPhongBan();
                MessageBox.Show("Thêm thành công !", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
        }
        private void Thembt_Click(object sender, EventArgs e)
        {
            themPhongBan(txtMaPhongBan.Text,txtTenPhongBan.Text);
        }

        private void suaPhongBan(string maPB,string tenPB)
        {
            try
            {

                MySqlConnection conn = DBConnect.GetDBConnection();
                PhongBanBAL PhongBanbal = new PhongBanBAL();
                var pb = PhongBanbal.GetAll(conn);
                if (maPB == "")
                {
                    throw new Exception("Mã phòng ban không được trống !");
                }
                PhongBanbal.Update(conn,maPB, tenPB);
                GetDGVPhongBan();
                MessageBox.Show("Sửa thành công !", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
        }
        private void Suabt_Click(object sender, EventArgs e)
        {
            suaPhongBan(txtMaPhongBan.Text, txtTenPhongBan.Text);
        }

       
    }
}
