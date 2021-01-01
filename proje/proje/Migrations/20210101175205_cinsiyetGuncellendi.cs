using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proje.Migrations
{
    public partial class cinsiyetGuncellendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IletisimBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Konum = table.Column<string>(maxLength: 250, nullable: false),
                    eposta = table.Column<string>(maxLength: 50, nullable: false),
                    telNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IletisimBilgileri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Konum",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    konum = table.Column<string>(maxLength: 50, nullable: false),
                    UstKonumID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Konum_Konum",
                        column: x => x.UstKonumID,
                        principalTable: "Konum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    telNo = table.Column<string>(maxLength: 12, nullable: false),
                    password = table.Column<string>(maxLength: 20, nullable: false),
                    dogumTarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    kimlikNo = table.Column<int>(nullable: false),
                    kullaniciTuru = table.Column<int>(nullable: false),
                    cinsiyet = table.Column<bool>(fixedLength: true, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ucaklar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<int>(nullable: false),
                    KoltukSayisi = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ucaklar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Havalimanlari",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(maxLength: 50, nullable: false),
                    KonumID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Havalimanlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Havalimanlari_Konum",
                        column: x => x.KonumID,
                        principalTable: "Konum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sefer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kalkisYeri = table.Column<string>(maxLength: 20, nullable: false),
                    InisYeri = table.Column<string>(maxLength: 20, nullable: false),
                    SeferTarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    UcakId = table.Column<int>(nullable: false),
                    YolcuSayisi = table.Column<byte>(nullable: false),
                    HavalimanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sefer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sefer_Havalimanlari",
                        column: x => x.HavalimanId,
                        principalTable: "Havalimanlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sefer_Ucaklar",
                        column: x => x.UcakId,
                        principalTable: "Ucaklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "bilet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kullaniciID = table.Column<int>(nullable: false),
                    SeferID = table.Column<int>(nullable: false),
                    biletFiyati = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bilet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bilet_Kullanici",
                        column: x => x.kullaniciID,
                        principalTable: "Kullanici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bilet_Sefer",
                        column: x => x.SeferID,
                        principalTable: "Sefer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bilet_kullaniciID",
                table: "bilet",
                column: "kullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_bilet_SeferID",
                table: "bilet",
                column: "SeferID");

            migrationBuilder.CreateIndex(
                name: "IX_Havalimanlari_KonumID",
                table: "Havalimanlari",
                column: "KonumID");

            migrationBuilder.CreateIndex(
                name: "IX_Konum_UstKonumID",
                table: "Konum",
                column: "UstKonumID");

            migrationBuilder.CreateIndex(
                name: "IX_Sefer_HavalimanId",
                table: "Sefer",
                column: "HavalimanId");

            migrationBuilder.CreateIndex(
                name: "IX_Sefer_UcakId",
                table: "Sefer",
                column: "UcakId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bilet");

            migrationBuilder.DropTable(
                name: "IletisimBilgileri");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "Sefer");

            migrationBuilder.DropTable(
                name: "Havalimanlari");

            migrationBuilder.DropTable(
                name: "Ucaklar");

            migrationBuilder.DropTable(
                name: "Konum");
        }
    }
}
