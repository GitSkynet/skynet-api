using AutoMapper;
using DomainService.Contracts.OpenBooks;
using DtoService.OpenBoooks;
using Entities.OpenBooks;
using Repository.Contracts.OpenBooks;

namespace DomainService.Services.OpenBooks
{
	public class AuthorService : IAuthorsContract
	{
		private readonly IAuthorsAssociationRepo authorsRepo;
		IMapper mapper;

		public AuthorService(IAuthorsAssociationRepo repository, IMapper mapper)
		{
			authorsRepo = repository;
			this.mapper = mapper;
		}

		public async Task<List<Author>> GetAuthorByID(int id)
		{
			List<Author> books = await authorsRepo.GetAuthorByID(id);
			var booksMapped = mapper.Map<List<AuthorDTO>>(books);
			return books;
		}
	}
}