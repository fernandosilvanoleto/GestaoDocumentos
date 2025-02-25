﻿// <auto-generated />
using System;
using GestaoDocumentos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestaoDocumentos.Migrations
{
    [DbContext(typeof(BancoContext))]
    [Migration("20250218225149_CorrigirChavesEmprestimoLivro")]
    partial class CorrigirChavesEmprestimoLivro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GestaoDocumentos.Models.BibliotecarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bilbiotecarios");
                });

            modelBuilder.Entity("GestaoDocumentos.Models.ClienteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("GestaoDocumentos.Models.DocumentoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Documentos");
                });

            modelBuilder.Entity("GestaoDocumentos.Models.EmprestimoLivroModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Anotacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraEmprestimo")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmprestimoId")
                        .HasColumnType("int");

                    b.Property<bool>("GerouMulta")
                        .HasColumnType("bit");

                    b.Property<int>("IdEmprestimoCH")
                        .HasColumnType("int");

                    b.Property<int>("IdLivroCH")
                        .HasColumnType("int");

                    b.Property<int?>("LivroId")
                        .HasColumnType("int");

                    b.Property<float>("PrecoUnitarioAlugado")
                        .HasColumnType("real");

                    b.Property<int>("QuantidadeAlugadaPorLivro")
                        .HasColumnType("int");

                    b.Property<int>("SituacaoAtual")
                        .HasColumnType("int");

                    b.Property<float?>("ValorMultaGerada")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("EmprestimoId");

                    b.HasIndex("LivroId");

                    b.ToTable("EmprestimoLivros");
                });

            modelBuilder.Entity("GestaoDocumentos.Models.EmprestimoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int?>("BibliotecarioId")
                        .HasColumnType("int");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdBibliotecarioCH")
                        .HasColumnType("int");

                    b.Property<int>("IdClienteCH")
                        .HasColumnType("int");

                    b.Property<string>("NomePersonalizado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusEmprestimo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BibliotecarioId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Emprestimos");
                });

            modelBuilder.Entity("GestaoDocumentos.Models.LivroModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ArquivoFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PrecoUnitario")
                        .HasColumnType("real");

                    b.Property<int>("QuantidadeEstoque")
                        .HasColumnType("int");

                    b.Property<int>("StatusLivro")
                        .HasColumnType("int");

                    b.Property<int>("TipoLivro")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("GestaoDocumentos.Models.EmprestimoLivroModel", b =>
                {
                    b.HasOne("GestaoDocumentos.Models.EmprestimoModel", "Emprestimo")
                        .WithMany("LivrosEmprestados")
                        .HasForeignKey("EmprestimoId");

                    b.HasOne("GestaoDocumentos.Models.LivroModel", "Livro")
                        .WithMany("LivrosEmprestados")
                        .HasForeignKey("LivroId");

                    b.Navigation("Emprestimo");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("GestaoDocumentos.Models.EmprestimoModel", b =>
                {
                    b.HasOne("GestaoDocumentos.Models.BibliotecarioModel", "Bibliotecario")
                        .WithMany("Emprestimos")
                        .HasForeignKey("BibliotecarioId");

                    b.HasOne("GestaoDocumentos.Models.ClienteModel", "Cliente")
                        .WithMany("Emprestimos")
                        .HasForeignKey("ClienteId");

                    b.Navigation("Bibliotecario");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("GestaoDocumentos.Models.BibliotecarioModel", b =>
                {
                    b.Navigation("Emprestimos");
                });

            modelBuilder.Entity("GestaoDocumentos.Models.ClienteModel", b =>
                {
                    b.Navigation("Emprestimos");
                });

            modelBuilder.Entity("GestaoDocumentos.Models.EmprestimoModel", b =>
                {
                    b.Navigation("LivrosEmprestados");
                });

            modelBuilder.Entity("GestaoDocumentos.Models.LivroModel", b =>
                {
                    b.Navigation("LivrosEmprestados");
                });
#pragma warning restore 612, 618
        }
    }
}
