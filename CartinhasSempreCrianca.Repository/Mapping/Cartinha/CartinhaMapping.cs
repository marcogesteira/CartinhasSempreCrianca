using CartinhasSempreCrianca.Domain.Cartinha;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Repository.Mapping.Cartinha
{
    public class CartinhaMapping : IEntityTypeConfiguration<Domain.Cartinha.Cartinha>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Domain.Cartinha.Cartinha> builder)
        {
            builder.ToTable(nameof(Domain.Cartinha.Cartinha));

            builder.HasKey(d => d.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Disponivel).IsRequired();
            builder.Property(x => x.Numero).IsRequired();
            builder.Property(x => x.Ano).IsRequired();
            builder.Property(x => x.Desenho).IsRequired().HasMaxLength(1024);

        }
    }
}
