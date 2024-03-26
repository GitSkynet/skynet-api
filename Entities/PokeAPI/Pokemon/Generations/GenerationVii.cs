using Entities.Base;
using Newtonsoft.Json;

namespace Entities.PokeAPI.Pokemon.Generations
{
    public class GenerationVii : EntityBase
    {
        [JsonProperty("icons", NullValueHandling = NullValueHandling.Ignore)]
        public Icons Icons { get; set; }

        [JsonProperty("ultra-sun-ultra-moon", NullValueHandling = NullValueHandling.Ignore)]
        public UltraSunUltraMoon UltraSunUltraMoon { get; set; }
    }
}
