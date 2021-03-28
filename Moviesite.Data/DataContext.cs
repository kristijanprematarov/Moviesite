using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Moviesite.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviesite.Data
{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Director> Directors { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MovieActor>()
                .HasKey(ma => new { ma.MovieID, ma.ActorID });
            //modelBuilder.Entity<MovieActor>()
            //    .HasOne(m => m.Movie)
            //    .WithMany(a => a.MovieActors)
            //    .HasForeignKey(m => m.MovieID);
            //modelBuilder.Entity<MovieActor>()
            //    .HasOne(a => a.Actor)
            //    .WithMany(m => m.MovieActors)
            //    .HasForeignKey(a => a.ActorID);
        }
    }
}
