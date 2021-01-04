using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using QuanLyCoSoSX.BAL;
using QuanLyCoSoSX.DAO;
using QuanLyCoSoSX.GUI;
using QuanLyCoSoSX.DTO;
using System.Configuration;

namespace QuanLyCoSoSX.GUI
{
    public partial class FormThongKe : Form
    {

        Form parr;
        MySqlConnection conn = DBConnect.GetDBConnection();
        public FormThongKe()
        {
            InitializeComponent();
            dtTuNgay.CustomFormat = "dd/MM/yyyy";
            dtDenNgay.CustomFormat = "dd/MM/yyyy";
            dtTuNgayDK_pnpdk.CustomFormat = "dd/MM/yyyy";
            dtDenNgayDK_pnpdk.CustomFormat = "dd/MM/yyyy";
            dtTuNgay_pnpkn.CustomFormat = "dd/MM/yyyy";
            dtDenNgay_pnpkn.CustomFormat = "dd/MM/yyyy";
            pnNgayThang_pnpkn.Hide();
            pnNgDK_pnpdk.Hide();
            pnNgHH_pnpdk.Hide();
            cbGioiTinh_pnnv.Hide();
            pnNgaySinh_pnnv.Hide();
            rdbtTatCa_pnnv.Checked = true;
            rdbtTatCa_pnsp.Checked = true;
            rdbtTatca_pnpkn.Checked = true;
            rdbtTatCa_pnPDK.Checked = true;
        }
        public FormThongKe(Form parent)
        {
            this.parr = parent;
            InitializeComponent();
            dtTuNgay.CustomFormat = "dd/MM/yyyy";
            dtDenNgay.CustomFormat = "dd/MM/yyyy";
            dtTuNgayDK_pnpdk.CustomFormat = "dd/MM/yyyy";
            dtDenNgayDK_pnpdk.CustomFormat = "dd/MM/yyyy";
            dtTuNgay_pnpkn.CustomFormat = "dd/MM/yyyy";
            dtDenNgay_pnpkn.CustomFormat = "dd/MM/yyyy";
            pnNgayThang_pnpkn.Hide();
            pnNgDK_pnpdk.Hide();
            pnNgHH_pnpdk.Hide();
            cbGioiTinh_pnnv.Hide();
            pnNgaySinh_pnnv.Hide();
            rdbtTatCa_pnnv.Checked = true;
            rdbtTatCa_pnsp.Checked = true;
            rdbtTatca_pnpkn.Checked = true;
            rdbtTatCa_pnPDK.Checked = true;
        }


//
//CONTROL PANEL NHAN VIEN
//

