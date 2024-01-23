using DataContext.DbContexts.OpenBooksDbContext;
using Entities.OpenBooks;
using Microsoft.EntityFrameworkCore;
using Repositories.BaseDA;
using Repository.Contracts.OpenBooks;

namespace Repositories.OpenBooksRepo
{
	public class AuthorsAssociationRepo : BaseDA<Author>, IAuthorsAssociationRepo
	{
		private readonly OpenBooksDbContext dbContext;

		public AuthorsAssociationRepo(OpenBooksDbContext context) : base(context)
		{
			dbContext = context;
		}

		public async Task<List<Author>> GetAuthorByID(int id)
		{
			List<Author> authors = new();
			List<Book> books = new();
			try
			{
				authors = AsQueryable()
					.Where(x => x.Id == id)
					.Include(x => x.AuthorsBooks)
						.ThenInclude(a => a.Books)
					.AndClean(x => x.AuthorsBooks, "Books")
					.ToList();

				return await Task.FromResult(authors);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
