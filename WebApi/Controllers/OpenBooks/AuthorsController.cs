using CleanArchitecture.Application.Contracts.OpenBooksContracts;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.OpenBooks
{
	[ApiController]
	[Route("api/openbooks/authors")]
	public class AuthorsController : Controller
	{
		private readonly IAuthorsApplicationService authorsService;

		public AuthorsController(IAuthorsApplicationService authorsAppService)
		{
			authorsService = authorsAppService;
		}

		[HttpGet]
		[Route("get_author_by_id")]
		public async Task<IActionResult> GetAuthorByID(int id)
		{
			var response = await authorsService.GetAuthorByID(id);
			return new ObjectResult(response);
		}
	}
}
