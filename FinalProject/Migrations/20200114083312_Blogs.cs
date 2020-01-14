using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class Blogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 33, 11, 670, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 33, 11, 670, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 33, 11, 670, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 33, 11, 669, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 33, 11, 670, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 33, 11, 670, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2020, 1, 14, 12, 33, 11, 670, DateTimeKind.Local).AddTicks(5672), "Expanding Your Home Network’s Reach4" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2020, 1, 14, 12, 33, 11, 670, DateTimeKind.Local).AddTicks(5674), "Expanding Your Home Network’s Reach5" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2020, 1, 14, 12, 33, 11, 670, DateTimeKind.Local).AddTicks(5676), "Expanding Your Home Network’s Reach6" });

            migrationBuilder.UpdateData(
                table: "CustomerReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 33, 11, 674, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 19, 12, 33, 11, 674, DateTimeKind.Local).AddTicks(5917), new DateTime(2020, 1, 14, 12, 33, 11, 674, DateTimeKind.Local).AddTicks(5456) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 11, 58, 0, 143, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 11, 58, 0, 143, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 11, 58, 0, 143, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 11, 58, 0, 141, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 11, 58, 0, 143, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 11, 58, 0, 143, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2020, 1, 14, 11, 58, 0, 143, DateTimeKind.Local).AddTicks(1589), "Expanding Your Home Network’s Reach" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2020, 1, 14, 11, 58, 0, 143, DateTimeKind.Local).AddTicks(1591), "Expanding Your Home Network’s Reach" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2020, 1, 14, 11, 58, 0, 143, DateTimeKind.Local).AddTicks(1593), "Expanding Your Home Network’s Reach" });

            migrationBuilder.UpdateData(
                table: "CustomerReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 11, 58, 0, 146, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 19, 11, 58, 0, 147, DateTimeKind.Local).AddTicks(1816), new DateTime(2020, 1, 14, 11, 58, 0, 147, DateTimeKind.Local).AddTicks(1017) });
        }
    }
}
