using AutoMapper;
using DomainService.Contracts.TMDB;
using Entities.TMDB;
using Entities.TMDB.Movies;
using Entities.TMDB.TVShows;
using Repository.Contracts.TMDB;

namespace DomainService.Services.TMDB
{
    public class TVShowBL: ITVShowBL
    {
        private readonly ITVShowDA tmdbDA;
        private readonly IMapper mapper;

        public TVShowBL(ITVShowDA ItmdbDA, IMapper mapper) 
        {
            tmdbDA = ItmdbDA;
            this.mapper = mapper;
        }

        public Task<TvShow> GetTvShowById(long tvShowID, string language) => tmdbDA.GetTvShowById(tvShowID, language);

        public async Task<List<TvShow>> GetMostPopularTvShows(string language, string page)
        {
            try
            {
                List<TvShow> mostPopularTvShowsRepo = await tmdbDA.GetMostPopularTvShows(language, page);
                return mostPopularTvShowsRepo;
            }
            catch (Exception ex)
            {
                throw new Exception($"Message: {ex.Message} InnerException:{ex.InnerException}");
            }
        }
        
        public async Task<List<TvShow>> GetMostRecentTvShows(string language, string page)
        {
            try
            {
                List<TvShow> mostRecenTvShowsRepo = await tmdbDA.GetMostRecentTvShows(language, page);
                return mostRecenTvShowsRepo;
            }
            catch (Exception ex)
            {
                throw new Exception($"Message: {ex.Message} InnerException:{ex.InnerException}");
            }
        }
        
        public async Task<List<TvShow>> GetTvShowsByCategory(string category, string page, string language)
        {
            return await tmdbDA.GetTvShowsByCategory(category, page, language);
        }
    }
}
