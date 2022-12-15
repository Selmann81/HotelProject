using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.Migrations
{
    public partial class randomkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RandomKey",
                table: "Rezervasyons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RandomKey",
                table: "Rezervasyons");
        }
    }
}
