using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCoSoSX.BAL;
using QuanLyCoSoSX.DAO;
using QuanLyCoSoSX.DTO;
using QuanLyCoSoSX.GUI;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace QuanLyCoSoSX.GUI
{
    public partial class FormXuLyTaiKhoan : Form
    {

        MySqlConnection conn = DBConnect.GetDBConnection();
        Form Parr;
        public FormXuLyTaiKhoan()
        {
            InitializeComponent();
        }

        public FormXuLyTaiKhoan(Form parent)
        {
            this.Parr = parent;
            InitializeComponent();
            cbQuyen.SelectedIndex = 0;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        bool CheckPassword()
        {
            if (txtPass.Text != txtRePass.Text)
                return false;
            return true;
        }

        bool CheckManv()
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            NhanVienBAL nv = new NhanVienBAL();
            try
            {
                if (nv.CheackMaNV(conn, int.Parse(txtMaNhanVien.Text)))
                    return true;
                else
                    return false;
            }
            catch
            {
                throw new Exception("Mã nhân viên phải là số");
            }
        }

        private bool KiemTraLogin(string tentk, string pass)
        {
            TaiKhoanBAL db = new TaiKhoanBAL();
            if (db.GetByTenTK(conn, tentk, pass).Quyen == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void KhoiPhuc()
        {
            TaiKhoanBAL db = new TaiKhoanBAL();
            string user = txtTenTKQL.Text;
            string pass = txtMKQL.Text;
            TaiKhoan tk = db.GetByTenTK(conn, user, pass);

            if (KiemTraLogin(user, pass))
            {
                if (tk.Quyen == ("quanly"))
                {
                    try
                    {

                        if (!CheckPassword())
                        {
                            MessageBox.Show("Mật khẩu không trùng khớp", "Lỗi");
                            return;
                        }

                        if (!CheckManv())
                        {
                            MessageBox.Show("Mã nhân viên không tồn tại","Lỗi");
                            return;
                        }

                        if(db.CheckUserName(conn,txtUsername.Text,txtMaNhanVien.Text))
                        {
                            MessageBox.Show("Tên tài khoản đã được sử dụng");
                            return;
                        }    

                        int manv = int.Parse(txtMaNhanVien.Text);
                        if(manv == tk.Manv&&cbQuyen.SelectedIndex==0)
                        {
                            MessageBox.Show("Nhân viên không thể thay đổi quyền truy cập của chính mình.", "Lỗi");
                            return;
                        }    

                        string tentk = txtUsername.Text;
                        byte[] temp = ASCIIEncoding.ASCII.GetBytes(txtPass.Text);
                        byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
                        string hasPass = "";
                        foreach (byte item in hasData)
                        {
                            hasPass += item;
                        }
                        string quyen = cbQuyen.SelectedIndex == 0 ? "nhanvien" : "quanly";
                        db.Update(conn, tentk, hasPass, manv, quyen);
                        MessageBox.Show("chỉnh sửa tài khoản thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Lỗi");
                    }


                    
                }
                else
                {
                    MessageBox.Show("Chỉ quản lý mới có quyền chỉnh sửa tài khoản");
                }    
            }
            else
            {
                MessageBox.Show("Tài khoản quản lý không đúng, vui lòng đăng nhập lại !!! ", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KhoiPhuc();
        }

        private void FormKhoiPhucTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parr.Show();
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
