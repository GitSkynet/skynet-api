using DataContext.DbContexts.TmdbDbContext;
using Entities.TMDB.Movies;
using Repositories.BaseDA;
using Repository.Contracts.TMDB;

namespace Repositories.TMDBRepo
{
	public class MoviesGenresDA : BaseDA<MoviesGenres>, IMoviesGenresDA
	{ 
		private readonly TmdbDbContext dbContext;

		public MoviesGenresDA(TmdbDbContext context) : base(context)
		{
			dbContext = context;
		}

		public bool AlreadyExists(MoviesGenres movieGenre)
		{
			return AsQueryable()
				.Where(x => x.MovieID == movieGenre.MovieID)
				.Where(x => x.GenreID == movieGenre.GenreID)
				.Any();
		}

		public List<MoviesGenres> GetAllByMovieId(long movieId)
		{
			return AsQueryable()
				.Where(x => x.MovieID == movieId)
				.ToList();
		}
	}
}
