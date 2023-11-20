using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Model.Context
{
    public class ThuVienContext:DbContext
    {
        public ThuVienContext()
        {

        }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }  
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<ThietHai> ThietHais { get; set; }
        public DbSet<TacGia> TacGias { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public DbSet<TheLoaiSach> TheLoaiSaches { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
        public DbSet<PhieuMuonSach> phieuMuonSaches { get; set; }
        public DbSet<Sach> saches { get; set;}
        public DbSet<SachChiTiet> sachChiTiets { get; set; }
        public DbSet<PhieuMuonChiTiet> phieuMuonChiTiets { get; set; }
        public DbSet<ChiTietTheLoai> chiTietTheLoais { get; set; }
        public DbSet<PhieuTraSach> phieuTraSaches { get; set; }
        public DbSet<ThietHaiChiTiet> thietHaiChiTiets { get; set; }
        public DbSet<TacGiaSach> tacGiaSaches { get; set; }
        public DbSet<LichSuNapDiem> lichSuNapDiems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // đổi tên server
            optionsBuilder.UseSqlServer(@"Server=BANGCHIU105\SQLEXPRESS;Initial Catalog=DbDuAn;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        // áp dụng tất cả asemmbly . 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Entity<ChiTietTheLoai>().HasKey(c => new { c.IdTheLoai, c.BarCodeSachNXS });
        }
    }
}
