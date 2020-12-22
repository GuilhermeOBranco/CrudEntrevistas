using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoEstags.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrevista_Entrevistador_EntrevistadorId",
                table: "Entrevista");

            migrationBuilder.DropColumn(
                name: "IdEntrevistado",
                table: "Entrevista");

            migrationBuilder.DropColumn(
                name: "IdEntrevistador",
                table: "Entrevista");

            migrationBuilder.RenameColumn(
                name: "EntrevistadorId",
                table: "Entrevista",
                newName: "IdEntrevistadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrevista_EntrevistadorId",
                table: "Entrevista",
                newName: "IX_Entrevista_IdEntrevistadorId");

            migrationBuilder.AddColumn<int>(
                name: "IdEntrevistadoId",
                table: "Entrevista",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entrevista_IdEntrevistadoId",
                table: "Entrevista",
                column: "IdEntrevistadoId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IdEntrevistadoId",
                table: "Entrevista");

            migrationBuilder.RenameColumn(
                name: "IdEntrevistadorId",
                table: "Entrevista",
                newName: "EntrevistadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrevista_IdEntrevistadorId",
                table: "Entrevista",
                newName: "IX_Entrevista_EntrevistadorId");

            migrationBuilder.AddColumn<int>(
                name: "IdEntrevistado",
                table: "Entrevista",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEntrevistador",
                table: "Entrevista",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrevista_Entrevistador_EntrevistadorId",
                table: "Entrevista",
                column: "EntrevistadorId",
                principalTable: "Entrevistador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
