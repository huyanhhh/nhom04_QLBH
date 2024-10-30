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
    public partial class XacNhanOtpForm : Form
    {
        private string generatedOtp;
        private DateTime otpExpiration;

        public XacNhanOtpForm(string otp, DateTime expiration)
        {
            InitializeComponent();
            generatedOtp = otp;
            otpExpiration = expiration;
        }

        private void btnConfirmOTP_Click(object sender, EventArgs e)
        {
            string inputOTP = txtOTP.Text; // Lấy giá trị từ TextBox

            // Kiểm tra xem OTP có hợp lệ không
            if (DateTime.Now > otpExpiration)
            {
                MessageBox.Show("Mã OTP đã hết hạn. Vui lòng yêu cầu mã mới.");
                return;
            }

            if (inputOTP == generatedOtp)
            {
                MessageBox.Show("OTP xác nhận thành công!");
                // Chuyển đến form đăng nhập
                DangNhap dangNhapForm = new DangNhap();
                this.Hide(); // Ẩn form xác nhận OTP
                dangNhapForm.Show();
            }
            else
            {
                MessageBox.Show("OTP không khớp. Vui lòng thử lại.");
            }
        }

        
    }

}
