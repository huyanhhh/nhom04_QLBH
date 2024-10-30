using nhom04_QLBH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom04_QLBH
{
    public partial class frmNhanVien : Form
    {
        ModelQuanLyBanHang quanLyBanHang = new ModelQuanLyBanHang();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string maNVMoi = txtMaNhanVien.Text;


                var nhanVienTrungMa = quanLyBanHang.tblNhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNVMoi);

                if (nhanVienTrungMa != null)
                {
                    MessageBox.Show("Mã Nhân Viên này đã tồn tại. Vui lòng nhập mã khác.");
                    return;
                }


                tblNhanVien newNhanVien = new tblNhanVien
                {
                    MaNhanVien = maNVMoi,
                    TenNhanVien = txtTenNhanVien.Text,
                    GioiTinh = rdoNam.Checked ? "Nam" : "Nữ",
                    DiaChi = txtDiaChi.Text,
                    DienThoai = txtDienThoai.Text,
                    Email = txtEmail.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    TrangThai = txtTrangThai.Text
                };

                quanLyBanHang.tblNhanViens.Add(newNhanVien);
                quanLyBanHang.SaveChanges();

                loadDGV();
                loadForm();
                MessageBox.Show("Thêm nhân viên thành công.");
            }

        }

        private void loadForm()
        {
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtTrangThai.Clear();
        }

        private void loadDGV()
        {
            List<tblNhanVien> newListtblNhanVien = quanLyBanHang.tblNhanViens.ToList();//lay ds moi tu db
            FillDataDGV(newListtblNhanVien);
            
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0 && ValidateInputs())
            {
                string maNV = dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString();
                string maNVMoi = txtMaNhanVien.Text;


                var nhanVienTrungMa = quanLyBanHang.tblNhanViens
                    .FirstOrDefault(nv => nv.MaNhanVien == maNVMoi && nv.MaNhanVien != maNV);

                if (nhanVienTrungMa != null)
                {
                    MessageBox.Show("Mã Nhân Viên này đã tồn tại. Vui lòng nhập mã khác.");
                    return;
                }

                tblNhanVien nhanVien = quanLyBanHang.tblNhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNV);

                if (nhanVien != null)
                {
                    nhanVien.MaNhanVien = maNVMoi; // Cập nhật mã nhân viên
                    nhanVien.TenNhanVien = txtTenNhanVien.Text;
                    nhanVien.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                    nhanVien.DiaChi = txtDiaChi.Text;
                    nhanVien.DienThoai = txtDienThoai.Text;
                    nhanVien.Email = txtEmail.Text;
                    nhanVien.NgaySinh = dtpNgaySinh.Value;
                    nhanVien.TrangThai = txtTrangThai.Text;


                    quanLyBanHang.SaveChanges();
                    loadDGV();
                    loadForm();
                    MessageBox.Show("Sửa thông tin nhân viên thành công.");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy mã nhân viên từ txtMaNhanVien
            string maNV = txtMaNhanVien.Text;

            // Kiểm tra xem mã nhân viên có được nhập không
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm nhân viên trong cơ sở dữ liệu
            var nhanVienToDelete = quanLyBanHang.tblNhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNV);

            if (nhanVienToDelete != null)
            {
                // Xác nhận xóa
                var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {nhanVienToDelete.TenNhanVien}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Xóa nhân viên
                    quanLyBanHang.tblNhanViens.Remove(nhanVienToDelete);

                    try
                    {
                        // Lưu các thay đổi
                        quanLyBanHang.SaveChanges();

                        // Cập nhật lại DataGridView
                        FillDataDGV(quanLyBanHang.tblNhanViens.ToList());

                        // Dọn dẹp form
                        loadForm();

                        MessageBox.Show($"Xóa thông tin nhân viên {nhanVienToDelete.TenNhanVien} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show($"Nhân viên có mã số {maNV} không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.ToLower();
            List<tblNhanVien> searchResults = quanLyBanHang.tblNhanViens
                .Where(nv => nv.TenNhanVien.ToLower().Contains(keyword)
                          || nv.MaNhanVien.ToLower().Contains(keyword)
                          || nv.DiaChi.ToLower().Contains(keyword)
                          || nv.DienThoai.Contains(keyword))
                .ToList();

            FillDataDGV(searchResults);
        }



        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            List<tblNhanVien> tblNhanViens = quanLyBanHang.tblNhanViens.ToList();
            FillDataDGV(tblNhanViens);
        }

        private void FillDataDGV(List<tblNhanVien> tblNhanViens)
        {
            dgvNhanVien.Rows.Clear();
            foreach (tblNhanVien nhanVien in tblNhanViens)
            {
                int RowNew = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[RowNew].Cells[0].Value = nhanVien.MaNhanVien;
                dgvNhanVien.Rows[RowNew].Cells[1].Value = nhanVien.TenNhanVien;
                dgvNhanVien.Rows[RowNew].Cells[2].Value = nhanVien.GioiTinh;
                dgvNhanVien.Rows[RowNew].Cells[3].Value = nhanVien.DiaChi;
                dgvNhanVien.Rows[RowNew].Cells[4].Value = nhanVien.DienThoai;
                dgvNhanVien.Rows[RowNew].Cells[5].Value = nhanVien.Email;
                dgvNhanVien.Rows[RowNew].Cells[6].Value = nhanVien.NgaySinh;
                dgvNhanVien.Rows[RowNew].Cells[7].Value = nhanVien.TrangThai;
            }
        }
        private bool ValidateInputs()
        {

            if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text))
            {
                MessageBox.Show("Mã Nhân Viên không được để trống.");
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text))
            {
                MessageBox.Show("Tên Nhân Viên không được để trống.");
                return false;
            }


            if (!rdoNam.Checked && !rdoNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn Giới Tính.");
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Địa Chỉ không được để trống.");
                return false;
            }

            string phonePattern = @"^(03|05|07|08|09)\d{8}$";
            if (string.IsNullOrWhiteSpace(txtDienThoai.Text) || !Regex.IsMatch(txtDienThoai.Text, phonePattern))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại Việt Nam hợp lệ (10 số, đầu số hợp lệ là 03, 05, 07, 08, 09).");
                return false;
            }


            if (dtpNgaySinh.Value >= DateTime.Now)
            {
                MessageBox.Show("Ngày Sinh phải trước ngày hiện tại.");
                return false;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập đúng định dạng email.");
                return false;
            }

            return true;

        }


        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvNhanVien.Rows[e.RowIndex];

                txtMaNhanVien.Text = selectedRow.Cells[0].Value.ToString();
                txtTenNhanVien.Text = selectedRow.Cells[1].Value.ToString();

                string gioiTinh = selectedRow.Cells[2].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    rdoNam.Checked = true;
                }
                else if (gioiTinh == "Nữ")
                {
                    rdoNu.Checked = true;
                }

                txtDiaChi.Text = selectedRow.Cells[3].Value.ToString();
                txtDienThoai.Text = selectedRow.Cells[4].Value.ToString();

                // Lấy Email và kiểm tra xem có null hay không
                if (selectedRow.Cells[5].Value != null)
                {
                    txtEmail.Text = selectedRow.Cells[5].Value.ToString();
                }
                else
                {
                    txtEmail.Text = "";
                    MessageBox.Show("Không có dữ liệu Email. Vui lòng kiểm tra lại.");
                }

                // Đưa Ngày Sinh vào DateTimePicker (chuyển đổi từ dạng string sang DateTime)
                DateTime ngaySinh;
                if (DateTime.TryParse(selectedRow.Cells[6].Value.ToString(), out ngaySinh))
                {
                    dtpNgaySinh.Value = ngaySinh;
                }
                else
                {
                    MessageBox.Show("Không thể chuyển đổi ngày sinh. Vui lòng kiểm tra lại dữ liệu.");
                }

                // Lấy Trạng Thái và kiểm tra xem có null hay không
                if (selectedRow.Cells[7].Value != null)
                {
                    txtTrangThai.Text = selectedRow.Cells[7].Value.ToString();
                }
                else
                {
                    txtTrangThai.Text = "";
                    MessageBox.Show("Không có dữ liệu Trạng Thái. Vui lòng kiểm tra lại.");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }


    }
}