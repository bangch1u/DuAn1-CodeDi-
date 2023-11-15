using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn01.DomainClass
{
    [Table("PhieuMuonChiTiet")]
    public partial class PhieuMuonChiTiet
    {
        [Key]
        [Column("idPhieuMuonChiTiet")]
        public int IdPhieuMuonChiTiet { get; set; }
        [Column("idPhieuMuon")]
        [StringLength(10)]
        [Unicode(false)]
        public string? IdPhieuMuon { get; set; }
        [Column("idNhanVien")]
        [StringLength(10)]
        [Unicode(false)]
        public string? IdNhanVien { get; set; }
        [Column("barCodeMaSach")]
        [StringLength(13)]
        [Unicode(false)]
        public string? BarCodeMaSach { get; set; }
        [Column("soLuongSach")]
        public int? SoLuongSach { get; set; }
        [Column("ngayMuonSach", TypeName = "date")]
        public DateTime? NgayMuonSach { get; set; }
        [Column("ngayTraSach", TypeName = "date")]
        public DateTime? NgayTraSach { get; set; }
        [Column("soLanGiaHan")]
        public int? SoLanGiaHan { get; set; }
        [Column("trangThai")]
        public int? TrangThai { get; set; }

        [ForeignKey("BarCodeMaSach")]
        [InverseProperty("PhieuMuonChiTiets")]
        public virtual SachChiTiet? BarCodeMaSachNavigation { get; set; }
        [ForeignKey("IdNhanVien")]
        [InverseProperty("PhieuMuonChiTiets")]
        public virtual NhanVien? IdNhanVienNavigation { get; set; }
        [ForeignKey("IdPhieuMuon")]
        [InverseProperty("PhieuMuonChiTiets")]
        public virtual PhieuMuon? IdPhieuMuonNavigation { get; set; }
    }
}
