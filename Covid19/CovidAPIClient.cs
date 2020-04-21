using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Covid19.Classes;
using System.Linq;
using System.Collections.Generic;

namespace Covid19
{
    /// <summary>
    /// Represents a covid API client
    /// </summary>
    public class CovidAPIClient
    {
        private HttpClient _httpClient;
        private string _baseUrl = "https://api.covid19api.com";

        /// <summary>
        /// Initialize a new client
        /// </summary>
        public CovidAPIClient() 
            => _httpClient = new HttpClient();

        ~CovidAPIClient()
        {
            _httpClient.Dispose();
        }

        private async Task<T> RestGET<T>(string url) where T : class
        {
            var result = await _httpClient.GetAsync(url);
            if (result.IsSuccessStatusCode)
            {
                var response = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(response);
            }
            else
                return default;
        }

        /// <summary>
        /// Get latest stats from a country.
        /// </summary>
        public async Task<LatestCountry> GetLatestByCountryAsync(string countrySlug)
        {        
            var result = await RestGET<Latest>($"{_baseUrl}/summary");
            if (result != null)
            {
                var country = result.Countries.Where(x => x.Slug == countrySlug.ToLower()).FirstOrDefault();
                return country;
            }
            else
                return default;
        }

        /// <summary>
        /// Get latest stats
        /// </summary>
        public async Task<Latest> GetLatestAsync()
        {
            var result = await RestGET<Latest>($"{_baseUrl}/summary");
            if (result != null)
                return result;
            else
                return default;
        }

        /// <summary>
        /// Get all of the country's data
        /// </summary>
        public async Task<List<Country>> GetTotalCountryDataAsync(string countrySlug)
        {
            var result = await RestGET<List<Country>>($"{_baseUrl}/total/country/{countrySlug.ToLower()}");
            if (result != null)
                return result;
            else
                return default;
        }
    }
}
