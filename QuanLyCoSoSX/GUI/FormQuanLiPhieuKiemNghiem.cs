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


namespace QuanLyCoSoSX.GUI
{
    public partial class FormQuanLiPhieuKiemNghiem : Form
    {
        Form parent;
        public FormQuanLiPhieuKiemNghiem()
        {
            InitializeComponent();
        }
        public FormQuanLiPhieuKiemNghiem(ManHinhQuanLyNhanVien par)
        {
            this.parent = par;
            InitializeComponent();
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
                
                foreach (var phieukn in dbPKN.GetAll(conn))
                {           
                    SanPham sp = phieukn.getSanPham();
                    NhanVien nv = phieukn.getnv();
                    string[] row = new string[] { phieukn.Spkn, phieukn.Ngkn.ToString("dd/MM/yy"),sp.Tensp,nv.Tennv, phieukn.KL1};
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

        private void SPDK_TextChanged(object sender, EventArgs e)
        {

        }

        private void XoaPKN_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FormQuanLiSanPham_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void ThemPKN_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormQuanLiPhieuKiemNghiem_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormQuanLiPhieuKiemNghiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parent.Show();
        }

        private void LayThongTin_Click(object sender, EventArgs e)
        {
            GetDGV2();
        }

        private void DGVDSChiTieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
