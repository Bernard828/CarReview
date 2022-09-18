﻿// <auto-generated />
using System;
using CarReview.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarReview.Migrations
{
    [DbContext(typeof(CarBlogContext))]
    partial class CarBlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarReview.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Electric",
                            Image = ""
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Luxury",
                            Image = ""
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Exotic",
                            Image = ""
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Sport",
                            Image = ""
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Muscle",
                            Image = ""
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Airplane",
                            Image = ""
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Bus",
                            Image = ""
                        });
                });

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

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Steve Jobs",
                            Body = "My new car is amazing",
                            CategoryId = 1,
                            PublishDate = new DateTime(2022, 9, 17, 7, 4, 43, 382, DateTimeKind.Local).AddTicks(5826),
                            Title = "New Car"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Steve Madden",
                            Body = "The candy apple red looks great in the summer.",
                            CategoryId = 1,
                            PublishDate = new DateTime(2022, 9, 17, 7, 4, 43, 386, DateTimeKind.Local).AddTicks(986),
                            Title = "New Car"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Elon Musk",
                            Body = "My used car sucks",
                            CategoryId = 2,
                            PublishDate = new DateTime(2022, 9, 17, 7, 4, 43, 386, DateTimeKind.Local).AddTicks(1040),
                            Title = "Used Car"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Stradman",
                            Body = "Not a good good",
                            CategoryId = 3,
                            PublishDate = new DateTime(2022, 9, 17, 7, 4, 43, 386, DateTimeKind.Local).AddTicks(1121),
                            Title = "Certfied Preowned"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Mr. Bloomberg",
                            Body = "Not a good good",
                            CategoryId = 3,
                            PublishDate = new DateTime(2022, 9, 17, 7, 4, 43, 386, DateTimeKind.Local).AddTicks(1126),
                            Title = "Certfied Preowned"
                        },
                        new
                        {
                            Id = 5,
                            Author = "DoctaM3",
                            Body = "Great project car",
                            CategoryId = 4,
                            PublishDate = new DateTime(2022, 9, 17, 7, 4, 43, 386, DateTimeKind.Local).AddTicks(1131),
                            Title = "Salvage Title"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Dr. Jay",
                            Body = "Great project car",
                            CategoryId = 4,
                            PublishDate = new DateTime(2022, 9, 17, 7, 4, 43, 386, DateTimeKind.Local).AddTicks(1135),
                            Title = "Lease"
                        });
                });

            modelBuilder.Entity("CarReview.Models.Content", b =>
                {
                    b.HasOne("CarReview.Models.Category", "Category")
                        .WithMany("Contents")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
