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
    public class InstituicaoMapping : IEntityTypeConfiguration<Instituicao>
    {
        public void Configure(EntityTypeBuilder<Instituicao> builder)
        {
            builder.ToTable(nameof(Instituicao));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Ativo).IsRequired();

            builder.HasOne<Diretor>(x => x.Diretor);

            builder.HasMany<Crianca>(x => x.Criancas).WithOne().OnDelete(DeleteBehavior.Cascade);


        }
    }
}
