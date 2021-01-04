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
    public partial class FormQuanLiChatLuong : Form
    {
        private Form parent;
        public FormQuanLiChatLuong()
        {
            InitializeComponent();
            GetDGVChiTieu();
        }

        public FormQuanLiChatLuong(Form par)
        {
            this.parent = par;
            InitializeComponent();
            GetDGVChiTieu();
        }
        void GetDGVChiTieu()
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            ChiTieuBAL ChiTieu = new ChiTieuBAL();
            var CT = ChiTieu.GetAll(conn);
            DGVChiTieu.Rows.Clear();
            foreach (var c in CT)
            {
                DGVChiTieu.Rows.Add(c.Mact, c.Tenchitieu, c.Ynghia);
            }
        }
        private void GetThongTinbt_Click(object sender, EventArgs e)
        {
            GetDGVChiTieu();
        }

        private void xoaChiTieu(string maCT)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                ChiTieuBAL ChiTieu = new ChiTieuBAL();
                ChiTieu.Delete(conn, maCT);
                GetDGVChiTieu();
                MessageBox.Show("Xoá thành công", "Thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void Xoabt_Click(object sender, EventArgs e)
        {
            xoaChiTieu(txtMaChiTieu.Text);  
        }

        private void CheckTT()
        {
            if (txtTenChiTieu.Text == "" || txtYNghia.Text == "")
                throw new Exception("Không được để trống thông tin");
        }


        private void suaChiTieu(string maCT,string tenCT,string yNghia)
        {
            try
            {
                CheckTT();
                MySqlConnection conn = DBConnect.GetDBConnection();
                ChiTieuBAL ChiTieu = new ChiTieuBAL();
                ChiTieu.Update(conn, maCT, tenCT, yNghia);
                GetDGVChiTieu();
                MessageBox.Show("Sửa thông tin thành công", "Thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void Suabt_Click(object sender, EventArgs e)
        {
            suaChiTieu(txtMaChiTieu.Text,txtTenChiTieu.Text,txtYNghia.Text);
        }

        private void themChiTieu(string tenCT,string yNghia)
        {
            try
            {
                CheckTT();
                MySqlConnection conn = DBConnect.GetDBConnection();
                ChiTieuBAL ChiTieu = new ChiTieuBAL();
                ChiTieu.Insert(conn, tenCT, yNghia);
                GetDGVChiTieu();
                MessageBox.Show("Thêm thành công", "Thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void Thembt_Click(object sender, EventArgs e)
        {
            themChiTieu(txtTenChiTieu.Text,txtYNghia.Text);
        }

        private void DGVChiTieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >=0)
            {
                txtMaChiTieu.Text = DGVChiTieu.Rows[index].Cells[0].Value.ToString();
                txtTenChiTieu.Text = DGVChiTieu.Rows[index].Cells[1].Value.ToString();
                txtYNghia.Text = DGVChiTieu.Rows[index].Cells[2].Value.ToString();
            }
            
        }

        private void FormQuanLiChatLuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        void SearchChiTieu(string key )
        {
            if (key == "")
            {
                DGVChiTieu.Rows.Clear();
                return;
            }
            MySqlConnection conn = DBConnect.GetDBConnection();
            ChiTieuBAL ChiTieu = new ChiTieuBAL();
            var lstChiTieu = ChiTieu.SearchByInfo(conn,key );
            DGVChiTieu.Rows.Clear();
            foreach(var ct in lstChiTieu)
                DGVChiTieu.Rows.Add(ct.Mact, ct.Tenchitieu, ct.Ynghia);
        }
        private void SearchChiTieubt_Click(object sender, EventArgs e)
        {
            SearchChiTieu(txtTimChiTieu.Text);
        }

        private void txtSearchChiTieu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                SearchChiTieu(txtTimChiTieu.Text);
        }

   
    }
}
