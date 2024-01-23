using DomainService.Contracts.TMDB;
using Entities.TMDB.Movies;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.TMDB.Movies
{
	[ApiController]
	[Route("api/tmdb/production_company")]
	public class ProductionCompanyController : Controller
    {
		private readonly IProductionCompaniesBL prodCompBL;

		public ProductionCompanyController(IProductionCompaniesBL iProdCompBL)
		{
			prodCompBL = iProdCompBL;
		}

		[HttpGet]
		[Route("get_all")]
		public IActionResult GetAll() => new ObjectResult(prodCompBL.GetAll());

		[HttpGet]
		[Route("get_by_ID")]
		public IActionResult GetById(long Id) => new ObjectResult(prodCompBL.GetById(Id));

		[HttpGet]
		[Route("update")]
		public IActionResult UpdateProductionCompany(string name, string originCountry, string logoPath, long idTmdb, long idDb)
		{
			ProductionCompany productionCompany = new()
			{
				Id = idDb,
				LogoPath = logoPath,
				Name = name,
				OriginCountry = originCountry,
				IdTMDB = idTmdb
			};

			return new ObjectResult(prodCompBL.Update(productionCompany));
		}

		[HttpGet]
		[Route("create")]
		public IActionResult CreateProductionCompany(string name, string originCountry, string logoPath, long idTmdb)
		{
			ProductionCompany productionCompany = new()
			{
				LogoPath = logoPath,
				Name = name,
				OriginCountry = originCountry,
				IdTMDB = idTmdb
			};

			return new ObjectResult(prodCompBL.Create(productionCompany));
		}

		[HttpGet]
		[Route("delete")]
		public IActionResult DeleteProductionCompany(long Id) => new ObjectResult(prodCompBL.Delete(Id));
	}
}