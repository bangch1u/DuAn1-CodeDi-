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
    [Table("TheLoaiSach")]
    public class TheLoaiSach
    {
        [Key]
        [Column("idTheLoai")]
        [StringLength(13)]
        public string IdTheLoai { get; set; }
        [Column("tenTheLoai")]
        [StringLength(50)]
        public string? TenTheLoai { get; set; }
        [Column("viTriKeSach")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ViTriKeSach { get; set; }
    }
}
