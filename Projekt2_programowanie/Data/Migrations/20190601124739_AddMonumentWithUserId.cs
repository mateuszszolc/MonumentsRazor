using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt2_programowanie.Data.Migrations
{
    public partial class AddMonumentWithUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddingUser",
                table: "Monument",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddingUser",
                table: "Monument");
        }
    }
}
