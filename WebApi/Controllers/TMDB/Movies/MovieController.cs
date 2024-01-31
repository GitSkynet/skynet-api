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