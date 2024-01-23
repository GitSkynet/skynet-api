using Entities.OpenBooks;

namespace Repository.Contracts.OpenBooks
{
    public interface ICategoriesAssociationRepo
    {
        Task<List<Category>> GetCategories();

        Task<List<Category>> getBestCategories();

        Task<List<Category>> getFeaturedCategories();

        Task<List<Category>> GetById(long categoryID);

	}
}
