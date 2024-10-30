using DevExpress.XtraBars;
using nhom04_QLBH.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nhom04_QLBH
{
    public partial class frmGiaoDienMuaHang : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmGiaoDienMuaHang()
        {
            InitializeComponent();
        }

        UC_TrangChu UC_TrangChu;
        UC_GioHang UC_GioHang;
        UC_Xoa UC_Xoa;
        private void accordionControlElement5_Click(object sender, EventArgs e)
        {

        }

        private void ACBTrangChu_Click(object sender, EventArgs e)
        {
            if(UC_TrangChu == null) 
            {
                UC_TrangChu = new UC_TrangChu();
                UC_TrangChu.Dock = DockStyle.Fill;
                Main.Controls.Add(UC_TrangChu);
                UC_TrangChu.BringToFront();
            }
            else
            {
                UC_TrangChu.BringToFront();
            }
        }

        private void ACBGioHang_Click(object sender, EventArgs e)
        {

        }

        private void ACBExit_Click(object sender, EventArgs e)
        {
            if (UC_Xoa == null)
            {
                UC_Xoa = new UC_Xoa();
                UC_Xoa.Dock = DockStyle.Fill;
                Main.Controls.Add(UC_Xoa);
                UC_Xoa.BringToFront();
            }
            else
            {
                UC_Xoa.BringToFront();
            }
        }

        private void ACBGioHang_Click_1(object sender, EventArgs e)
        {

            if (UC_GioHang == null)
            {
                UC_GioHang = new UC_GioHang();
                UC_GioHang.Dock = DockStyle.Fill;
                Main.Controls.Add(UC_GioHang);
                UC_GioHang.BringToFront();
            }
            else
            {
                UC_GioHang.BringToFront();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Main_Click(object sender, EventArgs e)
        {

        }
    }
}
