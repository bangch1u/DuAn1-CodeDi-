using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn01.DomainClass
{
    [Table("chiTietTheLoai")]
    public partial class ChiTietTheLoai
    {
        [Key]
        [Column("idTheLoai")]
        public Guid IdTheLoai { get; set; }
        [Key]
        [Column("barCode")]
        [StringLength(13)]
        [Unicode(false)]
        public string BarCode { get; set; } = null!;
        [Column("moTa")]
        [StringLength(150)]
        public string? MoTa { get; set; }

        [ForeignKey("BarCode")]
        [InverseProperty("ChiTietTheLoais")]
        public virtual Sach BarCodeNavigation { get; set; } = null!;
        [ForeignKey("IdTheLoai")]
        [InverseProperty("ChiTietTheLoais")]
        public virtual TheLoaiSach IdTheLoaiNavigation { get; set; } = null!;
    }
}
