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
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaCSSX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchCSSXbt = new System.Windows.Forms.Button();
            this.SearchCSSX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.MaCSSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCSSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCCSSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuCSSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // LCoSoSanXuat
            // 
            this.LCoSoSanXuat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LCoSoSanXuat.AutoSize = true;
            this.LCoSoSanXuat.Location = new System.Drawing.Point(16, 147);
            this.LCoSoSanXuat.Name = "LCoSoSanXuat";
            this.LCoSoSanXuat.Size = new System.Drawing.Size(77, 13);
            this.LCoSoSanXuat.TabIndex = 8;
            this.LCoSoSanXuat.Text = "Cở sở sản xuất";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSoDienThoai.Location = new System.Drawing.Point(115, 328);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(323, 20);
            this.txtSoDienThoai.TabIndex = 3;
            // 
            // Them
            // 
            this.Them.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Them.Image = ((System.Drawing.Image)(resources.GetObject("Them.Image")));
            this.Them.Location = new System.Drawing.Point(16, 389);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(105, 32);
            this.Them.TabIndex = 4;
            this.Them.Text = "Thêm";
            this.Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // LChuCoSo
            // 
            this.LChuCoSo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LChuCoSo.AutoSize = true;
            this.LChuCoSo.Location = new System.Drawing.Point(15, 212);
            this.LChuCoSo.Name = "LChuCoSo";
            this.LChuCoSo.Size = new System.Drawing.Size(58, 13);
            this.LChuCoSo.TabIndex = 9;
            this.LChuCoSo.Text = "Chủ cơ sở ";
            // 
            // LayThongTin
            // 
            this.LayThongTin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LayThongTin.BackColor = System.Drawing.Color.Orange;
            this.LayThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LayThongTin.Image = ((System.Drawing.Image)(resources.GetObject("LayThongTin.Image")));
            this.LayThongTin.Location = new System.Drawing.Point(346, 389);
            this.LayThongTin.Name = "LayThongTin";
            this.LayThongTin.Size = new System.Drawing.Size(105, 32);
            this.LayThongTin.TabIndex = 7;
            this.LayThongTin.Text = "Lấy thông tin";
            this.LayThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LayThongTin.UseVisualStyleBackColor = false;
            this.LayThongTin.Click += new System.EventHandler(this.LayThongTin_Click);
            // 
            // txtChuCoSo
            // 
            this.txtChuCoSo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtChuCoSo.Location = new System.Drawing.Point(115, 205);
            this.txtChuCoSo.Name = "txtChuCoSo";
            this.txtChuCoSo.Size = new System.Drawing.Size(323, 20);
            this.txtChuCoSo.TabIndex = 1;
            // 
            // Xoa
            // 
            this.Xoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Xoa.Image = ((System.Drawing.Image)(resources.GetObject("Xoa.Image")));
            this.Xoa.Location = new System.Drawing.Point(126, 389);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(105, 32);
            this.Xoa.TabIndex = 5;
            this.Xoa.Text = "Xoá";
            this.Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // LDiaChi
            // 
            this.LDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LDiaChi.AutoSize = true;
            this.LDiaChi.Location = new System.Drawing.Point(16, 272);
            this.LDiaChi.Name = "LDiaChi";
            this.LDiaChi.Size = new System.Drawing.Size(41, 13);
            this.LDiaChi.TabIndex = 10;
            this.LDiaChi.Text = "Địa Chỉ";
            // 
            // Sua
            // 
            this.Sua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sua.Image = ((System.Drawing.Image)(resources.GetObject("Sua.Image")));
            this.Sua.Location = new System.Drawing.Point(236, 389);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(105, 32);
            this.Sua.TabIndex = 6;
            this.Sua.Text = "Sửa";
            this.Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // txtCoSoSanXuat
            // 
            this.txtCoSoSanXuat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCoSoSanXuat.Location = new System.Drawing.Point(115, 144);
            this.txtCoSoSanXuat.Name = "txtCoSoSanXuat";
            this.txtCoSoSanXuat.Size = new System.Drawing.Size(323, 20);
            this.txtCoSoSanXuat.TabIndex = 0;
            // 
            // LSoDienThoai
            // 
            this.LSoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LSoDienThoai.AutoSize = true;
            this.LSoDienThoai.Location = new System.Drawing.Point(16, 331);
            this.LSoDienThoai.Name = "LSoDienThoai";
            this.LSoDienThoai.Size = new System.Drawing.Size(71, 13);
            this.LSoDienThoai.TabIndex = 11;
            this.LSoDienThoai.Text = "Số Điện thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDiaChi.Location = new System.Drawing.Point(115, 265);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(323, 20);
            this.txtDiaChi.TabIndex = 2;
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
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtMaCSSX);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDiaChi);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 636);
            this.panel1.TabIndex = 33;
            // 
            // txtMaCSSX
            // 
            this.txtMaCSSX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaCSSX.Enabled = false;
            this.txtMaCSSX.Location = new System.Drawing.Point(115, 82);
            this.txtMaCSSX.Name = "txtMaCSSX";
            this.txtMaCSSX.ReadOnly = true;
            this.txtMaCSSX.Size = new System.Drawing.Size(323, 20);
            this.txtMaCSSX.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã CSSX";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.SearchCSSXbt);
            this.panel2.Controls.Add(this.SearchCSSX);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(9, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 110);
            this.panel2.TabIndex = 37;
            // 
            // SearchCSSXbt
            // 
            this.SearchCSSXbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchCSSXbt.Image = ((System.Drawing.Image)(resources.GetObject("SearchCSSXbt.Image")));
            this.SearchCSSXbt.Location = new System.Drawing.Point(337, 33);
            this.SearchCSSXbt.Name = "SearchCSSXbt";
            this.SearchCSSXbt.Size = new System.Drawing.Size(110, 35);
            this.SearchCSSXbt.TabIndex = 9;
            this.SearchCSSXbt.Text = "Tìm";
            this.SearchCSSXbt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchCSSXbt.UseVisualStyleBackColor = true;
            this.SearchCSSXbt.Click += new System.EventHandler(this.SearchCSSXbt_Click);
            // 
            // SearchCSSX
            // 
            this.SearchCSSX.Location = new System.Drawing.Point(44, 41);
            this.SearchCSSX.Name = "SearchCSSX";
            this.SearchCSSX.Size = new System.Drawing.Size(265, 20);
            this.SearchCSSX.TabIndex = 8;
            this.SearchCSSX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchCSSX_KeyDown);
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
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCSSX,
            this.TenCSSX,
            this.DCCSSX,
            this.ChuCSSX,
            this.SDTChu});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(469, 0);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 51;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(700, 636);
            this.DGV.TabIndex = 38;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // MaCSSX
            // 
            this.MaCSSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCSSX.HeaderText = "Mã cơ sở";
            this.MaCSSX.MinimumWidth = 6;
            this.MaCSSX.Name = "MaCSSX";
            this.MaCSSX.ReadOnly = true;
            // 
            // TenCSSX
            // 
            this.TenCSSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCSSX.HeaderText = "Tên cơ sở";
            this.TenCSSX.MinimumWidth = 6;
            this.TenCSSX.Name = "TenCSSX";
            this.TenCSSX.ReadOnly = true;
            // 
            // DCCSSX
            // 
            this.DCCSSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DCCSSX.HeaderText = "Địa chỉ";
            this.DCCSSX.MinimumWidth = 6;
            this.DCCSSX.Name = "DCCSSX";
            this.DCCSSX.ReadOnly = true;
            // 
            // ChuCSSX
            // 
            this.ChuCSSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChuCSSX.HeaderText = "Chủ cơ sở";
            this.ChuCSSX.MinimumWidth = 6;
            this.ChuCSSX.Name = "ChuCSSX";
            this.ChuCSSX.ReadOnly = true;
            // 
            // SDTChu
            // 
            this.SDTChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDTChu.HeaderText = "Số điện thoại";
            this.SDTChu.MinimumWidth = 6;
            this.SDTChu.Name = "SDTChu";
            this.SDTChu.ReadOnly = true;
            // 
            // FormQuanLiCoSoSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1169, 636);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormQuanLiCoSoSanXuat";
            this.Text = "Quản lý cơ sở sản xuất";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQuanLiCoSoSanXuat_FormClosed);
            this.Load += new System.EventHandler(this.FormQuanLiCoSoSanXuat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SearchCSSXbt;
        private System.Windows.Forms.TextBox SearchCSSX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCSSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCSSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCCSSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuCSSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTChu;
        private System.Windows.Forms.TextBox txtMaCSSX;
        private System.Windows.Forms.Label label1;
    }
}