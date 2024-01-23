using Entities.TMDB.Movies;

namespace Repository.Contracts.TMDB
{
	public interface IMovieSpokenLanguagesDA
	{
		bool AlreadyExists(MovieSpokenLanguage movieSpokenLanguage);

		List<MovieSpokenLanguage> GetAllByMovieId(long movieId);
	}
}
