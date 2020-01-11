using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class OrderByAddedToTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 32, 6, 430, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 32, 6, 430, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 32, 6, 430, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 32, 6, 427, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 32, 6, 430, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 32, 6, 430, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 16, 14, 32, 6, 435, DateTimeKind.Local).AddTicks(4630), new DateTime(2020, 1, 11, 14, 32, 6, 435, DateTimeKind.Local).AddTicks(3950) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 26, 14, 648, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 26, 14, 648, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 26, 14, 648, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 26, 14, 646, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 26, 14, 648, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 26, 14, 648, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 16, 14, 26, 14, 653, DateTimeKind.Local).AddTicks(6875), new DateTime(2020, 1, 11, 14, 26, 14, 653, DateTimeKind.Local).AddTicks(6245) });
        }
    }
}
