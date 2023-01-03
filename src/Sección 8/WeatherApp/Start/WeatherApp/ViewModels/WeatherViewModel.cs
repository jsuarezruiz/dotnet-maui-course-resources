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
            _reloadCommand ??= new Command(async () => await GetWeatherAsync());

        public Task GetWeatherAsync()
        {
            // TODO: Implementa la lógica para obtener la información meteorológica aquí.
            throw new NotImplementedException(); 
        }
    }
}