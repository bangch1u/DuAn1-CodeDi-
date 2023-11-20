using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class NXB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhaXuatBan",
                columns: table => new
                {
                    idNXB = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    tenNXB = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    diaChi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    soDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaXuatBan", x => x.idNXB);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhaXuatBan");
        }
    }
}
