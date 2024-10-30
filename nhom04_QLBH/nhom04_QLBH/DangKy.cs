using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace nhom04_QLBH
{
    public partial class DangKy : Form


    {

        private string generatedOtp;
        private DateTime otpExpiration;
        public DangKy()
        {
            InitializeComponent();
        }

        public bool CheckAcount(string ac)// check mk, tentk
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Biểu thức chính quy kiểm tra định dạng email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            string xnmatkhau = textBox_XNMatKhau.Text;
            string email = txtEmail.Text;

            // Kiểm tra định dạng tài khoản và mật khẩu
            if (!CheckAcount(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6 - 24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!");
                return;
            }
            if (!CheckAcount(matkhau))
            {
                MessageBox.Show("Vui lòng nhập tên mật khẩu dài 6 - 24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!");
                return;
            }
            if (xnmatkhau != matkhau)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!");
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email!");
                return;
            }

            using (var context = new nhom04qlbhEntities()) // Sử dụng DbContext
            {
                // Kiểm tra xem email đã được đăng ký chưa
                if (context.TaiKhoan.Any(t => t.Email == email))
                {
                    MessageBox.Show("Email này đã được đăng ký, vui lòng đăng ký email khác!");
                    return;
                }

                // Kiểm tra xem tên tài khoản đã được đăng ký chưa
                if (context.TaiKhoan.Any(t => t.TenTaiKhoan == tentk))
                {
                    MessageBox.Show("Tên tài khoản này đã được đăng ký, vui lòng đăng ký tên tài khoản khác!");
                    return;
                }

                try
                {
                    // Thêm tài khoản mới vào cơ sở dữ liệu
                    TaiKhoan newTaiKhoan = new TaiKhoan
                    {
                        TenTaiKhoan = tentk,
                        MatKhau = matkhau,
                        Email = email
                    };
                    context.TaiKhoan.Add(newTaiKhoan);
                    context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi đăng ký tài khoản: " + ex.Message);
                    return;
                }
            }

            // Xử lý gửi OTP
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email.");
                return;
            }

            // Generate OTP
            Random random = new Random();
             generatedOtp = random.Next(100000, 999999).ToString(); // Lưu OTP vào biến
             otpExpiration = DateTime.Now.AddMinutes(5); // OTP hợp lệ trong 5 phút

            // Gửi OTP qua email
            try
            {
                SendOtpByEmail(email, generatedOtp);
                MessageBox.Show("OTP đã được gửi đến email của bạn.");

                // Chuyển sang form xác nhận OTP
                XacNhanOtpForm xacNhanForm = new XacNhanOtpForm(generatedOtp, otpExpiration);
                this.Hide(); // Ẩn form đăng ký
                xacNhanForm.Show(); // Hiện form xác nhận OTP
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi OTP: " + ex.Message);
            }
        }



        private void SendOtpByEmail(string email, string otp)
        {
            var fromAddress = new MailAddress("huyanhtran51@gmail.com", "03. Huy Anh");
            var toAddress = new MailAddress(email);
            const string fromPassword = "sckr leec nhcm ursa";  // Thay mật khẩu bằng App Password
            const string subject = "Your OTP Code";
            string body = $"Your OTP code is: {otp}. It will expire in 5 minutes.";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap dangnhap = new DangNhap ();
            this.Hide();
            dangnhap.ShowDialog();
        }
    }

}

