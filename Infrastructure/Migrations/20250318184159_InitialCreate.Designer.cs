﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250318184159_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Bloquear")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_bloquear");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_cidade");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_cpfcgc");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_email");

                    b.Property<long>("EmpresaId")
                        .HasColumnType("bigint")
                        .HasColumnName("emp_id");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_endereco");

                    b.Property<string>("Fone")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_fone");

                    b.Property<long?>("IdInterno")
                        .HasColumnType("bigint")
                        .HasColumnName("cli_idinterno");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_nome");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_nfantasia");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_uf");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Empresa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying")
                        .HasColumnName("emp_cpfcgc");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying")
                        .HasColumnName("emp_nome");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying")
                        .HasColumnName("emp_nfantasia");

                    b.HasKey("Id");

                    b.ToTable("Empresas", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Fpagamento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying")
                        .HasColumnName("fpa_codigo");

                    b.Property<string>("DescrAbreviada")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("character varying")
                        .HasColumnName("fpa_descrabreviada");

                    b.Property<long>("EmpresaId")
                        .HasColumnType("bigint")
                        .HasColumnName("emp_id");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Fpagamentos", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Item", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("mb2_observacao");

                    b.Property<long>("PedidoId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProdutoId")
                        .HasColumnType("bigint")
                        .HasColumnName("mb2_produto");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("numeric(10,3)")
                        .HasColumnName("mb2_quantidade");

                    b.Property<decimal>("ValorDesconto")
                        .HasColumnType("numeric(10,2)")
                        .HasColumnName("mb2_valor_desconto");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("numeric(10,2)")
                        .HasColumnName("mb2_valor_unitario");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("Mb2PedItens", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("ClienteId")
                        .HasColumnType("bigint")
                        .HasColumnName("mb1_cliente");

                    b.Property<DateTime>("Data")
                        .HasColumnType("date")
                        .HasColumnName("mb1_data");

                    b.Property<long>("EmpresaId")
                        .HasColumnType("bigint")
                        .HasColumnName("emp_id");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("character varying")
                        .HasColumnName("mb1_observacao");

                    b.Property<string>("Pagamento")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("mb1_pagamento");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint")
                        .HasColumnName("mb1_usuario");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Mb1PedCab", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Produto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<decimal>("DescontoMaximo")
                        .HasColumnType("numeric(10,2)")
                        .HasColumnName("desconto_maximo");

                    b.Property<long>("EmpresaId")
                        .HasColumnType("bigint")
                        .HasColumnName("emp_id");

                    b.Property<string>("Grupo")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying")
                        .HasColumnName("pro_grupo");

                    b.Property<long?>("IdInerno")
                        .HasColumnType("bigint")
                        .HasColumnName("sic_seqinternabd");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying")
                        .HasColumnName("pro_imagem");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying")
                        .HasColumnName("pro_marca");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying")
                        .HasColumnName("pro_nome");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("numeric(28,4)")
                        .HasColumnName("pro_saldo");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Produtos", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<decimal>("DescontoMaximo")
                        .HasColumnType("numeric(10,2)")
                        .HasColumnName("desconto_maximo");

                    b.Property<long>("EmpresaId")
                        .HasColumnType("bigint")
                        .HasColumnName("emp_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying")
                        .HasColumnName("usu_nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying")
                        .HasColumnName("usu_senha");

                    b.Property<long?>("SicSegmentoId")
                        .HasColumnType("bigint")
                        .HasColumnName("sic_seqinternabd");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Usuarios", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.HasOne("Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Domain.Entities.Fpagamento", b =>
                {
                    b.HasOne("Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Domain.Entities.Item", b =>
                {
                    b.HasOne("Domain.Entities.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.HasOne("Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Domain.Entities.Produto", b =>
                {
                    b.HasOne("Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.HasOne("Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });
#pragma warning restore 612, 618
        }
    }
}
