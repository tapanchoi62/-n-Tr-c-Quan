using MySql.Data.MySqlClient;
using QuanLyCoSoSX.BAL;
using QuanLyCoSoSX.DAO;
using QuanLyCoSoSX.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace QuanLyCoSoSX.GUI
{
    public partial class FormDangKyTaiKhoan : Form
    {
        private Form parent;
        public FormDangKyTaiKhoan()
        {
            InitializeComponent();
            cbQuyen.SelectedIndex = 0;
        }

        public FormDangKyTaiKhoan(Form par)
        {
            this.parent = par;
            InitializeComponent();
            cbQuyen.SelectedIndex = 0;
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
            if (nv.CheackMaNV(conn,int.Parse(txtMaNhanVien.Text)))
                return true;
            else
                return false;
         }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            TaiKhoanBAL taikhoan = new TaiKhoanBAL();

            if (!CheckManv())
            {
                MessageBox.Show("Mã nhân viên không tồn tại");
                return;
            }

            if (taikhoan.CheckUser(conn,txtUsername.Text))
            {
                MessageBox.Show("Tài khoản đã tồn tại");
                return;
            }    
           
            if(!CheckPassword())
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
                return;
            }
            try
            {
                byte[] temp = ASCIIEncoding.ASCII.GetBytes(txtPass.Text);
                byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
                string hasPass = "";
                foreach (byte item in hasData)
                {
                    hasPass += item;
                }

                string username = txtUsername.Text;
                string pass = hasPass;
                string quyen = cbQuyen.SelectedIndex == 0 ? "nhanvien" : "quanly";
                int manv = int.Parse(txtMaNhanVien.Text);

                taikhoan.Insert(conn, username, pass, manv, quyen);

                MessageBox.Show("Tạo tài khoản thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void FormDangKyTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }
    }
}
