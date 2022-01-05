namespace FinalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bangnhapkho")]
    public partial class bangnhapkho
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string idmathang { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string tenmathang { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime ngaynhap { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string idphieunhap { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int soluong { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int thanhtien { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tongthanhtien { get; set; }
    }
}
