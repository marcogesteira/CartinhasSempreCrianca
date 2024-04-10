using CartinhasSempreCrianca.Domain.Apadrinhamento;
using CartinhasSempreCrianca.Domain.Cartinha;
using CartinhasSempreCrianca.Domain.Conta;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Repository
{
    public class CartinhasSempreCriancaContext : DbContext
    {
        public DbSet<Cartinha> Cartinhas {  get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Diretor> Diretores { get; set; }
        public DbSet<Crianca> Criancas { get; set;}
        public DbSet<Padrinho> Padrinhos { get; set; }
        public DbSet<Moderador> Moderadores { get; set;}
        public DbSet<LocalDeRecolhimento> LocaisDeRecolhimento { get; set; }
        public DbSet<Apadrinhamento> Apadrinhamentos { get; set; }

        public CartinhasSempreCriancaContext(DbContextOptions<CartinhasSempreCriancaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CartinhasSempreCriancaContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(LoggerFactory.Create(x => x.AddConsole()));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
