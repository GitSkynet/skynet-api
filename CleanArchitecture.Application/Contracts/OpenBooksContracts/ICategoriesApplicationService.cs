using DtoService.OpenBoooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.OpenBooksContracts
{
	public interface ICategoriesApplicationService
	{
		Task<List<CategoriesDTO>> GetCategoryById(long categoryID);
		Task<List<CategoriesDTO>> getAllCategories();
		Task<List<CategoriesDTO>> getBestCategories();
		Task<List<CategoriesDTO>> getFeaturedCategories();
	}
}
