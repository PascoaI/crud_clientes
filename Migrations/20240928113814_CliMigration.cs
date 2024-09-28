using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace crud_clientes.Migrations
{
    /// <inheritdoc />
    public partial class CliMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    CLI_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CLI_NOME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CLI_DATANASCIMENTO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CLI_ATIVO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.CLI_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
