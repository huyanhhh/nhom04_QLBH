using nhom04_QLBH.UI;
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
    public partial class UC_TrangChu : UserControl
    {
        public UC_TrangChu()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDatHang datHang = new frmDatHang();
            datHang.ShowDialog();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {

        }

        
    }
}

  