namespace DoAnTrucQuan.GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GetThongTinbt = new System.Windows.Forms.Button();
            this.Xoabt = new System.Windows.Forms.Button();
            this.Suabt = new System.Windows.Forms.Button();
            this.Thembt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.GetThongTinbt);
            this.panel1.Controls.Add(this.Xoabt);
            this.panel1.Controls.Add(this.Suabt);
            this.panel1.Controls.Add(this.Thembt);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 223);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 104);
            this.panel2.TabIndex = 1;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(185, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(324, 22);
            this.textBox2.TabIndex = 3;
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
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::DoAnTrucQuan.Properties.Resources.search_icon;
            this.button1.Location = new System.Drawing.Point(61, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 37;
            this.button1.Text = "Tìm";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(204, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(355, 22);
            this.textBox3.TabIndex = 38;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(613, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(543, 333);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phòng ban";
            this.columnHeader1.Width = 236;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên phòng ban";
            this.columnHeader2.Width = 293;
            // 
            // FormPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 355);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPhongBan";
            this.Text = "FormPhongBan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GetThongTinbt;
        private System.Windows.Forms.Button Xoabt;
        private System.Windows.Forms.Button Suabt;
        private System.Windows.Forms.Button Thembt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}