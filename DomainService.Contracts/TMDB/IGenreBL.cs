using Entities.TMDB.Movies;
using System.Xml.Linq;

namespace DomainService.Contracts.TMDB
{
	public interface IGenreBL
	{
		public List<Genre> GetAll();

		public Genre GetByIdTMDB(long id);

		public Genre GetById(long genreId);

		public Genre Update(Genre genreToAdd);

		public Genre Create(Genre genreToAdd);

		public Genre Delete(long genreId);

		public Task<List<Genre>> UpdateGenresFromTmdb();

		public bool AlreadyExistsByName(string name);

		public bool AlreadyExistsByIdTMDB(long id);

		void SaveAssociatedGenres(long movieId, List<Genre> genres);
	}
}
