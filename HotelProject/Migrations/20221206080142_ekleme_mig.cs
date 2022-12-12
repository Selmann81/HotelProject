using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.Migrations
{
    public partial class ekleme_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rezervasyons",
                columns: table => new
                {
                    Idno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MusteriId = table.Column<int>(nullable: false),
                    OdaId = table.Column<int>(nullable: true),
                    OdaTipId = table.Column<int>(nullable: false),
                    GirisTarihi = table.Column<DateTime>(nullable: false),
                    CikisTarihi = table.Column<DateTime>(nullable: false),
                    Ucret = table.Column<double>(nullable: false),
                    Pansiyon = table.Column<int>(nullable: false),
                    EkUcret = table.Column<double>(nullable: false),
                    Aciklama = table.Column<string>(nullable: true),
                    Yetiskin = table.Column<int>(nullable: false),
                    Cocuk = table.Column<int>(nullable: false),
                    Act = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervasyons", x => x.Idno);
                    table.ForeignKey(
                        name: "FK_Rezervasyons_Musteris_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteris",
                        principalColumn: "Idno",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervasyons_Odalars_OdaId",
                        column: x => x.OdaId,
                        principalTable: "Odalars",
                        principalColumn: "Idno",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervasyons_OdaTips_OdaTipId",
                        column: x => x.OdaTipId,
                        principalTable: "OdaTips",
                        principalColumn: "Idno",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervasyons_Pansiyonlars_Pansiyon",
                        column: x => x.Pansiyon,
                        principalTable: "Pansiyonlars",
                        principalColumn: "Idno",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyons_MusteriId",
                table: "Rezervasyons",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyons_OdaId",
                table: "Rezervasyons",
                column: "OdaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyons_OdaTipId",
                table: "Rezervasyons",
                column: "OdaTipId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyons_Pansiyon",
                table: "Rezervasyons",
                column: "Pansiyon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rezervasyons");
        }
    }
}
