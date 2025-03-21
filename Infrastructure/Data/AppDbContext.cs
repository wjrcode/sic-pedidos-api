using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Dispositivos> Dispositivos { get; set; }
        public DbSet<Empresas> Empresas { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Mb1pedcab> Mb1PedCabs { get; set; }
        public DbSet<Mb2peditens> Mb2PedItens { get; set; }
        public DbSet<Ljusuarios> Ljusuarios { get; set; }
        public DbSet<Fpagamentos> Fpagamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dispositivos>(entity =>
            {
                entity.ToTable("dispositivos");
                entity.HasKey(e => e.Dis_id);

                entity.Property(e => e.Dis_uuid)
                    .HasColumnName("dis_uuid");

                entity.Property(e => e.Dis_plataforma)
                    .HasColumnName("dis_plataforma")
                    .HasColumnType("character varying")
                    .HasMaxLength(60);

                entity.Property(e => e.Dis_modelo)
                    .HasColumnName("dis_modelo")
                    .HasColumnType("character varying")
                    .HasMaxLength(60);

                entity.Property(e => e.Dis_versao)
                    .HasColumnName("dis_versao")
                    .HasColumnType("character varying")
                    .HasMaxLength(60);

                entity.Property(e => e.Dis_status)
                    .HasColumnName("dis_status");

                entity.Property(e => e.Dis_ultusuario)
                    .HasColumnName("dis_ultusuario")
                    .HasColumnType("character varying")
                    .HasMaxLength(30);

                entity.Property(e => e.Dis_uuiddispositivo)
                    .HasColumnName("dis_uuiddispositivo")
                    .HasColumnType("character varying")
                    .HasMaxLength(36);

                entity.Property(e => e.Emp_id)
                    .HasColumnName("emp_id");

                entity.HasOne(e => e.Empresa)
                    .WithMany()
                    .HasForeignKey(e => e.Emp_id);

            });

            modelBuilder.Entity<Empresas>(entity =>
            {
                entity.ToTable("empresas");
                entity.HasKey(e => e.Emp_id);

                entity.Property(e => e.Emp_nome)
                    .HasColumnName("emp_nome")
                    .HasColumnType("character varying")
                    .HasMaxLength(60);

                entity.Property(e => e.Emp_nfantasia)
                    .HasColumnName("emp_nfantasia")
                    .HasColumnType("character varying")
                    .HasMaxLength(60);

                entity.Property(e => e.Emp_cpfcgc)
                    .HasColumnName("emp_cpfcgc")
                    .HasColumnType("character varying")
                    .HasMaxLength(18);

                entity.Property(e => e.Emp_chavecentralizador)
                    .HasColumnName("emp_chavecentralizador");

                entity.Property(e => e.Emp_chavedispositivo)
                    .HasColumnName("emp_chavedispositivo");

                entity.Property(e => e.Emp_ativ)
                    .HasColumnName("emp_ativ");

                entity.Property(e => e.Created_at)
                    .HasColumnName("created_at");

                entity.Property(e => e.Updated_at)
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.ToTable("clientes");
                entity.HasKey(e => e.Cli_id);

                entity.Property(e => e.Cli_nome)
                    .HasColumnName("cli_nome")
                    .HasColumnType("character varying")
                    .HasMaxLength(60);

                entity.Property(e => e.Cli_nfantasia)
                    .HasColumnName("cli_nfantasia")
                    .HasColumnType("character varying")
                    .HasMaxLength(60);

                entity.Property(e => e.Cli_cpfcgc)
                    .HasColumnName("cli_cpfcgc")
                    .HasColumnType("character varying")
                    .HasMaxLength(18);

                entity.Property(e => e.Cli_endereco)
                    .HasColumnName("cli_endereco")
                    .HasColumnType("character varying")
                    .HasMaxLength(60);

                entity.Property(e => e.Cli_fone)
                    .HasColumnName("cli_fone")
                    .HasColumnType("character varying")
                    .HasMaxLength(14);

                entity.Property(e => e.Cli_email)
                    .HasColumnName("cli_email")
                    .HasColumnType("character varying")
                    .HasMaxLength(120);

                entity.Property(e => e.Cli_cidade)
                    .HasColumnName("cli_cidade")
                    .HasColumnType("character varying")
                    .HasMaxLength(60);

                entity.Property(e => e.Cli_uf)
                    .HasColumnName("cli_uf")
                    .HasColumnType("character varying")
                    .HasMaxLength(2);

                entity.Property(e => e.Cli_bloquear)
                    .HasColumnName("cli_bloquear")
                    .HasColumnType("character varying")
                    .HasMaxLength(2);

                entity.Property(e => e.Cli_idinterno)
                    .HasColumnName("cli_idinterno");

                entity.Property(e => e.Emp_id)
                    .HasColumnName("emp_id");

                entity.Property(e => e.Created_at)
                    .HasColumnName("created_at");

                entity.Property(e => e.Updated_at)
                    .HasColumnName("updated_at");

                entity.HasOne(e => e.Empresa)
                    .WithMany()
                    .HasForeignKey(e => e.Emp_id);
            });

            modelBuilder.Entity<Produtos>(entity =>
            {
                entity.ToTable("produtos");
                entity.HasKey(e => e.Pro_id);

                entity.Property(e => e.Pro_nome)
                    .HasColumnName("pro_nome")
                    .HasColumnType("character varying")
                    .HasMaxLength(200);

                entity.Property(e => e.Pro_marca)
                    .HasColumnName("pro_marca")
                    .HasColumnType("character varying")
                    .HasMaxLength(30);

                entity.Property(e => e.Pro_grupo)
                    .HasColumnName("pro_grupo")
                    .HasColumnType("character varying")
                    .HasMaxLength(40);

                entity.Property(e => e.Pro_saldo)
                    .HasColumnName("pro_saldo")
                    .HasColumnType("numeric(28,4)");

                entity.Property(e => e.Desconto_maximo)
                    .HasColumnName("desconto_maximo")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Pro_imagem)
                    .HasColumnName("pro_imagem")
                    .HasColumnType("character varying")
                    .HasMaxLength(200);

                entity.Property(e => e.Sic_seqintermabd)
                    .HasColumnName("sic_seqinternabd");

                entity.Property(e => e.Emp_id)
                    .HasColumnName("emp_id");

                entity.Property(e => e.Created_at)
                   .HasColumnName("created_at");

                entity.Property(e => e.Updated_at)
                    .HasColumnName("updated_at");

                entity.HasOne(e => e.Empresa)
                    .WithMany()
                    .HasForeignKey(e => e.Emp_id);
            });

            modelBuilder.Entity<Mb1pedcab>(entity =>
            {
                entity.ToTable("mb1pedcab");
                entity.HasKey(e => e.Mb1_id);

                entity.Property(e => e.Mb1_usuario)
                    .HasColumnName("mb1_usuario");

                entity.Property(e => e.Mb1_cliente)
                    .HasColumnName("mb1_cliente");

                entity.Property(e => e.Mb1_data)
                    .HasColumnName("mb1_data")
                    .HasColumnType("date");

                entity.Property(e => e.Mb1_pagamento)
                    .HasColumnName("mb1_pagamento")
                    .HasColumnType("character varying")
                    .HasMaxLength(2);

                entity.Property(e => e.Mb1_observacao)
                    .HasColumnName("mb1_observacao")
                    .HasColumnType("character varying")
                    .HasMaxLength(5000);

                entity.Property(e => e.Emp_id)
                    .HasColumnName("emp_id");

                entity.Property(e => e.Created_at)
                   .HasColumnName("created_at");

                entity.Property(e => e.Updated_at)
                    .HasColumnName("updated_at");

                entity.HasOne(e => e.Empresa)
                    .WithMany()
                    .HasForeignKey(e => e.Emp_id);

                entity.HasOne(e => e.Cliente)
                    .WithMany()
                    .HasForeignKey(e => e.Mb1_cliente);
            });

            modelBuilder.Entity<Mb2peditens>(entity =>
            {
                entity.ToTable("mb2peditens");
                entity.HasKey(e => e.Mb2_id);

                entity.Property(e => e.Mb2_produto)
                    .HasColumnName("mb2_produto");

                entity.Property(e => e.Mb2_quantidade)
                    .HasColumnName("mb2_quantidade")
                    .HasColumnType("numeric(10,3)");

                entity.Property(e => e.Mb2_valor_unitario)
                    .HasColumnName("mb2_valor_unitario")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Mb2_valor_desconto)
                    .HasColumnName("mb2_valor_desconto")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Mb2_observacao)
                    .HasColumnName("mb2_observacao")
                    .HasColumnType("character varying")
                    .HasMaxLength(255);

                entity.Property(e => e.Pedido_id)
                    .HasColumnName("pedido_id");

                entity.Property(e => e.Created_at)
                   .HasColumnName("created_at");

                entity.Property(e => e.Updated_at)
                    .HasColumnName("updated_at");

                entity.HasOne(e => e.Produto)
                    .WithMany()
                    .HasForeignKey(e => e.Mb2_produto);

                entity.HasOne(e => e.Pedido)
                    .WithMany()
                    .HasForeignKey(e => e.Pedido_id);
            });

            modelBuilder.Entity<Ljusuarios>(entity =>
            {
                entity.ToTable("ljusuarios");
                entity.HasKey(e => e.Lju_id);

                entity.Property(e => e.Lju_pwusuario)
                    .HasColumnName("lju_pwusuario")
                    .HasColumnType("character varying")
                    .HasMaxLength(30);

                entity.Property(e => e.Lju_psdsh)
                    .HasColumnName("lju_psdsh")
                    .HasColumnType("character varying")
                    .HasMaxLength(100);

                entity.Property(e => e.Ven_desconto)
                    .HasColumnName("ven_desconto")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Sic_seqinternabd)
                    .HasColumnName("sic_seqinternabd");

                entity.Property(e => e.Emp_id)
                    .HasColumnName("emp_id");

                entity.Property(e => e.Created_at)
                   .HasColumnName("created_at");

                entity.Property(e => e.Updated_at)
                    .HasColumnName("updated_at");

                entity.HasOne(e => e.Empresa)
                    .WithMany()
                    .HasForeignKey(e => e.Emp_id);
            });

            modelBuilder.Entity<Fpagamentos>(entity =>
            {
                entity.ToTable("fpagamentos");
                entity.HasKey(e => e.Fpa_id);

                entity.Property(e => e.Fpa_codigo)
                    .HasColumnName("fpa_codigo")
                    .HasColumnType("character varying")
                    .HasMaxLength(2);

                entity.Property(e => e.Fpa_descrabreviada)
                    .HasColumnName("fpa_descrabreviada")
                    .HasColumnType("character varying")
                    .HasMaxLength(16);

                entity.Property(e => e.Emp_id)
                    .HasColumnName("emp_id");

                entity.Property(e => e.Created_at)
                  .HasColumnName("created_at");

                entity.Property(e => e.Updated_at)
                    .HasColumnName("updated_at");

                entity.HasOne(e => e.Empresa)
                    .WithMany()
                    .HasForeignKey(e => e.Emp_id);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
