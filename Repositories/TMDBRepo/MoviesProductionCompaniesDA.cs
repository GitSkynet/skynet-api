using DataContext.DbContexts.TmdbDbContext;
using Entities.TMDB.Movies;
using Repositories.BaseDA;
using Repository.Contracts.TMDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.TMDBRepo
{
	public class MoviesProductionCompaniesDA : BaseDA<MovieProductionCompany>, IMoviesProductionCompaniesDA
	{
		private readonly TmdbDbContext dbContext;

		public MoviesProductionCompaniesDA(TmdbDbContext context) : base(context)
		{
			dbContext = context;
		}

		public bool AlreadyExists(MovieProductionCompany prodCount)
		{
			return AsQueryable()
				.Where(x => x.MovieID == prodCount.MovieID)
				.Where(x => x.ProductionCompanyID == prodCount.ProductionCompanyID)
				.Any();
		}

		public List<MovieProductionCompany> GetAllByMovieId(long movieId)
		{
			return AsQueryable()
				.Where(x => x.MovieID == movieId)
				.ToList();
		}
	}
}
