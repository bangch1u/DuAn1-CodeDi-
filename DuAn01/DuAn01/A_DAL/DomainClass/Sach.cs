using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn01.DomainClass
{
    [Table("Sach")]
    public partial class Sach
    {
        public Sach()
        {
            ChiTietTheLoais = new HashSet<ChiTietTheLoai>();
            SachChiTiets = new HashSet<SachChiTiet>();
            TacGiaSaches = new HashSet<TacGiaSach>();
        }

        [Key]
        [Column("barCodeSach")]
        [StringLength(13)]
        [Unicode(false)]
        public string BarCodeSach { get; set; } = null!;
        [Column("tenSach")]
        [StringLength(100)]
        public string? TenSach { get; set; }
        [Column("soLuong")]
        public int? SoLuong { get; set; }
        [Column("giaTien", TypeName = "money")]
        public decimal? GiaTien { get; set; }
        [Column("namXuatBan", TypeName = "date")]
        public DateTime? NamXuatBan { get; set; }

        [InverseProperty("BarCodeNavigation")]
        public virtual ICollection<ChiTietTheLoai> ChiTietTheLoais { get; set; }
        [InverseProperty("BarCodeSachNavigation")]
        public virtual ICollection<SachChiTiet> SachChiTiets { get; set; }
        [InverseProperty("BarCodeSachNavigation")]
        public virtual ICollection<TacGiaSach> TacGiaSaches { get; set; }
    }
}
