using DataContext.DbContexts.TmdbDbContext;
using Entities.TMDB.Movies;
using Repositories.BaseDA;
using Repository.Contracts.TMDB;

namespace Repositories.TMDBRepo
{
	public class MovieSpokenLanguageDA : BaseDA<MovieSpokenLanguage>, IMovieSpokenLanguagesDA
	{
		private readonly TmdbDbContext dbContext;

		public MovieSpokenLanguageDA(TmdbDbContext context) : base(context)
		{
			dbContext = context;
		}

		public bool AlreadyExists(MovieSpokenLanguage movieLanguage)
		{
			return AsQueryable()
				.Where(x => x.MovieID == movieLanguage.MovieID)
				.Where(x => x.SpokenLanguageID == movieLanguage.SpokenLanguageID)
				.Any();
		}

		public List<MovieSpokenLanguage> GetAllByMovieId(long movieId)
		{
			return AsQueryable()
				.Where(x => x.MovieID == movieId)
				.ToList();
		}
	}
}
