using Entities.OpenBooks;

namespace Repository.Contracts.OpenBooks
{
    public interface IBooksAssociationRepo
    {
        Task<List<Book>> GetBookByID(int bookID);

        Task<List<Book>> getBestBooks();

        Task<List<Book>> getSelectedBooks();

        Task<List<Book>> getLastAdded();

        Task<List<Book>> getMostDownloaded();

        Task<List<Book>> getRecommendedBooks();

        Task<List<Book>> GetBooksByCategoryID(int categoryID, int limit, int page);

        Task<List<Book>> GetBooksBySubCategoryID(int subCategoryID, int limit, int page);

        Task<List<Book>> GetBooksByPublisher(string publisher, int limit, int page);

        Task<List<Book>> GetBooksByPublisherDate(int publisherDate, int limit, int page);

    }
}
