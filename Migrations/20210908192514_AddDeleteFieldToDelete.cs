using Microsoft.EntityFrameworkCore.Migrations;

namespace EjemploAyuda.Migrations
{
    public partial class AddDeleteFieldToDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToDelete",
                table: "Tutoriales");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ToDelete",
                table: "Tutoriales",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
