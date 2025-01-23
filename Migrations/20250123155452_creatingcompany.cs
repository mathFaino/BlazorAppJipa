using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ServicesBlazor.Migrations
{
    public partial class creatingcompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Empresa",
                table: "Services");

            migrationBuilder.AddColumn<int>(
                name: "CompanyModelId",
                table: "Services",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Razao = table.Column<string>(type: "text", nullable: false),
                    CNPJ = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Services_CompanyModelId",
                table: "Services",
                column: "CompanyModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Companies_CompanyModelId",
                table: "Services",
                column: "CompanyModelId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Companies_CompanyModelId",
                table: "Services");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Services_CompanyModelId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "CompanyModelId",
                table: "Services");

            migrationBuilder.AddColumn<string>(
                name: "Empresa",
                table: "Services",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
