using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class ThietHai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_NhanVien_NhanVienIdNhanVien",
                table: "NhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_TaiKhoan_TaiKhoan_TaiKhoanIdTaiKhoan",
                table: "TaiKhoan");

            migrationBuilder.DropIndex(
                name: "IX_TaiKhoan_TaiKhoanIdTaiKhoan",
                table: "TaiKhoan");

            migrationBuilder.DropIndex(
                name: "IX_NhanVien_NhanVienIdNhanVien",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "TaiKhoanIdTaiKhoan",
                table: "TaiKhoan");

            migrationBuilder.DropColumn(
                name: "NhanVienIdNhanVien",
                table: "NhanVien");

            migrationBuilder.CreateTable(
                name: "ThietHai",
                columns: table => new
                {
                    idThietHai = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    tenThietHai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    diemTruUyTin = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThietHai", x => x.idThietHai);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThietHai");

            migrationBuilder.AddColumn<string>(
                name: "TaiKhoanIdTaiKhoan",
                table: "TaiKhoan",
                type: "varchar(13)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NhanVienIdNhanVien",
                table: "NhanVien",
                type: "varchar(13)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_TaiKhoanIdTaiKhoan",
                table: "TaiKhoan",
                column: "TaiKhoanIdTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_NhanVienIdNhanVien",
                table: "NhanVien",
                column: "NhanVienIdNhanVien");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_NhanVien_NhanVienIdNhanVien",
                table: "NhanVien",
                column: "NhanVienIdNhanVien",
                principalTable: "NhanVien",
                principalColumn: "idNhanVien");

            migrationBuilder.AddForeignKey(
                name: "FK_TaiKhoan_TaiKhoan_TaiKhoanIdTaiKhoan",
                table: "TaiKhoan",
                column: "TaiKhoanIdTaiKhoan",
                principalTable: "TaiKhoan",
                principalColumn: "idTaiKhoan");
        }
    }
}
