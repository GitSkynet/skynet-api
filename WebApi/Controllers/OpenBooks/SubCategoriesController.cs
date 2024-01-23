using CleanArchitecture.Application.Contracts.OpenBooksContracts;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.OpenBooks
{
	[ApiController]
	[Route("api/openbooks/subcategories")]
	public class SubCategoriesController : Controller
	{
		private readonly ISubCategoriesApplicationService subCategoryService;

		public SubCategoriesController(ISubCategoriesApplicationService AppSubCategoryService)
		{
			subCategoryService = AppSubCategoryService;
		}

		[HttpGet]
		[Route("get_all")]
		public async Task<IActionResult> GetAllSubCategories()
		{
			var response = await subCategoryService.GetAllSubCategories();
			return new ObjectResult(response);
		}
	}
}
