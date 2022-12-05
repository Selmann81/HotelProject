using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KullaniciAdi = table.Column<string>(nullable: true),
                    Sifre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musteris",
                columns: table => new
                {
                    Idno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Adisoyadi = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<DateTime>(nullable: false),
                    TcNo = table.Column<string>(nullable: true),
                    Uyruk = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Act = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteris", x => x.Idno);
                });

            migrationBuilder.CreateTable(
                name: "OdaTip",
                columns: table => new
                {
                    Idno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Baslik = table.Column<string>(nullable: true),
                    Ozellikler = table.Column<string>(nullable: true),
                    Ucret = table.Column<double>(nullable: false),
                    Act = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdaTip", x => x.Idno);
                });

            migrationBuilder.CreateTable(
                name: "Odalars",
                columns: table => new
                {
                    Idno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OdaAdi = table.Column<string>(nullable: true),
                    OdaNo = table.Column<int>(nullable: false),
                    OdaTip = table.Column<int>(nullable: false),
                    Cephe = table.Column<string>(nullable: true),
                    YatakSayisi = table.Column<int>(nullable: false),
                    Ozellikler = table.Column<string>(nullable: true),
                    Act = table.Column<int>(nullable: false),
                    Aciklama = table.Column<string>(nullable: true),
                    Anasayfa = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odalars", x => x.Idno);
                    table.ForeignKey(
                        name: "FK_Odalars_OdaTip_OdaTip",
                        column: x => x.OdaTip,
                        principalTable: "OdaTip",
                        principalColumn: "Idno",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Odalars_OdaTip",
                table: "Odalars",
                column: "OdaTip");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Musteris");

            migrationBuilder.DropTable(
                name: "Odalars");

            migrationBuilder.DropTable(
                name: "OdaTip");
        }
    }
}
