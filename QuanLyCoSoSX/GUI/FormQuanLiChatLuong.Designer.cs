namespace QuanLyCoSoSX.GUI
{
    partial class FormQuanLiChatLuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLiChatLuong));
            this.listView1 = new System.Windows.Forms.ListView();
            this.MaNhomChiTieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNhomChiTieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YNghia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaChiTieutb = new System.Windows.Forms.TextBox();
            this.TenChiTieutb = new System.Windows.Forms.TextBox();
            this.YNghiatb = new System.Windows.Forms.TextBox();
            this.NhomChiTieucb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaNhomtb = new System.Windows.Forms.TextBox();
            this.GetThongTinbt = new System.Windows.Forms.Button();
            this.Xoabt = new System.Windows.Forms.Button();
            this.Suabt = new System.Windows.Forms.Button();
            this.Thembt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchChiTieubt = new System.Windows.Forms.Button();
            this.SearchChiTieutb = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.MaNhomChiTieulv2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenChiTieulv2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YNghialv2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NhomChiTieulv2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNhomChiTieu,
            this.TenNhomChiTieu,
            this.YNghia});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1140, 191);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MaNhomChiTieu
            // 
            this.MaNhomChiTieu.Text = "Mã nhóm chỉ tiêu";
            this.MaNhomChiTieu.Width = 200;
            // 
            // TenNhomChiTieu
            // 
            this.TenNhomChiTieu.Text = "Tên nhóm chỉ tiêu";
            this.TenNhomChiTieu.Width = 400;
            // 
            // YNghia
            // 
            this.YNghia.Text = "Ý nghĩa";
            this.YNghia.Width = 535;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã chi tiêu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên chỉ tiêu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ý nghĩa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhóm chỉ tiêu";
            // 
            // MaChiTieutb
            // 
            this.MaChiTieutb.Location = new System.Drawing.Point(82, 9);
            this.MaChiTieutb.Name = "MaChiTieutb";
            this.MaChiTieutb.Size = new System.Drawing.Size(385, 20);
            this.MaChiTieutb.TabIndex = 3;
            this.MaChiTieutb.TextChanged += new System.EventHandler(this.MaChiTieutb_TextChanged);
            // 
            // TenChiTieutb
            // 
            this.TenChiTieutb.Location = new System.Drawing.Point(82, 79);
            this.TenChiTieutb.Name = "TenChiTieutb";
            this.TenChiTieutb.Size = new System.Drawing.Size(385, 20);
            this.TenChiTieutb.TabIndex = 3;
            // 
            // YNghiatb
            // 
            this.YNghiatb.Location = new System.Drawing.Point(82, 145);
            this.YNghiatb.Name = "YNghiatb";
            this.YNghiatb.Size = new System.Drawing.Size(385, 20);
            this.YNghiatb.TabIndex = 3;
            this.YNghiatb.TextChanged += new System.EventHandler(this.YNghiatb_TextChanged);
            // 
            // NhomChiTieucb
            // 
            this.NhomChiTieucb.FormattingEnabled = true;
            this.NhomChiTieucb.Location = new System.Drawing.Point(82, 219);
            this.NhomChiTieucb.Name = "NhomChiTieucb";
            this.NhomChiTieucb.Size = new System.Drawing.Size(195, 21);
            this.NhomChiTieucb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhóm";
            this.label3.Click += new System.EventHandler(this.label4_Click);
            // 
            // MaNhomtb
            // 
            this.MaNhomtb.Enabled = false;
            this.MaNhomtb.Location = new System.Drawing.Point(354, 219);
            this.MaNhomtb.Name = "MaNhomtb";
            this.MaNhomtb.Size = new System.Drawing.Size(113, 20);
            this.MaNhomtb.TabIndex = 3;
            this.MaNhomtb.TextChanged += new System.EventHandler(this.MaChiTieutb_TextChanged);
            // 
            // GetThongTinbt
            // 
            this.GetThongTinbt.BackColor = System.Drawing.Color.Orange;
            this.GetThongTinbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetThongTinbt.Image = ((System.Drawing.Image)(resources.GetObject("GetThongTinbt.Image")));
            this.GetThongTinbt.Location = new System.Drawing.Point(357, 299);
            this.GetThongTinbt.Name = "GetThongTinbt";
            this.GetThongTinbt.Size = new System.Drawing.Size(110, 36);
            this.GetThongTinbt.TabIndex = 30;
            this.GetThongTinbt.Text = "Lấy Thông Tin";
            this.GetThongTinbt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GetThongTinbt.UseVisualStyleBackColor = false;
            // 
            // Xoabt
            // 
            this.Xoabt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Xoabt.Image = ((System.Drawing.Image)(resources.GetObject("Xoabt.Image")));
            this.Xoabt.Location = new System.Drawing.Point(242, 299);
            this.Xoabt.Name = "Xoabt";
            this.Xoabt.Size = new System.Drawing.Size(110, 35);
            this.Xoabt.TabIndex = 31;
            this.Xoabt.Text = "Xoá ";
            this.Xoabt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Xoabt.UseVisualStyleBackColor = true;
            // 
            // Suabt
            // 
            this.Suabt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Suabt.Image = ((System.Drawing.Image)(resources.GetObject("Suabt.Image")));
            this.Suabt.Location = new System.Drawing.Point(127, 299);
            this.Suabt.Name = "Suabt";
            this.Suabt.Size = new System.Drawing.Size(110, 35);
            this.Suabt.TabIndex = 32;
            this.Suabt.Text = "Sửa";
            this.Suabt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Suabt.UseVisualStyleBackColor = true;
            // 
            // Thembt
            // 
            this.Thembt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thembt.Image = ((System.Drawing.Image)(resources.GetObject("Thembt.Image")));
            this.Thembt.Location = new System.Drawing.Point(12, 299);
            this.Thembt.Name = "Thembt";
            this.Thembt.Size = new System.Drawing.Size(110, 35);
            this.Thembt.TabIndex = 33;
            this.Thembt.Text = "Thêm ";
            this.Thembt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Thembt.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(445, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "DANH SÁCH NHÓM CHỈ TIÊU";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.listView2);
            this.panel2.Controls.Add(this.GetThongTinbt);
            this.panel2.Controls.Add(this.Xoabt);
            this.panel2.Controls.Add(this.Suabt);
            this.panel2.Controls.Add(this.Thembt);
            this.panel2.Controls.Add(this.NhomChiTieucb);
            this.panel2.Controls.Add(this.YNghiatb);
            this.panel2.Controls.Add(this.TenChiTieutb);
            this.panel2.Controls.Add(this.MaNhomtb);
            this.panel2.Controls.Add(this.MaChiTieutb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(17, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 370);
            this.panel2.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.SearchChiTieubt);
            this.panel1.Controls.Add(this.SearchChiTieutb);
            this.panel1.Location = new System.Drawing.Point(482, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 84);
            this.panel1.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(4, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tra cứu chỉ tiêu";
            // 
            // SearchChiTieubt
            // 
            this.SearchChiTieubt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchChiTieubt.Image = ((System.Drawing.Image)(resources.GetObject("SearchChiTieubt.Image")));
            this.SearchChiTieubt.Location = new System.Drawing.Point(507, 32);
            this.SearchChiTieubt.Name = "SearchChiTieubt";
            this.SearchChiTieubt.Size = new System.Drawing.Size(110, 35);
            this.SearchChiTieubt.TabIndex = 2;
            this.SearchChiTieubt.Text = "Tìm";
            this.SearchChiTieubt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchChiTieubt.UseVisualStyleBackColor = true;
            // 
            // SearchChiTieutb
            // 
            this.SearchChiTieutb.Location = new System.Drawing.Point(47, 40);
            this.SearchChiTieutb.Name = "SearchChiTieutb";
            this.SearchChiTieutb.Size = new System.Drawing.Size(430, 20);
            this.SearchChiTieutb.TabIndex = 0;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Control;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNhomChiTieulv2,
            this.TenChiTieulv2,
            this.YNghialv2,
            this.NhomChiTieulv2});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(483, 9);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(660, 249);
            this.listView2.TabIndex = 37;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // MaNhomChiTieulv2
            // 
            this.MaNhomChiTieulv2.Text = "Mã nhóm chỉ tiêu";
            this.MaNhomChiTieulv2.Width = 100;
            // 
            // TenChiTieulv2
            // 
            this.TenChiTieulv2.Text = "Tên chỉ tiêu";
            this.TenChiTieulv2.Width = 230;
            // 
            // YNghialv2
            // 
            this.YNghialv2.Text = "Ý nghĩa";
            this.YNghialv2.Width = 220;
            // 
            // NhomChiTieulv2
            // 
            this.NhomChiTieulv2.Text = "Nhóm chỉ tiêu";
            this.NhomChiTieulv2.Width = 105;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Location = new System.Drawing.Point(17, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1150, 245);
            this.panel3.TabIndex = 38;
            // 
            // FormQuanLiChatLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormQuanLiChatLuong";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormQuanLiChatLuong_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MaNhomChiTieu;
        private System.Windows.Forms.ColumnHeader TenNhomChiTieu;
        private System.Windows.Forms.ColumnHeader YNghia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MaChiTieutb;
        private System.Windows.Forms.TextBox TenChiTieutb;
        private System.Windows.Forms.TextBox YNghiatb;
        private System.Windows.Forms.ComboBox NhomChiTieucb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaNhomtb;
        private System.Windows.Forms.Button GetThongTinbt;
        private System.Windows.Forms.Button Xoabt;
        private System.Windows.Forms.Button Suabt;
        private System.Windows.Forms.Button Thembt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SearchChiTieubt;
        private System.Windows.Forms.TextBox SearchChiTieutb;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader MaNhomChiTieulv2;
        private System.Windows.Forms.ColumnHeader TenChiTieulv2;
        private System.Windows.Forms.ColumnHeader YNghialv2;
        private System.Windows.Forms.ColumnHeader NhomChiTieulv2;
        private System.Windows.Forms.Panel panel3;
    }
}