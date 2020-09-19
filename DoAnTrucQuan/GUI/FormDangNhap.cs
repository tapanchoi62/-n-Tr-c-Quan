﻿using DoAnTrucQuan.BAL;
using DoAnTrucQuan.DAO;
using DoAnTrucQuan.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTrucQuan.GUI
{
    public partial class FormDangNhap : Form
    {
        MySqlConnection conn = DBConnect.GetDBConnection();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TaiKhoanBAL db = new TaiKhoanBAL();
            string user = textBox1.Text;
            string pass = textBox2.Text;
            TaiKhoan tk = db.GetByTenTK(conn,user,pass) ;
            
            if (KiemTraLogin(user, pass))
            {
                if(tk.Quyen == "nhanvien")
                {
                    ManHinhQuanLyNhanVien manhinh = new ManHinhQuanLyNhanVien();
                    manhinh.Visible = true;
                    this.Visible = false;
                }
                else
                if(tk.Quyen == ("quanly"))
                {
                    ManHinhQuanLy manhinh = new ManHinhQuanLy();
                    manhinh.Visible = true;
                    this.Close();

                }
            }
            else 
            {
                MessageBox.Show("Đăng nhập lỗi, vui lòng đăng nhập lại !!! ", "Thông báo");
            }


        }

        
        private bool KiemTraLogin(string tentk,string pass) 
        {
            TaiKhoanBAL db = new TaiKhoanBAL();

            if (db.GetByTenTK(conn, tentk, pass).Quyen == null) 
            {
                return false;
            }
            else
            {
                return true;
            }
           
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TaiKhoanBAL db = new TaiKhoanBAL();
                string user = textBox1.Text;
                string pass = textBox2.Text;
                TaiKhoan tk = db.GetByTenTK(conn, user, pass);

                if (KiemTraLogin(user, pass))
                {
                    if (tk.Quyen == "nhanvien")
                    {
                        ManHinhQuanLyNhanVien manhinh = new ManHinhQuanLyNhanVien();
                        manhinh.Visible = true;
                        this.Visible = false;
                    }
                    else
                    if (tk.Quyen == ("quanly"))
                    {
                        ManHinhQuanLy manhinh = new ManHinhQuanLy();
                        manhinh.Visible = true;
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập lỗi, vui lòng đăng nhập lại !!! ", "Thông báo");
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TaiKhoanBAL db = new TaiKhoanBAL();
                string user = textBox1.Text;
                string pass = textBox2.Text;
                TaiKhoan tk = db.GetByTenTK(conn, user, pass);

                if (KiemTraLogin(user, pass))
                {
                    if (tk.Quyen == "nhanvien")
                    {
                        ManHinhQuanLyNhanVien manhinh = new ManHinhQuanLyNhanVien();
                        manhinh.Visible = true;
                        this.Visible = false;
                    }
                    else
                    if (tk.Quyen == ("quanly"))
                    {
                        ManHinhQuanLy manhinh = new ManHinhQuanLy();
                        manhinh.Visible = true;
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập lỗi, vui lòng đăng nhập lại !!! ","Thông báo");
                }
            }
        }
    }
}
