using DomainService.Contracts.TMDB;
using DomainService.Services.BaseBL;
using Entities.TMDB.Movies;
using Repository.Contracts.TMDB;

namespace DomainService.Services.TMDB
{
	public class MovieProductionCompaniesBL : BaseBL<MovieProductionCompany>, IMoviesProductionCompaniesBL
	{
		private IMoviesProductionCompaniesDA companiesDA => (IMoviesProductionCompaniesDA)DataAccess;

		public MovieProductionCompaniesBL(IMoviesProductionCompaniesDA icompaniesDA)
			: base((Repositories.BaseDA.IBaseDA<MovieProductionCompany>)icompaniesDA)
		{
		}

		public List<MovieProductionCompany> Save(long movieId, List<MovieProductionCompany> moviesCompanies)
		{
			List<MovieProductionCompany> companiesOnDb = companiesDA.GetAllByMovieId(movieId);
			List<MovieProductionCompany> companiesToSave = new();

			if (!companiesOnDb.Any())
				moviesCompanies.ForEach(x =>
				{
					x.RowState = Entities.Base.RowState.Added;
					companiesToSave.Add(x);
				});
			else
			{
				companiesOnDb
					.Where(pc => !moviesCompanies.Exists(x => x.ProductionCompanyID == pc.ProductionCompanyID))
					.ToList()
					.ForEach(e =>
					{
						e.RowState = Entities.Base.RowState.Deleted;
						companiesToSave.Add(e);
					});

				companiesOnDb
					.Where(pc => moviesCompanies.Exists(x => x.ProductionCompanyID == pc.ProductionCompanyID))
					.ToList()
					.ForEach(e =>
					{
						e.RowState = Entities.Base.RowState.Unchanged;
						companiesToSave.Add(e);
					});

				moviesCompanies
					.Where(pc => !companiesOnDb.Exists(x => x.ProductionCompanyID == pc.ProductionCompanyID))
					.ToList()
					.ForEach(e =>
					{
						e.RowState = Entities.Base.RowState.Added;
						companiesToSave.Add(e);
					});
			}

			return base.Save(companiesToSave);
		}
	}
}
