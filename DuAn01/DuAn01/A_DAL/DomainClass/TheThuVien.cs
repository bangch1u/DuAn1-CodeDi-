using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn01.DomainClass
{
    [Table("TheThuVien")]
    public partial class TheThuVien
    {
        public TheThuVien()
        {
            LichSuNaps = new HashSet<LichSuNap>();
        }

        [Key]
        [Column("idTheThuVien")]
        [StringLength(10)]
        [Unicode(false)]
        public string IdTheThuVien { get; set; } = null!;
        [Column("hoTen")]
        [StringLength(50)]
        public string? HoTen { get; set; }
        [Column("soDienThoai")]
        [StringLength(10)]
        [Unicode(false)]
        public string? SoDienThoai { get; set; }
        [Column("diemUyTin")]
        public int? DiemUyTin { get; set; }
        [Column("trangThai")]
        public int? TrangThai { get; set; }

        [InverseProperty("IdTheThuVienNavigation")]
        public virtual PhieuMuon? PhieuMuon { get; set; }
        [InverseProperty("IdTheThuVienNavigation")]
        public virtual ICollection<LichSuNap> LichSuNaps { get; set; }
    }
}
