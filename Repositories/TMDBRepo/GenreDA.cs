using DataContext.DbContexts.TmdbDbContext;
using Entities.TMDB.Movies;
using Repositories.BaseDA;
using Repository.Contracts.TMDB;

namespace Repositories.TMDBRepo
{
	public class GenreDA : BaseDA<Genre>, IGenreDA
	{
		private readonly TmdbDbContext dbContext;
		
		public GenreDA(TmdbDbContext context) : base(context)
		{
			dbContext = context;
		}

		public Genre GetByIdTMDB(long id)
		{
			return AsQueryable()
				.Where(mg => mg.IdTMDB == id)
				.FirstOrDefault()!;
		}

		public Genre GetByName(string name)
		{
			return AsQueryable()
				.Where(g => g.Name == name)
				.FirstOrDefault()!;
		}
		
		public bool HasMoviesAssociated(long genreId)
		{
			return AsQueryable<MoviesGenres>()
			.Where(mg => mg.GenreID == genreId)
			.Any();
		}

		public bool AlreadyExistsById(long id)
		{
			return AsQueryable()
			.Where(g => g.Id == id)
			.Any();
		}
		
		public bool AlreadyExistsByIdTMDB(long id)
		{
			return AsQueryable()
			.Where(g => g.IdTMDB == id)
			.Any();
		}
		
		public bool AlreadyExistsByName(string name)
		{
			return AsQueryable()
			.Where(g => g.Name == name)
			.Any();
		}
	}
}
