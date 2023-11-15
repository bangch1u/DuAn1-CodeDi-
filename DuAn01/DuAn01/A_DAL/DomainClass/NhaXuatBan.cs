using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn01.DomainClass
{
    [Table("NhaXuatBan")]
    public partial class NhaXuatBan
    {
        public NhaXuatBan()
        {
            SachChiTiets = new HashSet<SachChiTiet>();
        }

        [Key]
        [Column("idNXB")]
        [StringLength(10)]
        [Unicode(false)]
        public string IdNxb { get; set; } = null!;
        [Column("tenNXB")]
        [StringLength(100)]
        public string? TenNxb { get; set; }
        [Column("diaChi")]
        [StringLength(150)]
        public string? DiaChi { get; set; }
        [Column("soDienThoai")]
        [StringLength(10)]
        public string? SoDienThoai { get; set; }

        [InverseProperty("IdNxbNavigation")]
        public virtual ICollection<SachChiTiet> SachChiTiets { get; set; }
    }
}
