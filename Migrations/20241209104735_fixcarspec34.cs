using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace velocitaApi.Migrations
{
    /// <inheritdoc />
    public partial class fixcarspec34 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_brand_brandId",
                table: "car");

            migrationBuilder.DropForeignKey(
                name: "FK_car_category_categoryId",
                table: "car");

            migrationBuilder.DropForeignKey(
                name: "FK_order_customer_customerId",
                table: "order");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31e2da96-fab8-4ac6-be1b-7e6698badb49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7fd2f49-2e15-44c2-8649-0c0642a4fb56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dea462e3-7140-44d2-943e-97f92b09768d");

            migrationBuilder.RenameColumn(
                name: "totalCost",
                table: "order",
                newName: "TotalCost");

            migrationBuilder.RenameColumn(
                name: "serviceType",
                table: "order",
                newName: "ServiceType");

            migrationBuilder.RenameColumn(
                name: "orderStatus",
                table: "order",
                newName: "OrderStatus");

            migrationBuilder.RenameColumn(
                name: "orderDate",
                table: "order",
                newName: "OrderDate");

            migrationBuilder.RenameColumn(
                name: "discrption",
                table: "order",
                newName: "Discrption");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "order",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_order_customerId",
                table: "order",
                newName: "IX_order_CustomerId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "options",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "options",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "zipCode",
                table: "customer",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "customer",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "customer",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "customer",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "customer",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "customer",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "customer",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "customer",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "bankNumber",
                table: "customer",
                newName: "BankNumber");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "customer",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "category",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "categoryName",
                table: "category",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "CarOptions",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "available",
                table: "CarOptions",
                newName: "Available");

            migrationBuilder.RenameColumn(
                name: "year",
                table: "car",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "car",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "model",
                table: "car",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "mileage",
                table: "car",
                newName: "Mileage");

            migrationBuilder.RenameColumn(
                name: "color",
                table: "car",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "car",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "brandId",
                table: "car",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_car_categoryId",
                table: "car",
                newName: "IX_car_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_car_brandId",
                table: "car",
                newName: "IX_car_BrandId");

            migrationBuilder.RenameColumn(
                name: "url",
                table: "brand",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "brand",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "brand",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "brand",
                newName: "Country");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3dd0b971-42eb-47d1-b4a2-32436b82de0b", null, "Customer", "CUSTOMER" },
                    { "66d798e7-8bef-4cc9-af58-5fa3e736b791", null, "Admin", "ADMIN" },
                    { "f633fda5-ed96-402e-8a97-b5b5b43bb9b3", null, "User", "USER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_car_brand_BrandId",
                table: "car",
                column: "BrandId",
                principalTable: "brand",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_car_category_CategoryId",
                table: "car",
                column: "CategoryId",
                principalTable: "category",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_customer_CustomerId",
                table: "order",
                column: "CustomerId",
                principalTable: "customer",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_brand_BrandId",
                table: "car");

            migrationBuilder.DropForeignKey(
                name: "FK_car_category_CategoryId",
                table: "car");

            migrationBuilder.DropForeignKey(
                name: "FK_order_customer_CustomerId",
                table: "order");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dd0b971-42eb-47d1-b4a2-32436b82de0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66d798e7-8bef-4cc9-af58-5fa3e736b791");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f633fda5-ed96-402e-8a97-b5b5b43bb9b3");

            migrationBuilder.RenameColumn(
                name: "TotalCost",
                table: "order",
                newName: "totalCost");

            migrationBuilder.RenameColumn(
                name: "ServiceType",
                table: "order",
                newName: "serviceType");

            migrationBuilder.RenameColumn(
                name: "OrderStatus",
                table: "order",
                newName: "orderStatus");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "order",
                newName: "orderDate");

            migrationBuilder.RenameColumn(
                name: "Discrption",
                table: "order",
                newName: "discrption");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "order",
                newName: "customerId");

            migrationBuilder.RenameIndex(
                name: "IX_order_CustomerId",
                table: "order",
                newName: "IX_order_customerId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "options",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "options",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "customer",
                newName: "zipCode");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "customer",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "customer",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "customer",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "customer",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "customer",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "customer",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "customer",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "BankNumber",
                table: "customer",
                newName: "bankNumber");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "customer",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "category",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "category",
                newName: "categoryName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "CarOptions",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Available",
                table: "CarOptions",
                newName: "available");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "car",
                newName: "year");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "car",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "car",
                newName: "model");

            migrationBuilder.RenameColumn(
                name: "Mileage",
                table: "car",
                newName: "mileage");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "car",
                newName: "color");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "car",
                newName: "categoryId");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "car",
                newName: "brandId");

            migrationBuilder.RenameIndex(
                name: "IX_car_CategoryId",
                table: "car",
                newName: "IX_car_categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_car_BrandId",
                table: "car",
                newName: "IX_car_brandId");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "brand",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "brand",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "brand",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "brand",
                newName: "country");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31e2da96-fab8-4ac6-be1b-7e6698badb49", null, "Customer", "CUSTOMER" },
                    { "a7fd2f49-2e15-44c2-8649-0c0642a4fb56", null, "Admin", "ADMIN" },
                    { "dea462e3-7140-44d2-943e-97f92b09768d", null, "User", "USER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_car_brand_brandId",
                table: "car",
                column: "brandId",
                principalTable: "brand",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_car_category_categoryId",
                table: "car",
                column: "categoryId",
                principalTable: "category",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_customer_customerId",
                table: "order",
                column: "customerId",
                principalTable: "customer",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
