using Azure;
using DataAccess.RESTServices.TheMovieDB.Interfaces;
using DomainService.Contracts.TMDB;
using DomainService.Services.BaseBL;
using Entities.Base;
using Entities.TMDB;
using Entities.TMDB.Movies;
using Repository.Contracts.TMDB;

namespace DomainService.Services.TMDB
{
	public class MovieBL : BaseBL<Movie>, IMovieBL
	{
		private readonly IQueryServiceTMDB queryService;
		private readonly IGenreBL genreBL;
		private readonly IProductionCountriesBL countriesBL;
		private readonly ISpokenLanguageBL languageBL;	
		private readonly IProductionCompaniesBL companiesBL;
		private IMovieDA movieDA => (IMovieDA)DataAccess;

		public MovieBL(IQueryServiceTMDB iQqueryService, IMovieDA iMovieDA, IGenreBL iGenreBL, 
			IProductionCompaniesBL iCompaniesBL, IProductionCountriesBL iCountriesBL, 
			ISpokenLanguageBL iLanguageBL) : base((Repositories.BaseDA.IBaseDA<Movie>)iMovieDA)
		{
			genreBL = iGenreBL;
			queryService = iQqueryService;
			companiesBL = iCompaniesBL;
			countriesBL = iCountriesBL;
			languageBL = iLanguageBL;
		}
		
		public override Movie GetById(long movieId) => movieDA.GetById(movieId);

		public List<Movie> GetNowPlaying() => movieDA.GetNowPlaying();
		public List<Movie> GetUpcoming() => movieDA.GetUpcoming();

		public List<Movie> GetTrendingDay() => movieDA.GetTrendingDay();
		public List<Movie> GetTrendingWeek() => movieDA.GetTrendingWeek();

		public List<Movie> GetTopRated() => movieDA.GetTopRated();
			 
		public List<Movie> GetMostPopular(string language, int results) => movieDA.GetMostPopular(language, results);
		public List<Movie> GetMostRecent(string language, string status, int limit)
			=> movieDA.GetMostRecent(language, status, limit);

		public List<Movie> GetByGenre(string category, string language, int results, bool adult)
			=> movieDA.GetByGenre(category, language, results, adult);

		public Movie Update(Movie movieToAdd)
		{
			movieToAdd.RowState = RowState.Modified;
			var movieUpdated = base.Save(movieToAdd);
			SaveAssociatedEntitites(movieUpdated);
			return movieUpdated;
		}

		public Movie Create(Movie movieToAdd)
		{
			movieToAdd.RowState = RowState.Added;
			var movieSaved = base.Save(movieToAdd);
			SaveAssociatedEntitites(movieSaved);
			return movieSaved;
		}

		public Movie Delete(long movieId)
		{
			var movieToDelete = base.GetById(movieId);
			movieToDelete.RowState = RowState.Deleted;
			return base.Save(movieToDelete);
		}

		public List<MovieUpdated> UpdateFromTmdbByNowPlaying(string page)
		{
			List<Movie> moviesToSave = new();
			var movies = queryService.GetNowPlayingMovies(page).Result;

			movies.ForEach(x =>
			{
				var movieFromTmdb = queryService.GetByID(x.Id, "es").Result;
				movieFromTmdb.NowPlaying = true;
				if (movieDA.AlreadyExistsByIdTmdb(movieFromTmdb.Id))
				{
					var movie = movieDA.GetByIdTMDB(movieFromTmdb.Id);
					movieFromTmdb.Upcoming = movie.Upcoming;
					movieFromTmdb.TrendingDay = movie.TrendingDay;
					movieFromTmdb.TrendingWeek = movie.TrendingWeek;
					movieFromTmdb.TopRated = movie.TopRated;
				}
				moviesToSave.Add(movieFromTmdb);
			});

			var moviesAdded = SaveMovies(moviesToSave);
			var moviesUpdated = moviesAdded.ConvertAll(mov => new MovieUpdated()
			{
				Id = mov.Id,
				Title = mov.Title
			});
			return moviesUpdated;
		}

