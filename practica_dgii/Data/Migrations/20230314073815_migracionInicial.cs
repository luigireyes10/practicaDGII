using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class migracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoAutomoviles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descriccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAutomoviles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPersonas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersonas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlacaVehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoPlaca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoPersonaId = table.Column<int>(type: "int", nullable: false),
                    tipoAutomovilId = table.Column<int>(type: "int", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacaVehiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlacaVehiculos_TipoAutomoviles_tipoAutomovilId",
                        column: x => x.tipoAutomovilId,
                        principalTable: "TipoAutomoviles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlacaVehiculos_TipoPersonas_tipoPersonaId",
                        column: x => x.tipoPersonaId,
                        principalTable: "TipoPersonas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlacaVehiculos_tipoAutomovilId",
                table: "PlacaVehiculos",
                column: "tipoAutomovilId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacaVehiculos_tipoPersonaId",
                table: "PlacaVehiculos",
                column: "tipoPersonaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlacaVehiculos");

            migrationBuilder.DropTable(
                name: "TipoAutomoviles");

            migrationBuilder.DropTable(
                name: "TipoPersonas");
        }
    }
}
