using Entities.Base;
using Newtonsoft.Json;

namespace Entities.PokeAPI.Pokemon.Generations
{
    public class GenerationViii : EntityBase
    {
        [JsonProperty("icons", NullValueHandling = NullValueHandling.Ignore)]
        public Icons Icons { get; set; }
    }
}
