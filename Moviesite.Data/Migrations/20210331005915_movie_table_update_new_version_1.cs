using Microsoft.EntityFrameworkCore.Migrations;

namespace Moviesite.Data.Migrations
{
    public partial class movie_table_update_new_version_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActorNames",
                table: "Movies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActorNames",
                table: "Movies");
        }
    }
}
