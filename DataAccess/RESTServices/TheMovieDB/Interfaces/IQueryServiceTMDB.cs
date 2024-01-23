using Entities.TMDB;
using Entities.TMDB.Movies;
using Entities.TMDB.TVShows;
using System.Threading.Tasks;

namespace DataAccess.RESTServices.TheMovieDB.Interfaces
{
    public interface IQueryServiceTMDB
    {
        public Task<Movie> GetByID(long movieID, string language);

        public Task<TvShow> GetTvShowById(long tvShowID, string language);

		public Task<List<Movie>> GetMostPopularMovies(string page);

        public Task<List<Movie>> GetUpcomingMovies(string page);

        public Task<List<Movie>> GetNowPlayingMovies(string page);

		public Task<List<TvShow>> GetMostPopularTvShows(string language, string page);

        public Task<List<Movie>> GetMostRecentMovies(string language, string page);

        public Task<List<TvShow>> GetMostRecentTvShows(string language, string page);

        public Task<List<Movie>> GetMoviesByGenre(string genre, string page, bool adult);

        public Task<List<TvShow>> GetTvShowsByCategory(string category, string language, string page);

        public Task<string> GetMovieTrailer(long movieId, string language);

        public Task<List<Movie>> GetTrendingDay(string page);

        public Task<List<Movie>> GetTrendingWeek(string page);

        public Task<List<Movie>> GetTopRated(string page);

        public Task<List<ProductionCountry>> GetProductionCountries();

        public Task<List<SpokenLanguage>> GetSpokenLanguages();

        public Task<List<Genre>> GetGenres();

        public Task<ResponseChangeMovies> GetMoviesChanged(string page);
	}
}
