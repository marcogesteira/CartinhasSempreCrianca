using CartinhasSempreCrianca.Domain.Apadrinhamento;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Repository.Mapping.Apadrinhamento
{
    public class LocalDeRecolhimentoMapping : IEntityTypeConfiguration<LocalDeRecolhimento>
    {
        public void Configure(EntityTypeBuilder<LocalDeRecolhimento> builder)
        {
            builder.ToTable(nameof(LocalDeRecolhimento));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Endereco).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Regiao).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Telefone).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Horario).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Ativo).IsRequired();

        }
    }
}
