using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoSoSX.GUI
{
    public partial class ManHinhQuanLy : Form
    {
        public ManHinhQuanLy()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNhanVien form = new FormNhanVien();
            form.Visible = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ManHinhQuanLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormDangNhap dn = new FormDangNhap();
            dn.Visible = true;
        }
    }
}
