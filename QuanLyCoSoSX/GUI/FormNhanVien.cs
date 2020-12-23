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

        public FormNhanVien()
        {

            InitializeComponent();
            LoadCBPB();
            this.DtNgSinh.CustomFormat = "dd/MM/yyyy";
            DtNgSinh.Format = DateTimePickerFormat.Custom;
            GetDGV();
        }


        private void GetDGV()
        {
            //listView1.Items.Clear();
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
        private void GetThongTinbt_Click(object sender, EventArgs e)
        {
            GetDGV();

        }
        

        private void LoadCBPB()
        {
            PhongBanBAL db = new PhongBanBAL();
            foreach (var item in db.GetAll(conn))
            {

                cbPhongBan.Items.Add(item.Tenpb);
            }

        }

        private void Thembt_Click(object sender, EventArgs e)
        {

            PhongBanBAL db = new PhongBanBAL();
            NhanVienBAL dbnv = new NhanVienBAL();
            try
            {
                dbnv.Insert(conn, txtTenNv.Text, DtNgSinh.Value.ToString("yyyy/MM/dd"), cbGioiTinh.Text,
                                db.GetByName(conn, cbPhongBan.Text).Mapb, txtSDT.Text);
                GetDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi");
            }

        }

        private void Suabt_Click(object sender, EventArgs e)
        {
            PhongBanBAL db = new PhongBanBAL();
            NhanVienBAL dbnv = new NhanVienBAL();
            try
            {
                //ListViewItem item = listView1.SelectedItems[0];
                //int manv = int.Parse(item.SubItems[0].Text);
                int manv = int.Parse(DGVNhanvien.SelectedRows[0].Cells[0].Value.ToString());
                dbnv.Update(conn, manv, txtTenNv.Text, DtNgSinh.Value.ToString("yyyy/MM/dd"), cbGioiTinh.Text,
                                db.GetByName(conn, cbPhongBan.Text).Mapb, txtSDT.Text);
                GetDGV();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Lỗi");
            }
        }

        private void Xoabt_Click(object sender, EventArgs e)
        {
            NhanVienBAL dbnv = new NhanVienBAL();
            try
            {
                int manv = int.Parse(DGVNhanvien.SelectedRows[0].Cells[0].Value.ToString());
                dbnv.Delete(conn, manv);
                GetDGV();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Lỗi");
            }

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
    }
}
