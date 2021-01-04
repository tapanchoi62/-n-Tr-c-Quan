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
using System.Drawing.Drawing2D;
using System.Configuration;


namespace QuanLyCoSoSX.GUI
{
    public partial class FormQuanLiPhieuKiemNghiem : Form
    {
        Form parent;
        private int numofitem = 0;
        public FormQuanLiPhieuKiemNghiem()
        {
            InitializeComponent();
        }
        public FormQuanLiPhieuKiemNghiem(ManHinhQuanLyNhanVien par)
        {
            this.parent = par;
            InitializeComponent();
            GetPanel2();
            GetDGVDSPhieuKiemNghiem();
            dtNgayKN.Format = DateTimePickerFormat.Custom;
            dtNgayKN.CustomFormat = "dd/MM/yyyy";
            
        }   
        private void GetDGVDSPhieuKiemNghiem()
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                DGVDSPhieuKiemNghiem.Rows.Clear();
                PhieuKNBAL dbPKN = new PhieuKNBAL();
                List<PhieuKN> lst = dbPKN.GetAll(conn);

                foreach (var phieukn in dbPKN.GetAll(conn))
                {
                    SanPham sp = phieukn.getSanPham();
                    NhanVien nv = phieukn.getnv();
                    string[] row = new string[] { phieukn.Spkn, phieukn.Ngkn.ToString("dd/MM/yy"), sp.Tensp, nv.Tennv, phieukn.KL1 };
                    DGVDSPhieuKiemNghiem.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
        }  

        private void LayThongTin_Click(object sender, EventArgs e)
        {
            GetDGVDSPhieuKiemNghiem();
        }

       

        public void GetPanel2()
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
          
            cbSanPham.DisplayMember = "Tensp";
            cbSanPham.ValueMember = "Masp";
            NhanVienBAL NVBAL = new NhanVienBAL();
            string mapb = ConfigurationManager.AppSettings["maphongkiemdinh"];
            cbNhanVien.DisplayMember = "Tennv";
            cbNhanVien.ValueMember = "Manv";
            cbNhanVien.DataSource = NVBAL.GetByMaPB(conn,mapb);

            cbChiTieu.DisplayMember = "Tenchitieu";
            cbChiTieu.ValueMember = "Mact";
           

        }

        private void SearchPhieuDK(string spdk)
        {
            DGVPhieuDK.Rows.Clear();
            MySqlConnection conn = DBConnect.GetDBConnection();
            PhieuDKBAL PhieuDKBAL = new PhieuDKBAL();
            PhieuDK phieuDK = PhieuDKBAL.GetByID(conn, spdk);
            if (phieuDK != null)
            {
                textBox3.Text = phieuDK.Spdk;
                textBox4.Text = phieuDK.Ngdk.ToString("dd/MM/yyyy");
                textBox5.Text = phieuDK.Nghh.ToString("dd/MM/yyyy");
                textBox7.Text = phieuDK.getCoso().Tencs;
                textBox8.Text = phieuDK.getSanPham().Tensp;
                textBox9.Text = phieuDK.getSanPham().Donvi;
                textBox10.Text = phieuDK.sl.ToString();
                if (phieuDK.get() != null)
                {
                    foreach (var ctphieu in phieuDK.get())
                    {
                        ChiTieuBAL CTBAL = new ChiTieuBAL();
                        ChiTieu ct = CTBAL.GetByID(conn, ctphieu.Mact);
                        string[] row = new string[] { ct.Mact,ct.Tenchitieu, ct.Ynghia, ctphieu.Csdk.ToString() };
                        DGVPhieuDK.Rows.Add(row);
                    }
                }
            }
            else
            {
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text ="";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text ="";
                textBox10.Text = "";
            }    
        }
       
