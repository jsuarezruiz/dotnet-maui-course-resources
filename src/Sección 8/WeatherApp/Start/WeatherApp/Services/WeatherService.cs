using Newtonsoft.Json;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public enum Units
    {
        Imperial,
        Metric
    }

    public class WeatherService
    {
        const string WeatherCoordinatesUri = "http://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&units={2}&appid={3}";
        const string WeatherCityUri = "http://api.openweathermap.org/data/2.5/weather?q={0}&units={1}&appid={2}";
        const string ForecaseUri = "http://api.openweathermap.org/data/2.5/forecast?id={0}&units={1}&appid={2}";

        private static WeatherService _instance;

        public static WeatherService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WeatherService();

                return _instance;
            }
        }

        public Task<WeatherRoot> GetWeatherAsync(double latitude, double longitude, Units units = Units.Imperial)
        {
            // TODO: Implementa la llamada al servicio para obtener la información meteorológica.
            throw new NotImplementedException();
        }

        public Task<WeatherRoot> GetWeatherAsync(string city, Units units = Units.Imperial)
        {
            // TODO: Implementa la llamada al servicio para obtener la información meteorológica.
            throw new NotImplementedException();
        }

        public Task<WeatherForecastRoot> GetForecast(int id, Units units = Units.Imperial)
        {
            // TODO: Implementa la llamada al servicio para obtener la información meteorológica.
            throw new NotImplementedException();
        }
    }
}