using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class ChiTietTheLoai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiTietTheLoai",
                columns: table => new
                {
                    idTLCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTheLoai = table.Column<string>(type: "nvarchar(13)", nullable: true),
                    BarCodeSachNSX = table.Column<string>(type: "varchar(13)", nullable: true),
                    moTa = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietTheLoai", x => x.idTLCT);
                    table.ForeignKey(
                        name: "FK_ChiTietTheLoai_Sach_BarCodeSachNSX",
                        column: x => x.BarCodeSachNSX,
                        principalTable: "Sach",
                        principalColumn: "barCodeSachNSX");
                    table.ForeignKey(
                        name: "FK_ChiTietTheLoai_TheLoaiSach_IdTheLoai",
                        column: x => x.IdTheLoai,
                        principalTable: "TheLoaiSach",
                        principalColumn: "idTheLoai");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTheLoai_BarCodeSachNSX",
                table: "ChiTietTheLoai",
                column: "BarCodeSachNSX");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTheLoai_IdTheLoai",
                table: "ChiTietTheLoai",
                column: "IdTheLoai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietTheLoai");
        }
    }
}
