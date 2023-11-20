using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class PhieuMuonSach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdPhieuMuon",
                table: "KhachHang",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PhieuMuonSach",
                columns: table => new
                {
                    idPhieuMuon = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    idTheThuVien = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tongSachMuon = table.Column<int>(type: "int", nullable: true),
                    ngayTaoPhieu = table.Column<DateTime>(type: "date", nullable: true),
                    trangThai = table.Column<bool>(type: "bit", nullable: true),
                    IdKhachHang = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuMuonSach", x => x.idPhieuMuon);
                    table.ForeignKey(
                        name: "FK_PhieuMuonSach_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "idKhachHang");
                });

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_IdPhieuMuon",
                table: "KhachHang",
                column: "IdPhieuMuon");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuonSach_IdKhachHang",
                table: "PhieuMuonSach",
                column: "IdKhachHang");

            migrationBuilder.AddForeignKey(
                name: "FK_KhachHang_PhieuMuonSach_IdPhieuMuon",
                table: "KhachHang",
                column: "IdPhieuMuon",
                principalTable: "PhieuMuonSach",
                principalColumn: "idPhieuMuon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KhachHang_PhieuMuonSach_IdPhieuMuon",
                table: "KhachHang");

            migrationBuilder.DropTable(
                name: "PhieuMuonSach");

            migrationBuilder.DropIndex(
                name: "IX_KhachHang_IdPhieuMuon",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "IdPhieuMuon",
                table: "KhachHang");
        }
    }
}
