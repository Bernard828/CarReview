using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarReview.Migrations
{
    public partial class AddImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Category",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Image",
                value: "C8 Chevy Corvette Stingray.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Image",
                value: "C8 Chevy Corvette Stingray.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Image",
                value: "C8 Chevy Corvette Stingray.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "Image",
                value: "C8 Chevy Corvette Stingray.jpg");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 23, 16, 25, 706, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 23, 16, 25, 711, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 23, 16, 25, 711, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 23, 16, 25, 711, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 23, 16, 25, 711, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 23, 16, 25, 711, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 23, 16, 25, 711, DateTimeKind.Local).AddTicks(6203));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 6, 26, 14, 12, 19, 458, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 6, 26, 14, 12, 19, 465, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2020, 6, 26, 14, 12, 19, 465, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2020, 6, 26, 14, 12, 19, 465, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2020, 6, 26, 14, 12, 19, 465, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2020, 6, 26, 14, 12, 19, 465, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2020, 6, 26, 14, 12, 19, 465, DateTimeKind.Local).AddTicks(1935));
        }
    }
}
