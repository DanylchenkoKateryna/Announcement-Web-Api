using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "announcements",
                columns: new[] { "Id", "DateAdded", "Description", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2001, 1, 19, 19, 54, 31, 503, DateTimeKind.Unspecified).AddTicks(6712), "Ipsum corrupti eveniet numquam possimus.", "veritatis" },
                    { 2, new DateTime(2005, 10, 3, 16, 29, 20, 785, DateTimeKind.Unspecified).AddTicks(4208), "Qui quasi suscipit ut.", "recusandae" },
                    { 3, new DateTime(2009, 11, 4, 0, 17, 18, 510, DateTimeKind.Unspecified).AddTicks(9699), "Officia saepe sapiente aperiam vero at fugiat ratione.", "quia" },
                    { 4, new DateTime(2014, 12, 22, 0, 18, 33, 149, DateTimeKind.Unspecified).AddTicks(1440), "Eius ut numquam rem nisi error quia qui veniam quia.", "qui" },
                    { 5, new DateTime(2004, 7, 21, 13, 29, 11, 62, DateTimeKind.Unspecified).AddTicks(1798), "In quisquam dolor consequatur commodi sit aut qui.", "earum" },
                    { 6, new DateTime(2011, 3, 17, 17, 50, 55, 185, DateTimeKind.Unspecified).AddTicks(5864), "Hic ipsum numquam sed dolores suscipit nisi.", "nisi" },
                    { 7, new DateTime(2009, 11, 2, 21, 49, 58, 584, DateTimeKind.Unspecified).AddTicks(939), "Dolorem optio hic tempore est assumenda quia autem ipsa.", "harum" },
                    { 8, new DateTime(2020, 12, 5, 17, 30, 0, 335, DateTimeKind.Unspecified).AddTicks(8666), "Tempora praesentium eos tempore dolorem dolor labore cumque autem accusantium.", "hic" },
                    { 9, new DateTime(2007, 3, 29, 22, 7, 25, 775, DateTimeKind.Unspecified).AddTicks(8160), "Ipsum aliquid ut tenetur rerum voluptatibus nesciunt.", "libero" },
                    { 10, new DateTime(2013, 12, 8, 6, 14, 0, 763, DateTimeKind.Unspecified).AddTicks(1492), "Voluptatem tempora suscipit rerum velit nihil autem voluptatem molestiae.", "recusandae" },
                    { 11, new DateTime(2006, 7, 27, 12, 25, 33, 977, DateTimeKind.Unspecified).AddTicks(7363), "Possimus et qui molestias natus labore non nihil et aut.", "asperiores" },
                    { 12, new DateTime(2006, 11, 4, 7, 38, 25, 929, DateTimeKind.Unspecified).AddTicks(6948), "Quam quia quo explicabo odio temporibus facilis.", "voluptatem" },
                    { 13, new DateTime(2019, 5, 19, 7, 47, 49, 224, DateTimeKind.Unspecified).AddTicks(835), "Ducimus corrupti qui.", "impedit" },
                    { 14, new DateTime(2003, 1, 31, 18, 38, 16, 631, DateTimeKind.Unspecified).AddTicks(5128), "Officiis delectus beatae cupiditate tempora deserunt et.", "repellat" },
                    { 15, new DateTime(2004, 5, 15, 0, 9, 23, 452, DateTimeKind.Unspecified).AddTicks(6883), "Et vel excepturi hic numquam hic.", "odio" },
                    { 16, new DateTime(2000, 6, 23, 16, 36, 58, 454, DateTimeKind.Unspecified).AddTicks(4267), "Et tenetur inventore corrupti aut aliquid et ab hic autem.", "vitae" },
                    { 17, new DateTime(2007, 9, 24, 9, 51, 9, 53, DateTimeKind.Unspecified).AddTicks(6160), "Recusandae voluptas non voluptas sed fuga.", "quam" },
                    { 18, new DateTime(2018, 4, 6, 1, 13, 50, 17, DateTimeKind.Unspecified).AddTicks(9180), "Impedit expedita sit accusamus ut.", "dolorem" },
                    { 19, new DateTime(2013, 6, 3, 5, 30, 41, 134, DateTimeKind.Unspecified).AddTicks(7744), "Dolores corporis inventore fugiat dolores et vel deleniti enim quia.", "possimus" },
                    { 20, new DateTime(2017, 9, 21, 1, 13, 16, 190, DateTimeKind.Unspecified).AddTicks(9402), "Facere esse repellat molestias dignissimos tempore voluptatem quis maxime natus.", "ut" },
                    { 21, new DateTime(2002, 1, 1, 8, 17, 47, 121, DateTimeKind.Unspecified).AddTicks(1255), "Dolore ea totam itaque.", "dolorem" },
                    { 22, new DateTime(2010, 4, 9, 12, 41, 9, 364, DateTimeKind.Unspecified).AddTicks(8442), "Quae debitis porro commodi culpa.", "debitis" },
                    { 23, new DateTime(2017, 10, 13, 22, 42, 49, 898, DateTimeKind.Unspecified).AddTicks(2665), "Commodi non ducimus.", "non" },
                    { 24, new DateTime(2002, 6, 9, 0, 41, 9, 722, DateTimeKind.Unspecified).AddTicks(4829), "Tenetur labore sit ea qui.", "veniam" },
                    { 25, new DateTime(2000, 3, 24, 15, 21, 9, 259, DateTimeKind.Unspecified).AddTicks(5565), "Facere quod corporis nam ullam eum velit.", "id" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "announcements",
                keyColumn: "Id",
                keyValue: 25);
        }
    }
}
