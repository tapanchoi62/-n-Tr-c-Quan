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

        private void themSanPham(string tenSP,string dvTinh,int maCS)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            SanPhamBAL sanpham = new SanPhamBAL();
            try
            {
                sanpham.Insert(conn,tenSP, dvTinh, maCS);
                GetDGV();
                MessageBox.Show("Thêm thông tin sản phẩm thành công", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi");
            }
        }
        private void Thembt_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTT();
                themSanPham(txtTensp.Text, txtDonvitinh.Text, Convert.ToInt32(txtMaCSSX.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi");
            }
           

        }

        private void suaSanPham(string maSP,string tenSP,string dvTinh,int maCS)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            SanPhamBAL sanpham = new SanPhamBAL();
            try
            {
                sanpham.Update(conn, maSP, tenSP, dvTinh, maCS);
                GetDGV();
                MessageBox.Show("Sửa thông tin sản phẩm thành công", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void Suabt_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTT();
                suaSanPham(txtMasp.Text, txtTensp.Text, txtDonvitinh.Text, Convert.ToInt32(txtMaCSSX.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
           
        }

        private void xoaSanPham(string maSP)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            SanPhamBAL sanpham = new SanPhamBAL();
            try
            {
                if (maSP == "")
                    throw new Exception("Không thành công! Vui lòng chọn sản phẩm cần xoá");
                sanpham.Delete(conn, maSP);
                GetDGV();
                MessageBox.Show("Xoá thông tin sản phẩm thành công", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void Xoabt_Click(object sender, EventArgs e)
        {

            var select = MessageBox.Show("Nếu tiếp tục hệ thống sẽ xoá toàn bộ các dữ liệu có liên quan đến sản phẩm này. Bạn có muốn tiếp tục không ?", "Cảnh báo!", MessageBoxButtons.YesNoCancel);
            if(select==DialogResult.Yes)
            {
                xoaSanPham(txtMasp.Text);
            }  
           
        }

        private void timSanPham(string key)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            SanPhamBAL sanpham = new SanPhamBAL();                
            try
            {
                DGVSanPham.Rows.Clear();
                List<SanPham> lstSanPham = sanpham.SearchByInfo(conn, key);
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
           timSanPham(txtTimSanPham.Text);

        }

        private void DGVSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0&& DGVSanPham.Rows[e.RowIndex].Cells[3].Value!=null)
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
            if(cbCSSX.SelectedValue!=null)
                txtMaCSSX.Text = cbCSSX.SelectedValue.ToString();
        }

       

        private void FormSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parent.Show();
        }

        private void txtTimSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timSanPham(txtTimSanPham.Text);
            }
        }
    }
}
