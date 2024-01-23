using Entities.OpenBooks;

namespace DtoService.OpenBoooks
{

    public class BookMinimal
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string ContentShort { get; set; }

        public string Cover { get; set; }

        public string Publisher { get; set; }
    }

    public class BooksDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string CategoryID { get; set; }

        public string SubcategoryID { get; set; }

        public List<AuthorDTO> Authors { get; set; }

        public string Content { get; set; }

        public string ContentShort { get; set; }

        public string Publisher { get; set; }

        public string PublisherDate { get; set; }

        public string Pages { get; set; }

        public string Language { get; set; }

        public string URLDetails { get; set; }

        public string URLDownload { get; set; }

        public string Cover { get; set; }

        public string Thumbnail { get; set; }

        public string NumComments { get; set; }

        public string Tags { get; set; }

        public CategoriesDTO Categories { get; set; }

        public SubCategoriesDTO SubCategories { get; set; }

    }
}
