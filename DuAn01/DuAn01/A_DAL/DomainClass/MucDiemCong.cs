using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn01.DomainClass
{
    [Table("MucDiemCong")]
    public partial class MucDiemCong
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("mucTien", TypeName = "money")]
        public decimal? MucTien { get; set; }
        [Column("soDiemCong")]
        public int? SoDiemCong { get; set; }
    }
}
