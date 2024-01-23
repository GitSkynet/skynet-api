using Entities.Base;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Entities.OpenBooks
{
    public class Category : EntityBase
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty(PropertyName = "category_id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "nicename")]
        public string NiceName { get; set; }

        public string? Description { get; set; }

        public string? Short_desc { get; set; }

        public string? Icon { get; set; }

        public string Background { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

        public int SubCategoryId { get; set; }

        public ICollection<SubCategory> Subcategories { get; set; }
    }
}
