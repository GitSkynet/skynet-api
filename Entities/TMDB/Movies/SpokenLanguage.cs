using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.TMDB.Movies
{
    public class SpokenLanguage : BaseTMDB
	{
		[JsonProperty("id")]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

		[JsonProperty("english_name")]
        public string EnglishName { get; set; }

        [JsonProperty("iso_639_1")]
        public string Iso6391 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
		public List<MovieSpokenLanguage> MovieSpokenLanguages { get; set; }

		public List<Movie> Movies { get; set; }
	}
}
