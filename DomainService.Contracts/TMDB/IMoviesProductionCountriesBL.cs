using Entities.TMDB.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Contracts.TMDB
{
	public interface IMoviesProductionCountriesBL
	{
		public List<MovieProductionCountry> Save(long movieId, List<MovieProductionCountry> entities);
	}
}
