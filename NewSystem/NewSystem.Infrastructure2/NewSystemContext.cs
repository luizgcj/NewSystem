using Microsoft.EntityFrameworkCore;
using NewSystem.Entity;
using System.Configuration;
using System.Linq;
using System.Reflection;

namespace NewSystem.Infrastructure
{
    public class NewSystemContext : DbContext
    {  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LUIZPC\\SQLEXPRESS;Database=NewSystemDB;Trusted_Connection=true;");
           // "Data Source=LUIZPC\SQLEXPRESS;Initial Catalog=NewSystemDB;User Id=sa;Password=123456;Integrated Security=False;Persist Security Info=True;Multipleactiveresultsets=True;"
            //ConfigurationManager.ConnectionStrings["NewSystemConnectionString"].ConnectionString

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !string.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>));


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<Tributacao> Tributacoes { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<FormaPagto> FormaPagtos { get; set; }
        public DbSet<PlanoPagto> PlanoPagtos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<TipoMovimentacao> TipoMovimentacoes { get; set; }
        public DbSet<MovEstoque> MovEstoques { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }
        public DbSet<ItemMovimentacao> ItemMovimentacoes { get; set; }
        public DbSet<ItemMovimentacaoTributacao> ItemMovimentacaoTributacoes { get; set; }
    }
}
