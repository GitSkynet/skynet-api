using DataContext.DbContexts.TmdbDbContext;
using Entities.TMDB.Movies;
using Repositories.BaseDA;
using Repository.Contracts.TMDB;

namespace Repositories.TMDBRepo
{
	public class SpokenLanguageDA : BaseDA<SpokenLanguage>, ISpokenLanguageDA
	{
		private readonly TmdbDbContext dbContext;

		public SpokenLanguageDA(TmdbDbContext context) : base(context)
		{
			dbContext = context;
		}

		public bool HasMoviesAssociated(long Id)
		{
			return AsQueryable<MovieSpokenLanguage>()
			.Where(sl => sl.SpokenLanguageID == Id)
			.Any();
		}

		public SpokenLanguage GetByIso6391(string iso)
		{
			return AsQueryable()
				.Where(sl => sl.Iso6391 == iso)
				.FirstOrDefault();
		}
		
		public bool AlreadyExistsByIso(string iso)
		{
			return AsQueryable()
			.Where(sl => sl.Iso6391 == iso)
			.Any();
		}

		public bool AlreadyExistsById(long id)
		{
			return AsQueryable()
			.Where(sl => sl.Id == id)
			.Any();
		}

		public bool AlreadyExistsByName(string name)
		{
			return AsQueryable()
			.Where(sl => sl.EnglishName == name)
			.Any();
		}
	}
}
