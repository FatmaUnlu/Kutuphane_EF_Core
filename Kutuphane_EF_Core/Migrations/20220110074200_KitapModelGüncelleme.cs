using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kutuphane_EF_Core.Migrations
{
    public partial class KitapModelGüncelleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emanetler_Kitaolar_KitapId",
                table: "Emanetler");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaolar_Yayinevleri_YayineviId",
                table: "Kitaolar");

            migrationBuilder.DropForeignKey(
                name: "FK_KitapKategori_Kitaolar_KitapId",
                table: "KitapKategori");

            migrationBuilder.DropForeignKey(
                name: "FK_KitapYazarlar_Kitaolar_KitapId",
                table: "KitapYazarlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kitaolar",
                table: "Kitaolar");

            migrationBuilder.RenameTable(
                name: "Kitaolar",
                newName: "Kitaplar");

            migrationBuilder.RenameIndex(
                name: "IX_Kitaolar_YayineviId",
                table: "Kitaplar",
                newName: "IX_Kitaplar_YayineviId");

            migrationBuilder.AlterColumn<string>(
                name: "Isbn",
                table: "Kitaplar",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kitaplar",
                table: "Kitaplar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emanetler_Kitaplar_KitapId",
                table: "Emanetler",
                column: "KitapId",
                principalTable: "Kitaplar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KitapKategori_Kitaplar_KitapId",
                table: "KitapKategori",
                column: "KitapId",
                principalTable: "Kitaplar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Yayinevleri_YayineviId",
                table: "Kitaplar",
                column: "YayineviId",
                principalTable: "Yayinevleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KitapYazarlar_Kitaplar_KitapId",
                table: "KitapYazarlar",
                column: "KitapId",
                principalTable: "Kitaplar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emanetler_Kitaplar_KitapId",
                table: "Emanetler");

            migrationBuilder.DropForeignKey(
                name: "FK_KitapKategori_Kitaplar_KitapId",
                table: "KitapKategori");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Yayinevleri_YayineviId",
                table: "Kitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_KitapYazarlar_Kitaplar_KitapId",
                table: "KitapYazarlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kitaplar",
                table: "Kitaplar");

            migrationBuilder.RenameTable(
                name: "Kitaplar",
                newName: "Kitaolar");

            migrationBuilder.RenameIndex(
                name: "IX_Kitaplar_YayineviId",
                table: "Kitaolar",
                newName: "IX_Kitaolar_YayineviId");

            migrationBuilder.AlterColumn<string>(
                name: "Isbn",
                table: "Kitaolar",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kitaolar",
                table: "Kitaolar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emanetler_Kitaolar_KitapId",
                table: "Emanetler",
                column: "KitapId",
                principalTable: "Kitaolar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaolar_Yayinevleri_YayineviId",
                table: "Kitaolar",
                column: "YayineviId",
                principalTable: "Yayinevleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KitapKategori_Kitaolar_KitapId",
                table: "KitapKategori",
                column: "KitapId",
                principalTable: "Kitaolar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KitapYazarlar_Kitaolar_KitapId",
                table: "KitapYazarlar",
                column: "KitapId",
                principalTable: "Kitaolar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
