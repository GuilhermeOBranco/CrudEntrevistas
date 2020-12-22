using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoEstags.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entrevistado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrevistado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entrevistador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeEntrevistador = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrevistador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entrevista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntrevistadorId = table.Column<int>(type: "int", nullable: true),
                    IdEntrevistador = table.Column<int>(type: "int", nullable: false),
                    Andamento = table.Column<int>(type: "int", nullable: false),
                    IdEntrevistado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrevista", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entrevista_Entrevistador_EntrevistadorId",
                        column: x => x.EntrevistadorId,
                        principalTable: "Entrevistador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entrevista_EntrevistadorId",
                table: "Entrevista",
                column: "EntrevistadorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entrevista");

            migrationBuilder.DropTable(
                name: "Entrevistado");

            migrationBuilder.DropTable(
                name: "Entrevistador");
        }
    }
}
