using System.Globalization;

namespace WeatherApp.Converters
{
    public class BackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            var condition = value.ToString();

            if (condition.Contains("cloud") || condition.Contains("haze"))
                return "clouds_background.jpg";
            else if (condition.Contains("rain"))
                return "rain_background.jpg";
            else if (condition.Contains("sun") || condition.Contains("clear sky"))
                return "sun_background.jpg";
            else
                return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}