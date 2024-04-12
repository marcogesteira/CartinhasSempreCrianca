using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CartinhasSempreCrianca.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diretor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diretor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instituicao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DiretorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instituicao_Diretor_DiretorId",
                        column: x => x.DiretorId,
                        principalTable: "Diretor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apadrinhamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prazo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PadrinhoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apadrinhamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apadrinhamento_Usuario_PadrinhoId",
                        column: x => x.PadrinhoId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Moderador",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moderador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moderador_Usuario_Id",
                        column: x => x.Id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Padrinho",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Newsletter = table.Column<bool>(type: "bit", nullable: false),
                    BomPadrinho = table.Column<bool>(type: "bit", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Padrinho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Padrinho_Usuario_Id",
                        column: x => x.Id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Crianca",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    InstituicaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crianca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Crianca_Instituicao_InstituicaoId",
                        column: x => x.InstituicaoId,
                        principalTable: "Instituicao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocalDeRecolhimento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Regiao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Horario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    ApadrinhamentoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalDeRecolhimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocalDeRecolhimento_Apadrinhamento_ApadrinhamentoId",
                        column: x => x.ApadrinhamentoId,
                        principalTable: "Apadrinhamento",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cartinha",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Pedido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ano = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Desenho = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    ApadrinhamentoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CriancaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cartinha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cartinha_Apadrinhamento_ApadrinhamentoId",
                        column: x => x.ApadrinhamentoId,
                        principalTable: "Apadrinhamento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cartinha_Crianca_CriancaId",
                        column: x => x.CriancaId,
                        principalTable: "Crianca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apadrinhamento_PadrinhoId",
                table: "Apadrinhamento",
                column: "PadrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cartinha_ApadrinhamentoId",
                table: "Cartinha",
                column: "ApadrinhamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cartinha_CriancaId",
                table: "Cartinha",
                column: "CriancaId");

            migrationBuilder.CreateIndex(
                name: "IX_Crianca_InstituicaoId",
                table: "Crianca",
                column: "InstituicaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Instituicao_DiretorId",
                table: "Instituicao",
                column: "DiretorId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalDeRecolhimento_ApadrinhamentoId",
                table: "LocalDeRecolhimento",
                column: "ApadrinhamentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cartinha");

            migrationBuilder.DropTable(
                name: "LocalDeRecolhimento");

            migrationBuilder.DropTable(
                name: "Moderador");

            migrationBuilder.DropTable(
                name: "Padrinho");

            migrationBuilder.DropTable(
                name: "Crianca");

            migrationBuilder.DropTable(
                name: "Apadrinhamento");

            migrationBuilder.DropTable(
                name: "Instituicao");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Diretor");
        }
    }
}
