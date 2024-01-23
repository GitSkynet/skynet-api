using DataContext.DbContexts.TmdbDbContext;
using Entities.TMDB.Movies;
using Microsoft.EntityFrameworkCore;
using Repositories.BaseDA;
using Repository.Contracts.TMDB;

namespace Repositories.TMDBRepo
{
	public class ProductionCompaniesDA : BaseDA<ProductionCompany>, IProductionCompaniesDA
	{
		private readonly TmdbDbContext dbContext;

		public ProductionCompaniesDA(TmdbDbContext context) : base(context)
		{
			dbContext = context;
		}

		public ProductionCompany GetByIdTMDB(long id)
		{
			return AsQueryable()
			.Where(mg => mg.IdTMDB == id)
			.FirstOrDefault()!;
		}

		public ProductionCompany GetByName(string name)
		{
			return AsQueryable()
			.Where(pc => pc.Name == name)
			.FirstOrDefault()!;
		}

		public bool HasMoviesAssociated(long Id)
		{
			return AsQueryable<MovieProductionCompany>()
				.Where(pc => pc.ProductionCompanyID == Id)
				.Any();
		}

		public bool AlreadyExistsById(long id)
		{
			return AsQueryable()
				.Where(pc => pc.Id == id)
				.Any();
		}

		public bool AlreadyExistsByName(string name)
		{
			return AsQueryable()
				.Where(pc => pc.Name == name)
				.Any();
		}

		public bool AlreadyExistsByIdTMDB(long id)
		{
			return AsQueryable()
			.Where(g => g.IdTMDB == id)
			.Any();
		}
	}
}
