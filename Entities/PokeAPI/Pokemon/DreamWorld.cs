using Entities.Base;
using Newtonsoft.Json;

namespace Entities.PokeAPI.Pokemon
{
    public class DreamWorld : EntityBase
    {
        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female", NullValueHandling = NullValueHandling.Ignore)]
        public object FrontFemale { get; set; }
    }
}
