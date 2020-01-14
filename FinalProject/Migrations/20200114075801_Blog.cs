using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class Blog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "AuthorId", "BlogCategoryId", "CreatedAt", "InfoText", "Likes", "Name", "Photo", "PhotoSm", "Slug", "Text", "Title", "TopText", "Visited" },
                values: new object[,]
                {
                    { 4, 3, 4, new DateTime(2020, 1, 14, 11, 58, 0, 143, DateTimeKind.Local).AddTicks(1589), "Aliquam erat volutpat. Morbi eget velit ut lectus efficitur vulputate dictum vel ex. Etiam bibendum libero eget lorem malesuada, id mattis est egestas. Mauris eu quam bibendum, placerat odio non, ultrices leo. Proin laoreet purus nisl, non elementum tortor accumsan vitae. Proin commodo vulputate purus, eu dignissim ipsum lobortis ut. Sed ac nisi velit. Integer magna mi, faucibus a sapien eget, volutpat euismod dolor.", 0, "Expanding Your Home Network’s Reach", "post-item-1.jpg", "blog-item-sm-1.jpg", "expanding-your-home-networks-reach", "Aliquam non sodales felis. Fusce luctus porta tincidunt. Etiam aliquet varius est vestibulum consectetur. Donec arcu justo, fringilla sit amet nisi eu, hendrerit facilisis justo. Donec nisl risus, tincidunt at augue eget, ultrices varius orci. Fusce hendrerit lacus in volutpat malesuada. Vestibulum mattis tellus at purus pretium ullamcorper. In hac habitasse platea dictumst.Integer consectetur condimentum dolor eu consequat.Suspendisse dictum,tellus id semper pretium,velit lorem iaculis felis,sit amet ullamcorper mauris nisl at urna.Proin vel nibh ligula.Integer id ipsum quis eros sodales consectetur vel elementum urna.Morbi facilisis interdum nunc eu commodo.Maecenas magna tellus,dictum at dolor non,rutrum lacinia tellus.Integer accumsan velit est,ac bibendum ante fringilla sit amet.Mauris faucibus pellentesque elementum.Proin in convallis erat.Maecenas tincidunt cursus euismod.Maecenas quis felis diam.Suspendisse imperdiet tellus eget nunc fringilla fermentum.Fusce nisl neque,lobortis sed turpis ac,faucibus mattis nibh.Vivamus posuere dolor in euismod maximus.Donec velit nisi,rutrum iaculis libero sollicitudin,aliquam congue arcu.", "A standard blog post with image", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in tortor sed eros consequat rutrum eget iaculis lacus. Aenean ac sapien risus. Nullam eget lobortis odio. Nulla ac lacus in nunc sagittis pretium ut ac nulla. In mollis hendrerit metus, eu posuere dolor hendrerit vel. Duis sit amet tortor imperdiet nisl aliquam scelerisque. Suspendisse lobortis condimentum fermentum. In volutpat est libero, a facilisis ipsum pharetra eu. Fusce condimentum metus id ante auctor pellentesque. Donec placerat ornare risus ut sodales. In accumsan risus nec sodales ultrices. Vestibulum auctor auctor sodales. Donec varius volutpat tellus dapibus fringilla.Duis id leo gravida,convallis lorem ac,tincidunt tortor.Fusce in mollis eros,ac tempor purus.Nulla facilisi.Nam dictum neque quis felis iaculis,ut condimentum ex feugiat.Sed tincidunt velit sem,non elementum nibh dapibus eget.Cras at sagittis tellus.Donec vitae ullamcorper mi.Donec in ornare lacus.Cras elementum mi eget vestibulum pulvinar.Sed accumsan vel lorem ut ultricies.", 0 },
                    { 5, 3, 4, new DateTime(2020, 1, 14, 11, 58, 0, 143, DateTimeKind.Local).AddTicks(1591), "Aliquam erat volutpat. Morbi eget velit ut lectus efficitur vulputate dictum vel ex. Etiam bibendum libero eget lorem malesuada, id mattis est egestas. Mauris eu quam bibendum, placerat odio non, ultrices leo. Proin laoreet purus nisl, non elementum tortor accumsan vitae. Proin commodo vulputate purus, eu dignissim ipsum lobortis ut. Sed ac nisi velit. Integer magna mi, faucibus a sapien eget, volutpat euismod dolor.", 0, "Expanding Your Home Network’s Reach", "post-item-1.jpg", "blog-item-sm-1.jpg", "expanding-your-home-networks-reach", "Aliquam non sodales felis. Fusce luctus porta tincidunt. Etiam aliquet varius est vestibulum consectetur. Donec arcu justo, fringilla sit amet nisi eu, hendrerit facilisis justo. Donec nisl risus, tincidunt at augue eget, ultrices varius orci. Fusce hendrerit lacus in volutpat malesuada. Vestibulum mattis tellus at purus pretium ullamcorper. In hac habitasse platea dictumst.Integer consectetur condimentum dolor eu consequat.Suspendisse dictum,tellus id semper pretium,velit lorem iaculis felis,sit amet ullamcorper mauris nisl at urna.Proin vel nibh ligula.Integer id ipsum quis eros sodales consectetur vel elementum urna.Morbi facilisis interdum nunc eu commodo.Maecenas magna tellus,dictum at dolor non,rutrum lacinia tellus.Integer accumsan velit est,ac bibendum ante fringilla sit amet.Mauris faucibus pellentesque elementum.Proin in convallis erat.Maecenas tincidunt cursus euismod.Maecenas quis felis diam.Suspendisse imperdiet tellus eget nunc fringilla fermentum.Fusce nisl neque,lobortis sed turpis ac,faucibus mattis nibh.Vivamus posuere dolor in euismod maximus.Donec velit nisi,rutrum iaculis libero sollicitudin,aliquam congue arcu.", "A standard blog post with image", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in tortor sed eros consequat rutrum eget iaculis lacus. Aenean ac sapien risus. Nullam eget lobortis odio. Nulla ac lacus in nunc sagittis pretium ut ac nulla. In mollis hendrerit metus, eu posuere dolor hendrerit vel. Duis sit amet tortor imperdiet nisl aliquam scelerisque. Suspendisse lobortis condimentum fermentum. In volutpat est libero, a facilisis ipsum pharetra eu. Fusce condimentum metus id ante auctor pellentesque. Donec placerat ornare risus ut sodales. In accumsan risus nec sodales ultrices. Vestibulum auctor auctor sodales. Donec varius volutpat tellus dapibus fringilla.Duis id leo gravida,convallis lorem ac,tincidunt tortor.Fusce in mollis eros,ac tempor purus.Nulla facilisi.Nam dictum neque quis felis iaculis,ut condimentum ex feugiat.Sed tincidunt velit sem,non elementum nibh dapibus eget.Cras at sagittis tellus.Donec vitae ullamcorper mi.Donec in ornare lacus.Cras elementum mi eget vestibulum pulvinar.Sed accumsan vel lorem ut ultricies.", 0 },
                    { 6, 3, 4, new DateTime(2020, 1, 14, 11, 58, 0, 143, DateTimeKind.Local).AddTicks(1593), "Aliquam erat volutpat. Morbi eget velit ut lectus efficitur vulputate dictum vel ex. Etiam bibendum libero eget lorem malesuada, id mattis est egestas. Mauris eu quam bibendum, placerat odio non, ultrices leo. Proin laoreet purus nisl, non elementum tortor accumsan vitae. Proin commodo vulputate purus, eu dignissim ipsum lobortis ut. Sed ac nisi velit. Integer magna mi, faucibus a sapien eget, volutpat euismod dolor.", 0, "Expanding Your Home Network’s Reach", "post-item-1.jpg", "blog-item-sm-1.jpg", "expanding-your-home-networks-reach", "Aliquam non sodales felis. Fusce luctus porta tincidunt. Etiam aliquet varius est vestibulum consectetur. Donec arcu justo, fringilla sit amet nisi eu, hendrerit facilisis justo. Donec nisl risus, tincidunt at augue eget, ultrices varius orci. Fusce hendrerit lacus in volutpat malesuada. Vestibulum mattis tellus at purus pretium ullamcorper. In hac habitasse platea dictumst.Integer consectetur condimentum dolor eu consequat.Suspendisse dictum,tellus id semper pretium,velit lorem iaculis felis,sit amet ullamcorper mauris nisl at urna.Proin vel nibh ligula.Integer id ipsum quis eros sodales consectetur vel elementum urna.Morbi facilisis interdum nunc eu commodo.Maecenas magna tellus,dictum at dolor non,rutrum lacinia tellus.Integer accumsan velit est,ac bibendum ante fringilla sit amet.Mauris faucibus pellentesque elementum.Proin in convallis erat.Maecenas tincidunt cursus euismod.Maecenas quis felis diam.Suspendisse imperdiet tellus eget nunc fringilla fermentum.Fusce nisl neque,lobortis sed turpis ac,faucibus mattis nibh.Vivamus posuere dolor in euismod maximus.Donec velit nisi,rutrum iaculis libero sollicitudin,aliquam congue arcu.", "A standard blog post with image", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in tortor sed eros consequat rutrum eget iaculis lacus. Aenean ac sapien risus. Nullam eget lobortis odio. Nulla ac lacus in nunc sagittis pretium ut ac nulla. In mollis hendrerit metus, eu posuere dolor hendrerit vel. Duis sit amet tortor imperdiet nisl aliquam scelerisque. Suspendisse lobortis condimentum fermentum. In volutpat est libero, a facilisis ipsum pharetra eu. Fusce condimentum metus id ante auctor pellentesque. Donec placerat ornare risus ut sodales. In accumsan risus nec sodales ultrices. Vestibulum auctor auctor sodales. Donec varius volutpat tellus dapibus fringilla.Duis id leo gravida,convallis lorem ac,tincidunt tortor.Fusce in mollis eros,ac tempor purus.Nulla facilisi.Nam dictum neque quis felis iaculis,ut condimentum ex feugiat.Sed tincidunt velit sem,non elementum nibh dapibus eget.Cras at sagittis tellus.Donec vitae ullamcorper mi.Donec in ornare lacus.Cras elementum mi eget vestibulum pulvinar.Sed accumsan vel lorem ut ultricies.", 0 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 0, 12, 55, 223, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 0, 12, 55, 223, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 0, 12, 55, 223, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 0, 12, 55, 221, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 0, 12, 55, 223, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 0, 12, 55, 223, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "CustomerReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 0, 12, 55, 227, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 19, 0, 12, 55, 227, DateTimeKind.Local).AddTicks(7781), new DateTime(2020, 1, 14, 0, 12, 55, 227, DateTimeKind.Local).AddTicks(7304) });
        }
    }
}
