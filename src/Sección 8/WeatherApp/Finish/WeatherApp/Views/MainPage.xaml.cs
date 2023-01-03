using WeatherApp.ViewModels;

namespace WeatherApp.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = new WeatherViewModel();
    }

    protected override async void OnAppearing()
    {
        if (BindingContext is WeatherViewModel)
        {
            await ((WeatherViewModel)BindingContext).GetWeatherAsync();
        }

        base.OnAppearing();
    }
}