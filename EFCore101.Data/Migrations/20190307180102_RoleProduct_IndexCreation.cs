using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore101.Data.Migrations
{
    public partial class RoleProduct_IndexCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmployeeProductRoles_ProductId",
                schema: "Store",
                table: "EmployeeProductRoles");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProductRoles_ProductId_RoleId",
                schema: "Store",
                table: "EmployeeProductRoles",
                columns: new[] { "ProductId", "RoleId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmployeeProductRoles_ProductId_RoleId",
                schema: "Store",
                table: "EmployeeProductRoles");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProductRoles_ProductId",
                schema: "Store",
                table: "EmployeeProductRoles",
                column: "ProductId");
        }
    }
}
