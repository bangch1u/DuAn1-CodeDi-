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
    [Table("PhieuMuonChiTiet")]
    public class PhieuMuonChiTiet
    {
        [Key]
        [Column("idPhieuMuonChiTiet")]
        public int IdPhieuMuonChiTiet { get; set; }
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
        [Column("idPhieuMuon")]
        [StringLength(10)]
        [Unicode(false)]
        public string? IdPhieuMuon { get; set; }
        [ForeignKey("IdPhieuMuon")]
        public PhieuMuonSach PhieuMuonSach { get; set; }
        public string? IdNhanVien { get; set; }
        [ForeignKey("IdNhanVien")]
        public NhanVien NhanVien { get; set; }

        public string? BarCodeSach { get; set; }
        [ForeignKey("BarCodeSach")]
        public SachChiTiet SachChiTiet { get; set; }
        
    }
}
