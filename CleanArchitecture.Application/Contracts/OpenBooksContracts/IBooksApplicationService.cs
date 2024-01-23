using DtoService.OpenBoooks;
using Entities.OpenBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.OpenBooksContracts
{
    public interface IBooksApplicationService
    {
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
