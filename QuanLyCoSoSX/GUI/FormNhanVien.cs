using QuanLyCoSoSX.BAL;
using QuanLyCoSoSX.DAO;
using QuanLyCoSoSX.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoSoSX.GUI
{
    public partial class FormNhanVien : Form
    {
        MySqlConnection conn = DBConnect.GetDBConnection();
        Form Parr;
        public FormNhanVien()
        {

            InitializeComponent();
            LoadCBPB();
            this.DtNgSinh.CustomFormat = "dd/MM/yyyy";
            DtNgSinh.Format = DateTimePickerFormat.Custom;
            GetDGVNhanVien();
        }

        public FormNhanVien(Form pa)
        {
            this.Parr = pa;
            InitializeComponent();
            LoadCBPB();
            this.DtNgSinh.CustomFormat = "dd/MM/yyyy";
            DtNgSinh.Format = DateTimePickerFormat.Custom;
            GetDGVNhanVien();
        }
        private void GetDGVNhanVien()
        {
            DGVNhanvien.Rows.Clear();
            NhanVienBAL db = new NhanVienBAL();
            foreach (var item in db.GetAll(conn))
            {
                DGVNhanvien.Rows.Add(item.Manv.ToString(),
                   item.Tennv,
                   item.Ngsinh.ToString("yyyy/MM/dd"),
                   item.Gioitinh,
                   item.getpb().Tenpb,
                   item.Sdt);
            }
        }

        bool CheckSDT()
        {

            if (txtSDT.Text.Length > 15)
                return false;
            foreach (char c in txtSDT.Text)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }
        private void checkTT()
        {
            if (txtTenNv.Text == "")
                throw new Exception("Tên nhân viên không được để trống");
            if (!CheckSDT())
                throw new Exception("Số điện thoại không hợp lệ");
            if (cbGioiTinh.Text == "")
                throw new Exception("Vui lòng chọn giới tính của nhân viên");
            if (cbPhongBan.Text == "")
                throw new Exception("Vui lòng chọn phòng ban nhân viên làm việc");
        }
        private void GetThongTinbt_Click(object sender, EventArgs e)
        {
            GetDGVNhanVien();
        }

        private void LoadCBPB()
        {
            PhongBanBAL db = new PhongBanBAL();
            foreach (var item in db.GetAll(conn))
            {

                cbPhongBan.Items.Add(item.Tenpb);
            }

        }
        private void themNhanVien(string tenNV,string ngSinh,string gioiTinh,string tenPB,string sdt)
        {
           
            try
            {
                checkTT();
                PhongBanBAL db = new PhongBanBAL();
                NhanVienBAL dbnv = new NhanVienBAL();
                dbnv.Insert(conn, tenNV, ngSinh, gioiTinh,
                                db.GetByName(conn, tenPB).Mapb, sdt);
                GetDGVNhanVien();
                MessageBox.Show("Thêm thành công", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void Thembt_Click(object sender, EventArgs e)
        {
            themNhanVien(txtTenNv.Text, DtNgSinh.Value.ToString("yyyy/MM/dd"), cbGioiTinh.Text, cbPhongBan.Text, txtSDT.Text);
        }
           


        private void suaNhanVien(int maNV,string tenNV, string ngSinh, string gioiTinh, string tenPB, string sdt)
        {

          
            try
            {
                checkTT();
                PhongBanBAL db = new PhongBanBAL();
                NhanVienBAL dbnv = new NhanVienBAL();
                int manv = int.Parse(DGVNhanvien.SelectedRows[0].Cells[0].Value.ToString());
                dbnv.Update(conn, maNV, tenNV, ngSinh, gioiTinh,
                                db.GetByName(conn, tenPB).Mapb, sdt);
                GetDGVNhanVien();
                MessageBox.Show("Sữa thông tin thành công", "Thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void Suabt_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(DGVNhanvien.SelectedRows[0].Cells[0].Value.ToString());
            suaNhanVien(manv, txtTenNv.Text, DtNgSinh.Value.ToString("yyyy/MM/dd"), cbGioiTinh.Text,
                             cbPhongBan.Text, txtSDT.Text);
        }

        private void xoaNhanVien(int maNV)
        {
           
            try
            {
                checkTT();
                NhanVienBAL dbnv = new NhanVienBAL();
                dbnv.Delete(conn, maNV);
                GetDGVNhanVien();
                MessageBox.Show("Thêm thành công", "Thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void Xoabt_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(DGVNhanvien.SelectedRows[0].Cells[0].Value.ToString());
            xoaNhanVien(manv);
        }

        private void Search()
        {
            NhanVienBAL dbnv = new NhanVienBAL();
            DGVNhanvien.Rows.Clear();
            foreach (var item in dbnv.FindNV(conn, FindNhanVien.Text))
            {
                DGVNhanvien.Rows.Add(item.Manv.ToString(),
                   item.Tennv,
                   item.Ngsinh.ToString("yyyy/MM/dd"),
                   item.Gioitinh,
                   item.getpb().Tenpb,
                   item.Sdt);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Search();
        }

        private void DGVNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                txtTenNv.Text = DGVNhanvien.SelectedRows[0].Cells[1].Value.ToString();
                DtNgSinh.Text = DGVNhanvien.SelectedRows[0].Cells[2].Value.ToString();
                cbGioiTinh.SelectedItem = DGVNhanvien.SelectedRows[0].Cells[3].Value.ToString();
                cbPhongBan.SelectedItem = DGVNhanvien.SelectedRows[0].Cells[4].Value.ToString();
                txtSDT.Text = DGVNhanvien.SelectedRows[0].Cells[5].Value.ToString();
            }    
        }

        private void FindNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }

        private void FormNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parr.Show();
        }
    }
}
