using AutoMapper;
using CleanArchitecture.Application.Contracts.OpenBooksContracts;
using DomainService.Contracts.OpenBooks;
using DtoService.OpenBoooks;

namespace CleanArchitecture.Application.Services.OpenBooks
{
	public class SubCategoriesApplicationService : ISubCategoriesApplicationService
	{
		private readonly ISubCategoriesContract subCategoriesContract;
		IMapper mapper;

		public SubCategoriesApplicationService(ISubCategoriesContract subCategoriesAssociationContract, IMapper mapper)
		{
			subCategoriesContract = subCategoriesAssociationContract;
			this.mapper = mapper;
		}

		public async Task<List<SubCategoriesDTO>> GetAllSubCategories()
		{
			List<SubCategoriesDTO> listAllSubCategories = await subCategoriesContract.GetAllSubCategories();
			return listAllSubCategories;
		}
	}
}
