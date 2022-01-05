using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kutuphane_EF_Core.Migrations
{
    public partial class UyeModelGuncelleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SiparisDetaylari_Kategoriler_KategoriId",
                table: "SiparisDetaylari");

            migrationBuilder.DropForeignKey(
                name: "FK_SiparisDetaylari_Kitaolar_KitapId",
                table: "SiparisDetaylari");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SiparisDetaylari",
                table: "SiparisDetaylari");

            migrationBuilder.RenameTable(
                name: "SiparisDetaylari",
                newName: "KitapKategori");

            migrationBuilder.RenameIndex(
                name: "IX_SiparisDetaylari_KategoriId",
                table: "KitapKategori",
                newName: "IX_KitapKategori_KategoriId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KitapKategori",
                table: "KitapKategori",
                columns: new[] { "KitapId", "KategoriId" });

            migrationBuilder.AddForeignKey(
                name: "FK_KitapKategori_Kategoriler_KategoriId",
                table: "KitapKategori",
                column: "KategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KitapKategori_Kitaolar_KitapId",
                table: "KitapKategori",
                column: "KitapId",
                principalTable: "Kitaolar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KitapKategori_Kategoriler_KategoriId",
                table: "KitapKategori");

            migrationBuilder.DropForeignKey(
                name: "FK_KitapKategori_Kitaolar_KitapId",
                table: "KitapKategori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KitapKategori",
                table: "KitapKategori");

            migrationBuilder.RenameTable(
                name: "KitapKategori",
                newName: "SiparisDetaylari");

            migrationBuilder.RenameIndex(
                name: "IX_KitapKategori_KategoriId",
                table: "SiparisDetaylari",
                newName: "IX_SiparisDetaylari_KategoriId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SiparisDetaylari",
                table: "SiparisDetaylari",
                columns: new[] { "KitapId", "KategoriId" });

            migrationBuilder.AddForeignKey(
                name: "FK_SiparisDetaylari_Kategoriler_KategoriId",
                table: "SiparisDetaylari",
                column: "KategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiparisDetaylari_Kitaolar_KitapId",
                table: "SiparisDetaylari",
                column: "KitapId",
                principalTable: "Kitaolar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
