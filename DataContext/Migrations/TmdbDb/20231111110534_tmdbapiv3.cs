using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataContext.Migrations.TmdbDb
{
    /// <inheritdoc />
    public partial class tmdbapiv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "IdTMDB",
                table: "SpokenLanguage",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "IdTMDB",
                table: "ProductionCountries",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "IdTMDB",
                table: "ProductionCompanies",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "IdTMDB",
                table: "Movies",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "IdTMDB",
                table: "Genres",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdTMDB",
                table: "SpokenLanguage");

            migrationBuilder.DropColumn(
                name: "IdTMDB",
                table: "ProductionCountries");

            migrationBuilder.DropColumn(
                name: "IdTMDB",
                table: "ProductionCompanies");

            migrationBuilder.DropColumn(
                name: "IdTMDB",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "IdTMDB",
                table: "Genres");
        }
    }
}
