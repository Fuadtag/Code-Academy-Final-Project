using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class Admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Admin",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 13, 19, 22, 26, 816, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 13, 19, 22, 26, 816, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 13, 19, 22, 26, 816, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 13, 19, 22, 26, 814, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 13, 19, 22, 26, 816, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 13, 19, 22, 26, 816, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 18, 19, 22, 26, 820, DateTimeKind.Local).AddTicks(7676), new DateTime(2020, 1, 13, 19, 22, 26, 820, DateTimeKind.Local).AddTicks(7214) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Token",
                table: "Admin");

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 13, 18, 49, 56, 377, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 13, 18, 49, 56, 377, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 13, 18, 49, 56, 377, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 13, 18, 49, 56, 375, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 13, 18, 49, 56, 377, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 13, 18, 49, 56, 377, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 18, 18, 49, 56, 381, DateTimeKind.Local).AddTicks(406), new DateTime(2020, 1, 13, 18, 49, 56, 380, DateTimeKind.Local).AddTicks(9947) });
        }
    }
}
