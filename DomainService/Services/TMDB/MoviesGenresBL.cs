using DomainService.Contracts.TMDB;
using DomainService.Services.BaseBL;
using Entities.TMDB.Movies;
using Repositories.TMDBRepo;
using Repository.Contracts.TMDB;

namespace DomainService.Services.TMDB
{
	public class MoviesGenresBL : BaseBL<MoviesGenres>, IMoviesGenresBL
	{
		private IMoviesGenresDA moviesGenresDA => (IMoviesGenresDA)DataAccess;

		public MoviesGenresBL(IMoviesGenresDA iMoviesGenresDA)
			: base((Repositories.BaseDA.IBaseDA<MoviesGenres>)iMoviesGenresDA)
		{
		}

		public List<MoviesGenres> Save(long movieId, List<MoviesGenres> moviesGenres)
		{
			List<MoviesGenres> moviesGenresOnDb = moviesGenresDA.GetAllByMovieId(movieId);
			List<MoviesGenres> moviesGenresToSave = new();
			
			if (!moviesGenresOnDb.Any())
				moviesGenres.ForEach(x =>
				{
					x.RowState = Entities.Base.RowState.Added;
					moviesGenresToSave.Add(x);
				});
			else
			{
				moviesGenresOnDb
					.Where(mg => !moviesGenres.Exists(x => x.GenreID == mg.GenreID))
					.ToList()
					.ForEach(e =>
					{
						e.RowState = Entities.Base.RowState.Deleted;
						moviesGenresToSave.Add(e);
					});

				moviesGenresOnDb
					.Where(mg => moviesGenres.Exists(x => x.GenreID == mg.GenreID))
					.ToList()
					.ForEach(e =>
					{
						e.RowState = Entities.Base.RowState.Unchanged;
						moviesGenresToSave.Add(e);
					});

				moviesGenres
					.Where(mg => !moviesGenresOnDb.Exists(x => x.GenreID == mg.GenreID))
					.ToList()
					.ForEach(e =>
					{
						e.RowState = Entities.Base.RowState.Added;
						moviesGenresToSave.Add(e);
					});
			}

			return base.Save(moviesGenresToSave);
		}
	}
}