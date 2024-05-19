using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppProject.Migrations
{
    /// <inheritdoc />
    public partial class inicial6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonaId",
                table: "Rentas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rentas_PersonaId",
                table: "Rentas",
                column: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentas_Personas_PersonaId",
                table: "Rentas",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentas_Personas_PersonaId",
                table: "Rentas");

            migrationBuilder.DropIndex(
                name: "IX_Rentas_PersonaId",
                table: "Rentas");

            migrationBuilder.DropColumn(
                name: "PersonaId",
                table: "Rentas");
        }
    }
}
