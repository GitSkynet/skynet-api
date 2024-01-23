using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TMDB.TVShows
{
    public class Season
    {
        [JsonProperty("air_date", NullValueHandling = NullValueHandling.Ignore)]
        public string AirDate { get; set; }

        [JsonProperty("episode_count", NullValueHandling = NullValueHandling.Ignore)]
        public int EpisodeCount { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("overview", NullValueHandling = NullValueHandling.Ignore)]
        public string Overview { get; set; }

        [JsonProperty("poster_path", NullValueHandling = NullValueHandling.Ignore)]
        public string PosterPath { get; set; }

        [JsonProperty("season_number", NullValueHandling = NullValueHandling.Ignore)]
        public int SeasonNumber { get; set; }
    }
}
