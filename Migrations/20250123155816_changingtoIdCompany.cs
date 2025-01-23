using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServicesBlazor.Migrations
{
    public partial class changingtoIdCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Companies_CompanyModelId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_CompanyModelId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "CompanyModelId",
                table: "Services");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Services",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Services_CompanyId",
                table: "Services",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Companies_CompanyId",
                table: "Services",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Companies_CompanyId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_CompanyId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Services");

            migrationBuilder.AddColumn<int>(
                name: "CompanyModelId",
                table: "Services",
                type: "integer",
                nullable: true);

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
    }
}
