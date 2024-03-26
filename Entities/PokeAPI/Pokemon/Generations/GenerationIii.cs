using Entities.Base;
using Newtonsoft.Json;

namespace Entities.PokeAPI.Pokemon.Generations
{
    public class GenerationIii : EntityBase
    {
        [JsonProperty("emerald", NullValueHandling = NullValueHandling.Ignore)]
        public Emerald Emerald { get; set; }

        [JsonProperty("firered-leafgreen", NullValueHandling = NullValueHandling.Ignore)]
        public FireredLeafgreen FireredLeafgreen { get; set; }

        [JsonProperty("ruby-sapphire", NullValueHandling = NullValueHandling.Ignore)]
        public RubySapphire RubySapphire { get; set; }
    }
}
