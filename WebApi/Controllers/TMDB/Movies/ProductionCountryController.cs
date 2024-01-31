using DomainService.Contracts.TMDB;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.TMDB.Movies
{
	[ApiController]
	[Route("api/tmdb/production_country")]
	public class ProductionCountryController : Controller
    {
		private readonly IProductionCountriesBL prodCountBL;

		public ProductionCountryController(IProductionCountriesBL iProdCountBL)
		{
			prodCountBL = iProdCountBL;
		}

		[HttpGet]
		[Route("update_countries_from_tmdb")]
		public async Task<IActionResult> UpdateCountriesFromTmdb()
		{
			var result = await prodCountBL.UpdateCountriesFromTmdb();
			return new ObjectResult(result);
		}
	}
}
