using CleanArchitecture.Application.Contracts.OpenBooksContracts;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.OpenBooks
{
	[ApiController]
	[Route("api/openbooks/categories")]
	public class CategoriesController : Controller
	{
		private readonly ICategoriesApplicationService categoryService;

		public CategoriesController(ICategoriesApplicationService categoriesService)
		{
			categoryService = categoriesService;
		}

		[HttpGet]
		[Route("get_all")]
		public async Task<IActionResult> GetAllCategories()
		{
			var response = await categoryService.getAllCategories();
			return new ObjectResult(response);
		}

		[HttpGet]
		[Route("get_by_id")]
		public async Task<IActionResult> GetCategoryById(long categoryID)
		{
			var response = await categoryService.GetCategoryById(categoryID);
			return new ObjectResult(response);
		}

		[HttpGet]
		[Route("get_best_categories")]
		public async Task<IActionResult> GetBestCategories()
		{
			var response = await categoryService.getBestCategories();
			return new ObjectResult(response);
		}

		[HttpGet]
		[Route("get_featured_categories")]
		public async Task<IActionResult> GetFeaturedCategories()
		{
			var response = await categoryService.getFeaturedCategories();
			return new ObjectResult(response);
		}
	}
}
