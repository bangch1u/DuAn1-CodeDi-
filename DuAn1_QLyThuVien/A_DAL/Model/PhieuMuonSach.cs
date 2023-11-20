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
    [Table("PhieuMuonSach")]
    public class PhieuMuonSach
    {
        [Key]
        [Column("idPhieuMuon")]
        [StringLength(10)]
        [Unicode(false)]
        public string IdPhieuMuon { get; set; } 
        [Column("tongSachMuon")]
        public int? TongSachMuon { get; set; }
        [Column("ngayTaoPhieu", TypeName = "date")]
        public DateTime? NgayTaoPhieu { get; set; }
        [Column("trangThai")]
        public bool? TrangThai { get; set; }
        public string? IdKhachHang { get; set; }
        [ForeignKey("IdKhachHang")]
        public KhachHang KhachHang { get; set; }
    }
}
