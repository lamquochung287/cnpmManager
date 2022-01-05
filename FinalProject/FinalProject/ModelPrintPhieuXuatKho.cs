using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FinalProject
{
    public partial class ModelPrintPhieuXuatKho : DbContext
    {
        public ModelPrintPhieuXuatKho()
            : base("name=ModelPrintPhieuXuatKho")
        {
        }

        public virtual DbSet<bangxuatkho> bangxuatkhoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<bangxuatkho>()
                .Property(e => e.idmathang)
                .IsUnicode(false);

            modelBuilder.Entity<bangxuatkho>()
                .Property(e => e.tenmathang)
                .IsUnicode(false);

            modelBuilder.Entity<bangxuatkho>()
                .Property(e => e.idphieuxuat)
                .IsUnicode(false);
        }
    }
}
