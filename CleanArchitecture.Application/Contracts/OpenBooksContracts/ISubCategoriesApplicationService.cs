using DtoService.OpenBoooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.OpenBooksContracts
{
	public interface ISubCategoriesApplicationService
	{
		Task<List<SubCategoriesDTO>> GetAllSubCategories();
	}
}
