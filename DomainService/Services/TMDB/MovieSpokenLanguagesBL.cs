using AutoMapper;
using DomainService.Contracts.TMDB;
using DomainService.Services.BaseBL;
using Entities.TMDB.Movies;
using Repositories.TMDBRepo;
using Repository.Contracts.TMDB;

namespace DomainService.Services.TMDB
{
	public class MovieSpokenLanguagesBL : BaseBL<MovieSpokenLanguage>, IMovieSpokenLanguagesBL
	{
		private IMovieSpokenLanguagesDA movieSpokenLangsDA => (IMovieSpokenLanguagesDA)DataAccess;

		public MovieSpokenLanguagesBL(IMovieSpokenLanguagesDA iMovieSpokenLangsDA) 
			: base((Repositories.BaseDA.IBaseDA<MovieSpokenLanguage>)iMovieSpokenLangsDA)
		{
		}

		public List<MovieSpokenLanguage> Save(long movieId, List<MovieSpokenLanguage> movieSpokenLanguages)
		{
			List<MovieSpokenLanguage> movieSpokenLanguagesOnDb = movieSpokenLangsDA.GetAllByMovieId(movieId);
			List<MovieSpokenLanguage> movieSpokenLanguagesToSave = new();

			if (!movieSpokenLanguagesOnDb.Any())
				movieSpokenLanguages.ForEach(x =>
				{
					x.RowState = Entities.Base.RowState.Added;
					movieSpokenLanguagesToSave.Add(x);
				});
			else
			{
				movieSpokenLanguagesOnDb
					.Where(pc => !movieSpokenLanguages.Exists(x => x.SpokenLanguageID == pc.SpokenLanguageID))
					.ToList()
					.ForEach(e =>
					{
						e.RowState = Entities.Base.RowState.Deleted;
						movieSpokenLanguagesToSave.Add(e);
					});

				movieSpokenLanguagesOnDb
					.Where(pc => movieSpokenLanguages.Exists(x => x.SpokenLanguageID == pc.SpokenLanguageID))
					.ToList()
					.ForEach(e =>
					{
						e.RowState = Entities.Base.RowState.Unchanged;
						movieSpokenLanguagesToSave.Add(e);
					});

				movieSpokenLanguages
					.Where(pc => !movieSpokenLanguagesOnDb.Exists(x => x.SpokenLanguageID == pc.SpokenLanguageID))
					.ToList()
					.ForEach(e =>
					{
						e.RowState = Entities.Base.RowState.Added;
						movieSpokenLanguagesToSave.Add(e);
					});
			}

			return base.Save(movieSpokenLanguagesToSave);
		}
	}
}
