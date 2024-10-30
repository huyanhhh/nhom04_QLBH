namespace nhom04_QLBH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChiTietPhieuNhap")]
    public partial class tblChiTietPhieuNhap
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaPhieuNhap { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaHang { get; set; }

        public int? SoLuong { get; set; }

        public double? DonGia { get; set; }

        public double? ThanhTien { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }

        public virtual tblHang tblHang { get; set; }

        public virtual tblPhieuNhap tblPhieuNhap { get; set; }
    }
}
