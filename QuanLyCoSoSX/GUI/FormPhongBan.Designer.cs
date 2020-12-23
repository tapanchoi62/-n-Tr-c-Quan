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
            this.textBoxSearchPhongBan = new System.Windows.Forms.TextBox();
            this.SearchPhongBan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVPhongBan = new System.Windows.Forms.DataGridView();
            this.MaPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GetThongTinbt = new System.Windows.Forms.Button();
            this.Xoabt = new System.Windows.Forms.Button();
            this.Suabt = new System.Windows.Forms.Button();
            this.Thembt = new System.Windows.Forms.Button();
            this.textboxTenPhongBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxMaPhongBan = new System.Windows.Forms.TextBox();
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
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.textBoxSearchPhongBan);
            this.panel2.Controls.Add(this.SearchPhongBan);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(4, 193);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 84);
            this.panel2.TabIndex = 1;
            // 
            // textBoxSearchPhongBan
            // 
            this.textBoxSearchPhongBan.Location = new System.Drawing.Point(153, 41);
            this.textBoxSearchPhongBan.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearchPhongBan.Name = "textBoxSearchPhongBan";
            this.textBoxSearchPhongBan.Size = new System.Drawing.Size(267, 20);
            this.textBoxSearchPhongBan.TabIndex = 38;
            this.textBoxSearchPhongBan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchPhongBan_KeyDown);
            // 
            // SearchPhongBan
            // 
            this.SearchPhongBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchPhongBan.Image = global::QuanLyCoSoSX.Properties.Resources.search_icon;
            this.SearchPhongBan.Location = new System.Drawing.Point(46, 32);
            this.SearchPhongBan.Name = "SearchPhongBan";
            this.SearchPhongBan.Size = new System.Drawing.Size(88, 37);
            this.SearchPhongBan.TabIndex = 37;
            this.SearchPhongBan.Text = "Tìm";
            this.SearchPhongBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchPhongBan.UseVisualStyleBackColor = true;
            this.SearchPhongBan.Click += new System.EventHandler(this.SearchPhongBan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 12);
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
            this.DGVPhongBan.Location = new System.Drawing.Point(447, 0);
            this.DGVPhongBan.MultiSelect = false;
            this.DGVPhongBan.Name = "DGVPhongBan";
            this.DGVPhongBan.ReadOnly = true;
            this.DGVPhongBan.RowHeadersVisible = false;
            this.DGVPhongBan.RowHeadersWidth = 51;
            this.DGVPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPhongBan.ShowEditingIcon = false;
            this.DGVPhongBan.Size = new System.Drawing.Size(429, 288);
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
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.GetThongTinbt);
            this.panel3.Controls.Add(this.Xoabt);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.Suabt);
            this.panel3.Controls.Add(this.Thembt);
            this.panel3.Controls.Add(this.textboxTenPhongBan);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textboxMaPhongBan);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 288);
            this.panel3.TabIndex = 45;
            // 
            // GetThongTinbt
            // 
            this.GetThongTinbt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetThongTinbt.BackColor = System.Drawing.Color.Orange;
            this.GetThongTinbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetThongTinbt.Image = ((System.Drawing.Image)(resources.GetObject("GetThongTinbt.Image")));
            this.GetThongTinbt.Location = new System.Drawing.Point(306, 125);
            this.GetThongTinbt.Name = "GetThongTinbt";
            this.GetThongTinbt.Size = new System.Drawing.Size(114, 37);
            this.GetThongTinbt.TabIndex = 42;
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
            this.Xoabt.Location = new System.Drawing.Point(206, 125);
            this.Xoabt.Name = "Xoabt";
            this.Xoabt.Size = new System.Drawing.Size(93, 37);
            this.Xoabt.TabIndex = 43;
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
            this.Suabt.Location = new System.Drawing.Point(112, 124);
            this.Suabt.Name = "Suabt";
            this.Suabt.Size = new System.Drawing.Size(88, 37);
            this.Suabt.TabIndex = 44;
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
            this.Thembt.Location = new System.Drawing.Point(8, 125);
            this.Thembt.Name = "Thembt";
            this.Thembt.Size = new System.Drawing.Size(98, 37);
            this.Thembt.TabIndex = 45;
            this.Thembt.Text = "Thêm ";
            this.Thembt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Thembt.UseVisualStyleBackColor = true;
            this.Thembt.Click += new System.EventHandler(this.Thembt_Click);
            // 
            // textboxTenPhongBan
            // 
            this.textboxTenPhongBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxTenPhongBan.Location = new System.Drawing.Point(128, 79);
            this.textboxTenPhongBan.Margin = new System.Windows.Forms.Padding(2);
            this.textboxTenPhongBan.Name = "textboxTenPhongBan";
            this.textboxTenPhongBan.Size = new System.Drawing.Size(292, 20);
            this.textboxTenPhongBan.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tên phòng ban";
            // 
            // textboxMaPhongBan
            // 
            this.textboxMaPhongBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxMaPhongBan.Location = new System.Drawing.Point(128, 39);
            this.textboxMaPhongBan.Margin = new System.Windows.Forms.Padding(2);
            this.textboxMaPhongBan.Name = "textboxMaPhongBan";
            this.textboxMaPhongBan.Size = new System.Drawing.Size(292, 20);
            this.textboxMaPhongBan.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
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
            this.ClientSize = new System.Drawing.Size(876, 288);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DGVPhongBan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPhongBan";
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
        private System.Windows.Forms.TextBox textBoxSearchPhongBan;
        private System.Windows.Forms.Button SearchPhongBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongBan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button GetThongTinbt;
        private System.Windows.Forms.Button Xoabt;
        private System.Windows.Forms.Button Suabt;
        private System.Windows.Forms.Button Thembt;
        private System.Windows.Forms.TextBox textboxTenPhongBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxMaPhongBan;
        private System.Windows.Forms.Label label1;
    }
}