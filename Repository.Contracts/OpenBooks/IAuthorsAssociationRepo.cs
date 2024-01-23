using Entities.OpenBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts.OpenBooks
{
	public interface IAuthorsAssociationRepo
	{
		Task<List<Author>> GetAuthorByID(int id);
	}
}
