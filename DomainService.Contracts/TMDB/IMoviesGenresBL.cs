using Entities.TMDB.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Contracts.TMDB
{
	public interface IMoviesGenresBL
	{
		public List<MoviesGenres> Save(long movieId, List<MoviesGenres> entities);
	}
}
