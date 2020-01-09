using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class InfoTextAddedToBlogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.AddColumn<string>(
                name: "InfoText",
                table: "Blogs",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAdmin", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AppAdmin",
                columns: new[] { "Id", "Email", "Name", "Password", "Surname" },
                values: new object[] { 1, "fuadjt@code.edu.az", "Fuad", "admin123", "Taghiyev" });

            migrationBuilder.InsertData(
                table: "BlogComments",
                columns: new[] { "Id", "AuthorId", "BlogId", "CreatedAt", "Text" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2020, 1, 9, 17, 34, 51, 210, DateTimeKind.Local).AddTicks(3728), "Mauris lobortis sapien non tellus maximus volutpat. Nam aliquet quis erat et luctus. Sed dignissim id felis vitae fringilla. Maecenas faucibus enim eu mattis iaculis. In ultrices laoreet diam ac tempus." },
                    { 12, 2, 2, new DateTime(2020, 1, 9, 17, 34, 51, 210, DateTimeKind.Local).AddTicks(5612), "Mauris lobortis sapien non tellus maximus volutpat. Nam aliquet quis erat et luctus. Sed dignissim id felis vitae fringilla. Maecenas faucibus enim eu mattis iaculis. In ultrices laoreet diam ac tempus." },
                    { 3, 3, 3, new DateTime(2020, 1, 9, 17, 34, 51, 210, DateTimeKind.Local).AddTicks(5647), "Mauris lobortis sapien non tellus maximus volutpat. Nam aliquet quis erat et luctus. Sed dignissim id felis vitae fringilla. Maecenas faucibus enim eu mattis iaculis. In ultrices laoreet diam ac tempus." }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "InfoText" },
                values: new object[] { new DateTime(2020, 1, 9, 17, 34, 51, 207, DateTimeKind.Local).AddTicks(6923), "Aliquam erat volutpat. Morbi eget velit ut lectus efficitur vulputate dictum vel ex. Etiam bibendum libero eget lorem malesuada, id mattis est egestas. Mauris eu quam bibendum, placerat odio non, ultrices leo. Proin laoreet purus nisl, non elementum tortor accumsan vitae. Proin commodo vulputate purus, eu dignissim ipsum lobortis ut. Sed ac nisi velit. Integer magna mi, faucibus a sapien eget, volutpat euismod dolor." });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "InfoText" },
                values: new object[] { new DateTime(2020, 1, 9, 17, 34, 51, 209, DateTimeKind.Local).AddTicks(9220), "Aliquam erat volutpat. Morbi eget velit ut lectus efficitur vulputate dictum vel ex. Etiam bibendum libero eget lorem malesuada, id mattis est egestas. Mauris eu quam bibendum, placerat odio non, ultrices leo. Proin laoreet purus nisl, non elementum tortor accumsan vitae. Proin commodo vulputate purus, eu dignissim ipsum lobortis ut. Sed ac nisi velit. Integer magna mi, faucibus a sapien eget, volutpat euismod dolor." });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "InfoText" },
                values: new object[] { new DateTime(2020, 1, 9, 17, 34, 51, 209, DateTimeKind.Local).AddTicks(9350), "Aliquam erat volutpat. Morbi eget velit ut lectus efficitur vulputate dictum vel ex. Etiam bibendum libero eget lorem malesuada, id mattis est egestas. Mauris eu quam bibendum, placerat odio non, ultrices leo. Proin laoreet purus nisl, non elementum tortor accumsan vitae. Proin commodo vulputate purus, eu dignissim ipsum lobortis ut. Sed ac nisi velit. Integer magna mi, faucibus a sapien eget, volutpat euismod dolor." });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 14, 17, 34, 51, 217, DateTimeKind.Local).AddTicks(4651), new DateTime(2020, 1, 9, 17, 34, 51, 217, DateTimeKind.Local).AddTicks(3855) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppAdmin");

            migrationBuilder.DeleteData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "InfoText",
                table: "Blogs");

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "Email", "Name", "Password", "Surname" },
                values: new object[] { 1, "fuadjt@code.edu.az", "Fuad", "admin123", "Taghiyev" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 8, 15, 39, 54, 426, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 8, 15, 39, 54, 429, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 8, 15, 39, 54, 429, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 13, 15, 39, 54, 434, DateTimeKind.Local).AddTicks(9677), new DateTime(2020, 1, 8, 15, 39, 54, 434, DateTimeKind.Local).AddTicks(8894) });
        }
    }
}
