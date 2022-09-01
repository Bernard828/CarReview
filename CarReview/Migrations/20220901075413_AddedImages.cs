using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarReview.Migrations
{
    public partial class AddedImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Image",
                value: "electricTransportation.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Image",
                value: "luxuryTransportation.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Image" },
                values: new object[] { "Muscle", "muscleTransportation.jpg" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName", "Image" },
                values: new object[,]
                {
                    { 5, "Airplane", "airplaneTransportation.jpg" },
                    { 6, "Bus", "busTransportation.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2022, 9, 1, 3, 54, 12, 540, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2022, 9, 1, 3, 54, 12, 543, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2022, 9, 1, 3, 54, 12, 543, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2022, 9, 1, 3, 54, 12, 543, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2022, 9, 1, 3, 54, 12, 543, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2022, 9, 1, 3, 54, 12, 543, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2022, 9, 1, 3, 54, 12, 543, DateTimeKind.Local).AddTicks(696));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6);

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
                keyValue: 4,
                columns: new[] { "CategoryName", "Image" },
                values: new object[] { "Sport", "C8 Chevy Corvette Stingray.jpg" });

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
    }
}
