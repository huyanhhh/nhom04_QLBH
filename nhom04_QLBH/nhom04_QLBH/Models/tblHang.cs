namespace nhom04_QLBH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblHang")]
    public partial class tblHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHang()
        {
            tblChiTietGioHangs = new HashSet<tblChiTietGioHang>();
            tblChiTietHDBans = new HashSet<tblChiTietHDBan>();
            tblChiTietPhieuNhaps = new HashSet<tblChiTietPhieuNhap>();
            tblKhoHangs = new HashSet<tblKhoHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaHang { get; set; }

        [StringLength(50)]
        public string TenHang { get; set; }

        [StringLength(10)]
        public string MaChatLieu { get; set; }

        [StringLength(10)]
        public string MaNhaCungCap { get; set; }

        public int? SoLuong { get; set; }

        public double? DonGiaNhap { get; set; }

        public double? DonGiaBan { get; set; }

        [StringLength(255)]
        public string Anh { get; set; }

        [StringLength(255)]
        public string GhiChu { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }

        public virtual tblChatLieu tblChatLieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietGioHang> tblChiTietGioHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietHDBan> tblChiTietHDBans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietPhieuNhap> tblChiTietPhieuNhaps { get; set; }

        public virtual tblNhaCungCap tblNhaCungCap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKhoHang> tblKhoHangs { get; set; }
    }
}
