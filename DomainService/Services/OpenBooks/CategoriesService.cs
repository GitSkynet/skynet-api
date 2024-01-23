using AutoMapper;
using DomainService.Contracts;
using DomainService.Contracts.OpenBooks;
using DtoService.OpenBoooks;
using Entities.OpenBooks;
using Repository.Contracts.OpenBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Services.OpenBooks
{
    public class CategoriesService : ICategoriesContract
	{
		private readonly ICategoriesAssociationRepo categoriesRepo;
		IMapper mapper;

		public CategoriesService(ICategoriesAssociationRepo repository, IMapper mapper)
		{
			categoriesRepo = repository;
			this.mapper = mapper;
		}

		public async Task<List<CategoriesDTO>> getAllCategories()
		{
			List<Category> categories = await categoriesRepo.GetCategories();
			var categoriesDTO = mapper.Map<List<CategoriesDTO>>(categories);
			return categoriesDTO;
		}
		
		public async Task<List<CategoriesDTO>> GetCategoryById(long categoryID)
		{
			List<Category> categories = await categoriesRepo.GetById(categoryID);
			var categoriesDTO = mapper.Map<List<CategoriesDTO>>(categories);
			return categoriesDTO;
		}


		public async Task<List<CategoriesDTO>> getBestCategories()
		{
			List<Category> categories = await categoriesRepo.getBestCategories();
			var categoriesDTO = mapper.Map<List<CategoriesDTO>>(categories);
			return categoriesDTO;
		}

		public async Task<List<CategoriesDTO>> getFeaturedCategories()
		{
			List<Category> categories = await categoriesRepo.getFeaturedCategories();
			var categoriesDTO = mapper.Map<List<CategoriesDTO>>(categories);
			return categoriesDTO;
		}
	}
}
