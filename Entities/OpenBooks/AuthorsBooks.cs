using Entities.Base;

namespace Entities.OpenBooks
{
	public class AuthorsBooks : EntityBase
	{
		public int AuthorId { get; set; }
		public Author Authors { get; set; }

		public int BookId { get; set; }
		public Book Books { get; set; }
	}
}