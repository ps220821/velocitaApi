using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace velocitaApi.Migrations
{
    /// <inheritdoc />
    public partial class fixcarspec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11d1d409-852f-4d6f-bbbe-d7943287250f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bb7db26-cc54-4cd9-b589-dab20729a663");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ee02163-0458-4e19-ae23-95219bea8cc3");

            migrationBuilder.AlterColumn<string>(
                name: "Transmission",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FuelType",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DriveTrain",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f6b7880-22ae-42d5-bec6-b702f6f435e8", null, "Customer", "CUSTOMER" },
                    { "4db9981d-1a2d-465e-843b-9f8f77415f92", null, "Admin", "ADMIN" },
                    { "bd7e47f6-399c-49ab-af7a-101be294e757", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<int>(
                name: "Transmission",
                table: "CarSpecs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "FuelType",
                table: "CarSpecs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "DriveTrain",
                table: "CarSpecs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11d1d409-852f-4d6f-bbbe-d7943287250f", null, "Admin", "ADMIN" },
                    { "5bb7db26-cc54-4cd9-b589-dab20729a663", null, "Customer", "CUSTOMER" },
                    { "7ee02163-0458-4e19-ae23-95219bea8cc3", null, "User", "USER" }
                });
        }
    }
}
