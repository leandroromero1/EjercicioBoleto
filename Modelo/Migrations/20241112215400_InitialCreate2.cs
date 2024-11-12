using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColectivoId",
                table: "Pasajeros",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Colectivo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Linea = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colectivo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pasajeros_ColectivoId",
                table: "Pasajeros",
                column: "ColectivoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pasajeros_Colectivo_ColectivoId",
                table: "Pasajeros",
                column: "ColectivoId",
                principalTable: "Colectivo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pasajeros_Colectivo_ColectivoId",
                table: "Pasajeros");

            migrationBuilder.DropTable(
                name: "Colectivo");

            migrationBuilder.DropIndex(
                name: "IX_Pasajeros_ColectivoId",
                table: "Pasajeros");

            migrationBuilder.DropColumn(
                name: "ColectivoId",
                table: "Pasajeros");
        }
    }
}
