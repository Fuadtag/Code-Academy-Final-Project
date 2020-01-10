using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class GalleryAndGalleryItemTablesCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GalleryItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GalleryId = table.Column<int>(nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    PhotoSm = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GalleryItems_Galleries_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Galleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 16, 39, 10, 344, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 16, 39, 10, 345, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 16, 39, 10, 345, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 16, 39, 10, 342, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 16, 39, 10, 344, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 10, 16, 39, 10, 344, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.InsertData(
                table: "Galleries",
                column: "Id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 15, 16, 39, 10, 350, DateTimeKind.Local).AddTicks(4112), new DateTime(2020, 1, 10, 16, 39, 10, 350, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.InsertData(
                table: "GalleryItems",
                columns: new[] { "Id", "GalleryId", "Photo", "PhotoSm" },
                values: new object[,]
                {
                    { 1, 1, "gallery-sm-1.jpg", "gallery-sm-1.jpg" },
                    { 2, 1, "gallery-sm-1.jpg", "gallery-sm-1.jpg" },
                    { 3, 1, "gallery-sm-1.jpg", "gallery-sm-1.jpg" },
                    { 4, 1, "gallery-sm-1.jpg", "gallery-sm-1.jpg" },
                    { 5, 1, "gallery-sm-1.jpg", "gallery-sm-1.jpg" },
                    { 6, 1, "gallery-sm-1.jpg", "gallery-sm-1.jpg" },
                    { 7, 1, "gallery-sm-1.jpg", "gallery-sm-1.jpg" },
                    { 8, 1, "gallery-sm-1.jpg", "gallery-sm-1.jpg" },
                    { 9, 1, "gallery-sm-1.jpg", "gallery-sm-1.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GalleryItems_GalleryId",
                table: "GalleryItems",
                column: "GalleryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GalleryItems");

            migrationBuilder.DropTable(
                name: "Galleries");

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

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 15, 16, 25, 4, 646, DateTimeKind.Local).AddTicks(5140), new DateTime(2020, 1, 10, 16, 25, 4, 646, DateTimeKind.Local).AddTicks(4454) });
        }
    }
}
