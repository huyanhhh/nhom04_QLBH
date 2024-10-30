namespace nhom04_QLBH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChiTietHDBan")]
    public partial class tblChiTietHDBan
    {
        [Key]
        [StringLength(10)]
        public string MaCTHDBan { get; set; }

        [StringLength(10)]
        public string MaHDBan { get; set; }

        [StringLength(10)]
        public string MaHang { get; set; }

        public int? SoLuong { get; set; }

        public double? DonGia { get; set; }

        public double? GiamGia { get; set; }

        public double? ThanhTien { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }

        public virtual tblHang tblHang { get; set; }

        public virtual tblHDBan tblHDBan { get; set; }
    }
}
