using Microsoft.EntityFrameworkCore.Migrations;

namespace SDL.Migrations
{
    public partial class StoreDependencyUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Customers_CustomerID",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_CustomerID",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Stores");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Stores",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stores_CustomerID",
                table: "Stores",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Customers_CustomerID",
                table: "Stores",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
