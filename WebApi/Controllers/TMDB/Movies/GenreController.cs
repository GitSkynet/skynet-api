using DomainService.Contracts.TMDB;
using Entities.TMDB.Movies;
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
		[Route("get_all")]
		public IActionResult GetAll() => new ObjectResult(genreBL.GetAll());
		
		[HttpGet]
		[Route("get_by_ID")]
		public IActionResult GetById(long genreId) => new ObjectResult(genreBL.GetById(genreId));

		[HttpGet]
		[Route("create")]
		public IActionResult CreateGenre(string name, long idTmdb)
		{
			Genre genreToAdd = new()
			{
				Name = name,
				IdTMDB = idTmdb
			};

			return new ObjectResult(genreBL.Create(genreToAdd));
		}

		[HttpGet]
		[Route("update")]
		public IActionResult UpdateGenre(string name, long id)
		{
			Genre genreToAdd = new()
			{
				Name = name,
				Id = id
			};

			return new ObjectResult(genreBL.Update(genreToAdd));
		}
		
		[HttpGet]
		[Route("delete")]
		public IActionResult DeleteGenre(long genreId) => new ObjectResult(genreBL.Delete(genreId));

		[HttpGet]
		[Route("update_from_tmdb")]
		public async Task<IActionResult> UpdateGenresFromTmdb(long Id) 
			=> new ObjectResult(await genreBL.UpdateGenresFromTmdb());

	}
}