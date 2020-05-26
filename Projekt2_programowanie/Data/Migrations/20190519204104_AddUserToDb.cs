using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt2_programowanie.Data.Migrations
{
    public partial class AddUserToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Monument",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Monument",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
