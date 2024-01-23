using AutoMapper;
using CleanArchitecture.Application.Contracts.OpenBooksContracts;
using DomainService.Contracts;
using DomainService.Contracts.OpenBooks;
using DtoService.OpenBoooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services.OpenBooks
{
	public class CategoriesApplicationService : ICategoriesApplicationService
	{
		private readonly ICategoriesContract categoriesContract;
		IMapper mapper;

		public CategoriesApplicationService(ICategoriesContract categoriesAssociationContract, IMapper mapper)
		{
			categoriesContract = categoriesAssociationContract;
			this.mapper = mapper;
		}

		public async Task<List<CategoriesDTO>> getAllCategories()
		{
			return await categoriesContract.getAllCategories();
		}
		
		public async Task<List<CategoriesDTO>> GetCategoryById(long categoryID)
		{
			return await categoriesContract.GetCategoryById(categoryID);
		}

		public async Task<List<CategoriesDTO>> getBestCategories()
		{
			List<CategoriesDTO> listAllCategories = await categoriesContract.getBestCategories();
			return listAllCategories;
		}

		public async Task<List<CategoriesDTO>> getFeaturedCategories()
		{
			List<CategoriesDTO> listCategories = await categoriesContract.getFeaturedCategories();
			return listCategories;
		}
	}
}
