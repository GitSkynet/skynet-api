using Entities.TMDB.Movies;

namespace DomainService.Contracts.TMDB
{
	public interface IProductionCompaniesBL
	{
		List<ProductionCompany> GetAll();

		ProductionCompany GetById(long Id);

		ProductionCompany GetByIdTMDB(long id);

		ProductionCompany Update(ProductionCompany productionCompany);

		ProductionCompany Create(ProductionCompany productionCompany);

		ProductionCompany Delete(long Id);

		bool AlreadyExistsByIdTMDB(long id);

		void SaveAssociatedCompanies(long movieId, List<ProductionCompany> companies);
	}
}
