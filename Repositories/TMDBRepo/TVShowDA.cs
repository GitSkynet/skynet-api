using DataAccess.RESTServices.TheMovieDB.Interfaces;
using DataContext.DbContexts.TmdbDbContext;
using Entities.TMDB;
using Entities.TMDB.Movies;
using Entities.TMDB.TVShows;
using Microsoft.EntityFrameworkCore;
using Repositories.BaseDA;
using Repository.Contracts.TMDB;

namespace Repositories.TMDBRepo
{
    public class TVShowDA : BaseDA<TvShow>, ITVShowDA
	{
		private readonly IQueryServiceTMDB tmdbQueryService;
		private readonly TmdbDbContext dbContext;

		public TVShowDA(IQueryServiceTMDB tmdbQueryService, TmdbDbContext context) : base(context)
		{
			dbContext = context;
			this.tmdbQueryService = tmdbQueryService;
		}

		public async Task<TvShow> GetTvShowById(long tvShowID, string language) 
			=> await tmdbQueryService.GetTvShowById(tvShowID, language);

		public async Task<List<TvShow>> GetMostPopularTvShows(string language, string page) 
			=> await tmdbQueryService.GetMostPopularTvShows(language, page);
			
		public async Task<List<TvShow>> GetMostRecentTvShows(string language, string page)
			=> await tmdbQueryService.GetMostRecentTvShows(language, page);

		public async Task<List<TvShow>> GetTvShowsByCategory(string category, string page, string language) => await tmdbQueryService.GetTvShowsByCategory(category, page, language);

	}
}
