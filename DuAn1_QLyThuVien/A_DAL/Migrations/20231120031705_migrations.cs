using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    idNhanVien = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: false),
                    hoTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: true),
                    soDienThoai = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    diaChi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ngaySinh = table.Column<DateTime>(type: "date", nullable: true),
                    email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    trangThai = table.Column<int>(type: "int", nullable: true),
                    IdTaiKhoan = table.Column<string>(type: "varchar(13)", nullable: true),
                    NhanVienIdNhanVien = table.Column<string>(type: "varchar(13)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.idNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanVien_NhanVien_NhanVienIdNhanVien",
                        column: x => x.NhanVienIdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "idNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    idTaiKhoan = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: false),
                    userName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    passWord = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    role = table.Column<int>(type: "int", nullable: true),
                    IdNhanVien = table.Column<string>(type: "varchar(13)", nullable: true),
                    TaiKhoanIdTaiKhoan = table.Column<string>(type: "varchar(13)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.idTaiKhoan);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "idNhanVien");
                    table.ForeignKey(
                        name: "FK_TaiKhoan_TaiKhoan_TaiKhoanIdTaiKhoan",
                        column: x => x.TaiKhoanIdTaiKhoan,
                        principalTable: "TaiKhoan",
                        principalColumn: "idTaiKhoan");
                });

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdTaiKhoan",
                table: "NhanVien",
                column: "IdTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_NhanVienIdNhanVien",
                table: "NhanVien",
                column: "NhanVienIdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_IdNhanVien",
                table: "TaiKhoan",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_TaiKhoanIdTaiKhoan",
                table: "TaiKhoan",
                column: "TaiKhoanIdTaiKhoan");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_TaiKhoan_IdTaiKhoan",
                table: "NhanVien",
                column: "IdTaiKhoan",
                principalTable: "TaiKhoan",
                principalColumn: "idTaiKhoan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_TaiKhoan_IdTaiKhoan",
                table: "NhanVien");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}
