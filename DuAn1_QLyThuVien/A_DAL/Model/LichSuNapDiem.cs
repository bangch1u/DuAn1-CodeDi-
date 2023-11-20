using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("LichSuNapDiem")]
    public class LichSuNapDiem
    {
        [Key]
        [Column("idLSND")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idLSND { get; set; }
        [Column("soTienNap", TypeName = "money")]
        public decimal? SoTienNap { get; set; }
        [Column("diemCongUyTin")]
        public int? DiemCongUyTin { get; set; }
        [Column("ngayNap", TypeName = "date")]
        public DateTime? NgayNap { get; set; }
        public string? IdKhachHang { get; set; }
        [ForeignKey("IdKhachHang")]
        public KhachHang KhachHang { get; set; }
        public string? IdNhanVien { get; set; }
        [ForeignKey("IdNhanVien")]
        public NhanVien NhanVien { get; set; }  
    }
}
