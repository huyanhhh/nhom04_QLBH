using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Security.Principal;

namespace nhom04_QLBH
{
    public partial class QuenMatKhau : Form
    {


        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            this.Hide();
            dangnhap.ShowDialog();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string usernameOrEmail = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(usernameOrEmail))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập hoặc email.");
                return;
            }

            using (var dbContext = new nhom04qlbhEntities())
            {
                var account = dbContext.TaiKhoan
                    .FirstOrDefault(tk => tk.TenTaiKhoan == usernameOrEmail || tk.Email == usernameOrEmail);

                if (account != null)
                {
                    string password = account.MatKhau;
                    txtShowpass.Text = $"{password}";
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc email không tồn tại.");
                }
            }
        }

    }
}