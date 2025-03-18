using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    emp_nome = table.Column<string>(type: "character varying", maxLength: 60, nullable: false),
                    emp_nfantasia = table.Column<string>(type: "character varying", maxLength: 60, nullable: false),
                    emp_cpfcgc = table.Column<string>(type: "character varying", maxLength: 18, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cli_nome = table.Column<string>(type: "character varying", maxLength: 60, nullable: false),
                    cli_nfantasia = table.Column<string>(type: "character varying", maxLength: 60, nullable: false),
                    cli_cpfcgc = table.Column<string>(type: "character varying", maxLength: 18, nullable: false),
                    cli_endereco = table.Column<string>(type: "character varying", maxLength: 60, nullable: false),
                    cli_fone = table.Column<string>(type: "character varying", maxLength: 14, nullable: false),
                    cli_email = table.Column<string>(type: "character varying", maxLength: 120, nullable: false),
                    cli_cidade = table.Column<string>(type: "character varying", maxLength: 60, nullable: false),
                    cli_uf = table.Column<string>(type: "character varying", maxLength: 2, nullable: false),
                    cli_bloquear = table.Column<string>(type: "character varying", maxLength: 2, nullable: false),
                    cli_idinterno = table.Column<long>(type: "bigint", nullable: true),
                    emp_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Empresas_emp_id",
                        column: x => x.emp_id,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fpagamentos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fpa_codigo = table.Column<string>(type: "character varying", maxLength: 2, nullable: false),
                    fpa_descrabreviada = table.Column<string>(type: "character varying", maxLength: 16, nullable: false),
                    emp_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fpagamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fpagamentos_Empresas_emp_id",
                        column: x => x.emp_id,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mb1PedCab",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    mb1_usuario = table.Column<long>(type: "bigint", nullable: false),
                    mb1_cliente = table.Column<long>(type: "bigint", nullable: false),
                    mb1_data = table.Column<DateTime>(type: "date", nullable: false),
                    mb1_pagamento = table.Column<string>(type: "text", nullable: false),
                    mb1_observacao = table.Column<string>(type: "character varying", maxLength: 5000, nullable: false),
                    emp_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mb1PedCab", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mb1PedCab_Empresas_emp_id",
                        column: x => x.emp_id,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pro_nome = table.Column<string>(type: "character varying", maxLength: 200, nullable: false),
                    pro_marca = table.Column<string>(type: "character varying", maxLength: 30, nullable: false),
                    pro_grupo = table.Column<string>(type: "character varying", maxLength: 40, nullable: false),
                    pro_saldo = table.Column<decimal>(type: "numeric(28,4)", nullable: false),
                    desconto_maximo = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    pro_imagem = table.Column<string>(type: "character varying", maxLength: 200, nullable: false),
                    sic_seqinternabd = table.Column<long>(type: "bigint", nullable: true),
                    emp_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Empresas_emp_id",
                        column: x => x.emp_id,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usu_nome = table.Column<string>(type: "character varying", maxLength: 30, nullable: false),
                    usu_senha = table.Column<string>(type: "character varying", maxLength: 100, nullable: false),
                    desconto_maximo = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    sic_seqinternabd = table.Column<long>(type: "bigint", nullable: true),
                    emp_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Empresas_emp_id",
                        column: x => x.emp_id,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mb2PedItens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    mb2_produto = table.Column<long>(type: "bigint", nullable: false),
                    mb2_quantidade = table.Column<decimal>(type: "numeric(10,3)", nullable: false),
                    mb2_valor_unitario = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    mb2_valor_desconto = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    mb2_observacao = table.Column<string>(type: "character varying", maxLength: 255, nullable: false),
                    PedidoId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mb2PedItens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mb2PedItens_Mb1PedCab_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Mb1PedCab",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_emp_id",
                table: "Clientes",
                column: "emp_id");

            migrationBuilder.CreateIndex(
                name: "IX_Fpagamentos_emp_id",
                table: "Fpagamentos",
                column: "emp_id");

            migrationBuilder.CreateIndex(
                name: "IX_Mb1PedCab_emp_id",
                table: "Mb1PedCab",
                column: "emp_id");

            migrationBuilder.CreateIndex(
                name: "IX_Mb2PedItens_PedidoId",
                table: "Mb2PedItens",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_emp_id",
                table: "Produtos",
                column: "emp_id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_emp_id",
                table: "Usuarios",
                column: "emp_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Fpagamentos");

            migrationBuilder.DropTable(
                name: "Mb2PedItens");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Mb1PedCab");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
