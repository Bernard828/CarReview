﻿// <auto-generated />
using System;
using CarReview.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarReview.Migrations
{
    [DbContext(typeof(CarBlogContext))]
    [Migration("20200625232652_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarReview.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarList");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Steve Jobs",
                            Body = "My new car is amazing",
                            Category = "Sports Car",
                            PublishDate = new DateTime(2020, 6, 25, 19, 26, 51, 769, DateTimeKind.Local).AddTicks(2457),
                            Title = "New Car"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Elon Musk",
                            Body = "My used car sucks",
                            Category = "Electric Car",
                            PublishDate = new DateTime(2020, 6, 25, 19, 26, 51, 769, DateTimeKind.Local).AddTicks(3862),
                            Title = "Used Car"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Stradman",
                            Body = "Not a good good",
                            Category = "Luxury Car",
                            PublishDate = new DateTime(2020, 6, 25, 19, 26, 51, 769, DateTimeKind.Local).AddTicks(3882),
                            Title = "Certfied Preowned"
                        },
                        new
                        {
                            Id = 4,
                            Author = "DoctaM3",
                            Body = "Great project car",
                            Category = "Exotic Car",
                            PublishDate = new DateTime(2020, 6, 25, 19, 26, 51, 769, DateTimeKind.Local).AddTicks(3890),
                            Title = "Salvage Title"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
