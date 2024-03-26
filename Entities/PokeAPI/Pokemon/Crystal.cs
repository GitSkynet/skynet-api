using Entities.Base;
using Newtonsoft.Json;

namespace Entities.PokeAPI.Pokemon
{
    public class Crystal : EntityBase
    {
        [JsonProperty("back_default", NullValueHandling = NullValueHandling.Ignore)]
        public string BackDefault { get; set; }

        [JsonProperty("back_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShinyTransparent { get; set; }

        [JsonProperty("back_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public string BackTransparent { get; set; }

        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShinyTransparent { get; set; }

        [JsonProperty("front_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontTransparent { get; set; }
    }
}
