namespace nhom04_QLBH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblVaiTro")]
    public partial class tblVaiTro
    {
        [Key]
        [StringLength(10)]
        public string MaVaiTro { get; set; }

        [StringLength(50)]
        public string TenVaiTro { get; set; }
    }
}
