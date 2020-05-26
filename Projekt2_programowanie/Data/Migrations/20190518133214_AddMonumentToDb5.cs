using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt2_programowanie.Data.Migrations
{
    public partial class AddMonumentToDb5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Monument",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Monument",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Monument");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Monument",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
