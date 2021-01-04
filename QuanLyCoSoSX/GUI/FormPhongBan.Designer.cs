namespace QuanLyCoSoSX.GUI
{
    partial class FormPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhongBan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimPhongBan = new System.Windows.Forms.TextBox();
            this.btTimPhongBan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVPhongBan = new System.Windows.Forms.DataGridView();
            this.MaPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btLayThongTin = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtTenPhongBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhongBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhongBan)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(2, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.txtTimPhongBan);
            this.panel2.Controls.Add(this.btTimPhongBan);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(11, 221);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 76);
            this.panel2.TabIndex = 1;
            // 
            // txtTimPhongBan
            // 
            this.txtTimPhongBan.Location = new System.Drawing.Point(19, 34);
            this.txtTimPhongBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimPhongBan.Name = "txtTimPhongBan";
            this.txtTimPhongBan.Size = new System.Drawing.Size(235, 20);
            this.txtTimPhongBan.TabIndex = 38;
            this.txtTimPhongBan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchPhongBan_KeyDown);
            // 
            // btTimPhongBan
            // 
            this.btTimPhongBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTimPhongBan.Image = global::QuanLyCoSoSX.Properties.Resources.search_icon;
            this.btTimPhongBan.Location = new System.Drawing.Point(275, 25);
            this.btTimPhongBan.Name = "btTimPhongBan";
            this.btTimPhongBan.Size = new System.Drawing.Size(88, 37);
            this.btTimPhongBan.TabIndex = 37;
            this.btTimPhongBan.Text = "Tìm";
            this.btTimPhongBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTimPhongBan.UseVisualStyleBackColor = true;
            this.btTimPhongBan.Click += new System.EventHandler(this.SearchPhongBan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "TRA CỨU PHÒNG BAN";
            // 
            // DGVPhongBan
            // 
            this.DGVPhongBan.AllowUserToAddRows = false;
            this.DGVPhongBan.AllowUserToDeleteRows = false;
            this.DGVPhongBan.AllowUserToResizeRows = false;
            this.DGVPhongBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhongBan,
            this.TenPhongBan});
            this.DGVPhongBan.Location = new System.Drawing.Point(421, 0);
            this.DGVPhongBan.MultiSelect = false;
            this.DGVPhongBan.Name = "DGVPhongBan";
            this.DGVPhongBan.ReadOnly = true;
            this.DGVPhongBan.RowHeadersVisible = false;
            this.DGVPhongBan.RowHeadersWidth = 51;
            this.DGVPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPhongBan.ShowEditingIcon = false;
            this.DGVPhongBan.Size = new System.Drawing.Size(613, 551);
            this.DGVPhongBan.TabIndex = 44;
            this.DGVPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVChiTieu_CellClick);
            // 
            // MaPhongBan
            // 
            this.MaPhongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhongBan.HeaderText = "Mã phòng ban";
            this.MaPhongBan.MinimumWidth = 6;
            this.MaPhongBan.Name = "MaPhongBan";
            this.MaPhongBan.ReadOnly = true;
            // 
            // TenPhongBan
            // 
            this.TenPhongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhongBan.HeaderText = "Tên phòng ban";
            this.TenPhongBan.MinimumWidth = 6;
            this.TenPhongBan.Name = "TenPhongBan";
            this.TenPhongBan.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btLayThongTin);
            this.panel3.Controls.Add(this.btXoa);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btSua);
            this.panel3.Controls.Add(this.btThem);
            this.panel3.Controls.Add(this.txtTenPhongBan);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtMaPhongBan);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 551);
            this.panel3.TabIndex = 45;
            // 
            // btLayThongTin
            // 
            this.btLayThongTin.BackColor = System.Drawing.Color.Orange;
            this.btLayThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLayThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btLayThongTin.Image")));
            this.btLayThongTin.Location = new System.Drawing.Point(286, 162);
            this.btLayThongTin.Name = "btLayThongTin";
            this.btLayThongTin.Size = new System.Drawing.Size(114, 37);
            this.btLayThongTin.TabIndex = 42;
            this.btLayThongTin.Text = "Lấy Thông Tin";
            this.btLayThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLayThongTin.UseVisualStyleBackColor = false;
            this.btLayThongTin.Click += new System.EventHandler(this.GetThongTinbt_Click);
            // 
            // btXoa
            // 
            this.btXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Location = new System.Drawing.Point(196, 162);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(69, 37);
            this.btXoa.TabIndex = 43;
            this.btXoa.Text = "Xoá ";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.Xoabt_Click);
            // 
            // btSua
            // 
            this.btSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.Location = new System.Drawing.Point(106, 162);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(69, 37);
            this.btSua.TabIndex = 44;
            this.btSua.Text = "Sửa";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.Suabt_Click);
            // 
            // btThem
            // 
            this.btThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.Location = new System.Drawing.Point(15, 162);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(85, 37);
            this.btThem.TabIndex = 45;
            this.btThem.Text = "Thêm ";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.Thembt_Click);
            // 
            // txtTenPhongBan
            // 
            this.txtTenPhongBan.Location = new System.Drawing.Point(135, 116);
            this.txtTenPhongBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenPhongBan.Name = "txtTenPhongBan";
            this.txtTenPhongBan.Size = new System.Drawing.Size(234, 20);
            this.txtTenPhongBan.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tên phòng ban";
            // 
            // txtMaPhongBan
            // 
            this.txtMaPhongBan.Location = new System.Drawing.Point(135, 76);
            this.txtMaPhongBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhongBan.Name = "txtMaPhongBan";
            this.txtMaPhongBan.Size = new System.Drawing.Size(234, 20);
            this.txtMaPhongBan.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mã phòng ban ";
            // 
            // FormPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 551);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DGVPhongBan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1050, 388);
            this.Name = "FormPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng ban";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPhongBan_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhongBan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimPhongBan;
        private System.Windows.Forms.Button btTimPhongBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongBan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btLayThongTin;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtTenPhongBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhongBan;
        private System.Windows.Forms.Label label1;
    }
}