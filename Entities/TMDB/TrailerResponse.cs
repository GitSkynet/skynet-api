using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TMDB
{
    public class TrailerResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("results")]
        public List<TrailerResult> Results { get; set; }
    }

    public class TrailerResult
    {
        [JsonProperty("iso_639_1")]
        public string Iso_639_1 { get; set; }

        [JsonProperty("iso_3166_1")]
        public string Iso_3166_1 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("site")]
        public string Site { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("official")]
        public bool Official { get; set; }

        [JsonProperty("published_at")]
        public DateTime Published_at { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
