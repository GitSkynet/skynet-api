using Entities.Base;
using Newtonsoft.Json;

namespace Entities.PokeAPI.Pokemon.Generations
{
    public class GenerationI : EntityBase
    {
        [JsonProperty("red-blue", NullValueHandling = NullValueHandling.Ignore)]
        public RedBlue RedBlue { get; set; }

        [JsonProperty("yellow", NullValueHandling = NullValueHandling.Ignore)]
        public Yellow Yellow { get; set; }
    }
}
