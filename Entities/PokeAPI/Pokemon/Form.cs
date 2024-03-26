using Entities.Base;
using Newtonsoft.Json;

namespace Entities.PokeAPI.Pokemon
{
    public class Form : EntityBase
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }
}
