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
    [Table("TacGia")]
    public class TacGia
    {
        [Key]
        [Column("idTacGia")]
        public string IdTacGia { get; set; }
        [Column("hoTen")]
        [StringLength(50)]
        public string? HoTen { get; set; }
        [Column("ngaySinh", TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        [Column("gioiTinh")]
        public bool? GioiTinh { get; set; }
        [Column("diaChi")]
        [StringLength(100)]
        public string? DiaChi { get; set; }
    }
}
