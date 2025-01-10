using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace velocitaApi.Migrations
{
    /// <inheritdoc />
    public partial class carImagessseaw21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { "512c1e62-bd29-4002-bb19-beefea3eec16", null, "Customer", "CUSTOMER" },
                    { "7555371a-22d4-48a6-acee-b860bf2f6c1b", null, "Admin", "ADMIN" },
                    { "cd1fab24-017a-423e-a4fb-ae6ba4094829", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "512c1e62-bd29-4002-bb19-beefea3eec16");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7555371a-22d4-48a6-acee-b860bf2f6c1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd1fab24-017a-423e-a4fb-ae6ba4094829");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f414caf-91c2-4d82-932a-adc7c9dab282", null, "Customer", "CUSTOMER" },
                    { "cab4902c-9e18-4545-8568-231277f315d5", null, "Admin", "ADMIN" },
                    { "ff21e99a-f3e2-4a71-96fe-e07d6214ce6f", null, "User", "USER" }
                });
        }
    }
}
