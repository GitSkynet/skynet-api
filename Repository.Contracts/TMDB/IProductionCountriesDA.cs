using Entities.TMDB.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts.TMDB
{
	public interface IProductionCountriesDA
	{
		public bool HasMoviesAssociated(long Id);

		public bool AlreadyExistsById(long id);

		public bool AlreadyExistsByName(string name);

		public bool AlreadyExistsByIso(string iso31661);

		public ProductionCountry GetByIso(string name);
	}
}
