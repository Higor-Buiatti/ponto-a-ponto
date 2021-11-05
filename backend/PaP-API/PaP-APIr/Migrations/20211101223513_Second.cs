using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PaP_APIr.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PontoDois",
                table: "Pontos");

            migrationBuilder.DropColumn(
                name: "PontoQuatro",
                table: "Pontos");

            migrationBuilder.DropColumn(
                name: "PontoTres",
                table: "Pontos");

            migrationBuilder.RenameColumn(
                name: "PontoUm",
                table: "Pontos",
                newName: "PontoHora");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PontoHora",
                table: "Pontos",
                newName: "PontoUm");

            migrationBuilder.AddColumn<DateTime>(
                name: "PontoDois",
                table: "Pontos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PontoQuatro",
                table: "Pontos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PontoTres",
                table: "Pontos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
