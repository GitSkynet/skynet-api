using DomainService.Contracts.TMDB;
using DomainService.Services.TMDB;
using Entities.TMDB.Movies;
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
		[Route("get_all")]
		public IActionResult GetAll() => new ObjectResult(prodCountBL.GetAll());

		[HttpGet]
		[Route("get_by_ID")]
		public IActionResult GetById(long Id) => new ObjectResult(prodCountBL.GetById(Id));

		[HttpGet]
		[Route("update")]
		public IActionResult UpdateProductionCountry(long id, long idTmdb, string iso31661, string name)
		{
			ProductionCountry productionCompany = new()
			{
				Id = id,
				Iso31661 = iso31661,
				Name = name,
				IdTMDB = idTmdb,
			};

			return new ObjectResult(prodCountBL.Update(productionCompany));
		}

		[HttpGet]
		[Route("create")]
		public IActionResult CreateProductionCountry(long idTmdb, string iso31661, string name)
		{
			ProductionCountry productionCompany = new()
			{
				IdTMDB = idTmdb,
				Iso31661 = iso31661,
				Name = name,
			};

			return new ObjectResult(prodCountBL.Create(productionCompany));
		}

		[HttpGet]
		[Route("delete")]
		public IActionResult DeleteProductionCountry(long Id) => new ObjectResult(prodCountBL.Delete(Id));


		[HttpGet]
		[Route("update_countries_from_tmdb")]
		public async Task<IActionResult> UpdateCountriesFromTmdb()
		{
			var result = await prodCountBL.UpdateCountriesFromTmdb();
			return new ObjectResult(result);
		}
	}
}
