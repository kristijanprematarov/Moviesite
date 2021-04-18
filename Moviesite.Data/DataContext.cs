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

            // ****************** DATA SEEDING ******************

            #region Admin and Roles

            const string ADMIN_ID = "b4280b6a-0613-4cbd-a9e6-f1701e926e73";
            const string ROLE_ID = ADMIN_ID; // role id e istiot nacin kako admin id
            const string password = "admin123abc";

            modelBuilder.Entity<IdentityRole>().HasData
                (
                    new IdentityRole { Id = ROLE_ID, Name = "admin", NormalizedName = "ADMIN" },
                    new IdentityRole { Id = "b4280b6a-0613-4cbd-a9e6-f1701e926e74", Name = "editor", NormalizedName = "EDITOR" },
                    new IdentityRole { Id = "b4280b6a-0613-4cbd-a9e6-f1701e926e75", Name = "guest", NormalizedName = "GUEST" }
                );

            var hasher = new PasswordHasher<IdentityUser>();

            modelBuilder.Entity<IdentityUser>().HasData
                (
                    new IdentityUser
                    {
                        Id = ADMIN_ID,
                        UserName = "admin@moviesite.com",
                        NormalizedUserName = "ADMIN@MOVIESITE.COM",
                        Email = "admin@moviesite.com",
                        NormalizedEmail = "ADMIN@MOVIESITE.COM",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, password),
                        SecurityStamp = string.Empty,
                        ConcurrencyStamp = "c8554266-b401-4591-9aeb-a9283053fc58"
                    }
                );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData
                (
                    new IdentityUserRole<string>
                    {
                        UserId = ADMIN_ID,
                        RoleId = ROLE_ID
                    }
                );

            #endregion

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
                    Gender = "Male",
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
                },
                new Actor
                {
                    Id = 17,
                    Name = "Clark Gregg",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 18,
                    Name = "Paul Bettany",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 19,
                    Name = "Gwyneth Paltrow",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Female"
                },
                new Actor
                {
                    Id = 20,
                    Name = "Terrence Howard",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                }
                ,
                new Actor
                {
                    Id = 21,
                    Name = "Jeff Bridges",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 22,
                    Name = "Don Cheadle",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 23,
                    Name = "Edward Norton",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 24,
                    Name = "Tim Roth",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 25,
                    Name = "Liv Tyler",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 26,
                    Name = "Mickey Rourke",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 27,
                    Name = "Natalie Portman",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Female"
                },
                new Actor
                {
                    Id = 28,
                    Name = "Rene Russo",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Female"
                },
                new Actor
                {
                    Id = 29,
                    Name = "Idris Elba",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 30,
                    Name = "Tadanobu Asano",
                    Country = "Japan",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 31,
                    Name = "Kat Dennings",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Female"
                },
                new Actor
                {
                    Id = 32,
                    Name = "Anthony Hopkins",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 33,
                    Name = "Jaimie Alexander",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Female"
                },
                new Actor
                {
                    Id = 34,
                    Name = "Ray Stevenson",
                    Country = "Ireland",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 35,
                    Name = "Sebastian Stan",
                    Country = "Romania",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 36,
                    Name = "Hayley Atwell",
                    Country = "England",
                    DateBirth = DateTime.Now,
                    Gender = "Female"
                },
                new Actor
                {
                    Id = 37,
                    Name = "Tommy Lee Jones",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 38,
                    Name = "Evangeline Lilly",
                    Country = "Canada",
                    DateBirth = DateTime.Now,
                    Gender = "Female"
                },
                new Actor
                {
                    Id = 39,
                    Name = "Chris Pratt",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Female"
                },
                new Actor
                {
                    Id = 40,
                    Name = "Zoe Saldana",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Female"
                },
                new Actor
                {
                    Id = 41,
                    Name = "Vin Diesel",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 42,
                    Name = "Dave Bautista",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 43,
                    Name = "Kurt Russell",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 44,
                    Name = "Tom Holland",
                    Country = "England",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 45,
                    Name = "Anthony Mackie",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 46,
                    Name = "Elizabeth Olsen",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Female"
                },
                new Actor
                {
                    Id = 47,
                    Name = "Paul Rudd",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 48,
                    Name = "Benedict Cumberbatch",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 49,
                    Name = "Michael B. Jordan",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 50,
                    Name = "Chadwick Boseman",
                    Country = "USA",
                    DateBirth = DateTime.Now,
                    Gender = "Male"
                },
                new Actor
                {
                    Id = 51,
                    Name = "Jake Gyllenhaal",
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
                    Name = "Kevin Feige",
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
                Name = "Kevin Feige",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 2,
                Name = "Joe Russo", //avengers 1
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 3,
                Name = "Anthony Russo", //infinity war, endgame
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 4,
                Name = "Anna Boden", // CAP MARVEL
                Country = "USA",
                Gender = "Female",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 5,
                Name = "Jon Favreau",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 6,
                Name = "Shane Black",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 7,
                Name = "Louis Leterrier",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 8,
                Name = "Taika Waititi",// ragnarok,
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 9,
                Name = "Alan Taylor",//thor 2
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 10,
                Name = "Joss Whedon", //age of ultron
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 11,
                Name = "Joe Johnston", //CAP AMERICA,
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 12,
                Name = "James Gunn",
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 13,
                Name = "Peyton Reed", // ANT MAN i ANT MAN 2
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 14,
                Name = "Jon Watts", // Spiderman
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 15,
                Name = "Scott Derrickson", //DR STRANGE
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 16,
                Name = "Ryan Coogler", //Black Panther
                Country = "USA",
                Gender = "Male",
                DateBirth = DateTime.Now,
                ShortDescription = ""
            },
            new Director
            {
                Id = 17,
                Name = "Kenneth Branagh", //THOR 1
                Country = "Ireland",
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
                    Title = "Captain America: The First Avenger",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 11,
                    DirectorName = "Joe Johnston",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Chris Evans, Samuel L. Jackson, Hayley Atwell, Sebastian Bach",
                    Price = 12,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 33,
                    ReleaseDate = new DateTime(2019, 01, 20, 21, 30, 15),
                    PhotoURL = "CaptainAmerica.jpg",
                },
                new Movie
                {
                    Id = 2,
                    Title = "Captain Marvel",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 4,
                    DirectorName = "Anna Boden",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Brie Larson, Samuel L. Jackson, Clark Gregg",
                    Price = 15,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 12,
                    ReleaseDate = new DateTime(2019, 02, 20, 21, 30, 15),
                    PhotoURL = "CaptainMarvel.jpg",
                },
                new Movie
                {
                    Id = 3,
                    Title = "Iron Man",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 5,
                    DirectorName = "Jon Favreau",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Robert Downey Jr., Gwyneth Paltrow, Jon Favreau, Samuel L. Jackson, Jeff Bridges, Terrence Howard, Paul Bettany, Clark Gregg",
                    Price = 11,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 32,
                    ReleaseDate = new DateTime(2019, 03, 20, 21, 30, 15),
                    PhotoURL = "IronMan.jpg",
                },
                new Movie
                {
                    Id = 4,
                    Title = "Iron Man 2",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 5,
                    DirectorName = "Jon Favreau",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Robert Downey Jr., Gwyneth Paltrow, Jon Favreau, Samuel L. Jackson, Don Cheadle, Paul Bettany, Clark Gregg, Mickey Rourke",
                    Price = 22,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 50,
                    ReleaseDate = new DateTime(2019, 04, 20, 21, 30, 15),
                    PhotoURL = "IronMan2.jpg",
                },
                new Movie
                {
                    Id = 5,
                    Title = "The Incredible Hulk",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 7,
                    DirectorName = "Louis Leterrier",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Edward Norton, Tim Roth",
                    Price = 16,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 13,
                    ReleaseDate = new DateTime(2019, 05, 20, 21, 30, 15),
                    PhotoURL = "TheIncredibleHulk.jpg",
                },
                new Movie
                {
                    Id = 6,
                    Title = "Thor",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 17,
                    DirectorName = "Kenneth Branagh",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Chris Hemsworth, Natalie Portman, Jaimie Alexander, Idris Elba, Anthony Hopkins, Kat Dennings, Rene Russo, Ray Stevenson, Stellan Skarsgard, Tadanobu Asano, Clark Gregg , Samuel L. Jackson, Jeremy Lee Renner, Tom Hiddleston",
                    Price = 15,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 12,
                    ReleaseDate = new DateTime(2019, 06, 20, 21, 30, 15),
                    PhotoURL = "Thor.jpg",
                },
                new Movie
                {
                    Id = 7,
                    Title = "The Avengers",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 2,
                    DirectorName = "Joe Russo",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Chris Hemsworth, Mark Ruffalo, Robert Downey Jr., Jeremy Lee Renner, Tom Hiddleston, Chris Evans, Elizabeth Olsen, Paul Bettany, Scarlet Johansson, Samuel L. Jackson",
                    Price = 15,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 33,
                    ReleaseDate = new DateTime(2019, 07, 20, 21, 30, 15),
                    PhotoURL = "Avengers.jpg",
                },
                new Movie
                {
                    Id = 8,
                    Title = "Iron Man 3",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 6,
                    DirectorName = "Shane Black",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Robert Downey Jr., Gwyneth Paltrow, Jon Favreau, Samuel L. Jackson, Don Cheadle, Paul Bettany, Clark Gregg",
                    Price = 16,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 34,
                    ReleaseDate = new DateTime(2019, 08, 20, 21, 30, 15),
                    PhotoURL = "IronMan3.jpg",
                },
                new Movie
                {
                    Id = 9,
                    Title = "Thor: The Dark World",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 9,
                    DirectorName = "Alan Taylor",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Chris Hemsworth, Natalie Portman, Jaimie Alexander, Idris Elba, Anthony Hopkins, Kat Dennings, Rene Russo, Ray Stevenson, Stellan Skarsgard, Tadanobu Asano, Tom Hiddleston",
                    Price = 16,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 50,
                    ReleaseDate = new DateTime(2018, 01, 20, 21, 30, 15),
                    PhotoURL = "ThorTheDarkWorld.jpg",
                },
                new Movie
                {
                    Id = 10,
                    Title = "Captain America: Winter Soldier",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 3,
                    DirectorName = "Anthony Russo",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Chris Evans, Samuel L. Jackson, Hayley Atwell, Sebastian Bach, Anthony Mackie",
                    Price = 16,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 50,
                    ReleaseDate = new DateTime(2019, 03, 20, 21, 30, 15),
                    PhotoURL = "CaptainAmericaWinterSoldier.jpg",
                },
                new Movie
                {
                    Id = 11,
                    Title = "Guardians of the Galaxy",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 12,
                    DirectorName = "James Gunn",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Chris Pratt, Zoe Saldana, Vin Diesel, Bradley Cooper, Karen Gillan, Dave Bautista",
                    Price = 14,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 34,
                    ReleaseDate = new DateTime(2018, 04, 20, 21, 30, 15),
                    PhotoURL = "GuardiansOfTheGalaxy.jpg",
                },
                new Movie
                {
                    Id = 12,
                    Title = "Guardians of the Galaxy Vol.2",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 12,
                    DirectorName = "James Gunn",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Chris Pratt, Zoe Saldana, Vin Diesel, Bradley Cooper, Karen Gillan, Dave Bautista, Kurt Russel",
                    Price = 15,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 14,
                    ReleaseDate = new DateTime(2018, 03, 20, 21, 30, 15),
                    PhotoURL = "GuardiansOfTheGalaxyVol2.jpg",
                },
                new Movie
                {
                    Id = 13,
                    Title = "Avengers: Age of Ultron",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 10,
                    DirectorName = "Joss Whedon",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Chris Hemsworth, Mark Ruffalo, Robert Downey Jr., Jeremy Lee Renner, Tom Hiddleston, Chris Evans, Elizabeth Olsen, Paul Bettany, Scarlet Johansson, Samuel L. Jackson",
                    Price = 18,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 45,
                    ReleaseDate = new DateTime(2019, 04, 20, 21, 30, 15),
                    PhotoURL = "AvengersAgeOfUltron.jpg",
                },
                new Movie
                {
                    Id = 14,
                    Title = "Ant-Man",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 13,
                    DirectorName = "Peyton Reed",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Paul Rudd, Michael Douglas",
                    Price = 15,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 4.5,
                    SoldItems = 30,
                    ReleaseDate = new DateTime(2019, 07, 20, 21, 30, 15),
                    PhotoURL = "AntMan.jpg",
                },
                new Movie
                {
                    Id = 15,
                    Title = "Captain America: Civil War",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 2,
                    DirectorName = "Joe Russo",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Chris Evans, Samuel L. Jackson, Robert Downey Jr., Sebastian Bach, Anthony Mackie, Elizabeth Olsen, Scarlet Johansson, Jeremy Lee Renner, Paul Rudd, Tom Holland, Paul Bettany",
                    Price = 16,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 4.5,
                    SoldItems = 44,
                    ReleaseDate = new DateTime(2019, 02, 20, 21, 30, 15),
                    PhotoURL = "CaptainAmericaCivilWar.jpg",
                },
                new Movie
                {
                    Id = 16,
                    Title = "Spider-Man: Homecoming",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 14,
                    DirectorName = "Jon Watts",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Tom Holland, Robert Downey Jr., Jon Favreau, Zendaya",
                    Price = 15,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 43,
                    ReleaseDate = new DateTime(2019, 07, 20, 21, 30, 15),
                    PhotoURL = "SpidermanHomecoming.jpg",
                },
                new Movie
                {
                    Id = 17,
                    Title = "Doctor Strange",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 15,
                    DirectorName = "Scott Derrickson",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Benedict Cumberbatch",
                    Price = 16,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 4.3,
                    SoldItems = 34,
                    ReleaseDate = new DateTime(2019, 06, 20, 21, 30, 15),
                    PhotoURL = "DrStrange.jpg",
                },
                new Movie
                {
                    Id = 18,
                    Title = "Black Panther",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 16,
                    DirectorName = "Ryan Coogler",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Chadwick Boseman, Michael B. Jordan",
                    Price = 16,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 4.4,
                    SoldItems = 32,
                    ReleaseDate = new DateTime(2019, 04, 20, 21, 30, 15),
                    PhotoURL = "BlackPanther.jpg",
                },
                new Movie
                {
                    Id = 19,
                    Title = "Thor: Ragnarok",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 8,
                    DirectorName = "Taika Waititi",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Chris Hemsworth, Idris Elba, Anthony Hopkins, Ray Stevenson, Tadanobu Asano,Tom Hiddleston",
                    Price = 17,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 30,
                    ReleaseDate = new DateTime(2019, 04, 23, 21, 30, 15),
                    PhotoURL = "ThorRagnarok.jpg",
                },
                new Movie
                {
                    Id = 20,
                    Title = "Avengers: Infinity War",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 3,
                    DirectorName = "Anthony Russo",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Chris Hemsworth, Mark Ruffalo, Scarlet Johannson, Karen Gillan, Robert Downey Jr., Samuel L. Jackson, Jeremy Lee Renner, Tom Hiddleston, Chris Evans, Brie Larson, Josh Brolin, Chadwick Boseman, Elizabeth Olsen, Chris Pratt, Zoe Saldana, Benedict Cumberbatch, Paul Bettany, Anthony Mackie, Sebastian Bach, Vin Diesel, Tom Holland",
                    Price = 22,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 80,
                    ReleaseDate = new DateTime(2020, 05, 20, 21, 30, 15),
                    PhotoURL = "AvengersInfinityWar.jpg",
                },
                new Movie
                {
                    Id = 21,
                    Title = "Ant-Man and The Wasp",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 13,
                    DirectorName = "Peyton Reed",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Paul Rudd, Evangeline Lilly, Michael Douglas",
                    Price = 14,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 4.5,
                    SoldItems = 20,
                    ReleaseDate = new DateTime(2020, 06, 20, 21, 30, 15),
                    PhotoURL = "AntManAndTheWasp.jpg",
                },
                new Movie
                {
                    Id = 22,
                    Title = "Avengers: Endgame",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 3,
                    DirectorName = "Anthony Russo",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Chris Hemsworth, Mark Ruffalo, Scarlet Johannson, Karen Gillan, Robert Downey Jr., Samuel L. Jackson, Jeremy Lee Renner, Tom Hiddleston, Chris Evans, Brie Larson, Josh Brolin, Chadwick Boseman, Elizabeth Olsen, Chris Pratt, Zoe Saldana, Benedict Cumberbatch, Paul Bettany, Anthony Mackie, Sebastian Bach, Vin Diesel, Tom Holland",
                    Price = 20,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 23,
                    ReleaseDate = new DateTime(2020, 06, 15, 21, 30, 15),
                    PhotoURL = "AvengersEndGame.jpg",
                },
                new Movie
                {
                    Id = 23,
                    Title = "Spider-Man: Far From Home",
                    FormatType = "",
                    DateAdded = DateTime.Now,
                    Description = "",
                    DirectorID = 14,
                    DirectorName = "Jon Watts",
                    ProducerID = 1,
                    ProducerName = "Kevin Feige",
                    Country = "USA",
                    Duration = "",
                    GenreID = 11,
                    GenreName = "Sci-Fi",
                    ActorNames = "Tom Holland, Jon Favreau, Zendaya, Samuel L. Jackson, Cobie Smulders, Jake Gyllenhaal",
                    Price = 12,
                    Language = "English",
                    Shipping = "Yes",
                    Rating = 5,
                    SoldItems = 10,
                    ReleaseDate = new DateTime(2020, 07, 20, 21, 30, 15),
                    PhotoURL = "SpidermanFarFromHome.jpg",
                }
                );
            #endregion




        }



    }
}
