// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewSystem.Infrastructure;

namespace NewSystem.Infrastructure.Migrations
{
    [DbContext(typeof(NewSystemContext))]
    [Migration("20220509175159_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewSystem.Entity.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoIBGE")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("NewSystem.Entity.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("NewSystem.Entity.FormaPagto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Inativo")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("FormaPagtos");
                });

            modelBuilder.Entity("NewSystem.Entity.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Inativo")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("NewSystem.Entity.ItemMovimentacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CFOP")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovimentacaoId")
                        .HasColumnType("int");

                    b.Property<int>("NumItem")
                        .HasColumnType("int");

                    b.Property<double>("PercAcrescimo")
                        .HasColumnType("float");

                    b.Property<double>("PercDesconto")
                        .HasColumnType("float");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<double>("Quantidade")
                        .HasColumnType("float");

                    b.Property<double>("VrAcrescimo")
                        .HasColumnType("float");

                    b.Property<double>("VrDesconto")
                        .HasColumnType("float");

                    b.Property<double>("VrTotal")
                        .HasColumnType("float");

                    b.Property<double>("VrUnitario")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ItemMovimentacoes");
                });

            modelBuilder.Entity("NewSystem.Entity.ItemMovimentacaoTributacao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BaseCalculo")
                        .HasColumnType("float");

                    b.Property<double>("BaseCalculoBruto")
                        .HasColumnType("float");

                    b.Property<int>("ItemMovimentacaoId")
                        .HasColumnType("int");

                    b.Property<double>("PercReducaoBase")
                        .HasColumnType("float");

                    b.Property<int>("TributacaoId")
                        .HasColumnType("int");

                    b.Property<double>("VrImposto")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ItemMovimentacaoTributacoes");
                });

            modelBuilder.Entity("NewSystem.Entity.MovEstoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<double>("Quantidade")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("MovEstoques");
                });

            modelBuilder.Entity("NewSystem.Entity.Movimentacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CFOP")
                        .HasColumnType("int");

                    b.Property<bool>("Cancelada")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormaPagtoId")
                        .HasColumnType("int");

                    b.Property<long>("Numero")
                        .HasColumnType("bigint");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<int>("PlanoPagtoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoMovimentacaoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movimentacoes");
                });

            modelBuilder.Entity("NewSystem.Entity.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<bool>("Cliente")
                        .HasColumnType("bit");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CpfCnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Fornecedor")
                        .HasColumnType("bit");

                    b.Property<bool>("Inativo")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RgIE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoPessoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Transportadora")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("NewSystem.Entity.PlanoPagto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiasInicial")
                        .HasColumnType("int");

                    b.Property<int>("DiasIntervalo")
                        .HasColumnType("int");

                    b.Property<bool>("Inativo")
                        .HasColumnType("bit");

                    b.Property<int>("NumParcelas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PlanoPagtos");
                });

            modelBuilder.Entity("NewSystem.Entity.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CofinsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescricaoResumida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GrupoId")
                        .HasColumnType("int");

                    b.Property<int>("IcmsId")
                        .HasColumnType("int");

                    b.Property<int>("IcmsImpId")
                        .HasColumnType("int");

                    b.Property<int>("IcmsStId")
                        .HasColumnType("int");

                    b.Property<bool>("Inativo")
                        .HasColumnType("bit");

                    b.Property<int>("IpiId")
                        .HasColumnType("int");

                    b.Property<string>("NCM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PercReducaoBaseIcms")
                        .HasColumnType("float");

                    b.Property<int>("PisId")
                        .HasColumnType("int");

                    b.Property<double>("PrCusto")
                        .HasColumnType("float");

                    b.Property<double>("PrMedio")
                        .HasColumnType("float");

                    b.Property<double>("PrVenda")
                        .HasColumnType("float");

                    b.Property<int>("UnidadeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.HasIndex("UnidadeId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("NewSystem.Entity.TipoMovimentacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BaixaEstoque")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Fiscal")
                        .HasColumnType("bit");

                    b.Property<bool>("GeraFinanceiro")
                        .HasColumnType("bit");

                    b.Property<bool>("Inativo")
                        .HasColumnType("bit");

                    b.Property<string>("TipoMov")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoMovimentacoes");
                });

            modelBuilder.Entity("NewSystem.Entity.Tributacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Aliquota")
                        .HasColumnType("float");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Inativo")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Tributacoes");
                });

            modelBuilder.Entity("NewSystem.Entity.Unidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Inativo")
                        .HasColumnType("bit");

                    b.Property<int>("QtdeDecimais")
                        .HasColumnType("int");

                    b.Property<string>("Sigla")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Unidades");
                });

            modelBuilder.Entity("NewSystem.Entity.Cidade", b =>
                {
                    b.HasOne("NewSystem.Entity.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("NewSystem.Entity.MovEstoque", b =>
                {
                    b.HasOne("NewSystem.Entity.Produto", null)
                        .WithMany("MovEstoque")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NewSystem.Entity.Pessoa", b =>
                {
                    b.HasOne("NewSystem.Entity.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("NewSystem.Entity.Produto", b =>
                {
                    b.HasOne("NewSystem.Entity.Grupo", "Grupo")
                        .WithMany()
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NewSystem.Entity.Unidade", "Unidade")
                        .WithMany()
                        .HasForeignKey("UnidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grupo");

                    b.Navigation("Unidade");
                });

            modelBuilder.Entity("NewSystem.Entity.Produto", b =>
                {
                    b.Navigation("MovEstoque");
                });
#pragma warning restore 612, 618
        }
    }
}
