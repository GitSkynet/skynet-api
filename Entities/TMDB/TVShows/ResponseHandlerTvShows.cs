using Entities.TMDB.Movies;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TMDB.TVShows
{
    public class ResponseHandlerTvShows
    {
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public string? Page { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<TvShow>? TvShowsList { get; set; }

        [JsonProperty("total_pages", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalPages { get; set; }

        [JsonProperty("total_results", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalResults { get; set; }
    }
}
