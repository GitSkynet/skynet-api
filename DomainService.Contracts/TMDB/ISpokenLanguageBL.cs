using DomainService.Contracts.BaseContracts;
using Entities.TMDB.Movies;

namespace DomainService.Contracts.TMDB
{
	public interface ISpokenLanguageBL
	{
		List<SpokenLanguage> GetAll();

		bool AlreadyExistsByIso(string iso);

		SpokenLanguage GetById(long Id);

		SpokenLanguage Update(SpokenLanguage spokenLanguage);

		SpokenLanguage Create(SpokenLanguage spokenLanguage);

		SpokenLanguage Delete(long Id);

		Task<List<SpokenLanguage>> UpdateLanguagesFromTmdb();

		SpokenLanguage GetByIso6391(string iso);

		void SaveAssociatedLanguages(long movieId, List<SpokenLanguage> languages);
	}
}
