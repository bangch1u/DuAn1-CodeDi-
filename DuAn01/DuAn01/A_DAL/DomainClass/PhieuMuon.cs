using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn01.DomainClass
{
    [Table("PhieuMuon")]
    [Index("IdTheThuVien", Name = "UQ__PhieuMuo__CFF8AF0441E169C2", IsUnique = true)]
    public partial class PhieuMuon
    {
        public PhieuMuon()
        {
            PhieuMuonChiTiets = new HashSet<PhieuMuonChiTiet>();
            PhieuTraSaches = new HashSet<PhieuTraSach>();
        }

        [Key]
        [Column("idPhieuMuon")]
        [StringLength(10)]
        [Unicode(false)]
        public string IdPhieuMuon { get; set; } = null!;
        [Column("idTheThuVien")]
        [StringLength(10)]
        [Unicode(false)]
        public string? IdTheThuVien { get; set; }
        [Column("tongSachMuon")]
        public int? TongSachMuon { get; set; }
        [Column("ngayTaoPhieu", TypeName = "date")]
        public DateTime? NgayTaoPhieu { get; set; }
        [Column("trangThai")]
        public bool? TrangThai { get; set; }

        [ForeignKey("IdTheThuVien")]
        [InverseProperty("PhieuMuon")]
        public virtual TheThuVien? IdTheThuVienNavigation { get; set; }
        [InverseProperty("IdPhieuMuonNavigation")]
        public virtual ICollection<PhieuMuonChiTiet> PhieuMuonChiTiets { get; set; }
        [InverseProperty("IdPhieuMuonNavigation")]
        public virtual ICollection<PhieuTraSach> PhieuTraSaches { get; set; }
    }
}
