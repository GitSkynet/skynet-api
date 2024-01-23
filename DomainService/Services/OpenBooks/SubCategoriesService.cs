using AutoMapper;
using DomainService.Contracts.OpenBooks;
using DtoService.OpenBoooks;
using Entities.OpenBooks;
using Repository.Contracts.OpenBooks;

namespace DomainService.Services.OpenBooks
{
    public class SubCategoriesService : ISubCategoriesContract
	{
		private readonly ISubCategoriesAssociationRepo subCategoriesRepo;
		IMapper mapper;

		public SubCategoriesService(ISubCategoriesAssociationRepo repository, IMapper mapper)
		{
			subCategoriesRepo = repository;
			this.mapper = mapper;
		}

		public async Task<List<SubCategoriesDTO>> GetAllSubCategories()
		{
			List<SubCategory> subCategories = await subCategoriesRepo.GetAllSubCategories();
			var subCategoriesDTO = mapper.Map<List<SubCategoriesDTO>>(subCategories);
			return subCategoriesDTO;
		}
	}
}
