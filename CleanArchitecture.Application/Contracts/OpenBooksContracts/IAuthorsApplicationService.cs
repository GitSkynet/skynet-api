using CleanArchitecture.Application.Contracts.OpenBooksContracts;
using Entities.OpenBooks;

namespace CleanArchitecture.Application.Contracts.OpenBooksContracts
{
	public interface IAuthorsApplicationService
	{
		Task<List<Author>> GetAuthorByID(int id);

	}
}