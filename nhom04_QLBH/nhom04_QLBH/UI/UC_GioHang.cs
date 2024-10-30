using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom04_QLBH.UI
{
    public partial class UC_GioHang : UserControl
    {
        public UC_GioHang()
        {
            InitializeComponent();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDatHang datHang = new frmDatHang();
            datHang.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
