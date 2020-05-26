using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt2_programowanie.Data.Migrations
{
    public partial class AddNickToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nick",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nick",
                table: "AspNetUsers");
        }
    }
}
