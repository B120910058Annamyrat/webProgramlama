using Microsoft.EntityFrameworkCore.Migrations;

namespace proje.Migrations
{
    public partial class SeferEklemeHatasiGuncelleme1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Sefer_kalkisYeri",
                table: "Sefer",
                column: "kalkisYeri");

            migrationBuilder.AddForeignKey(
                name: "FK_Sefer_Konum",
                table: "Sefer",
                column: "kalkisYeri",
                principalTable: "Konum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sefer_Konum",
                table: "Sefer");

            migrationBuilder.DropIndex(
                name: "IX_Sefer_kalkisYeri",
                table: "Sefer");
        }
    }
}
