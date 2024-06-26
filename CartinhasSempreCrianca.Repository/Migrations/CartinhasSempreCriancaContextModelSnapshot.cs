﻿// <auto-generated />
using System;
using CartinhasSempreCrianca.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CartinhasSempreCrianca.Repository.Migrations
{
    [DbContext(typeof(CartinhasSempreCriancaContext))]
    partial class CartinhasSempreCriancaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Apadrinhamento.Apadrinhamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PadrinhoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Prazo")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PadrinhoId");

                    b.ToTable("Apadrinhamento", (string)null);
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Apadrinhamento.LocalDeRecolhimento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ApadrinhamentoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Horario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Regiao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ApadrinhamentoId");

                    b.ToTable("LocalDeRecolhimento", (string)null);
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Cartinha.Cartinha", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Ano")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ApadrinhamentoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CriancaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Desenho")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Pedido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApadrinhamentoId");

                    b.HasIndex("CriancaId");

                    b.ToTable("Cartinha", (string)null);
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Cartinha.Crianca", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<Guid?>("InstituicaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("InstituicaoId");

                    b.ToTable("Crianca", (string)null);
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Cartinha.Diretor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Diretor", (string)null);
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Cartinha.Instituicao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<Guid>("DiretorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("DiretorId");

                    b.ToTable("Instituicao", (string)null);
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Conta.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Conta.Moderador", b =>
                {
                    b.HasBaseType("CartinhasSempreCrianca.Domain.Conta.Usuario");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.ToTable("Moderador", (string)null);
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Conta.Padrinho", b =>
                {
                    b.HasBaseType("CartinhasSempreCrianca.Domain.Conta.Usuario");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<bool>("BomPadrinho")
                        .HasColumnType("bit");

                    b.Property<bool>("Newsletter")
                        .HasColumnType("bit");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.ToTable("Padrinho", (string)null);
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Apadrinhamento.Apadrinhamento", b =>
                {
                    b.HasOne("CartinhasSempreCrianca.Domain.Conta.Usuario", "Padrinho")
                        .WithMany()
                        .HasForeignKey("PadrinhoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Padrinho");
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Apadrinhamento.LocalDeRecolhimento", b =>
                {
                    b.HasOne("CartinhasSempreCrianca.Domain.Apadrinhamento.Apadrinhamento", null)
                        .WithMany("LocaisDeRecolhimento")
                        .HasForeignKey("ApadrinhamentoId");
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Cartinha.Cartinha", b =>
                {
                    b.HasOne("CartinhasSempreCrianca.Domain.Apadrinhamento.Apadrinhamento", null)
                        .WithMany("Cartinhas")
                        .HasForeignKey("ApadrinhamentoId");

                    b.HasOne("CartinhasSempreCrianca.Domain.Cartinha.Crianca", null)
                        .WithMany("Cartinhas")
                        .HasForeignKey("CriancaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Cartinha.Crianca", b =>
                {
                    b.HasOne("CartinhasSempreCrianca.Domain.Cartinha.Instituicao", null)
                        .WithMany("Criancas")
                        .HasForeignKey("InstituicaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Cartinha.Instituicao", b =>
                {
                    b.HasOne("CartinhasSempreCrianca.Domain.Cartinha.Diretor", "Diretor")
                        .WithMany()
                        .HasForeignKey("DiretorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diretor");
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Conta.Moderador", b =>
                {
                    b.HasOne("CartinhasSempreCrianca.Domain.Conta.Usuario", null)
                        .WithOne()
                        .HasForeignKey("CartinhasSempreCrianca.Domain.Conta.Moderador", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Conta.Padrinho", b =>
                {
                    b.HasOne("CartinhasSempreCrianca.Domain.Conta.Usuario", null)
                        .WithOne()
                        .HasForeignKey("CartinhasSempreCrianca.Domain.Conta.Padrinho", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Apadrinhamento.Apadrinhamento", b =>
                {
                    b.Navigation("Cartinhas");

                    b.Navigation("LocaisDeRecolhimento");
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Cartinha.Crianca", b =>
                {
                    b.Navigation("Cartinhas");
                });

            modelBuilder.Entity("CartinhasSempreCrianca.Domain.Cartinha.Instituicao", b =>
                {
                    b.Navigation("Criancas");
                });
#pragma warning restore 612, 618
        }
    }
}
