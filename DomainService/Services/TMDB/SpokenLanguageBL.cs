using AutoMapper;
using DataAccess.RESTServices.TheMovieDB.Interfaces;
using DomainService.Contracts.TMDB;
using DomainService.Services.BaseBL;
using Entities.Base;
using Entities.TMDB.Movies;
using Repositories.TMDBRepo;
using Repository.Contracts.TMDB;

namespace DomainService.Services.TMDB
{
	public class SpokenLanguageBL : BaseBL<SpokenLanguage>, ISpokenLanguageBL
	{
		private readonly IQueryServiceTMDB queryService;
		private readonly IMovieSpokenLanguagesBL movieSpokenLanguagesBL;
		private ISpokenLanguageDA splangDA => (ISpokenLanguageDA)DataAccess;
		private readonly IMapper mapper;

		public SpokenLanguageBL(IQueryServiceTMDB iQueryService, ISpokenLanguageDA iSplangDA, IMapper mapper, 
			IMovieSpokenLanguagesBL iMovieSpokenLanguagesBL)
			: base((Repositories.BaseDA.IBaseDA<SpokenLanguage>)iSplangDA)
		{
			this.mapper = mapper;
			queryService = iQueryService;
			movieSpokenLanguagesBL = iMovieSpokenLanguagesBL;
		}

		public bool AlreadyExistsByIso(string iso) => splangDA.AlreadyExistsByIso(iso);
		public SpokenLanguage GetByIso6391(string iso) => splangDA.GetByIso6391(iso);

		public SpokenLanguage Update(SpokenLanguage spokenLanguage)
		{
			if (!splangDA.AlreadyExistsById(spokenLanguage.Id))
				throw new Exception("No existe el Idioma especificado en base de datos");

			SpokenLanguage spkLangOnDb = base.GetById(spokenLanguage.Id);
			spkLangOnDb.Name = spokenLanguage.Name;
			spkLangOnDb.Iso6391 = spokenLanguage.Iso6391;
			spkLangOnDb.IdTMDB = spokenLanguage.IdTMDB;
			spkLangOnDb.EnglishName = spokenLanguage.EnglishName;
			spkLangOnDb.RowState = RowState.Modified;
			return base.Save(spkLangOnDb);
		}

		public SpokenLanguage Create(SpokenLanguage spokenLanguage)
		{
			SpokenLanguage spkLangAdded = new();

			if (!splangDA.AlreadyExistsByName(spokenLanguage.Name))
			{
				spokenLanguage.RowState = RowState.Added;
				spkLangAdded = base.Save(spokenLanguage);
			}
			else
				throw new Exception("Ya existe un Spoken Language con ese nombre");
			return spkLangAdded;
		}

		public SpokenLanguage Delete(long Id)
		{
			bool hasMovies = splangDA.HasMoviesAssociated(Id);
			if (!hasMovies)
			{
				var spokenLanguage = base.GetById(Id);
				spokenLanguage.RowState = RowState.Deleted;
				return base.Save(spokenLanguage);
			}
			else
				throw new Exception("El Idioma tiene películas asociadas y no se puede eliminar");
		}

		public void SaveAssociatedLanguages(long movieId, List<SpokenLanguage> languages)
		{
			if (languages == null)
				languages = new();

			List<MovieSpokenLanguage> associatedLanguages = new();
			if (languages != null)
			{
				for (int i = 0; i <= languages.Count() - 1; i++)
				{
					SpokenLanguage spkLang = languages[i];
					if (AlreadyExistsByIso(spkLang.Iso6391))
					{
						SpokenLanguage spkLangOnDb = GetByIso6391(spkLang.Iso6391);
						languages[i].Id = spkLangOnDb.Id;
					}
					else
					{
						var spkLangToCreate = new SpokenLanguage()
						{
							Iso6391 = spkLang.Iso6391,
							Name = spkLang.Name,
							EnglishName = spkLang.EnglishName,
							IdTMDB = spkLang.IdTMDB
						};
						var languageAdded = Create(spkLangToCreate);
						languages[i].Id = languageAdded.Id;
					}
				}
			}

			foreach (var langAssociated in languages)
			{
				MovieSpokenLanguage movieLanguage = new()
				{
					MovieID = movieId,
					SpokenLanguageID = langAssociated.Id
				};
				associatedLanguages.Add(movieLanguage);
			}
			movieSpokenLanguagesBL.Save(movieId, associatedLanguages);
		}

		public async Task<List<SpokenLanguage>> UpdateLanguagesFromTmdb()
		{
			var languagesOnTmdb = await queryService.GetSpokenLanguages();
			List<SpokenLanguage> languagesToSave = new();
			for (int i = 0; i <= languagesOnTmdb.Count() - 1; i++)
			{
				try
				{
					var languageToSave = languagesOnTmdb[i];
					if (!splangDA.AlreadyExistsByName(languageToSave.EnglishName)) 
					{
						languageToSave.RowState = RowState.Added;
						languagesToSave.Add(languageToSave);
					}
				}
				catch (Exception ex)
				{
					throw new Exception($"Error: {ex}");
				}
			}
			return base.Save(languagesToSave);
		}
	}
}
