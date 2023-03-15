using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class migracionVehiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "TipoPersonas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TipoPersonas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "DeletedRecord",
                table: "TipoPersonas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "TipoPersonas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "TipoPersonas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "TipoAutomoviles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TipoAutomoviles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "DeletedRecord",
                table: "TipoAutomoviles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "TipoAutomoviles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "TipoAutomoviles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PlacaVehiculos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "PlacaVehiculos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "DeletedRecord",
                table: "PlacaVehiculos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "PlacaVehiculos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "PlacaVehiculos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idVehiculoId",
                table: "PlacaVehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idVehiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estilo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoVehiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chasis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedRecord = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlacaVehiculos_idVehiculoId",
                table: "PlacaVehiculos",
                column: "idVehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlacaVehiculos_Vehiculos_idVehiculoId",
                table: "PlacaVehiculos",
                column: "idVehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlacaVehiculos_Vehiculos_idVehiculoId",
                table: "PlacaVehiculos");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_PlacaVehiculos_idVehiculoId",
                table: "PlacaVehiculos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TipoPersonas");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TipoPersonas");

            migrationBuilder.DropColumn(
                name: "DeletedRecord",
                table: "TipoPersonas");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "TipoPersonas");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "TipoPersonas");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TipoAutomoviles");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TipoAutomoviles");

            migrationBuilder.DropColumn(
                name: "DeletedRecord",
                table: "TipoAutomoviles");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "TipoAutomoviles");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "TipoAutomoviles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PlacaVehiculos");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "PlacaVehiculos");

            migrationBuilder.DropColumn(
                name: "DeletedRecord",
                table: "PlacaVehiculos");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PlacaVehiculos");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "PlacaVehiculos");

            migrationBuilder.DropColumn(
                name: "idVehiculoId",
                table: "PlacaVehiculos");
        }
    }
}
