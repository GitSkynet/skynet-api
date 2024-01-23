using Entities.TMDB;
using Entities.TMDB.Movies;
using Entities.TMDB.TVShows;

namespace DomainService.Contracts.TMDB
{
    public interface ITVShowBL
    {
        public Task<TvShow> GetTvShowById(long tvShowID, string language);

        public Task<List<TvShow>> GetMostPopularTvShows(string language, string page);

        public Task<List<TvShow>> GetMostRecentTvShows(string language, string page);

        public Task<List<TvShow>> GetTvShowsByCategory(string category, string language, string page);
    }
}
