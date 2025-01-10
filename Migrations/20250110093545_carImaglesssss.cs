using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace velocitaApi.Migrations
{
    /// <inheritdoc />
    public partial class carImaglesssss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18565363-1a12-4093-a939-e0546f207d47", null, "Admin", "ADMIN" },
                    { "2f20120f-9161-4098-80e1-cf3e2f498547", null, "Customer", "CUSTOMER" },
                    { "79330e02-32b6-42b1-86f5-15aaf6d976e7", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                    { "0a2d0456-091c-48d1-ba98-a5e94a00dc08", null, "Customer", "CUSTOMER" },
                    { "5a9996e9-43a8-41de-92e6-d29eb49ad13f", null, "User", "USER" },
                    { "74930b20-5f2f-48bc-822f-b2fd22ff7639", null, "Admin", "ADMIN" }
                });
        }
    }
}
