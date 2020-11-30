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
using System.Globalization;
using System.Runtime;
namespace QuanLyCoSoSX.GUI
{
    public partial class FormQuanLyPhieuDangKy : Form
    {
        private Form parent;
        private void GetDGV()
        {
            
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
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
            txtNgayDK.Format = DateTimePickerFormat.Custom;
            txtNgayHH.Format = DateTimePickerFormat.Custom;
            txtNgayDK.CustomFormat = "dd/MM/yyyy";
            txtNgayHH.CustomFormat = "dd/MM/yyyy";
            GetPanelThaoTac();
            
        }
        public FormQuanLyPhieuDangKy(ManHinhQuanLyNhanVien par)
        {
            this.parent = par;
            InitializeComponent();
            txtNgayDK.Format = DateTimePickerFormat.Custom;
            txtNgayHH.Format = DateTimePickerFormat.Custom;
            txtNgayDK.CustomFormat = "dd/MM/yyyy";
            txtNgayHH.CustomFormat = "dd/MM/yyyy";
            GetPanelThaoTac();
            GetDGV();
        }

        bool CheckNgay()
        {
            DateTime day1 = DateTime.Parse(txtNgayDK.Value.ToString("yyyy/MM/dd"));
            DateTime day2 = DateTime.Parse(txtNgayHH.Value.ToString("yyyy/MM/dd"));
            if (day1 < day2)
                return true;
            else
                return false;
            
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(!CheckNgay())
                {
                    throw new Exception("Ngày đăng kí và ngày hết hạn không hợp lệ");
                }
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhieuDKBAL bdPhieuDK = new PhieuDKBAL();
                string soPDK = txtSoPDK.Text;
                int maCS = int.Parse(txtMaCS.Text);
                string maSP = txtMaSP.Text;
                string ngayDK = txtNgayDK.Value.ToString("yyyy/MM/dd");
                string ngayHH = txtNgayHH.Value.ToString("yyyy/MM/dd");
                int soLuong = int.Parse(txtSoLuong.Text);
                if (soLuong < 0)
                {
                    throw new Exception("Số lượng không thể là số âm");
                }
                bdPhieuDK.Insert(conn, maCS, maSP, ngayDK, ngayHH, soLuong);
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
            
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
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
            try
            {
                if (!CheckNgay())
                    throw new Exception("Ngày đăng ký, ngày hết hạn không hợp lệ");
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhieuDKBAL dbPhieuDK = new PhieuDKBAL();
                string soPhieuDK = txtSoPDK.Text;
                int maCS = int.Parse(txtMaCS.Text);
                string maSP = txtMaSP.Text;
                string ngayDK = txtNgayDK.Value.ToString("yyyy/MM/dd");
                string ngayHH = txtNgayHH.Value.ToString("yyyy/MM/dd");
                int soLuong = int.Parse(txtSoLuong.Text);
                if(soLuong<0)
                {
                    throw new Exception("Số lượng không thể là số âm");
                }
                dbPhieuDK.Update(conn, soPhieuDK, maCS, maSP, ngayDK, ngayHH, soLuong);
                GetDGV();
            }
            catch (Exception ex)
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
                if (csDK < 0)
                    throw new Exception("Chỉ số đăng kí không thể là số âm");
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
            
            try
            {
                DGVDSPhieuDK.Rows.Clear();
                if (txtMaPhieu.Text == "")
                    return;
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhieuDKBAL dbPhieuDK = new PhieuDKBAL();
                List<PhieuDK> phieudk;
                phieudk = dbPhieuDK.SearchByInfo(conn, txtMaPhieu.Text);
                if(phieudk!=null)
                {
                    foreach(var p in phieudk)
                    {
                        var row = new string[]
                    { p.Spdk,
                      p.getSanPham().Tensp,
                      p.Ngdk.ToString("dd/MM/yyyy"),
                      p.Nghh.ToString("dd/MM/yyyy")
                    };
                        DGVDSPhieuDK.Rows.Add(row);
                    }
                    
                }
                
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
            ChiTieuBAL ChiTieu = new ChiTieuBAL();
            CSSXBAL CoSoSanXuat = new CSSXBAL();
            SanPhamBAL SanPham = new SanPhamBAL();
            foreach(var cssx in CoSoSanXuat.GetAll(conn))
            {
                cbCSSX.Items.Add(cssx.Tencs);
                cbMaCSSX.Items.Add(cssx.Macs);
            }
            
            foreach(var sp in SanPham.GetAll(conn) )
            {

                cbTenSP.Items.Add(sp.Tensp);
                cbMaSP.Items.Add(sp.Masp);
            }
            foreach(var ct in ChiTieu.GetAll(conn))
            {
                cbTenCT.Items.Add(ct.Tenchitieu);
                cbMaCT.Items.Add(ct.Mact);
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
                if (DGVDSPhieuDK.Rows[e.RowIndex].Cells[0].Value.ToString()!=null)
                {
                    string ID = DGVDSPhieuDK.Rows[e.RowIndex].Cells[0].Value.ToString();
                    GetPanelThaoTac(ID);
                    GetPanelThongTin(ID);
                }
                    
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
            if(cbTenSP.Items.Count<1)
            {
                cbTenSP.Text = null;
                txtMaSP.Text = null;
            }
            else
            {
                cbTenSP.SelectedIndex = 0;
            }
        }

        private void txtTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaSP.Text = cbMaSP.Items[cbTenSP.SelectedIndex].ToString();
        }

        private void txtMaPhieu_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                SearchByID();
            }
        }

