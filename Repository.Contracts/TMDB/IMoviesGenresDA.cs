using Entities.TMDB.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts.TMDB
{
	public interface IMoviesGenresDA
	{
		bool AlreadyExists(MoviesGenres movieGenre);

		List<MoviesGenres> GetAllByMovieId(long movieId);
	}
}
