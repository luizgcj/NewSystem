using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewSystem.Infrastructure.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormaPagtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemMovimentacaoTributacoes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemMovimentacaoId = table.Column<int>(type: "int", nullable: false),
                    TributacaoId = table.Column<int>(type: "int", nullable: false),
                    BaseCalculoBruto = table.Column<double>(type: "float", nullable: false),
                    PercReducaoBase = table.Column<double>(type: "float", nullable: false),
                    BaseCalculo = table.Column<double>(type: "float", nullable: false),
                    VrImposto = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemMovimentacaoTributacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemMovimentacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovimentacaoId = table.Column<int>(type: "int", nullable: false),
                    NumItem = table.Column<int>(type: "int", nullable: false),
                    CFOP = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<double>(type: "float", nullable: false),
                    VrUnitario = table.Column<double>(type: "float", nullable: false),
                    PercDesconto = table.Column<double>(type: "float", nullable: false),
                    VrDesconto = table.Column<double>(type: "float", nullable: false),
                    PercAcrescimo = table.Column<double>(type: "float", nullable: false),
                    VrAcrescimo = table.Column<double>(type: "float", nullable: false),
                    VrTotal = table.Column<double>(type: "float", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemMovimentacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movimentacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<long>(type: "bigint", nullable: false),
                    TipoMovimentacaoId = table.Column<int>(type: "int", nullable: false),
                    CFOP = table.Column<int>(type: "int", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    FormaPagtoId = table.Column<int>(type: "int", nullable: false),
                    PlanoPagtoId = table.Column<int>(type: "int", nullable: false),
                    Cancelada = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanoPagtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumParcelas = table.Column<int>(type: "int", nullable: false),
                    DiasInicial = table.Column<int>(type: "int", nullable: false),
                    DiasIntervalo = table.Column<int>(type: "int", nullable: false),
                    Inativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoPagtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoMovimentacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoMov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaixaEstoque = table.Column<bool>(type: "bit", nullable: false),
                    Fiscal = table.Column<bool>(type: "bit", nullable: false),
                    GeraFinanceiro = table.Column<bool>(type: "bit", nullable: false),
                    Inativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMovimentacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tributacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aliquota = table.Column<double>(type: "float", nullable: false),
                    Inativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tributacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtdeDecimais = table.Column<int>(type: "int", nullable: false),
                    Inativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    CodigoIBGE = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidades_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescricaoResumida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeId = table.Column<int>(type: "int", nullable: false),
                    NCM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrCusto = table.Column<double>(type: "float", nullable: false),
                    PrMedio = table.Column<double>(type: "float", nullable: false),
                    PrVenda = table.Column<double>(type: "float", nullable: false),
                    GrupoId = table.Column<int>(type: "int", nullable: false),
                    IcmsId = table.Column<int>(type: "int", nullable: false),
                    IpiId = table.Column<int>(type: "int", nullable: false),
                    PisId = table.Column<int>(type: "int", nullable: false),
                    CofinsId = table.Column<int>(type: "int", nullable: false),
                    IcmsStId = table.Column<int>(type: "int", nullable: false),
                    IcmsImpId = table.Column<int>(type: "int", nullable: false),
                    PercReducaoBaseIcms = table.Column<double>(type: "float", nullable: false),
                    Inativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produtos_Unidades_UnidadeId",
                        column: x => x.UnidadeId,
                        principalTable: "Unidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<bool>(type: "bit", nullable: false),
                    Fornecedor = table.Column<bool>(type: "bit", nullable: false),
                    Transportadora = table.Column<bool>(type: "bit", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CidadeId = table.Column<int>(type: "int", nullable: false),
                    TipoPessoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CpfCnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RgIE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoas_Cidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovEstoques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<double>(type: "float", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovEstoques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovEstoques_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_EstadoId",
                table: "Cidades",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_MovEstoques_ProdutoId",
                table: "MovEstoques",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_CidadeId",
                table: "Pessoas",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_GrupoId",
                table: "Produtos",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_UnidadeId",
                table: "Produtos",
                column: "UnidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormaPagtos");

            migrationBuilder.DropTable(
                name: "ItemMovimentacaoTributacoes");

            migrationBuilder.DropTable(
                name: "ItemMovimentacoes");

            migrationBuilder.DropTable(
                name: "MovEstoques");

            migrationBuilder.DropTable(
                name: "Movimentacoes");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "PlanoPagtos");

            migrationBuilder.DropTable(
                name: "TipoMovimentacoes");

            migrationBuilder.DropTable(
                name: "Tributacoes");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Unidades");

            migrationBuilder.DropTable(
                name: "Estados");
        }
    }
}