        private void FormQuanLyPhieuDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parent.Show();
        }

        private void btXoaCTP_Click(object sender, EventArgs e)
        {
            
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                CTPhieuDKBAL dbCTPhieuDK = new CTPhieuDKBAL();
                string maCT = txtMaCT.Text;
                string spdk = txtSoPDK.Text;
                dbCTPhieuDK.Delete(conn, maCT, spdk);
                GetPanelThongTin(txtSoPDK.Text);
                GetPanelThaoTac(txtSoPDK.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btThemCTP_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                CTPhieuDKBAL dbCTPhieuDK = new CTPhieuDKBAL();
                string maCT = txtMaCT.Text;
                string spDK = txtSoPDK.Text;
                int csDK = int.Parse(txtCSDK.Text);
                if (csDK < 0)
                    throw new Exception("Chỉ số đăng kí không thể là số âm");
                dbCTPhieuDK.Insert(conn, maCT, spDK, csDK);
                GetPanelThongTin(txtSoPDK.Text);
                GetPanelThaoTac(txtSoPDK.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
        }

        private void DGVDSChiTieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            cbTenCT.SelectedItem = DGVDSChiTieu.Rows[index].Cells[0].Value.ToString();
        }

        private void txtNgayDK_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void drawCTPhieu(Graphics g, float x, float y,string id, int chiso)
        {
            Font font = new Font("Times New Roman", 13);
            Font Name =  new Font("Times New Roman", 13,FontStyle.Bold);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            MySqlConnection conn = DBConnect.GetDBConnection();
            ChiTieuBAL CTBAL= new ChiTieuBAL();
            ChiTieu chitieu = CTBAL.GetByID(conn, id);
            RectangleF NameOfCollum1 = new RectangleF(x, y, 150, 25);
            RectangleF NameOfCollum2 = new RectangleF(x + 150, y, 350, 25);
            RectangleF NameOfCollum3 = new RectangleF(x + 150 + 350, y, 150, 25);
            RectangleF[] NameRects = new RectangleF[] { NameOfCollum1,NameOfCollum2,NameOfCollum3 };
            g.DrawString("Tên chỉ tiêu", Name, Brushes.Black, NameOfCollum1, sf);
            g.DrawString("Ý nghĩa", Name, Brushes.Black,NameOfCollum2, sf);
            g.DrawString("Chỉ số đăng ký", Name, Brushes.Black, NameOfCollum3, sf);
            g.DrawRectangles(Pens.Black, NameRects);
            RectangleF collum1 = new RectangleF(x,y+25,150, 130);
            RectangleF collum2 = new RectangleF(x + 150, y+25, 350, 130);
            RectangleF collum3 = new RectangleF(x + 150 + 350, y+25, 150, 130);
            RectangleF[] rects = new RectangleF[] {collum1,collum2,collum3};
            g.DrawString(chitieu.Tenchitieu, font, Brushes.Black, collum1,sf);
            g.DrawString(chitieu.Ynghia, font, Brushes.Black, collum2,sf);
            g.DrawString(chiso.ToString(), font, Brushes.Black, collum3,sf);
            g.DrawRectangles(Pens.Black, rects);
        }

        private int numofitem = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            if (txtSoPDK.Text != "")
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhieuDKBAL PDKBAL = new PhieuDKBAL();
                PhieuDK phieudk = PDKBAL.GetByID(conn, txtSoPDK.Text);
                float w = e.PageBounds.Width / 2;
                float x = e.MarginBounds.Left;
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                Graphics gp = e.Graphics;
                Font font = new Font("Times New Roman", 12, FontStyle.Bold);
                Font font2 = new Font("Times New Roman", 12);
                RectangleF rect1 = new RectangleF(40, x, 150, 170);
                float yct;
                if(numofitem ==0)
                {
                    gp.DrawString("CỘNG HOÀ XÃ HỘI CHỦ NGHĨA VIỆT NAM", new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new PointF(w, 70), sf);
                    gp.DrawString("Độc lập - Tự do - Hạnh phúc", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(w, 97), sf);
                    gp.DrawString("PHIẾU ĐĂNG KÝ CHẤT LƯỢNG SẢN PHẨM", new Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new PointF(w, 137), sf);
                    gp.DrawString("Số phiếu đăng ký:", font, Brushes.Black, new PointF(x, 177));
                    gp.DrawString(phieudk.Spdk, font2, Brushes.Black, new PointF(x + 150, 177));
                    gp.DrawString("Ngày đăng ký:", font, Brushes.Black, new PointF(x, 207));
                    gp.DrawString(phieudk.Ngdk.ToString("dd/MM/yyyy"), font2, Brushes.Black, new PointF(x + 150, 207));
                    gp.DrawString("Ngày hết hạn:", font, Brushes.Black, new PointF(w + 20, 207));
                    gp.DrawString(phieudk.Nghh.ToString("dd/MM/yyyy"), font2, Brushes.Black, new PointF(w + 170, 207));
                    gp.DrawString("Tên cơ sở sản xuất:", font, Brushes.Black, new PointF(x, 237));
                    gp.DrawString(phieudk.getCoso().Tencs, font2, Brushes.Black, new PointF(x + 150, 237));
                    gp.DrawString("Mã cơ sở sản xuất:", font, Brushes.Black, new PointF(w + 20, 237));
                    gp.DrawString(phieudk.Macs.ToString(), font2, Brushes.Black, new PointF(w + 170, 237));
                    gp.DrawString("Tên sản phẩm:", font, Brushes.Black, new PointF(x, 267));
                    gp.DrawString(phieudk.getSanPham().Tensp, font2, Brushes.Black, new PointF(x + 150, 267));
                    gp.DrawString("Mã sản phẩm", font, Brushes.Black, new PointF(w + 20, 267));
                    gp.DrawString(phieudk.Masp, font2, Brushes.Black, new PointF(w + 170, 267));
                    gp.DrawString("Số lượng", font, Brushes.Black, new PointF(x, 297));
                    gp.DrawString(phieudk.sl.ToString(), font2, Brushes.Black, new PointF(x + 150, 297));
                    gp.DrawString("Đăng kí chất lượng sản phậm với các tiêu chí sau:", font, Brushes.Black, new PointF(x, 327));
                    yct = 367;
                }
                else
                {
                    yct = 70;
                }    
                List<CTPhieuDK> ctphieu = phieudk.get();
                for(;numofitem<ctphieu.Count;numofitem++)
                {
                    if(yct <= e.MarginBounds.Height)
                    {
                        drawCTPhieu(gp, x, yct, ctphieu[numofitem].Mact, ctphieu[numofitem].Csdk);
                        yct += 190;
                    }
                    else
                    {
                        e.HasMorePages = true;
                        break;
                    }
                }    

                if(numofitem == ctphieu.Count)
                {
                    float but = e.PageBounds.Height;
                    gp.DrawString("Ngày lập phiếu: ", font, Brushes.Black, new PointF(w + 100, but - 170));
                    gp.DrawString(DateTime.Now.ToString("dd/MM/yyyy"), font2, Brushes.Black, new PointF(w + 230, but - 170));
                    gp.DrawString("CHI CỤC ĐO LƯỜNG CHẤT LƯỢNG THÀNH PHỐ HỒ CHÍ MINH ", new Font("Times New Roman", 11, FontStyle.Bold), Brushes.Black, new PointF(w + 150, but - 130), sf);
                    gp.DrawString("SỞ KHOA HỌC VÀ CÔNG NGHỆ", new Font("Times New Roman", 11, FontStyle.Bold), Brushes.Black, new PointF(w + 150, but - 100), sf);
                    numofitem = 0;
                    e.HasMorePages = false;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.printDocument1.Print();
        }
    }
}
