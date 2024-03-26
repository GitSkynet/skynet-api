using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.PokeAPI.Pokemon
{
    public class Home
    {
        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShinyFemale { get; set; }
    }
}
