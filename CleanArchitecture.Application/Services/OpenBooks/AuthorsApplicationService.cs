using AutoMapper;
using CleanArchitecture.Application.Contracts.OpenBooksContracts;
using DomainService.Contracts.OpenBooks;
using Entities.OpenBooks;

namespace CleanArchitecture.Application.Services.OpenBooks
{
	public class AuthorsApplicationService : IAuthorsApplicationService
	{

		private readonly IAuthorsContract authorsContract;
		IMapper mapper;

		public AuthorsApplicationService(IAuthorsContract authorsContract, IMapper mapper)
		{
			this.authorsContract = authorsContract;
			this.mapper = mapper;
		}

		public async Task<List<Author>> GetAuthorByID(int id)
		{
			List<Author> authorsList = await authorsContract.GetAuthorByID(id);
			return authorsList;
		}
	}
}
