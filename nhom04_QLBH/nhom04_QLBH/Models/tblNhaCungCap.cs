namespace nhom04_QLBH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblNhaCungCap")]
    public partial class tblNhaCungCap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblNhaCungCap()
        {
            tblHangs = new HashSet<tblHang>();
            tblPhieuNhaps = new HashSet<tblPhieuNhap>();
        }

        [Key]
        [StringLength(10)]
        public string MaNhaCungCap { get; set; }

        [StringLength(50)]
        public string TenNhaCungCap { get; set; }

        [StringLength(255)]
        public string DiaChi { get; set; }

        [StringLength(20)]
        public string DienThoai { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHang> tblHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPhieuNhap> tblPhieuNhaps { get; set; }
    }
}
