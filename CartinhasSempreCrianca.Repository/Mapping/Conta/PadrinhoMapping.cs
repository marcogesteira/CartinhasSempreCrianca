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
    public class PadrinhoMapping : IEntityTypeConfiguration<Padrinho>
    {
        public void Configure(EntityTypeBuilder<Padrinho> builder)
        {
            builder.ToTable(nameof(Padrinho));

            builder.HasBaseType<Usuario>();

            builder.Property(x => x.Telefone).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Newsletter).IsRequired();
            builder.Property(x => x.BomPadrinho).IsRequired();
            builder.Property(x => x.Ativo).IsRequired();

        }
    }
}
