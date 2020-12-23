using System;
using QuanLyCoSoSX.BAL;
using QuanLyCoSoSX.DAO;
using QuanLyCoSoSX.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QuanLyCoSoSX.GUI
{
    public partial class FormSanPham : Form
    {
        Form parent;
        public FormSanPham()
        {
            InitializeComponent();
            GetThongTin();
            GetDGV();
        }

        public FormSanPham(ManHinhQuanLyNhanVien par)
        {
            this.parent = par;
            InitializeComponent();
            GetThongTin();
            GetDGV();
        }
        private void GetThongTin()
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            CSSXBAL cssx = new CSSXBAL();
            List<CSSX> LstCSSX = cssx.GetAll(conn);
            cbCSSX.DisplayMember = "Tencs";
            cbCSSX.ValueMember = "Macs";
            cbCSSX.DataSource = LstCSSX;
        }
        private void GetDGV()
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            try
            {
                DGVSanPham.Rows.Clear();
                SanPhamBAL sp = new SanPhamBAL();
                List<SanPham> lSanPham = sp.GetAll(conn);
                foreach (SanPham spp in lSanPham)
                {
                    DGVSanPham.Rows.Add(spp.Masp, spp.Tensp, spp.Donvi, spp.getCS().Tencs);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi");
            }
        }

        private void GetThongTinbt_Click(object sender, EventArgs e)
        {
            GetDGV();
        }

        private void CheckTT()
        {
            if (txtTensp.Text == "")
                throw new Exception("Tên sản phẩm không được để trống");
            if (txtDonvitinh.Text == "")
                throw new Exception("Đơn vị tính không được để trống");
            if (txtMaCSSX.Text == "")
                throw new Exception("Cơ sở sản xuất không được để trống");
        }
        private void Thembt_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            SanPhamBAL sanpham = new SanPhamBAL();
            try
            {
                sanpham.Insert(conn, txtTensp.Text, txtDonvitinh.Text, Convert.ToInt32(txtMaCSSX.Text));
                GetDGV();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi");
            }

        }

        private void Suabt_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            SanPhamBAL sanpham = new SanPhamBAL();
            try
            {
                CheckTT();
                sanpham.Update(conn, txtMasp.Text, txtTensp.Text, txtDonvitinh.Text, Convert.ToInt32(txtMaCSSX.Text));
                GetDGV();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Loi");
            }
        }

        private void Xoabt_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            SanPhamBAL sanpham = new SanPhamBAL();
            try
            {
                CheckTT();
                sanpham.Delete(conn, txtMasp.Text);
                GetDGV();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Loi");
            }
            
        }

        private void SearchByID()
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            SanPhamBAL sanpham = new SanPhamBAL();                
            try
            {
                DGVSanPham.Rows.Clear();
                List<SanPham> lstSanPham = sanpham.SearchByInfo(conn, txtFindByID.Text);
                foreach(var sp in lstSanPham)
                {
                    DGVSanPham.Rows.Add(sp.Masp, sp.Tensp, sp.Donvi, sp.getCS().Tencs);
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi");
            }
        }
        private void TraCuuKiemNghiem_Click(object sender, EventArgs e)
        {
            SearchByID();

        }

        private void DGVSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                int index = e.RowIndex;
                txtMasp.Text = DGVSanPham.Rows[index].Cells[0].Value.ToString();
                txtTensp.Text = DGVSanPham.Rows[index].Cells[1].Value.ToString();
                txtDonvitinh.Text = DGVSanPham.Rows[index].Cells[2].Value.ToString();
                MySqlConnection conn = DBConnect.GetDBConnection();
                CSSXBAL DBCSSX = new CSSXBAL();
                   
                cbCSSX.SelectedValue = DBCSSX.GetIDByName(conn, DGVSanPham.Rows[index].Cells[3].Value.ToString());
            }    
        }

        private void cbCSSX_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtMaCSSX.Text = cbCSSX.SelectedValue.ToString();
        }

        private void txtFindByID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchByID();
            }
        }

        private void FormSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parent.Show();
        }
    }
}
