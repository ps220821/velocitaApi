using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace velocitaApi.Migrations
{
    /// <inheritdoc />
    public partial class addCarspecre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "042c5f71-8386-4db2-b3f8-cc56dae9f77c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4f1759e-163f-4fdb-b2da-7b261083611b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff60f36e-a4b9-49d8-bf89-84a81e05086a");

            migrationBuilder.AddColumn<int>(
                name: "carId",
                table: "CarSpecs",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "305fb194-4fff-4acb-a69d-8043a5ccaddd", null, "Admin", "ADMIN" },
                    { "320dc0d9-983e-498f-a96a-0eb2bfbec843", null, "Customer", "CUSTOMER" },
                    { "8a7cd04f-ae39-486d-94cd-5636f0371c76", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarSpecs_carId",
                table: "CarSpecs",
                column: "carId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarSpecs_car_carId",
                table: "CarSpecs",
                column: "carId",
                principalTable: "car",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarSpecs_car_carId",
                table: "CarSpecs");

            migrationBuilder.DropIndex(
                name: "IX_CarSpecs_carId",
                table: "CarSpecs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "305fb194-4fff-4acb-a69d-8043a5ccaddd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "320dc0d9-983e-498f-a96a-0eb2bfbec843");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a7cd04f-ae39-486d-94cd-5636f0371c76");

            migrationBuilder.DropColumn(
                name: "carId",
                table: "CarSpecs");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "042c5f71-8386-4db2-b3f8-cc56dae9f77c", null, "Admin", "ADMIN" },
                    { "b4f1759e-163f-4fdb-b2da-7b261083611b", null, "User", "USER" },
                    { "ff60f36e-a4b9-49d8-bf89-84a81e05086a", null, "Customer", "CUSTOMER" }
                });
        }
    }
}
