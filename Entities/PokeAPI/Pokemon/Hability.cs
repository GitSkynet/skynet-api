using Entities.Base;
using Newtonsoft.Json;

namespace Entities.PokeAPI.Pokemon
{
    public class Hability : EntityBase
    {
        [JsonProperty("ability", NullValueHandling = NullValueHandling.Ignore)]
        public TheAbility Ability { get; set; }

        [JsonProperty("is_hidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHidden { get; set; }

        [JsonProperty("slot", NullValueHandling = NullValueHandling.Ignore)]
        public int? Slot { get; set; }
    }
}
