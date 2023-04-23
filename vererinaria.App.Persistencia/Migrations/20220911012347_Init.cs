using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace vererinaria.App.Persistencia.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    duenioId = table.Column<int>(type: "int", nullable: true),
                    TargetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    atiendeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Gatos_atiendeId",
                        column: x => x.atiendeId,
                        principalTable: "Gatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Gatos_duenioId",
                        column: x => x.duenioId,
                        principalTable: "Gatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperatura = table.Column<float>(type: "real", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    FrecuenciaRespiratoria = table.Column<float>(type: "real", nullable: false),
                    FrecuenciaCardiaca = table.Column<float>(type: "real", nullable: false),
                    EstadoDeAnimo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaVisita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdProfesional = table.Column<int>(type: "int", nullable: false),
                    Recomendaciones = table.Column<int>(type: "int", nullable: false),
                    Medicamentos = table.Column<int>(type: "int", nullable: false),
                    GatoId = table.Column<int>(type: "int", nullable: true),
                    VeterinarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visitas_Gatos_GatoId",
                        column: x => x.GatoId,
                        principalTable: "Gatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visitas_Personas_VeterinarioId",
                        column: x => x.VeterinarioId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_atiendeId",
                table: "Personas",
                column: "atiendeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_duenioId",
                table: "Personas",
                column: "duenioId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_GatoId",
                table: "Visitas",
                column: "GatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_VeterinarioId",
                table: "Visitas",
                column: "VeterinarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visitas");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Gatos");
        }
    }
}
