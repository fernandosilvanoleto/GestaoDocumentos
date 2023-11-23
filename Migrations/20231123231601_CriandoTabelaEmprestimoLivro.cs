using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoDocumentos.Migrations
{
    public partial class CriandoTabelaEmprestimoLivro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "EmprestimoLivros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmprestimoCH = table.Column<int>(type: "int", nullable: false),
                    EmprestimoId = table.Column<int>(type: "int", nullable: true),
                    IdLivroCH = table.Column<int>(type: "int", nullable: false),
                    LivroId = table.Column<int>(type: "int", nullable: true),
                    DataHoraEmprestimo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDevolucao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuantidadeAlugadaPorLivro = table.Column<int>(type: "int", nullable: false),
                    PrecoUnitarioAlugado = table.Column<float>(type: "real", nullable: false),
                    Anotacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    SituacaoAtual = table.Column<int>(type: "int", nullable: false),
                    GerouMulta = table.Column<bool>(type: "bit", nullable: false),
                    ValorMultaGerada = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmprestimoLivros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmprestimoLivros_Emprestimos_EmprestimoId",
                        column: x => x.EmprestimoId,
                        principalTable: "Emprestimos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmprestimoLivros_Livros_LivroId",
                        column: x => x.LivroId,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmprestimoLivros_EmprestimoId",
                table: "EmprestimoLivros",
                column: "EmprestimoId");

            migrationBuilder.CreateIndex(
                name: "IX_EmprestimoLivros_LivroId",
                table: "EmprestimoLivros",
                column: "LivroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmprestimoLivros");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
