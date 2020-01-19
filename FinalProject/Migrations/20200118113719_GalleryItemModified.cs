using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class GalleryItemModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhotoSm",
                table: "GalleryItems",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "GalleryItems",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 18, 15, 37, 18, 279, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 18, 15, 37, 18, 281, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 18, 15, 37, 18, 281, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 18, 15, 37, 18, 281, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 18, 15, 37, 18, 281, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 18, 15, 37, 18, 281, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 18, 15, 37, 18, 281, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 18, 15, 37, 18, 282, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 18, 15, 37, 18, 282, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "CustomerReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 18, 15, 37, 18, 286, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 23, 15, 37, 18, 287, DateTimeKind.Local).AddTicks(629), new DateTime(2020, 1, 18, 15, 37, 18, 287, DateTimeKind.Local).AddTicks(132) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhotoSm",
                table: "GalleryItems",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "GalleryItems",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
