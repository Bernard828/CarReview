using CarReview.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarReview.Views
{
    public class CarContext : DbContext
    {
        public DbSet<CarModel> CarList { get; set; }
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
            modelbuilder.Entity<CarModel>().HasData(

               new CarModel("Bushwood CC", 1, "Good snack shack and poor caddying", "Bushwood.jpg"),
               new CarModel("Fury Creek Golf CC", 2, "Price is wrong B&$#%", "FurryCreek.jpg"),
               new CarModel("Cotton Wood", 3, "Waggle and let the big dog eat", "Cottonwood.jpg"),
               new CarModel("Little Met", 4, "Great course for beginners, not so much for the advanced player", "golfcourse5.jpg")
               );
        }
}   }
