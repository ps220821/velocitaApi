using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace velocitaApi.Migrations
{
    /// <inheritdoc />
    public partial class neww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "877e07a8-3198-4bd8-b6ed-6d31cd17ff67", null, "Customer", "CUSTOMER" },
                    { "95112281-14d6-445a-b78c-c971a7a30c5e", null, "Admin", "ADMIN" },
                    { "cdebe38f-9b77-43de-9566-b9a415f7bac1", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "877e07a8-3198-4bd8-b6ed-6d31cd17ff67");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95112281-14d6-445a-b78c-c971a7a30c5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdebe38f-9b77-43de-9566-b9a415f7bac1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3dd0b971-42eb-47d1-b4a2-32436b82de0b", null, "Customer", "CUSTOMER" },
                    { "66d798e7-8bef-4cc9-af58-5fa3e736b791", null, "Admin", "ADMIN" },
                    { "f633fda5-ed96-402e-8a97-b5b5b43bb9b3", null, "User", "USER" }
                });
        }
    }
}
