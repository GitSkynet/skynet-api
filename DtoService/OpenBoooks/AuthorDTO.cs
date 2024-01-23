using Entities.OpenBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoService.OpenBoooks
{
	public class AuthorDTO
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public DateTime Birthday { get; set; }

		public string Description { get; set; }

		public string ShortDescription { get; set; }

		public string Photo { get; set; }

		public List<BooksDTO> Books { get; set; }

	}
}
