using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 14, 34, 37, 84, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 14, 34, 37, 84, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 14, 34, 37, 84, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 14, 34, 37, 82, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 14, 34, 37, 84, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 14, 34, 37, 84, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Icon", "Text", "Title" },
                values: new object[,]
                {
                    { 1, "lnr-star", "Fusce blandit at tortor vitae ultricies. Praesent efficitur feugiat leo id tempus. Sed pulvinar gravida sodales.", "Best Price Guarantee" },
                    { 2, "lnr-star", "Fusce blandit at tortor vitae ultricies. Praesent efficitur feugiat leo id tempus. Sed pulvinar gravida sodales.", "Best Price Guarantee" },
                    { 3, "lnr-star", "Fusce blandit at tortor vitae ultricies. Praesent efficitur feugiat leo id tempus. Sed pulvinar gravida sodales.", "Best Price Guarantee" },
                    { 4, "lnr-star", "Fusce blandit at tortor vitae ultricies. Praesent efficitur feugiat leo id tempus. Sed pulvinar gravida sodales.", "Best Price Guarantee" },
                    { 5, "lnr-star", "Fusce blandit at tortor vitae ultricies. Praesent efficitur feugiat leo id tempus. Sed pulvinar gravida sodales.", "Best Price Guarantee" },
                    { 6, "lnr-star", "Fusce blandit at tortor vitae ultricies. Praesent efficitur feugiat leo id tempus. Sed pulvinar gravida sodales.", "Best Price Guarantee" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 15, 14, 34, 37, 89, DateTimeKind.Local).AddTicks(99), new DateTime(2020, 1, 10, 14, 34, 37, 88, DateTimeKind.Local).AddTicks(9448) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 13, 28, 26, 809, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 13, 28, 26, 809, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 13, 28, 26, 809, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 13, 28, 26, 807, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 13, 28, 26, 809, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 13, 28, 26, 809, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 15, 13, 28, 26, 815, DateTimeKind.Local).AddTicks(2494), new DateTime(2020, 1, 10, 13, 28, 26, 815, DateTimeKind.Local).AddTicks(1740) });
        }
    }
}
