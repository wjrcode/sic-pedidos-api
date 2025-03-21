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
    [Migration("20250321134349_InitialCreation")]
    partial class InitialCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Clientes", b =>
                {
                    b.Property<long>("Cli_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Cli_id"));

                    b.Property<string>("Cli_bloquear")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_bloquear");

                    b.Property<string>("Cli_cidade")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_cidade");

                    b.Property<string>("Cli_cpfcgc")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_cpfcgc");

                    b.Property<string>("Cli_email")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_email");

                    b.Property<string>("Cli_endereco")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_endereco");

                    b.Property<string>("Cli_fone")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_fone");

                    b.Property<long>("Cli_idinterno")
                        .HasColumnType("bigint")
                        .HasColumnName("cli_idinterno");

                    b.Property<string>("Cli_nfantasia")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_nfantasia");

                    b.Property<string>("Cli_nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_nome");

                    b.Property<string>("Cli_uf")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying")
                        .HasColumnName("cli_uf");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<long>("Emp_id")
                        .HasColumnType("bigint")
                        .HasColumnName("emp_id");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Cli_id");

                    b.HasIndex("Emp_id");

                    b.ToTable("clientes", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Dispositivos", b =>
                {
                    b.Property<long>("Dis_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Dis_id"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Dis_modelo")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying")
                        .HasColumnName("dis_modelo");

                    b.Property<string>("Dis_plataforma")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying")
                        .HasColumnName("dis_plataforma");

                    b.Property<bool>("Dis_status")
                        .HasColumnType("boolean")
                        .HasColumnName("dis_status");

                    b.Property<string>("Dis_ultusuario")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying")
                        .HasColumnName("dis_ultusuario");

                    b.Property<Guid>("Dis_uuid")
                        .HasColumnType("uuid")
                        .HasColumnName("dis_uuid");

                    b.Property<string>("Dis_uuiddispositivo")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("character varying")
                        .HasColumnName("dis_uuiddispositivo");

                    b.Property<string>("Dis_versao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying")
                        .HasColumnName("dis_versao");

                    b.Property<long>("Emp_id")
                        .HasColumnType("bigint")
                        .HasColumnName("emp_id");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Dis_id");

                    b.HasIndex("Emp_id");

                    b.ToTable("dispositivos", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Empresas", b =>
                {
                    b.Property<long>("Emp_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Emp_id"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("Emp_ativ")
                        .HasColumnType("boolean")
                        .HasColumnName("emp_ativ");

                    b.Property<Guid>("Emp_chavecentralizador")
                        .HasColumnType("uuid")
                        .HasColumnName("emp_chavecentralizador");

                    b.Property<Guid>("Emp_chavedispositivo")
                        .HasColumnType("uuid")
                        .HasColumnName("emp_chavedispositivo");

                    b.Property<string>("Emp_cpfcgc")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying")
                        .HasColumnName("emp_cpfcgc");

                    b.Property<string>("Emp_nfantasia")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying")
                        .HasColumnName("emp_nfantasia");

                    b.Property<string>("Emp_nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying")
                        .HasColumnName("emp_nome");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Emp_id");

                    b.ToTable("empresas", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Fpagamentos", b =>
                {
                    b.Property<long>("Fpa_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Fpa_id"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<long>("Emp_id")
                        .HasColumnType("bigint")
                        .HasColumnName("emp_id");

                    b.Property<string>("Fpa_codigo")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying")
                        .HasColumnName("fpa_codigo");

                    b.Property<string>("Fpa_descrabreviada")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("character varying")
                        .HasColumnName("fpa_descrabreviada");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Fpa_id");

                    b.HasIndex("Emp_id");

                    b.ToTable("fpagamentos", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Ljusuarios", b =>
                {
                    b.Property<long>("Lju_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Lju_id"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<long>("Emp_id")
                        .HasColumnType("bigint")
                        .HasColumnName("emp_id");

                    b.Property<string>("Lju_psdsh")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying")
                        .HasColumnName("lju_psdsh");

                    b.Property<string>("Lju_pwusuario")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying")
                        .HasColumnName("lju_pwusuario");

                    b.Property<long>("Sic_seqinternabd")
                        .HasColumnType("bigint")
                        .HasColumnName("sic_seqinternabd");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<decimal>("Ven_desconto")
                        .HasColumnType("numeric(10,2)")
                        .HasColumnName("ven_desconto");

                    b.HasKey("Lju_id");

                    b.HasIndex("Emp_id");

                    b.ToTable("ljusuarios", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Mb1pedcab", b =>
                {
                    b.Property<long>("Mb1_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Mb1_id"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<long>("Emp_id")
                        .HasColumnType("bigint")
                        .HasColumnName("emp_id");

                    b.Property<long>("Mb1_cliente")
                        .HasColumnType("bigint")
                        .HasColumnName("mb1_cliente");

                    b.Property<DateTime>("Mb1_data")
                        .HasColumnType("date")
                        .HasColumnName("mb1_data");

                    b.Property<string>("Mb1_observacao")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("character varying")
                        .HasColumnName("mb1_observacao");

                    b.Property<string>("Mb1_pagamento")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying")
                        .HasColumnName("mb1_pagamento");

                    b.Property<long>("Mb1_usuario")
                        .HasColumnType("bigint")
                        .HasColumnName("mb1_usuario");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Mb1_id");

                    b.HasIndex("Emp_id");

                    b.HasIndex("Mb1_cliente");

                    b.ToTable("mb1pedcab", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Mb2peditens", b =>
                {
                    b.Property<long>("Mb2_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Mb2_id"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Mb2_observacao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("mb2_observacao");

                    b.Property<long>("Mb2_produto")
                        .HasColumnType("bigint")
                        .HasColumnName("mb2_produto");

                    b.Property<decimal>("Mb2_quantidade")
                        .HasColumnType("numeric(10,3)")
                        .HasColumnName("mb2_quantidade");

                    b.Property<decimal>("Mb2_valor_desconto")
                        .HasColumnType("numeric(10,2)")
                        .HasColumnName("mb2_valor_desconto");

                    b.Property<decimal>("Mb2_valor_unitario")
                        .HasColumnType("numeric(10,2)")
                        .HasColumnName("mb2_valor_unitario");

                    b.Property<long>("Pedido_id")
                        .HasColumnType("bigint")
                        .HasColumnName("pedido_id");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Mb2_id");

                    b.HasIndex("Mb2_produto");

                    b.HasIndex("Pedido_id");

                    b.ToTable("mb2peditens", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Produtos", b =>
                {
                    b.Property<long>("Pro_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Pro_id"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<decimal>("Desconto_maximo")
                        .HasColumnType("numeric(10,2)")
                        .HasColumnName("desconto_maximo");

                    b.Property<long>("Emp_id")
                        .HasColumnType("bigint")
                        .HasColumnName("emp_id");

                    b.Property<string>("Pro_grupo")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying")
                        .HasColumnName("pro_grupo");

                    b.Property<string>("Pro_imagem")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying")
                        .HasColumnName("pro_imagem");

                    b.Property<string>("Pro_marca")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying")
                        .HasColumnName("pro_marca");

                    b.Property<string>("Pro_nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying")
                        .HasColumnName("pro_nome");

                    b.Property<decimal>("Pro_saldo")
                        .HasColumnType("numeric(28,4)")
                        .HasColumnName("pro_saldo");

                    b.Property<long>("Sic_seqintermabd")
                        .HasColumnType("bigint")
                        .HasColumnName("sic_seqinternabd");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Pro_id");

                    b.HasIndex("Emp_id");

                    b.ToTable("produtos", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Clientes", b =>
                {
                    b.HasOne("Domain.Entities.Empresas", "Empresa")
                        .WithMany()
                        .HasForeignKey("Emp_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Domain.Entities.Dispositivos", b =>
                {
                    b.HasOne("Domain.Entities.Empresas", "Empresa")
                        .WithMany()
                        .HasForeignKey("Emp_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Domain.Entities.Fpagamentos", b =>
                {
                    b.HasOne("Domain.Entities.Empresas", "Empresa")
                        .WithMany()
                        .HasForeignKey("Emp_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Domain.Entities.Ljusuarios", b =>
                {
                    b.HasOne("Domain.Entities.Empresas", "Empresa")
                        .WithMany()
                        .HasForeignKey("Emp_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Domain.Entities.Mb1pedcab", b =>
                {
                    b.HasOne("Domain.Entities.Empresas", "Empresa")
                        .WithMany()
                        .HasForeignKey("Emp_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Clientes", "Cliente")
                        .WithMany()
                        .HasForeignKey("Mb1_cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Domain.Entities.Mb2peditens", b =>
                {
                    b.HasOne("Domain.Entities.Produtos", "Produto")
                        .WithMany()
                        .HasForeignKey("Mb2_produto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Mb1pedcab", "Pedido")
                        .WithMany()
                        .HasForeignKey("Pedido_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Domain.Entities.Produtos", b =>
                {
                    b.HasOne("Domain.Entities.Empresas", "Empresa")
                        .WithMany()
                        .HasForeignKey("Emp_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });
#pragma warning restore 612, 618
        }
    }
}
