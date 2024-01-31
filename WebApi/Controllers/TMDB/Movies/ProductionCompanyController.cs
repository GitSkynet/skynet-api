using DomainService.Contracts.TMDB;
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
	}
}