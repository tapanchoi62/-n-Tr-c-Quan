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
    public partial class FormQuanLiChatLuong : Form
    {
        private Form parent;
        public FormQuanLiChatLuong()
        {
            InitializeComponent();
        }

        public FormQuanLiChatLuong(Form par)
        {
            this.parent = par;
            InitializeComponent();
        }
        void GetDGVChiTieu()
        {
            MySqlConnection conn = DBConnect.GetDBConnection();
            ChiTieuBAL ChiTieu = new ChiTieuBAL();
            var CT = ChiTieu.GetAll(conn);
            DGVChiTieu.Rows.Clear();
            foreach (var c in CT)
            {
                DGVChiTieu.Rows.Add(c.Mact, c.Tenchitieu, c.Ynghia);
            }
        }
        private void GetThongTinbt_Click(object sender, EventArgs e)
        {
            GetDGVChiTieu();
        }

        private void Xoabt_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                ChiTieuBAL ChiTieu = new ChiTieuBAL();
                ChiTieu.Delete(conn, txtMaChiTieu.Text);
                GetDGVChiTieu();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void Suabt_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                ChiTieuBAL ChiTieu = new ChiTieuBAL();
                ChiTieu.Update(conn, txtMaChiTieu.Text, txtTenChiTieu.Text, txtYNghia.Text);
                GetDGVChiTieu();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Thembt_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = DBConnect.GetDBConnection();
                ChiTieuBAL ChiTieu = new ChiTieuBAL();
                ChiTieu.Insert(conn, txtMaChiTieu.Text, txtTenChiTieu.Text, txtYNghia.Text);
                GetDGVChiTieu();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGVChiTieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >=0)
            {
                txtMaChiTieu.Text = DGVChiTieu.Rows[index].Cells[0].Value.ToString();
                txtTenChiTieu.Text = DGVChiTieu.Rows[index].Cells[1].Value.ToString();
                txtYNghia.Text = DGVChiTieu.Rows[index].Cells[2].Value.ToString();
            }
            
        }

        private void FormQuanLiChatLuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        void SearchChiTieu()
        {
            if (txtSearchChiTieu.Text == "")
            {
                GetDGVChiTieu();
                return;
            }
            MySqlConnection conn = DBConnect.GetDBConnection();
            ChiTieuBAL ChiTieu = new ChiTieuBAL();
            var lstChiTieu = ChiTieu.SearchByInfo(conn, txtSearchChiTieu.Text);
            DGVChiTieu.Rows.Clear();
            foreach(var ct in lstChiTieu)
                DGVChiTieu.Rows.Add(ct.Mact, ct.Tenchitieu, ct.Ynghia);
        }
        private void SearchChiTieubt_Click(object sender, EventArgs e)
        {
            SearchChiTieu();
        }

        private void txtSearchChiTieu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                SearchChiTieu();
        }

   
    }
}
