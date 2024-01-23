using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataContext.Migrations.TmdbDb
{
    /// <inheritdoc />
    public partial class tmdbapiv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoviesGenres_Genres_GenresId",
                table: "MoviesGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviesGenres_Movies_MoviesId",
                table: "MoviesGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviesProductionCompanies_Movies_MoviesId",
                table: "MoviesProductionCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviesProductionCompanies_ProductionCompanies_ProductionCompaniesId",
                table: "MoviesProductionCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviesProductionCountries_Movies_MoviesId",
                table: "MoviesProductionCountries");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviesProductionCountries_ProductionCountries_ProductionCountriesId",
                table: "MoviesProductionCountries");

            migrationBuilder.DropTable(
                name: "MovieSpokenLanguage");

            migrationBuilder.RenameColumn(
                name: "ProductionCountriesId",
                table: "MoviesProductionCountries",
                newName: "ProductionCountryID");

            migrationBuilder.RenameColumn(
                name: "MoviesId",
                table: "MoviesProductionCountries",
                newName: "MovieID");

            migrationBuilder.RenameIndex(
                name: "IX_MoviesProductionCountries_ProductionCountriesId",
                table: "MoviesProductionCountries",
                newName: "IX_MoviesProductionCountries_ProductionCountryID");

            migrationBuilder.RenameColumn(
                name: "ProductionCompaniesId",
                table: "MoviesProductionCompanies",
                newName: "ProductionCompanyID");

            migrationBuilder.RenameColumn(
                name: "MoviesId",
                table: "MoviesProductionCompanies",
                newName: "MovieID");

            migrationBuilder.RenameIndex(
                name: "IX_MoviesProductionCompanies_ProductionCompaniesId",
                table: "MoviesProductionCompanies",
                newName: "IX_MoviesProductionCompanies_ProductionCompanyID");

            migrationBuilder.RenameColumn(
                name: "MoviesId",
                table: "MoviesGenres",
                newName: "MovieID");

            migrationBuilder.RenameColumn(
                name: "GenresId",
                table: "MoviesGenres",
                newName: "GenreID");

            migrationBuilder.RenameIndex(
                name: "IX_MoviesGenres_MoviesId",
                table: "MoviesGenres",
                newName: "IX_MoviesGenres_MovieID");

            migrationBuilder.CreateTable(
                name: "MoviesSpokenLanguages",
                columns: table => new
                {
                    MovieID = table.Column<long>(type: "bigint", nullable: false),
                    SpokenLanguageID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesSpokenLanguages", x => new { x.MovieID, x.SpokenLanguageID });
                    table.ForeignKey(
                        name: "FK_MoviesSpokenLanguages_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviesSpokenLanguages_SpokenLanguage_SpokenLanguageID",
                        column: x => x.SpokenLanguageID,
                        principalTable: "SpokenLanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoviesSpokenLanguages_SpokenLanguageID",
                table: "MoviesSpokenLanguages",
                column: "SpokenLanguageID");

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesGenres_Genres_GenreID",
                table: "MoviesGenres",
                column: "GenreID",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesGenres_Movies_MovieID",
                table: "MoviesGenres",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesProductionCompanies_Movies_MovieID",
                table: "MoviesProductionCompanies",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesProductionCompanies_ProductionCompanies_ProductionCompanyID",
                table: "MoviesProductionCompanies",
                column: "ProductionCompanyID",
                principalTable: "ProductionCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesProductionCountries_Movies_MovieID",
                table: "MoviesProductionCountries",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesProductionCountries_ProductionCountries_ProductionCountryID",
                table: "MoviesProductionCountries",
                column: "ProductionCountryID",
                principalTable: "ProductionCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoviesGenres_Genres_GenreID",
                table: "MoviesGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviesGenres_Movies_MovieID",
                table: "MoviesGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviesProductionCompanies_Movies_MovieID",
                table: "MoviesProductionCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviesProductionCompanies_ProductionCompanies_ProductionCompanyID",
                table: "MoviesProductionCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviesProductionCountries_Movies_MovieID",
                table: "MoviesProductionCountries");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviesProductionCountries_ProductionCountries_ProductionCountryID",
                table: "MoviesProductionCountries");

            migrationBuilder.DropTable(
                name: "MoviesSpokenLanguages");

            migrationBuilder.RenameColumn(
                name: "ProductionCountryID",
                table: "MoviesProductionCountries",
                newName: "ProductionCountriesId");

            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "MoviesProductionCountries",
                newName: "MoviesId");

            migrationBuilder.RenameIndex(
                name: "IX_MoviesProductionCountries_ProductionCountryID",
                table: "MoviesProductionCountries",
                newName: "IX_MoviesProductionCountries_ProductionCountriesId");

            migrationBuilder.RenameColumn(
                name: "ProductionCompanyID",
                table: "MoviesProductionCompanies",
                newName: "ProductionCompaniesId");

            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "MoviesProductionCompanies",
                newName: "MoviesId");

            migrationBuilder.RenameIndex(
                name: "IX_MoviesProductionCompanies_ProductionCompanyID",
                table: "MoviesProductionCompanies",
                newName: "IX_MoviesProductionCompanies_ProductionCompaniesId");

            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "MoviesGenres",
                newName: "MoviesId");

            migrationBuilder.RenameColumn(
                name: "GenreID",
                table: "MoviesGenres",
                newName: "GenresId");

            migrationBuilder.RenameIndex(
                name: "IX_MoviesGenres_MovieID",
                table: "MoviesGenres",
                newName: "IX_MoviesGenres_MoviesId");

            migrationBuilder.CreateTable(
                name: "MovieSpokenLanguage",
                columns: table => new
                {
                    MoviesId = table.Column<long>(type: "bigint", nullable: false),
                    SpokenLanguagesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieSpokenLanguage", x => new { x.MoviesId, x.SpokenLanguagesId });
                    table.ForeignKey(
                        name: "FK_MovieSpokenLanguage_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieSpokenLanguage_SpokenLanguage_SpokenLanguagesId",
                        column: x => x.SpokenLanguagesId,
                        principalTable: "SpokenLanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieSpokenLanguage_SpokenLanguagesId",
                table: "MovieSpokenLanguage",
                column: "SpokenLanguagesId");

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesGenres_Genres_GenresId",
                table: "MoviesGenres",
                column: "GenresId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesGenres_Movies_MoviesId",
                table: "MoviesGenres",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesProductionCompanies_Movies_MoviesId",
                table: "MoviesProductionCompanies",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesProductionCompanies_ProductionCompanies_ProductionCompaniesId",
                table: "MoviesProductionCompanies",
                column: "ProductionCompaniesId",
                principalTable: "ProductionCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesProductionCountries_Movies_MoviesId",
                table: "MoviesProductionCountries",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesProductionCountries_ProductionCountries_ProductionCountriesId",
                table: "MoviesProductionCountries",
                column: "ProductionCountriesId",
                principalTable: "ProductionCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
