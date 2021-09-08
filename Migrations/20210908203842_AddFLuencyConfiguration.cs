using Microsoft.EntityFrameworkCore.Migrations;

namespace EjemploAyuda.Migrations
{
    public partial class AddFLuencyConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutoriales",
                table: "Tutoriales");

            migrationBuilder.EnsureSchema(
                name: "admin");

            migrationBuilder.RenameTable(
                name: "Tutoriales",
                newName: "Tuto",
                newSchema: "admin");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "admin",
                table: "Tuto",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tuto",
                schema: "admin",
                table: "Tuto",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tuto",
                schema: "admin",
                table: "Tuto");

            migrationBuilder.RenameTable(
                name: "Tuto",
                schema: "admin",
                newName: "Tutoriales");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Tutoriales",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutoriales",
                table: "Tutoriales",
                column: "Id");
        }
    }
}
