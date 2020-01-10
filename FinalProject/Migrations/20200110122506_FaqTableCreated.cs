using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class FaqTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 16, 25, 4, 641, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 16, 25, 4, 641, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 16, 25, 4, 641, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 16, 25, 4, 638, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 16, 25, 4, 640, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 16, 25, 4, 640, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "Question" },
                values: new object[,]
                {
                    { 1, "Mauris ornare cursus urna vel tincidunt. Mauris sit amet molestie lacus, at blandit sapien. Nullam ac ipsum eget dui feugiat commodo. Quisque facilisis sem finibus eros pellentesque, cursus elementum massa accumsan. Donec cursus, felis non molestie tincidunt, nulla mi faucibus quam, ut aliquet orci ante volutpat arcu. Praesent sed ex non leo sodales lacinia.", "What is your favorite fruit?" },
                    { 2, "Mauris ornare cursus urna vel tincidunt. Mauris sit amet molestie lacus, at blandit sapien. Nullam ac ipsum eget dui feugiat commodo. Quisque facilisis sem finibus eros pellentesque, cursus elementum massa accumsan. Donec cursus, felis non molestie tincidunt, nulla mi faucibus quam, ut aliquet orci ante volutpat arcu. Praesent sed ex non leo sodales lacinia.", "What is your favorite fruit?" },
                    { 3, "Mauris ornare cursus urna vel tincidunt. Mauris sit amet molestie lacus, at blandit sapien. Nullam ac ipsum eget dui feugiat commodo. Quisque facilisis sem finibus eros pellentesque, cursus elementum massa accumsan. Donec cursus, felis non molestie tincidunt, nulla mi faucibus quam, ut aliquet orci ante volutpat arcu. Praesent sed ex non leo sodales lacinia.", "What is your favorite fruit?" },
                    { 4, "Mauris ornare cursus urna vel tincidunt. Mauris sit amet molestie lacus, at blandit sapien. Nullam ac ipsum eget dui feugiat commodo. Quisque facilisis sem finibus eros pellentesque, cursus elementum massa accumsan. Donec cursus, felis non molestie tincidunt, nulla mi faucibus quam, ut aliquet orci ante volutpat arcu. Praesent sed ex non leo sodales lacinia.", "What is your favorite fruit?" },
                    { 5, "Mauris ornare cursus urna vel tincidunt. Mauris sit amet molestie lacus, at blandit sapien. Nullam ac ipsum eget dui feugiat commodo. Quisque facilisis sem finibus eros pellentesque, cursus elementum massa accumsan. Donec cursus, felis non molestie tincidunt, nulla mi faucibus quam, ut aliquet orci ante volutpat arcu. Praesent sed ex non leo sodales lacinia.", "What is your favorite fruit?" },
                    { 6, "Mauris ornare cursus urna vel tincidunt. Mauris sit amet molestie lacus, at blandit sapien. Nullam ac ipsum eget dui feugiat commodo. Quisque facilisis sem finibus eros pellentesque, cursus elementum massa accumsan. Donec cursus, felis non molestie tincidunt, nulla mi faucibus quam, ut aliquet orci ante volutpat arcu. Praesent sed ex non leo sodales lacinia.", "What is your favorite fruit?" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 15, 16, 25, 4, 646, DateTimeKind.Local).AddTicks(5140), new DateTime(2020, 1, 10, 16, 25, 4, 646, DateTimeKind.Local).AddTicks(4454) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faqs");

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
