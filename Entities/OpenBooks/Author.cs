using Entities.Base;

namespace Entities.OpenBooks
{
    public class Author : EntityBase
	{
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string Description { get; set; }

        public string ShortDescription { get; set; }

        public string Photo { get; set; }

		public List<Book> Books { get; set; }

		public List<AuthorsBooks> AuthorsBooks { get; set; }

	}
}
