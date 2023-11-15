using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn01.DomainClass
{
    [Table("ThietHai")]
    public partial class ThietHai
    {
        public ThietHai()
        {
            ThietHaiChiTiets = new HashSet<ThietHaiChiTiet>();
        }

        [Key]
        [Column("idThietHai")]
        [StringLength(10)]
        [Unicode(false)]
        public string IdThietHai { get; set; } = null!;
        [Column("tenThietHai")]
        [StringLength(50)]
        public string? TenThietHai { get; set; }
        [Column("diemTruUyTin")]
        public int? DiemTruUyTin { get; set; }

        [InverseProperty("IdThietHaiNavigation")]
        public virtual ICollection<ThietHaiChiTiet> ThietHaiChiTiets { get; set; }
    }
}
