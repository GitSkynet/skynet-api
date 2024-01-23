using Entities.Base;

namespace Entities.TMDB.Movies
{
	public class MoviesGenres : EntityBase
	{
		public long MovieID { get; set; }
		public Movie Movies { get; set; }

		public long GenreID { get; set; }
		public Genre Genres { get; set; }
	}
}
