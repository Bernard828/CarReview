using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarReview.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Electric" },
                    { 2, "Luxury" },
                    { 3, "Exotic" },
                    { 4, "Sport" }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Steve Jobs", "My new car is amazing", 1, new DateTime(2020, 6, 26, 14, 12, 19, 458, DateTimeKind.Local).AddTicks(7025), "New Car" },
                    { 2, "Steve Madden", "The candy apple red looks great in the summer.", 1, new DateTime(2020, 6, 26, 14, 12, 19, 465, DateTimeKind.Local).AddTicks(1036), "New Car" },
                    { 3, "Elon Musk", "My used car sucks", 2, new DateTime(2020, 6, 26, 14, 12, 19, 465, DateTimeKind.Local).AddTicks(1904), "Used Car" },
                    { 4, "Stradman", "Not a good good", 3, new DateTime(2020, 6, 26, 14, 12, 19, 465, DateTimeKind.Local).AddTicks(1930), "Certfied Preowned" },
                    { 7, "Mr. Bloomberg", "Not a good good", 3, new DateTime(2020, 6, 26, 14, 12, 19, 465, DateTimeKind.Local).AddTicks(1935), "Certfied Preowned" },
                    { 5, "DoctaM3", "Great project car", 4, new DateTime(2020, 6, 26, 14, 12, 19, 465, DateTimeKind.Local).AddTicks(1941), "Salvage Title" },
                    { 6, "Dr. Jay", "Great project car", 4, new DateTime(2020, 6, 26, 14, 12, 19, 465, DateTimeKind.Local).AddTicks(1946), "Lease" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_CategoryId",
                table: "Contents",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
