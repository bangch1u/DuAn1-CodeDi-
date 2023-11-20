using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace A_DAL.Model
{
    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [Column("idTaiKhoan")]
        [StringLength(13)]
        [Unicode(false)]
        public string IdTaiKhoan { get; set; }
        [Column("userName")]
        [StringLength(50)]
        [Unicode(false)]
        public string? UserName { get; set; }
        [Column("passWord")]
        [StringLength(50)]
        [Unicode(false)]
        public string? PassWord { get; set; }
       
        [Column("role")]
        public int? Role { get; set; }
        public string? IdNhanVien { get; set; }
        [ForeignKey("IdNhanVien")]
        public  NhanVien NhanViens { get; set; }
        //public ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
