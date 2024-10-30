namespace nhom04_QLBH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblHDBan")]
    public partial class tblHDBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHDBan()
        {
            tblChiTietHDBans = new HashSet<tblChiTietHDBan>();
        }

        [Key]
        [StringLength(10)]
        public string MaHDBan { get; set; }

        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBan { get; set; }

        [StringLength(10)]
        public string MaKhach { get; set; }

        public double? TongTien { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietHDBan> tblChiTietHDBans { get; set; }

        public virtual tblKhach tblKhach { get; set; }

        public virtual tblNhanVien tblNhanVien { get; set; }
    }
}
