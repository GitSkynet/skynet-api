using Entities.TMDB;
using Entities.TMDB.Movies;

namespace DomainService.Contracts.TMDB
{
	public interface IMovieBL
	{
		List<Movie> GetAll();

		Movie GetById(long movieId);

		List<Movie> GetUpcoming();

		List<Movie> GetNowPlaying();

		List<Movie> GetTrendingDay();

		List<Movie> GetTrendingWeek();

		List<Movie> GetTopRated();

		Movie Update(Movie movieToUpdate);

		Movie Create(Movie movieToAdd);

		Movie Delete(long movieToDelete);

		List<MovieUpdated> UpdateFromTmdbByGenre(string genre, string page, bool adult);

		List<Movie> GetMostPopular(string language, int results);

		List<MovieUpdated> UpdateFromTmdbByUpcoming(string page);

		List<MovieUpdated> UpdateFromTmdbByNowPlaying(string page);

		List<MovieUpdated> UpdateFromTmdbByMostPopular(string page);

		List<MovieUpdated> UpdateFromTmdbByTrendingDay(string page);

		List<MovieUpdated> UpdateFromTmdbByTrendingWeek(string page);

		List<MovieUpdated> UpdateFromTmdbByTopRated(string page);

		List<Movie> GetMostRecent(string language, string status, int limit);

		List<Movie> GetByGenre(string category, string language, int results, bool adult);

		List<MovieUpdated> SyncLastAddedFromTmdb(string page);
	}
}
