using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.PokeAPI.Pokemon
{
    public class Move
    {
        [JsonProperty("move", NullValueHandling = NullValueHandling.Ignore)]
        public Move TheMove { get; set; }

        [JsonProperty("version_group_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<VersionGroupDetail> VersionGroupDetails { get; set; }
    }
}
