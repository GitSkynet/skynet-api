using Entities.Base;
using Newtonsoft.Json;

namespace Entities.PokeAPI.Pokemon.Generations
{
    public class GenerationVi : EntityBase
    {
        [JsonProperty("omegaruby-alphasapphire", NullValueHandling = NullValueHandling.Ignore)]
        public OmegarubyAlphasapphire OmegarubyAlphasapphire { get; set; }

        [JsonProperty("x-y", NullValueHandling = NullValueHandling.Ignore)]
        public XY XY { get; set; }
    }
}
