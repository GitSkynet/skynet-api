using Entities.Base;
using Newtonsoft.Json;

namespace Entities.PokeAPI.Pokemon.Generations
{
    public class GenerationIi : EntityBase
    {
        [JsonProperty("crystal", NullValueHandling = NullValueHandling.Ignore)]
        public Crystal Crystal { get; set; }

        [JsonProperty("gold", NullValueHandling = NullValueHandling.Ignore)]
        public Gold Gold { get; set; }

        [JsonProperty("silver", NullValueHandling = NullValueHandling.Ignore)]
        public Silver Silver { get; set; }
    }
}
