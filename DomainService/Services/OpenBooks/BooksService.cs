using AutoMapper;
using DomainService.Contracts;
using DtoService.OpenBoooks;
using Entities.OpenBooks;
using Repository.Contracts.OpenBooks;

namespace DomainService.Services.OpenBooks
{
    public class BooksService : IBooksContract
    {
        private readonly IBooksAssociationRepo openBooksRepo;
        IMapper mapper;
        public BooksService(IBooksAssociationRepo repository, IMapper mapper)
        {
            openBooksRepo = repository;
            this.mapper = mapper;
        }

        public async Task<List<BooksDTO>> GetBookByID(int bookID)
        {
            List<Book> books = await openBooksRepo.GetBookByID(bookID);
            var bookMapped = mapper.Map<List<BooksDTO>>(books);
            return bookMapped;
        }

        public async Task<List<BooksDTO>> getBestBooks()
        {
            List<Book> books = await openBooksRepo.getBestBooks();
            var booksDTO = mapper.Map<List<BooksDTO>>(books);
            return booksDTO;
        }

        public async Task<List<BooksDTO>> getLastAdded()
        {
            List<Book> books = await openBooksRepo.getLastAdded();
            var booksDTO = mapper.Map<List<BooksDTO>>(books);
            return booksDTO;
        }

        public async Task<List<BooksDTO>> getMostDownloaded()
        {
            List<Book> books = await openBooksRepo.getMostDownloaded();
            var booksDTO = mapper.Map<List<BooksDTO>>(books);
            return booksDTO;
        }

        public async Task<List<BooksDTO>> getRecommendedBooks()
        {
            List<Book> books = await openBooksRepo.getRecommendedBooks();
            var booksDTO = mapper.Map<List<BooksDTO>>(books);
            return booksDTO;
        }

        public async Task<List<BooksDTO>> getSelectedBooks()
        {
            List<Book> books = await openBooksRepo.getSelectedBooks();
            var booksDTO = mapper.Map<List<BooksDTO>>(books);
            return booksDTO;
        }

        public async Task<List<BooksDTO>> GetAllBooksByCategoryID(int categoryID, int limit, int page)
        {
            List<Book> books = await openBooksRepo.GetBooksByCategoryID(categoryID, limit, page);
            var booksMapped = mapper.Map<List<BooksDTO>>(books);
            return booksMapped;
        }

        public async Task<List<BooksDTO>> GetAllBooksBySubCategoryID(int subcategoryID, int limit, int page)
        {
            List<Book> books = await openBooksRepo.GetBooksBySubCategoryID(subcategoryID, limit, page);
            var booksMapped = mapper.Map<List<BooksDTO>>(books);
            return booksMapped;
        }
        
        public async Task<List<BooksDTO>> GetBooksByPublisher(string publisher, int limit, int page)
        {
            List<Book> books = await openBooksRepo.GetBooksByPublisher(publisher, limit, page);
            var booksMapped = mapper.Map<List<BooksDTO>>(books);
            return booksMapped;
        }

        public async Task<List<BooksDTO>> GetBooksByPublisherDate(int publisherDate, int limit, int page)
        {
            List<Book> books = await openBooksRepo.GetBooksByPublisherDate(publisherDate, limit, page);
            var booksMapped = mapper.Map<List<BooksDTO>>(books);
            return booksMapped;
        }
    }
}
