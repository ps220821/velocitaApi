using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace velocitaApi.Migrations
{
    /// <inheritdoc />
    public partial class carspecfix : Migration
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
                keyValue: "305fb194-4fff-4acb-a69d-8043a5ccaddd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "320dc0d9-983e-498f-a96a-0eb2bfbec843");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a7cd04f-ae39-486d-94cd-5636f0371c76");

            migrationBuilder.DropColumn(
                name: "bedCargoSpace",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedGroundClearance",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedHeight",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedLength",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedLengthWidthHeight",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedLengthWidthHeightCargoSpace",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedLengthWidthHeightGroundClearance",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedLengthWidthHeightMaxPayload",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedLengthWidthHeightMaxTowingCapacity",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedLengthWidthHeightPayload",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedLengthWidthHeightSeating",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedLengthWidthHeightTowingCapacity",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedLengthWidthHeightVolume",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedMaxPayload",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedMaxTowingCapacity",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedPayload",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedSeating",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedTowingCapacity",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedVolume",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedWheelbase",
                table: "CarSpecs");

            migrationBuilder.DropColumn(
                name: "bedWidth",
                table: "CarSpecs");

            migrationBuilder.RenameColumn(
                name: "zeroToSixty",
                table: "CarSpecs",
                newName: "ZeroToSixty");

            migrationBuilder.RenameColumn(
                name: "width",
                table: "CarSpecs",
                newName: "Width");

            migrationBuilder.RenameColumn(
                name: "wheelbase",
                table: "CarSpecs",
                newName: "Wheelbase");

            migrationBuilder.RenameColumn(
                name: "weight",
                table: "CarSpecs",
                newName: "Weight");

            migrationBuilder.RenameColumn(
                name: "transmission",
                table: "CarSpecs",
                newName: "Transmission");

            migrationBuilder.RenameColumn(
                name: "towingCapacity",
                table: "CarSpecs",
                newName: "TowingCapacity");

            migrationBuilder.RenameColumn(
                name: "torque",
                table: "CarSpecs",
                newName: "Torque");

            migrationBuilder.RenameColumn(
                name: "topSpeed",
                table: "CarSpecs",
                newName: "TopSpeed");

            migrationBuilder.RenameColumn(
                name: "seating",
                table: "CarSpecs",
                newName: "Seating");

            migrationBuilder.RenameColumn(
                name: "passengerSpace",
                table: "CarSpecs",
                newName: "PassengerSpace");

            migrationBuilder.RenameColumn(
                name: "maxPayload",
                table: "CarSpecs",
                newName: "MaxPayload");

            migrationBuilder.RenameColumn(
                name: "length",
                table: "CarSpecs",
                newName: "Length");

            migrationBuilder.RenameColumn(
                name: "horsepower",
                table: "CarSpecs",
                newName: "Horsepower");

            migrationBuilder.RenameColumn(
                name: "height",
                table: "CarSpecs",
                newName: "Height");

            migrationBuilder.RenameColumn(
                name: "groundClearance",
                table: "CarSpecs",
                newName: "GroundClearance");

            migrationBuilder.RenameColumn(
                name: "fuelType",
                table: "CarSpecs",
                newName: "FuelType");

            migrationBuilder.RenameColumn(
                name: "fuelEconomy",
                table: "CarSpecs",
                newName: "FuelEconomy");

            migrationBuilder.RenameColumn(
                name: "engine",
                table: "CarSpecs",
                newName: "Engine");

            migrationBuilder.RenameColumn(
                name: "driveTrain",
                table: "CarSpecs",
                newName: "DriveTrain");

            migrationBuilder.RenameColumn(
                name: "cargoSpace",
                table: "CarSpecs",
                newName: "CargoSpace");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CarSpecs",
                newName: "Id");

            migrationBuilder.AlterColumn<decimal>(
                name: "ZeroToSixty",
                table: "CarSpecs",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Width",
                table: "CarSpecs",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Wheelbase",
                table: "CarSpecs",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "CarSpecs",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Transmission",
                table: "CarSpecs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TowingCapacity",
                table: "CarSpecs",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Torque",
                table: "CarSpecs",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TopSpeed",
                table: "CarSpecs",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Seating",
                table: "CarSpecs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PassengerSpace",
                table: "CarSpecs",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MaxPayload",
                table: "CarSpecs",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Length",
                table: "CarSpecs",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Horsepower",
                table: "CarSpecs",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Height",
                table: "CarSpecs",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GroundClearance",
                table: "CarSpecs",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "FuelType",
                table: "CarSpecs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FuelEconomy",
                table: "CarSpecs",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "DriveTrain",
                table: "CarSpecs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CargoSpace",
                table: "CarSpecs",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "carId",
                table: "CarSpecs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "407f0f81-f5fd-4fe8-9889-6a524bc232a1", null, "Customer", "CUSTOMER" },
                    { "4675968c-e308-4e93-8acd-a4569e00efe9", null, "User", "USER" },
                    { "5582d689-8b48-4895-b5eb-98f98f5470c1", null, "Admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CarSpecs_car_carId",
                table: "CarSpecs",
                column: "carId",
                principalTable: "car",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarSpecs_car_carId",
                table: "CarSpecs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "407f0f81-f5fd-4fe8-9889-6a524bc232a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4675968c-e308-4e93-8acd-a4569e00efe9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5582d689-8b48-4895-b5eb-98f98f5470c1");

            migrationBuilder.RenameColumn(
                name: "ZeroToSixty",
                table: "CarSpecs",
                newName: "zeroToSixty");

            migrationBuilder.RenameColumn(
                name: "Width",
                table: "CarSpecs",
                newName: "width");

            migrationBuilder.RenameColumn(
                name: "Wheelbase",
                table: "CarSpecs",
                newName: "wheelbase");

            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "CarSpecs",
                newName: "weight");

            migrationBuilder.RenameColumn(
                name: "Transmission",
                table: "CarSpecs",
                newName: "transmission");

            migrationBuilder.RenameColumn(
                name: "TowingCapacity",
                table: "CarSpecs",
                newName: "towingCapacity");

            migrationBuilder.RenameColumn(
                name: "Torque",
                table: "CarSpecs",
                newName: "torque");

            migrationBuilder.RenameColumn(
                name: "TopSpeed",
                table: "CarSpecs",
                newName: "topSpeed");

            migrationBuilder.RenameColumn(
                name: "Seating",
                table: "CarSpecs",
                newName: "seating");

            migrationBuilder.RenameColumn(
                name: "PassengerSpace",
                table: "CarSpecs",
                newName: "passengerSpace");

            migrationBuilder.RenameColumn(
                name: "MaxPayload",
                table: "CarSpecs",
                newName: "maxPayload");

            migrationBuilder.RenameColumn(
                name: "Length",
                table: "CarSpecs",
                newName: "length");

            migrationBuilder.RenameColumn(
                name: "Horsepower",
                table: "CarSpecs",
                newName: "horsepower");

            migrationBuilder.RenameColumn(
                name: "Height",
                table: "CarSpecs",
                newName: "height");

            migrationBuilder.RenameColumn(
                name: "GroundClearance",
                table: "CarSpecs",
                newName: "groundClearance");

            migrationBuilder.RenameColumn(
                name: "FuelType",
                table: "CarSpecs",
                newName: "fuelType");

            migrationBuilder.RenameColumn(
                name: "FuelEconomy",
                table: "CarSpecs",
                newName: "fuelEconomy");

            migrationBuilder.RenameColumn(
                name: "Engine",
                table: "CarSpecs",
                newName: "engine");

            migrationBuilder.RenameColumn(
                name: "DriveTrain",
                table: "CarSpecs",
                newName: "driveTrain");

            migrationBuilder.RenameColumn(
                name: "CargoSpace",
                table: "CarSpecs",
                newName: "cargoSpace");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CarSpecs",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "carId",
                table: "CarSpecs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "zeroToSixty",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "width",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "wheelbase",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "weight",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "transmission",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "towingCapacity",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "torque",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "topSpeed",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "seating",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "passengerSpace",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "maxPayload",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "length",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "horsepower",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "height",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "groundClearance",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "fuelType",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "fuelEconomy",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "driveTrain",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "cargoSpace",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bedCargoSpace",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedGroundClearance",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedHeight",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedLength",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedLengthWidthHeight",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedLengthWidthHeightCargoSpace",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedLengthWidthHeightGroundClearance",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedLengthWidthHeightMaxPayload",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedLengthWidthHeightMaxTowingCapacity",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedLengthWidthHeightPayload",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedLengthWidthHeightSeating",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedLengthWidthHeightTowingCapacity",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedLengthWidthHeightVolume",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedMaxPayload",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedMaxTowingCapacity",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedPayload",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedSeating",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedTowingCapacity",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedVolume",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedWheelbase",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bedWidth",
                table: "CarSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "305fb194-4fff-4acb-a69d-8043a5ccaddd", null, "Admin", "ADMIN" },
                    { "320dc0d9-983e-498f-a96a-0eb2bfbec843", null, "Customer", "CUSTOMER" },
                    { "8a7cd04f-ae39-486d-94cd-5636f0371c76", null, "User", "USER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CarSpecs_car_carId",
                table: "CarSpecs",
                column: "carId",
                principalTable: "car",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
