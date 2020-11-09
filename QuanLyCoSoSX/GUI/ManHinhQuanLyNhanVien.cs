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
        private  Form parent;
        public ManHinhQuanLyNhanVien()
        {
            InitializeComponent();
        }

        public ManHinhQuanLyNhanVien(Form par)
        {
            this.parent = par;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormQuanLiCoSoSanXuat cssx = new FormQuanLiCoSoSanXuat(this);
            cssx.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            FormSanPham sanpham = new FormSanPham(this);
            sanpham.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormQuanLiChatLuong ChiTieu = new FormQuanLiChatLuong(this);
            ChiTieu.Show();
            this.Hide();
        }

        private void ManHinhQuanLyNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
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
