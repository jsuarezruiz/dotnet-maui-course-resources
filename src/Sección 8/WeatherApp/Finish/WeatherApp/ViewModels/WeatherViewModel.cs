using System.Windows.Input;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class WeatherViewModel : BindableObject
    {
        bool _isBusy;
        string _temp;
        string _condition;
        WeatherForecastRoot _forecast;
        ICommand _reloadCommand;

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public string Temp
        {
            get { return _temp; }
            set
            {
                _temp = value;
                OnPropertyChanged();
            }
        }

        public string Condition
        {
            get { return _condition; }
            set
            {
                _condition = value;
                OnPropertyChanged();
            }
        }

        public WeatherForecastRoot Forecast
        {
            get { return _forecast; }
            set
            {
                _forecast = value;
                OnPropertyChanged();
            }
        }

        public ICommand ReloadCommand =>
            _reloadCommand ??
            (_reloadCommand = new Command(async () => await GetWeatherAsync()));

        public async Task GetWeatherAsync()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                var random = new Random();
                var cities = new List<string> { "Boston", "Seattle", "Sevilla", "Madrid" };
                int index = random.Next(cities.Count);

                WeatherRoot weatherRoot = null;
                var units = AppSettings.IsImperial ? Units.Imperial : Units.Metric;
                weatherRoot = await WeatherService.Instance.GetWeatherAsync(cities[index], units);
                Forecast = await WeatherService.Instance.GetForecast(weatherRoot.CityId, units);
                var unit = AppSettings.IsImperial ? "F" : "C";
                Temp = $"{weatherRoot?.MainWeather?.Temperature ?? 0}°{unit}";
                Condition = $"{weatherRoot.Name}: {weatherRoot?.Weather?[0]?.Description ?? string.Empty}";
            }
            catch (Exception)
            {
                Temp = "Unable to get Weather";
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}