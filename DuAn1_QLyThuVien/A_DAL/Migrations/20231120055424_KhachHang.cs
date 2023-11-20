using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class KhachHang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    idKhachHang = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    hoTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    soDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    diemUyTin = table.Column<int>(type: "int", nullable: true),
                    trangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.idKhachHang);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhachHang");
        }
    }
}
