namespace QuanLyCoSoSX.GUI
{
    partial class FormSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.OutMaSanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OutTenSanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OutDonViTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OutCoSoSanXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OutNhomChiTieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InNhomChiTieu = new System.Windows.Forms.ComboBox();
            this.InCSSX = new System.Windows.Forms.ComboBox();
            this.InMaCSSX = new System.Windows.Forms.TextBox();
            this.InMaNhom = new System.Windows.Forms.TextBox();
            this.InDonViTinh = new System.Windows.Forms.TextBox();
            this.InTenSanPham = new System.Windows.Forms.TextBox();
            this.InMaSanPham = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetThongTinbt = new System.Windows.Forms.Button();
            this.Xoabt = new System.Windows.Forms.Button();
            this.Suabt = new System.Windows.Forms.Button();
            this.Thembt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.TraCuuKiemNghiem = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(532, 484);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(0, 0);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tra cứu sản phẩm";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OutMaSanPham,
            this.OutTenSanPham,
            this.OutDonViTinh,
            this.OutCoSoSanXuat,
            this.OutNhomChiTieu});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(532, 71);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(640, 360);
            this.listView1.TabIndex = 30;
            this.listView1.TileSize = new System.Drawing.Size(150, 30);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // OutMaSanPham
            // 
            this.OutMaSanPham.Text = "Mã sản phẩm";
            this.OutMaSanPham.Width = 125;
            // 
            // OutTenSanPham
            // 
            this.OutTenSanPham.Text = "Tên sản phẩm";
            this.OutTenSanPham.Width = 135;
            // 
            // OutDonViTinh
            // 
            this.OutDonViTinh.Text = "Đơn vị tính";
            this.OutDonViTinh.Width = 125;
            // 
            // OutCoSoSanXuat
            // 
            this.OutCoSoSanXuat.Text = "Cơ sở sản xuất";
            this.OutCoSoSanXuat.Width = 125;
            // 
            // OutNhomChiTieu
            // 
            this.OutNhomChiTieu.Text = "Nhóm chỉ tiêu";
            this.OutNhomChiTieu.Width = 125;
            // 
            // InNhomChiTieu
            // 
            this.InNhomChiTieu.FormattingEnabled = true;
            this.InNhomChiTieu.Location = new System.Drawing.Point(120, 391);
            this.InNhomChiTieu.Name = "InNhomChiTieu";
            this.InNhomChiTieu.Size = new System.Drawing.Size(216, 21);
            this.InNhomChiTieu.TabIndex = 25;
            this.InNhomChiTieu.SelectedIndexChanged += new System.EventHandler(this.InNhomChiTieu_SelectedIndexChanged);
            // 
            // InCSSX
            // 
            this.InCSSX.FormattingEnabled = true;
            this.InCSSX.Location = new System.Drawing.Point(120, 311);
            this.InCSSX.Name = "InCSSX";
            this.InCSSX.Size = new System.Drawing.Size(216, 21);
            this.InCSSX.TabIndex = 24;
            // 
            // InMaCSSX
            // 
            this.InMaCSSX.Enabled = false;
            this.InMaCSSX.Location = new System.Drawing.Point(415, 311);
            this.InMaCSSX.Name = "InMaCSSX";
            this.InMaCSSX.Size = new System.Drawing.Size(100, 20);
            this.InMaCSSX.TabIndex = 23;
            // 
            // InMaNhom
            // 
            this.InMaNhom.Enabled = false;
            this.InMaNhom.Location = new System.Drawing.Point(415, 391);
            this.InMaNhom.Name = "InMaNhom";
            this.InMaNhom.Size = new System.Drawing.Size(100, 20);
            this.InMaNhom.TabIndex = 22;
            // 
            // InDonViTinh
            // 
            this.InDonViTinh.Location = new System.Drawing.Point(120, 231);
            this.InDonViTinh.Name = "InDonViTinh";
            this.InDonViTinh.Size = new System.Drawing.Size(395, 20);
            this.InDonViTinh.TabIndex = 21;
            // 
            // InTenSanPham
            // 
            this.InTenSanPham.Location = new System.Drawing.Point(120, 151);
            this.InTenSanPham.Name = "InTenSanPham";
            this.InTenSanPham.Size = new System.Drawing.Size(395, 20);
            this.InTenSanPham.TabIndex = 20;
            // 
            // InMaSanPham
            // 
            this.InMaSanPham.Location = new System.Drawing.Point(120, 71);
            this.InMaSanPham.Name = "InMaSanPham";
            this.InMaSanPham.Size = new System.Drawing.Size(395, 20);
            this.InMaSanPham.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mã nhóm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã CSSX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nhóm chỉ tiêu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "CSSX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã sản phẩm";
            // 
            // GetThongTinbt
            // 
            this.GetThongTinbt.BackColor = System.Drawing.Color.Orange;
            this.GetThongTinbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetThongTinbt.Image = ((System.Drawing.Image)(resources.GetObject("GetThongTinbt.Image")));
            this.GetThongTinbt.Location = new System.Drawing.Point(393, 492);
            this.GetThongTinbt.Name = "GetThongTinbt";
            this.GetThongTinbt.Size = new System.Drawing.Size(110, 36);
            this.GetThongTinbt.TabIndex = 34;
            this.GetThongTinbt.Text = "Lấy Thông Tin";
            this.GetThongTinbt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GetThongTinbt.UseVisualStyleBackColor = false;
            // 
            // Xoabt
            // 
            this.Xoabt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Xoabt.Image = ((System.Drawing.Image)(resources.GetObject("Xoabt.Image")));
            this.Xoabt.Location = new System.Drawing.Point(273, 493);
            this.Xoabt.Name = "Xoabt";
            this.Xoabt.Size = new System.Drawing.Size(110, 35);
            this.Xoabt.TabIndex = 35;
            this.Xoabt.Text = "Xoá ";
            this.Xoabt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Xoabt.UseVisualStyleBackColor = true;
            // 
            // Suabt
            // 
            this.Suabt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Suabt.Image = ((System.Drawing.Image)(resources.GetObject("Suabt.Image")));
            this.Suabt.Location = new System.Drawing.Point(153, 493);
            this.Suabt.Name = "Suabt";
            this.Suabt.Size = new System.Drawing.Size(110, 35);
            this.Suabt.TabIndex = 36;
            this.Suabt.Text = "Sửa";
            this.Suabt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Suabt.UseVisualStyleBackColor = true;
            // 
            // Thembt
            // 
            this.Thembt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thembt.Image = ((System.Drawing.Image)(resources.GetObject("Thembt.Image")));
            this.Thembt.Location = new System.Drawing.Point(33, 493);
            this.Thembt.Name = "Thembt";
            this.Thembt.Size = new System.Drawing.Size(110, 35);
            this.Thembt.TabIndex = 37;
            this.Thembt.Text = "Thêm ";
            this.Thembt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Thembt.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.TraCuuKiemNghiem);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(532, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 90);
            this.panel1.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(5, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tra cứu chỉ tiêu";
            // 
            // TraCuuKiemNghiem
            // 
            this.TraCuuKiemNghiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TraCuuKiemNghiem.Image = ((System.Drawing.Image)(resources.GetObject("TraCuuKiemNghiem.Image")));
            this.TraCuuKiemNghiem.Location = new System.Drawing.Point(490, 24);
            this.TraCuuKiemNghiem.Name = "TraCuuKiemNghiem";
            this.TraCuuKiemNghiem.Size = new System.Drawing.Size(110, 35);
            this.TraCuuKiemNghiem.TabIndex = 5;
            this.TraCuuKiemNghiem.Text = "Tìm";
            this.TraCuuKiemNghiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TraCuuKiemNghiem.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(420, 20);
            this.textBox2.TabIndex = 4;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GetThongTinbt);
            this.Controls.Add(this.Xoabt);
            this.Controls.Add(this.Suabt);
            this.Controls.Add(this.Thembt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.InNhomChiTieu);
            this.Controls.Add(this.InCSSX);
            this.Controls.Add(this.InMaCSSX);
            this.Controls.Add(this.InMaNhom);
            this.Controls.Add(this.InDonViTinh);
            this.Controls.Add(this.InTenSanPham);
            this.Controls.Add(this.InMaSanPham);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader OutMaSanPham;
        private System.Windows.Forms.ColumnHeader OutTenSanPham;
        private System.Windows.Forms.ColumnHeader OutDonViTinh;
        private System.Windows.Forms.ColumnHeader OutCoSoSanXuat;
        private System.Windows.Forms.ColumnHeader OutNhomChiTieu;
        private System.Windows.Forms.ComboBox InNhomChiTieu;
        private System.Windows.Forms.ComboBox InCSSX;
        private System.Windows.Forms.TextBox InMaCSSX;
        private System.Windows.Forms.TextBox InMaNhom;
        private System.Windows.Forms.TextBox InDonViTinh;
        private System.Windows.Forms.TextBox InTenSanPham;
        private System.Windows.Forms.TextBox InMaSanPham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetThongTinbt;
        private System.Windows.Forms.Button Xoabt;
        private System.Windows.Forms.Button Suabt;
        private System.Windows.Forms.Button Thembt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TraCuuKiemNghiem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
    }
}