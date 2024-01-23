using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TMDB.Movies
{
    public class ProductionCompany : BaseTMDB
	{
		[JsonProperty("id")]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

		[JsonProperty("logo_path", NullValueHandling = NullValueHandling.Ignore)]
        public string? LogoPath { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("origin_country", NullValueHandling = NullValueHandling.Ignore)]
        public string? OriginCountry { get; set; }

		public List<MovieProductionCompany>? MovieProductionCompanies { get; set; }

		public List<Movie>? Movies { get; set; }
	}
}
