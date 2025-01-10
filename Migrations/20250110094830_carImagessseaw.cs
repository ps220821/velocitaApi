using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace velocitaApi.Migrations
{
    /// <inheritdoc />
    public partial class carImagessseaw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carImages_car_CarId",
                table: "carImages");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18565363-1a12-4093-a939-e0546f207d47");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f20120f-9161-4098-80e1-cf3e2f498547");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79330e02-32b6-42b1-86f5-15aaf6d976e7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c405ef2-950c-4159-8459-e4441b26ed73", null, "User", "USER" },
                    { "8cf418dc-6155-46e7-85fd-82354f75a5be", null, "Customer", "CUSTOMER" },
                    { "d29f3fbb-d58f-4a10-979d-dc65f7b9623d", null, "Admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_carImages_car_CarId",
                table: "carImages",
                column: "CarId",
                principalTable: "car",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carImages_car_CarId",
                table: "carImages");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c405ef2-950c-4159-8459-e4441b26ed73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cf418dc-6155-46e7-85fd-82354f75a5be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d29f3fbb-d58f-4a10-979d-dc65f7b9623d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18565363-1a12-4093-a939-e0546f207d47", null, "Admin", "ADMIN" },
                    { "2f20120f-9161-4098-80e1-cf3e2f498547", null, "Customer", "CUSTOMER" },
                    { "79330e02-32b6-42b1-86f5-15aaf6d976e7", null, "User", "USER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_carImages_car_CarId",
                table: "carImages",
                column: "CarId",
                principalTable: "car",
                principalColumn: "id");
        }
    }
}
