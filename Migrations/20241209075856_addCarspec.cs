using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace velocitaApi.Migrations
{
    /// <inheritdoc />
    public partial class addCarspec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0669b6b7-144a-4d30-ad27-f3afb1f5c3cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97e4c1cc-0685-410e-bf7b-829d77b5d888");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac7f1d3d-b710-4b4b-8569-7011d4d7c117");

            migrationBuilder.CreateTable(
                name: "CarSpecs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    engine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    transmission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    driveTrain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fuelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fuelEconomy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    horsepower = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    torque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zeroToSixty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    topSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    length = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    width = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    height = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wheelbase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    groundClearance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cargoSpace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passengerSpace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    seating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    towingCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maxPayload = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedLength = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedWidth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedHeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedVolume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedPayload = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedTowingCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedMaxPayload = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedMaxTowingCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedSeating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedCargoSpace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedGroundClearance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedWheelbase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedLengthWidthHeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedLengthWidthHeightVolume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedLengthWidthHeightPayload = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedLengthWidthHeightTowingCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedLengthWidthHeightMaxPayload = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedLengthWidthHeightMaxTowingCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedLengthWidthHeightSeating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedLengthWidthHeightCargoSpace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bedLengthWidthHeightGroundClearance = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarSpecs", x => x.id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarSpecs");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0669b6b7-144a-4d30-ad27-f3afb1f5c3cc", null, "Admin", "ADMIN" },
                    { "97e4c1cc-0685-410e-bf7b-829d77b5d888", null, "User", "USER" },
                    { "ac7f1d3d-b710-4b4b-8569-7011d4d7c117", null, "Customer", "CUSTOMER" }
                });
        }
    }
}
