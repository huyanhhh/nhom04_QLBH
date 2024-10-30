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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            this.Hide();
            quenMatKhau.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DangKy dangKy = new DangKy();
            this.Hide();
            dangKy.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;

            using (var context = new nhom04qlbhEntities())
            {
                var user = context.TaiKhoan.SingleOrDefault(t => t.TenTaiKhoan == tentk && t.MatKhau == matkhau);

                if (user != null)
                {
                    // Kiểm tra quyền hạn
                    if (user.MaVaiTro == "1")                                              // Admin
                    {
                        // Chuyển đến form quản trị
                       // FormAdmin adminForm = new FormAdmin();
                       // adminForm.Show();
                    }
                    else
                    {
                        // Chuyển đến form mua hàng
                       // frmGiaoDienMuaHang muaHangForm = new frmGiaoDienMuaHang();
                      //  muaHangForm.Show();
                    }
                    this.Hide(); // Ẩn form đăng nhập
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                }
            }

            if (string.IsNullOrWhiteSpace(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }

            if (string.IsNullOrWhiteSpace(matkhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }

            using (var context = new nhom04qlbhEntities()) 
            {
                var taiKhoan = context.TaiKhoan
                    .FirstOrDefault(t => t.TenTaiKhoan == tentk && t.MatKhau == matkhau);

                if (taiKhoan != null)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

      
    }
}

