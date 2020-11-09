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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GetThongTinbt = new System.Windows.Forms.Button();
            this.txtMaChiTieu = new System.Windows.Forms.TextBox();
            this.Xoabt = new System.Windows.Forms.Button();
            this.txtTenChiTieu = new System.Windows.Forms.TextBox();
            this.Suabt = new System.Windows.Forms.Button();
            this.txtYNghia = new System.Windows.Forms.TextBox();
            this.Thembt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchChiTieubt = new System.Windows.Forms.Button();
            this.txtSearchChiTieu = new System.Windows.Forms.TextBox();
            this.DGVChiTieu = new System.Windows.Forms.DataGridView();
            this.MaChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YNghia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhomChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVChiTieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.GetThongTinbt);
            this.panel3.Controls.Add(this.txtMaChiTieu);
            this.panel3.Controls.Add(this.Xoabt);
            this.panel3.Controls.Add(this.txtTenChiTieu);
            this.panel3.Controls.Add(this.Suabt);
            this.panel3.Controls.Add(this.txtYNghia);
            this.panel3.Controls.Add(this.Thembt);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 404);
            this.panel3.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã chi tiêu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên chỉ tiêu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ý nghĩa";
            // 
            // GetThongTinbt
            // 
            this.GetThongTinbt.BackColor = System.Drawing.Color.Orange;
            this.GetThongTinbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetThongTinbt.Image = ((System.Drawing.Image)(resources.GetObject("GetThongTinbt.Image")));
            this.GetThongTinbt.Location = new System.Drawing.Point(303, 286);
            this.GetThongTinbt.Name = "GetThongTinbt";
            this.GetThongTinbt.Size = new System.Drawing.Size(110, 36);
            this.GetThongTinbt.TabIndex = 30;
            this.GetThongTinbt.Text = "Lấy Thông Tin";
            this.GetThongTinbt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GetThongTinbt.UseVisualStyleBackColor = false;
            this.GetThongTinbt.Click += new System.EventHandler(this.GetThongTinbt_Click);
            // 
            // txtMaChiTieu
            // 
            this.txtMaChiTieu.Location = new System.Drawing.Point(92, 41);
            this.txtMaChiTieu.Name = "txtMaChiTieu";
            this.txtMaChiTieu.Size = new System.Drawing.Size(305, 20);
            this.txtMaChiTieu.TabIndex = 3;
            // 
            // Xoabt
            // 
            this.Xoabt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Xoabt.Image = ((System.Drawing.Image)(resources.GetObject("Xoabt.Image")));
            this.Xoabt.Location = new System.Drawing.Point(207, 286);
            this.Xoabt.Name = "Xoabt";
            this.Xoabt.Size = new System.Drawing.Size(93, 35);
            this.Xoabt.TabIndex = 31;
            this.Xoabt.Text = "Xoá ";
            this.Xoabt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Xoabt.UseVisualStyleBackColor = true;
            this.Xoabt.Click += new System.EventHandler(this.Xoabt_Click);
            // 
            // txtTenChiTieu
            // 
            this.txtTenChiTieu.Location = new System.Drawing.Point(92, 124);
            this.txtTenChiTieu.Name = "txtTenChiTieu";
            this.txtTenChiTieu.Size = new System.Drawing.Size(305, 20);
            this.txtTenChiTieu.TabIndex = 3;
            // 
            // Suabt
            // 
            this.Suabt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Suabt.Image = ((System.Drawing.Image)(resources.GetObject("Suabt.Image")));
            this.Suabt.Location = new System.Drawing.Point(108, 286);
            this.Suabt.Name = "Suabt";
            this.Suabt.Size = new System.Drawing.Size(93, 35);
            this.Suabt.TabIndex = 32;
            this.Suabt.Text = "Sửa";
            this.Suabt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Suabt.UseVisualStyleBackColor = true;
            this.Suabt.Click += new System.EventHandler(this.Suabt_Click);
            // 
            // txtYNghia
            // 
            this.txtYNghia.Location = new System.Drawing.Point(92, 205);
            this.txtYNghia.Name = "txtYNghia";
            this.txtYNghia.Size = new System.Drawing.Size(305, 20);
            this.txtYNghia.TabIndex = 3;
            // 
            // Thembt
            // 
            this.Thembt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thembt.Image = ((System.Drawing.Image)(resources.GetObject("Thembt.Image")));
            this.Thembt.Location = new System.Drawing.Point(9, 286);
            this.Thembt.Name = "Thembt";
            this.Thembt.Size = new System.Drawing.Size(93, 35);
            this.Thembt.TabIndex = 33;
            this.Thembt.Text = "Thêm ";
            this.Thembt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Thembt.UseVisualStyleBackColor = true;
            this.Thembt.Click += new System.EventHandler(this.Thembt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.SearchChiTieubt);
            this.panel1.Controls.Add(this.txtSearchChiTieu);
            this.panel1.Location = new System.Drawing.Point(12, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 100);
            this.panel1.TabIndex = 41;
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
            this.SearchChiTieubt.Location = new System.Drawing.Point(292, 25);
            this.SearchChiTieubt.Name = "SearchChiTieubt";
            this.SearchChiTieubt.Size = new System.Drawing.Size(110, 35);
            this.SearchChiTieubt.TabIndex = 2;
            this.SearchChiTieubt.Text = "Tìm";
            this.SearchChiTieubt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchChiTieubt.UseVisualStyleBackColor = true;
            this.SearchChiTieubt.Click += new System.EventHandler(this.SearchChiTieubt_Click);
            // 
            // txtSearchChiTieu
            // 
            this.txtSearchChiTieu.Location = new System.Drawing.Point(14, 40);
            this.txtSearchChiTieu.Name = "txtSearchChiTieu";
            this.txtSearchChiTieu.Size = new System.Drawing.Size(258, 20);
            this.txtSearchChiTieu.TabIndex = 0;
            this.txtSearchChiTieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchChiTieu_KeyDown);
            // 
            // DGVChiTieu
            // 
            this.DGVChiTieu.AllowUserToAddRows = false;
            this.DGVChiTieu.AllowUserToDeleteRows = false;
            this.DGVChiTieu.AllowUserToResizeRows = false;
            this.DGVChiTieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVChiTieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiTieu,
            this.TenChiTieu,
            this.YNghia,
            this.NhomChiTieu});
            this.DGVChiTieu.Location = new System.Drawing.Point(448, 12);
            this.DGVChiTieu.MultiSelect = false;
            this.DGVChiTieu.Name = "DGVChiTieu";
            this.DGVChiTieu.ReadOnly = true;
            this.DGVChiTieu.RowHeadersVisible = false;
            this.DGVChiTieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVChiTieu.ShowEditingIcon = false;
            this.DGVChiTieu.Size = new System.Drawing.Size(641, 510);
            this.DGVChiTieu.TabIndex = 43;
            this.DGVChiTieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVChiTieu_CellClick);
            // 
            // MaChiTieu
            // 
            this.MaChiTieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaChiTieu.HeaderText = "Mã chỉ tiêu";
            this.MaChiTieu.Name = "MaChiTieu";
            this.MaChiTieu.ReadOnly = true;
            // 
            // TenChiTieu
            // 
            this.TenChiTieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenChiTieu.HeaderText = "Tên chỉ tiêu";
            this.TenChiTieu.Name = "TenChiTieu";
            this.TenChiTieu.ReadOnly = true;
            // 
            // YNghia
            // 
            this.YNghia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.YNghia.HeaderText = "Ý Nghĩa";
            this.YNghia.Name = "YNghia";
            this.YNghia.ReadOnly = true;
            // 
            // NhomChiTieu
            // 
            this.NhomChiTieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NhomChiTieu.HeaderText = "Nhóm chỉ tiêu";
            this.NhomChiTieu.Name = "NhomChiTieu";
            this.NhomChiTieu.ReadOnly = true;
            // 
            // FormQuanLiChatLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1101, 561);
            this.Controls.Add(this.DGVChiTieu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormQuanLiChatLuong";
            this.Text = "Quản lí chỉ tiêu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQuanLiChatLuong_FormClosed);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVChiTieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GetThongTinbt;
        private System.Windows.Forms.TextBox txtMaChiTieu;
        private System.Windows.Forms.Button Xoabt;
        private System.Windows.Forms.TextBox txtTenChiTieu;
        private System.Windows.Forms.Button Suabt;
        private System.Windows.Forms.TextBox txtYNghia;
        private System.Windows.Forms.Button Thembt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SearchChiTieubt;
        private System.Windows.Forms.TextBox txtSearchChiTieu;
        private System.Windows.Forms.DataGridView DGVChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn YNghia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhomChiTieu;
    }
}