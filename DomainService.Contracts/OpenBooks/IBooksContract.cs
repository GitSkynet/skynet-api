using DtoService.OpenBoooks;
using Entities.OpenBooks;

namespace DomainService.Contracts
{
    public  interface IBooksContract
    {
        /// <summary>
        /// Obtiene una lista de objetos de tipo <see cref="Book"/> 
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns>Devuelve una lista de objetos de tipo <see cref="BooksDTO"/></returns>
        Task<List<BooksDTO>> GetBookByID(int bookID);

        Task<List<BooksDTO>> getBestBooks();

        Task<List<BooksDTO>> getSelectedBooks();

        Task<List<BooksDTO>> getLastAdded();

        Task<List<BooksDTO>> getMostDownloaded();

        Task<List<BooksDTO>> getRecommendedBooks();

        Task<List<BooksDTO>> GetAllBooksByCategoryID(int category, int limit, int page);

        Task<List<BooksDTO>> GetAllBooksBySubCategoryID(int category, int limit, int page);

        Task<List<BooksDTO>> GetBooksByPublisher(string publisher, int limit, int page);
        
        Task<List<BooksDTO>> GetBooksByPublisherDate(int publisherDate, int limit, int page);
    }
}
