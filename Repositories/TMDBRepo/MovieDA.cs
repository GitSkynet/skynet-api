using DataContext.DbContexts.TmdbDbContext;
using Entities.TMDB.Movies;
using Microsoft.EntityFrameworkCore;
using Repositories.BaseDA;
using Repository.Contracts.TMDB;

namespace Repositories.TMDBRepo
{
	public class MovieDA : BaseDA<Movie>, IMovieDA
	{
		private readonly TmdbDbContext dbContext;

		public MovieDA(TmdbDbContext context) : base(context)
		{
			dbContext = context;
		}

		public Movie GetByIdTMDB(long id)
		{
			return AsQueryable()
				.Include(x => x.Genres)
			.Where(m => m.IdTMDB == id).AsNoTracking()
			.FirstOrDefault();
		}

		public bool AlreadyExists(long movieId)
		{
			return AsQueryable()
				.Where(x => x.Id == movieId)
				.Any();
		}
		
		public bool AlreadyExistsByIdTmdb(long id)
		{
			return AsQueryable()
				.Where(x => x.IdTMDB == id)
				.Any();
		}

		public override Movie GetById(long movieID)
		{
			Movie? movie = AsQueryable()
				.Where(x => x.Id == movieID)
				.Include(x => x.Genres)
				.Include(x => x.ProductionCompanies)
				.Include(x => x.ProductionCountries)
				.Include(x => x.SpokenLanguages)
				.FirstOrDefault();
			return movie;
		}

		public List<Movie> GetMostPopular(string language, int results)
		{
			return AsQueryable()
				.OrderByDescending(x => x.Popularity)
				.Take(results)
				.ToList();
		}

		public List<Movie> GetMostRecent(string language, string status, int limit)
		{
			return AsQueryable()
				.Where(x => x.Status == status)
				.OrderByDescending(x => x.ReleaseDate)
				.Take(limit)
				.ToList();
		}

		public List<Movie> GetByGenre(string category, string language, int results, bool adult)
		{
			var query = AsQueryable()
				.Include(x => x.Genres)
				.Include(x => x.SpokenLanguages)
				.Include(x => x.ProductionCompanies)
				.Include(x => x.ProductionCountries)
				.Where(e => e.Genres.Any(c => c.Name == category));

			if (!string.IsNullOrEmpty(language))
				query = query.Where(e => e.SpokenLanguages.Any(sl => sl.Name == category));

			if (results != 0)
				query = query.Take(results);

			if (adult)
				query = query.Where(m => m.Adult == adult);

			return query.ToList();
		}

		public List<Movie> GetUpcoming()
		{
			return AsQueryable()
				.Where(x => x.Upcoming == true)
					.Include(x => x.Genres)
					.Include(x => x.SpokenLanguages)
					.Include(x => x.ProductionCompanies)
					.Include(x => x.ProductionCountries)
				.ToList();
		}

		public List<Movie> GetNowPlaying()
		{
			return AsQueryable()
				.Where(x => x.NowPlaying == true)
					.Include(x => x.Genres)
					.Include(x => x.SpokenLanguages)
					.Include(x => x.ProductionCompanies)
					.Include(x => x.ProductionCountries)
				.ToList();
		}

		public List<Movie> GetTrendingDay()
		{
			return AsQueryable()
				.Where(x => x.TrendingDay == true)
					.Include(x => x.Genres)
					.Include(x => x.SpokenLanguages)
					.Include(x => x.ProductionCompanies)
					.Include(x => x.ProductionCountries)
				.ToList();
		}
		
		public List<Movie> GetTrendingWeek()
		{
			return AsQueryable()
				.Where(x => x.TrendingWeek == true)
					.Include(x => x.Genres)
					.Include(x => x.SpokenLanguages)
					.Include(x => x.ProductionCompanies)
					.Include(x => x.ProductionCountries)
				.ToList();
		}
		
		public List<Movie> GetTopRated()
		{
			return AsQueryable()
				.Where(x => x.TopRated == true)
					.Include(x => x.Genres)
					.Include(x => x.SpokenLanguages)
					.Include(x => x.ProductionCompanies)
					.Include(x => x.ProductionCountries)
				.ToList();
		}
	}
}
