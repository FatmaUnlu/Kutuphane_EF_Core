using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kutuphane_EF_Core.Migrations
{
    public partial class UyeGuncelleme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TCNo",
                table: "Uyeler",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TCNo",
                table: "Uyeler");
        }
    }
}
