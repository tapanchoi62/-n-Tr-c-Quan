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
        private void GetDGVDSPheuDK()
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
            GetDGVDSPheuDK();
        }

        private void CheckNgay()
        {
            try
            {
                DateTime day1 = DateTime.Parse(txtNgayDK.Value.ToString("yyyy/MM/dd"));
                DateTime day2 = DateTime.Parse(txtNgayHH.Value.ToString("yyyy/MM/dd"));
                if (day1 > day2)
                    throw new Exception("Ngày đăng ký không đuọc nhỏ hơn ngày hết hạn");
            }
            catch
            {
                throw new Exception("Định dạng ngày không hợp lệ");
            }
           
            
        }

        private void themPhieuDangKy(int maCS,string maSP,string ngayDK,string ngayHH,int soLuong)
        {
            try
            {
                
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhieuDKBAL bdPhieuDK = new PhieuDKBAL();
                
                bdPhieuDK.Insert(conn, maCS, maSP, ngayDK, ngayHH, soLuong);
                GetDGVDSPheuDK();
                MessageBox.Show("Thêm thông tin phiếu đăng ký thành công", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                checkTTPhieuDK();
                string soPDK = txtSoPDK.Text;
                int maCS = int.Parse(txtMaCS.Text);
                string maSP = txtMaSP.Text;
                string ngayDK = txtNgayDK.Value.ToString("yyyy/MM/dd");
                string ngayHH = txtNgayHH.Value.ToString("yyyy/MM/dd");
                int soLuong = int.Parse(txtSoLuong.Text);
                themPhieuDangKy(maCS, maSP, ngayDK, ngayHH, soLuong);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
        }


        private void xoaPhieuDangKy(string soPDK)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhieuDKBAL dbPhieuDK = new PhieuDKBAL();
                dbPhieuDK.Delete(conn, soPDK);
                GetDGVDSPheuDK();
                MessageBox.Show("Xoá thông tin phiếu đăng ký thành công", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            var select = MessageBox.Show("Nếu tiếp tục hệ thống sẽ xoá toàn bộ các dữ liệu có liên quan đến phiếu đăng ký này. Bạn có muốn tiếp tục không ?", "Cảnh báo!", MessageBoxButtons.YesNoCancel);
            if (select == DialogResult.Yes)
            {
                string soPDK = txtSoPDK.Text;
                xoaPhieuDangKy(soPDK);
            }
            

        }
        void checkTTPhieuDK()
        {
            CheckNgay();
            if (txtMaCS.Text == "")
                throw new Exception("Vui lòng chọn cơ sở sản xuất đăng ký");
            if (txtMaSP.Text == "")
                throw new Exception("Vui lòng chọn sản phẩm đăng ký");
            try
            {
                int soLuong;
                soLuong = int.Parse(txtSoLuong.Text);
                if (soLuong < 0)
                {
                    throw new Exception("Số lượng không thể là số âm");
                }
            }
            catch
            {
                throw new Exception("Số lượng phải là một số nguyên");
            }
        }

        void checkTTCTPhieuDK()
        {
            
            if (txtMaCT.Text == "")
                throw new Exception("Vui lòng chọn chỉ tiêu đăng ký");
            try
            {
                int cs;
                cs = int.Parse(txtCSDK.Text);
            }
            catch
            {
                throw new Exception("Chỉ số đăng ký phải là một số nguyên");
            }


        }
        private void suaPhieuDangKy(string soPhieuDK,int maCS, string maSP,string ngayDK,string ngayHH,int soLuong)
        {
            try
            {
                
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhieuDKBAL dbPhieuDK = new PhieuDKBAL();
                dbPhieuDK.Update(conn, soPhieuDK, maCS, maSP, ngayDK, ngayHH, soLuong);
                GetDGVDSPheuDK();
                MessageBox.Show("Sửa thông tin phiếu đăng ký thành công", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                checkTTPhieuDK();
                string soPhieuDK = txtSoPDK.Text;
                int maCS = int.Parse(txtMaCS.Text);
                string maSP = txtMaSP.Text;
                string ngayDK = txtNgayDK.Value.ToString("yyyy/MM/dd");
                string ngayHH = txtNgayHH.Value.ToString("yyyy/MM/dd");
                int soLuong = int.Parse(txtSoLuong.Text);
                suaPhieuDangKy(soPhieuDK, maCS, maSP, ngayDK, ngayHH, soLuong);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            

        }

              

        private void suaCTPhieuDangKy(string spDK,string maCT,int csDK)
        {
            try
            {
                
                MySqlConnection conn = DBConnect.GetDBConnection();
                CTPhieuDKBAL dbCTPDK = new CTPhieuDKBAL();
                dbCTPDK.Update(conn, maCT, spDK, csDK);
                GetPanelThongTin(spDK);
                GetPanelThaoTac(spDK);
                MessageBox.Show("Sửa thông tin chi tiết phiếu đăng ký thành công", "Thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
        }

        private void btSuaCTP_Click(object sender, EventArgs e)
        {
            try
            {
                checkTTCTPhieuDK();
                string maCT = txtMaCT.Text;
                string spDK = txtSoPDK.Text;
                int csDK = int.Parse(txtCSDK.Text);
                suaCTPhieuDangKy(spDK, maCT, csDK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
          
        }

        private void btGetTT_Click(object sender, EventArgs e)
        {
            GetDGVDSPheuDK();
        }

        private void timPhieuDangKy(string key)
        {
            
            try
            {
                DGVDSPhieuDK.Rows.Clear();
                if (key == "")
                    return;
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhieuDKBAL dbPhieuDK = new PhieuDKBAL();
                List<PhieuDK> phieudk;
                phieudk = dbPhieuDK.SearchByInfo(conn, key);
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
            timPhieuDangKy(txtTTTimKiem.Text);
        }
        
        private void GetDGVDSCT(PhieuDK phieuDK)
        {
            var dsPhieu = phieuDK.get();
            DGVDSChiTieu.Rows.Clear();
            foreach (var phieu in dsPhieu)
            {
                var chitieu = phieu.get();
                var row = new string[] {chitieu.Mact, chitieu.Tenchitieu, chitieu.Ynghia, phieu.Csdk.ToString() };
                DGVDSChiTieu.Rows.Add(row);
            }
            if (DGVDSChiTieu.Rows.Count > 0)
                cbTenCT.SelectedValue = DGVDSChiTieu.Rows[0].Cells[0].Value.ToString();
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
            cbCSSX.DisplayMember = "Tencs";
            cbCSSX.ValueMember = "Macs";
            cbCSSX.DataSource = CoSoSanXuat.GetAll(conn);
            cbTenCT.DisplayMember = "Tenchitieu";
            cbTenCT.ValueMember = "Mact";
            cbTenCT.DataSource = ChiTieu.GetAll(conn);
            
        }
        private void GetPanelThaoTac(String ID)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            PhieuDKBAL dbPhieuDK = new PhieuDKBAL();
            PhieuDK phieudk = dbPhieuDK.GetByID(conn, ID);
            txtSoPDK.Text = phieudk.Spdk;
            var CSSX = phieudk.getCoso();
            cbCSSX.SelectedValue = CSSX.Macs;
            var SanPham = phieudk.getSanPham();
            cbTenSP.SelectedValue = SanPham.Masp;
            txtNgayDK.Value = phieudk.Ngdk;
            txtNgayHH.Value = phieudk.Nghh;
            txtSoLuong.Text = phieudk.sl.ToString();
            
        }

        private void DSPhieuDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0&& DGVDSPhieuDK.Rows[e.RowIndex].Cells[0].Value!=null)
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
            if (DGVDSChiTieu.Rows.Count <= 0)
                return;
            MySqlConnection conn = DBConnect.GetDBConnection();
            try
            {
                txtMaCT.Text = cbTenCT.SelectedValue.ToString();
                PhieuDKBAL dbPhieuDK = new PhieuDKBAL();
                var phieuDK = dbPhieuDK.GetByID(conn, txtSoPDK.Text);
                if (phieuDK == null)
                    return;

                var lstCTPhieu = phieuDK.get();
                foreach (var CTPhieu in lstCTPhieu)
                {
                    if (CTPhieu.get().Mact == cbTenCT.SelectedValue.ToString())
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
        
        private void xoaDuLieuPanelThaoTac()
        {
            DGVDSChiTieu.Rows.Clear();
            txtCSDK.Text = "";
            txtSoLuong.Text = "";
        }

        private void cbCSSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            xoaDuLieuPanelThaoTac();
            MySqlConnection conn = DBConnect.GetDBConnection();
            txtMaCS.Text = cbCSSX.SelectedValue.ToString();
            CSSXBAL dbCSSX = new CSSXBAL();
            var cssx = dbCSSX.GetByID(conn,int.Parse(txtMaCS.Text));
            var lstSanPham = cssx.get();
            cbTenSP.DisplayMember = "Tensp";
            cbTenSP.ValueMember = "Masp";
            cbTenSP.DataSource = lstSanPham;
        }

        private void txtTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            xoaDuLieuPanelThaoTac();
            txtMaSP.Text = cbTenSP.SelectedValue.ToString();
        }

        private void txtMaPhieu_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                timPhieuDangKy(txtTTTimKiem.Text);
            }
        }

        private void FormQuanLyPhieuDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parent.Show();
        }

        private void xoaCTPhieuDangKy(string spdk,string maCT)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                CTPhieuDKBAL dbCTPhieuDK = new CTPhieuDKBAL();
              
                dbCTPhieuDK.Delete(conn, maCT, spdk);
                GetPanelThongTin(spdk);
                GetPanelThaoTac(spdk);
                MessageBox.Show("Xoá thông tin chi tiết phiếu đăng ký thành công", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void btXoaCTP_Click(object sender, EventArgs e)
        {

            string maCT = txtMaCT.Text;
            string spdk = txtSoPDK.Text;
            xoaCTPhieuDangKy(spdk, maCT);
        }

        private void themCTPhieuDangKy(string maCT,string sPDK, int csDK)
        {
            try
            {    
                MySqlConnection conn = DBConnect.GetDBConnection();
                CTPhieuDKBAL dbCTPhieuDK = new CTPhieuDKBAL();
                dbCTPhieuDK.Insert(conn, maCT, sPDK, csDK);
                GetPanelThongTin(sPDK);
                GetPanelThaoTac(sPDK);
                MessageBox.Show("Thêm thông tin chi tiết phiếu đăng ký thành công", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
        }
        private void btThemCTP_Click(object sender, EventArgs e)
        {
            try
            {
                checkTTCTPhieuDK();
                string maCT = txtMaCT.Text;
                string sPDK = txtSoPDK.Text;
                int csDK = int.Parse(txtCSDK.Text);
                themCTPhieuDangKy(maCT, sPDK, csDK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
            
            

        }

        private void DGVDSChiTieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0&& DGVDSChiTieu.Rows[e.RowIndex].Cells[0].Value != null)
            {
                cbTenCT.SelectedValue = DGVDSChiTieu.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void txtNgayDK_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void drawCTPhieu(Graphics g, float x, float y,string tenct, string yNghia, int chiso)
        {
            Font font = new Font("Times New Roman", 13);
            Font Name =  new Font("Times New Roman", 13,FontStyle.Bold);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            RectangleF NameOfCollum1 = new RectangleF(x, y, 150, 25);
            RectangleF NameOfCollum2 = new RectangleF(x + 150, y, 350, 25);
            RectangleF NameOfCollum3 = new RectangleF(x + 150 + 350, y, 150, 25);
            RectangleF[] NameRects = new RectangleF[] { NameOfCollum1,NameOfCollum2,NameOfCollum3 };
            g.DrawString("Tên chỉ tiêu", Name, Brushes.Black, NameOfCollum1, sf);
            g.DrawString("Ý nghĩa", Name, Brushes.Black,NameOfCollum2, sf);
            g.DrawString("Chỉ số đăng ký", Name, Brushes.Black, NameOfCollum3, sf);
            g.DrawRectangles(Pens.Black, NameRects);
            SizeF s =  g.MeasureString(yNghia, font, 350);
            float height = s.Height <= 130 ? 130 : s.Height + 10;
            RectangleF collum1 = new RectangleF(x,y+25,150, height);
            RectangleF collum2 = new RectangleF(x + 150, y+25, 350, height);
            RectangleF collum3 = new RectangleF(x + 150 + 350, y+25, 150, height);
            RectangleF[] rects = new RectangleF[] {collum1,collum2,collum3};
            g.DrawString(tenct, font, Brushes.Black, collum1,sf);
            g.DrawString(yNghia, font, Brushes.Black, collum2,sf);
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
                    gp.DrawString("Đăng ký chất lượng sản phậm với các tiêu chí sau:", font, Brushes.Black, new PointF(x, 327));
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
                        ChiTieuBAL CTBAL = new ChiTieuBAL();
                        ChiTieu chitieu = CTBAL.GetByID(conn, ctphieu[numofitem].Mact);
                        drawCTPhieu(gp, x, yct, chitieu.Tenchitieu,chitieu.Ynghia, ctphieu[numofitem].Csdk);
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
            if(txtSoPDK.Text =="")
            {
                MessageBox.Show("Vui lòng chọn phiếu đăng ký ", "Lỗi");
            }
            else
            {
                this.printPreviewDialog1.Document = this.printDocument1;
                this.printPreviewDialog1.ShowDialog();
            }    
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.printDocument1.Print();
        }

        private void FormQuanLyPhieuDangKy_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                GetDGVDSPheuDK();
            }
            
        }

        
    }
}
