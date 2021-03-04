using Microsoft.EntityFrameworkCore.Migrations;

namespace Minha1Conexao.Data.Migrations
{
    public partial class AlunoMapCorrect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdTurma",
                table: "Aluno",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_IdTurma",
                table: "Aluno",
                column: "IdTurma");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Turma_IdTurma",
                table: "Aluno",
                column: "IdTurma",
                principalTable: "Turma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Turma_IdTurma",
                table: "Aluno");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_IdTurma",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "IdTurma",
                table: "Aluno");
        }
    }
}
