using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace nhom04_QLBH.Models
{
    public partial class ModelQuanLyBanHang : DbContext
    {
        public ModelQuanLyBanHang()
            : base("name=ModelQuanLyBanHang")
        {
        }

        public virtual DbSet<tblChatLieu> tblChatLieux { get; set; }
        public virtual DbSet<tblChiTietGioHang> tblChiTietGioHangs { get; set; }
        public virtual DbSet<tblChiTietHDBan> tblChiTietHDBans { get; set; }
        public virtual DbSet<tblChiTietPhieuNhap> tblChiTietPhieuNhaps { get; set; }
        public virtual DbSet<tblGioHang> tblGioHangs { get; set; }
        public virtual DbSet<tblHang> tblHangs { get; set; }
        public virtual DbSet<tblHDBan> tblHDBans { get; set; }
        public virtual DbSet<tblKhach> tblKhaches { get; set; }
        public virtual DbSet<tblKho> tblKhoes { get; set; }
        public virtual DbSet<tblKhoHang> tblKhoHangs { get; set; }
        public virtual DbSet<tblNhaCungCap> tblNhaCungCaps { get; set; }
        public virtual DbSet<tblNhanVien> tblNhanViens { get; set; }
        public virtual DbSet<tblPhieuNhap> tblPhieuNhaps { get; set; }
        public virtual DbSet<tblVaiTro> tblVaiTroes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblHang>()
                .HasMany(e => e.tblChiTietPhieuNhaps)
                .WithRequired(e => e.tblHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblHang>()
                .HasMany(e => e.tblKhoHangs)
                .WithRequired(e => e.tblHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblKho>()
                .HasMany(e => e.tblKhoHangs)
                .WithRequired(e => e.tblKho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPhieuNhap>()
                .HasMany(e => e.tblChiTietPhieuNhaps)
                .WithRequired(e => e.tblPhieuNhap)
                .WillCascadeOnDelete(false);
        }
    }
}
