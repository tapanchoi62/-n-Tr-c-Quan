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
            this.GetThongTinbt = new System.Windows.Forms.Button();
            this.Xoabt = new System.Windows.Forms.Button();
            this.Suabt = new System.Windows.Forms.Button();
            this.Thembt = new System.Windows.Forms.Button();
            this.textboxTenPhongBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxMaPhongBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSearchPhongBan = new System.Windows.Forms.TextBox();
            this.SearchPhongBan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVPhongBan = new System.Windows.Forms.DataGridView();
            this.MaPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.GetThongTinbt);
            this.panel1.Controls.Add(this.Xoabt);
            this.panel1.Controls.Add(this.Suabt);
            this.panel1.Controls.Add(this.Thembt);
            this.panel1.Controls.Add(this.textboxTenPhongBan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textboxMaPhongBan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 223);
            this.panel1.TabIndex = 0;
            // 
            // GetThongTinbt
            // 
            this.GetThongTinbt.BackColor = System.Drawing.Color.Orange;
            this.GetThongTinbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetThongTinbt.Image = ((System.Drawing.Image)(resources.GetObject("GetThongTinbt.Image")));
            this.GetThongTinbt.Location = new System.Drawing.Point(421, 158);
            this.GetThongTinbt.Margin = new System.Windows.Forms.Padding(4);
            this.GetThongTinbt.Name = "GetThongTinbt";
            this.GetThongTinbt.Size = new System.Drawing.Size(152, 46);
            this.GetThongTinbt.TabIndex = 34;
            this.GetThongTinbt.Text = "Lấy Thông Tin";
            this.GetThongTinbt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GetThongTinbt.UseVisualStyleBackColor = false;
            this.GetThongTinbt.Click += new System.EventHandler(this.GetThongTinbt_Click);
            // 
            // Xoabt
            // 
            this.Xoabt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Xoabt.Image = ((System.Drawing.Image)(resources.GetObject("Xoabt.Image")));
            this.Xoabt.Location = new System.Drawing.Point(289, 160);
            this.Xoabt.Margin = new System.Windows.Forms.Padding(4);
            this.Xoabt.Name = "Xoabt";
            this.Xoabt.Size = new System.Drawing.Size(124, 45);
            this.Xoabt.TabIndex = 35;
            this.Xoabt.Text = "Xoá ";
            this.Xoabt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Xoabt.UseVisualStyleBackColor = true;
            this.Xoabt.Click += new System.EventHandler(this.Xoabt_Click);
            // 
            // Suabt
            // 
            this.Suabt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Suabt.Image = ((System.Drawing.Image)(resources.GetObject("Suabt.Image")));
            this.Suabt.Location = new System.Drawing.Point(164, 159);
            this.Suabt.Margin = new System.Windows.Forms.Padding(4);
            this.Suabt.Name = "Suabt";
            this.Suabt.Size = new System.Drawing.Size(117, 45);
            this.Suabt.TabIndex = 36;
            this.Suabt.Text = "Sửa";
            this.Suabt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Suabt.UseVisualStyleBackColor = true;
            this.Suabt.Click += new System.EventHandler(this.Suabt_Click);
            // 
            // Thembt
            // 
            this.Thembt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thembt.Image = ((System.Drawing.Image)(resources.GetObject("Thembt.Image")));
            this.Thembt.Location = new System.Drawing.Point(25, 160);
            this.Thembt.Margin = new System.Windows.Forms.Padding(4);
            this.Thembt.Name = "Thembt";
            this.Thembt.Size = new System.Drawing.Size(131, 45);
            this.Thembt.TabIndex = 37;
            this.Thembt.Text = "Thêm ";
            this.Thembt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Thembt.UseVisualStyleBackColor = true;
            this.Thembt.Click += new System.EventHandler(this.Thembt_Click);
            // 
            // textboxTenPhongBan
            // 
            this.textboxTenPhongBan.Location = new System.Drawing.Point(185, 104);
            this.textboxTenPhongBan.Name = "textboxTenPhongBan";
            this.textboxTenPhongBan.Size = new System.Drawing.Size(324, 22);
            this.textboxTenPhongBan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên phòng ban";
            // 
            // textboxMaPhongBan
            // 
            this.textboxMaPhongBan.Location = new System.Drawing.Point(185, 54);
            this.textboxMaPhongBan.Name = "textboxMaPhongBan";
            this.textboxMaPhongBan.Size = new System.Drawing.Size(324, 22);
            this.textboxMaPhongBan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng ban ";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.textBoxSearchPhongBan);
            this.panel2.Controls.Add(this.SearchPhongBan);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 104);
            this.panel2.TabIndex = 1;
            // 
            // textBoxSearchPhongBan
            // 
            this.textBoxSearchPhongBan.Location = new System.Drawing.Point(204, 50);
            this.textBoxSearchPhongBan.Name = "textBoxSearchPhongBan";
            this.textBoxSearchPhongBan.Size = new System.Drawing.Size(355, 22);
            this.textBoxSearchPhongBan.TabIndex = 38;
            this.textBoxSearchPhongBan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchPhongBan_KeyDown);
            // 
            // SearchPhongBan
            // 
            this.SearchPhongBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchPhongBan.Image = global::QuanLyCoSoSX.Properties.Resources.search_icon;
            this.SearchPhongBan.Location = new System.Drawing.Point(61, 39);
            this.SearchPhongBan.Margin = new System.Windows.Forms.Padding(4);
            this.SearchPhongBan.Name = "SearchPhongBan";
            this.SearchPhongBan.Size = new System.Drawing.Size(117, 45);
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
            this.label3.Location = new System.Drawing.Point(22, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "TRA CỨU PHÒNG BAN";
            // 
            // DGVPhongBan
            // 
            this.DGVPhongBan.AllowUserToAddRows = false;
            this.DGVPhongBan.AllowUserToDeleteRows = false;
            this.DGVPhongBan.AllowUserToResizeRows = false;
            this.DGVPhongBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DGVPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhongBan,
            this.TenPhongBan});
            this.DGVPhongBan.Location = new System.Drawing.Point(614, 13);
            this.DGVPhongBan.Margin = new System.Windows.Forms.Padding(4);
            this.DGVPhongBan.MultiSelect = false;
            this.DGVPhongBan.Name = "DGVPhongBan";
            this.DGVPhongBan.ReadOnly = true;
            this.DGVPhongBan.RowHeadersVisible = false;
            this.DGVPhongBan.RowHeadersWidth = 51;
            this.DGVPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPhongBan.ShowEditingIcon = false;
            this.DGVPhongBan.Size = new System.Drawing.Size(541, 329);
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
            // FormPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1168, 355);
            this.Controls.Add(this.DGVPhongBan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPhongBan";
            this.ShowIcon = false;
            this.Text = "PHÒNG BAN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPhongBan_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhongBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textboxTenPhongBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxMaPhongBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GetThongTinbt;
        private System.Windows.Forms.Button Xoabt;
        private System.Windows.Forms.Button Suabt;
        private System.Windows.Forms.Button Thembt;
        private System.Windows.Forms.TextBox textBoxSearchPhongBan;
        private System.Windows.Forms.Button SearchPhongBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongBan;
    }
}