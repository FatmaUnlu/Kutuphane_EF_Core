using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kutuphane_EF_Core.Migrations
{
    public partial class emanetModelDüzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeslimDurumu",
                table: "Emanetler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeslimDurumu",
                table: "Emanetler");
        }
    }
}