		public List<MovieUpdated> UpdateFromTmdbByUpcoming(string page)
		{
			List<Movie> moviesToSave = new();
			var movies = queryService.GetUpcomingMovies(page).Result;

			movies.ForEach(x =>
			{
				var movieFromTmdb = queryService.GetByID(x.Id, "es").Result;
				movieFromTmdb.Upcoming = true;
				if (movieDA.AlreadyExistsByIdTmdb(movieFromTmdb.Id))
				{
					var movie = movieDA.GetByIdTMDB(movieFromTmdb.Id);
					movieFromTmdb.NowPlaying = movie.NowPlaying;
					movieFromTmdb.TrendingDay = movie.TrendingDay;
					movieFromTmdb.TrendingWeek = movie.TrendingWeek;
					movieFromTmdb.TopRated = movie.TopRated;
				}
				moviesToSave.Add(movieFromTmdb);
			});

			var moviesAdded = SaveMovies(moviesToSave);
			var moviesUpdated = moviesAdded.ConvertAll(mov => new MovieUpdated()
			{
				Id = mov.Id,
				Title = mov.Title
			});
			return moviesUpdated;
		}

		public List<MovieUpdated> UpdateFromTmdbByMostPopular(string page)
		{
			List<Movie> moviesToSave = new();
			var movies = queryService.GetMostPopularMovies(page).Result;

			foreach (var movie in movies)
			{
				var movieFromTmdb = queryService.GetByID(movie.Id, "es").Result;
				if (movieDA.AlreadyExistsByIdTmdb(movieFromTmdb.Id))
				{
					var movieOnDb = movieDA.GetByIdTMDB(movieFromTmdb.Id);
					movieFromTmdb.NowPlaying = movieOnDb.NowPlaying;
					movieFromTmdb.Upcoming = movieOnDb.Upcoming;
					movieFromTmdb.TrendingDay = movieOnDb.TrendingDay;
					movieFromTmdb.TrendingWeek = movieOnDb.TrendingWeek;
					movieFromTmdb.TopRated = movieOnDb.TopRated;
				}
				moviesToSave.Add(movieFromTmdb);
			}
			var moviesAdded = SaveMovies(moviesToSave);
			var moviesUpdated = moviesAdded.ConvertAll(mov => new MovieUpdated()
			{
				Id = mov.Id,
				Title = mov.Title
			});
			return moviesUpdated;
		}
		
		public List<MovieUpdated> UpdateFromTmdbByTrendingDay(string page)
		{
			List<Movie> moviesToSave = new();
			var movies = queryService.GetTrendingDay(page).Result;

			movies.ForEach(x =>
			{
				var movieFromTmdb = queryService.GetByID(x.Id, "es").Result;
				movieFromTmdb.TrendingDay = true;
				if (movieDA.AlreadyExistsByIdTmdb(movieFromTmdb.Id))
				{
					var movie = movieDA.GetByIdTMDB(movieFromTmdb.Id);
					movieFromTmdb.NowPlaying = movie.NowPlaying;
					movieFromTmdb.Upcoming = movie.Upcoming;
					movieFromTmdb.TrendingWeek = movie.TrendingWeek;
					movieFromTmdb.TopRated = movie.TopRated;
				}
				moviesToSave.Add(movieFromTmdb);
			});

			var moviesAdded = SaveMovies(moviesToSave);
			var moviesUpdated = moviesAdded.ConvertAll(mov => new MovieUpdated()
			{
				Id = mov.Id,
				Title = mov.Title
			});
			return moviesUpdated;
		}
		
		public List<MovieUpdated> UpdateFromTmdbByTrendingWeek(string page)
		{
			List<Movie> moviesToSave = new();
			var movies = queryService.GetTrendingWeek(page).Result;
			movies.ForEach(x =>
			{
				var movieFromTmdb = queryService.GetByID(x.Id, "es").Result;
				movieFromTmdb.TrendingWeek = true;
				if (movieDA.AlreadyExistsByIdTmdb(movieFromTmdb.Id))
				{
					var movie = movieDA.GetByIdTMDB(movieFromTmdb.Id);
					movieFromTmdb.NowPlaying = movie.NowPlaying;
					movieFromTmdb.Upcoming = movie.Upcoming;
					movieFromTmdb.TrendingDay = movie.TrendingDay;
					movieFromTmdb.TopRated = movie.TopRated;
				}
				moviesToSave.Add(movieFromTmdb);
			});

			var moviesAdded = SaveMovies(moviesToSave);
			var moviesUpdated = moviesAdded.ConvertAll(mov => new MovieUpdated()
			{
				Id = mov.Id,
				Title = mov.Title
			});
			return moviesUpdated;
		}
		
