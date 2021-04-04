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
            modelBuilder.Entity<MovieActor>()
                .HasOne(m => m.Movie)
                .WithMany(a => a.MovieActors)
                .HasForeignKey(m => m.MovieID);
            modelBuilder.Entity<MovieActor>()
                .HasOne(a => a.Actor)
                .WithMany(m => m.MovieActors)
                .HasForeignKey(a => a.ActorID);

            #region Actor

            modelBuilder.Entity<Actor>().HasData
                (
                new Actor
                {
                    Id = 1,
                    Name = "Chris Hemsworth",
                    Country = "Australia",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 2,
                    Name = "Robert Downey Jr.",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 3,
                    Name = "Chris Evans",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 4,
                    Name = "Scarlett Johansson",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Female"
                },
                new Actor
                {
                    Id = 5,
                    Name = "Mark Ruffalo",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 6,
                    Name = "Jeremy Lee Renner",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 7,
                    Name = "Tom Hiddleston",
                    Country = "England",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 8,
                    Name = "Robert Clark Gregg",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 9,
                    Name = "Cobie Smulders",
                    Country = "Canada",
                    DateBirth = DateTime.Now,
                    Gender = "Female"
                },
                new Actor
                {
                    Id = 10,
                    Name = "Stellan John Skarsgard",
                    Country = "Sweden",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 11,
                    Name = "Samuel L. Jackson",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 12,
                    Name = "Karen Gillan",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Female"
                },
                new Actor
                {
                    Id = 13,
                    Name = "Brie Larson",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Female"
                },
                new Actor
                {
                    Id = 14,
                    Name = "Jon Favreau",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 15,
                    Name = "Bradley Cooper",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 16,
                    Name = "Josh Brolin",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                }
                );

            #endregion

            #region Genre

            modelBuilder.Entity<Genre>().HasData
                (
                    new Genre { Id = 1, Name = "Fiction" },
                    new Genre { Id = 2, Name = "Action" },
                    new Genre { Id = 3, Name = "Crime" },
                    new Genre { Id = 4, Name = "Adventure" },
                    new Genre { Id = 5, Name = "Drama" },
                    new Genre { Id = 6, Name = "Fantasy" },
                    new Genre { Id = 7, Name = "Thriller" },
                    new Genre { Id = 8, Name = "General" },
                    new Genre { Id = 9, Name = "Horror" },
                    new Genre { Id = 10, Name = "Comedy" },
                    new Genre { Id = 11, Name = "Sci-Fi" },
                    new Genre { Id = 12, Name = "Uncategorised" }
                );

            #endregion

            #region Producer

            modelBuilder.Entity<Producer>().HasData
                (
                new Producer
                {
                    Id = 1,
                    Name = "Michael Mann",
                    Country = "USA",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    ShortDescription = ""
                },
                new Producer
                {
                    Id = 2,
                    Name = "Steven Spielberg",
                    Country = "USA",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    ShortDescription = ""
                },
                new Producer
                {
                    Id = 3,
                    Name = "Spike Lee",
                    Country = "USA",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    ShortDescription = ""
                },
                new Producer
                {
                    Id = 4,
                    Name = "Quentin Tarantino",
                    Country = "USA",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    ShortDescription = ""
                },
                new Producer
                {
                    Id = 5,
                    Name = "Irwin Winkler",
                    Country = "USA",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    ShortDescription = ""
                },
                new Producer
                {
                    Id = 6,
                    Name = "Kathleen Kennedy",
                    Country = "USA",
                    Gender = "Female",
                    DateBirth = DateTime.Now,
                    ShortDescription = ""
                },
                new Producer
                {
                    Id = 7,
                    Name = "Nina Jacobson",
                    Country = "USA",
                    Gender = "Female",
                    DateBirth = DateTime.Now,
                    ShortDescription = ""
                },
                new Producer
                {
                    Id = 8,
                    Name = "Kevin Feige",
                    Country = "USA",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    ShortDescription = ""
                },
                new Producer
                {
                    Id = 9,
                    Name = "Jason Blum",
                    Country = "USA",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    ShortDescription = ""
                },
                new Producer
                {
                    Id = 10,
                    Name = "James Cameron",
                    Country = "Canada",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    ShortDescription = ""
                },
                new Producer
                {
                    Id = 11,
                    Name = "George Lucas",
                    Country = "USA",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    ShortDescription = ""
                },
                new Producer
                {
                    Id = 12,
                    Name = "Joe Russo",
                    Country = "USA",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    ShortDescription = ""
                },
                new Producer
                {
                    Id = 13,
                    Name = "Sam Hargrave",
                    Country = "USA",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    ShortDescription = ""
                }
                );

            #endregion

            #region Director

            modelBuilder.Entity<Director>().HasData
            (
            new Director
            {
                Id = 1,
                Name = "Christopher Nolan",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 2,
                Name = "Steven Spielberg",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 3,
                Name = "Spike Lee",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 4,
                Name = "Quentin Tarantino",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 5,
                Name = "Irwin Winkler",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 6,
                Name = "Martin Scorsese",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 7,
                Name = "Tim Burton",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 8,
                Name = "Kevin Feige",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 9,
                Name = "Jason Blum",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 10,
                Name = "James Cameron",
                Country = "Canada",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 11,
                Name = "George Lucas",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 12,
                Name = "Joe Russo",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 13,
                Name = "Sam Hargrave",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            }
            );

            #endregion

            #region Movie

            modelBuilder.Entity<Movie>().HasData
                (
                new Movie
                {
                    Id = 1,
                    Title = "Avengers",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 8,
                    DirectorName = "Kevin Feige",
                    ProducerID = 8,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Chris Hemsworth, Mark Ruffalo, Scarlet Johannson, Karen Gillan, Robert Downey Jr., Samuel L. Jackson, Jeremy Lee Renner, Tom Hiddleston, Chris Evans, Brie Larson, Josh Brolin",
                    Price = 1,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 50,
                    //ReleaseDate = new DateTime(2020, 02, 29, 23, 29, 25),
                    ReleaseDate = new DateTime(2019, 02, 20, 21, 30, 15),
                    PhotoURL = "Avengers.jpg",
                },
                new Movie
                {
                    Id = 2,
                    Title = "Extraction",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 13,
                    DirectorName = "Sam Hargrave",
                    ProducerID = 12,
                    ProducerName = "Joe Russo",
                    Country = "USA",
                    Duration = "",
                    GenreID = 2,
                    GenreName = "Action",
                    ActorNames = "Chris Hemsworth",
                    Price = 1,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 50,
                    //ReleaseDate = new DateTime(2020, 02, 29, 23, 29, 25),
                    ReleaseDate = new DateTime(2020, 02, 19, 22, 15, 15),
                    PhotoURL = "Extraction.jpg",
                }
                );
            #endregion


        }



    }
}
