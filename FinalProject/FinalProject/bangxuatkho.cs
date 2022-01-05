namespace FinalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bangxuatkho")]
    public partial class bangxuatkho
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
        [Column(Order = 2)]
        public DateTime ngayxuat { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string idphieuxuat { get; set; }

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

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string tendaili { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(100)]
        public string tinhtrangdonhang { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool tinhtrangthanhtoan { get; set; }
    }
}
