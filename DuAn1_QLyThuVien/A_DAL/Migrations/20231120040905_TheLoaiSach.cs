using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class TheLoaiSach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TheLoaiSach",
                columns: table => new
                {
                    idTheLoai = table.Column<string>(type: "nvarchar(13)", nullable: false),
                    tenTheLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    viTriKeSach = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoaiSach", x => x.idTheLoai);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TheLoaiSach");
        }
    }
}
