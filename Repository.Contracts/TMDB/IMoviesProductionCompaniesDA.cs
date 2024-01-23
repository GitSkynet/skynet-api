using Entities.TMDB.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts.TMDB
{
	public interface IMoviesProductionCompaniesDA
	{
		bool AlreadyExists(MovieProductionCompany movieProductionCountry);

		List<MovieProductionCompany> GetAllByMovieId(long movieId);
	}
}
