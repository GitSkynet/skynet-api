using Entities.TMDB.Movies;

namespace Repository.Contracts.TMDB
{
	public interface IProductionCompaniesDA
	{

		public ProductionCompany GetByIdTMDB(long id);

		public ProductionCompany GetByName(string name);

		public bool HasMoviesAssociated(long Id);

		public bool AlreadyExistsById(long id);

		public bool AlreadyExistsByIdTMDB(long id);

		public bool AlreadyExistsByName(string name);
	}
}
