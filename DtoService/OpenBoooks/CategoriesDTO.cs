namespace DtoService.OpenBoooks
{
    public class CategoriesDTO
    {
        public int ID { get; set; }

        public string name { get; set; }

        public string niceName { get; set; }

        public string? description { get; set; }

        public string? SubCategoryId { get; set; }

        public string? short_desc { get; set; }

        public string icon { get; set; }

        public string background { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

        public List<SubCategoriesDTO> SubCategories { get; set; }
    }
}
