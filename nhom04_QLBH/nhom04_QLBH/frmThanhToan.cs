using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom04_QLBH
{
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem khách hàng đã chọn RadioButton nào chưa
            if (!rdbThanhToan.Checked && !rdbNhanHang.Checked)
            {
                MessageBox.Show("Vui lòng chọn 1 trong 2 chức năng thanh toán.");
                return;
            }

            // Nếu khách hàng chọn rdbThanhToan
            if (rdbThanhToan.Checked)
            {
                // Hiển thị form thanh toán trực tiếp
                frmThanhToanTrucTiep frm = new frmThanhToanTrucTiep();
                frm.ShowDialog();
            }
            // Nếu khách hàng chọn rdbNhanHang
            else if (rdbNhanHang.Checked)
            {
                // Xuất thông báo tạo phiếu đặt hàng thành công
                MessageBox.Show("Tạo phiếu đặt hàng thành công.");
            }
        }
    }
}
