using DataAccess.RESTServices.TheMovieDB.Interfaces;
using DomainService.Contracts.TMDB;
using Entities.TMDB.Movies;
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
		[Route("get_all")]
		public IActionResult GetAll() => new ObjectResult(splangBL.GetAll());

		[HttpGet]
		[Route("get_by_ID")]
		public IActionResult GetById(long Id) => new ObjectResult(splangBL.GetById(Id));

		[HttpGet]
		[Route("update")]
		public IActionResult Update(long id, long idTmdb, string name, string englishName, string iso6391)
		{
			SpokenLanguage spkLangToAdd = new()
			{
				Id = id,
				IdTMDB = idTmdb,
				Name = name,
				EnglishName = englishName,
				Iso6391 = iso6391
			};

			return new ObjectResult(splangBL.Update(spkLangToAdd));
		}

		[HttpGet]
		[Route("create")]
		public IActionResult Create(string name, string englishName, string iso6391, long idTmdb)
		{
			return new ObjectResult(splangBL.Create(new()
			{
				Name = name,
				EnglishName = englishName,
				Iso6391 = iso6391,
				IdTMDB = idTmdb
			}));
		}

		[HttpGet]
		[Route("delete")]
		public IActionResult DeleteSpokenLanguage(long Id) => new ObjectResult(splangBL.Delete(Id));

		[HttpGet]
		[Route("update_from_tmdb")]
		public async Task<IActionResult> UpdateSpokenLanguagesFromTmdb(long Id) => new ObjectResult(await splangBL.UpdateLanguagesFromTmdb());
	}
}
