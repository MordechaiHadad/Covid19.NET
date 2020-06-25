using Newtonsoft.Json;
using System;

namespace Covid19.Models
{

    public class Latest
    {
        [JsonProperty("Global")]
        public Global Global { get; set; }

        [JsonProperty("Countries")]
        public LatestCountry[] Countries { get; set; }

        [JsonProperty("Date")]
        public DateTime UpdateDate { get; set; }
    }

    public class Global
    {
        [JsonProperty("NewConfirmed")]
        public int NewConfirmed { get; set; }

        [JsonProperty("TotalConfirmed")]
        public int TotalConfirmed { get; set; }

        [JsonProperty("NewDeaths")]
        public int NewDeaths { get; set; }

        [JsonProperty("TotalDeaths")]
        public int TotalDeaths { get; set; }

        [JsonProperty("NewRecovered")]
        public int NewRecovered { get; set; }

        [JsonProperty("TotalRecovered")]
        public int TotalRecovered { get; set; }
    }

    public class LatestCountry
    {
        [JsonProperty("Country")]
        public string Name { get; set; }

        [JsonProperty("CountryCode")]
        public string Code { get; set; }

        [JsonProperty("Slug")]
        public string Slug { get; set; }

        [JsonProperty("NewConfirmed")]
        public int NewConfirmed { get; set; }

        [JsonProperty("TotalConfirmed")]
        public int TotalConfirmed { get; set; }

        [JsonProperty("NewDeaths")]
        public int NewDeaths { get; set; }

        [JsonProperty("TotalDeaths")]
        public int TotalDeaths { get; set; }

        [JsonProperty("NewRecovered")]
        public int NewRecovered { get; set; }

        [JsonProperty("TotalRecovered")]
        public int TotalRecovered { get; set; }

        [JsonProperty("Date")]
        public DateTime UpdateDate { get; set; }
    }

}
