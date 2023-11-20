using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class LichSuNap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LichSuNapDiem",
                columns: table => new
                {
                    idLSND = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    soTienNap = table.Column<decimal>(type: "money", nullable: true),
                    diemCongUyTin = table.Column<int>(type: "int", nullable: true),
                    ngayNap = table.Column<DateTime>(type: "date", nullable: true),
                    IdKhachHang = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    IdNhanVien = table.Column<string>(type: "varchar(13)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuNapDiem", x => x.idLSND);
                    table.ForeignKey(
                        name: "FK_LichSuNapDiem_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "idKhachHang");
                    table.ForeignKey(
                        name: "FK_LichSuNapDiem_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "idNhanVien");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LichSuNapDiem_IdKhachHang",
                table: "LichSuNapDiem",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuNapDiem_IdNhanVien",
                table: "LichSuNapDiem",
                column: "IdNhanVien");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LichSuNapDiem");
        }
    }
}
