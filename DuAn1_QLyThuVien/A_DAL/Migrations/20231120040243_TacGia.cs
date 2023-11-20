using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class TacGia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TacGia",
                columns: table => new
                {
                    idTacGia = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    hoTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ngaySinh = table.Column<DateTime>(type: "date", nullable: true),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: true),
                    diaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TacGia", x => x.idTacGia);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TacGia");
        }
    }
}
