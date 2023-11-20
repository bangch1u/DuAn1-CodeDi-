using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class PhieuTra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhieuTraSach",
                columns: table => new
                {
                    idPhieuTra = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    soLuongTra = table.Column<int>(type: "int", nullable: true),
                    thoiGianTraSach = table.Column<DateTime>(type: "date", nullable: true),
                    tinhTrangSach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trangThai = table.Column<bool>(type: "bit", nullable: true),
                    BarCodeSach = table.Column<string>(type: "varchar(13)", nullable: true),
                    IdPhieuMuon = table.Column<string>(type: "varchar(10)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuTraSach", x => x.idPhieuTra);
                    table.ForeignKey(
                        name: "FK_PhieuTraSach_PhieuMuonSach_IdPhieuMuon",
                        column: x => x.IdPhieuMuon,
                        principalTable: "PhieuMuonSach",
                        principalColumn: "idPhieuMuon");
                    table.ForeignKey(
                        name: "FK_PhieuTraSach_SachChiTiet_BarCodeSach",
                        column: x => x.BarCodeSach,
                        principalTable: "SachChiTiet",
                        principalColumn: "barCodeSach");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTraSach_BarCodeSach",
                table: "PhieuTraSach",
                column: "BarCodeSach");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTraSach_IdPhieuMuon",
                table: "PhieuTraSach",
                column: "IdPhieuMuon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhieuTraSach");
        }
    }
}
