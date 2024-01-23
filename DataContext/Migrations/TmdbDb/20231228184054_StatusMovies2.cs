using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataContext.Migrations.TmdbDb
{
    /// <inheritdoc />
    public partial class StatusMovies2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Popular",
                table: "Movies",
                newName: "TrendingWeek");

            migrationBuilder.AddColumn<bool>(
                name: "TrendingDay",
                table: "Movies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrendingDay",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "TrendingWeek",
                table: "Movies",
                newName: "Popular");
        }
    }
}
