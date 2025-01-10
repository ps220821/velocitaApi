using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace velocitaApi.Migrations
{
    /// <inheritdoc />
    public partial class carImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "car",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CarImages",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarImages", x => x.id);
                    table.ForeignKey(
                        name: "FK_CarImages_car_CarId",
                        column: x => x.CarId,
                        principalTable: "car",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07c2b43d-e811-4cfa-86cd-0fbbd5946d02", null, "Customer", "CUSTOMER" },
                    { "b21287b5-c250-4608-a76c-f2fa82cbb8dc", null, "User", "USER" },
                    { "fe0454b7-b3f2-4868-a10e-1397139b0245", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarImages_CarId",
                table: "CarImages",
                column: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarImages");

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

            migrationBuilder.DropColumn(
                name: "description",
                table: "car");

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
    }
}
