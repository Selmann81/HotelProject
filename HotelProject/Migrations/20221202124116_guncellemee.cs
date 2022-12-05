using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.Migrations
{
    public partial class guncellemee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OdaOzelliks",
                columns: table => new
                {
                    Idno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ikon = table.Column<string>(nullable: true),
                    Baslik = table.Column<string>(nullable: true),
                    Act = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdaOzelliks", x => x.Idno);
                });

            migrationBuilder.CreateTable(
                name: "Pansiyonlars",
                columns: table => new
                {
                    Idno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Baslik = table.Column<string>(nullable: true),
                    Ucret = table.Column<double>(nullable: false),
                    Act = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pansiyonlars", x => x.Idno);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OdaOzelliks");

            migrationBuilder.DropTable(
                name: "Pansiyonlars");
        }
    }
}