        //XUAT DU LIEU RA DGV
        private void XuatKQTKNV(List<NhanVien> lstNhanVien )
        {

            dgvNhanVien.Rows.Clear();
            DateTime ngSinhTu = dtTuNgay.Value;
            DateTime ngSinhDen = dtDenNgay.Value;
            DataChart duLieuThongKeGioiTinh = new DataChart();
            DataChart duLieuThongKePhongBan = new DataChart();
            if(ckbNgSinh_pnnv.Checked)
            {
                if(ckbGioiTinh_pnnv.Checked)
                {
                    string gt = cbGioiTinh_pnnv.Text;
                    foreach (var nv in lstNhanVien)
                    {
                        if(nv.Ngsinh.Date >= ngSinhTu.Date && nv.Ngsinh.Date <=ngSinhDen.Date && nv.Gioitinh == gt)
                        {
                            duLieuThongKeGioiTinh.Add(nv.Gioitinh, 1);
                            duLieuThongKePhongBan.Add(nv.Mapb, 1);
                            dgvNhanVien.Rows.Add(nv.Manv, nv.Tennv, nv.Ngsinh.ToString("dd/MM/yyyy"), nv.Gioitinh, nv.Mapb, nv.Sdt);
                        }
                    }
                    //txtSoNV_pnnv.Text = dgvNhanVien.Rows.Count.ToString();
                }
                else
                {
                    foreach (var nv in lstNhanVien)
                    {
                        if (nv.Ngsinh.Date >= ngSinhTu.Date && nv.Ngsinh.Date <= ngSinhDen.Date)
                        {
                            duLieuThongKeGioiTinh.Add(nv.Gioitinh, 1);
                            duLieuThongKePhongBan.Add(nv.Mapb, 1);
                            dgvNhanVien.Rows.Add(nv.Manv, nv.Tennv, nv.Ngsinh.ToString("dd/MM/yyyy"), nv.Gioitinh, nv.Mapb, nv.Sdt);
                        }
                    }
                    //txtSoNV_pnnv.Text = dgvNhanVien.Rows.Count.ToString();
                }
            }
            else
            {
                if (ckbGioiTinh_pnnv.Checked)
                {
                    string gt = cbGioiTinh_pnnv.Text;
                    foreach (var nv in lstNhanVien)
                    {
                        if (nv.Gioitinh == gt)
                        {
                            duLieuThongKeGioiTinh.Add(nv.Gioitinh, 1);
                            duLieuThongKePhongBan.Add(nv.Mapb, 1);
                            dgvNhanVien.Rows.Add(nv.Manv, nv.Tennv, nv.Ngsinh.ToString("dd/MM/yyyy"), nv.Gioitinh, nv.Mapb, nv.Sdt);
                        }
                    }
                    //txtSoNV_pnnv.Text = dgvNhanVien.Rows.Count.ToString();
                }
                else
                {
                    foreach (var nv in lstNhanVien)
                    {
                       
                        {
                            duLieuThongKeGioiTinh.Add(nv.Gioitinh, 1);
                            duLieuThongKePhongBan.Add(nv.Mapb, 1);
                            dgvNhanVien.Rows.Add(nv.Manv, nv.Tennv, nv.Ngsinh.ToString("dd/MM/yyyy"), nv.Gioitinh, nv.Mapb, nv.Sdt);
                        }
                    }
                    //txtSoNV_pnnv.Text = dgvNhanVien.Rows.Count.ToString();
                }
            }

            XuatDuLieuChart(duLieuThongKeGioiTinh, duLieuThongKePhongBan);
        }
        // XUAT DU LIEU RA CHART
        private void XuatDuLieuChart(DataChart datachart1, DataChart datachart2)
        {
            ChartNhanVien_GioiTinh.Series["S1"].Points.Clear();
            foreach(var tk in datachart1.Data)
            {
                ChartNhanVien_GioiTinh.Series["S1"].Points.AddXY(tk.chitieu, tk.soluong);
            }

            PhongBanBAL dbPhongBan = new PhongBanBAL();

            ChartNhanVien_PhongBan.Series["S1"].Points.Clear();
            foreach (var tk in datachart2.Data)
            {
                ChartNhanVien_PhongBan.Series["S1"].Points.AddXY(dbPhongBan.GetByID(conn,tk.chitieu).Tenpb, tk.soluong);
            }
        }



        private void TKNhanvienBangPB(string mapb)
        {
            NhanVienBAL NVBAL = new NhanVienBAL();
            List<NhanVien> lstNhanVien = NVBAL.GetByMaPB(conn, mapb);
            XuatKQTKNV(lstNhanVien);

        }
        private void TKTatCaNV()
        {
            NhanVienBAL NVBAL = new NhanVienBAL();
            dgvNhanVien.Rows.Clear();
            List<NhanVien> lstNhanVien = NVBAL.GetAll(conn);
            XuatKQTKNV(lstNhanVien);
        }

        private void ThongKeNV()
        {
            if (rdbtTatCa_pnnv.Checked)
            {
                TKTatCaNV();
            }
            else if (rdbtPhongBan_pnnv.Checked)
            {
                if (cbTieuChi.SelectedValue != null)
                    TKNhanvienBangPB(cbTieuChi.SelectedValue.ToString());
            }
        }


