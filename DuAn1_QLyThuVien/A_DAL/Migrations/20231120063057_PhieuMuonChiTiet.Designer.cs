﻿// <auto-generated />
using System;
using A_DAL.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace A_DAL.Migrations
{
    [DbContext(typeof(ThuVienContext))]
    [Migration("20231120063057_PhieuMuonChiTiet")]
    partial class PhieuMuonChiTiet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("A_DAL.Model.KhachHang", b =>
                {
                    b.Property<string>("IdKhachHang")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("idKhachHang");

                    b.Property<int?>("DiemUyTin")
                        .HasColumnType("int")
                        .HasColumnName("diemUyTin");

                    b.Property<string>("HoTen")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("hoTen");

                    b.Property<string>("IdPhieuMuon")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("soDienThoai");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("trangThai");

                    b.HasKey("IdKhachHang");

                    b.HasIndex("IdPhieuMuon");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("A_DAL.Model.NhanVien", b =>
                {
                    b.Property<string>("IdNhanVien")
                        .HasMaxLength(13)
                        .IsUnicode(false)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("idNhanVien");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("diaChi");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<bool?>("GioiTinh")
                        .HasColumnType("bit")
                        .HasColumnName("gioiTinh");

                    b.Property<string>("HoTen")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("hoTen");

                    b.Property<string>("IdTaiKhoan")
                        .HasColumnType("varchar(13)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date")
                        .HasColumnName("ngaySinh");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("soDienThoai");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("trangThai");

                    b.HasKey("IdNhanVien");

                    b.HasIndex("IdTaiKhoan");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("A_DAL.Model.NhaXuatBan", b =>
                {
                    b.Property<string>("IdNxb")
                        .HasMaxLength(13)
                        .IsUnicode(false)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("idNXB");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("diaChi");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("soDienThoai");

                    b.Property<string>("TenNxb")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("tenNXB");

                    b.HasKey("IdNxb");

                    b.ToTable("NhaXuatBan");
                });

            modelBuilder.Entity("A_DAL.Model.PhieuMuonChiTiet", b =>
                {
                    b.Property<int>("IdPhieuMuonChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idPhieuMuonChiTiet");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPhieuMuonChiTiet"), 1L, 1);

                    b.Property<string>("BarCodeSach")
                        .HasColumnType("varchar(13)");

                    b.Property<string>("IdNhanVien")
                        .HasColumnType("varchar(13)");

                    b.Property<string>("IdPhieuMuon")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("idPhieuMuon");

                    b.Property<DateTime?>("NgayMuonSach")
                        .HasColumnType("date")
                        .HasColumnName("ngayMuonSach");

                    b.Property<DateTime?>("NgayTraSach")
                        .HasColumnType("date")
                        .HasColumnName("ngayTraSach");

                    b.Property<int?>("SoLanGiaHan")
                        .HasColumnType("int")
                        .HasColumnName("soLanGiaHan");

                    b.Property<int?>("SoLuongSach")
                        .HasColumnType("int")
                        .HasColumnName("soLuongSach");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("trangThai");

                    b.HasKey("IdPhieuMuonChiTiet");

                    b.HasIndex("BarCodeSach");

                    b.HasIndex("IdNhanVien");

                    b.HasIndex("IdPhieuMuon");

                    b.ToTable("PhieuMuonChiTiet");
                });

            modelBuilder.Entity("A_DAL.Model.PhieuMuonSach", b =>
                {
                    b.Property<string>("IdPhieuMuon")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("idPhieuMuon");

                    b.Property<string>("IdKhachHang")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("IdTheThuVien")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("idTheThuVien");

                    b.Property<DateTime?>("NgayTaoPhieu")
                        .HasColumnType("date")
                        .HasColumnName("ngayTaoPhieu");

                    b.Property<int?>("TongSachMuon")
                        .HasColumnType("int")
                        .HasColumnName("tongSachMuon");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit")
                        .HasColumnName("trangThai");

                    b.HasKey("IdPhieuMuon");

                    b.HasIndex("IdKhachHang");

                    b.ToTable("PhieuMuonSach");
                });

            modelBuilder.Entity("A_DAL.Model.Sach", b =>
                {
                    b.Property<string>("BarCodeSachNSX")
                        .HasMaxLength(13)
                        .IsUnicode(false)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("barCodeSachNSX");

                    b.Property<decimal?>("GiaTien")
                        .HasColumnType("money")
                        .HasColumnName("giaTien");

                    b.Property<DateTime?>("NamXuatBan")
                        .HasColumnType("date")
                        .HasColumnName("namXuatBan");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("soLuong");

                    b.Property<string>("TenSach")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("tenSach");

                    b.HasKey("BarCodeSachNSX");

                    b.ToTable("Sach");
                });

            modelBuilder.Entity("A_DAL.Model.SachChiTiet", b =>
                {
                    b.Property<string>("BarCodeSach")
                        .HasMaxLength(13)
                        .IsUnicode(false)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("barCodeSach");

                    b.Property<string>("BarCodeSachNSX")
                        .HasColumnType("varchar(13)");

                    b.Property<int?>("DiemUyTinMin")
                        .HasColumnType("int")
                        .HasColumnName("diemUyTinMin");

                    b.Property<string>("IdNhaXuatBan")
                        .HasColumnType("varchar(13)");

                    b.Property<int?>("KichCo")
                        .HasColumnType("int")
                        .HasColumnName("kichCo");

                    b.Property<int?>("LanTaiBan")
                        .HasColumnType("int")
                        .HasColumnName("lanTaiBan");

                    b.Property<DateTime?>("NamTaiBan")
                        .HasColumnType("date")
                        .HasColumnName("namTaiBan");

                    b.Property<string>("TinhTrangSach")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tinhTrangSach");

                    b.HasKey("BarCodeSach");

                    b.HasIndex("BarCodeSachNSX");

                    b.HasIndex("IdNhaXuatBan");

                    b.ToTable("SachChiTiet");
                });

            modelBuilder.Entity("A_DAL.Model.TacGia", b =>
                {
                    b.Property<string>("IdTacGia")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("idTacGia");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("diaChi");

                    b.Property<bool?>("GioiTinh")
                        .HasColumnType("bit")
                        .HasColumnName("gioiTinh");

                    b.Property<string>("HoTen")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("hoTen");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date")
                        .HasColumnName("ngaySinh");

                    b.HasKey("IdTacGia");

                    b.ToTable("TacGia");
                });

            modelBuilder.Entity("A_DAL.Model.TaiKhoan", b =>
                {
                    b.Property<string>("IdTaiKhoan")
                        .HasMaxLength(13)
                        .IsUnicode(false)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("idTaiKhoan");

                    b.Property<string>("IdNhanVien")
                        .HasColumnType("varchar(13)");

                    b.Property<string>("PassWord")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("passWord");

                    b.Property<int?>("Role")
                        .HasColumnType("int")
                        .HasColumnName("role");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("userName");

                    b.HasKey("IdTaiKhoan");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("TaiKhoan");
                });

            modelBuilder.Entity("A_DAL.Model.TheLoaiSach", b =>
                {
                    b.Property<string>("IdTheLoai")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("idTheLoai");

                    b.Property<string>("TenTheLoai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tenTheLoai");

                    b.Property<string>("ViTriKeSach")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("viTriKeSach");

                    b.HasKey("IdTheLoai");

                    b.ToTable("TheLoaiSach");
                });

            modelBuilder.Entity("A_DAL.Model.ThietHai", b =>
                {
                    b.Property<string>("IdThietHai")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("idThietHai");

                    b.Property<int?>("DiemTruUyTin")
                        .HasColumnType("int")
                        .HasColumnName("diemTruUyTin");

                    b.Property<string>("TenThietHai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tenThietHai");

                    b.HasKey("IdThietHai");

                    b.ToTable("ThietHai");
                });

            modelBuilder.Entity("A_DAL.Model.KhachHang", b =>
                {
                    b.HasOne("A_DAL.Model.PhieuMuonSach", "PhieuMuonSach")
                        .WithMany()
                        .HasForeignKey("IdPhieuMuon");

                    b.Navigation("PhieuMuonSach");
                });

            modelBuilder.Entity("A_DAL.Model.NhanVien", b =>
                {
                    b.HasOne("A_DAL.Model.TaiKhoan", "TaiKhoan")
                        .WithMany()
                        .HasForeignKey("IdTaiKhoan");

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("A_DAL.Model.PhieuMuonChiTiet", b =>
                {
                    b.HasOne("A_DAL.Model.SachChiTiet", "SachChiTiet")
                        .WithMany()
                        .HasForeignKey("BarCodeSach");

                    b.HasOne("A_DAL.Model.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("IdNhanVien");

                    b.HasOne("A_DAL.Model.PhieuMuonSach", "PhieuMuonSach")
                        .WithMany()
                        .HasForeignKey("IdPhieuMuon");

                    b.Navigation("NhanVien");

                    b.Navigation("PhieuMuonSach");

                    b.Navigation("SachChiTiet");
                });

            modelBuilder.Entity("A_DAL.Model.PhieuMuonSach", b =>
                {
                    b.HasOne("A_DAL.Model.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("IdKhachHang");

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("A_DAL.Model.SachChiTiet", b =>
                {
                    b.HasOne("A_DAL.Model.Sach", "Sach")
                        .WithMany()
                        .HasForeignKey("BarCodeSachNSX");

                    b.HasOne("A_DAL.Model.NhaXuatBan", "NhaXuatBan")
                        .WithMany()
                        .HasForeignKey("IdNhaXuatBan");

                    b.Navigation("NhaXuatBan");

                    b.Navigation("Sach");
                });

            modelBuilder.Entity("A_DAL.Model.TaiKhoan", b =>
                {
                    b.HasOne("A_DAL.Model.NhanVien", "NhanViens")
                        .WithMany()
                        .HasForeignKey("IdNhanVien");

                    b.Navigation("NhanViens");
                });
#pragma warning restore 612, 618
        }
    }
}
