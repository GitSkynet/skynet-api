using DataContext.DbContexts.TmdbDbContext;
using Entities.TMDB.Movies;
using Repositories.BaseDA;
using Repository.Contracts.TMDB;

namespace Repositories.TMDBRepo
{
	public class MoviesProductionCountriesDA : BaseDA<MovieProductionCountry>, IMoviesProductionCountriesDA
	{
		private readonly TmdbDbContext dbContext;

		public MoviesProductionCountriesDA(TmdbDbContext context) : base(context)
		{
			dbContext = context;
		}

		public bool AlreadyExists(MovieProductionCountry prodCount)
		{
			return AsQueryable()
				.Where(x => x.MovieID == prodCount.MovieID)
				.Where(x => x.ProductionCountryID == prodCount.ProductionCountryID)
				.Any();
		}

		public List<MovieProductionCountry> GetAllByMovieId(long movieId)
		{
			return AsQueryable()
				.Where(x => x.MovieID == movieId)
				.ToList();
		}
	}
}