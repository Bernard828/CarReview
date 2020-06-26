using CarReview.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarReview.Views
{
    public class CarBlogContext : DbContext
    {
        public DbSet<Content> CarList { get; set; }
        public IEnumerable<Category> Category { get; set; }

        //public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=CarDatabase;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Content>().HasData(

               new Content("New Car", 1, "My new car is amazing", "Steve Jobs", "Sports Car", DateTime.Now),
               new Content("Used Car", 2, "My used car sucks", "Elon Musk", "Electric Car", DateTime.Now),
               new Content("Certfied Preowned", 3, "Not a good good", "Stradman", "Luxury Car", DateTime.Now),
               new Content("Salvage Title", 4, "Great project car", "DoctaM3", "Exotic Car", DateTime.Now)
               );

            modelbuilder.Entity<Category>().HasData(

               new Category("Bernard", 1, "Car drives great. I love it."),
               new Category("Jody", 2, "I've driven better cars. This car is subpar."),
               new Category("Chuck", 3, "I'm a pro driver, and wouldn't drive a crappy car like this."),
               new Category("Dede", 4, "I forgot my sunglasses and this car is a convertible.")
               );
        }
}   }
