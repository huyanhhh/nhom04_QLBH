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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanVien nhanVien = new frmNhanVien();
            nhanVien.ShowDialog();
        }

        private void btnVao_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGiaoDienMuaHang giaoDienMuaHang = new frmGiaoDienMuaHang();
            giaoDienMuaHang.ShowDialog();   
        }
    }
}
