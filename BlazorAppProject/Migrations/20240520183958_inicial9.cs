using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppProject.Migrations
{
    /// <inheritdoc />
    public partial class inicial9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Equipo",
                table: "Rentas");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Rentas");

            migrationBuilder.DropColumn(
                name: "EquipoRenta",
                table: "Personas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Equipo",
                table: "Rentas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Rentas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EquipoRenta",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
