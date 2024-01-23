using Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Entities.OpenBooks
{
    [DataContract]
    public class Book : EntityBase
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; }

        public int IdOpenlibra { get; set; }

        public int SubCategoryId { get; set; }

        public SubCategory SubCategories { get; set; }

        public int CategoryId { get; set; }

        public Category Categories { get; set; }

        public string Content { get; set; }

        public string Content_short { get; set; }

        public string Publisher { get; set; }

        public string PublisherDate { get; set; }

        public string Pages { get; set; }

        public string Language { get; set; }

        public string UrlDetails { get; set; }

        public string UrlDownload { get; set; }

        public string Cover { get; set; }

        public string Thumbnail { get; set; }

        public string NumComments { get; set; }

        public string Tags { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

		public List<Author> Authors { get; set; }

		public List<AuthorsBooks> AuthorsBooks { get; set; }
	}
}
