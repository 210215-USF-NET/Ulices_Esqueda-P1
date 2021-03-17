using Microsoft.EntityFrameworkCore.Migrations;

namespace SDL.Migrations
{
    public partial class StoreDependencyUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationVisted_Customers_CustomerID",
                table: "LocationVisted");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationVisted_Stores_StoreID",
                table: "LocationVisted");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_ProductID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreInventories_Products_ProductID",
                table: "StoreInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreInventories_Stores_StoreID",
                table: "StoreInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackOrders_Customers_CustomerID",
                table: "TrackOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackOrders_OrderItems_OrderItemID",
                table: "TrackOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackOrders_Orders_OrderID",
                table: "TrackOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackOrders_Stores_StoreID",
                table: "TrackOrders");

            migrationBuilder.DropIndex(
                name: "IX_TrackOrders_CustomerID",
                table: "TrackOrders");

            migrationBuilder.DropIndex(
                name: "IX_TrackOrders_OrderID",
                table: "TrackOrders");

            migrationBuilder.DropIndex(
                name: "IX_TrackOrders_OrderItemID",
                table: "TrackOrders");

            migrationBuilder.DropIndex(
                name: "IX_TrackOrders_StoreID",
                table: "TrackOrders");

            migrationBuilder.DropIndex(
                name: "IX_StoreInventories_ProductID",
                table: "StoreInventories");

            migrationBuilder.DropIndex(
                name: "IX_StoreInventories_StoreID",
                table: "StoreInventories");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_ProductID",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_LocationVisted_CustomerID",
                table: "LocationVisted");

            migrationBuilder.DropIndex(
                name: "IX_LocationVisted_StoreID",
                table: "LocationVisted");

            migrationBuilder.AlterColumn<int>(
                name: "StoreID",
                table: "TrackOrders",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderItemID",
                table: "TrackOrders",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderID",
                table: "TrackOrders",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "TrackOrders",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StoreID",
                table: "StoreInventories",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "StoreInventories",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "OrderItems",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StoreID",
                table: "LocationVisted",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "LocationVisted",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StoreID",
                table: "TrackOrders",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "OrderItemID",
                table: "TrackOrders",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "OrderID",
                table: "TrackOrders",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "TrackOrders",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "StoreID",
                table: "StoreInventories",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "StoreInventories",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "OrderItems",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "StoreID",
                table: "LocationVisted",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "LocationVisted",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_TrackOrders_CustomerID",
                table: "TrackOrders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_TrackOrders_OrderID",
                table: "TrackOrders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_TrackOrders_OrderItemID",
                table: "TrackOrders",
                column: "OrderItemID");

            migrationBuilder.CreateIndex(
                name: "IX_TrackOrders_StoreID",
                table: "TrackOrders",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_StoreInventories_ProductID",
                table: "StoreInventories",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_StoreInventories_StoreID",
                table: "StoreInventories",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductID",
                table: "OrderItems",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_LocationVisted_CustomerID",
                table: "LocationVisted",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_LocationVisted_StoreID",
                table: "LocationVisted",
                column: "StoreID");

            migrationBuilder.AddForeignKey(
                name: "FK_LocationVisted_Customers_CustomerID",
                table: "LocationVisted",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationVisted_Stores_StoreID",
                table: "LocationVisted",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_ProductID",
                table: "OrderItems",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreInventories_Products_ProductID",
                table: "StoreInventories",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreInventories_Stores_StoreID",
                table: "StoreInventories",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackOrders_Customers_CustomerID",
                table: "TrackOrders",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackOrders_OrderItems_OrderItemID",
                table: "TrackOrders",
                column: "OrderItemID",
                principalTable: "OrderItems",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackOrders_Orders_OrderID",
                table: "TrackOrders",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackOrders_Stores_StoreID",
                table: "TrackOrders",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
