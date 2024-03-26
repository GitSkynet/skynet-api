using Entities.Base;
using Newtonsoft.Json;

namespace Entities.PokeAPI.Pokemon
{
    public class FireredLeafgreen : EntityBase
    {
        [JsonProperty("back_default", NullValueHandling = NullValueHandling.Ignore)]
        public string BackDefault { get; set; }

        [JsonProperty("back_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShiny { get; set; }

        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }
    }
}
