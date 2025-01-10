using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace velocitaApi.Migrations
{
    /// <inheritdoc />
    public partial class carImagles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarImages_car_CarId",
                table: "CarImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarImages",
                table: "CarImages");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07c2b43d-e811-4cfa-86cd-0fbbd5946d02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b21287b5-c250-4608-a76c-f2fa82cbb8dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe0454b7-b3f2-4868-a10e-1397139b0245");

            migrationBuilder.RenameTable(
                name: "CarImages",
                newName: "carImages");

            migrationBuilder.RenameIndex(
                name: "IX_CarImages_CarId",
                table: "carImages",
                newName: "IX_carImages_CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carImages",
                table: "carImages",
                column: "id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a2d0456-091c-48d1-ba98-a5e94a00dc08", null, "Customer", "CUSTOMER" },
                    { "5a9996e9-43a8-41de-92e6-d29eb49ad13f", null, "User", "USER" },
                    { "74930b20-5f2f-48bc-822f-b2fd22ff7639", null, "Admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_carImages_car_CarId",
                table: "carImages",
                column: "CarId",
                principalTable: "car",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carImages_car_CarId",
                table: "carImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carImages",
                table: "carImages");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a2d0456-091c-48d1-ba98-a5e94a00dc08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a9996e9-43a8-41de-92e6-d29eb49ad13f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74930b20-5f2f-48bc-822f-b2fd22ff7639");

            migrationBuilder.RenameTable(
                name: "carImages",
                newName: "CarImages");

            migrationBuilder.RenameIndex(
                name: "IX_carImages_CarId",
                table: "CarImages",
                newName: "IX_CarImages_CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarImages",
                table: "CarImages",
                column: "id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07c2b43d-e811-4cfa-86cd-0fbbd5946d02", null, "Customer", "CUSTOMER" },
                    { "b21287b5-c250-4608-a76c-f2fa82cbb8dc", null, "User", "USER" },
                    { "fe0454b7-b3f2-4868-a10e-1397139b0245", null, "Admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CarImages_car_CarId",
                table: "CarImages",
                column: "CarId",
                principalTable: "car",
                principalColumn: "id");
        }
    }
}
