using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore101.Data.Migrations
{
    public partial class RolesEmployeeProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Employees_EmployeeId",
                schema: "Store",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_EmployeeId",
                schema: "Store",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                schema: "Store",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProductRoles",
                schema: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProductRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeProductRoles_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "Store",
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProductRoles_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Store",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProductRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Store",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProductRoles_EmployeeId",
                schema: "Store",
                table: "EmployeeProductRoles",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProductRoles_ProductId",
                schema: "Store",
                table: "EmployeeProductRoles",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProductRoles_RoleId",
                schema: "Store",
                table: "EmployeeProductRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProductRoles",
                schema: "Store");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "Store");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                schema: "Store",
                table: "Products",
                nullable: false,
                defaultValue: 0);

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
    }
}