        private void rbbtTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbtTatCa_pnnv.Checked)
            {
                cbTieuChi.Hide();
                TKTatCaNV();
            }
               
        }

        private void rdbtPhongBan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtPhongBan_pnnv.Checked == true)
            {
                cbTieuChi.Show();
                PhongBanBAL PBBAL = new PhongBanBAL();
                List<PhongBan> lstPhongBan = PBBAL.GetAll(conn);
                cbTieuChi.DisplayMember = "Tenpb";
                cbTieuChi.ValueMember = "Mapb";
                cbTieuChi.DataSource = lstPhongBan;
            }
            else
                cbTieuChi.Hide();

           
        }

        
        private void cbTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbtPhongBan_pnnv.Checked == true)
            {
                if(cbTieuChi.SelectedValue!=null)
                    TKNhanvienBangPB(cbTieuChi.SelectedValue.ToString());
            }
            
        }

        private void dtTuNgay_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((dtTuNgay.Value > dtDenNgay.Value))
                    throw new Exception("Điều kiện ngày không hợp lệ");
                else
                    ThongKeNV(); 

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            
        }

        private void dtDenNgay_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((dtTuNgay.Value > dtDenNgay.Value))
                    throw new Exception("Điều kiện ngày không hợp lệ");
                else
                    ThongKeNV();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void ckbGioiTinh_pnnv_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbGioiTinh_pnnv.Checked)
            {
                cbGioiTinh_pnnv.Show();
                cbGioiTinh_pnnv.Items.Clear();
                cbGioiTinh_pnnv.Items.Add("Nam");
                cbGioiTinh_pnnv.Items.Add("Nữ");
                
            }
            else
                cbGioiTinh_pnnv.Hide();
            ThongKeNV();

        }

        private void ckbNgSinh_pnnv_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNgSinh_pnnv.Checked)
                pnNgaySinh_pnnv.Show();
            else
                pnNgaySinh_pnnv.Hide();
            ThongKeNV();
        }

        private void cbGioiTinh_pnnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThongKeNV();
        }

//
//CONTROL PANEL SAN PHAM
//

        private void  InChartSanPham(DataChart data)
        {
            ChartSanPham_CSSX.Series["S1"].Points.Clear();
            CSSXBAL dbCSSX = new CSSXBAL();

            foreach (var tk in data.Data)
            {
                ChartSanPham_CSSX.Series["S1"].Points.AddXY(dbCSSX.GetByID(conn, int.Parse(tk.chitieu)).Tencs, tk.soluong);
            }
        }

        private void XuatThongTinTKSP(List<SanPham> lstSanPham)
        {
            DataChart data = new DataChart();
            DGVSanPham.Rows.Clear();
            foreach (var sp in lstSanPham)
            {
                data.Add(sp.Macs.ToString(), 1);
                DGVSanPham.Rows.Add(sp.Masp, sp.Tensp, sp.Donvi, sp.Macs);
            }
            InChartSanPham(data);
            txtSLSP_pnsp.Text = lstSanPham.Count.ToString();
        }

        private void TKTatCaSP()
        {
            SanPhamBAL SPBAL = new SanPhamBAL();
            List<SanPham> lstSanPham = SPBAL.GetAll(conn);
            XuatThongTinTKSP(lstSanPham);
        }
        private void rdbtTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbtTatCa_pnsp.Checked)
            {
                TKTatCaSP();
                cbCssx_pnsp.Hide();
            }

        }

        private void rdbtCSSX_pnsp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtCSSX_pnsp.Checked)
            {
                cbCssx_pnsp.Show();
                CSSXBAL cssxbal = new CSSXBAL();
                List<CSSX> lstCSSX = cssxbal.GetAll(conn);
                cbCssx_pnsp.DisplayMember = "Tencs";
                cbCssx_pnsp.ValueMember = "Macs";
                cbCssx_pnsp.DataSource = lstCSSX;
            }
            else
                cbCssx_pnsp.Hide();
            
        }

        private void TKSanPhamBangCS(int macs)
        {
            SanPhamBAL SPBAL = new SanPhamBAL();
            List<SanPham> lstSanPham = SPBAL.GetByMacs(conn, macs);
            XuatThongTinTKSP(lstSanPham);
            txtSLSP_pnsp.Text = lstSanPham.Count.ToString();
        }
        private void cbCssx_pnsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGVSanPham.Rows.Clear();
            if (cbCssx_pnsp.SelectedValue != null)
            {
                TKSanPhamBangCS(int.Parse(cbCssx_pnsp.SelectedValue.ToString()));
            }
        }
