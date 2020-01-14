using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class BlogsSorting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 44, 51, 540, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 44, 51, 540, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 44, 51, 540, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 44, 51, 538, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 44, 51, 540, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 44, 51, 540, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2020, 1, 14, 12, 44, 51, 540, DateTimeKind.Local).AddTicks(2774), "A standard blog post with image4" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2020, 1, 14, 12, 44, 51, 540, DateTimeKind.Local).AddTicks(2775), "A standard blog post with image5" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2020, 1, 14, 12, 44, 51, 540, DateTimeKind.Local).AddTicks(2777), "A standard blog post with image6" });

            migrationBuilder.UpdateData(
                table: "CustomerReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 44, 51, 544, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 19, 12, 44, 51, 544, DateTimeKind.Local).AddTicks(3433), new DateTime(2020, 1, 14, 12, 44, 51, 544, DateTimeKind.Local).AddTicks(2978) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 43, 29, 163, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 43, 29, 163, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 43, 29, 163, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 43, 29, 161, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 43, 29, 162, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 43, 29, 162, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2020, 1, 14, 12, 43, 29, 162, DateTimeKind.Local).AddTicks(8156), "A standard blog post with image" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2020, 1, 14, 12, 43, 29, 162, DateTimeKind.Local).AddTicks(8158), "A standard blog post with image" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2020, 1, 14, 12, 43, 29, 162, DateTimeKind.Local).AddTicks(8160), "A standard blog post with image" });

            migrationBuilder.UpdateData(
                table: "CustomerReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 43, 29, 167, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 19, 12, 43, 29, 167, DateTimeKind.Local).AddTicks(5448), new DateTime(2020, 1, 14, 12, 43, 29, 167, DateTimeKind.Local).AddTicks(4995) });
        }
    }
}
