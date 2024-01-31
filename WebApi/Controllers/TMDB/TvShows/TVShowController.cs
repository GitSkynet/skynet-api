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


    }
}
