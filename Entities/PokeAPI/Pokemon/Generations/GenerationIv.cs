using Entities.Base;
using Newtonsoft.Json;

namespace Entities.PokeAPI.Pokemon.Generations
{
    public class GenerationIv : EntityBase
    {
        [JsonProperty("diamond-pearl", NullValueHandling = NullValueHandling.Ignore)]
        public DiamondPearl DiamondPearl { get; set; }

        [JsonProperty("heartgold-soulsilver", NullValueHandling = NullValueHandling.Ignore)]
        public HeartgoldSoulsilver HeartgoldSoulsilver { get; set; }

        [JsonProperty("platinum", NullValueHandling = NullValueHandling.Ignore)]
        public Platinum Platinum { get; set; }
    }
}
