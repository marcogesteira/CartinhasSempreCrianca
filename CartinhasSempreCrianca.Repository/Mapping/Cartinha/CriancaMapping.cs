using CartinhasSempreCrianca.Domain.Cartinha;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartinhasSempreCrianca.Repository.Mapping.Cartinha
{
    public class CriancaMapping : IEntityTypeConfiguration<Crianca>
    {
        public void Configure(EntityTypeBuilder<Crianca> builder)
        {
            builder.ToTable(nameof(Crianca));
            
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Idade).IsRequired();

            builder.HasMany<Domain.Cartinha.Cartinha>(x => x.Cartinhas).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}
