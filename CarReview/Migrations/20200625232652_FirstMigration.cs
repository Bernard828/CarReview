using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarReview.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarList", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CarList",
                columns: new[] { "Id", "Author", "Body", "Category", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Steve Jobs", "My new car is amazing", "Sports Car", new DateTime(2020, 6, 25, 19, 26, 51, 769, DateTimeKind.Local).AddTicks(2457), "New Car" },
                    { 2, "Elon Musk", "My used car sucks", "Electric Car", new DateTime(2020, 6, 25, 19, 26, 51, 769, DateTimeKind.Local).AddTicks(3862), "Used Car" },
                    { 3, "Stradman", "Not a good good", "Luxury Car", new DateTime(2020, 6, 25, 19, 26, 51, 769, DateTimeKind.Local).AddTicks(3882), "Certfied Preowned" },
                    { 4, "DoctaM3", "Great project car", "Exotic Car", new DateTime(2020, 6, 25, 19, 26, 51, 769, DateTimeKind.Local).AddTicks(3890), "Salvage Title" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarList");
        }
    }
}
