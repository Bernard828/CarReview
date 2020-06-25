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
        }
}   }
