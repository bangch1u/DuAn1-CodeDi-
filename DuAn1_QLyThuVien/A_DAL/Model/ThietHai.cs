using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("ThietHai")]
    public class ThietHai
    {
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
       // public virtual ICollection<ThietHaiChiTiet> ThietHaiChiTiets { get; set; }
    }
}
