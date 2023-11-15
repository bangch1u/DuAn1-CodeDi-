using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn01.DomainClass
{
    public partial class TacGium
    {
        public TacGium()
        {
            TacGiaSaches = new HashSet<TacGiaSach>();
        }

        [Key]
        [Column("idTacGia")]
        public Guid IdTacGia { get; set; }
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

        [InverseProperty("IdTacGiaNavigation")]
        public virtual ICollection<TacGiaSach> TacGiaSaches { get; set; }
    }
}
