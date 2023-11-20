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
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        [Column("idKhachHang")]
        [StringLength(10)]
        public string IdKhachHang { get; set; } = null!;
        [Column("hoTen")]
        [StringLength(50)]
        public string? HoTen { get; set; }
        [Column("soDienThoai")]
        [StringLength(10)]
        public string? SoDienThoai { get; set; }
        [Column("diemUyTin")]
        public int? DiemUyTin { get; set; }
        [Column("trangThai")]
        public int? TrangThai { get; set; }
        public string? IdPhieuMuon { get; set; }
        [ForeignKey("IdPhieuMuon")]
        public PhieuMuonSach PhieuMuonSach { get; set; }
    }
}
