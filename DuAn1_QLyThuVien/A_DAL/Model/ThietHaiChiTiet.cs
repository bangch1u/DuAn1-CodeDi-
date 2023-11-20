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
    [Table("ThietHaiChiTiet")]
    public class ThietHaiChiTiet
    {

        [Key]
        [Column("idTHCT")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTHCT { get; set; }

        [Column("moTa")]
        [StringLength(100)]
        public string? MoTa { get; set; }   
        public string? IdPhieuTra { get; set; }
        [ForeignKey("IdPhieuTra")]
        public PhieuTraSach PhieuTraSach { get; set; }
        public string? IdThietHai { get; set; }
        [ForeignKey("IdThietHai")]

        public ThietHai ThietHai { get; set; }
    }
}
