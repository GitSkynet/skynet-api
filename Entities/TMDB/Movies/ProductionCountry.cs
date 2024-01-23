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
    public class ProductionCountry : BaseTMDB
	{
		[JsonProperty("id")]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

		[JsonProperty("iso_3166_1")]
        public string Iso31661 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

		public List<MovieProductionCountry>? MovieProductionCountries { get; set; }

		public List<Movie>? Movies { get; set; }
	}

	public class CountriesTMDB : BaseTMDB
	{
		[JsonProperty("id")]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

		[JsonProperty("iso_3166_1")]
		public string Iso31661 { get; set; }

		[JsonProperty("native_name")]
		public string Name { get; set; }
	}
}
