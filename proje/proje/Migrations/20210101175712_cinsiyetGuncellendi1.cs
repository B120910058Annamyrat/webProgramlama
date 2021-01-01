using Microsoft.EntityFrameworkCore.Migrations;

namespace proje.Migrations
{
    public partial class cinsiyetGuncellendi1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "cinsiyet",
                table: "Kullanici",
                fixedLength: true,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldFixedLength: true,
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "cinsiyet",
                table: "Kullanici",
                type: "bit",
                fixedLength: true,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(bool),
                oldFixedLength: true,
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
