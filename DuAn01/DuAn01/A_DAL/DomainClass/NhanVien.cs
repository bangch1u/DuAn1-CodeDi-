using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn01.DomainClass
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            PhieuMuonChiTiets = new HashSet<PhieuMuonChiTiet>();
        }

        [Key]
        [Column("idNhanVien")]
        [StringLength(10)]
        [Unicode(false)]
        public string IdNhanVien { get; set; } = null!;
        [Column("hoTen")]
        [StringLength(50)]
        public string? HoTen { get; set; }
        [Column("gioiTinh")]
        public bool? GioiTinh { get; set; }
        [Column("soDienThoai")]
        [StringLength(10)]
        [Unicode(false)]
        public string? SoDienThoai { get; set; }
        [Column("diaChi")]
        [StringLength(150)]
        public string? DiaChi { get; set; }
        [Column("ngaySinh", TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        [Column("email")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Email { get; set; }
        [Column("trangThai")]
        public int? TrangThai { get; set; }

        [InverseProperty("IdNhanVienNavigation")]
        public virtual TaiKhoan? TaiKhoan { get; set; }
        [InverseProperty("IdNhanVienNavigation")]
        public virtual ICollection<PhieuMuonChiTiet> PhieuMuonChiTiets { get; set; }
    }
}
