using DataContext.DbContexts.TmdbDbContext;
using Entities.TMDB.Movies;
using Repositories.BaseDA;
using Repository.Contracts.TMDB;

namespace Repositories.TMDBRepo
{
	public class ProductionCountriesDA : BaseDA<ProductionCountry>, IProductionCountriesDA
	{
		private readonly TmdbDbContext dbContext;

		public ProductionCountriesDA(TmdbDbContext context) : base(context)
		{
			dbContext = context;
		}

		public bool HasMoviesAssociated(long Id)
		{
			return AsQueryable<MovieProductionCountry>()
				.Where(pc => pc.ProductionCountryID == Id)
				.Any();
		}

		public ProductionCountry GetByIso(string iso31661)
		{
			return AsQueryable()
				.Where(pc => pc.Iso31661 == iso31661)
				.FirstOrDefault();
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
		
		public bool AlreadyExistsByIso(string iso31661)
		{
			return AsQueryable()
				.Where(pc => pc.Iso31661 == iso31661)
				.Any();
		}
	}
}
