using MySql.Data.MySqlClient;
using QuanLyCoSoSX.BAL;
using QuanLyCoSoSX.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoSoSX.GUI
{
    public partial class FormPhongBan : Form
    {
        private Form parent;
        public FormPhongBan()
        {
            InitializeComponent();
        }
        public FormPhongBan(Form par)
        {
            this.parent = par;
            InitializeComponent();
        }

        private void FormPhongBan_FormClosed(object sender, FormClosedEventArgs e)
        {          
            this.parent.Show();
        }
        void GetDGVPhongBan()
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            PhongBanBAL PhongBanbal = new PhongBanBAL();
            var pb = PhongBanbal.GetAll(conn);
            DGVPhongBan.Rows.Clear();
            foreach(var pb1 in pb)
            {
                DGVPhongBan.Rows.Add(pb1.Mapb,pb1.Tenpb);
            }
        }

        private void GetThongTinbt_Click(object sender, EventArgs e)
        {
            GetDGVPhongBan();
        }

        private void DGVChiTieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                textboxMaPhongBan.Text = DGVPhongBan.Rows[index].Cells[0].Value.ToString();
                textboxTenPhongBan.Text = DGVPhongBan.Rows[index].Cells[1].Value.ToString();
            }
        }
        void Search()
        {
            if (textBoxSearchPhongBan.Text == "")
            {
                GetDGVPhongBan();
                return;
            }
            MySqlConnection conn = DBConnect.GetDBConnection();
            PhongBanBAL PhongBanbal = new PhongBanBAL();
            var pb = PhongBanbal.GetByID(conn, textBoxSearchPhongBan.Text);
            DGVPhongBan.Rows.Clear();
            DGVPhongBan.Rows.Add(pb.Mapb, pb.Tenpb);
        }

        private void SearchPhongBan_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxSearchPhongBan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                Search();
            }
        }

        private void Xoabt_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhongBanBAL PhongBanbal = new PhongBanBAL();
                PhongBanbal.Delete(conn, textboxMaPhongBan.Text);
                GetDGVPhongBan();
                MessageBox.Show("xóa thành công !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("thất bại" + ex.Message);
            }
        }

        private void Thembt_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                PhongBanBAL PhongBanbal = new PhongBanBAL();
                var pb = PhongBanbal.GetAll(conn);
                foreach (var pb1 in pb)
                {
                    if(pb1.Mapb==textboxMaPhongBan.Text)
                    {
                        throw new ArgumentException("mã phòng ban không được trùng lặp !");
                    }
                }
                if (textboxMaPhongBan.Text == "")
                {
                    throw new ArgumentException("mã phòng ban không được trống !");
                }
                PhongBanbal.Insert(conn, textboxMaPhongBan.Text, textboxTenPhongBan.Text);
                GetDGVPhongBan();
                MessageBox.Show("thêm thành công !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("thất bại ! " + ex.Message);
            }      
        }

        private void Suabt_Click(object sender, EventArgs e)
        { 
            try
            {

                MySqlConnection conn = DBConnect.GetDBConnection();
                PhongBanBAL PhongBanbal = new PhongBanBAL();
                var pb = PhongBanbal.GetAll(conn);
                foreach (var pb1 in pb)
                {
                    if (pb1.Mapb == textboxMaPhongBan.Text)
                    {
                        throw new ArgumentException("mã phòng ban không được trùng lặp !");
                    }
                }
                if (textboxMaPhongBan.Text == "")
                {
                    throw new ArgumentException("mã phòng ban không được trống !");
                }
                PhongBanbal.Update(conn, textboxMaPhongBan.Text, textboxTenPhongBan.Text);
                GetDGVPhongBan();
                MessageBox.Show("sửa thành công !");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thất bại ! "+ ex.Message);
            }
        }
    }
}
