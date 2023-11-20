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
    [Table("PhieuTraSach")]
    public class PhieuTraSach
    {
        [Key]
        [Column("idPhieuTra")]
        [StringLength(10)]
        [Unicode(false)]
        public string IdPhieuTra { get; set; } = null!;
        [Column("soLuongTra")]
        public int? SoLuongTra { get; set; }
        [Column("thoiGianTraSach", TypeName = "date")]
        public DateTime? ThoiGianTraSach { get; set; }
        [Column("tinhTrangSach")]
        [StringLength(50)]
        public string? TinhTrangSach { get; set; }
        [Column("trangThai")]
        public bool? TrangThai { get; set; }

        public string? BarCodeSach { get; set; }
        [ForeignKey("BarCodeSach")]
        public SachChiTiet SachChiTiet { get; set; }
        [Unicode(false)]
        public string? IdPhieuMuon { get; set; }
        [ForeignKey("IdPhieuMuon")]
        public PhieuMuonSach PhieuMuon { get; set; }
        //public virtual ICollection<ThietHaiChiTiet> ThietHaiChiTiets { get; set; }
    }
}
