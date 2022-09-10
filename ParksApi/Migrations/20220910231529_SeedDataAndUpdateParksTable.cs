using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksApi.Migrations
{
    public partial class SeedDataAndUpdateParksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Parks");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Parks",
                type: "varchar(12) CHARACTER SET utf8mb4",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ParkName",
                table: "Parks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "AreaInAcres",
                table: "Parks",
                type: "double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CityOrClosestCity",
                table: "Parks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "StateOrNational",
                table: "Parks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false);

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "AreaInAcres", "CityOrClosestCity", "DateEstablished", "ParkName", "State", "StateOrNational" },
                values: new object[,]
                {
                    { 1, 4740911.1600000001, "Denali Park", new DateTime(1917, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denali", "Alaska", "National Park" },
                    { 2, 183224.04999999999, "Klamath Falls", new DateTime(1902, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crater Lake", "Oregon", "National Park" },
                    { 3, 310044.35999999999, "Moose", new DateTime(1929, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grand Teton", "Wyoming", "National Park" },
                    { 4, 922649.41000000003, "Port Angeles", new DateTime(1938, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olympic", "Washington", "National Park" },
                    { 5, 1013126.39, "Kalispell", new DateTime(1910, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Glacier", "Montana", "National Park" },
                    { 6, 64701.220000000001, "Key West", new DateTime(1992, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dry Tortugas", "Florida", "National Park" },
                    { 7, 168.0, "Union", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1932), "Catherine Creek State Park", "Oregon", "State Park" },
                    { 8, 165.0, "Joseph", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1941), "Wallowa Lake State Park", "Oregon", "State Park" },
                    { 9, 740.0, "Poland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1965), "Range Pond", "Maine", "State Park" },
                    { 10, 801163.20999999996, "Terlingua", new DateTime(1944, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Big Bend", "Texas", "National Park" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "CityOrClosestCity",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "StateOrNational",
                table: "Parks");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Parks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(12) CHARACTER SET utf8mb4",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "ParkName",
                table: "Parks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "AreaInAcres",
                table: "Parks",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Parks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
