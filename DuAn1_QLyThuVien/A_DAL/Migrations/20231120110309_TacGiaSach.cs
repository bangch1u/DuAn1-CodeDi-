using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class TacGiaSach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TacGiaSach",
                columns: table => new
                {
                    idTGS = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarCodeSachNSX = table.Column<string>(type: "varchar(13)", nullable: true),
                    IdTacGia = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    moTa = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TacGiaSach", x => x.idTGS);
                    table.ForeignKey(
                        name: "FK_TacGiaSach_Sach_BarCodeSachNSX",
                        column: x => x.BarCodeSachNSX,
                        principalTable: "Sach",
                        principalColumn: "barCodeSachNSX");
                    table.ForeignKey(
                        name: "FK_TacGiaSach_TacGia_IdTacGia",
                        column: x => x.IdTacGia,
                        principalTable: "TacGia",
                        principalColumn: "idTacGia");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TacGiaSach_BarCodeSachNSX",
                table: "TacGiaSach",
                column: "BarCodeSachNSX");

            migrationBuilder.CreateIndex(
                name: "IX_TacGiaSach_IdTacGia",
                table: "TacGiaSach",
                column: "IdTacGia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TacGiaSach");
        }
    }
}
