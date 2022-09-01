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

                    b.Property<string>("CategoryImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryImage = "electricTransportation.jpg",
                            CategoryName = "Electric"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryImage = "luxuryTransportation.jpg",
                            CategoryName = "Luxury"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryImage = "exoticTransportation.jpg",
                            CategoryName = "Exotic"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryImage = "muscleTransportation.jpg",
                            CategoryName = "Muscle"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryImage = "airplaneTransportation.jpg",
                            CategoryName = "Airplane"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryImage = "busTransportation.jpg",
                            CategoryName = "Bus"
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
                            PublishDate = new DateTime(2022, 9, 1, 2, 28, 37, 977, DateTimeKind.Local).AddTicks(8014),
                            Title = "New Car"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Steve Madden",
                            Body = "The candy apple red looks great in the summer.",
                            CategoryId = 1,
                            PublishDate = new DateTime(2022, 9, 1, 2, 28, 37, 981, DateTimeKind.Local).AddTicks(3207),
                            Title = "New Car"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Elon Musk",
                            Body = "My used car sucks",
                            CategoryId = 2,
                            PublishDate = new DateTime(2022, 9, 1, 2, 28, 37, 981, DateTimeKind.Local).AddTicks(3285),
                            Title = "Used Car"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Stradman",
                            Body = "Not a good good",
                            CategoryId = 3,
                            PublishDate = new DateTime(2022, 9, 1, 2, 28, 37, 981, DateTimeKind.Local).AddTicks(3292),
                            Title = "Certfied Preowned"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Mr. Bloomberg",
                            Body = "Not a good good",
                            CategoryId = 3,
                            PublishDate = new DateTime(2022, 9, 1, 2, 28, 37, 981, DateTimeKind.Local).AddTicks(3296),
                            Title = "Certfied Preowned"
                        },
                        new
                        {
                            Id = 5,
                            Author = "DoctaM3",
                            Body = "Great project car",
                            CategoryId = 4,
                            PublishDate = new DateTime(2022, 9, 1, 2, 28, 37, 981, DateTimeKind.Local).AddTicks(3300),
                            Title = "Salvage Title"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Dr. Jay",
                            Body = "Great project car",
                            CategoryId = 4,
                            PublishDate = new DateTime(2022, 9, 1, 2, 28, 37, 981, DateTimeKind.Local).AddTicks(3303),
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
