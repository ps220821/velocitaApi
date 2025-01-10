using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace velocitaApi.Migrations
{
    /// <inheritdoc />
    public partial class carImaglesssss223 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_brand_BrandId",
                table: "car");

            migrationBuilder.DropForeignKey(
                name: "FK_car_category_CategoryId",
                table: "car");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "743ae769-cbd4-4bae-8ed5-0d7b7da5fd30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af4540cf-1318-4f3a-8880-5b5dee3f6fb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea699bc9-49ea-48c3-9e6a-84d54c619763");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f414caf-91c2-4d82-932a-adc7c9dab282", null, "Customer", "CUSTOMER" },
                    { "cab4902c-9e18-4545-8568-231277f315d5", null, "Admin", "ADMIN" },
                    { "ff21e99a-f3e2-4a71-96fe-e07d6214ce6f", null, "User", "USER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_car_brand_BrandId",
                table: "car",
                column: "BrandId",
                principalTable: "brand",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_car_category_CategoryId",
                table: "car",
                column: "CategoryId",
                principalTable: "category",
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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f414caf-91c2-4d82-932a-adc7c9dab282");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cab4902c-9e18-4545-8568-231277f315d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff21e99a-f3e2-4a71-96fe-e07d6214ce6f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "743ae769-cbd4-4bae-8ed5-0d7b7da5fd30", null, "Admin", "ADMIN" },
                    { "af4540cf-1318-4f3a-8880-5b5dee3f6fb4", null, "User", "USER" },
                    { "ea699bc9-49ea-48c3-9e6a-84d54c619763", null, "Customer", "CUSTOMER" }
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
        }
    }
}
