using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn01.DomainClass
{
    [Table("ThietHaiChiTiet")]
    public partial class ThietHaiChiTiet
    {
        [Key]
        [Column("idThietHai")]
        [StringLength(10)]
        [Unicode(false)]
        public string IdThietHai { get; set; } = null!;
        [Key]
        [Column("idPhieuTra")]
        [StringLength(10)]
        [Unicode(false)]
        public string IdPhieuTra { get; set; } = null!;
        [Column("moTa")]
        [StringLength(100)]
        public string? MoTa { get; set; }

        [ForeignKey("IdPhieuTra")]
        [InverseProperty("ThietHaiChiTiets")]
        public virtual PhieuTraSach IdPhieuTraNavigation { get; set; } = null!;
        [ForeignKey("IdThietHai")]
        [InverseProperty("ThietHaiChiTiets")]
        public virtual ThietHai IdThietHaiNavigation { get; set; } = null!;
    }
}
