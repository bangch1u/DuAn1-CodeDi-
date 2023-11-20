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
    [Table("NhaXuatBan")]
    public class NhaXuatBan
    {
        [Key]
        [Column("idNXB")]
        [StringLength(13)]
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
    }
}
