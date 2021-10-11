using Microsoft.EntityFrameworkCore.Migrations;

namespace Bibliothèque.Migrations
{
    public partial class UpdateLivre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NomPages",
                table: "Livre",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomPages",
                table: "Livre");
        }
    }
}
