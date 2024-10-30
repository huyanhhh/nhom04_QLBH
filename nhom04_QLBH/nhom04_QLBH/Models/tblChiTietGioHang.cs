namespace nhom04_QLBH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChiTietGioHang")]
    public partial class tblChiTietGioHang
    {
        [Key]
        [StringLength(10)]
        public string MaChiTietGioHang { get; set; }

        [StringLength(10)]
        public string MaGioHang { get; set; }

        [StringLength(10)]
        public string MaHang { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }

        public virtual tblGioHang tblGioHang { get; set; }

        public virtual tblHang tblHang { get; set; }
    }
}
