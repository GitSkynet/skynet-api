using DataContext.DbContexts.OpenBooksDbContext;
using Entities.OpenBooks;
using Microsoft.EntityFrameworkCore;
using Repositories.BaseDA;
using Repository.Contracts.OpenBooks;
using System.Data;

namespace Repositories.OpenBooksRepo
{
	public class CategoriesAssociationRepo : BaseDA<Category>, ICategoriesAssociationRepo
	{
		private readonly OpenBooksDbContext dbContext;

		public CategoriesAssociationRepo(OpenBooksDbContext context) : base(context)
		{
			dbContext = context;
		}

		public async Task<List<Category>> GetCategories()
		{
			try
			{ 
				var categories = AsQueryable()
					.Include(c => c.Subcategories)
					.AndClean(c => c.Subcategories, "Subcategories")
					.ToList();

				return await Task.FromResult(categories);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		
		public async Task<List<Category>> GetById(long categoryID)
		{
			try
			{
				var categories = AsQueryable()
					.Where(c => c.Id == categoryID)
					.Include(c => c.Subcategories)
					.ToList();

				return await Task.FromResult(categories);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public async Task<List<Category>> getBestCategories()
		{
			try
			{
				var categories = AsQueryable()
					.Include(c => c.Subcategories)
					.OrderBy(r => Guid.NewGuid())
					.Take(5)
					.ToList();

				return await Task.FromResult(categories);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public async Task<List<Category>> getFeaturedCategories()
		{
			try
			{
				var categories = AsQueryable()
					.OrderBy(r => Guid.NewGuid())
					.Take(8)
					.ToList();

				return await Task.FromResult(categories);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}