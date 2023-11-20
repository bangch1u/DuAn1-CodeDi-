using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class tb_Sach_SachChiTiet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "idNXB",
                table: "NhaXuatBan",
                type: "varchar(13)",
                unicode: false,
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.CreateTable(
                name: "Sach",
                columns: table => new
                {
                    barCodeSachNSX = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: false),
                    tenSach = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    soLuong = table.Column<int>(type: "int", nullable: true),
                    giaTien = table.Column<decimal>(type: "money", nullable: true),
                    namXuatBan = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach", x => x.barCodeSachNSX);
                });

            migrationBuilder.CreateTable(
                name: "SachChiTiet",
                columns: table => new
                {
                    barCodeSach = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: false),
                    tinhTrangSach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    lanTaiBan = table.Column<int>(type: "int", nullable: true),
                    kichCo = table.Column<int>(type: "int", nullable: true),
                    namTaiBan = table.Column<DateTime>(type: "date", nullable: true),
                    diemUyTinMin = table.Column<int>(type: "int", nullable: true),
                    IdNhaXuatBan = table.Column<string>(type: "varchar(13)", nullable: true),
                    BarCodeSachNSX = table.Column<string>(type: "varchar(13)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SachChiTiet", x => x.barCodeSach);
                    table.ForeignKey(
                        name: "FK_SachChiTiet_NhaXuatBan_IdNhaXuatBan",
                        column: x => x.IdNhaXuatBan,
                        principalTable: "NhaXuatBan",
                        principalColumn: "idNXB");
                    table.ForeignKey(
                        name: "FK_SachChiTiet_Sach_BarCodeSachNSX",
                        column: x => x.BarCodeSachNSX,
                        principalTable: "Sach",
                        principalColumn: "barCodeSachNSX");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SachChiTiet_BarCodeSachNSX",
                table: "SachChiTiet",
                column: "BarCodeSachNSX");

            migrationBuilder.CreateIndex(
                name: "IX_SachChiTiet_IdNhaXuatBan",
                table: "SachChiTiet",
                column: "IdNhaXuatBan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SachChiTiet");

            migrationBuilder.DropTable(
                name: "Sach");

            migrationBuilder.AlterColumn<string>(
                name: "idNXB",
                table: "NhaXuatBan",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(13)",
                oldUnicode: false,
                oldMaxLength: 13);
        }
    }
}
