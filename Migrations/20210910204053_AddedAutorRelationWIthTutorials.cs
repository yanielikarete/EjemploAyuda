using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EjemploAyuda.Migrations
{
    public partial class AddedAutorRelationWIthTutorials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                schema: "admin",
                table: "Tuto",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tuto_AutorId",
                schema: "admin",
                table: "Tuto",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tuto_Autores_AutorId",
                schema: "admin",
                table: "Tuto",
                column: "AutorId",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tuto_Autores_AutorId",
                schema: "admin",
                table: "Tuto");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropIndex(
                name: "IX_Tuto_AutorId",
                schema: "admin",
                table: "Tuto");

            migrationBuilder.DropColumn(
                name: "AutorId",
                schema: "admin",
                table: "Tuto");
        }
    }
}
