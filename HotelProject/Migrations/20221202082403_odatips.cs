using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.Migrations
{
    public partial class odatips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Odalars_OdaTip_OdaTip",
                table: "Odalars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OdaTip",
                table: "OdaTip");

            migrationBuilder.RenameTable(
                name: "OdaTip",
                newName: "OdaTips");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OdaTips",
                table: "OdaTips",
                column: "Idno");

            migrationBuilder.AddForeignKey(
                name: "FK_Odalars_OdaTips_OdaTip",
                table: "Odalars",
                column: "OdaTip",
                principalTable: "OdaTips",
                principalColumn: "Idno",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Odalars_OdaTips_OdaTip",
                table: "Odalars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OdaTips",
                table: "OdaTips");

            migrationBuilder.RenameTable(
                name: "OdaTips",
                newName: "OdaTip");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OdaTip",
                table: "OdaTip",
                column: "Idno");

            migrationBuilder.AddForeignKey(
                name: "FK_Odalars_OdaTip_OdaTip",
                table: "Odalars",
                column: "OdaTip",
                principalTable: "OdaTip",
                principalColumn: "Idno",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
