namespace nhom04_QLBH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblKhach")]
    public partial class tblKhach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKhach()
        {
            tblGioHangs = new HashSet<tblGioHang>();
            tblHDBans = new HashSet<tblHDBan>();
        }

        [Key]
        [StringLength(10)]
        public string MaKhach { get; set; }

        [StringLength(50)]
        public string TenKhach { get; set; }

        [StringLength(255)]
        public string DiaChi { get; set; }

        [StringLength(20)]
        public string DienThoai { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGioHang> tblGioHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHDBan> tblHDBans { get; set; }
    }
}
