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
        Form parent;
        public ManHinhQuanLy()
        {
            InitializeComponent();
            
        }

        public ManHinhQuanLy(Form par)
        {
            this.parent = par;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormNhanVien form = new FormNhanVien();
            form.Visible = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPhongBan formpb = new FormPhongBan(this);
            formpb.Show();
            this.Hide();
        }

        private void ManHinhQuanLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormThongKe form = new FormThongKe(this);
            form.Show();
            this.Hide();
        }
    }
}
