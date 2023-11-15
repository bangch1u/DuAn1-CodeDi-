using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DuAn01.DomainClass;

namespace DuAn01.Context
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietTheLoai> ChiTietTheLoais { get; set; } = null!;
        public virtual DbSet<LichSuNap> LichSuNaps { get; set; } = null!;
        public virtual DbSet<MucDiemCong> MucDiemCongs { get; set; } = null!;
        public virtual DbSet<NhaXuatBan> NhaXuatBans { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<PhieuMuon> PhieuMuons { get; set; } = null!;
        public virtual DbSet<PhieuMuonChiTiet> PhieuMuonChiTiets { get; set; } = null!;
        public virtual DbSet<PhieuTraSach> PhieuTraSaches { get; set; } = null!;
        public virtual DbSet<Sach> Saches { get; set; } = null!;
        public virtual DbSet<SachChiTiet> SachChiTiets { get; set; } = null!;
        public virtual DbSet<TacGiaSach> TacGiaSaches { get; set; } = null!;
        public virtual DbSet<TacGium> TacGia { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;
        public virtual DbSet<TheLoaiSach> TheLoaiSaches { get; set; } = null!;
        public virtual DbSet<TheThuVien> TheThuViens { get; set; } = null!;
        public virtual DbSet<ThietHai> ThietHais { get; set; } = null!;
        public virtual DbSet<ThietHaiChiTiet> ThietHaiChiTiets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=BANGCHIU105\\SQLEXPRESS01;Initial Catalog=DuAn1_TVBQ;Integrated Security=True ;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietTheLoai>(entity =>
            {
                entity.HasKey(e => new { e.IdTheLoai, e.BarCode })
                    .HasName("PK__chiTietT__AA87D46E8756A5E6");

                entity.HasOne(d => d.BarCodeNavigation)
                    .WithMany(p => p.ChiTietTheLoais)
                    .HasForeignKey(d => d.BarCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__chiTietTh__barCo__2F10007B");

                entity.HasOne(d => d.IdTheLoaiNavigation)
                    .WithMany(p => p.ChiTietTheLoais)
                    .HasForeignKey(d => d.IdTheLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__chiTietTh__idThe__2E1BDC42");
            });

            modelBuilder.Entity<LichSuNap>(entity =>
            {
                entity.HasKey(e => e.IdLichSu)
                    .HasName("PK__LichSuNa__C6FF381632C12044");

                entity.HasOne(d => d.IdTheThuVienNavigation)
                    .WithMany(p => p.LichSuNaps)
                    .HasForeignKey(d => d.IdTheThuVien)
                    .HasConstraintName("FK__LichSuNap__idThe__398D8EEE");
            });

            modelBuilder.Entity<NhaXuatBan>(entity =>
            {
                entity.HasKey(e => e.IdNxb)
                    .HasName("PK__NhaXuatB__3FF01B985F3EBDCB");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.IdNhanVien)
                    .HasName("PK__NhanVien__214E82582FE88EE9");
            });

            modelBuilder.Entity<PhieuMuon>(entity =>
            {
                entity.HasKey(e => e.IdPhieuMuon)
                    .HasName("PK__PhieuMuo__63AC6C2C69F1ED2B");

                entity.HasOne(d => d.IdTheThuVienNavigation)
                    .WithOne(p => p.PhieuMuon)
                    .HasForeignKey<PhieuMuon>(d => d.IdTheThuVien)
                    .HasConstraintName("FK__PhieuMuon__idThe__3F466844");
            });

            modelBuilder.Entity<PhieuMuonChiTiet>(entity =>
            {
                entity.HasKey(e => e.IdPhieuMuonChiTiet)
                    .HasName("PK__PhieuMuo__98AFF4A2375BD9A2");

                entity.HasOne(d => d.BarCodeMaSachNavigation)
                    .WithMany(p => p.PhieuMuonChiTiets)
                    .HasForeignKey(d => d.BarCodeMaSach)
                    .HasConstraintName("FK__PhieuMuon__barCo__49C3F6B7");

                entity.HasOne(d => d.IdNhanVienNavigation)
                    .WithMany(p => p.PhieuMuonChiTiets)
                    .HasForeignKey(d => d.IdNhanVien)
                    .HasConstraintName("FK__PhieuMuon__idNha__48CFD27E");

                entity.HasOne(d => d.IdPhieuMuonNavigation)
                    .WithMany(p => p.PhieuMuonChiTiets)
                    .HasForeignKey(d => d.IdPhieuMuon)
                    .HasConstraintName("FK__PhieuMuon__idPhi__47DBAE45");
            });

            modelBuilder.Entity<PhieuTraSach>(entity =>
            {
                entity.HasKey(e => e.IdPhieuTra)
                    .HasName("PK__PhieuTra__30BE3188018B2477");

                entity.HasOne(d => d.BarCodeMaSachNavigation)
                    .WithMany(p => p.PhieuTraSaches)
                    .HasForeignKey(d => d.BarCodeMaSach)
                    .HasConstraintName("FK__PhieuTraS__barCo__4CA06362");

                entity.HasOne(d => d.IdPhieuMuonNavigation)
                    .WithMany(p => p.PhieuTraSaches)
                    .HasForeignKey(d => d.IdPhieuMuon)
                    .HasConstraintName("FK__PhieuTraS__idPhi__4D94879B");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.HasKey(e => e.BarCodeSach)
                    .HasName("PK__Sach__5DB376BE20DECDC3");
            });

            modelBuilder.Entity<SachChiTiet>(entity =>
            {
                entity.HasKey(e => e.BarCodeMaSach)
                    .HasName("PK__SachChiT__15F719802BF58D9A");

                entity.HasOne(d => d.BarCodeSachNavigation)
                    .WithMany(p => p.SachChiTiets)
                    .HasForeignKey(d => d.BarCodeSach)
                    .HasConstraintName("FK__SachChiTi__barCo__440B1D61");

                entity.HasOne(d => d.IdNxbNavigation)
                    .WithMany(p => p.SachChiTiets)
                    .HasForeignKey(d => d.IdNxb)
                    .HasConstraintName("FK__SachChiTi__idNXB__44FF419A");
            });

            modelBuilder.Entity<TacGiaSach>(entity =>
            {
                entity.HasKey(e => new { e.BarCodeSach, e.IdTacGia })
                    .HasName("PK__TacGiaSa__6D1AE38361F900C4");

                entity.HasOne(d => d.BarCodeSachNavigation)
                    .WithMany(p => p.TacGiaSaches)
                    .HasForeignKey(d => d.BarCodeSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TacGiaSac__barCo__286302EC");

                entity.HasOne(d => d.IdTacGiaNavigation)
                    .WithMany(p => p.TacGiaSaches)
                    .HasForeignKey(d => d.IdTacGia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TacGiaSac__idTac__29572725");
            });

            modelBuilder.Entity<TacGium>(entity =>
            {
                entity.HasKey(e => e.IdTacGia)
                    .HasName("PK__TacGia__0A9953D2ED29E5B6");

                entity.Property(e => e.IdTacGia).ValueGeneratedNever();
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.IdTaiKhoan)
                    .HasName("PK__TaiKhoan__8FA29E4A147D0F5D");

                entity.Property(e => e.IdTaiKhoan).ValueGeneratedNever();

                entity.HasOne(d => d.IdNhanVienNavigation)
                    .WithOne(p => p.TaiKhoan)
                    .HasForeignKey<TaiKhoan>(d => d.IdNhanVien)
                    .HasConstraintName("FK__TaiKhoan__idNhan__571DF1D5");
            });

            modelBuilder.Entity<TheLoaiSach>(entity =>
            {
                entity.HasKey(e => e.IdTheLoai)
                    .HasName("PK__TheLoaiS__890D7EC8A5CED670");

                entity.Property(e => e.IdTheLoai).ValueGeneratedNever();
            });

            modelBuilder.Entity<TheThuVien>(entity =>
            {
                entity.HasKey(e => e.IdTheThuVien)
                    .HasName("PK__TheThuVi__CFF8AF0593DC0FD5");
            });

            modelBuilder.Entity<ThietHai>(entity =>
            {
                entity.HasKey(e => e.IdThietHai)
                    .HasName("PK__ThietHai__5F4E884AB85BC206");
            });

            modelBuilder.Entity<ThietHaiChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.IdThietHai, e.IdPhieuTra })
                    .HasName("PK__ThietHai__CC456B52A0F41C75");

                entity.HasOne(d => d.IdPhieuTraNavigation)
                    .WithMany(p => p.ThietHaiChiTiets)
                    .HasForeignKey(d => d.IdPhieuTra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThietHaiC__idPhi__534D60F1");

                entity.HasOne(d => d.IdThietHaiNavigation)
                    .WithMany(p => p.ThietHaiChiTiets)
                    .HasForeignKey(d => d.IdThietHai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThietHaiC__idThi__52593CB8");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
