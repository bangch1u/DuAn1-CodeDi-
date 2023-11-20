using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class updatePhieuMuon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idTheThuVien",
                table: "PhieuMuonSach");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "idTheThuVien",
                table: "PhieuMuonSach",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: true);
        }
    }
}
