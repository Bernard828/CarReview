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
        public DbSet<Content> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }

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

               new Content("New Car", 1, "My new car is amazing", "Steve Jobs", 1),
               new Content("New Car", 2, "The candy apple red looks great in the summer.", "Steve Madden", 1),
               new Content("Used Car", 3, "My used car sucks", "Elon Musk", 2),
               new Content("Certfied Preowned", 4, "Not a good good", "Stradman", 3),
               new Content("Certfied Preowned", 7, "Not a good good", "Mr. Bloomberg", 3),
               new Content("Salvage Title", 5, "Great project car", "DoctaM3", 4),
               new Content("Lease", 6, "Great project car", "Dr. Jay", 4)
               );

            modelbuilder.Entity<Category>().HasData(


               new Category("Electric", 1, ""),
               new Category("Luxury", 2, ""),
               new Category("Exotic", 3, ""),
               new Category("Muscle", 4, ""),
               new Category ("Airplane", 5, "airplaneTransportation.jpg"),
               new Category("Bus", 9, "busTransportation.jpg"),
               new Category("Truck", 10, "")

               );
        }
        //public DbSet<CarReview.Models.Category> Category_1 { get; set; }
    }
}
