using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace velocitaApi.Migrations
{
    /// <inheritdoc />
    public partial class fixcarspec33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarSpecs_car_carId",
                table: "CarSpecs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f6b7880-22ae-42d5-bec6-b702f6f435e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4db9981d-1a2d-465e-843b-9f8f77415f92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd7e47f6-399c-49ab-af7a-101be294e757");

            migrationBuilder.RenameColumn(
                name: "carId",
                table: "CarSpecs",
                newName: "CarId");

            migrationBuilder.RenameIndex(
                name: "IX_CarSpecs_carId",
                table: "CarSpecs",
                newName: "IX_CarSpecs_CarId");

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
                name: "FK_CarSpecs_car_CarId",
                table: "CarSpecs",
                column: "CarId",
                principalTable: "car",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarSpecs_car_CarId",
                table: "CarSpecs");

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
                name: "CarId",
                table: "CarSpecs",
                newName: "carId");

            migrationBuilder.RenameIndex(
                name: "IX_CarSpecs_CarId",
                table: "CarSpecs",
                newName: "IX_CarSpecs_carId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f6b7880-22ae-42d5-bec6-b702f6f435e8", null, "Customer", "CUSTOMER" },
                    { "4db9981d-1a2d-465e-843b-9f8f77415f92", null, "Admin", "ADMIN" },
                    { "bd7e47f6-399c-49ab-af7a-101be294e757", null, "User", "USER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CarSpecs_car_carId",
                table: "CarSpecs",
                column: "carId",
                principalTable: "car",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