//
//CONTROL PANEL PHIEU DANG KY
//


        private void InChartPhieuDangKy(DataChart data)
        {
            ChartPDK_CSSX.Series["S1"].Points.Clear();
            CSSXBAL dbCSSX = new CSSXBAL();
            foreach (var tk in data.Data)
            {
                ChartPDK_CSSX.Series["S1"].Points.AddXY(dbCSSX.GetByID(conn, int.Parse(tk.chitieu)).Tencs, tk.soluong);
            }
        }
        private void XuatKQTKPDK(List<PhieuDK> lstPhieuDK)
        {
            DateTime dktungay = dtTuNgayDK_pnpdk.Value, dkdengay = dtDenNgayDK_pnpdk.Value, hhtungay = dtTuNgayHH_pnpdk.Value, hhdengay = dtDenNgayHH_pnpdk.Value;
            DataChart data = new DataChart();
            if (ckbNgayDK_pnpdk.Checked)
            {
                if (ckbNgayHH_pnpdk.Checked)
                {
                    foreach (var pdk in lstPhieuDK)
                    {
                        if (pdk.Ngdk.Date >= dktungay && pdk.Ngdk.Date <= dkdengay.Date && pdk.Nghh.Date >= hhtungay && pdk.Nghh.Date <= hhdengay.Date)
                        {
                            DGVPhieuDK.Rows.Add(pdk.Spdk, pdk.Ngdk.ToString("dd/MM/yyyy"), pdk.Nghh.ToString("dd/MM/yyyy"), pdk.Macs, pdk.Masp, pdk.sl);
                            data.Add(pdk.Macs.ToString(), 1);
                        }
                            
                    }
                    txtSoPDK.Text = DGVPhieuDK.Rows.Count.ToString();
                }
                else
                {
                    foreach (var pdk in lstPhieuDK)
                    {
                        if (pdk.Ngdk.Date >= dktungay && pdk.Ngdk.Date <= dkdengay.Date)
                        {
                            DGVPhieuDK.Rows.Add(pdk.Spdk, pdk.Ngdk.ToString("dd/MM/yyyy"), pdk.Nghh.ToString("dd/MM/yyyy"), pdk.Macs, pdk.Masp, pdk.sl);
                            data.Add(pdk.Macs.ToString(), 1);
                        }
                    }
                    txtSoPDK.Text = DGVPhieuDK.Rows.Count.ToString();
                }

            }
            else
            {
                if (ckbNgayHH_pnpdk.Checked)
                {
                    foreach (var pdk in lstPhieuDK)
                    {
                        if (pdk.Nghh.Date >= hhtungay && pdk.Nghh.Date <= hhdengay.Date)
                        {
                            DGVPhieuDK.Rows.Add(pdk.Spdk, pdk.Ngdk.ToString("dd/MM/yyyy"), pdk.Nghh.ToString("dd/MM/yyyy"), pdk.Macs, pdk.Masp, pdk.sl);
                            data.Add(pdk.Macs.ToString(), 1);
                        }
                    }
                    txtSoPDK.Text = DGVPhieuDK.Rows.Count.ToString();
                }
                else
                {
                    foreach (var pdk in lstPhieuDK)
                    {
                        DGVPhieuDK.Rows.Add(pdk.Spdk, pdk.Ngdk.ToString("dd/MM/yyyy"), pdk.Nghh.ToString("dd/MM/yyyy"), pdk.Macs, pdk.Masp, pdk.sl);
                        {
                            DGVPhieuDK.Rows.Add(pdk.Spdk, pdk.Ngdk.ToString("dd/MM/yyyy"), pdk.Nghh.ToString("dd/MM/yyyy"), pdk.Macs, pdk.Masp, pdk.sl);
                            data.Add(pdk.Macs.ToString(), 1);
                        }
                    }
                    txtSoPDK.Text = DGVPhieuDK.Rows.Count.ToString();
                }
            }

            InChartPhieuDangKy(data);
        }

        private void TKTatCaPDK()
        {
            DGVPhieuDK.Rows.Clear();
            PhieuDKBAL PDKBAL = new PhieuDKBAL();
            List<PhieuDK> lstPhieuDK = PDKBAL.GetAll(conn);
            XuatKQTKPDK(lstPhieuDK);
        }
          
        private void TKPDKBangCSXX(string cssx)
        {
            DGVPhieuDK.Rows.Clear();
            PhieuDKBAL pdkBAL = new PhieuDKBAL();
            List<PhieuDK> lstPhieuDK = pdkBAL.GetByCSSX(conn, cssx);
            XuatKQTKPDK(lstPhieuDK);
        }

        private void ThongKePDK()
        {
            if(rdbtTatCa_pnPDK.Checked)
            {
                TKTatCaPDK();
            }
            else if(rdbtCssx_pnpdk.Checked)
            {
                if (cbTieuChi_pnpdk.SelectedValue != null)
                    TKPDKBangCSXX(cbTieuChi_pnpdk.SelectedValue.ToString());
            }
        }

        private void rdbtTatCa_pnPDK_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbtTatCa_pnPDK.Checked)
            {
                cbTieuChi_pnpkn.Hide();
                TKTatCaPDK();
            }
                
        }

        private void rdbtCssx_pnpdk_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtCssx_pnpdk.Checked)
            {
                cbTieuChi_pnpdk.Show();
                CSSXBAL cssxbal = new CSSXBAL();
                List<CSSX> lstCSSX = cssxbal.GetAll(conn);
                cbTieuChi_pnpdk.DisplayMember = "Tencs";
                cbTieuChi_pnpdk.ValueMember = "Macs";
                cbTieuChi_pnpdk.DataSource = lstCSSX;
            }
            else
                cbTieuChi_pnpdk.Hide();
            

        }    

        private void cbTieuChi_pnpdk_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rdbtCssx_pnpdk.Checked == true)
            {
                if (cbTieuChi_pnpdk.SelectedValue != null)
                    TKPDKBangCSXX(cbTieuChi_pnpdk.SelectedValue.ToString());
            }
        }

        private void ckbNgayDK_pnpdk_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNgayDK_pnpdk.Checked)
            {
                pnNgDK_pnpdk.Show();

            }
            else
            {
                pnNgDK_pnpdk.Hide();
            }
            ThongKePDK();
        }
        private void ckbNgHH_pnpdk_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNgayHH_pnpdk.Checked)
            {
                pnNgHH_pnpdk.Show();

            }
            else
            {
                pnNgHH_pnpdk.Hide();
            }
            ThongKePDK();
        }

        private void dtTuNgayDK_pnpdk_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtTuNgayDK_pnpdk.Value > dtDenNgayDK_pnpdk.Value)
                    throw new Exception("Điều kiện ngày đăng ký không hợp lệ");
                else
                    ThongKePDK();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void dtDenNgayDK_pnpdk_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtTuNgayDK_pnpdk.Value > dtDenNgayDK_pnpdk.Value)
                    throw new Exception("Điều kiện ngày đăng ký không hợp lệ");
                else
                    ThongKePDK();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void dtTuNgayHH_pnpdk_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtTuNgayHH_pnpdk.Value > dtDenNgayHH_pnpdk.Value)
                    throw new Exception("Điều kiện ngày hết hạn không hợp lệ");
                else
                    ThongKePDK();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void dtDenNgayHH_pnpdk_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtTuNgayHH_pnpdk.Value > dtDenNgayHH_pnpdk.Value)
                    throw new Exception("Điều kiện ngày hết hạn không hợp lệ");
                else
                    ThongKePDK();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
