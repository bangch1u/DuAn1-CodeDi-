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
    [Table("ChiTietTheLoai")]
    public class ChiTietTheLoai
    {

        [Key]
        [Column("idTLCT")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTLCT { get; set; }

        public string? IdTheLoai { get; set; }
        [ForeignKey("IdTheLoai")]
        public TheLoaiSach TheLoaiSach { get; set; }

        public string? BarCodeSachNSX { get; set; }
        [ForeignKey("BarCodeSachNSX")] 
        public Sach Sach { get; set; }
        
        [Column("moTa")]
        [StringLength(150)]
        public string? MoTa { get; set; }
     




    }
}
