using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Empresas_emp_id",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Fpagamentos_Empresas_emp_id",
                table: "Fpagamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Mb1PedCab_Empresas_emp_id",
                table: "Mb1PedCab");

            migrationBuilder.DropForeignKey(
                name: "FK_Mb2PedItens_Mb1PedCab_PedidoId",
                table: "Mb2PedItens");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Empresas_emp_id",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mb2PedItens",
                table: "Mb2PedItens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mb1PedCab",
                table: "Mb1PedCab");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fpagamentos",
                table: "Fpagamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "produtos");

            migrationBuilder.RenameTable(
                name: "Mb2PedItens",
                newName: "mb2peditens");

            migrationBuilder.RenameTable(
                name: "Mb1PedCab",
                newName: "mb1pedcab");

            migrationBuilder.RenameTable(
                name: "Fpagamentos",
                newName: "fpagamentos");

            migrationBuilder.RenameTable(
                name: "Empresas",
                newName: "empresas");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "clientes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "produtos",
                newName: "Pro_id");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_emp_id",
                table: "produtos",
                newName: "IX_produtos_emp_id");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "mb2peditens",
                newName: "pedido_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "mb2peditens",
                newName: "Mb2_id");

            migrationBuilder.RenameIndex(
                name: "IX_Mb2PedItens_PedidoId",
                table: "mb2peditens",
                newName: "IX_mb2peditens_pedido_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "mb1pedcab",
                newName: "Mb1_id");

            migrationBuilder.RenameIndex(
                name: "IX_Mb1PedCab_emp_id",
                table: "mb1pedcab",
                newName: "IX_mb1pedcab_emp_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "fpagamentos",
                newName: "Fpa_id");

            migrationBuilder.RenameIndex(
                name: "IX_Fpagamentos_emp_id",
                table: "fpagamentos",
                newName: "IX_fpagamentos_emp_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "empresas",
                newName: "Emp_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "clientes",
                newName: "Cli_id");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_emp_id",
                table: "clientes",
                newName: "IX_clientes_emp_id");

            migrationBuilder.AlterColumn<long>(
                name: "sic_seqinternabd",
                table: "produtos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "produtos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "produtos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "mb2peditens",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "mb2peditens",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "mb1_pagamento",
                table: "mb1pedcab",
                type: "character varying",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "mb1pedcab",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "mb1pedcab",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "fpagamentos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "fpagamentos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "empresas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "emp_ativ",
                table: "empresas",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "emp_chavecentralizador",
                table: "empresas",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "emp_chavedispositivo",
                table: "empresas",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "empresas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<long>(
                name: "cli_idinterno",
                table: "clientes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "clientes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "clientes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_produtos",
                table: "produtos",
                column: "Pro_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mb2peditens",
                table: "mb2peditens",
                column: "Mb2_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mb1pedcab",
                table: "mb1pedcab",
                column: "Mb1_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_fpagamentos",
                table: "fpagamentos",
                column: "Fpa_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_empresas",
                table: "empresas",
                column: "Emp_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clientes",
                table: "clientes",
                column: "Cli_id");

            migrationBuilder.CreateTable(
                name: "dispositivos",
                columns: table => new
                {
                    Dis_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dis_uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    dis_plataforma = table.Column<string>(type: "character varying", maxLength: 60, nullable: false),
                    dis_modelo = table.Column<string>(type: "character varying", maxLength: 60, nullable: false),
                    dis_versao = table.Column<string>(type: "character varying", maxLength: 60, nullable: false),
                    dis_status = table.Column<bool>(type: "boolean", nullable: false),
                    dis_ultusuario = table.Column<string>(type: "character varying", maxLength: 30, nullable: false),
                    dis_uuiddispositivo = table.Column<string>(type: "character varying", maxLength: 36, nullable: false),
                    emp_id = table.Column<long>(type: "bigint", nullable: false),
                    Created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dispositivos", x => x.Dis_id);
                    table.ForeignKey(
                        name: "FK_dispositivos_empresas_emp_id",
                        column: x => x.emp_id,
                        principalTable: "empresas",
                        principalColumn: "Emp_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ljusuarios",
                columns: table => new
                {
                    Lju_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    lju_pwusuario = table.Column<string>(type: "character varying", maxLength: 30, nullable: false),
                    lju_psdsh = table.Column<string>(type: "character varying", maxLength: 100, nullable: false),
                    ven_desconto = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    sic_seqinternabd = table.Column<long>(type: "bigint", nullable: false),
                    emp_id = table.Column<long>(type: "bigint", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ljusuarios", x => x.Lju_id);
                    table.ForeignKey(
                        name: "FK_ljusuarios_empresas_emp_id",
                        column: x => x.emp_id,
                        principalTable: "empresas",
                        principalColumn: "Emp_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_mb2peditens_mb2_produto",
                table: "mb2peditens",
                column: "mb2_produto");

            migrationBuilder.CreateIndex(
                name: "IX_mb1pedcab_mb1_cliente",
                table: "mb1pedcab",
                column: "mb1_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_dispositivos_emp_id",
                table: "dispositivos",
                column: "emp_id");

            migrationBuilder.CreateIndex(
                name: "IX_ljusuarios_emp_id",
                table: "ljusuarios",
                column: "emp_id");

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_empresas_emp_id",
                table: "clientes",
                column: "emp_id",
                principalTable: "empresas",
                principalColumn: "Emp_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_fpagamentos_empresas_emp_id",
                table: "fpagamentos",
                column: "emp_id",
                principalTable: "empresas",
                principalColumn: "Emp_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mb1pedcab_clientes_mb1_cliente",
                table: "mb1pedcab",
                column: "mb1_cliente",
                principalTable: "clientes",
                principalColumn: "Cli_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mb1pedcab_empresas_emp_id",
                table: "mb1pedcab",
                column: "emp_id",
                principalTable: "empresas",
                principalColumn: "Emp_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mb2peditens_mb1pedcab_pedido_id",
                table: "mb2peditens",
                column: "pedido_id",
                principalTable: "mb1pedcab",
                principalColumn: "Mb1_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mb2peditens_produtos_mb2_produto",
                table: "mb2peditens",
                column: "mb2_produto",
                principalTable: "produtos",
                principalColumn: "Pro_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_produtos_empresas_emp_id",
                table: "produtos",
                column: "emp_id",
                principalTable: "empresas",
                principalColumn: "Emp_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_empresas_emp_id",
                table: "clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_fpagamentos_empresas_emp_id",
                table: "fpagamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_mb1pedcab_clientes_mb1_cliente",
                table: "mb1pedcab");

            migrationBuilder.DropForeignKey(
                name: "FK_mb1pedcab_empresas_emp_id",
                table: "mb1pedcab");

            migrationBuilder.DropForeignKey(
                name: "FK_mb2peditens_mb1pedcab_pedido_id",
                table: "mb2peditens");

            migrationBuilder.DropForeignKey(
                name: "FK_mb2peditens_produtos_mb2_produto",
                table: "mb2peditens");

            migrationBuilder.DropForeignKey(
                name: "FK_produtos_empresas_emp_id",
                table: "produtos");

            migrationBuilder.DropTable(
                name: "dispositivos");

            migrationBuilder.DropTable(
                name: "ljusuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_produtos",
                table: "produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mb2peditens",
                table: "mb2peditens");

            migrationBuilder.DropIndex(
                name: "IX_mb2peditens_mb2_produto",
                table: "mb2peditens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mb1pedcab",
                table: "mb1pedcab");

            migrationBuilder.DropIndex(
                name: "IX_mb1pedcab_mb1_cliente",
                table: "mb1pedcab");

            migrationBuilder.DropPrimaryKey(
                name: "PK_fpagamentos",
                table: "fpagamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_empresas",
                table: "empresas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clientes",
                table: "clientes");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "produtos");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "produtos");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "mb2peditens");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "mb2peditens");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "mb1pedcab");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "mb1pedcab");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "fpagamentos");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "fpagamentos");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "empresas");

            migrationBuilder.DropColumn(
                name: "emp_ativ",
                table: "empresas");

            migrationBuilder.DropColumn(
                name: "emp_chavecentralizador",
                table: "empresas");

            migrationBuilder.DropColumn(
                name: "emp_chavedispositivo",
                table: "empresas");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "empresas");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "clientes");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "clientes");

            migrationBuilder.RenameTable(
                name: "produtos",
                newName: "Produtos");

            migrationBuilder.RenameTable(
                name: "mb2peditens",
                newName: "Mb2PedItens");

            migrationBuilder.RenameTable(
                name: "mb1pedcab",
                newName: "Mb1PedCab");

            migrationBuilder.RenameTable(
                name: "fpagamentos",
                newName: "Fpagamentos");

            migrationBuilder.RenameTable(
                name: "empresas",
                newName: "Empresas");

            migrationBuilder.RenameTable(
                name: "clientes",
                newName: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Pro_id",
                table: "Produtos",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_produtos_emp_id",
                table: "Produtos",
                newName: "IX_Produtos_emp_id");

            migrationBuilder.RenameColumn(
                name: "pedido_id",
                table: "Mb2PedItens",
                newName: "PedidoId");

            migrationBuilder.RenameColumn(
                name: "Mb2_id",
                table: "Mb2PedItens",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_mb2peditens_pedido_id",
                table: "Mb2PedItens",
                newName: "IX_Mb2PedItens_PedidoId");

            migrationBuilder.RenameColumn(
                name: "Mb1_id",
                table: "Mb1PedCab",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_mb1pedcab_emp_id",
                table: "Mb1PedCab",
                newName: "IX_Mb1PedCab_emp_id");

            migrationBuilder.RenameColumn(
                name: "Fpa_id",
                table: "Fpagamentos",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_fpagamentos_emp_id",
                table: "Fpagamentos",
                newName: "IX_Fpagamentos_emp_id");

            migrationBuilder.RenameColumn(
                name: "Emp_id",
                table: "Empresas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Cli_id",
                table: "Clientes",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_clientes_emp_id",
                table: "Clientes",
                newName: "IX_Clientes_emp_id");

            migrationBuilder.AlterColumn<long>(
                name: "sic_seqinternabd",
                table: "Produtos",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "mb1_pagamento",
                table: "Mb1PedCab",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<long>(
                name: "cli_idinterno",
                table: "Clientes",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mb2PedItens",
                table: "Mb2PedItens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mb1PedCab",
                table: "Mb1PedCab",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fpagamentos",
                table: "Fpagamentos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    emp_id = table.Column<long>(type: "bigint", nullable: false),
                    desconto_maximo = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    usu_nome = table.Column<string>(type: "character varying", maxLength: 30, nullable: false),
                    usu_senha = table.Column<string>(type: "character varying", maxLength: 100, nullable: false),
                    sic_seqinternabd = table.Column<long>(type: "bigint", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_emp_id",
                table: "Usuarios",
                column: "emp_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Empresas_emp_id",
                table: "Clientes",
                column: "emp_id",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fpagamentos_Empresas_emp_id",
                table: "Fpagamentos",
                column: "emp_id",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mb1PedCab_Empresas_emp_id",
                table: "Mb1PedCab",
                column: "emp_id",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mb2PedItens_Mb1PedCab_PedidoId",
                table: "Mb2PedItens",
                column: "PedidoId",
                principalTable: "Mb1PedCab",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Empresas_emp_id",
                table: "Produtos",
                column: "emp_id",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
