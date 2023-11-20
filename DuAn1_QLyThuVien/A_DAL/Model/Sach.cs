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
    [Table("Sach")]
    public class Sach
    {
        [Key]
        [Column("barCodeSachNSX")]//đây là mã barcode có sẵn của sách do nhà sản xuất tạo
        [StringLength(13)]
        [Unicode(false)]
        public string BarCodeSachNSX { get; set; } = null!;
        [Column("tenSach")]
        [StringLength(100)]
        public string? TenSach { get; set; }
        [Column("soLuong")]
        public int? SoLuong { get; set; }
        [Column("giaTien", TypeName = "money")]
        public decimal? GiaTien { get; set; }
        [Column("namXuatBan", TypeName = "date")]
        public DateTime? NamXuatBan { get; set; }
       
    }
}
