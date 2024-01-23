using Entities.TMDB.Movies;

namespace Repository.Contracts.TMDB
{
	public interface IGenreDA
	{
		public Genre GetByIdTMDB(long id);

		public Genre GetByName(string name);
		public bool HasMoviesAssociated(long genreId);

		public bool AlreadyExistsById(long id);
		public bool AlreadyExistsByIdTMDB(long id);

		public bool AlreadyExistsByName(string genreName);
	}
}
