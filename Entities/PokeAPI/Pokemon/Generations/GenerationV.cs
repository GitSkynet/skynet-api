using Entities.Base;
using Newtonsoft.Json;

namespace Entities.PokeAPI.Pokemon.Generations
{
    public class GenerationV : EntityBase
    {
        [JsonProperty("black-white", NullValueHandling = NullValueHandling.Ignore)]
        public BlackWhite BlackWhite { get; set; }
    }
}
