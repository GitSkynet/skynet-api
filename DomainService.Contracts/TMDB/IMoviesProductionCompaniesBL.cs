using Entities.TMDB.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Contracts.TMDB
{
	public interface IMoviesProductionCompaniesBL
	{
		public List<MovieProductionCompany> Save(long movieId, List<MovieProductionCompany> entities);

	}
}
