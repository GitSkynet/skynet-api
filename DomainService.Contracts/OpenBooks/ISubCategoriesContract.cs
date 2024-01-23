using DtoService.OpenBoooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Contracts.OpenBooks
{
	public interface ISubCategoriesContract
	{
		Task<List<SubCategoriesDTO>> GetAllSubCategories();
	}
}
