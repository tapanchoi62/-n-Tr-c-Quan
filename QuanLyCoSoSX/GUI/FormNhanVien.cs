using QuanLyCoSoSX.BAL;
using QuanLyCoSoSX.DAO;
using QuanLyCoSoSX.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoSoSX.GUI
{
    public partial class FormNhanVien : Form
    {
        MySqlConnection conn = DBConnect.GetDBConnection();

        public FormNhanVien()
        {

            InitializeComponent();
            LoadCBPB();
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }



        private void GetThongTinbt_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            NhanVienBAL db = new NhanVienBAL();
            foreach (var item in db.GetAll(conn))
            {
                var row = new String[]
                {
                   item.Manv.ToString(),
                   item.Tennv,
                   item.Ngsinh.ToString("yyyy/MM/dd"),
                   item.Gioitinh,
                   item.getpb().Tenpb,
                   item.Sdt
                };
                var lvi = new ListViewItem(row);

                listView1.Items.Add(lvi);
            }

        }

        private void getThongTin()
        {
            listView1.Items.Clear();
            NhanVienBAL db = new NhanVienBAL();
            foreach (var item in db.GetAll(conn))
            {
                var row = new String[]
                {
                   item.Manv.ToString(),
                   item.Tennv,
                   item.Ngsinh.ToString("yyyy/MM/dd"),
                   item.Gioitinh,
                   item.getpb().Tenpb,
                   item.Sdt
                };
                var lvi = new ListViewItem(row);

                listView1.Items.Add(lvi);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {

                return;
            }
            else
            {
                ListViewItem item = listView1.SelectedItems[0];
                textBox1.Text = item.SubItems[1].Text;
                dateTimePicker1.Value = DateTime.ParseExact(item.SubItems[2].Text, "yyyy/MM/dd", CultureInfo.InvariantCulture);
                comboBox2.Text = item.SubItems[4].Text;
                comboBox1.Text = item.SubItems[3].Text;
                textBox2.Text = item.SubItems[5].Text;

            }
        }

        private void LoadCBPB()
        {
            PhongBanBAL db = new PhongBanBAL();
            foreach (var item in db.GetAll(conn))
            {

                comboBox2.Items.Add(item.Tenpb);
            }

        }

        private void Thembt_Click(object sender, EventArgs e)
        {

            PhongBanBAL db = new PhongBanBAL();
            NhanVienBAL dbnv = new NhanVienBAL();
            try
            {
                dbnv.Insert(conn, textBox1.Text, dateTimePicker1.Value.ToString("yyyy/MM/dd"), comboBox1.Text,
                                db.GetByName(conn, comboBox2.Text).Mapb, textBox2.Text);
                MessageBox.Show("Them thanh cong");
                getThongTin();
            }
            catch (Exception)
            {
                MessageBox.Show("Them that bai");
            }

        }

        private void Suabt_Click(object sender, EventArgs e)
        {
            PhongBanBAL db = new PhongBanBAL();
            NhanVienBAL dbnv = new NhanVienBAL();
            try
            {
                ListViewItem item = listView1.SelectedItems[0];
                int manv = int.Parse(item.SubItems[0].Text);
                dbnv.Update(conn, manv, textBox1.Text, dateTimePicker1.Value.ToString("yyyy/MM/dd"), comboBox1.Text,
                                db.GetByName(conn, comboBox2.Text).Mapb, textBox2.Text);
                MessageBox.Show("Cap nhat thanh cong");
                getThongTin();
            }
            catch (Exception)
            {

                MessageBox.Show("Cap nhat khong thanh cong");
            }
        }

        private void Xoabt_Click(object sender, EventArgs e)
        {
            PhongBanBAL db = new PhongBanBAL();
            NhanVienBAL dbnv = new NhanVienBAL();
            try
            {
                ListViewItem item = listView1.SelectedItems[0];
                int manv = int.Parse(item.SubItems[0].Text);
                dbnv.Delete(conn, manv);
                getThongTin();
                MessageBox.Show("Xóa Thành công");
            }
            catch (Exception)
            {

                MessageBox.Show("Xóa không Thành công");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            NhanVienBAL dbnv = new NhanVienBAL();
            listView1.Items.Clear();
            
            foreach (var item in dbnv.FindNV(conn, FindNhanVien.Text))
            {
                var row = new String[]
                {
                   item.Manv.ToString(),
                   item.Tennv,
                   item.Ngsinh.ToString("yyyy/MM/dd"),
                   item.Gioitinh,
                   item.getpb().Tenpb,
                   item.Sdt
                };
                var lvi = new ListViewItem(row);

                listView1.Items.Add(lvi);
            }
            
        }
    }
}
