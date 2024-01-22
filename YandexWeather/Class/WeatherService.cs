using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexWeather.Class
{
    public class WeatherService
    {
        private readonly HttpClient client;
        private readonly string apiKey;

        public WeatherService()
        {
            client = new HttpClient();
            apiKey = "19fe6f14-aea0-4983-ad3c-f744af8c0560";
        }

        public async Task<JObject> GetWeatherAsync(string location)
        {
            string apiKey = "19fe6f14-aea0-4983-ad3c-f744af8c0560";
            string[] coordinates = location.Split(' ');

            if (coordinates.Length != 2)
            {
                Console.WriteLine("Location is not in the correct format.");
                return null;
            }

            string apiUrl = $"https://api.weather.yandex.ru/v2/forecast?lat={coordinates[0]}&lon={coordinates[1]}&lang=ru_RU&apikey={apiKey}";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Yandex-API-Key", apiKey);
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject weatherData = JObject.Parse(responseBody);
                return weatherData;
            }
        }
    }
}
