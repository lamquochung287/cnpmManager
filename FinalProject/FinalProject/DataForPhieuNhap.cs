using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FinalProject
{
    public partial class DataForPhieuNhap : DbContext
    {
        public DataForPhieuNhap()
            : base("name=DataForPhieuNhap")
        {
        }

        public virtual DbSet<bangnhapkho> bangnhapkhoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<bangnhapkho>()
                .Property(e => e.idmathang)
                .IsUnicode(false);

            modelBuilder.Entity<bangnhapkho>()
                .Property(e => e.tenmathang)
                .IsUnicode(false);

            modelBuilder.Entity<bangnhapkho>()
                .Property(e => e.idphieunhap)
                .IsUnicode(false);
        }
    }
}
