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
    [Table("SachChiTiet")]
    public class SachChiTiet
    {
        [Key]
        [Column("barCodeSach")]
        [StringLength(13)]
        [Unicode(false)]
        public string BarCodeSach { get; set; } = null!; // barcode do thư viện tạo cho từng quyển sách
        [Column("tinhTrangSach")]
        [StringLength(50)]
        public string? TinhTrangSach { get; set; }
        [Column("lanTaiBan")]
        public int? LanTaiBan { get; set; }
        [Column("kichCo")]
        public int? KichCo { get; set; }
        [Column("namTaiBan", TypeName = "date")]
        public DateTime? NamTaiBan { get; set; }
        [Column("diemUyTinMin")]
        public int? DiemUyTinMin { get; set; }
        public string? IdNhaXuatBan { get; set; }
        [ForeignKey("IdNhaXuatBan")]
        public NhaXuatBan NhaXuatBan { get; set; }
        public string? BarCodeSachNSX { get; set; }
        [ForeignKey("BarCodeSachNSX")]
        public Sach Sach { get; set; }
    }
}
