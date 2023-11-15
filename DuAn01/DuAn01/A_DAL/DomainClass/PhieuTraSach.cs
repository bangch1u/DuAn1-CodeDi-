using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn01.DomainClass
{
    [Table("PhieuTraSach")]
    public partial class PhieuTraSach
    {
        public PhieuTraSach()
        {
            ThietHaiChiTiets = new HashSet<ThietHaiChiTiet>();
        }

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
        [Column("barCodeMaSach")]
        [StringLength(13)]
        [Unicode(false)]
        public string? BarCodeMaSach { get; set; }
        [Column("idPhieuMuon")]
        [StringLength(10)]
        [Unicode(false)]
        public string? IdPhieuMuon { get; set; }
        [Column("trangThai")]
        public bool? TrangThai { get; set; }

        [ForeignKey("BarCodeMaSach")]
        [InverseProperty("PhieuTraSaches")]
        public virtual SachChiTiet? BarCodeMaSachNavigation { get; set; }
        [ForeignKey("IdPhieuMuon")]
        [InverseProperty("PhieuTraSaches")]
        public virtual PhieuMuon? IdPhieuMuonNavigation { get; set; }
        [InverseProperty("IdPhieuTraNavigation")]
        public virtual ICollection<ThietHaiChiTiet> ThietHaiChiTiets { get; set; }
    }
}