//
//CONTROL PANEL PHIEU KIEM NGHIEM
//

        private void InChartPhieuKiemNghiem(DataChart datakq, DataChart datanv, DataChart datasp)
        {
            ChartPKN_KQ.Series["S1"].Points.Clear();
            foreach (var tk in datakq.Data)
            {
                if(tk.chitieu == "Chưa hoàn tất kiểm định")
                    ChartPKN_KQ.Series["S1"].Points.AddXY("Chưa KĐ", tk.soluong);
                if(tk.chitieu == "Mẫu thử đạt chất lượng")
                    ChartPKN_KQ.Series["S1"].Points.AddXY("Đạt", tk.soluong);
                if(tk.chitieu == "Mẫu thử không đạt chất lượng")
                    ChartPKN_KQ.Series["S1"].Points.AddXY("Không đạt", tk.soluong);
            }

            ChartPKN_NV.Series["S1"].Points.Clear();
            NhanVienBAL DBNV = new NhanVienBAL();
            foreach (var tk in datanv.Data)
            { 
                ChartPKN_NV.Series["S1"].Points.AddXY(DBNV.GetByID(conn,int.Parse(tk.chitieu)).Tennv, tk.soluong);
            }

            ChartPKN_SP.Series["S1"].Points.Clear();
            SanPhamBAL DBSP = new SanPhamBAL();
            foreach (var tk in datasp.Data)
            {
                ChartPKN_SP.Series["S1"].Points.AddXY(DBSP.GetByID(conn, tk.chitieu).Tensp, tk.soluong);
            }
        }
        private void TKTatCaPKN()
        {
            DGVPKN.Rows.Clear();
            PhieuKNBAL PKNBAL = new PhieuKNBAL();
            List<PhieuKN> lstPhieuKN = PKNBAL.GetAll(conn);
            DataChart datakq = new DataChart(), datanv = new DataChart(), datasp = new DataChart();
            if (ckbNgayKN.Checked == true)
            {
                DateTime tungay, dengay;
                tungay = dtTuNgay_pnpkn.Value;
                dengay = dtDenNgay_pnpkn.Value;
                foreach (var pkn in lstPhieuKN)
                {
                    if (pkn.Ngkn.Date >= tungay.Date && pkn.Ngkn.Date <= dengay.Date)
                    {
                        DGVPKN.Rows.Add(pkn.Spkn, pkn.Spdk, pkn.Ngkn.ToString("dd/MM/yyyy"), pkn.Manv, pkn.Masp, pkn.KL1);
                        datakq.Add(pkn.KL1, 1);
                        datanv.Add(pkn.Manv.ToString(), 1);
                        datasp.Add(pkn.Masp, 1);
                    }

                }
                txtSoLuongPKN.Text = DGVPKN.Rows.Count.ToString();
            }
            else
            {
                foreach (var pkn in lstPhieuKN)
                {
                    DGVPKN.Rows.Add(pkn.Spkn, pkn.Spdk, pkn.Ngkn.ToString("dd/MM/yyyy"), pkn.Manv, pkn.Masp, pkn.KL1);
                    datakq.Add(pkn.KL1, 1);
                    datanv.Add(pkn.Manv.ToString(), 1);
                    datasp.Add(pkn.Masp, 1);
                }
                txtSoLuongPKN.Text = DGVPKN.Rows.Count.ToString();
            }
            InChartPhieuKiemNghiem(datakq, datanv, datasp);
        }
       

        private void TKPKNBangKQ(string kl)
        {
            DGVPKN.Rows.Clear();
            PhieuKNBAL PKNBAL = new PhieuKNBAL();
            List<PhieuKN> lstPhieuKN = PKNBAL.GetByKL(conn,kl);
            DataChart datakq = new DataChart() , datanv = new DataChart(), datasp = new DataChart();
            if(ckbNgayKN.Checked==true)
            {
                DateTime tungay, dengay;
                tungay = dtTuNgay_pnpkn.Value;
                dengay = dtDenNgay_pnpkn.Value;
                foreach (var pkn in lstPhieuKN)
                {
                    if(pkn.Ngkn.Date >= tungay.Date && pkn.Ngkn.Date<=dengay.Date)
                    {
                        DGVPKN.Rows.Add(pkn.Spkn, pkn.Spdk, pkn.Ngkn.ToString("dd/MM/yyyy"), pkn.Manv, pkn.Masp, pkn.KL1);
                        datakq.Add(pkn.KL1, 1);
                        datanv.Add(pkn.Manv.ToString(), 1);
                        datasp.Add(pkn.Masp, 1);
                    }
                        
                }
                txtSoLuongPKN.Text = DGVPKN.Rows.Count.ToString();
            }
            else
            {
                foreach(var pkn in lstPhieuKN)
                {
                    DGVPKN.Rows.Add(pkn.Spkn, pkn.Spdk, pkn.Ngkn.ToString("dd/MM/yyyy"), pkn.Manv, pkn.Masp, pkn.KL1);
                    datakq.Add(pkn.KL1, 1);
                    datanv.Add(pkn.Manv.ToString(), 1);
                    datasp.Add(pkn.Masp, 1);
                }
                txtSoLuongPKN.Text = DGVPKN.Rows.Count.ToString();
            }
            InChartPhieuKiemNghiem(datakq, datanv, datasp);
            
        }
        private void TKPKNBangNV(string manv)
        {
            DGVPKN.Rows.Clear();
            PhieuKNBAL PKNBAL = new PhieuKNBAL();
            List<PhieuKN> lstPhieuKN = PKNBAL.GetBYNV(conn,manv);
            DataChart datakq = new DataChart(), datanv = new DataChart(), datasp = new DataChart();
            if (ckbNgayKN.Checked == true)
            {
                DateTime tungay, dengay;
                tungay = dtTuNgay_pnpkn.Value;
                dengay = dtDenNgay_pnpkn.Value;
                foreach (var pkn in lstPhieuKN)
                {
                    if (pkn.Ngkn.Date >= tungay.Date && pkn.Ngkn.Date <= dengay.Date)
                    {
                        DGVPKN.Rows.Add(pkn.Spkn, pkn.Spdk, pkn.Ngkn.ToString("dd/MM/yyyy"), pkn.Manv, pkn.Masp, pkn.KL1);
                        datakq.Add(pkn.KL1, 1);
                        datanv.Add(pkn.Manv.ToString(), 1);
                        datasp.Add(pkn.Masp, 1);
                    }
                }
                txtSoLuongPKN.Text = DGVPKN.Rows.Count.ToString();
            }
            else
            {
                foreach (var pkn in lstPhieuKN)
                {
                    DGVPKN.Rows.Add(pkn.Spkn, pkn.Spdk, pkn.Ngkn.ToString("dd/MM/yyyy"), pkn.Manv, pkn.Masp, pkn.KL1);
                    DGVPKN.Rows.Add(pkn.Spkn, pkn.Spdk, pkn.Ngkn.ToString("dd/MM/yyyy"), pkn.Manv, pkn.Masp, pkn.KL1);
                    datakq.Add(pkn.KL1, 1);
                    datanv.Add(pkn.Manv.ToString(), 1);
                    datasp.Add(pkn.Masp, 1);
                }
                txtSoLuongPKN.Text = DGVPKN.Rows.Count.ToString();
            }

            InChartPhieuKiemNghiem(datakq, datanv, datasp);
        }

        private void TKPKNBangSP(string masp)
        {
            DGVPKN.Rows.Clear();
            PhieuKNBAL PKNBAL = new PhieuKNBAL();
            List<PhieuKN> lstPhieuKN = PKNBAL.GetBYSP(conn, masp);
            DataChart datakq = new DataChart(), datanv = new DataChart(), datasp = new DataChart();
            if (ckbNgayKN.Checked == true)
            {
                DateTime tungay, dengay;
                tungay = dtTuNgay_pnpkn.Value;
                dengay = dtDenNgay_pnpkn.Value;
                foreach (var pkn in lstPhieuKN)
                {
                    if (pkn.Ngkn.Date >= tungay.Date && pkn.Ngkn.Date <= dengay.Date)
                    {
                        DGVPKN.Rows.Add(pkn.Spkn, pkn.Spdk, pkn.Ngkn.ToString("dd/MM/yyyy"), pkn.Manv, pkn.Masp, pkn.KL1);
                        datakq.Add(pkn.KL1, 1);
                        datanv.Add(pkn.Manv.ToString(), 1);
                        datasp.Add(pkn.Masp, 1);
                    }
                }
                txtSoLuongPKN.Text = DGVPKN.Rows.Count.ToString();
            }
            else
            {
                foreach (var pkn in lstPhieuKN)
                {
                    DGVPKN.Rows.Add(pkn.Spkn, pkn.Spdk, pkn.Ngkn.ToString("dd/MM/yyyy"), pkn.Manv, pkn.Masp, pkn.KL1);
                    DGVPKN.Rows.Add(pkn.Spkn, pkn.Spdk, pkn.Ngkn.ToString("dd/MM/yyyy"), pkn.Manv, pkn.Masp, pkn.KL1);
                    datakq.Add(pkn.KL1, 1);
                    datanv.Add(pkn.Manv.ToString(), 1);
                    datasp.Add(pkn.Masp, 1);
                }
                txtSoLuongPKN.Text = DGVPKN.Rows.Count.ToString();
            }
            InChartPhieuKiemNghiem(datakq, datanv, datasp);

        }
        private void rdbtTatca_pnpkn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtTatca_pnpkn.Checked)
            {
                TKTatCaPKN();
                cbTieuChi_pnpkn.Hide();
            }

                
                
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dtDenNgay_pnpkn.Show();
            dtTuNgay_pnpkn.Show();
            cbTieuChi_pnpkn.Hide();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbtNhanVien_pnpkn.Checked)
            {
                cbTieuChi_pnpkn.Show();
                NhanVienBAL NVBAL = new NhanVienBAL();
                List<NhanVien> lstNhanVien = NVBAL.GetByMaPB(conn, ConfigurationManager.AppSettings["maphongkiemdinh"]);
                cbTieuChi_pnpkn.DataSource = null;
                cbTieuChi_pnpkn.DisplayMember = "Tennv";
                cbTieuChi_pnpkn.ValueMember = "Manv";
                cbTieuChi_pnpkn.DataSource = lstNhanVien;
            }
           
        }

        private void rdbtSanPham_pnpkn_CheckedChanged(object sender, EventArgs e)
        {
            cbTieuChi_pnpkn.Show();
            cbTieuChi_pnpkn.DataSource = null;
            if (rdbtSanPham_pnpkn.Checked)
            {
                PhieuKNBAL DBPKN = new PhieuKNBAL();
                cbTieuChi_pnpkn.DataSource = DBPKN.GetAllMaSanPham(conn);
                cbTieuChi_pnpkn.DisplayMember = "Tensp";
                cbTieuChi_pnpkn.ValueMember = "Masp";


            }
          
        }

        private void ThongKePKN()
        {
            if (!rdbtTatca_pnpkn.Checked && cbTieuChi_pnpkn.SelectedValue == null)
                return;
            if (rdbtKQ_pnpkn.Checked)
            {
                TKPKNBangKQ(cbTieuChi_pnpkn.SelectedValue.ToString());
            }
            else if (rdbtNhanVien_pnpkn.Checked)
            {
                TKPKNBangNV(cbTieuChi_pnpkn.SelectedValue.ToString());
            }
            else if (rdbtSanPham_pnpkn.Checked)
            {
                TKPKNBangSP(cbTieuChi_pnpkn.SelectedValue.ToString());
            }
            else if(rdbtTatca_pnpkn.Checked)
            {
                TKTatCaPKN();
            }
        }
        private void cbTieuChi_pnpkn_SelectedValueChanged(object sender, EventArgs e)
        {
            ThongKePKN();
        }

        private void dtTuNgay_pnpkn_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtTuNgay_pnpkn.Value > dtDenNgay_pnpkn.Value)
                    throw new Exception("Điều kiện ngày không hợp lệ");
                else
                {
                    ThongKePKN();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void dtDenNgay_pnpkn_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtTuNgay_pnpkn.Value > dtDenNgay_pnpkn.Value)
                    throw new Exception("Điều kiện ngày không hợp lệ");
                else
                {
                    ThongKePKN();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void ckbNgayKN_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbNgayKN.Checked==true)
            {
                 pnNgayThang_pnpkn.Show();  
            }
            else
            {
                pnNgayThang_pnpkn.Hide();
            }
            ThongKePKN();
        }

        private void FormThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parr.Show();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbtKQ_pnpkn_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbtKQ_pnpkn.Checked)
            {      
                cbTieuChi_pnpkn.Show();
                cbTieuChi_pnpkn.DataSource = null;
                Dictionary<string, string> test = new Dictionary<string, string>();
                test.Add("Chưa hoàn tất kiểm định", "Chưa hoàn tất kiểm định");
                test.Add("Mẫu thử đạt chất lượng", "Mẫu thử đạt chất lượng");
                test.Add("Mẫu thử không đạt chất lượng", "Mẫu thử không đạt chất lượng");
                cbTieuChi_pnpkn.DataSource = new BindingSource(test, null);
                cbTieuChi_pnpkn.DisplayMember = "display";
                cbTieuChi_pnpkn.ValueMember = "value";
            }
        }

        
    }
}
