using Entities.OpenBooks;

namespace DomainService.Contracts.OpenBooks
{
	public interface IAuthorsContract
	{
		Task<List<Author>> GetAuthorByID(int id);
	}
}
