using Entities.Base;
using Newtonsoft.Json;

namespace Entities.PokeAPI.Pokemon
{
    public class Cries : EntityBase
    {
        [JsonProperty("latest", NullValueHandling = NullValueHandling.Ignore)]
        public string Latest { get; set; }

        [JsonProperty("legacy", NullValueHandling = NullValueHandling.Ignore)]
        public string Legacy { get; set; }
    }
}
