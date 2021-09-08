using Microsoft.EntityFrameworkCore.Migrations;

namespace EjemploAyuda.Migrations
{
    public partial class AddedToDeleteToTutorial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ToDelete",
                table: "Tutoriales",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToDelete",
                table: "Tutoriales");
        }
    }
}
