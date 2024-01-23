using Entities.Base;

namespace Entities.TMDB.Movies
{
	public class MovieProductionCountry : EntityBase
	{
		public long MovieID { get; set; }
		public Movie Movies { get; set; }

		public long ProductionCountryID { get; set; }
		public ProductionCountry ProductionCountries { get; set; }
	}
}