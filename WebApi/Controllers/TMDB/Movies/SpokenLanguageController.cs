using DataAccess.RESTServices.TheMovieDB.Interfaces;
using DomainService.Contracts.TMDB;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.TMDB.Movies
{
	[ApiController]
	[Route("api/tmdb/spokenlanguages")]
	public class SpokenLanguageController : Controller
    {
		private readonly ISpokenLanguageBL splangBL;
		private readonly IQueryServiceTMDB queryService;

		public SpokenLanguageController(ISpokenLanguageBL iSlangBL, IQueryServiceTMDB iQueryService)
		{
			queryService = iQueryService;
			splangBL = iSlangBL;
		}

		[HttpGet]
		[Route("update_from_tmdb")]
		public async Task<IActionResult> UpdateSpokenLanguagesFromTmdb(long Id) => new ObjectResult(await splangBL.UpdateLanguagesFromTmdb());
	}
}
