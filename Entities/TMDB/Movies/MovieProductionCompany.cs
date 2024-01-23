using Entities.Base;

namespace Entities.TMDB.Movies
{
	public class MovieProductionCompany : EntityBase
	{
		public long MovieID { get; set; }
		public Movie Movies { get; set; }

		public long ProductionCompanyID { get; set; }

		public ProductionCompany ProductionCompanies { get; set; }
	}
}
