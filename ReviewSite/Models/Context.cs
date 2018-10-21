using Microsoft.EntityFrameworkCore;
using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Models
{
    public class Context : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }

        //SEED DATA
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasData(
                new Review() { Id = 1, Title = "Corgi Type: Untoasted", CategoryId=1,ImageUrl = "/Images/whiteCorgi.png", Content = "Untoasted type Corgis have white fur. It's as if you had a piece of bread and did not put it in a toaster." },
                new Review() { Id = 2, Title = "Corgi Type: Toasted", CategoryId = 1, ImageUrl = "/Images/puppyCorgi.jpg", Content = "Toasted type Corgis have brown fur. Like if you were to take a white piece of bread and put it in the toaster to toast it." },
                new Review() { Id = 3, Title = "Corgi Type: Burnt", CategoryId = 2, ImageUrl = "/Images/blackCorgi.jpg", Content = "Burnt type Corgis have mostly black fur with partial brown and white mixed in. In other words, you left your piece of bread in the toaster for far too long and it got burnt." });

            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name="dog" },
                new Category() { Id = 2, Name = "doggo" }
                );
            
            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MRReviews;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
               .UseLazyLoadingProxies();

            
            base.OnConfiguring(optionsBuilder);
        }
    }
}