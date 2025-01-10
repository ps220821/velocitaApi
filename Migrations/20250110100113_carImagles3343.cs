using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace velocitaApi.Migrations
{
    /// <inheritdoc />
    public partial class carImagles3343 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "description",
                table: "car",
                newName: "Description");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "743ae769-cbd4-4bae-8ed5-0d7b7da5fd30", null, "Admin", "ADMIN" },
                    { "af4540cf-1318-4f3a-8880-5b5dee3f6fb4", null, "User", "USER" },
                    { "ea699bc9-49ea-48c3-9e6a-84d54c619763", null, "Customer", "CUSTOMER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "car",
                newName: "description");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c405ef2-950c-4159-8459-e4441b26ed73", null, "User", "USER" },
                    { "8cf418dc-6155-46e7-85fd-82354f75a5be", null, "Customer", "CUSTOMER" },
                    { "d29f3fbb-d58f-4a10-979d-dc65f7b9623d", null, "Admin", "ADMIN" }
                });
        }
    }
}
