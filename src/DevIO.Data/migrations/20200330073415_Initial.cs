using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevIO.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Siatis",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Resolvido = table.Column<bool>(nullable: false),
                    Resolucao = table.Column<string>(type: "varchar(500)", nullable: false),
                    NumeroProcesso = table.Column<string>(type: "varchar(100)", nullable: false),
                    DataCriacaoProcesso = table.Column<DateTime>(nullable: false),
                    TipoProcesso = table.Column<string>(type: "varchar(100)", nullable: false),
                    NomeProcesso = table.Column<string>(type: "varchar(100)", nullable: false),
                    NomeUser = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siatis", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Siatis");
        }
    }
}
