using CartinhasSempreCrianca.Domain.Conta;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Repository.Mapping.Conta
{
    public class ModeradorRepository : IEntityTypeConfiguration<Moderador>
    {
        public void Configure(EntityTypeBuilder<Moderador> builder)
        {
            builder.ToTable(nameof(Moderador));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Senha).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Ativo).IsRequired();

        }
    }
}
