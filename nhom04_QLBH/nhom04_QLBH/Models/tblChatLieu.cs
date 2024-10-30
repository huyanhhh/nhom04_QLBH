namespace nhom04_QLBH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChatLieu")]
    public partial class tblChatLieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblChatLieu()
        {
            tblHangs = new HashSet<tblHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaChatLieu { get; set; }

        [StringLength(50)]
        public string TenChatLieu { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHang> tblHangs { get; set; }
    }
}
