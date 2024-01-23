using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TMDB.TVShows
{
    public class CreatedBy
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("credit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreditId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public int Gender { get; set; }

        [JsonProperty("profile_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfilePath { get; set; }
    }
}
