using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Aspnetcore.web.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MateriasPrimas",
                table: "MateriasPrimas");

            migrationBuilder.CreateTable(
                name: "Producao",
                columns: table => new
                {
                    ProducaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MateriaPrimaId = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producao", x => x.ProducaoId);
                    table.ForeignKey(
                        name: "FK_Producao_MateriaPrima_MateriaPrimaId",
                        column: x => x.MateriaPrimaId,
                        principalTable: "MateriasPrimas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Producao_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                maxLength: 150,
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produto",
                table: "Produtos",
                column: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "MateriasPrimas",
                maxLength: 150,
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MateriaPrima",
                table: "MateriasPrimas",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Producao_MateriaPrimaId",
                table: "Producao",
                column: "MateriaPrimaId");

            migrationBuilder.CreateIndex(
                name: "IX_Producao_ProdutoId",
                table: "Producao",
                column: "ProdutoId");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "Produto");

            migrationBuilder.RenameTable(
                name: "MateriasPrimas",
                newName: "MateriaPrima");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Produto",
                table: "Produto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MateriaPrima",
                table: "MateriaPrima");

            migrationBuilder.DropTable(
                name: "Producao");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produto",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produto",
                column: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "MateriaPrima",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MateriasPrimas",
                table: "MateriaPrima",
                column: "Id");

            migrationBuilder.RenameTable(
                name: "Produto",
                newName: "Produtos");

            migrationBuilder.RenameTable(
                name: "MateriaPrima",
                newName: "MateriasPrimas");
        }
    }
}
