using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TMDB.TVShows
{
    public class LastEpisodeToAir
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("overview", NullValueHandling = NullValueHandling.Ignore)]
        public string Overview { get; set; }

        [JsonProperty("vote_average", NullValueHandling = NullValueHandling.Ignore)]
        public double VoteAverage { get; set; }

        [JsonProperty("vote_count", NullValueHandling = NullValueHandling.Ignore)]
        public int VoteCount { get; set; }

        [JsonProperty("air_date", NullValueHandling = NullValueHandling.Ignore)]
        public string AirDate { get; set; }

        [JsonProperty("episode_number", NullValueHandling = NullValueHandling.Ignore)]
        public int EpisodeNumber { get; set; }

        [JsonProperty("production_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductionCode { get; set; }

        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public int Runtime { get; set; }

        [JsonProperty("season_number", NullValueHandling = NullValueHandling.Ignore)]
        public int SeasonNumber { get; set; }

        [JsonProperty("show_id", NullValueHandling = NullValueHandling.Ignore)]
        public int ShowId { get; set; }

        [JsonProperty("still_path", NullValueHandling = NullValueHandling.Ignore)]
        public string StillPath { get; set; }
    }
}
