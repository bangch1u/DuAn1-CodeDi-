using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model
{
    [Table("TacGiaSach")]
    public class TacGiaSach
    {
        [Key]
        [Column("idTGS")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTGS { get; set; }

        public string? BarCodeSachNSX { get; set; }
        [ForeignKey("BarCodeSachNSX")]
        public Sach Sach { get; set; }

        public string? IdTacGia { get; set; }
        [ForeignKey("IdTacGia")]
        public TacGia TacGia { get; set; }

        [Column("moTa")]
        [StringLength(150)]
        public string? MoTa { get; set; }

    }
}
