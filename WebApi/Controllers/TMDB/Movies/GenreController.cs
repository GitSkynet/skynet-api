using DomainService.Contracts.TMDB;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.TMDB.Movies
{
	[ApiController]
	[Route("api/tmdb/genres")]
	public class GenreController : Controller
    {
		private readonly IGenreBL genreBL;

		public GenreController(IGenreBL iGenreBL)
		{
			genreBL = iGenreBL;
		}

		[HttpGet]
		[Route("update_from_tmdb")]
		public async Task<IActionResult> UpdateGenresFromTmdb(long Id) 
			=> new ObjectResult(await genreBL.UpdateGenresFromTmdb());

	}
}