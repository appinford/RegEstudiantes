using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TallerMecanica.Data.Migrations
{
    public partial class inici2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    Cedula = table.Column<string>(maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(maxLength: 80, nullable: false),
                    Sector = table.Column<string>(maxLength: 50, nullable: false),
                    Ciudad = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mecanicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    HabilidadRep = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mecanicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<int>(nullable: false),
                    Matricula = table.Column<string>(nullable: false),
                    AnoFab = table.Column<int>(nullable: false),
                    Color = table.Column<int>(nullable: false),
                    TipoTransmision = table.Column<int>(nullable: false),
                    LugarFab = table.Column<int>(nullable: false),
                    DescProblema = table.Column<string>(maxLength: 150, nullable: false),
                    Comentario = table.Column<string>(maxLength: 250, nullable: true),
                    FechaIngreso = table.Column<DateTime>(nullable: false),
                    FechaEntrega = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrdenReps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    VehiculoId = table.Column<int>(nullable: false),
                    MecanicoId = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    NumeroOrden = table.Column<string>(maxLength: 15, nullable: true),
                    Cliente_Nombres = table.Column<string>(maxLength: 50, nullable: false),
                    Cliente_Apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    Mecanico_Nombres = table.Column<string>(maxLength: 50, nullable: false),
                    Mecanico_Apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    Marca = table.Column<int>(nullable: false),
                    Matricula = table.Column<string>(nullable: false),
                    AnoFab = table.Column<int>(nullable: false),
                    Color = table.Column<int>(nullable: false),
                    Fecha_Asignacion = table.Column<DateTime>(nullable: false),
                    Fecha_Terminado = table.Column<DateTime>(nullable: false),
                    Resolucion = table.Column<string>(maxLength: 250, nullable: true),
                    Estatus = table.Column<int>(nullable: false),
                    MotivoNoRep = table.Column<string>(maxLength: 250, nullable: true),
                    DecisionFinal = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenReps", x => new { x.VehiculoId, x.MecanicoId, x.ClienteId, x.Id });
                    table.ForeignKey(
                        name: "FK_OrdenReps_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenReps_Mecanicos_MecanicoId",
                        column: x => x.MecanicoId,
                        principalTable: "Mecanicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenReps_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdenReps_ClienteId",
                table: "OrdenReps",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenReps_MecanicoId",
                table: "OrdenReps",
                column: "MecanicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdenReps");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Mecanicos");

            migrationBuilder.DropTable(
                name: "Vehiculos");
        }
    }
}
