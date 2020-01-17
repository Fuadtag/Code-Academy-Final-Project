using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 49, 30, 491, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 49, 30, 494, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 49, 30, 494, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 49, 30, 494, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 49, 30, 494, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 49, 30, 494, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 49, 30, 495, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 49, 30, 495, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 49, 30, 495, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "CustomerReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 49, 30, 499, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 22, 15, 49, 30, 499, DateTimeKind.Local).AddTicks(7613), new DateTime(2020, 1, 17, 15, 49, 30, 499, DateTimeKind.Local).AddTicks(6905) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 47, 0, 432, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 47, 0, 434, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 47, 0, 434, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 47, 0, 434, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 47, 0, 434, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 47, 0, 434, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 47, 0, 434, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 47, 0, 435, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 47, 0, 435, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "CustomerReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 17, 15, 47, 0, 438, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 22, 15, 47, 0, 439, DateTimeKind.Local), new DateTime(2020, 1, 17, 15, 47, 0, 438, DateTimeKind.Local).AddTicks(8966) });
        }
    }
}
