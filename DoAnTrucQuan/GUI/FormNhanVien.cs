using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTrucQuan.GUI
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime iDate;
            iDate = dateTimePicker1.Value;

            this.dateTimePicker1.CustomFormat ="dd-mm-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            
            MessageBox.Show("Bạn đã lựa chọn: " + iDate.ToString("dd-mm-yyyy"));
        }
    }
}
