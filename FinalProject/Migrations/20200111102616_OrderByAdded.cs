using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class OrderByAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 15, 36, 933, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 15, 36, 933, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 15, 36, 933, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 15, 36, 930, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 15, 36, 932, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 11, 14, 15, 36, 932, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 16, 14, 15, 36, 939, DateTimeKind.Local).AddTicks(486), new DateTime(2020, 1, 11, 14, 15, 36, 938, DateTimeKind.Local).AddTicks(9784) });
        }
    }
}
