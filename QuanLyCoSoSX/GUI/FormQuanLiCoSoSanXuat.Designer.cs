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
            this.LCoSoSanXuat.AutoSize = true;
            this.LCoSoSanXuat.Location = new System.Drawing.Point(16, 144);
            this.LCoSoSanXuat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCoSoSanXuat.Name = "LCoSoSanXuat";
            this.LCoSoSanXuat.Size = new System.Drawing.Size(101, 17);
            this.LCoSoSanXuat.TabIndex = 8;
            this.LCoSoSanXuat.Text = "Cở sở sản xuất";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(148, 418);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(429, 22);
            this.txtSoDienThoai.TabIndex = 3;
            // 
            // Them
            // 
            this.Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Them.Image = ((System.Drawing.Image)(resources.GetObject("Them.Image")));
            this.Them.Location = new System.Drawing.Point(21, 510);
            this.Them.Margin = new System.Windows.Forms.Padding(4);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(140, 39);
            this.Them.TabIndex = 4;
            this.Them.Text = "Thêm";
            this.Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // LChuCoSo
            // 
            this.LChuCoSo.AutoSize = true;
            this.LChuCoSo.Location = new System.Drawing.Point(15, 244);
            this.LChuCoSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LChuCoSo.Name = "LChuCoSo";
            this.LChuCoSo.Size = new System.Drawing.Size(75, 17);
            this.LChuCoSo.TabIndex = 9;
            this.LChuCoSo.Text = "Chủ cơ sở ";
            // 
            // LayThongTin
            // 
            this.LayThongTin.BackColor = System.Drawing.Color.Orange;
            this.LayThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LayThongTin.Image = ((System.Drawing.Image)(resources.GetObject("LayThongTin.Image")));
            this.LayThongTin.Location = new System.Drawing.Point(461, 510);
            this.LayThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.LayThongTin.Name = "LayThongTin";
            this.LayThongTin.Size = new System.Drawing.Size(140, 39);
            this.LayThongTin.TabIndex = 7;
            this.LayThongTin.Text = "Lấy thông tin";
            this.LayThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LayThongTin.UseVisualStyleBackColor = false;
            this.LayThongTin.Click += new System.EventHandler(this.LayThongTin_Click);
            // 
            // txtChuCoSo
            // 
            this.txtChuCoSo.Location = new System.Drawing.Point(148, 235);
            this.txtChuCoSo.Margin = new System.Windows.Forms.Padding(4);
            this.txtChuCoSo.Name = "txtChuCoSo";
            this.txtChuCoSo.Size = new System.Drawing.Size(429, 22);
            this.txtChuCoSo.TabIndex = 1;
            // 
            // Xoa
            // 
            this.Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Xoa.Image = ((System.Drawing.Image)(resources.GetObject("Xoa.Image")));
            this.Xoa.Location = new System.Drawing.Point(168, 510);
            this.Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(140, 39);
            this.Xoa.TabIndex = 5;
            this.Xoa.Text = "Xoá";
            this.Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // LDiaChi
            // 
            this.LDiaChi.AutoSize = true;
            this.LDiaChi.Location = new System.Drawing.Point(16, 335);
            this.LDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDiaChi.Name = "LDiaChi";
            this.LDiaChi.Size = new System.Drawing.Size(53, 17);
            this.LDiaChi.TabIndex = 10;
            this.LDiaChi.Text = "Địa Chỉ";
            // 
            // Sua
            // 
            this.Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sua.Image = ((System.Drawing.Image)(resources.GetObject("Sua.Image")));
            this.Sua.Location = new System.Drawing.Point(315, 510);
            this.Sua.Margin = new System.Windows.Forms.Padding(4);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(140, 39);
            this.Sua.TabIndex = 6;
            this.Sua.Text = "Sửa";
            this.Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // txtCoSoSanXuat
            // 
            this.txtCoSoSanXuat.Location = new System.Drawing.Point(148, 140);
            this.txtCoSoSanXuat.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoSoSanXuat.Name = "txtCoSoSanXuat";
            this.txtCoSoSanXuat.Size = new System.Drawing.Size(429, 22);
            this.txtCoSoSanXuat.TabIndex = 0;
            // 
            // LSoDienThoai
            // 
            this.LSoDienThoai.AutoSize = true;
            this.LSoDienThoai.Location = new System.Drawing.Point(16, 422);
            this.LSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LSoDienThoai.Name = "LSoDienThoai";
            this.LSoDienThoai.Size = new System.Drawing.Size(93, 17);
            this.LSoDienThoai.TabIndex = 11;
            this.LSoDienThoai.Text = "Số Điện thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(148, 326);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(429, 22);
            this.txtDiaChi.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(679, 559);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(0, 0);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tra cứu cơ sở sản xuất";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtMaCSSX);
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
            this.panel1.Location = new System.Drawing.Point(40, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 602);
            this.panel1.TabIndex = 33;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtMaCSSX
            // 
            this.txtMaCSSX.Enabled = false;
            this.txtMaCSSX.Location = new System.Drawing.Point(148, 48);
            this.txtMaCSSX.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCSSX.Name = "txtMaCSSX";
            this.txtMaCSSX.ReadOnly = true;
            this.txtMaCSSX.Size = new System.Drawing.Size(429, 22);
            this.txtMaCSSX.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã CSSX";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.SearchCSSXbt);
            this.panel2.Controls.Add(this.SearchCSSX);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(679, 559);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 135);
            this.panel2.TabIndex = 37;
            // 
            // SearchCSSXbt
            // 
            this.SearchCSSXbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchCSSXbt.Image = ((System.Drawing.Image)(resources.GetObject("SearchCSSXbt.Image")));
            this.SearchCSSXbt.Location = new System.Drawing.Point(672, 39);
            this.SearchCSSXbt.Margin = new System.Windows.Forms.Padding(4);
            this.SearchCSSXbt.Name = "SearchCSSXbt";
            this.SearchCSSXbt.Size = new System.Drawing.Size(147, 43);
            this.SearchCSSXbt.TabIndex = 9;
            this.SearchCSSXbt.Text = "Tìm";
            this.SearchCSSXbt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchCSSXbt.UseVisualStyleBackColor = true;
            this.SearchCSSXbt.Click += new System.EventHandler(this.SearchCSSXbt_Click);
            // 
            // SearchCSSX
            // 
            this.SearchCSSX.Location = new System.Drawing.Point(59, 50);
            this.SearchCSSX.Margin = new System.Windows.Forms.Padding(4);
            this.SearchCSSX.Name = "SearchCSSX";
            this.SearchCSSX.Size = new System.Drawing.Size(559, 22);
            this.SearchCSSX.TabIndex = 8;
            this.SearchCSSX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchCSSX_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(7, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tra cứu cơ sở sản xuất";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCSSX,
            this.TenCSSX,
            this.DCCSSX,
            this.ChuCSSX,
            this.SDTChu});
            this.DGV.Location = new System.Drawing.Point(679, 92);
            this.DGV.Margin = new System.Windows.Forms.Padding(4);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 51;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(865, 443);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1559, 783);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQuanLiCoSoSanXuat";
            this.ShowIcon = false;
            this.Text = "QUẢN LÝ CƠ SỞ SẢN XUẤT";
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