using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class ThietHaiChiTiet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThietHaiChiTiet",
                columns: table => new
                {
                    idTHCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    moTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IdPhieuTra = table.Column<string>(type: "varchar(10)", nullable: true),
                    IdThietHai = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThietHaiChiTiet", x => x.idTHCT);
                    table.ForeignKey(
                        name: "FK_ThietHaiChiTiet_PhieuTraSach_IdPhieuTra",
                        column: x => x.IdPhieuTra,
                        principalTable: "PhieuTraSach",
                        principalColumn: "idPhieuTra");
                    table.ForeignKey(
                        name: "FK_ThietHaiChiTiet_ThietHai_IdThietHai",
                        column: x => x.IdThietHai,
                        principalTable: "ThietHai",
                        principalColumn: "idThietHai");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ThietHaiChiTiet_IdPhieuTra",
                table: "ThietHaiChiTiet",
                column: "IdPhieuTra");

            migrationBuilder.CreateIndex(
                name: "IX_ThietHaiChiTiet_IdThietHai",
                table: "ThietHaiChiTiet",
                column: "IdThietHai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThietHaiChiTiet");
        }
    }
}
