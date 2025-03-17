using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Mb1PedCabs { get; set; }
        public DbSet<Item> Mb2PedItens { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Fpagamento> Fpagamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.ToTable("Empresas");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Nome)
                    .HasColumnName("emp_nome")
                    .HasColumnType("character varying")
                    .HasMaxLength(60);

                entity.Property(e => e.NomeFantasia)
                    .HasColumnName("emp_nfantasia")
                    .HasColumnType("character varying")
                    .HasMaxLength(60);

                entity.Property(e => e.CpfCnpj)
                    .HasColumnName("emp_cpfcgc")
                    .HasColumnType("character varying")
                    .HasMaxLength(18);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Clientes");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Nome)
                    .HasColumnName("cli_nome")
                    .HasColumnType("character varying")
                    .HasMaxLength(60);

                entity.Property(e => e.NomeFantasia)
                    .HasColumnName("cli_nfantasia")
                    .HasColumnType("character varying")
                    .HasMaxLength(60);

                entity.Property(e => e.CpfCnpj)
                    .HasColumnName("cli_cpfcgc")
                    .HasColumnType("character varying")
                    .HasMaxLength(18);

                entity.Property(e => e.Endereco)
                    .HasColumnName("cli_endereco")
                    .HasColumnType("character varying")
                    .HasMaxLength(60);

                entity.Property(e => e.Fone)
                    .HasColumnName("cli_fone")
                    .HasColumnType("character varying")
                    .HasMaxLength(14);

                entity.Property(e => e.Email)
                    .HasColumnName("cli_email")
                    .HasColumnType("character varying")
                    .HasMaxLength(120);

                entity.Property(e => e.Cidade)
                    .HasColumnName("cli_cidade")
                    .HasColumnType("character varying")
                    .HasMaxLength(60);

                entity.Property(e => e.Uf)
                    .HasColumnName("cli_uf")
                    .HasColumnType("character varying")
                    .HasMaxLength(2);

                entity.Property(e => e.Bloquear)
                    .HasColumnName("cli_bloquear")
                    .HasColumnType("character varying")
                    .HasMaxLength(2);

                entity.Property(e => e.IdInterno)
                    .HasColumnName("cli_idinterno");

                entity.Property(e => e.EmpresaId)
                    .HasColumnName("emp_id");

                entity.HasOne(e => e.Empresa)
                    .WithMany()
                    .HasForeignKey(e => e.EmpresaId);
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("Produtos");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Nome)
                    .HasColumnName("pro_nome")
                    .HasColumnType("character varying")
                    .HasMaxLength(200);

                entity.Property(e => e.Marca)
                    .HasColumnName("pro_marca")
                    .HasColumnType("character varying")
                    .HasMaxLength(30);

                entity.Property(e => e.Grupo)
                    .HasColumnName("pro_grupo")
                    .HasColumnType("character varying")
                    .HasMaxLength(40);

                entity.Property(e => e.Saldo)
                    .HasColumnName("pro_saldo")
                    .HasColumnType("numeric(28,4)");

                entity.Property(e => e.DescontoMaximo)
                    .HasColumnName("desconto_maximo")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Imagem)
                    .HasColumnName("pro_imagem")
                    .HasColumnType("character varying")
                    .HasMaxLength(200);

                entity.Property(e => e.IdInerno)
                    .HasColumnName("sic_seqinternabd");

                entity.Property(e => e.EmpresaId)
                    .HasColumnName("emp_id");

                entity.HasOne(e => e.Empresa)
                    .WithMany()
                    .HasForeignKey(e => e.EmpresaId);
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.ToTable("Mb1PedCab");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("mb1_usuario");

                entity.Property(e => e.ClienteId)
                    .HasColumnName("mb1_cliente");

                entity.Property(e => e.Data)
                    .HasColumnName("mb1_data")
                    .HasColumnType("date");

                entity.Property(e => e.Pagamento)
                    .HasColumnName("mb1_pagamento")
                    .HasColumnType("bit")
                    .HasMaxLength(2);

                entity.Property(e => e.Observacao)
                    .HasColumnName("mb1_observacao")
                    .HasColumnType("character varying")
                    .HasMaxLength(5000);

                entity.Property(e => e.EmpresaId)
                    .HasColumnName("emp_id");

                entity.HasOne(e => e.Empresa)
                    .WithMany()
                    .HasForeignKey(e => e.EmpresaId);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("Mb2PedItens");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.ProdutoId)
                    .HasColumnName("mb2_produto");

                entity.Property(e => e.Quantidade)
                    .HasColumnName("mb2_quantidade")
                    .HasColumnType("numeric(10,3)");

                entity.Property(e => e.ValorUnitario)
                    .HasColumnName("mb2_valor_unitario")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ValorDesconto)
                    .HasColumnName("mb2_valor_desconto")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Observacao)
                    .HasColumnName("mb2_observacao")
                    .HasColumnType("character varying")
                    .HasMaxLength(255);

                entity.HasOne(e => e.Pedido)
                    .WithMany()
                    .HasForeignKey(e => e.PedidoId);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuarios");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Nome)
                    .HasColumnName("usu_nome")
                    .HasColumnType("character varying")
                    .HasMaxLength(30);

                entity.Property(e => e.Senha)
                    .HasColumnName("usu_senha")
                    .HasColumnType("character varying")
                    .HasMaxLength(100);

                entity.Property(e => e.DescontoMaximo)
                    .HasColumnName("desconto_maximo")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.SicSegmentoId)
                    .HasColumnName("sic_seqinternabd");

                entity.Property(e => e.EmpresaId)
                    .HasColumnName("emp_id");

                entity.HasOne(e => e.Empresa)
                    .WithMany()
                    .HasForeignKey(e => e.EmpresaId);
            });

            modelBuilder.Entity<Fpagamento>(entity =>
            {
                entity.ToTable("Fpagamentos");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Codigo)
                    .HasColumnName("fpa_codigo")
                    .HasColumnType("character varying")
                    .HasMaxLength(2);

                entity.Property(e => e.DescrAbreviada)
                    .HasColumnName("fpa_descrabreviada")
                    .HasColumnType("character varying")
                    .HasMaxLength(16);

                entity.Property(e => e.EmpresaId)
                    .HasColumnName("emp_id");

                entity.HasOne(e => e.Empresa)
                    .WithMany()
                    .HasForeignKey(e => e.EmpresaId);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
