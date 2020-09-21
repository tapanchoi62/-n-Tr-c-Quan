namespace QuanLyCoSoSX.GUI
{
    partial class FormQuanLiCoSoSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLiCoSoSanXuat));
            this.ThongTin = new System.Windows.Forms.ListView();
            this.MaCoSo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenCoSo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChuCoSo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoDienThoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LCoSoSanXuat = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.Them = new System.Windows.Forms.Button();
            this.LChuCoSo = new System.Windows.Forms.Label();
            this.LayThongTin = new System.Windows.Forms.Button();
            this.txtChuCoSo = new System.Windows.Forms.TextBox();
            this.Xoa = new System.Windows.Forms.Button();
            this.LDiaChi = new System.Windows.Forms.Label();
            this.Sua = new System.Windows.Forms.Button();
            this.txtCoSoSanXuat = new System.Windows.Forms.TextBox();
            this.LSoDienThoai = new System.Windows.Forms.Label();
            this.tDiaChi = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchCSSXbt = new System.Windows.Forms.Button();
            this.SearchCSSXtb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThongTin
            // 
            this.ThongTin.AllowColumnReorder = true;
            this.ThongTin.BackColor = System.Drawing.SystemColors.Control;
            this.ThongTin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaCoSo,
            this.TenCoSo,
            this.DiaChi,
            this.ChuCoSo,
            this.SoDienThoai});
            this.ThongTin.FullRowSelect = true;
            this.ThongTin.HideSelection = false;
            this.ThongTin.Location = new System.Drawing.Point(509, 75);
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.OwnerDraw = true;
            this.ThongTin.Size = new System.Drawing.Size(640, 360);
            this.ThongTin.TabIndex = 14;
            this.ThongTin.UseCompatibleStateImageBehavior = false;
            this.ThongTin.View = System.Windows.Forms.View.Details;
            this.ThongTin.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MaCoSo
            // 
            this.MaCoSo.Text = "Mã Cơ Sở";
            this.MaCoSo.Width = 70;
            // 
            // TenCoSo
            // 
            this.TenCoSo.Text = "Tên cơ sở";
            this.TenCoSo.Width = 140;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.Width = 150;
            // 
            // ChuCoSo
            // 
            this.ChuCoSo.Text = "Chủ cơ sở";
            this.ChuCoSo.Width = 140;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.Text = "Số Điện  Thoại";
            this.SoDienThoai.Width = 140;
            // 
            // LCoSoSanXuat
            // 
            this.LCoSoSanXuat.AutoSize = true;
            this.LCoSoSanXuat.Location = new System.Drawing.Point(13, 53);
            this.LCoSoSanXuat.Name = "LCoSoSanXuat";
            this.LCoSoSanXuat.Size = new System.Drawing.Size(77, 13);
            this.LCoSoSanXuat.TabIndex = 8;
            this.LCoSoSanXuat.Text = "Cở sở sản xuất";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(112, 290);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(323, 20);
            this.txtSoDienThoai.TabIndex = 3;
            this.txtSoDienThoai.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Them
            // 
            this.Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Them.Image = ((System.Drawing.Image)(resources.GetObject("Them.Image")));
            this.Them.Location = new System.Drawing.Point(16, 414);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(105, 32);
            this.Them.TabIndex = 4;
            this.Them.Text = "Thêm";
            this.Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Them.UseVisualStyleBackColor = true;
            // 
            // LChuCoSo
            // 
            this.LChuCoSo.AutoSize = true;
            this.LChuCoSo.Location = new System.Drawing.Point(13, 137);
            this.LChuCoSo.Name = "LChuCoSo";
            this.LChuCoSo.Size = new System.Drawing.Size(58, 13);
            this.LChuCoSo.TabIndex = 9;
            this.LChuCoSo.Text = "Chủ cơ sở ";
            this.LChuCoSo.Click += new System.EventHandler(this.label2_Click);
            // 
            // LayThongTin
            // 
            this.LayThongTin.BackColor = System.Drawing.Color.Orange;
            this.LayThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LayThongTin.Image = ((System.Drawing.Image)(resources.GetObject("LayThongTin.Image")));
            this.LayThongTin.Location = new System.Drawing.Point(346, 414);
            this.LayThongTin.Name = "LayThongTin";
            this.LayThongTin.Size = new System.Drawing.Size(105, 32);
            this.LayThongTin.TabIndex = 7;
            this.LayThongTin.Text = "Lấy thông tin";
            this.LayThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LayThongTin.UseVisualStyleBackColor = false;
            this.LayThongTin.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtChuCoSo
            // 
            this.txtChuCoSo.Location = new System.Drawing.Point(113, 130);
            this.txtChuCoSo.Name = "txtChuCoSo";
            this.txtChuCoSo.Size = new System.Drawing.Size(323, 20);
            this.txtChuCoSo.TabIndex = 1;
            // 
            // Xoa
            // 
            this.Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Xoa.Image = ((System.Drawing.Image)(resources.GetObject("Xoa.Image")));
            this.Xoa.Location = new System.Drawing.Point(126, 414);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(105, 32);
            this.Xoa.TabIndex = 5;
            this.Xoa.Text = "Xoá";
            this.Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Xoa.UseVisualStyleBackColor = true;
            // 
            // LDiaChi
            // 
            this.LDiaChi.AutoSize = true;
            this.LDiaChi.Location = new System.Drawing.Point(13, 217);
            this.LDiaChi.Name = "LDiaChi";
            this.LDiaChi.Size = new System.Drawing.Size(41, 13);
            this.LDiaChi.TabIndex = 10;
            this.LDiaChi.Text = "Địa Chỉ";
            // 
            // Sua
            // 
            this.Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sua.Image = ((System.Drawing.Image)(resources.GetObject("Sua.Image")));
            this.Sua.Location = new System.Drawing.Point(236, 414);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(105, 32);
            this.Sua.TabIndex = 6;
            this.Sua.Text = "Sửa";
            this.Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sua.UseVisualStyleBackColor = true;
            // 
            // txtCoSoSanXuat
            // 
            this.txtCoSoSanXuat.Location = new System.Drawing.Point(112, 50);
            this.txtCoSoSanXuat.Name = "txtCoSoSanXuat";
            this.txtCoSoSanXuat.Size = new System.Drawing.Size(323, 20);
            this.txtCoSoSanXuat.TabIndex = 0;
            // 
            // LSoDienThoai
            // 
            this.LSoDienThoai.AutoSize = true;
            this.LSoDienThoai.Location = new System.Drawing.Point(13, 293);
            this.LSoDienThoai.Name = "LSoDienThoai";
            this.LSoDienThoai.Size = new System.Drawing.Size(71, 13);
            this.LSoDienThoai.TabIndex = 11;
            this.LSoDienThoai.Text = "Số Điện thoại";
            this.LSoDienThoai.Click += new System.EventHandler(this.SoDienThoai_Click);
            // 
            // tDiaChi
            // 
            this.tDiaChi.Location = new System.Drawing.Point(112, 210);
            this.tDiaChi.Name = "tDiaChi";
            this.tDiaChi.Size = new System.Drawing.Size(323, 20);
            this.tDiaChi.TabIndex = 2;
            this.tDiaChi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(509, 454);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(0, 0);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tra cứu cơ sở sản xuất";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.tDiaChi);
            this.panel1.Controls.Add(this.LSoDienThoai);
            this.panel1.Controls.Add(this.txtCoSoSanXuat);
            this.panel1.Controls.Add(this.Sua);
            this.panel1.Controls.Add(this.LDiaChi);
            this.panel1.Controls.Add(this.LCoSoSanXuat);
            this.panel1.Controls.Add(this.Xoa);
            this.panel1.Controls.Add(this.txtSoDienThoai);
            this.panel1.Controls.Add(this.txtChuCoSo);
            this.panel1.Controls.Add(this.Them);
            this.panel1.Controls.Add(this.LayThongTin);
            this.panel1.Controls.Add(this.LChuCoSo);
            this.panel1.Location = new System.Drawing.Point(30, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 489);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.SearchCSSXbt);
            this.panel2.Controls.Add(this.SearchCSSXtb);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(509, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 110);
            this.panel2.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(5, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tra cứu cơ sở sản xuất";
            // 
            // SearchCSSXbt
            // 
            this.SearchCSSXbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchCSSXbt.Image = ((System.Drawing.Image)(resources.GetObject("SearchCSSXbt.Image")));
            this.SearchCSSXbt.Location = new System.Drawing.Point(504, 32);
            this.SearchCSSXbt.Name = "SearchCSSXbt";
            this.SearchCSSXbt.Size = new System.Drawing.Size(110, 35);
            this.SearchCSSXbt.TabIndex = 5;
            this.SearchCSSXbt.Text = "Tìm";
            this.SearchCSSXbt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchCSSXbt.UseVisualStyleBackColor = true;
            // 
            // SearchCSSXtb
            // 
            this.SearchCSSXtb.Location = new System.Drawing.Point(44, 41);
            this.SearchCSSXtb.Name = "SearchCSSXtb";
            this.SearchCSSXtb.Size = new System.Drawing.Size(420, 20);
            this.SearchCSSXtb.TabIndex = 4;
            // 
            // FormQuanLiCoSoSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ThongTin);
            this.Name = "FormQuanLiCoSoSanXuat";
            this.Text = "FormQuanLiCoSoSanXuat";
            this.Load += new System.EventHandler(this.FormQuanLiCoSoSanXuat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView ThongTin;
        private System.Windows.Forms.ColumnHeader MaCoSo;
        private System.Windows.Forms.ColumnHeader TenCoSo;
        private System.Windows.Forms.ColumnHeader DiaChi;
        private System.Windows.Forms.ColumnHeader ChuCoSo;
        private System.Windows.Forms.ColumnHeader SoDienThoai;
        private System.Windows.Forms.Label LCoSoSanXuat;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Label LChuCoSo;
        private System.Windows.Forms.Button LayThongTin;
        private System.Windows.Forms.TextBox txtChuCoSo;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Label LDiaChi;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.TextBox txtCoSoSanXuat;
        private System.Windows.Forms.Label LSoDienThoai;
        private System.Windows.Forms.TextBox tDiaChi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SearchCSSXbt;
        private System.Windows.Forms.TextBox SearchCSSXtb;
        private System.Windows.Forms.Label label7;
    }
}