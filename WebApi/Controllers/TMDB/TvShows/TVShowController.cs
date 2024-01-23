using DomainService.Contracts.TMDB;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.TMDB.TvShows
{
    [ApiController]
    [Route("api/tmdb/tvshows")]
    public class TVShowController : Controller
    {
        private readonly ITVShowBL tvShowBL;

        public TVShowController(ITVShowBL iTvShowBL)
        {
			tvShowBL = iTvShowBL;
        }

        [HttpGet]
        [Route("get_by_ID")]
        public IActionResult GetTvShowById(long tvShowID, string language)
        {
            var response = tvShowBL.GetTvShowById(tvShowID, language);
            return new ObjectResult(response);
        }

        [HttpGet]
        [Route("get_most_popular")]
        public IActionResult GetMostPopularTvShows(string language, string page)
        {
            var response = tvShowBL.GetMostPopularTvShows(language, page);
            return new ObjectResult(response);
        }

        [HttpGet]
        [Route("get_most_recent")]
        public IActionResult GetMostRecentTvShows(string language, string page)
        {
            var mostRecentTvShow = tvShowBL.GetMostRecentTvShows(language, page);
            return new ObjectResult(mostRecentTvShow);
        }

        [HttpGet]
        [Route("get_by_category")]
        public IActionResult GetTvShowsByCategory(string category, string language, string page)
        {
            var moviesByCategory = tvShowBL.GetTvShowsByCategory(category, page, language);
            return new ObjectResult(moviesByCategory);
        }
    }
}