		public List<MovieUpdated> UpdateFromTmdbByTopRated(string page)
		{
			List<Movie> moviesToSave = new();
			var movies = queryService.GetTopRated(page).Result;
			movies.ForEach(x =>
			{
				var movieFromTmdb = queryService.GetByID(x.Id, "es").Result;
				movieFromTmdb.TopRated = true;
				if (movieDA.AlreadyExistsByIdTmdb(movieFromTmdb.Id))
				{
					var movie = movieDA.GetByIdTMDB(movieFromTmdb.Id);
					movieFromTmdb.NowPlaying = movie.NowPlaying;
					movieFromTmdb.Upcoming = movie.Upcoming;
					movieFromTmdb.TrendingDay = movie.TrendingDay;
					movieFromTmdb.TrendingWeek = movie.TrendingWeek;
				}
				moviesToSave.Add(movieFromTmdb);
			});

			var moviesAdded = SaveMovies(moviesToSave);
			var moviesUpdated = moviesAdded.ConvertAll(mov => new MovieUpdated()
			{
				Id = mov.Id,
				Title = mov.Title
			});
			return moviesUpdated;
		}

		public List<MovieUpdated> UpdateFromTmdbByGenre(string genre, string page, bool adult)
		{
			List<Movie> moviesToSave = new();
			var movies = queryService.GetMoviesByGenre(genre, page, adult).Result;

			foreach (var movie in movies)
			{
				var movieFromTmdb = queryService.GetByID(movie.Id, "es").Result;
				moviesToSave.Add(movieFromTmdb);
			}
			var moviesAdded = SaveMovies(moviesToSave);
			var moviesUpdated = moviesAdded.ConvertAll(mov => new MovieUpdated()
			{
				Id = mov.Id,
				Title = mov.Title
			});
			return moviesUpdated;
		}

		public List<MovieUpdated> SyncLastAddedFromTmdb(string page)
		{
			List<Movie> movies = new();

			var moviesChanged = queryService.GetMoviesChanged(page).Result;
			foreach (var movie in moviesChanged.MoviesList!)
			{
				var movieFromTmdb = queryService.GetByID(movie.Id, "es").Result;
				if (movieFromTmdb.Id != 0)
					movies.Add(movieFromTmdb);
			}
			var moviesAdded = SaveMovies(movies);
			var moviesUpdated = moviesAdded.ConvertAll(mov => new MovieUpdated()
			{
				Id = mov.Id,
				Title = mov.Title
			});
			return moviesUpdated;
		}

		private List<Movie> SaveMovies(List<Movie> movies)
		{
			List<Movie> moviesSaved = new(); 
			foreach (var movie in movies)
			{
				movie.BackdropPath = movie.BackdropPath == null ? "" : movie.BackdropPath;
				movie.PosterPath = movie.PosterPath == null ? "" : movie.PosterPath;

				Movie movieToSave = new();
				if (!movieDA.AlreadyExistsByIdTmdb(movie.Id))
				{
					movie.IdTMDB = movie.Id;
					movie.Id = 0;
					movieToSave = Create(movie);
				}
				else
				{
					var movieOnDb = movieDA.GetByIdTMDB(movie.Id);
					movie.IdTMDB = movieOnDb.IdTMDB;
					movie.Id = movieOnDb.Id;
					movieToSave = Update(movie);
				}
				moviesSaved.Add(movieToSave);
			}
			return moviesSaved;
		}

		private void SaveAssociatedEntitites(Movie movie)
		{
			genreBL.SaveAssociatedGenres(movie.Id, movie.Genres);
			countriesBL.SaveAssociatedProdCounts(movie.Id, movie.ProductionCountries);
			languageBL.SaveAssociatedLanguages(movie.Id, movie.SpokenLanguages);
			companiesBL.SaveAssociatedCompanies(movie.Id, movie.ProductionCompanies);
		}
	}
}