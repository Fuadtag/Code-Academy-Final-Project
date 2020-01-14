using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class CarsSort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 13, 8, 20, 947, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 13, 8, 20, 947, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 13, 8, 20, 947, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 13, 8, 20, 945, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 13, 8, 20, 947, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 13, 8, 20, 947, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 13, 8, 20, 947, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 13, 8, 20, 947, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 13, 8, 20, 947, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarModelId", "CartPhoto", "DailyPrice", "Description", "DetailPhoto", "Discount", "Door", "Fuel", "Luggage", "Passsenger", "Photo", "Status", "Title", "Transmission" },
                values: new object[,]
                {
                    { 8, 2, "cart-item-1.jpg", 200m, "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.", "single-car-thumb.jpg", (byte)0, (byte)5, 0, (byte)4, (byte)5, "car-1.jpg", true, "Mauris semper nisl a massa convallis7", 0 },
                    { 9, 2, "cart-item-1.jpg", 200m, "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.", "single-car-thumb.jpg", (byte)0, (byte)5, 0, (byte)4, (byte)5, "car-1.jpg", true, "Mauris semper nisl a massa convallis8", 0 },
                    { 6, 2, "cart-item-1.jpg", 200m, "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.", "single-car-thumb.jpg", (byte)0, (byte)5, 0, (byte)4, (byte)5, "car-1.jpg", true, "Mauris semper nisl a massa convallis5", 0 },
                    { 5, 2, "cart-item-1.jpg", 200m, "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.", "single-car-thumb.jpg", (byte)0, (byte)5, 0, (byte)4, (byte)5, "car-1.jpg", true, "Mauris semper nisl a massa convallis", 0 },
                    { 7, 2, "cart-item-1.jpg", 200m, "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.", "single-car-thumb.jpg", (byte)0, (byte)5, 0, (byte)4, (byte)5, "car-1.jpg", true, "Mauris semper nisl a massa convallis6", 0 },
                    { 4, 2, "cart-item-1.jpg", 200m, "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.", "single-car-thumb.jpg", (byte)0, (byte)5, 0, (byte)4, (byte)5, "car-1.jpg", true, "Mauris semper nisl a massa convallis", 0 }
                });

            migrationBuilder.UpdateData(
                table: "CustomerReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 13, 8, 20, 951, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DropDate", "PickupDate" },
                values: new object[] { new DateTime(2020, 1, 19, 13, 8, 20, 951, DateTimeKind.Local).AddTicks(7547), new DateTime(2020, 1, 14, 13, 8, 20, 951, DateTimeKind.Local).AddTicks(7064) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

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
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 44, 51, 540, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 44, 51, 540, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 14, 12, 44, 51, 540, DateTimeKind.Local).AddTicks(2777));

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
    }
}
