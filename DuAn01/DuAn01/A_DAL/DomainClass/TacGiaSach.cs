using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn01.DomainClass
{
    [Table("TacGiaSach")]
    public partial class TacGiaSach
    {
        [Key]
        [Column("barCodeSach")]
        [StringLength(13)]
        [Unicode(false)]
        public string BarCodeSach { get; set; } = null!;
        [Key]
        [Column("idTacGia")]
        public Guid IdTacGia { get; set; }
        [Column("moTa")]
        [StringLength(150)]
        public string? MoTa { get; set; }

        [ForeignKey("BarCodeSach")]
        [InverseProperty("TacGiaSaches")]
        public virtual Sach BarCodeSachNavigation { get; set; } = null!;
        [ForeignKey("IdTacGia")]
        [InverseProperty("TacGiaSaches")]
        public virtual TacGium IdTacGiaNavigation { get; set; } = null!;
    }
}
