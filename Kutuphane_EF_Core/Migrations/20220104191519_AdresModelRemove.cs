using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kutuphane_EF_Core.Migrations
{
    public partial class AdresModelRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uyeler_Adresler_AdresId",
                table: "Uyeler");

            migrationBuilder.DropTable(
                name: "Adresler");

            migrationBuilder.DropIndex(
                name: "IX_Uyeler_AdresId",
                table: "Uyeler");

            migrationBuilder.DropColumn(
                name: "AdresId",
                table: "Uyeler");

            migrationBuilder.DropColumn(
                name: "Cinsiyet",
                table: "Uyeler");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Uyeler",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Uyeler");

            migrationBuilder.AddColumn<int>(
                name: "AdresId",
                table: "Uyeler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Cinsiyet",
                table: "Uyeler",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Adresler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BinaNo = table.Column<int>(type: "int", nullable: false),
                    Cadde = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Il = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Kat = table.Column<int>(type: "int", nullable: false),
                    Mahalle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostaKodu = table.Column<int>(type: "int", nullable: false),
                    Sokak = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresler", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Uyeler_AdresId",
                table: "Uyeler",
                column: "AdresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Uyeler_Adresler_AdresId",
                table: "Uyeler",
                column: "AdresId",
                principalTable: "Adresler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
