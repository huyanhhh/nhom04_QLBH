namespace nhom04_QLBH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblKho")]
    public partial class tblKho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKho()
        {
            tblKhoHangs = new HashSet<tblKhoHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaKho { get; set; }

        [StringLength(50)]
        public string TenKho { get; set; }

        [StringLength(255)]
        public string DiaChi { get; set; }

        [StringLength(20)]
        public string SoDienThoai { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKhoHang> tblKhoHangs { get; set; }
    }
}
