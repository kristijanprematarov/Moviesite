using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Moviesite.Data.Migrations
{
    public partial class fixedGenreSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Producers");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Directors");

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Country", "DateBirth", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, "Australia", new DateTime(2021, 4, 3, 23, 23, 17, 447, DateTimeKind.Local).AddTicks(1405), "Male", "Chris Hemsworth" },
                    { 16, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 451, DateTimeKind.Local).AddTicks(2094), "Male", "Josh Brolin" },
                    { 15, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 451, DateTimeKind.Local).AddTicks(2091), "Male", "Bradley Cooper" },
                    { 14, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 451, DateTimeKind.Local).AddTicks(2087), "Male", "Jon Favreau" },
                    { 13, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 451, DateTimeKind.Local).AddTicks(2084), "Female", "Brie Larson" },
                    { 12, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 451, DateTimeKind.Local).AddTicks(2079), "Female", "Karen Gillan" },
                    { 10, "Sweden", new DateTime(2021, 4, 3, 23, 23, 17, 451, DateTimeKind.Local).AddTicks(2072), "Male", "Stellan John Skarsgard" },
                    { 9, "Canada", new DateTime(2021, 4, 3, 23, 23, 17, 451, DateTimeKind.Local).AddTicks(2069), "Female", "Cobie Smulders" },
                    { 11, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 451, DateTimeKind.Local).AddTicks(2075), "Male", "Samuel L. Jackson" },
                    { 7, "England", new DateTime(2021, 4, 3, 23, 23, 17, 451, DateTimeKind.Local).AddTicks(2061), "Male", "Tom Hiddleston" },
                    { 6, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 451, DateTimeKind.Local).AddTicks(2058), "Male", "Jeremy Lee Renner" },
                    { 5, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 451, DateTimeKind.Local).AddTicks(2054), "Male", "Mark Ruffalo" },
                    { 4, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 451, DateTimeKind.Local).AddTicks(2050), "Female", "Scarlett Johansson" },
                    { 3, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 451, DateTimeKind.Local).AddTicks(2043), "Male", "Chris Evans" },
                    { 2, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 451, DateTimeKind.Local).AddTicks(1990), "Male", "Robert Downey Jr." },
                    { 8, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 451, DateTimeKind.Local).AddTicks(2065), "Male", "Robert Clark Gregg" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Country", "DateBirth", "Gender", "Name", "ShortDescription" },
                values: new object[,]
                {
                    { 7, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(4204), "Male", "Tim Burton", "" },
                    { 11, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(4217), "Male", "George Lucas", "" },
                    { 10, "Canada", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(4214), "Male", "James Cameron", "" },
                    { 8, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(4207), "Male", "Kevin Feige", "" },
                    { 6, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(4201), "Male", "Martin Scorsese", "" },
                    { 9, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(4211), "Male", "Jason Blum", "" },
                    { 4, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(4194), "Male", "Quentin Tarantino", "" },
                    { 3, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(4190), "Male", "Spike Lee", "" },
                    { 2, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(4154), "Male", "Steven Spielberg", "" },
                    { 1, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(2882), "Male", "Christopher Nolan", "" },
                    { 5, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(4198), "Male", "Irwin Winkler", "" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 12, "Uncategorised" },
                    { 11, "Sci-Fi" },
                    { 10, "Comedy" },
                    { 8, "General" },
                    { 7, "Thriller" },
                    { 9, "Horror" },
                    { 5, "Drama" },
                    { 4, "Adventure" },
                    { 3, "Crime" },
                    { 2, "Action" },
                    { 1, "Fiction" },
                    { 6, "Fantasy" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Country", "DateBirth", "Gender", "Name", "ShortDescription" },
                values: new object[,]
                {
                    { 9, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(582), "Male", "Jason Blum", "" },
                    { 8, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(577), "Male", "Kevin Feige", "" },
                    { 7, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(573), "Female", "Nina Jacobson", "" },
                    { 6, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(570), "Female", "Kathleen Kennedy", "" },
                    { 3, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(559), "Male", "Spike Lee", "" },
                    { 4, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(563), "Male", "Quentin Tarantino", "" },
                    { 2, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(528), "Male", "Steven Spielberg", "" },
                    { 1, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 452, DateTimeKind.Local).AddTicks(9266), "Male", "Michael Mann", "" },
                    { 10, "Canada", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(586), "Male", "James Cameron", "" },
                    { 5, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(566), "Male", "Irwin Winkler", "" },
                    { 11, "USA", new DateTime(2021, 4, 3, 23, 23, 17, 453, DateTimeKind.Local).AddTicks(589), "Male", "George Lucas", "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Producers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Directors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