        private void TraCuuPhieuKiemNghiem(string key)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            PhieuKNBAL PKNBAL = new PhieuKNBAL();
            PhieuKN phieuKN = PKNBAL.GetByID(conn,key);
            DGVDSPhieuKiemNghiem.Rows.Clear();
            SanPhamBAL SPBAL = new SanPhamBAL();
            NhanVienBAL NVBAL = new NhanVienBAL();
            string[] row = new string[] { phieuKN.Spkn, phieuKN.Ngkn.ToString("dd/MM/yyyy"), SPBAL.GetByID(conn, phieuKN.Masp).Tensp, NVBAL.GetByID(conn, phieuKN.Manv).Tennv, phieuKN.KL1 };
            DGVDSPhieuKiemNghiem.Rows.Add(row);
        }
        private void TraCuuKiemNghiem_Click(object sender, EventArgs e)
        {
            TraCuuPhieuKiemNghiem(txtTTTimKiem.Text);
        }

        private void GetDGVChiTieuKN(string soPKN)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            CTPhieuKNBAL CTPKNBAL = new CTPhieuKNBAL();
            ChiTieuBAL CTBAL = new ChiTieuBAL();
            DGVChiTieuKN.Rows.Clear();
            foreach (var ctpkn in CTPKNBAL.GetByspkn(conn, soPKN))
            {
                string[] rows = new string[] { CTBAL.GetByID(conn, ctpkn.Mact).Mact , CTBAL.GetByID(conn, ctpkn.Mact).Tenchitieu, "", ctpkn.Cskn.ToString(), ctpkn.Cskq.ToString() };
                DGVChiTieuKN.Rows.Add(rows);
            }
        }

        private void ChiTieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtChiSoKN.Text = "";
            txtChiSoKQ.Text = "";

            if (cbChiTieu.SelectedValue != null)
                txtMaCT.Text = cbChiTieu.SelectedValue.ToString();
            for (int i=0;i<DGVChiTieuKN.Rows.Count;i++)
            {
                if(DGVChiTieuKN.Rows[i].Cells[0].Value.ToString() == txtMaCT.Text)
                {
                    txtChiSoKN.Text = DGVChiTieuKN.Rows[i].Cells[3].Value.ToString();
                    txtChiSoKQ.Text = DGVChiTieuKN.Rows[i].Cells[4].Value.ToString();
                    return;
                }
            }
            //MySqlConnection conn = DBConnect.GetDBConnection();
            
            //CTPhieuKNBAL CTPKNBAL = new CTPhieuKNBAL();
            //CTPhieuKN CTPKN = CTPKNBAL.GetByID(conn, txtMaCT.Text, SoPhieuKiemNghiem.Text);
            //if (CTPKN != null)
            //{
            //    txtChiSoKN.Text = CTPKN.Cskn.ToString();
            //    txtChiSoKQ.Text = CTPKN.Cskq.ToString();
            //}
            //else
            //{
            //    CTPhieuDKBAL CTPDKBAL = new CTPhieuDKBAL();
            //    var CTPDK = CTPDKBAL.GetByID(conn, txtMaCT.Text, txtSPDK.Text);
            //    if (CTPDK != null)
            //    {
            //        txtChiSoKN.Text = CTPDK.Csdk.ToString();
            //    }
            //}

        }

        private void NhanVienThucHien_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNV.Text = cbNhanVien.SelectedValue.ToString();
        }

        private void tbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaSP.Text = cbSanPham.SelectedValue.ToString();
        }

        private void FormQuanLiPhieuKiemNghiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parent.Show();
        }

        private void CheckTTPhieuKiemNghiem()
        {
            if (txtSPDK.Text == "")
                throw new Exception("Vui lòng nhập só phiếu đăng kí");
            else
            {
                if (txtCSXX.Text == "")
                    throw new Exception("Không tồn tại thông tin của phiếu đăng kí trong cssdl");
            }

            if (txtMaNV.Text == "")
                throw new Exception("Vui lòng chọn nhân viên tiến hành kiểm nghiệm");

            if (cbKetLuan.Text == "")
                throw new Exception("Vui lòng nhập kết luận ");
           
        }

        private void CheckTTCTPhieuKiemNghiem()
        {
            if (txtMaCT.Text == "")
                throw new Exception("Vui lòng chọn chỉ tiêu được kiểm nghiệm");
            if (txtChiSoKN.Text == "")
                throw new Exception("Vui lòng nhập chỉ số kiểm nghiệm");
            else
            {
                try
                {
                    int.Parse(txtChiSoKN.Text);
                }
                catch
                {
                    throw new Exception("Chỉ số kiểm nghiệm phải là số nguyên");
                }
            }

            if (txtChiSoKQ.Text == "")
                throw new Exception("Vui lòng nhập chỉ số kết quả");
            else
            {
                try
                {
                    int.Parse(txtChiSoKQ.Text);
                }
                catch
                {
                    throw new Exception("Chỉ số kết quả phải là số nguyên");
                }
            }
        }
        private void suaPhieuKiemNghiem(string soPKN,string soPDK,string ngKN,int maNV,string maSP,string ketLuan)
        {
            try
            {
               
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhieuKNBAL PKNBAL = new PhieuKNBAL(); 
                PKNBAL.Update(conn, soPKN, soPDK, ngKN, maNV,maSP, ketLuan);
                GetDGVDSPhieuKiemNghiem();
                MessageBox.Show("Sửa thông tin phiếu kiểm nghiệm thành công", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void SuaPKN_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTTPhieuKiemNghiem();
                string ngaykn = dtNgayKN.Value.ToString("yyyy/MM/dd");
                suaPhieuKiemNghiem(SoPhieuKiemNghiem.Text, txtSPDK.Text, ngaykn, int.Parse(txtMaNV.Text), txtMaSP.Text, cbKetLuan.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
           
            
        }

        private void themPhieuKiemNghiem(string soPDK,string ngayKN,int maNV,string maSP,string KL)
        {
            try
            {
                CheckTTPhieuKiemNghiem();
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhieuKNBAL PKNBAL = new PhieuKNBAL();
                string ngaykn = dtNgayKN.Value.ToString("yyyy/MM/dd");
                PKNBAL.Insert(conn,soPDK, ngayKN,maNV,maSP,KL);
                GetDGVDSPhieuKiemNghiem();
                MessageBox.Show("Thêm thông tin phiếu kiểm nghiệm thành công", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void ThemPKN_Click(object sender, EventArgs e)
        {

            try
            {
                CheckTTPhieuKiemNghiem();
                string ngaykn = dtNgayKN.Value.ToString("yyyy/MM/dd");
                themPhieuKiemNghiem(txtSPDK.Text, ngaykn, int.Parse(txtMaNV.Text), txtMaSP.Text, cbKetLuan.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
          
        }

        private void xoaPhieuKiemNghiem(string soPKN)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhieuKNBAL PKNBAL = new PhieuKNBAL();
                PKNBAL.Delete(conn,soPKN);
                GetDGVDSPhieuKiemNghiem();
                MessageBox.Show("Xoá thông tin phiếu kiểm nghiệm thành công", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void XoaPKN_Click(object sender, EventArgs e)
        {
            xoaPhieuKiemNghiem(SoPhieuKiemNghiem.Text);
        }


        private void themCTPhieuKiemNghiem(string soPKN,string maCT,int csKN,int csKQ)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                CTPhieuKNBAL CTPKN = new CTPhieuKNBAL();
                CTPKN.Insert(conn, soPKN,maCT,csKN,csKQ);
                GetDGVChiTieuKN(soPKN);
                MessageBox.Show("Thêm thông tin chi tiết phiếu kiểm nghiệm thành công", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void ThemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTTCTPhieuKiemNghiem();
                themCTPhieuKiemNghiem(SoPhieuKiemNghiem.Text, txtMaCT.Text, int.Parse(txtChiSoKN.Text), int.Parse(txtChiSoKQ.Text)); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            
          
        }

        private void xoaCTPhieuKN(string soPKN,string maCT)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                CTPhieuKNBAL CTPKN = new CTPhieuKNBAL();
                CTPKN.Delete(conn, soPKN,maCT);
                GetDGVChiTieuKN(SoPhieuKiemNghiem.Text);
                MessageBox.Show("Xoá thông tin chi tiết phiếu kiểm nghiệm thành công", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void XoaChiTiet_Click(object sender, EventArgs e)
        {
            xoaCTPhieuKN(SoPhieuKiemNghiem.Text, txtMaCT.Text);

        }

        private void suaCTPhieuKiemNghiem(string soPKN,string maCT,int csKN,int csKQ)
        {
            try
            {
                CheckTTCTPhieuKiemNghiem();
                MySqlConnection conn = DBConnect.GetDBConnection();
                CTPhieuKNBAL CTPKN = new CTPhieuKNBAL();
                CTPKN.Update(conn, soPKN, maCT, csKN, csKQ);
                GetDGVChiTieuKN(soPKN);
                MessageBox.Show("Sửa thông tin chi tiết phiếu kiểm nghiệm thành công", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void SuaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTTCTPhieuKiemNghiem();
                suaCTPhieuKiemNghiem(SoPhieuKiemNghiem.Text, txtMaCT.Text, int.Parse(txtChiSoKN.Text), int.Parse(txtChiSoKQ.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
           
        }

        private void XemTruoc_Click(object sender, EventArgs e)
        {
            if (SoPhieuKiemNghiem.Text == "")
            {
                MessageBox.Show("Không thành công! vui lòng chọn phiếu kiểm nghiệm trước khi in", "Lỗi");
            }
            else
            {
                this.printPreviewDialog1.Document = this.printDocument1;
                this.printPreviewDialog1.ShowDialog();
            }
                
        }

        private void In_Click(object sender, EventArgs e)
        {
            if (SoPhieuKiemNghiem.Text == "")
            {
                MessageBox.Show("Không thành công! vui lòng chọn phiếu kiểm nghiệm trước khi in", "Lỗi");
            }
            else
            {
                this.printDocument1.Print();
            }
           
        }

        private void drawCTPhieu(Graphics g, float x, float y, string TenchiTieu,string csdk,string cskn,string cskq)
        {
            Font font = new Font("Times New Roman", 13);
            Font Name = new Font("Times New Roman", 13, FontStyle.Bold);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            RectangleF NameOfCollum1 = new RectangleF(x, y, 200, 25);
            RectangleF NameOfCollum2 = new RectangleF(x + 200, y, 160, 25);
            RectangleF NameOfCollum3 = new RectangleF(x + 200 + 160, y, 170, 25);
            RectangleF NameOfCollum4 = new RectangleF(x + 360 + 170, y, 160, 25);
            RectangleF[] NameRects = new RectangleF[] { NameOfCollum1, NameOfCollum2, NameOfCollum3,NameOfCollum4 };
            g.DrawString("Tên chỉ tiêu", Name, Brushes.Black, NameOfCollum1, sf);
            g.DrawString("Chỉ số đăng ký", Name, Brushes.Black, NameOfCollum2, sf);
            g.DrawString("Chỉ số kiểm nghiệm", Name, Brushes.Black, NameOfCollum3, sf);
            g.DrawString("Chỉ số kết quả", Name, Brushes.Black, NameOfCollum4, sf);
            g.DrawRectangles(Pens.Black, NameRects);
            SizeF s = g.MeasureString(TenchiTieu, font, 200);
            float height = s.Height <= 70 ? 70 : s.Height + 10;
            RectangleF collum1 = new RectangleF(x, y + 25, 200, 70);
            RectangleF collum2 = new RectangleF(x + 200, y + 25, 160, 70);
            RectangleF collum3 = new RectangleF(x + 200 + 160, y + 25, 170, 70);
            RectangleF collum4 = new RectangleF(x + 360 + 170, y + 25, 160, 70);
            RectangleF[] rects = new RectangleF[] { collum1, collum2, collum3,collum4};
            g.DrawString(TenchiTieu, font, Brushes.Black, collum1, sf);
            g.DrawString(csdk, font, Brushes.Black, collum2, sf);
            g.DrawString(cskn, font, Brushes.Black, collum3, sf);
            g.DrawString(cskq, font, Brushes.Black, collum4, sf);
            g.DrawRectangles(Pens.Black, rects);
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            

            MySqlConnection conn = DBConnect.GetDBConnection();
            PhieuKNBAL PKNBAL = new PhieuKNBAL();
            PhieuKN PKN = PKNBAL.GetByID(conn, SoPhieuKiemNghiem.Text);
            float w = e.PageBounds.Width / 2;
            float x = e.MarginBounds.Left;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            Graphics gp = e.Graphics;
            Font font = new Font("Times New Roman", 12, FontStyle.Bold);
            Font font2 = new Font("Times New Roman", 12);
            RectangleF rect1 = new RectangleF(40, x, 150, 170);
            float yct;
            if (numofitem == 0)
            { 
                gp.DrawString("CỘNG HOÀ XÃ HỘI CHỦ NGHĨA VIỆT NAM", new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new PointF(w, 70), sf);
                gp.DrawString("Độc lập - Tự do - Hạnh phúc", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(w, 97), sf);
                gp.DrawString("PHIẾU KIỂM NGHIỆM CHẤT LƯỢNG SẢN PHẨM", new Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new PointF(w, 137), sf);
                gp.DrawString("Số phiếu kiểm nghiệm: ",font,Brushes.Black,new PointF(x, 177));
                gp.DrawString(PKN.Spkn, font2, Brushes.Black, new PointF(x + 170, 177));
                gp.DrawString("số phiếu đăng ký:", font, Brushes.Black, new PointF(w, 177));
                gp.DrawString(PKN.Spdk, font2, Brushes.Black, new PointF(w + 170, 177));
                gp.DrawString("Ngày kiểm nghiệm: ", font, Brushes.Black, new PointF(x, 207));
                gp.DrawString(PKN.Ngkn.ToString("dd/MM/yyyy"), font2, Brushes.Black, new PointF(x + 170, 207));
                gp.DrawString("Tên cơ sở sản xuất:", font, Brushes.Black, new PointF(w, 207));
                gp.DrawString(PKN.getPhieudk().getCoso().Tencs, font2, Brushes.Black, new PointF(w + 170, 207));
                gp.DrawString("Tên sản phẩm:", font, Brushes.Black, new PointF(x, 237));
                gp.DrawString(PKN.getSanPham().Tensp, font2, Brushes.Black, new PointF(x + 170, 237));
                gp.DrawString("Mã sản phẩm", font, Brushes.Black, new PointF(w , 237));
                gp.DrawString(PKN.Masp, font2, Brushes.Black, new PointF(w + 170, 237));
                gp.DrawString("Nhân viên thực hiện", font, Brushes.Black, new PointF(x, 267));
                gp.DrawString(PKN.getnv().Tennv, font2, Brushes.Black, new PointF(x + 170, 267));
                gp.DrawString("Mã nhân viên", font, Brushes.Black, new PointF(w, 267));
                gp.DrawString(PKN.Manv.ToString(), font2, Brushes.Black, new PointF(w + 170, 267));
                gp.DrawString("Kết Luận", font, Brushes.Black, new PointF(x,297));
                gp.DrawString(PKN.KL1, font2, Brushes.Black, new RectangleF(x +170 , 297, 500, 60));
                gp.DrawString("Kết quả kiểm nghiệm các chỉ tiêu sau ", font, Brushes.Black, new PointF(x, 357));
                yct = 387;
            }
            else
            {
                yct = 70;
            }
            CTPhieuKNBAL CTPKNBAL = new CTPhieuKNBAL();
            List<CTPhieuKN> ctphieu = CTPKNBAL.GetByspkn(conn, SoPhieuKiemNghiem.Text);
            CTPhieuDKBAL CTPDKBAL = new CTPhieuDKBAL();
            for (; numofitem < ctphieu.Count; numofitem++)
            {
                if (yct <= e.MarginBounds.Height)
                {
                    CTPhieuKN CT = ctphieu[numofitem];
                    drawCTPhieu(gp, x, yct, CT.getCT().Tenchitieu,CTPDKBAL.GetByID(conn,CT.Mact,PKN.Spdk).Csdk.ToString(),CT.Cskn.ToString(),CT.Cskq.ToString());
                    yct += 130;
                }
                else
                {
                    e.HasMorePages = true;
                    break;
                }
            }

            if (numofitem == ctphieu.Count)
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TraCuuPhieuKiemNghiem(txtTTTimKiem.Text);
            }    
        }



        private void DGVDSPhieuKiemNghiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || DGVDSPhieuKiemNghiem.Rows[e.RowIndex].Cells[0].Value == null)
                return;

            MySqlConnection conn = DBConnect.GetDBConnection();
            PhieuKNBAL PKNBAL = new PhieuKNBAL();
            string soPKN = DGVDSPhieuKiemNghiem.Rows[e.RowIndex].Cells[0].Value.ToString();
            PhieuKN phieuKN = PKNBAL.GetByID(conn, soPKN);

            //Cap nhat so phieu kiem nghiem
            SoPhieuKiemNghiem.Text = phieuKN.Spkn;
            TxTSoPhieuKN.Text = phieuKN.Spkn;

            //cap nhat so phieu dang ki
            txtSPDK.Text = phieuKN.Spdk;
            TxTSoPhieuDK.Text = phieuKN.Spdk;

            //Cap nhat DGVChiTieuKN
            GetDGVChiTieuKN(soPKN);

            //Cap nhat co so san xuat
            txtCSXX.Text = phieuKN.getSanPham().getCS().Tencs;
            TxtCSXX2.Text = txtCSXX.Text;

            //cap nhat ngay kiem nghiem
            dtNgayKN.Text = phieuKN.Ngkn.ToString();

            //Cap nhat san pham
            cbSanPham.SelectedValue = phieuKN.Masp;
            txtSanPham.Text = cbSanPham.Text;

            //Cap nhat nhan vien thuc hien
            cbNhanVien.SelectedValue = phieuKN.Manv;
            //Cap nhat don vi
            TxtDonVi.Text = textBox9.Text;

            //Cap nhat so luong
            TxTSoLuong.Text = textBox10.Text;

            //Cap nhat ket luan
            TxtKetLuan2.Text = phieuKN.KL1;
            cbKetLuan.SelectedItem = phieuKN.KL1;
            //txtKetLuan.Text = phieuKN.KL1;
           
        }

        private void DGVPhieuDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVPhieuDK.Rows[e.RowIndex].Cells[0].Value != null)
                cbChiTieu.SelectedValue = DGVPhieuDK.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void DGVChiTieuKN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbChiTieu.SelectedValue = DGVChiTieuKN.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void txtSPDK_TextChanged(object sender, EventArgs e)
        {
            //if(DGVDSPhieuKiemNghiem.SelectedRows.Count > 0)
            //     DGVDSPhieuKiemNghiem.Rows[DGVDSPhieuKiemNghiem.SelectedRows[0].Index].Selected = false;
            DGVChiTieuKN.Rows.Clear();

            SearchPhieuDK(txtSPDK.Text);
            MySqlConnection conn = DBConnect.GetDBConnection();
            PhieuDKBAL PDKBAL = new PhieuDKBAL();
            PhieuDK PDK = PDKBAL.GetByID(conn, txtSPDK.Text);
            List<ChiTieu> lstChiTieu = new List<ChiTieu>();
            List<SanPham> lstSanPham = new List<SanPham>();
            if (PDK != null)
            {
                //Tim CSSX
                txtCSXX.Text = PDK.getCoso().Tencs;
                //Tim San pham
                lstSanPham.Add(PDK.getSanPham());
                //Tim chi tieu
                var CTPDK = PDK.get();
                foreach (var ct in CTPDK)
                {
                    lstChiTieu.Add(ct.get());
                }
            }
            else
            {
                txtCSXX.Text = "";
                cbSanPham.Text = "";
                txtMaSP.Text = "";

                cbChiTieu.Text = "";
                txtMaCT.Text = "";
            }
            cbSanPham.DataSource = lstSanPham;
            cbChiTieu.DisplayMember = "Tenchitieu";
            cbChiTieu.ValueMember = "Mact";
            cbChiTieu.DataSource = lstChiTieu;
        }
    }
}
