using AutoMapper;
using CleanArchitecture.Application.Contracts.OpenBooksContracts;
using DomainService.Contracts;
using DtoService.OpenBoooks;
using Entities.OpenBooks;

namespace CleanArchitecture.Application.Services.OpenBooks
{
    public class BooksApplicationService : IBooksApplicationService
    {
        private readonly IBooksContract booksAssociationContract;
        IMapper mapper;

        public BooksApplicationService(IBooksContract associationContract, IMapper mapper)
        {
            booksAssociationContract = associationContract;
            this.mapper = mapper;
        }

        public async Task<List<BooksDTO>> GetBookByID(int bookID)
        {
            List<BooksDTO> listBookDTO = await booksAssociationContract.GetBookByID(bookID);
            return listBookDTO;
        }

        public async Task<List<BooksDTO>> getBestBooks()
        {
            List<BooksDTO> listBestBooks = await booksAssociationContract.getBestBooks();
            return listBestBooks;
        }

        public async Task<List<BooksDTO>> getLastAdded()
        {
            List<BooksDTO> listLastAdded = await booksAssociationContract.getLastAdded();
            return listLastAdded;
        }

        public async Task<List<BooksDTO>> getMostDownloaded()
        {
            List<BooksDTO> listMostDownloaded = await booksAssociationContract.getMostDownloaded();
            return listMostDownloaded;
        }

        public async Task<List<BooksDTO>> getRecommendedBooks()
        {
            List<BooksDTO> listRecommendedBooks = await booksAssociationContract.getRecommendedBooks();
            return listRecommendedBooks;
        }

        public async Task<List<BooksDTO>> getSelectedBooks()
        {
            List<BooksDTO> listSelectedBooks = await booksAssociationContract.getSelectedBooks();
            return listSelectedBooks;
        }

        public async Task<List<BooksDTO>> GetAllBooksByCategoryID(int catgegory, int limit, int page)
        {
            List<BooksDTO> listBooksByCategory = await booksAssociationContract.GetAllBooksByCategoryID(catgegory, limit, page);
            return listBooksByCategory;
        }

        public async Task<List<BooksDTO>> GetAllBooksBySubCategoryID(int catgegory, int limit, int page)
        {
            List<BooksDTO> listBooksBySubCategory = await booksAssociationContract.GetAllBooksBySubCategoryID(catgegory, limit, page);
            return listBooksBySubCategory;
        }

        public async Task<List<BooksDTO>> GetBooksByPublisher(string publisher, int limit, int page)
        {
            List<BooksDTO> listBooksByPublisher = await booksAssociationContract.GetBooksByPublisher(publisher, limit, page);
            return listBooksByPublisher;
        }

        public async Task<List<BooksDTO>> GetBooksByPublisherDate(int publisherDate, int limit, int page)
        {
            List<BooksDTO> listBooksByPublisherDate = await booksAssociationContract.GetBooksByPublisherDate(publisherDate, limit, page);
            return listBooksByPublisherDate;
        }
    }
}
