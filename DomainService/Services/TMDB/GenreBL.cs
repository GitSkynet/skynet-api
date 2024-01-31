using AutoMapper;
using DataAccess.RESTServices.TheMovieDB.Interfaces;
using DomainService.Contracts.TMDB;
using DomainService.Services.BaseBL;
using Entities.Base;
using Entities.TMDB.Movies;
using Repository.Contracts.TMDB;

namespace DomainService.Services.TMDB
{
	public class GenreBL : BaseBL<Genre>, IGenreBL
	{
		private readonly IQueryServiceTMDB queryService;
		private readonly IMoviesGenresBL moviesGenresBL;
		private IGenreDA genreDA => (IGenreDA)DataAccess;
		private readonly IMapper mapper;

		public GenreBL(IQueryServiceTMDB iQqueryService, IGenreDA iGenreDA, IMapper mapper, IMoviesGenresBL iMoviesGenresBL)
			: base((Repositories.BaseDA.IBaseDA<Genre>)iGenreDA)
		{
			this.mapper = mapper;
			queryService = iQqueryService;
			moviesGenresBL = iMoviesGenresBL;
		}

        public Genre GetByIdTMDB(long id) => genreDA.GetByIdTMDB(id);

        public Genre GetByName(string name) => genreDA.GetByName(name);

        public bool AlreadyExistsByName(string name) => genreDA.AlreadyExistsByName(name);

        public bool AlreadyExistsByIdTMDB(long id) => genreDA.AlreadyExistsByIdTMDB(id);

        public Genre Update(Genre genreToAdd)
		{
			if (!genreDA.AlreadyExistsById(genreToAdd.Id))
				throw new Exception("No existe el género en base de datos");

			Genre genreOnDb = base.GetById(genreToAdd.IdTMDB);
			genreOnDb.Name = genreToAdd.Name;
			genreOnDb.RowState = RowState.Modified;
			return base.Save(genreOnDb);
		}

		public Genre Create(Genre genreToAdd)
		{
			Genre genreAdded = new();

			if (!genreDA.AlreadyExistsByName(genreToAdd.Name))
			{
				genreToAdd.RowState = RowState.Added;
				return base.Save(genreToAdd);
			}
			else
				genreAdded.Name = "Ya existe un género con ese nombre";

			return genreAdded;
		}

		public Genre Delete(long genreId)
		{
			bool hasMovies = genreDA.HasMoviesAssociated(genreId);
			if (hasMovies)
				throw new Exception("El género no se puede eliminar porque hay películas asociadas con el mismo");
			else
			{
				var genreToDelete = base.GetById(genreId);
				genreToDelete.RowState = RowState.Deleted;
				return base.Save(genreToDelete);
			}
		}

		public void SaveAssociatedGenres(long movieId, List<Genre> genres)
		{
			if (genres == null)
				genres = new();

			List<MoviesGenres> moviesGenres = new();
			if (genres != null)
			{
				for (int i = 0; i <= genres.Count() - 1; i++)
				{
					if (genreDA.AlreadyExistsByName(genres[i].Name))
					{
						Genre genreOnDb = genreDA.GetByName(genres[i].Name);
						genres[i].Id = genreOnDb.Id;
					}
					else
					{
						var genreToCreate = new Genre()
						{
							IdTMDB = genres[i].Id,
							Name = genres[i].Name,
						};
						var genreAdded = Create(genreToCreate);
						genres[i].Id = genreAdded.Id;
					}
				}
			}

			foreach (Genre genre in genres)
			{
				MoviesGenres movieGenre = new()
				{
					MovieID = movieId,
					GenreID = genre.Id
				};

				moviesGenres.Add(movieGenre);
			}
			moviesGenresBL.Save(movieId, moviesGenres);
		}

		public async Task<List<Genre>> UpdateGenresFromTmdb()
		{
			var genresOnTmdb = await queryService.GetGenres();
			List<Genre> genresToSave = new();
			for (int i = 0; i <= genresOnTmdb.Count() - 1; i++)
			{
				try
				{
					var genre = genresOnTmdb[i];
					if (!genreDA.AlreadyExistsByName(genre.Name))
					{
						genre.RowState = RowState.Added;
						genresToSave.Add(genre);
					}
				}
				catch (Exception ex)
				{
					throw new Exception($"Error: {ex}");
				}
			}
			return base.Save(genresToSave);
		}
	}
}
