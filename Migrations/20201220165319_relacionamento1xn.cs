using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoEstags.Migrations
{
    public partial class relacionamento1xn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrevista_Entrevistado_IdEntrevistadoId",
                table: "Entrevista");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrevista_Entrevistador_IdEntrevistadorId",
                table: "Entrevista");

            migrationBuilder.DropIndex(
                name: "IX_Entrevista_IdEntrevistadoId",
                table: "Entrevista");

            migrationBuilder.DropIndex(
                name: "IX_Entrevista_IdEntrevistadorId",
                table: "Entrevista");

            migrationBuilder.DropColumn(
                name: "IdEntrevistadoId",
                table: "Entrevista");

            migrationBuilder.DropColumn(
                name: "IdEntrevistadorId",
                table: "Entrevista");

            migrationBuilder.AddColumn<int>(
                name: "EntrevistadoId",
                table: "Entrevista",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EntrevistadorId",
                table: "Entrevista",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Entrevista_EntrevistadoId",
                table: "Entrevista",
                column: "EntrevistadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrevista_EntrevistadorId",
                table: "Entrevista",
                column: "EntrevistadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrevista_Entrevistado_EntrevistadoId",
                table: "Entrevista",
                column: "EntrevistadoId",
                principalTable: "Entrevistado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrevista_Entrevistador_EntrevistadorId",
                table: "Entrevista",
                column: "EntrevistadorId",
                principalTable: "Entrevistador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrevista_Entrevistado_EntrevistadoId",
                table: "Entrevista");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrevista_Entrevistador_EntrevistadorId",
                table: "Entrevista");

            migrationBuilder.DropIndex(
                name: "IX_Entrevista_EntrevistadoId",
                table: "Entrevista");

            migrationBuilder.DropIndex(
                name: "IX_Entrevista_EntrevistadorId",
                table: "Entrevista");

            migrationBuilder.DropColumn(
                name: "EntrevistadoId",
                table: "Entrevista");

            migrationBuilder.DropColumn(
                name: "EntrevistadorId",
                table: "Entrevista");

            migrationBuilder.AddColumn<int>(
                name: "IdEntrevistadoId",
                table: "Entrevista",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdEntrevistadorId",
                table: "Entrevista",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entrevista_IdEntrevistadoId",
                table: "Entrevista",
                column: "IdEntrevistadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrevista_IdEntrevistadorId",
                table: "Entrevista",
                column: "IdEntrevistadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrevista_Entrevistado_IdEntrevistadoId",
                table: "Entrevista",
                column: "IdEntrevistadoId",
                principalTable: "Entrevistado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrevista_Entrevistador_IdEntrevistadorId",
                table: "Entrevista",
                column: "IdEntrevistadorId",
                principalTable: "Entrevistador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
