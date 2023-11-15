using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn01.DomainClass
{
    [Table("LichSuNap")]
    public partial class LichSuNap
    {
        [Key]
        [Column("idLichSu")]
        public int IdLichSu { get; set; }
        [Column("soTienNap", TypeName = "money")]
        public decimal? SoTienNap { get; set; }
        [Column("diemCongUyTin")]
        public int? DiemCongUyTin { get; set; }
        [Column("ngayNap", TypeName = "date")]
        public DateTime? NgayNap { get; set; }
        [Column("idTheThuVien")]
        [StringLength(10)]
        [Unicode(false)]
        public string? IdTheThuVien { get; set; }

        [ForeignKey("IdTheThuVien")]
        [InverseProperty("LichSuNaps")]
        public virtual TheThuVien? IdTheThuVienNavigation { get; set; }
    }
}
