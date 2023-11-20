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
    [Table("NhanVien")]
    public partial class NhanVien
    {

        [Key]
        [Column("idNhanVien")]
        [StringLength(13)]
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
        public string? IdTaiKhoan { get; set; }
        [ForeignKey("IdTaiKhoan")]
        public  TaiKhoan TaiKhoan { get; set; }
        //public ICollection<NhanVien> NhanViens { get; set; }

    }
}
