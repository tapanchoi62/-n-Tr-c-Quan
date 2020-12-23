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
            this.cbCSSX = new System.Windows.Forms.ComboBox();
            this.txtMaCSSX = new System.Windows.Forms.TextBox();
            this.txtDonvitinh = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetThongTinbt = new System.Windows.Forms.Button();
            this.Xoabt = new System.Windows.Forms.Button();
            this.Suabt = new System.Windows.Forms.Button();
            this.Thembt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TraCuuKiemNghiem = new System.Windows.Forms.Button();
            this.txtFindByID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DGVSanPham = new System.Windows.Forms.DataGridView();
            this.dgvMasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDVTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCSSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMaCSSX = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(31, 608);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(0, 0);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tra cứu sản phẩm";
            // 
            // cbCSSX
            // 
            this.cbCSSX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCSSX.FormattingEnabled = true;
            this.cbCSSX.ItemHeight = 16;
            this.cbCSSX.Location = new System.Drawing.Point(160, 383);
            this.cbCSSX.Margin = new System.Windows.Forms.Padding(4);
            this.cbCSSX.Name = "cbCSSX";
            this.cbCSSX.Size = new System.Drawing.Size(287, 24);
            this.cbCSSX.TabIndex = 24;
            this.cbCSSX.SelectedIndexChanged += new System.EventHandler(this.cbCSSX_SelectedIndexChanged);
            // 
            // txtMaCSSX
            // 
            this.txtMaCSSX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaCSSX.Enabled = false;
            this.txtMaCSSX.Location = new System.Drawing.Point(553, 383);
            this.txtMaCSSX.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCSSX.Name = "txtMaCSSX";
            this.txtMaCSSX.Size = new System.Drawing.Size(132, 22);
            this.txtMaCSSX.TabIndex = 23;
            // 
            // txtDonvitinh
            // 
            this.txtDonvitinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDonvitinh.Location = new System.Drawing.Point(160, 284);
            this.txtDonvitinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonvitinh.Name = "txtDonvitinh";
            this.txtDonvitinh.Size = new System.Drawing.Size(525, 22);
            this.txtDonvitinh.TabIndex = 2;
            // 
            // txtTensp
            // 
            this.txtTensp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTensp.Location = new System.Drawing.Point(160, 186);
            this.txtTensp.Margin = new System.Windows.Forms.Padding(4);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(525, 22);
            this.txtTensp.TabIndex = 1;
            // 
            // txtMasp
            // 
            this.txtMasp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMasp.Enabled = false;
            this.txtMasp.Location = new System.Drawing.Point(160, 87);
            this.txtMasp.Margin = new System.Windows.Forms.Padding(4);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(525, 22);
            this.txtMasp.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 386);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã CSSX";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 386);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "CSSX";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã sản phẩm";
            // 
            // GetThongTinbt
            // 
            this.GetThongTinbt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetThongTinbt.BackColor = System.Drawing.Color.Orange;
            this.GetThongTinbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetThongTinbt.Image = ((System.Drawing.Image)(resources.GetObject("GetThongTinbt.Image")));
            this.GetThongTinbt.Location = new System.Drawing.Point(524, 464);
            this.GetThongTinbt.Margin = new System.Windows.Forms.Padding(4);
            this.GetThongTinbt.Name = "GetThongTinbt";
            this.GetThongTinbt.Size = new System.Drawing.Size(147, 44);
            this.GetThongTinbt.TabIndex = 7;
            this.GetThongTinbt.Text = "Lấy Thông Tin";
            this.GetThongTinbt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GetThongTinbt.UseVisualStyleBackColor = false;
            this.GetThongTinbt.Click += new System.EventHandler(this.GetThongTinbt_Click);
            // 
            // Xoabt
            // 
            this.Xoabt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Xoabt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Xoabt.Image = ((System.Drawing.Image)(resources.GetObject("Xoabt.Image")));
            this.Xoabt.Location = new System.Drawing.Point(364, 465);
            this.Xoabt.Margin = new System.Windows.Forms.Padding(4);
            this.Xoabt.Name = "Xoabt";
            this.Xoabt.Size = new System.Drawing.Size(147, 43);
            this.Xoabt.TabIndex = 6;
            this.Xoabt.Text = "Xoá ";
            this.Xoabt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Xoabt.UseVisualStyleBackColor = true;
            this.Xoabt.Click += new System.EventHandler(this.Xoabt_Click);
            // 
            // Suabt
            // 
            this.Suabt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Suabt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Suabt.Image = ((System.Drawing.Image)(resources.GetObject("Suabt.Image")));
            this.Suabt.Location = new System.Drawing.Point(204, 465);
            this.Suabt.Margin = new System.Windows.Forms.Padding(4);
            this.Suabt.Name = "Suabt";
            this.Suabt.Size = new System.Drawing.Size(147, 43);
            this.Suabt.TabIndex = 5;
            this.Suabt.Text = "Sửa";
            this.Suabt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Suabt.UseVisualStyleBackColor = true;
            this.Suabt.Click += new System.EventHandler(this.Suabt_Click);
            // 
            // Thembt
            // 
            this.Thembt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Thembt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thembt.Image = ((System.Drawing.Image)(resources.GetObject("Thembt.Image")));
            this.Thembt.Location = new System.Drawing.Point(44, 465);
            this.Thembt.Margin = new System.Windows.Forms.Padding(4);
            this.Thembt.Name = "Thembt";
            this.Thembt.Size = new System.Drawing.Size(147, 43);
            this.Thembt.TabIndex = 4;
            this.Thembt.Text = "Thêm ";
            this.Thembt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Thembt.UseVisualStyleBackColor = true;
            this.Thembt.Click += new System.EventHandler(this.Thembt_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.TraCuuKiemNghiem);
            this.panel1.Controls.Add(this.txtFindByID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(31, 583);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 111);
            this.panel1.TabIndex = 38;
            // 
            // TraCuuKiemNghiem
            // 
            this.TraCuuKiemNghiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TraCuuKiemNghiem.Image = ((System.Drawing.Image)(resources.GetObject("TraCuuKiemNghiem.Image")));
            this.TraCuuKiemNghiem.Location = new System.Drawing.Point(493, 30);
            this.TraCuuKiemNghiem.Margin = new System.Windows.Forms.Padding(4);
            this.TraCuuKiemNghiem.Name = "TraCuuKiemNghiem";
            this.TraCuuKiemNghiem.Size = new System.Drawing.Size(147, 43);
            this.TraCuuKiemNghiem.TabIndex = 9;
            this.TraCuuKiemNghiem.Text = "Tìm";
            this.TraCuuKiemNghiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TraCuuKiemNghiem.UseVisualStyleBackColor = true;
            this.TraCuuKiemNghiem.Click += new System.EventHandler(this.TraCuuKiemNghiem_Click);
            // 
            // txtFindByID
            // 
            this.txtFindByID.Location = new System.Drawing.Point(21, 48);
            this.txtFindByID.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindByID.Name = "txtFindByID";
            this.txtFindByID.Size = new System.Drawing.Size(425, 22);
            this.txtFindByID.TabIndex = 8;
            this.txtFindByID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFindByID_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(7, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tra cứu sản phẩm";
            // 
            // DGVSanPham
            // 
            this.DGVSanPham.AllowUserToAddRows = false;
            this.DGVSanPham.AllowUserToDeleteRows = false;
            this.DGVSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMasp,
            this.dgvTenSP,
            this.dgvDVTinh,
            this.dgvCSSX});
            this.DGVSanPham.Location = new System.Drawing.Point(709, 82);
            this.DGVSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.DGVSanPham.Name = "DGVSanPham";
            this.DGVSanPham.ReadOnly = true;
            this.DGVSanPham.RowHeadersVisible = false;
            this.DGVSanPham.RowHeadersWidth = 51;
            this.DGVSanPham.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSanPham.Size = new System.Drawing.Size(837, 612);
            this.DGVSanPham.TabIndex = 10;
            this.DGVSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSanPham_CellClick);
            // 
            // dgvMasp
            // 
            this.dgvMasp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMasp.HeaderText = "Mã sản phẩm";
            this.dgvMasp.MinimumWidth = 6;
            this.dgvMasp.Name = "dgvMasp";
            this.dgvMasp.ReadOnly = true;
            // 
            // dgvTenSP
            // 
            this.dgvTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTenSP.HeaderText = "Tên sản phẩm";
            this.dgvTenSP.MinimumWidth = 6;
            this.dgvTenSP.Name = "dgvTenSP";
            this.dgvTenSP.ReadOnly = true;
            // 
            // dgvDVTinh
            // 
            this.dgvDVTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDVTinh.HeaderText = "Đơn vị tính";
            this.dgvDVTinh.MinimumWidth = 6;
            this.dgvDVTinh.Name = "dgvDVTinh";
            this.dgvDVTinh.ReadOnly = true;
            // 
            // dgvCSSX
            // 
            this.dgvCSSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCSSX.HeaderText = "Cơ sở sản xuất";
            this.dgvCSSX.MinimumWidth = 6;
            this.dgvCSSX.Name = "dgvCSSX";
            this.dgvCSSX.ReadOnly = true;
            // 
            // cbMaCSSX
            // 
            this.cbMaCSSX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMaCSSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaCSSX.FormattingEnabled = true;
            this.cbMaCSSX.Location = new System.Drawing.Point(569, 386);
            this.cbMaCSSX.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaCSSX.Name = "cbMaCSSX";
            this.cbMaCSSX.Size = new System.Drawing.Size(100, 10);
            this.cbMaCSSX.TabIndex = 40;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1579, 783);
            this.Controls.Add(this.DGVSanPham);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GetThongTinbt);
            this.Controls.Add(this.Xoabt);
            this.Controls.Add(this.Suabt);
            this.Controls.Add(this.Thembt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbCSSX);
            this.Controls.Add(this.txtDonvitinh);
            this.Controls.Add(this.txtTensp);
            this.Controls.Add(this.txtMasp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaCSSX);
            this.Controls.Add(this.cbMaCSSX);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSanPham";
            this.ShowIcon = false;
            this.Text = "SẢN PHẨM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSanPham_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbCSSX;
        private System.Windows.Forms.TextBox txtMaCSSX;
        private System.Windows.Forms.TextBox txtDonvitinh;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.TextBox txtFindByID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DGVSanPham;
        private System.Windows.Forms.ComboBox cbMaCSSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDVTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCSSX;
    }
}