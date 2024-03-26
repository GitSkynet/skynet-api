using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.PokeAPI.Pokemon
{
    public class HeldItem
    {
        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public Item Item { get; set; }

        [JsonProperty("version_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<VersionDetail> VersionDetails { get; set; }
    }
}
