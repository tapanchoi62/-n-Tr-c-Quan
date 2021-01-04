using MySql.Data.MySqlClient;
using QuanLyCoSoSX.BAL;
using QuanLyCoSoSX.DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoSoSX.GUI
{
    public partial class FormQuanLiCoSoSanXuat : Form
    {

        private Form parent;
        public FormQuanLiCoSoSanXuat()
        {
            InitializeComponent();
            GetDGV();
        }
        
        public FormQuanLiCoSoSanXuat(Form par)
        {
            this.parent = par;
            InitializeComponent();
            GetDGV();
        }

        bool CheckSDT()
        {
            
            if (txtSoDienThoai.Text.Length > 15)
                return false; 
            foreach(char c in txtSoDienThoai.Text)
            {
                if (!char.IsDigit(c))     
                    return false;
            }
            return true;
        }

        bool CheckInsert()
        {
           
            if (txtCoSoSanXuat.Text == "")
            {
                throw new Exception("Cơ sở sản xuất không hợp lệ");
            }
            if(txtChuCoSo.Text=="")
            {
                throw new Exception("Chủ cơ sở không hợp lệ ");
            }    
            if (txtDiaChi.Text == "")
            {
                throw new Exception("Địa chỉ không hợp lệ");
            }
            if (!CheckSDT())
            {
                throw new Exception("Số điện thoại không hợp lệ");
            }
            return true;
        }
        
        bool Check()
        {
            
            if (txtMaCSSX.Text == "")
            {
                throw new Exception("Mã CSSX không hợp lệ");
            }
            CheckInsert();
            return true;        
        }
        private void FormQuanLiCoSoSanXuat_Load(object sender, EventArgs e)
        {

        }

        void GetDGV()
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            try
            {
                CSSXBAL cssx = new CSSXBAL();
                var LstCSSX = cssx.GetAll(conn);
                DGV.Rows.Clear();
                foreach(var cs in LstCSSX)
                {
                    DGV.Rows.Add(cs.Macs, cs.Tencs, cs.Diachi, cs.Tenchu, cs.Sodt);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LayThongTin_Click(object sender, EventArgs e)
        {
            GetDGV();
        }

        void Search()
        {

            try
            {
                DGV.Rows.Clear();
                if (SearchCSSX.Text != "")
                {
                    MySqlConnection conn = DBConnect.GetDBConnection();
                    CSSXBAL CSSX = new CSSXBAL();
                    var lstCSSX = CSSX.SearchByInfo(conn,SearchCSSX.Text);        
                    foreach(var cs in lstCSSX)
                    {
                        DGV.Rows.Add(cs.Macs, cs.Tencs, cs.Diachi, cs.Tenchu, cs.Sodt);
                    }
                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SearchCSSXbt_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txtMaCSSX.Text = DGV.Rows[index].Cells[0].Value.ToString();
                txtCoSoSanXuat.Text = DGV.Rows[index].Cells[1].Value.ToString();
                txtChuCoSo.Text = DGV.Rows[index].Cells[3].Value.ToString();
                txtDiaChi.Text = DGV.Rows[index].Cells[2].Value.ToString();
                txtSoDienThoai.Text = DGV.Rows[index].Cells[4].Value.ToString();
            }
        }

     

        private void Sua_Click(object sender, EventArgs e)
        {
            

            try
            {
                Check();
                int Macs = int.Parse(txtMaCSSX.Text);
                string TenCS = txtCoSoSanXuat.Text;
                string TenChu = txtChuCoSo.Text;
                string DiaChi = txtDiaChi.Text;
                string SoDT = txtSoDienThoai.Text;
                MySqlConnection conn = DBConnect.GetDBConnection();
                CSSXBAL CSSX = new CSSXBAL();
                CSSX.Update(conn, Macs, TenCS, DiaChi, TenChu, SoDT);
                GetDGV();
                MessageBox.Show("Sửa thông tin thành công", "Thành công");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void Xoa_Click(object sender, EventArgs e)
        {
            
            try
            {
                var select = MessageBox.Show("Nếu tiếp tục hệ thống sẽ xoá toàn bộ các dữ liệu có liên quan đến cơ sở sản xuất này. Bạn có muốn tiếp tục không ?", "Cảnh báo!", MessageBoxButtons.YesNoCancel);
                if (select == DialogResult.Yes)
                {

                    MySqlConnection conn = DBConnect.GetDBConnection();
                    CSSXBAL cssx = new CSSXBAL();
                    cssx.Delete(conn, txtMaCSSX.Text);
                    GetDGV();
                    MessageBox.Show("Xoá thành công", "Thành công");
                }
                
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInsert();
                string TenCs = txtCoSoSanXuat.Text;
                string TenChu = txtChuCoSo.Text;
                string DiaChi = txtDiaChi.Text;
                string SoDT = txtSoDienThoai.Text;
                MySqlConnection conn = DBConnect.GetDBConnection();
                CSSXBAL CSSX = new CSSXBAL();
                CSSX.Insert(conn, TenCs, DiaChi, TenChu, SoDT);
                GetDGV();
                MessageBox.Show("Thêm thành công","Thành công");

            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void FormQuanLiCoSoSanXuat_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        private void SearchCSSX_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Search();
            }    
        }
    }
}
