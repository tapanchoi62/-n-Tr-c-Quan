using QuanLyCoSoSX.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoSoSX
{
    public partial class ManHinhQuanLyNhanVien : Form
    {
        public ManHinhQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            FormSanPham sanpham = new FormSanPham(this);
            sanpham.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ManHinhQuanLyNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormDangNhap dn = new FormDangNhap();
            dn.Visible = true;
        }

        private void ManHinhQuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLyPhieuDangKy qlpdk = new FormQuanLyPhieuDangKy(this);
            qlpdk.Show();
        }
    }
}
