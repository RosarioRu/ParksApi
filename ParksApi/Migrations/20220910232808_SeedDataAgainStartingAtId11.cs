using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksApi.Migrations
{
    public partial class SeedDataAgainStartingAtId11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "AreaInAcres", "CityOrClosestCity", "DateEstablished", "ParkName", "State", "StateOrNational" },
                values: new object[,]
                {
                    { 11, 4740911.1600000001, "Denali Park", new DateTime(1917, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denali", "Alaska", "National Park" },
                    { 12, 183224.04999999999, "Klamath Falls", new DateTime(1902, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crater Lake", "Oregon", "National Park" },
                    { 13, 310044.35999999999, "Moose", new DateTime(1929, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grand Teton", "Wyoming", "National Park" },
                    { 14, 922649.41000000003, "Port Angeles", new DateTime(1938, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olympic", "Washington", "National Park" },
                    { 15, 1013126.39, "Kalispell", new DateTime(1910, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Glacier", "Montana", "National Park" },
                    { 16, 64701.220000000001, "Key West", new DateTime(1992, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dry Tortugas", "Florida", "National Park" },
                    { 17, 168.0, "Union", new DateTime(1932, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Catherine Creek State Park", "Oregon", "State Park" },
                    { 18, 165.0, "Joseph", new DateTime(1941, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wallowa Lake State Park", "Oregon", "State Park" },
                    { 19, 740.0, "Poland", new DateTime(1965, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Range Pond", "Maine", "State Park" },
                    { 20, 801163.20999999996, "Terlingua", new DateTime(1944, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Big Bend", "Texas", "National Park" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 20);

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
                    { 7, 168.0, "Union", new DateTime(1932, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Catherine Creek State Park", "Oregon", "State Park" },
                    { 8, 165.0, "Joseph", new DateTime(1941, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wallowa Lake State Park", "Oregon", "State Park" },
                    { 9, 740.0, "Poland", new DateTime(1965, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Range Pond", "Maine", "State Park" },
                    { 10, 801163.20999999996, "Terlingua", new DateTime(1944, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Big Bend", "Texas", "National Park" }
                });
        }
    }
}
