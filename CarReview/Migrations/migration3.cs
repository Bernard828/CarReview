using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarReview.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Category_CategoryId",
                table: "Contents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CategoryImage",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "CategoryImage",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CategoryImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryName", "CategoryImage" },
                values: new object[] { "Sport", "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CategoryName", "CategoryImage" },
                values: new object[] { "Muscle", "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CategoryName", "CategoryImage" },
                values: new object[] { "Airplane", "" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CategoryImage" },
                values: new object[] { 7, "Bus", "" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2022, 9, 17, 7, 4, 43, 382, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2022, 9, 17, 7, 4, 43, 386, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2022, 9, 17, 7, 4, 43, 386, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2022, 9, 17, 7, 4, 43, 386, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2022, 9, 17, 7, 4, 43, 386, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2022, 9, 17, 7, 4, 43, 386, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2022, 9, 17, 7, 4, 43, 386, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Categories_CategoryId",
                table: "Contents",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Categories_CategoryId",
                table: "Contents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "CategoryImage",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.AddColumn<string>(
                name: "CategoryImage",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryImage",
                value: "electricTransportation.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryImage",
                value: "luxuryTransportation.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CategoryImage",
                value: "exoticTransportation.jpg");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryImage", "CategoryName" },
                values: new object[] { "muscleTransportation.jpg", "Muscle" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CategoryImage", "CategoryName" },
                values: new object[] { "airplaneTransportation.jpg", "Airplane" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CategoryImage", "CategoryName" },
                values: new object[] { "busTransportation.jpg", "Bus" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2022, 9, 1, 2, 28, 37, 977, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2022, 9, 1, 2, 28, 37, 981, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2022, 9, 1, 2, 28, 37, 981, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2022, 9, 1, 2, 28, 37, 981, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2022, 9, 1, 2, 28, 37, 981, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2022, 9, 1, 2, 28, 37, 981, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2022, 9, 1, 2, 28, 37, 981, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Category_CategoryId",
                table: "Contents",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
