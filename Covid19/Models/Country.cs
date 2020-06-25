using Newtonsoft.Json;
using System;

namespace Covid19.Models
{
    public class Country
    {
        [JsonProperty("Country")]
        public string Name { get; set; }

        [JsonProperty("Confirmed")]
        public int Confirmed { get; set; }

        [JsonProperty("Deaths")]
        public int Deaths { get; set; }

        [JsonProperty("Recovered")]
        public int Recovered { get; set; }

        [JsonProperty("Date")]
        public DateTime UpdateDate { get; set; }
    }
}
