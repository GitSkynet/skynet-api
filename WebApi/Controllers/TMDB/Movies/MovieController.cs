using DomainService.Contracts.TMDB;
using Entities.TMDB.Movies;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.TMDB.Movies
{
    [ApiController]
	[Route("api/tmdb/movies")]
	public class MovieController : Controller
    {
        private readonly IMovieBL movieBL;

        public MovieController(IMovieBL iMovieBL)
        {
			movieBL = iMovieBL;
        }

		[HttpGet]
		[Route("get_all")]
		public IActionResult GetAll(long movieId)
	        => new ObjectResult(movieBL.GetAll());

		[HttpGet]
        [Route("get_by_ID")]
        public IActionResult GetById(long movieId)
			=> new ObjectResult(movieBL.GetById(movieId));

		[HttpGet]
		[Route("update")]
		public IActionResult Update(long idMovie, string title)
        {
			Movie movieToSave = new()
			{
				Id= idMovie,
				Title = title,
				Adult = true,
				BackdropPath = "/asdfas/asdas/ass",
				Genres = new List<Genre>()
				{
					new Genre { Id = 45 },
					new Genre { Id = 54 },
					new Genre { Id = 57 },
					new Genre { Id = 58 }
				},

				ProductionCountries = new List<ProductionCountry>()
				{
					new ProductionCountry { Id = 593 },
					new ProductionCountry { Id = 594 },
					new ProductionCountry { Id = 595 },
				},

				SpokenLanguages = new List<SpokenLanguage>()
				{
					new SpokenLanguage { Id = 368},
					new SpokenLanguage { Id = 369}
				},

				OriginalLanguage = "Narniano",
				OriginalTitle = title,
				Overview = "",
				Popularity = 2.2,
				PosterPath = "asdasd/asdasda/aSDASD",
				Budget = 12000,
				Revenue = 12000,
				Runtime = 1212,
				Status = "On Air",
				Tagline = "myeggs",
				Video = false,
				ReleaseDate = "12/12/2023"
			};

			return new ObjectResult(movieBL.Update(movieToSave));
		}

		[HttpGet]
		[Route("create")]
		public IActionResult Create(string title, bool adult, string backDropPath)
        {
            Movie movieToSave = new()
            {
                Title = title,
                Adult = adult,
                BackdropPath = backDropPath,
				// !! genres idtmdb en id, prodcompanies idtmdb en id, prodcountries iso31661, spokenlanguages Iso6391
				Genres = new List<Genre>() { new Genre { Id = 28 } },
				ProductionCompanies = new List<ProductionCompany>() { new ProductionCompany { Id = 16026  } },
				ProductionCountries = new List<ProductionCountry>() { new ProductionCountry { Iso31661 = "AD" } },
				SpokenLanguages = new List<SpokenLanguage>() { new SpokenLanguage { Iso6391 = "xx" } },
				OriginalLanguage = "English",
                OriginalTitle = title,
                Overview = 
				"Las ladillas le han ganado la partida a la higiene y se abren paso por el basto " +
				"bosque de pelos púbicos crecidos de manera farragosa y nada estética. " +
				"El pollavieja del dueño, que es más guarro que María Martillo, " +
				"no se ducha desde hace años y se enfrenta a uno de los mayores retos de su vida: " +
				"seguir viviendo o romper sus ideales higiénicos y ducharse para poder conquistar " +
				"a la mujer de sus sueños, una pija loca que solo sabe follar y comer",
                Popularity = 2.2,
                PosterPath = "asdasd/asdasda/aSDASD",
                Budget = 12000,
                Revenue = 12000,
                Runtime = 1212,
                Status = "On Air",
                Tagline = "myeggs",
                Video = false,
                ReleaseDate = "12/12/2023"
			};

            return new ObjectResult(movieBL.Create(movieToSave));
		}

		[HttpGet]
		[Route("delete")]
		public IActionResult Delete(long movieId)
	        => new ObjectResult(movieBL.Delete(movieId));

		[HttpGet]
        [Route("get_most_popular")]
        public IActionResult GetMostPopular(string language, int results)
            => new ObjectResult(movieBL.GetMostPopular(language, results));

        [HttpGet]
        [Route("get_most_recent")]
        public IActionResult GetMostRecent(string language, string status, int limit)
            => new ObjectResult(movieBL.GetMostRecent(language, status, limit));

        [HttpGet]
        [Route("get_by_category")]
        public IActionResult GetByGenre(string category, string language, int results, bool adult)
            => new ObjectResult(movieBL.GetByGenre(category, language, results, adult));

        //[HttpGet]
        //[Route("get_trending_tvormovie_week")]
        //public IActionResult GetTrending(string movieOrTv, string weekOrDay, string page, string language)
        //    => new ObjectResult(movieBL.GetTrending(movieOrTv, weekOrDay, page, language));

		[HttpGet]
		[Route("update_from_tmdb_by_now_playing")]
		public IActionResult UpdateFromTmdbByNowPlaying(int pages)
		{
			var results = new List<MovieUpdated>();

			var nowPlayingMoviesOnDb = movieBL.GetNowPlaying();

			nowPlayingMoviesOnDb.ForEach(movie =>
			{
				movie.NowPlaying = false;
				movieBL.Update(movie);
			});

			for (int i = 1; i <= pages; i++)
			{
				var result = movieBL.UpdateFromTmdbByNowPlaying(i.ToString());
				foreach (var item in result)
				{
					results.Add(item);
				}
			}
			return new ObjectResult(results);
		}

		[HttpGet]
		[Route("update_from_tmdb_by_upcoming")]
		public IActionResult UpdateFromTmdbByUpcoming(int pages)
		{
			var results = new List<MovieUpdated>();

			var upcomingMoviesOnDb = movieBL.GetUpcoming();

			upcomingMoviesOnDb.ForEach(movie =>
			{
				movie.Upcoming = false;
				movieBL.Update(movie);
			});

			for (int i = 1; i <= pages; i++)
			{
				var result = movieBL.UpdateFromTmdbByUpcoming(i.ToString());
				foreach (var item in result)
				{
					results.Add(item);
				}
			}
			return new ObjectResult(results);
		}

		[HttpGet]
		[Route("update_from_tmdb_by_most_popular")]
		public IActionResult UpdateFromTmdbByMostPopular(int pages)
		{
			var results = new List<MovieUpdated>();
			for (int i = 1; i <= pages; i++)
			{
				var result = movieBL.UpdateFromTmdbByMostPopular(i.ToString());
				foreach (var item in result)
				{
					results.Add(item);
				}
			}
			return new ObjectResult(results); 
		}
		
		[HttpGet]
		[Route("update_from_tmdb_by_trending_day")]
		public IActionResult UpdateFromTmdbByTrendingDay(int pages)
		{
			var results = new List<MovieUpdated>();
			var trendingDayMoviesOnDb = movieBL.GetTrendingDay();
			trendingDayMoviesOnDb.ForEach(movie =>
			{
				movie.TrendingDay = false;
				movieBL.Update(movie);
			});

			for (int i = 1; i <= pages; i++)
			{
				var result = movieBL.UpdateFromTmdbByTrendingDay(i.ToString());
				foreach (var item in result)
				{
					results.Add(item);
				}
			}
			return new ObjectResult(results); 
		}
		
		[HttpGet]
		[Route("update_from_tmdb_by_trending_week")]
		public IActionResult UpdateFromTmdbByTrendingWeek(int pages)
		{
			var results = new List<MovieUpdated>();
			var trendingDayMoviesOnDb = movieBL.GetTrendingDay();
			trendingDayMoviesOnDb.ForEach(movie =>
			{
				movie.TrendingDay = false;
				movieBL.Update(movie);
			});

			for (int i = 1; i <= pages; i++)
			{
				var result = movieBL.UpdateFromTmdbByTrendingWeek(i.ToString());
				foreach (var item in result)
				{
					results.Add(item);
				}
			}
			return new ObjectResult(results); 
		}
		
		[HttpGet]
		[Route("update_from_tmdb_by_top_rated")]
		public IActionResult UpdateFromTmdbByTopRated(int pages)
		{
			var results = new List<MovieUpdated>();
			var topRatedMoviesOnDb = movieBL.GetTopRated();
			topRatedMoviesOnDb.ForEach(movie =>
			{
				movie.TopRated = false;
				movieBL.Update(movie);
			});

			for (int i = 1; i <= pages; i++)
			{
				var result = movieBL.UpdateFromTmdbByTopRated(i.ToString());
				foreach (var item in result)
				{
					results.Add(item);
				}
			}
			return new ObjectResult(results); 
		}

		[HttpGet]
		[Route("update_from_tmdb_by_genre")]
		public IActionResult UpdateFromTmdbByGenre(string genre, int pages, bool adult)
		{
			var results = new List<MovieUpdated>();
			for (int i = 1; i < pages; i++)
			{
				var result = movieBL.UpdateFromTmdbByGenre(genre, i.ToString(), adult);
				foreach (var item in result)
				{
					results.Add(item);
				}
			}
			return new ObjectResult(results);
		}
		
		[HttpGet]
		[Route("sync_last_added_from_tmdb")]
		public IActionResult SyncLastAddedFromTmdb(int pages)
		{	
			var results = new List<MovieUpdated>();
			for (int i = 1; i < pages; i++)
			{
				var result = movieBL.SyncLastAddedFromTmdb(i.ToString());
				foreach (var item in result)
				{
					results.Add(item);
				}
			}
			return new ObjectResult(results);
		}
	}
}