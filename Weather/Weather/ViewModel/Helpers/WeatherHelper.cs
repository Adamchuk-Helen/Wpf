using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;
using Newtonsoft.Json;

namespace Weather.ViewModel.Helpers
{
    public static class WeatherHelper
    {
        public const string BASE_URL = "http://dataservice.accuweather.com/";
        public const string API_KEY = "1bNcTzrF0TTVVX3SmSTUJMkOZG8qc9SQ";
        public const string AUTOCOMPLIT_ENDPOINT = "locations/v1/cities/autocomplete?apikey={0}&q={1}";
        public const string CURRENTCONDITION_ENDPOINT = "currentconditions/v1/{0}?apikey={1}";
        public const string FIVE_DAYS_ENDPOINT = "forecasts / v1 / daily / 5day/{0}?apikey={1}";

        public static async Task<List<City>> GetCitiesAsynk(string query)
        {
            var cities = new List<City>();
            var url = BASE_URL + String.Format(AUTOCOMPLIT_ENDPOINT,  API_KEY, query);
            using (var client = new HttpClient())
            {
                var responce = await client.GetAsync(url);
                string json = await responce.Content.ReadAsStringAsync();
                cities = JsonConvert.DeserializeObject<List<City>>(json);
            }
            return cities;
        }

        public static async Task<CurrentConditions> GetCurrentConditionsAsynk(string locationKey)
        {
            var currentConditions = new List<CurrentConditions>();
            currentConditions.Clear();
            var url = BASE_URL + String.Format(CURRENTCONDITION_ENDPOINT, locationKey, API_KEY);
            using (var client = new HttpClient())
            {
                var responce = await client.GetAsync(url);
                var json = await responce.Content.ReadAsStringAsync();
                currentConditions = JsonConvert.DeserializeObject<List<CurrentConditions>>(json);
            }
            return currentConditions.FirstOrDefault();
        }

        public static async Task<FiveDaysWeather> GetFiveDaysWeatherAsynk(string locationKey)
        {

            var fiveDaysWeather = new List<FiveDaysWeather>();
            fiveDaysWeather.Clear();
            var url = BASE_URL + String.Format(FIVE_DAYS_ENDPOINT, locationKey, API_KEY);
            using (var client = new HttpClient())
            {
                var responce = await client.GetAsync(url);
                var json = await responce.Content.ReadAsStringAsync();
                fiveDaysWeather = JsonConvert.DeserializeObject<List<FiveDaysWeather>>(json);
            }
            return fiveDaysWeather.FirstOrDefault();
        }
    }
}
