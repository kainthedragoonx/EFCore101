using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore101.Data.Migrations
{
    public partial class anothermigrationforstuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                schema: "Store",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_EmployeeId",
                schema: "Store",
                table: "Products",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Employees_EmployeeId",
                schema: "Store",
                table: "Products",
                column: "EmployeeId",
                principalSchema: "Store",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Employees_EmployeeId",
                schema: "Store",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Products_EmployeeId",
                schema: "Store",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                schema: "Store",
                table: "Products");
        }
    }
}
