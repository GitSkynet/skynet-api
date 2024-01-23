using DataContext.DbContexts.OpenBooksDbContext;
using Entities.OpenBooks;
using Microsoft.EntityFrameworkCore;
using Repositories.BaseDA;
using Repository.Contracts.OpenBooks;
using System.Data;
using System.Net;

namespace Repositories.OpenBooksRepo
{
    public class BooksAssociationRepo : BaseDA<Book>, IBooksAssociationRepo
    {
        private readonly OpenBooksDbContext dbContext;

        public BooksAssociationRepo(OpenBooksDbContext context) : base(context)
        {
		}

        public async Task<List<Book>> GetBookByID(int bookID)
        {
            List<Book> books = new();
            List<Author> authors = new();
            try
            {
                var book = AsQueryable()
                    .Where(b => b.Id == bookID)
                    .Include(b => b.Categories)
                    .Include(b => b.SubCategories)
					.Include(b => b.AuthorsBooks)
						.ThenInclude(ab => ab.Authors)
					.AndClean(x => x.AuthorsBooks, "Authors")
					.FirstOrDefault();

				books.Add(book);

				return await Task.FromResult(books);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Book>> GetBooksByCategoryID(int categoryID, int limit, int page)
        {
            try
            {
				var books = AsQueryable()
                    .Where(x => x.CategoryId == categoryID)
					.Include(b => b.Categories)
					.Include(b => b.SubCategories)
					.Include(b => b.AuthorsBooks)
						.ThenInclude(ab => ab.Authors)
					.AndClean(x => x.AuthorsBooks, "Authors")
                    .Skip(page)
                    .Take(limit)
                    .ToList();

				return await Task.FromResult(books);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Book>> getBestBooks()
        {
            try
            {
                var books = AsQueryable()
                    .OrderBy(p => Guid.NewGuid())
                    .Take(10)
                    .ToList();

                return await Task.FromResult(books);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Book>> getLastAdded()
        {
            try
            {
                var books = AsQueryable()
                    .OrderByDescending(b => b.createdAt)
                    .Take(12)
                    .ToList();

                return await Task.FromResult(books);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Book>> getMostDownloaded()
        {
            try
            {
                var bookList = AsQueryable()
                    .Where(x => x.CategoryId == 220)
                    .OrderBy(p => Guid.NewGuid())
                    .Take(20)
                    .ToList();

                return await Task.FromResult(bookList);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Book>> getRecommendedBooks()
        {
            try
            {
                var bookList = AsQueryable()
                    .Where(x => x.SubCategoryId == 305)
                    .OrderBy(p => Guid.NewGuid())
                    .Take(10)
                    .ToList();

                return await Task.FromResult(bookList);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Book>> getSelectedBooks()
        {
            try
            {
                var bookList = AsQueryable()
                    .Where(x => x.SubCategoryId == 855)
                    .OrderByDescending(p => Guid.NewGuid())
                    .Take(3)
                    .ToList();

                return await Task.FromResult(bookList);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Book>> GetBooksBySubCategoryID(int subcategory, int limit, int page)
        {
            try
            {
                var books = AsQueryable()
                    .Where(x => x.SubCategoryId == subcategory)
					.Include(b => b.Categories)
					.Include(b => b.SubCategories)
					.Include(b => b.AuthorsBooks)
						.ThenInclude(ab => ab.Authors)
					.AndClean(x => x.AuthorsBooks, "Authors")
					.Skip(page)
                    .Take(limit)
                    .ToList();
                return await Task.FromResult(books);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Book>> GetBooksByPublisher(string publisher, int limit, int page)
        {
            try
            {
                var books = AsQueryable()
                    .Where(x => x.Publisher == publisher)
					.Include(b => b.Categories)
					.Include(b => b.SubCategories)
					.Include(b => b.AuthorsBooks)
						.ThenInclude(ab => ab.Authors)
					.AndClean(x => x.AuthorsBooks, "Authors")
                    .Take(limit)
                    //.Skip(page)
                    .ToList();

                return await Task.FromResult(books);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Book>> GetBooksByPublisherDate(int publisherDate, int limit, int page)
        {
            try
            {
                var books = AsQueryable()
                    .Where(b => b.PublisherDate == publisherDate.ToString())
					.Include(b => b.Categories)
					.Include(b => b.SubCategories)
					.Include(b => b.AuthorsBooks)
						.ThenInclude(ab => ab.Authors)
					.AndClean(x => x.AuthorsBooks, "Authors")
					.Take(limit)
					//.Skip(page)
					.ToList();
                return await Task.FromResult(books);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
