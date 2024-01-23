using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataContext.Migrations.TmdbDb
{
    /// <inheritdoc />
    public partial class StatusMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NowPlaying",
                table: "Movies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Popular",
                table: "Movies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TopRated",
                table: "Movies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Upcoming",
                table: "Movies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NowPlaying",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Popular",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "TopRated",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Upcoming",
                table: "Movies");
        }
    }
}
