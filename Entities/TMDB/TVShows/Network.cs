using Newtonsoft.Json;

namespace Entities.TMDB.TVShows
{
    public class Network
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("logo_path", NullValueHandling = NullValueHandling.Ignore)]
        public string LogoPath { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("origin_country", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginCountry { get; set; }
    }
}
