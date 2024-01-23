using DataContext.DbContexts.OpenBooksDbContext;
using Entities.OpenBooks;
using Microsoft.EntityFrameworkCore;
using Repositories.BaseDA;
using Repository.Contracts.OpenBooks;
using System.Data;

namespace Repositories.OpenBooksRepo
{
	public class SubCategoriesAssociationRepo : BaseDA<SubCategory>, ISubCategoriesAssociationRepo
	{
		private readonly OpenBooksDbContext dbContext;

		public SubCategoriesAssociationRepo(OpenBooksDbContext context) : base(context)
		{
			dbContext = context;
		}

		public async Task<List<SubCategory>> GetAllSubCategories()
		{
			try
			{
				var subCategories = AsQueryable()
					.OrderBy(x => x.Name)
					.ToList();

				return await Task.FromResult(subCategories);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}


