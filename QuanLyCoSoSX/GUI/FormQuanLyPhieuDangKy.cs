using System;
using QuanLyCoSoSX.BAL;
using QuanLyCoSoSX.DAO;
using QuanLyCoSoSX.DTO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyCoSoSX.GUI
{
    public partial class FormQuanLyPhieuDangKy : Form
    {
        private Form parent;
        private void GetDGV()
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            try
            {
                DGVDSPhieuDK.Rows.Clear();
                PhieuDKBAL dbPDK = new PhieuDKBAL();
                foreach (var phieudk in dbPDK.GetAll(conn))
                {
                    SanPham sanPhandk = phieudk.getSanPham();
                    string[] row = new string[] { phieudk.Spdk, sanPhandk.Tensp, phieudk.Ngdk.ToString("dd/MM/yyyy"), phieudk.Nghh.ToString("dd/MM/yyyy") };
                    DGVDSPhieuDK.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
        }
        public FormQuanLyPhieuDangKy()
        {
            InitializeComponent();
            txtNgayDK.CustomFormat = "dd/MM/yyyy";
            txtNgayHH.CustomFormat = "dd/MM/yyyy";
            GetPanelThaoTac();
            
        }
        public FormQuanLyPhieuDangKy(ManHinhQuanLyNhanVien par)
        {
            this.parent = par;
            InitializeComponent();
            txtNgayDK.CustomFormat = "dd/MM/yyyy";
            txtNgayHH.CustomFormat = "dd/MM/yyyy";
            GetPanelThaoTac();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhieuDKBAL bdPhieuDK = new PhieuDKBAL();
                string soPDK = txtSoPDK.Text;
                int maCS = int.Parse(txtMaCS.Text);
                string maSP = txtMaSP.Text;
                string ngayDK = txtNgayDK.Value.ToString("yyyy/MM/dd");
                string ngayHH = txtNgayHH.Value.ToString("yyyy/MM/dd");
                int soLuong = int.Parse(txtSoLuong.Text);
                bdPhieuDK.Insert(conn, soPDK, maCS, maSP, ngayDK, ngayHH, soLuong);
                GetPanelThongTin(soPDK);
                GetDGV();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
           
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            try
            {
                PhieuDKBAL dbPhieuDK = new PhieuDKBAL();
                string soPDK = txtSoPDK.Text;
                dbPhieuDK.Delete(conn, soPDK);
                GetDGV();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
           
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            try
            {
                PhieuDKBAL dbPhieuDK = new PhieuDKBAL();
                string soPhieuDK = txtSoPDK.Text;
                int maCS = int.Parse(txtMaCS.Text);
                string maSP = txtMaCS.Text;
                string ngayDK = txtNgayDK.Text;
                string ngayHH = txtNgayHH.Text;
                int soLuong = int.Parse(txtSoLuong.Text);
                dbPhieuDK.Update(conn, soPhieuDK, maCS, maSP, ngayDK, ngayHH, soLuong);
                GetDGV();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Thất bại");
            }
            
        }

        private void btThemCTP_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            try
            {
                CTPhieuDKBAL dbCTPhieuDK = new CTPhieuDKBAL();
                string maCT = cbMaCT.Text;
                string spDK = cbTenSP.Text;
                int csDK = int.Parse(txtCSDK.Text);
                dbCTPhieuDK.Insert(conn, maCT, spDK, csDK);
                GetPanelThongTin(txtSoPDK.Text);
                GetPanelThaoTac(txtSoPDK.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Thất bại");
            }
        }

        private void btXoaCTP_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            try
            {
                CTPhieuDKBAL dbCTPhieuDK = new CTPhieuDKBAL();
                string maCT = cbMaCT.Text;
                string spdk = txtSoPDK.Text;
                dbCTPhieuDK.Delete(conn, maCT, spdk);
                GetPanelThongTin(txtSoPDK.Text);
                GetPanelThaoTac(txtSoPDK.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
            
        }

        private void btSuaCTP_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            try
            {
                CTPhieuDKBAL dbCTPDK = new CTPhieuDKBAL();
                string maCT = txtMaCT.Text;
                string spDK = txtSoPDK.Text;
                int csDK = int.Parse(txtCSDK.Text);
                dbCTPDK.Update(conn, maCT, spDK, csDK);
                GetPanelThongTin(txtSoPDK.Text);
                GetPanelThaoTac(txtSoPDK.Text);

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message,"Thất bại");
            }
        }

        private void btGetTT_Click(object sender, EventArgs e)
        {

            GetDGV();
        }

        private void SearchByID()
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            try
            {
                PhieuDKBAL dbPhieuDK = new PhieuDKBAL();
                PhieuDK phieudk;
                phieudk = dbPhieuDK.GetByID(conn, txtMaPhieu.Text);
                DGVDSPhieuDK.Rows.Clear();
                var row = new string[]
                { phieudk.Spdk,
                  phieudk.getSanPham().Tensp,
                  phieudk.Ngdk.ToString("dd/MM/yyyy"),
                  phieudk.Nghh.ToString("dd/MM/yyyy")
                };
                DGVDSPhieuDK.Rows.Add(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "That bai");
            }
        }
        private void btTim_Click(object sender, EventArgs e)
        {
            SearchByID();
        }
        
        private void GetDGVDSCT(PhieuDK phieuDK)
        {
            var dsPhieu = phieuDK.get();
            DGVDSChiTieu.Rows.Clear();
            foreach (var phieu in dsPhieu)
            {
                var chitieu = phieu.get();
                var row = new string[] { chitieu.Tenchitieu, chitieu.Ynghia, phieu.Csdk.ToString() };
                DGVDSChiTieu.Rows.Add(row);
            }
        }
        private void GetPanelThongTin(string ID)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            PhieuDKBAL dbPhieuDk = new PhieuDKBAL();
            PhieuDK phieuDK = dbPhieuDk.GetByID(conn,ID);
            txtSoPDK1.Text = phieuDK.Spdk;
            txtNgayDK1.Text = phieuDK.Ngdk.ToString("dd/MM/yyyy");
            txtNgayHH1.Text = phieuDK.Nghh.ToString("dd/MM/yyyy");
            var cssx = phieuDK.getCoso();
            txtCSSX1.Text = cssx.Tencs;
            var sanPham = phieuDK.getSanPham();
            txtTenSP1.Text = sanPham.Tensp;
            txtSoLuong1.Text = phieuDK.sl.ToString();
            GetDGVDSCT(phieuDK);
        }

        private void GetPanelThaoTac()
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            PhieuDKBAL dbPhieuDK = new PhieuDKBAL();
            var lstPhieuDK = dbPhieuDK.GetAll(conn);
            foreach(var phieudk in lstPhieuDK)
            {
                var CSSX = phieudk.getCoso();
                cbCSSX.Items.Add(CSSX.Tencs);
                cbMaCSSX.Items.Add(CSSX.Macs);
                
            }

            ChiTieuBAL dbChiTieu = new ChiTieuBAL();
            var lstChiTieu = dbChiTieu.GetAll(conn);
            foreach(var chitieu in lstChiTieu)
            {
                cbTenCT.Items.Add(chitieu.Tenchitieu);
                cbMaCT.Items.Add(chitieu.Mact);
                
            }
        }
        private void GetPanelThaoTac(String ID)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            PhieuDKBAL dbPhieuDK = new PhieuDKBAL();
            PhieuDK phieudk = dbPhieuDK.GetByID(conn, ID);
            txtSoPDK.Text = phieudk.Spdk;
            var CSSX = phieudk.getCoso();
            cbCSSX.SelectedItem = CSSX.Tencs;
            var SanPham = phieudk.getSanPham();
            cbTenSP.SelectedItem = SanPham.Tensp;
            txtNgayDK.Value = phieudk.Ngdk;
            txtNgayHH.Value = phieudk.Nghh;
            txtSoLuong.Text = phieudk.sl.ToString();
            
        }

        private void DSPhieuDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                string ID = DGVDSPhieuDK.Rows[e.RowIndex].Cells[0].Value.ToString();
                GetPanelThaoTac(ID);
                GetPanelThongTin(ID);
            }
           
            
        }

        private void cbTenCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            try
            {
                txtMaCT.Text = cbMaCT.Items[cbTenCT.SelectedIndex].ToString();
                PhieuDKBAL dbPhieuDK = new PhieuDKBAL();
                var phieuDK = dbPhieuDK.GetByID(conn, txtSoPDK.Text);
                var lstCTPhieu = phieuDK.get();
                foreach (var CTPhieu in lstCTPhieu)
                {
                    if (CTPhieu.get().Mact == cbMaCT.Items[cbTenCT.SelectedIndex].ToString())
                    {
                        txtCSDK.Text = CTPhieu.Csdk.ToString();
                        break;
                    }
                    else
                    {
                        txtCSDK.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi");
            }
            
        }

        private void cbCSSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            txtMaCS.Text = cbMaCSSX.Items[cbCSSX.SelectedIndex].ToString();
            CSSXBAL dbCSSX = new CSSXBAL();
            var cssx = dbCSSX.GetByID(conn,int.Parse(txtMaCS.Text));
            var lstSanPham = cssx.get();
            cbTenSP.Items.Clear();
            cbMaSP.Items.Clear();
            foreach(var sanpham in lstSanPham)
            {
                cbTenSP.Items.Add(sanpham.Tensp);
                cbMaSP.Items.Add(sanpham.Masp);
            }
            
        }

        private void txtTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaSP.Text = cbMaSP.Items[cbTenSP.SelectedIndex].ToString();
        }

        private void txtMaPhieu_KeyDown(object sender, KeyEventArgs e)
        {
            SearchByID();
        }

        private void FormQuanLyPhieuDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parent.Show();
        }
    }
}
