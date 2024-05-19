using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppProject.Migrations
{
    /// <inheritdoc />
    public partial class inicial5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RentaId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RentaId",
                table: "Equipos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Rentas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Equipo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fecha = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_RentaId",
                table: "Personas",
                column: "RentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_RentaId",
                table: "Equipos",
                column: "RentaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Rentas_RentaId",
                table: "Equipos",
                column: "RentaId",
                principalTable: "Rentas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Rentas_RentaId",
                table: "Personas",
                column: "RentaId",
                principalTable: "Rentas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Rentas_RentaId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Rentas_RentaId",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "Rentas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_RentaId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_RentaId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "RentaId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "RentaId",
                table: "Equipos");
        }
    }
}
