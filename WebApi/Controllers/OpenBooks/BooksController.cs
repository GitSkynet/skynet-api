using CleanArchitecture.Application.Contracts.OpenBooksContracts;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.OpenBooks
{
    [ApiController]
    [Route("api/openbooks/books")]
    public class BooksController : Controller
    {
        private readonly IBooksApplicationService booksAppService;

        public BooksController(IBooksApplicationService appBooksService)
        {
            booksAppService = appBooksService;
        }

        [HttpGet]
        [Route("get_by_id")]
        public async Task<IActionResult> GetBookByID(int bookID)
        {
            var response = await booksAppService.GetBookByID(bookID);
            return new ObjectResult(response);
        }

        [HttpGet]
        [Route("get_best_books")]
        public async Task<IActionResult> GetBestBooks()
        {
            var response = await booksAppService.getBestBooks();
            return new ObjectResult(response);
        }

        [HttpGet]
        [Route("get_last_added")]
        public async Task<IActionResult> GetLastAdded()
        {
            var response = await booksAppService.getLastAdded();
            return new ObjectResult(response);
        }

        [HttpGet]
        [Route("get_most_downloaded")]
        public async Task<IActionResult> GetMostDownloaded()
        {
            var response = await booksAppService.getMostDownloaded();
            return new ObjectResult(response);
        }

        [HttpGet]
        [Route("get_recommended_books")]
        public async Task<IActionResult> GetRecommendedBooks()
        {
            var response = await booksAppService.getRecommendedBooks();
            return new ObjectResult(response);
        }

        [HttpGet]
        [Route("get_selected_books")]
        public async Task<IActionResult> GetSelectedBooks()
        {
            var response = await booksAppService.getSelectedBooks();
            return new ObjectResult(response);
        }

        [HttpGet]
        [Route("get_by_category_id")]
        public async Task<IActionResult> GetAllBooksByCategoryID(int category, int limit, int page)
        {
            var response = await booksAppService.GetAllBooksByCategoryID(category, limit, page);
            return new ObjectResult(response);
        }

        [HttpGet]
        [Route("get_by_subcategory_id")]
        public async Task<IActionResult> GetAllBooksBySubCategoryID(int subcategory, int limit, int page)
        {
            var response = await booksAppService.GetAllBooksBySubCategoryID(subcategory, limit, page);
            return new ObjectResult(response);
        }

        [HttpGet]
        [Route("get_by_publisher_name")]
        public async Task<IActionResult> GetBooksByPublisher(string publisher, int limit, int page)
        {
            var response = await booksAppService.GetBooksByPublisher(publisher, limit, page);
            return new ObjectResult(response);
        }

        [HttpGet]
        [Route("get_by_publisher_date")]
        public async Task<IActionResult> GetBooksByPublisherDate(int publisherDate, int limit, int page)
        {
            var response = await booksAppService.GetBooksByPublisherDate(publisherDate, limit, page);
            return new ObjectResult(response);
        }
    }
}
