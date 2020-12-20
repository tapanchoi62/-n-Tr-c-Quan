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
using System.Drawing;

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
            GetDGV2();
            NgayKiemNghiem.Format = DateTimePickerFormat.Custom;
            NgayKiemNghiem.CustomFormat = "dd/MM/yyyy";
            
        }   
        private void GetDGV1()
        {
            try 
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                DGV1.Rows.Clear();
                PhieuKNBAL dbPKN = new PhieuKNBAL();
                foreach (var phieu in dbPKN.GetAll(conn))
                {
                    PhieuDK pdk = phieu.getPhieudk();
                    SanPham sp = pdk.getSanPham();
                    NhanVien nv = phieu.getnv();
                    List<CTPhieuDK> ctpdk = pdk.get();         
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
        }
        private void GetDGV2()
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                DGV2.Rows.Clear();
                PhieuKNBAL dbPKN = new PhieuKNBAL();
                List<PhieuKN> lst = dbPKN.GetAll(conn);

                foreach (var phieukn in dbPKN.GetAll(conn))
                {
                    SanPham sp = phieukn.getSanPham();
                    NhanVien nv = phieukn.getnv();
                    string[] row = new string[] { phieukn.Spkn, phieukn.Ngkn.ToString("dd/MM/yy"), sp.Tensp, nv.Tennv, phieukn.KL1 };
                    DGV2.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thất bại");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

      

        private void LayThongTin_Click(object sender, EventArgs e)
        {
            GetDGV2();
        }

       

        public void GetPanel2()
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
          
            tbSanPham.DisplayMember = "Tensp";
            tbSanPham.ValueMember = "Masp";
            NhanVienBAL NVBAL = new NhanVienBAL();
            NhanVienThucHien.DisplayMember = "Tennv";
            NhanVienThucHien.ValueMember = "Manv";
            NhanVienThucHien.DataSource = NVBAL.GetAll(conn);

            ChiTieu.DisplayMember = "Tenchitieu";
            ChiTieu.ValueMember = "Mact";
           

        }

        private void SearchPhieuDK(string spdk)
        {
            DGV1.Rows.Clear();
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
                        DGV1.Rows.Add(row);
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
        private void TraCuuDangKi_Click(object sender, EventArgs e)
        {

            SearchPhieuDK(textBox1.Text);
        }

        private void TraCuuKiemNghiem_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            PhieuKNBAL PKNBAL = new PhieuKNBAL();
            PhieuKN phieuKN = PKNBAL.GetByID(conn, textBox2.Text);
            DGV2.Rows.Clear();
            SanPhamBAL SPBAL = new SanPhamBAL();
            NhanVienBAL NVBAL = new NhanVienBAL();
            string[] row = new string[] { phieuKN.Spkn, phieuKN.Ngkn.ToString("dd/MM/yyyy"), SPBAL.GetByID(conn, phieuKN.Masp).Tensp, NVBAL.GetByID(conn, phieuKN.Manv).Tennv ,phieuKN.KL1};
            DGV2.Rows.Add(row);
        }

        private void DGV2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            MySqlConnection conn = DBConnect.GetDBConnection();
            PhieuKNBAL PKNBAL = new PhieuKNBAL();
            string soPKN = DGV2.Rows[e.RowIndex].Cells[0].Value.ToString();
            PhieuKN phieuKN = PKNBAL.GetByID(conn, soPKN);
            
            SoPhieuKiemNghiem.Text = phieuKN.Spkn;
            TxTSoPhieuKN.Text = phieuKN.Spkn;
            //cap nhat so phieu dang ki
            SPDK.Text = phieuKN.Spdk;
            TxTSoPhieuDK.Text = phieuKN.Spdk;

            //Cap nhat co so san xuat
            tbCSXX.Text = phieuKN.getSanPham().getCS().Tencs;
            TxtCSXX.Text = tbCSXX.Text;
            //cap nhat ngay kiem nghiem
            NgayKiemNghiem.Text = phieuKN.Ngkn.ToString();
          
            //Cap nhat san pham
            tbSanPham.SelectedValue = phieuKN.Masp;
            txtSanPham.Text = tbSanPham.Text;
            //Cap nhat nhan vien thuc hien
            NhanVienThucHien.SelectedValue = phieuKN.Manv;
            //Cap nhat don vi
            TxtDonVi.Text = textBox9.Text;

            TxTSoLuong.Text = textBox10.Text;
            //Cap nhat ket luan
            TxtKetLuan2.Text = phieuKN.KL1;
            KetLuan.Text = phieuKN.KL1;
            //Cap nhat DGV3
            GetDGV3(soPKN);
            

        }

        private void GetDGV3(string soPKN)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            CTPhieuKNBAL CTPKNBAL = new CTPhieuKNBAL();
            ChiTieuBAL CTBAL = new ChiTieuBAL();
            DGV3.Rows.Clear();
            foreach (var ctpkn in CTPKNBAL.GetByspkn(conn, soPKN))
            {
                string[] rows = new string[] { CTBAL.GetByID(conn, ctpkn.Mact).Tenchitieu, "", ctpkn.Cskn.ToString(), ctpkn.Cskq.ToString() };
                DGV3.Rows.Add(rows);
            }
        }

        private void ChiTieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChiSoKiemNghiem.Text = "";
            ChiSoKetQua.Text = "";
            MySqlConnection conn = DBConnect.GetDBConnection();
            MaCT.Text = ChiTieu.SelectedValue.ToString();
            CTPhieuKNBAL CTPKNBAL = new CTPhieuKNBAL();
            CTPhieuKN CTPKN = CTPKNBAL.GetByID(conn, MaCT.Text, SoPhieuKiemNghiem.Text);
            if (CTPKN != null)
            {
                ChiSoKiemNghiem.Text = CTPKN.Cskn.ToString();
                ChiSoKetQua.Text = CTPKN.Cskq.ToString();
            }
            else
            {
                CTPhieuDKBAL CTPDKBAL = new CTPhieuDKBAL();
                var CTPDK = CTPDKBAL.GetByID(conn, MaCT.Text, SPDK.Text);
                if (CTPDK != null)
                {
                    ChiSoKiemNghiem.Text = CTPDK.Csdk.ToString();
                }
            }

        }

        private void NhanVienThucHien_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaNV.Text = NhanVienThucHien.SelectedValue.ToString();
        }

        private void tbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaSP.Text = tbSanPham.SelectedValue.ToString();
        }

        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChiTieu.SelectedValue = DGV1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void SPDK_TextChanged_1(object sender, EventArgs e)
        {
            SearchPhieuDK(SPDK.Text);

            MySqlConnection conn = DBConnect.GetDBConnection();
            PhieuDKBAL PDKBAL = new PhieuDKBAL();
            PhieuDK PDK = PDKBAL.GetByID(conn, SPDK.Text);
            List<ChiTieu> lstChiTieu = new List<ChiTieu>();
            List<SanPham> lstSanPham = new List<SanPham>();
            if (PDK != null)
            {
                //Tim CSSX
                tbCSXX.Text = PDK.getCoso().Tencs;
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
                tbCSXX.Text = "";
                tbSanPham.Text = "";
                MaSP.Text = "";

                ChiTieu.Text = "";
                MaCT.Text = "";
            }
            tbSanPham.DataSource = lstSanPham;
            ChiTieu.DisplayMember = "Tenchitieu";
            ChiTieu.ValueMember = "Mact";
            ChiTieu.DataSource = lstChiTieu;
        }

        private void FormQuanLiPhieuKiemNghiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parent.Show();
        }

        private void SuaPKN_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhieuKNBAL PKNBAL = new PhieuKNBAL();
                string ngaykn = NgayKiemNghiem.Value.ToString("yyyy/MM/dd");
                PKNBAL.Update(conn, SoPhieuKiemNghiem.Text, SPDK.Text, ngaykn, int.Parse(MaNV.Text), MaSP.Text, KetLuan.Text);
                GetDGV2();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            
        }

        private void ThemPKN_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhieuKNBAL PKNBAL = new PhieuKNBAL();
                string ngaykn = NgayKiemNghiem.Value.ToString("yyyy/MM/dd");
                PKNBAL.Insert(conn, SPDK.Text, ngaykn, int.Parse(MaNV.Text), MaSP.Text, KetLuan.Text);
                GetDGV2();
            }catch(Exception ex)
            {
                MessageBox.Show( ex.Message,"Lỗi");
            }
        }

        private void XoaPKN_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhieuKNBAL PKNBAL = new PhieuKNBAL();
                PKNBAL.Delete(conn, SoPhieuKiemNghiem.Text);
                GetDGV2();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void ThemChiTiet_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            CTPhieuKNBAL CTPKN = new CTPhieuKNBAL();
            CTPKN.Insert(conn, SoPhieuKiemNghiem.Text, MaCT.Text, int.Parse(ChiSoKiemNghiem.Text), int.Parse(ChiSoKetQua.Text));
            GetDGV3(SoPhieuKiemNghiem.Text);
        }

        private void XoaChiTiet_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            CTPhieuKNBAL CTPKN = new CTPhieuKNBAL();
            CTPKN.Delete(conn, SoPhieuKiemNghiem.Text, MaCT.Text);
            GetDGV3(SoPhieuKiemNghiem.Text);
        }

        private void SuaChiTiet_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            CTPhieuKNBAL CTPKN = new CTPhieuKNBAL();
            CTPKN.Update(conn, SoPhieuKiemNghiem.Text, MaCT.Text, int.Parse(ChiSoKiemNghiem.Text), int.Parse(ChiSoKetQua.Text));
            GetDGV3(SoPhieuKiemNghiem.Text);
        }

        private void XemTruoc_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.ShowDialog();
        }

        private void In_Click(object sender, EventArgs e)
        {
            this.printDocument1.Print();
        }

        private void drawCTPhieu(Graphics g, float x, float y, string TenchiTieu,string csdk,string cskn,string cskq)
        {
            Font font = new Font("Times New Roman", 13);
            Font Name = new Font("Times New Roman", 13, FontStyle.Bold);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            RectangleF NameOfCollum1 = new RectangleF(x, y, 200, 25);
            RectangleF NameOfCollum2 = new RectangleF(x + 200, y, 150, 25);
            RectangleF NameOfCollum3 = new RectangleF(x + 200 + 150, y, 150, 25);
            RectangleF NameOfCollum4 = new RectangleF(x + 350 + 150, y, 150, 25);
            RectangleF[] NameRects = new RectangleF[] { NameOfCollum1, NameOfCollum2, NameOfCollum3,NameOfCollum4 };
            g.DrawString("Tên chỉ tiêu", Name, Brushes.Black, NameOfCollum1, sf);
            g.DrawString("Chỉ số đăng ký", Name, Brushes.Black, NameOfCollum2, sf);
            g.DrawString("Chỉ số kiểm nghiệm", Name, Brushes.Black, NameOfCollum3, sf);
            g.DrawString("Chỉ số kết quả", Name, Brushes.Black, NameOfCollum4, sf);
            g.DrawRectangles(Pens.Black, NameRects);
            RectangleF collum1 = new RectangleF(x, y + 25, 200, 70);
            RectangleF collum2 = new RectangleF(x + 200, y + 25, 150, 70);
            RectangleF collum3 = new RectangleF(x + 200 + 150, y + 25, 150, 70);
            RectangleF collum4 = new RectangleF(x + 350 + 150, y + 25, 150, 70);
            RectangleF[] rects = new RectangleF[] { collum1, collum2, collum3,collum4};
            g.DrawString(TenchiTieu, font, Brushes.Black, collum1, sf);
            g.DrawString(csdk, font, Brushes.Black, collum2, sf);
            g.DrawString(cskn, font, Brushes.Black, collum3, sf);
            g.DrawString(cskq, font, Brushes.Black, collum4, sf);
            g.DrawRectangles(Pens.Black, rects);
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (SoPhieuKiemNghiem.Text != "")
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
        }
    }
}
