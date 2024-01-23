using Entities.TMDB.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts.TMDB
{
	public interface IMoviesProductionCountriesDA
	{
		bool AlreadyExists(MovieProductionCountry movieProductionCountry);

		List<MovieProductionCountry> GetAllByMovieId(long movieId);
	}
}
