namespace nhom04_QLBH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblGioHang")]
    public partial class tblGioHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblGioHang()
        {
            tblChiTietGioHangs = new HashSet<tblChiTietGioHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaGioHang { get; set; }

        [StringLength(10)]
        public string MaKhach { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietGioHang> tblChiTietGioHangs { get; set; }

        public virtual tblKhach tblKhach { get; set; }
    }
}
