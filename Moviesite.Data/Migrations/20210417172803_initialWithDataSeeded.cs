using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Moviesite.Data.Migrations
{
    public partial class initialWithDataSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Country = table.Column<string>(maxLength: 100, nullable: true),
                    DateBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Country = table.Column<string>(maxLength: 100, nullable: true),
                    DateBirth = table.Column<DateTime>(nullable: false),
                    ShortDescription = table.Column<string>(maxLength: 500, nullable: true),
                    Gender = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    MovieTitle = table.Column<string>(nullable: true),
                    MovieProducer = table.Column<string>(nullable: true),
                    MovieCountry = table.Column<string>(nullable: true),
                    MovieCategory = table.Column<string>(nullable: true),
                    MovieFormatType = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    ShippedDate = table.Column<DateTime>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Country = table.Column<string>(maxLength: 100, nullable: true),
                    DateBirth = table.Column<DateTime>(nullable: false),
                    ShortDescription = table.Column<string>(maxLength: 500, nullable: true),
                    Gender = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    MovieId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    MovieId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 350, nullable: true),
                    ProducerName = table.Column<string>(nullable: true),
                    ProducerID = table.Column<int>(nullable: false),
                    DirectorName = table.Column<string>(nullable: true),
                    DirectorID = table.Column<int>(nullable: false),
                    ActorNames = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    GenreName = table.Column<string>(maxLength: 150, nullable: true),
                    GenreID = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    FormatType = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Language = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 150, nullable: true),
                    Shipping = table.Column<string>(maxLength: 50, nullable: true),
                    PhotoURL = table.Column<string>(nullable: true),
                    SoldItems = table.Column<int>(nullable: false),
                    Rating = table.Column<double>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Directors_DirectorID",
                        column: x => x.DirectorID,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Producers_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieActors",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false),
                    ActorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieActors", x => new { x.MovieID, x.ActorID });
                    table.ForeignKey(
                        name: "FK_MovieActors_Actors_ActorID",
                        column: x => x.ActorID,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieActors_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Country", "DateBirth", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, "Australia", new DateTime(2021, 4, 17, 19, 28, 2, 682, DateTimeKind.Local).AddTicks(3463), "Male", "Chris Hemsworth" },
                    { 29, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6942), "Male", "Idris Elba" },
                    { 30, "Japan", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6946), "Male", "Tadanobu Asano" },
                    { 31, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6950), "Female", "Kat Dennings" },
                    { 32, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6953), "Male", "Anthony Hopkins" },
                    { 33, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6957), "Female", "Jaimie Alexander" },
                    { 34, "Ireland", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6961), "Male", "Ray Stevenson" },
                    { 35, "Romania", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6964), "Male", "Sebastian Stan" },
                    { 36, "England", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6968), "Female", "Hayley Atwell" },
                    { 37, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6972), "Male", "Tommy Lee Jones" },
                    { 38, "Canada", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6975), "Female", "Evangeline Lilly" },
                    { 28, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6938), "Female", "Rene Russo" },
                    { 39, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6979), "Female", "Chris Pratt" },
                    { 42, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6990), "Male", "Dave Bautista" },
                    { 43, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6993), "Male", "Kurt Russell" },
                    { 44, "England", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6997), "Male", "Tom Holland" },
                    { 45, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(7001), "Male", "Anthony Mackie" },
                    { 46, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(7005), "Female", "Elizabeth Olsen" },
                    { 47, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(7008), "Male", "Paul Rudd" },
                    { 48, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(7012), "Male", "Benedict Cumberbatch" },
                    { 49, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(7016), "Male", "Michael B. Jordan" },
                    { 50, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(7020), "Male", "Chadwick Boseman" },
                    { 51, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(7023), "Male", "Jake Gyllenhaal" },
                    { 40, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6982), "Female", "Zoe Saldana" },
                    { 27, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6934), "Female", "Natalie Portman" },
                    { 41, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6986), "Male", "Vin Diesel" },
                    { 25, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6886), "Male", "Liv Tyler" },
                    { 26, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6931), "Male", "Mickey Rourke" },
                    { 2, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6720), "Male", "Robert Downey Jr." },
                    { 3, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6794), "Male", "Chris Evans" },
                    { 4, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6802), "Female", "Scarlett Johansson" },
                    { 5, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6807), "Male", "Mark Ruffalo" },
                    { 6, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6811), "Male", "Jeremy Lee Renner" },
                    { 7, "England", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6817), "Male", "Tom Hiddleston" },
                    { 8, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6821), "Male", "Robert Clark Gregg" },
                    { 9, "Canada", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6825), "Female", "Cobie Smulders" },
                    { 11, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6832), "Male", "Samuel L. Jackson" },
                    { 12, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6836), "Female", "Karen Gillan" },
                    { 10, "Sweden", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6829), "Male", "Stellan John Skarsgard" },
                    { 14, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6843), "Male", "Jon Favreau" },
                    { 24, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6882), "Male", "Tim Roth" },
                    { 23, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6879), "Male", "Edward Norton" },
                    { 22, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6874), "Male", "Don Cheadle" },
                    { 13, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6840), "Female", "Brie Larson" },
                    { 20, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6865), "Male", "Terrence Howard" },
                    { 19, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6862), "Female", "Gwyneth Paltrow" },
                    { 21, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6869), "Male", "Jeff Bridges" },
                    { 17, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6854), "Male", "Clark Gregg" },
                    { 16, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6851), "Male", "Josh Brolin" },
                    { 15, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6847), "Male", "Bradley Cooper" },
                    { 18, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 686, DateTimeKind.Local).AddTicks(6858), "Male", "Paul Bettany" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Country", "DateBirth", "Gender", "Name", "ShortDescription" },
                values: new object[,]
                {
                    { 11, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(9295), "Male", "Joe Johnston", "" },
                    { 16, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(9519), "Male", "Ryan Coogler", "" },
                    { 15, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(9514), "Male", "Scott Derrickson", "" },
                    { 17, "Ireland", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(9524), "Male", "Kenneth Branagh", "" },
                    { 14, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(9509), "Male", "Jon Watts", "" },
                    { 13, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(9504), "Male", "Peyton Reed", "" },
                    { 12, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(9299), "Male", "James Gunn", "" },
                    { 10, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(9290), "Male", "Joss Whedon", "" },
                    { 3, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(9257), "Male", "Anthony Russo", "" },
                    { 8, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(9282), "Male", "Taika Waititi", "" },
                    { 7, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(9277), "Male", "Louis Leterrier", "" },
                    { 6, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(9273), "Male", "Shane Black", "" },
                    { 5, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(9269), "Male", "Jon Favreau", "" },
                    { 4, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(9263), "Female", "Anna Boden", "" },
                    { 2, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(9193), "Male", "Joe Russo", "" },
                    { 1, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(7892), "Male", "Kevin Feige", "" },
                    { 9, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(9286), "Male", "Alan Taylor", "" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 11, "Sci-Fi" },
                    { 10, "Comedy" },
                    { 9, "Horror" },
                    { 8, "General" },
                    { 7, "Thriller" },
                    { 3, "Crime" },
                    { 5, "Drama" },
                    { 4, "Adventure" },
                    { 2, "Action" },
                    { 1, "Fiction" },
                    { 12, "Uncategorised" },
                    { 6, "Fantasy" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Country", "DateBirth", "Gender", "Name", "ShortDescription" },
                values: new object[] { 1, "USA", new DateTime(2021, 4, 17, 19, 28, 2, 689, DateTimeKind.Local).AddTicks(3156), "Male", "Kevin Feige", "" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "ActorNames", "Country", "DateAdded", "Description", "DirectorID", "DirectorName", "Duration", "FormatType", "GenreID", "GenreName", "Language", "PhotoURL", "Price", "ProducerID", "ProducerName", "Rating", "ReleaseDate", "Shipping", "SoldItems", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Chris Evans, Samuel L. Jackson, Hayley Atwell, Sebastian Bach", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 690, DateTimeKind.Local).AddTicks(2549), "", 11, "Joe Johnston", "", "", 11, "Sci-Fi", "English", "CaptainAmerica.jpg", 12.0, 1, "Kevin Feige", 5.0, new DateTime(2019, 1, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 33, "Captain America: The First Avenger", 0 },
                    { 21, "Paul Rudd, Evangeline Lilly, Michael Douglas", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5515), "", 13, "Peyton Reed", "", "", 11, "Sci-Fi", "English", "AntManAndTheWasp.jpg", 14.0, 1, "Kevin Feige", 4.5, new DateTime(2020, 6, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 20, "Ant-Man and The Wasp", 0 },
                    { 20, "Chris Hemsworth, Mark Ruffalo, Scarlet Johannson, Karen Gillan, Robert Downey Jr., Samuel L. Jackson, Jeremy Lee Renner, Tom Hiddleston, Chris Evans, Brie Larson, Josh Brolin, Chadwick Boseman, Elizabeth Olsen, Chris Pratt, Zoe Saldana, Benedict Cumberbatch, Paul Bettany, Anthony Mackie, Sebastian Bach, Vin Diesel, Tom Holland", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5508), "", 3, "Anthony Russo", "", "", 11, "Sci-Fi", "English", "AvengersInfinityWar.jpg", 22.0, 1, "Kevin Feige", 5.0, new DateTime(2020, 5, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 80, "Avengers: Infinity War", 0 },
                    { 19, "Chris Hemsworth, Idris Elba, Anthony Hopkins, Ray Stevenson, Tadanobu Asano,Tom Hiddleston", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5502), "", 8, "Taika Waititi", "", "", 11, "Sci-Fi", "English", "ThorRagnarok.jpg", 17.0, 1, "Kevin Feige", 5.0, new DateTime(2019, 4, 23, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 30, "Thor: Ragnarok", 0 },
                    { 18, "Chadwick Boseman, Michael B. Jordan", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5497), "", 16, "Ryan Coogler", "", "", 11, "Sci-Fi", "English", "BlackPanther.jpg", 16.0, 1, "Kevin Feige", 4.4000000000000004, new DateTime(2019, 4, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 32, "Black Panther", 0 },
                    { 17, "Benedict Cumberbatch", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5492), "", 15, "Scott Derrickson", "", "", 11, "Sci-Fi", "English", "DrStrange.jpg", 16.0, 1, "Kevin Feige", 4.2999999999999998, new DateTime(2019, 6, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 34, "Doctor Strange", 0 },
                    { 16, "Tom Holland, Robert Downey Jr., Jon Favreau, Zendaya", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5486), "", 14, "Jon Watts", "", "", 11, "Sci-Fi", "English", "SpidermanHomecoming.jpg", 15.0, 1, "Kevin Feige", 5.0, new DateTime(2019, 7, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 43, "Spider-Man: Homecoming", 0 },
                    { 15, "Chris Evans, Samuel L. Jackson, Robert Downey Jr., Sebastian Bach, Anthony Mackie, Elizabeth Olsen, Scarlet Johansson, Jeremy Lee Renner, Paul Rudd, Tom Holland, Paul Bettany", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5480), "", 2, "Joe Russo", "", "", 11, "Sci-Fi", "English", "CaptainAmericaCivilWar.jpg", 16.0, 1, "Kevin Feige", 4.5, new DateTime(2019, 2, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 44, "Captain America: Civil War", 0 },
                    { 14, "Paul Rudd, Michael Douglas", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5420), "", 13, "Peyton Reed", "", "", 11, "Sci-Fi", "English", "AntMan.jpg", 15.0, 1, "Kevin Feige", 4.5, new DateTime(2019, 7, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 30, "Ant-Man", 0 },
                    { 13, "Chris Hemsworth, Mark Ruffalo, Robert Downey Jr., Jeremy Lee Renner, Tom Hiddleston, Chris Evans, Elizabeth Olsen, Paul Bettany, Scarlet Johansson, Samuel L. Jackson", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5415), "", 10, "Joss Whedon", "", "", 11, "Sci-Fi", "English", "AvengersAgeOfUltron.jpg", 18.0, 1, "Kevin Feige", 5.0, new DateTime(2019, 4, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 45, "Avengers: Age of Ultron", 0 },
                    { 22, "Chris Hemsworth, Mark Ruffalo, Scarlet Johannson, Karen Gillan, Robert Downey Jr., Samuel L. Jackson, Jeremy Lee Renner, Tom Hiddleston, Chris Evans, Brie Larson, Josh Brolin, Chadwick Boseman, Elizabeth Olsen, Chris Pratt, Zoe Saldana, Benedict Cumberbatch, Paul Bettany, Anthony Mackie, Sebastian Bach, Vin Diesel, Tom Holland", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5520), "", 3, "Anthony Russo", "", "", 11, "Sci-Fi", "English", "AvengersEndGame.jpg", 20.0, 1, "Kevin Feige", 5.0, new DateTime(2020, 6, 15, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 23, "Avengers: Endgame", 0 },
                    { 12, "Chris Pratt, Zoe Saldana, Vin Diesel, Bradley Cooper, Karen Gillan, Dave Bautista, Kurt Russel", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5409), "", 12, "James Gunn", "", "", 11, "Sci-Fi", "English", "GuardiansOfTheGalaxyVol2.jpg", 15.0, 1, "Kevin Feige", 5.0, new DateTime(2018, 3, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 14, "Guardians of the Galaxy Vol.2", 0 },
                    { 10, "Chris Evans, Samuel L. Jackson, Hayley Atwell, Sebastian Bach, Anthony Mackie", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5398), "", 3, "Anthony Russo", "", "", 11, "Sci-Fi", "English", "CaptainAmericaWinterSoldier.jpg", 16.0, 1, "Kevin Feige", 5.0, new DateTime(2019, 3, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 50, "Captain America: Winter Soldier", 0 },
                    { 9, "Chris Hemsworth, Natalie Portman, Jaimie Alexander, Idris Elba, Anthony Hopkins, Kat Dennings, Rene Russo, Ray Stevenson, Stellan Skarsgard, Tadanobu Asano, Tom Hiddleston", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5393), "", 9, "Alan Taylor", "", "", 11, "Sci-Fi", "English", "ThorTheDarkWorld.jpg", 16.0, 1, "Kevin Feige", 5.0, new DateTime(2018, 1, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 50, "Thor: The Dark World", 0 },
                    { 8, "Robert Downey Jr., Gwyneth Paltrow, Jon Favreau, Samuel L. Jackson, Don Cheadle, Paul Bettany, Clark Gregg", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5388), "", 6, "Shane Black", "", "", 11, "Sci-Fi", "English", "IronMan3.jpg", 16.0, 1, "Kevin Feige", 5.0, new DateTime(2019, 8, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 34, "Iron Man 3", 0 },
                    { 7, "Chris Hemsworth, Mark Ruffalo, Robert Downey Jr., Jeremy Lee Renner, Tom Hiddleston, Chris Evans, Elizabeth Olsen, Paul Bettany, Scarlet Johansson, Samuel L. Jackson", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5382), "", 2, "Joe Russo", "", "", 11, "Sci-Fi", "English", "Avengers.jpg", 15.0, 1, "Kevin Feige", 5.0, new DateTime(2019, 7, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 33, "The Avengers", 0 },
                    { 6, "Chris Hemsworth, Natalie Portman, Jaimie Alexander, Idris Elba, Anthony Hopkins, Kat Dennings, Rene Russo, Ray Stevenson, Stellan Skarsgard, Tadanobu Asano, Clark Gregg , Samuel L. Jackson, Jeremy Lee Renner, Tom Hiddleston", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5376), "", 17, "Kenneth Branagh", "", "", 11, "Sci-Fi", "English", "Thor.jpg", 15.0, 1, "Kevin Feige", 5.0, new DateTime(2019, 6, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 12, "Thor", 0 },
                    { 5, "Edward Norton, Tim Roth", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5370), "", 7, "Louis Leterrier", "", "", 11, "Sci-Fi", "English", "TheIncredibleHulk.jpg", 16.0, 1, "Kevin Feige", 5.0, new DateTime(2019, 5, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 13, "The Incredible Hulk", 0 },
                    { 4, "Robert Downey Jr., Gwyneth Paltrow, Jon Favreau, Samuel L. Jackson, Don Cheadle, Paul Bettany, Clark Gregg, Mickey Rourke", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5363), "", 5, "Jon Favreau", "", "", 11, "Sci-Fi", "English", "IronMan2.jpg", 22.0, 1, "Kevin Feige", 5.0, new DateTime(2019, 4, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 50, "Iron Man 2", 0 },
                    { 3, "Robert Downey Jr., Gwyneth Paltrow, Jon Favreau, Samuel L. Jackson, Jeff Bridges, Terrence Howard, Paul Bettany, Clark Gregg", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5212), "", 5, "Jon Favreau", "", "", 11, "Sci-Fi", "English", "IronMan.jpg", 11.0, 1, "Kevin Feige", 5.0, new DateTime(2019, 3, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 32, "Iron Man", 0 },
                    { 2, "Brie Larson, Samuel L. Jackson, Clark Gregg", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(4998), "", 4, "Anna Boden", "", "", 11, "Sci-Fi", "English", "CaptainMarvel.jpg", 15.0, 1, "Kevin Feige", 5.0, new DateTime(2019, 2, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 12, "Captain Marvel", 0 },
                    { 11, "Chris Pratt, Zoe Saldana, Vin Diesel, Bradley Cooper, Karen Gillan, Dave Bautista", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5404), "", 12, "James Gunn", "", "", 11, "Sci-Fi", "English", "GuardiansOfTheGalaxy.jpg", 14.0, 1, "Kevin Feige", 5.0, new DateTime(2018, 4, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 34, "Guardians of the Galaxy", 0 },
                    { 23, "Tom Holland, Jon Favreau, Zendaya, Samuel L. Jackson, Cobie Smulders, Jake Gyllenhaal", "USA", new DateTime(2021, 4, 17, 19, 28, 2, 691, DateTimeKind.Local).AddTicks(5526), "", 14, "Jon Watts", "", "", 11, "Sci-Fi", "English", "SpidermanFarFromHome.jpg", 12.0, 1, "Kevin Feige", 5.0, new DateTime(2020, 7, 20, 21, 30, 15, 0, DateTimeKind.Unspecified), "Yes", 10, "Spider-Man: Far From Home", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_ActorID",
                table: "MovieActors",
                column: "ActorID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DirectorID",
                table: "Movies",
                column: "DirectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreID",
                table: "Movies",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerID",
                table: "Movies",
                column: "ProducerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MovieActors");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Producers");
        }
    }
}
