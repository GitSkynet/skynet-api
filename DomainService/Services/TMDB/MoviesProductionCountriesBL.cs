using DomainService.Contracts.TMDB;
using DomainService.Services.BaseBL;
using Entities.TMDB.Movies;
using Repository.Contracts.TMDB;

namespace DomainService.Services.TMDB
{
	public class MoviesProductionCountriesBL : BaseBL<MovieProductionCountry>, IMoviesProductionCountriesBL
	{
		private IMoviesProductionCountriesDA moviesProdCountsDA => (IMoviesProductionCountriesDA)DataAccess;

		public MoviesProductionCountriesBL(IMoviesProductionCountriesDA iMoviesProdCountDA)
			: base((Repositories.BaseDA.IBaseDA<MovieProductionCountry>)iMoviesProdCountDA)
		{
		}

		public List<MovieProductionCountry> Save(long movieId, List<MovieProductionCountry> moviesProdCounts)
		{
			List<MovieProductionCountry> moviesProdCountsOnDb = moviesProdCountsDA.GetAllByMovieId(movieId);
			List<MovieProductionCountry> prodCountsToSave = new();

			if (!moviesProdCountsOnDb.Any())
				moviesProdCounts.ForEach(x =>
				{
					x.RowState = Entities.Base.RowState.Added;
					prodCountsToSave.Add(x);
				});
			else
			{
				moviesProdCountsOnDb
					.Where(pc => !moviesProdCounts.Exists(x => x.ProductionCountryID == pc.ProductionCountryID))
					.ToList()
					.ForEach(e =>
					{
						e.RowState = Entities.Base.RowState.Deleted;
						prodCountsToSave.Add(e);
					});
				moviesProdCountsOnDb
					.Where(pc => moviesProdCounts.Exists(x => x.ProductionCountryID == pc.ProductionCountryID))
					.ToList()
					.ForEach(e =>
					{
						e.RowState = Entities.Base.RowState.Unchanged;
						prodCountsToSave.Add(e);
					});

				moviesProdCounts
					.Where(pc => !moviesProdCountsOnDb.Exists(x => x.ProductionCountryID == pc.ProductionCountryID))
					.ToList()
					.ForEach(e =>
					{
						e.RowState = Entities.Base.RowState.Added;
						prodCountsToSave.Add(e);
					});
			}

			return base.Save(prodCountsToSave);
		}
	}
}