using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class PhieuMuonChiTiet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhieuMuonChiTiet",
                columns: table => new
                {
                    idPhieuMuonChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    soLuongSach = table.Column<int>(type: "int", nullable: true),
                    ngayMuonSach = table.Column<DateTime>(type: "date", nullable: true),
                    ngayTraSach = table.Column<DateTime>(type: "date", nullable: true),
                    soLanGiaHan = table.Column<int>(type: "int", nullable: true),
                    trangThai = table.Column<int>(type: "int", nullable: true),
                    idPhieuMuon = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    IdNhanVien = table.Column<string>(type: "varchar(13)", nullable: true),
                    BarCodeSach = table.Column<string>(type: "varchar(13)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuMuonChiTiet", x => x.idPhieuMuonChiTiet);
                    table.ForeignKey(
                        name: "FK_PhieuMuonChiTiet_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "idNhanVien");
                    table.ForeignKey(
                        name: "FK_PhieuMuonChiTiet_PhieuMuonSach_idPhieuMuon",
                        column: x => x.idPhieuMuon,
                        principalTable: "PhieuMuonSach",
                        principalColumn: "idPhieuMuon");
                    table.ForeignKey(
                        name: "FK_PhieuMuonChiTiet_SachChiTiet_BarCodeSach",
                        column: x => x.BarCodeSach,
                        principalTable: "SachChiTiet",
                        principalColumn: "barCodeSach");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuonChiTiet_BarCodeSach",
                table: "PhieuMuonChiTiet",
                column: "BarCodeSach");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuonChiTiet_IdNhanVien",
                table: "PhieuMuonChiTiet",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuonChiTiet_idPhieuMuon",
                table: "PhieuMuonChiTiet",
                column: "idPhieuMuon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhieuMuonChiTiet");
        }
    }
}
