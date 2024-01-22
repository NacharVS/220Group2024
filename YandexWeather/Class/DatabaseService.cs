using Newtonsoft.Json.Linq;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexWeather.Class
{
    public class DatabaseService
    {
        private readonly string connectionString;

        public DatabaseService()
        {
            connectionString = "Host=localhost;Port=5432;Database=weather;Username=postgres;Password=Ramil2005r;";
        }

        public void SaveWeatherData(JObject weatherData)
        {
            string connectionString = "Host=localhost;Port=5432;Database=weather;Username=postgres;Password=Ramil2005r;";

            string commandText = "INSERT INTO weather_data (timestamp, temperature, humidity, wind_speed) VALUES (@timestamp, @temperature, @humidity, @wind_speed)";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@timestamp", NpgsqlDbType.Timestamp, DateTime.Now);
                    command.Parameters.AddWithValue("@temperature", NpgsqlDbType.Double, Convert.ToDouble(weatherData["fact"]["temp"]));
                    command.Parameters.AddWithValue("@humidity", NpgsqlDbType.Double, Convert.ToDouble(weatherData["fact"]["feels_like"]));
                    command.Parameters.AddWithValue("@wind_speed", NpgsqlDbType.Double, Convert.ToDouble(weatherData["fact"]["wind_speed"]));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
