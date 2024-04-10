using CartinhasSempreCrianca.Domain.Apadrinhamento;
using CartinhasSempreCrianca.Domain.Cartinha;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Repository.Mapping.Apadrinhamento
{
    public class ApadrinhamentoMapping : IEntityTypeConfiguration<Domain.Apadrinhamento.Apadrinhamento>
    {
        public void Configure(EntityTypeBuilder<Domain.Apadrinhamento.Apadrinhamento> builder)
        {
            builder.ToTable(nameof(Domain.Apadrinhamento.Apadrinhamento));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Data).IsRequired();
            builder.Property(x => x.Prazo).IsRequired();

            builder.HasMany<Domain.Cartinha.Cartinha>(x => x.Cartinhas).WithOne();
            builder.HasMany<LocalDeRecolhimento>(x => x.LocaisDeRecolhimento).WithOne();

        }
    }
}
