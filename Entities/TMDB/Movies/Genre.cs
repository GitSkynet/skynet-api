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

    public class Genre : BaseTMDB
	{
        [JsonProperty("id")]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public List<MoviesGenres> MoviesGenres { get; set; }
        
        public List<Movie> Movies { get; set; }
    }
}
