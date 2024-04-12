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
    public class ModeradorMapping : IEntityTypeConfiguration<Moderador>
    {
        public void Configure(EntityTypeBuilder<Moderador> builder)
        {
            builder.ToTable(nameof(Moderador));

            builder.HasBaseType<Usuario>();

            builder.Property(x => x.Ativo).IsRequired();

        }
    }
}
