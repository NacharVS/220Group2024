using Newtonsoft.Json.Linq;
using Npgsql;
using NpgsqlTypes;
using System.Data.SqlClient;
using YandexWeather.Class;

namespace YandexWeather
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var weatherService = new WeatherService();
            var databaseService = new DatabaseService();

            while (true)
            {
                Console.WriteLine("Введите координаты населенного пункта:");
                Console.WriteLine("Пример: 55.79 49.13");
                string location = Console.ReadLine();
                var weather = await weatherService.GetWeatherAsync(location);
                if (weather != null)
                {
                    databaseService.SaveWeatherData(weather);
                }
                else
                {
                    Console.WriteLine("Данные о погоде не получены.");
                }
                Console.WriteLine("Ждем 10 минут перед следующим запросом.");
                await Task.Delay(10 * 60 * 1000); // 10 минут
            }
        }
    }
}