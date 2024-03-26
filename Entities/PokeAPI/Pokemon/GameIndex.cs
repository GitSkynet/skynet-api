using Entities.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.PokeAPI.Pokemon
{
    public class GameIndex : EntityBase
    {
        [JsonProperty("game_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? TheGameIndex { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public Version Version { get; set; }
    }
}
